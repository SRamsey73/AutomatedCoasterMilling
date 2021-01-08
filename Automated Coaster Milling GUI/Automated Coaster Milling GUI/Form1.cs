using System;
using System.IO;
using System.Threading;
using System.IO.Ports;
using Timer = System.Timers.Timer;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_Coaster_Milling_GUI
{
    public partial class Form1 : Form
    {
        //----------Robot Variables----------------------------------------------------------------
        int[] posistionArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        const int home = 0;
        const int aboveVice = 5;
        const int vice = 10;
        const int abovePickup = 15;
        const int pickup = 20;
        int selectedPosistion;
        //----------Data File Editing--------------------------------------------------------------
        string dataFilePath = @"H:\Automated Coaster Milling\GUI\Automated Coaster Milling GUI\Data.txt";
        //----------Receive Variables--------------------------------------------------------------
        char[] incomingChar = new char[5];
        int[] incomingData = new int[255];
        int[] incomingInt = new int[5];
        int[] receiveData = new int[2];
        int expectedValue = 0;
        int receiveSign;
        int receiveLength;
        int bytesReceived = 0;
        int errorCount = 0;
        //----------Interactive Objects-----------------------------------------------------------
        int posistionDropState = 0;
        int comDropState = 0;
        int baudDropState = 0;
        int viceState = 0;
        int clawTarget = 0;
        int buttonHeld = 0;
        int portIsOpen = 0;
        int clawState = 0;
        string valueBeforeChange;
        Timer holdTimer = new Timer();
        //----------Delegates---------------------------------------------------------------------
        delegate void SetTextCallback(string text);
        private void SetRotationE(string text)
        {
            if (this.rotationE.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetRotationE);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rotationE.Text = text;
            }
        }
        private void SetMainArmE(string text)
        {
            if (this.mainArmE.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetMainArmE);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.mainArmE.Text = text;
            }
        }
        private void SetSecondaryArmE(string text)
        {
            if (this.secondaryArmE.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetSecondaryArmE);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.secondaryArmE.Text = text;
            }
        }
        private void SetEffectorYawE(string text)
        {
            if (this.effectorYawE.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetEffectorYawE);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.effectorYawE.Text = text;
            }
        }
        private void SetEffectorPitchE(string text)
        {
            if (this.effectorPitchE.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetEffectorPitchE);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.effectorPitchE.Text = text;
            }
        }
        //----------Serial Send Data-----------------------------------------------------------
        private void togglePosistionDrop()
        {
            if (posistionDropState == 0)
            {
                posistionDropButton.BackColor = Color.FromArgb(68, 87, 153);
                homePosistion.Visible = true;
                //Thread.Sleep(50);
                aboveVicePosistion.Visible = true;
                //Thread.Sleep(50);
                vicePosistion.Visible = true;
                //Thread.Sleep(50);
                abovePickupPosistion.Visible = true;
                //Thread.Sleep(50);
                pickupPosistion.Visible = true;
                //Thread.Sleep(50);
                posistionDropState = 1;
            }
            else
            {
                posistionDropButton.BackColor = Color.FromArgb(86, 111, 191);
                pickupPosistion.Visible = false;
                Thread.Sleep(10);
                abovePickupPosistion.Visible = false;
                Thread.Sleep(10);
                vicePosistion.Visible = false;
                Thread.Sleep(10);
                aboveVicePosistion.Visible = false;
                Thread.Sleep(10);
                homePosistion.Visible = false;
                Thread.Sleep(10);
                posistionDropState = 0;
            }
        }
        private void sendSerial(int destination, int meaning, double data)
        {
            int sign;
            int length;
            byte[] charsToWrite = new byte[5];
            if (data < 0)
            {
                sign = 10;
            }
            else
            {
                sign = 20;
            }
            data = Math.Abs(data);
            if (data == 0)
            {
                length = 1;
            }
            else if (data > 100000)
            {
                length = 3;
            }
            else
            {
                length = Convert.ToInt32((Math.Floor(Math.Log10(data) / 2) + 1));
            }
            charsToWrite[0] = Convert.ToByte(length + sign);
            data = Math.Abs(data);
            charsToWrite[1] = Convert.ToByte(meaning);
            charsToWrite[4] = Convert.ToByte(Convert.ToInt32(Math.Truncate(data / 10000)));
            charsToWrite[3] = Convert.ToByte(Convert.ToInt32(Math.Truncate((data - Math.Truncate(data / 10000) * 10000) / 100)));
            charsToWrite[2] = Convert.ToByte(Convert.ToInt32(data - (data - Convert.ToInt32(Math.Truncate(data / 10000) * 10000) - Convert.ToInt32(Math.Truncate((data - (Math.Truncate(data / 10000)) * 10000) - (Math.Truncate(data / 100)) * 100)))));
            try
            {
                serialPort1.Write(charsToWrite, 0, length + 2);
            }
            catch(Exception e)
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //----------Button Interactions-----------------------------------------------------------------------------------------------
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesRead = 1;
            receiveSign = 1;
            Array.Clear(incomingData, 0, 255);
            while (true)
            {
                if (serialPort1.BytesToRead > 0)
                {
                    incomingData[0] = serialPort1.ReadByte();
                    if (incomingData[0] == 254)
                    {
                        break;
                    }
                }
            }
            while (true)
            {
                if (serialPort1.BytesToRead > 0)
                {
                    incomingData[bytesRead] = serialPort1.ReadByte();
                    if (incomingData[bytesRead] == 255)
                    {
                        break;
                    }
                    /*if (bytesRead > 6)
                    {
                        Array.Clear(incomingData, 0, 255);
                        return;
                    }*/
                    bytesRead++;
                }
            }
            if (bytesRead != 5)
            {
                return;
            }
                if (incomingData[2] > 100)
                {
                    incomingData[2] = incomingData[2] - 100;
                    receiveSign = -1;
                }
                receiveData[0] = incomingData[1];
            receiveData[1] = receiveSign * (incomingData[4] * 10000 + incomingData[3] * 100 + incomingData[2]);
            //SetErrorText(receiveData[0] + "\r\n" + receiveData[1]);
            if (expectedValue != receiveData[1])
            {
                errorCount++;
            }
            expectedValue++;
            switch (receiveData[0])
            {
                case 0:
                    SetRotationE(receiveData[1].ToString());
                    break;
                case 1:
                    SetMainArmE(receiveData[1].ToString());
                    break;
                case 2:
                    SetSecondaryArmE(receiveData[1].ToString());
                    break;
                case 3:
                    SetEffectorYawE(receiveData[1].ToString());
                    break;
                case 4:
                    SetEffectorPitchE(receiveData[1].ToString());
                    break;
            }
        }
        private void rotationDown_Click(object sender, EventArgs e)
        {
            sendSerial(3, 0, 0);
            rotationDown.Top -= 3;
        }

        private void rotationUp_Click(object sender, EventArgs e)
        {
            sendSerial(3, 0, 0);
            rotationUp.Top -= 3;
        }

        private void rotationDown_MouseDown(object sender, MouseEventArgs e)
        {
            sendSerial(3, 0, -Convert.ToInt32(speedText.Text));
            rotationDown.Top += 3;
        }

        private void rotationUp_MouseDown(object sender, MouseEventArgs e)
        {
            sendSerial(3, 0, Convert.ToInt32(speedText.Text));
            rotationUp.Top += 3;
        }

        private void mainArmUp_Click(object sender, EventArgs e)
        {
            sendSerial(3, 1, 0);
            mainArmUp.Top -= 3;

        }

        private void mainArmUp_MouseDown_1(object sender, MouseEventArgs e)
        {
            sendSerial(3, 1, Convert.ToInt32(speedText.Text));
            mainArmUp.Top += 3;
        }

        private void secondaryArmUp_Click(object sender, EventArgs e)
        {
            sendSerial(3, 2, 0);
            secondaryArmUp.Top -= 3;
        }

        private void secondaryArmUp_MouseDown(object sender, MouseEventArgs e)
        {
            sendSerial(3, 2, Convert.ToInt32(speedText.Text));
            secondaryArmUp.Top += 3;
        }

        private void effectorYawUp_Click(object sender, EventArgs e)
        {
            sendSerial(3, 3, 0);
            effectorYawUp.Top -= 3;
        }

        private void effectorYawUp_MouseDown(object sender, MouseEventArgs e)
        {
            sendSerial(3, 3, Convert.ToInt32(speedText.Text));
            effectorYawUp.Top += 3;
        }

        private void effectorPitchUp_Click(object sender, EventArgs e)
        {
            sendSerial(3, 4, 0);
            effectorPitchUp.Top -= 3;
        }

        private void effectorPitchUp_MouseDown(object sender, MouseEventArgs e)
        {
            sendSerial(3, 4, Convert.ToInt32(speedText.Text));
            effectorPitchUp.Top += 3;
        }

        private void mainArmDown_Click(object sender, EventArgs e)
        {
            sendSerial(3, 1, 0);
            mainArmDown.Top -= 3;
        }

        private void mainArmDown_MouseDown_1(object sender, MouseEventArgs e)
        {
            sendSerial(3, 1, -Convert.ToInt32(speedText.Text));
            mainArmDown.Top += 3;
        }

        private void secondaryArmDown_Click(object sender, EventArgs e)
        {
            sendSerial(3, 2, 0);
            secondaryArmDown.Top -= 3;
        }

        private void secondaryArmDown_MouseDown(object sender, MouseEventArgs e)
        {
            sendSerial(3, 2, -Convert.ToInt32(speedText.Text));
            secondaryArmDown.Top += 3;
        }

        private void effectorYawDown_Click(object sender, EventArgs e)
        {
            sendSerial(3, 3, 0);
            effectorYawDown.Top -= 3;
        }

        private void effectorYawDown_MouseDown(object sender, MouseEventArgs e)
        {
            sendSerial(3, 3, -Convert.ToInt32(speedText.Text));
            effectorYawDown.Top += 3;
        }

        private void effectorPitchDown_Click(object sender, EventArgs e)
        {
            sendSerial(3, 4, 0);
            effectorPitchDown.Top -= 3;
        }

        private void effectorPitchDown_MouseDown(object sender, MouseEventArgs e)
        {
            sendSerial(3, 4, -Convert.ToInt32(speedText.Text));
            effectorPitchDown.Top += 3;
        }

        private void posistionDropButton_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void posistionDropButton_Click(object sender, EventArgs e)
        {
            togglePosistionDrop();
        }

        private void rotationPosistion_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dataFilePath);
            string line;
            line = sr.ReadLine();
            string[] dividedPosistions = line.Split(',');
            int[] posistionData = new int[4];
            posistionSelect.Text = "Home";
            homePosistion.BackColor = Color.FromArgb(35, 35, 35);
            togglePosistionDrop();
            homePosistion.BackColor = Color.FromArgb(46, 47, 49);
            rotationP.Text = dividedPosistions[0];
            mainArmP.Text = dividedPosistions[1];
            secondaryArmP.Text = dividedPosistions[2];
            effectorYawP.Text = dividedPosistions[3];
            effectorPitchP.Text = dividedPosistions[4];
        }
        private void homePosistion_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dataFilePath);
            string line;
            line = sr.ReadLine();
            string[] dividedPosistions = line.Split(',');
            int[] posistionData = new int[5];
            posistionSelect.Text = "Home";
            homePosistion.BackColor = Color.FromArgb(35, 35, 35);
            togglePosistionDrop();
            homePosistion.BackColor = Color.FromArgb(46, 47, 49);
            rotationP.Text = dividedPosistions[0];
            mainArmP.Text = dividedPosistions[1];
            secondaryArmP.Text = dividedPosistions[2];
            effectorYawP.Text = dividedPosistions[3];
            effectorPitchP.Text = dividedPosistions[4];
        }

        private void aboveVicePosistion_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dataFilePath);
            string line;
            line = sr.ReadLine();
            line = sr.ReadLine();
            string[] dividedPosistions = line.Split(',');
            int[] posistionData = new int[4];
            posistionSelect.Text = "Above Vice";
            aboveVicePosistion.BackColor = Color.FromArgb(35, 35, 35);
            togglePosistionDrop();
            aboveVicePosistion.BackColor = Color.FromArgb(46, 47, 49);
            rotationP.Text = dividedPosistions[0];
            mainArmP.Text = dividedPosistions[1];
            secondaryArmP.Text = dividedPosistions[2];
            effectorYawP.Text = dividedPosistions[3];
            effectorPitchP.Text = dividedPosistions[4];
        }

        private void vicePosistion_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dataFilePath);
            string line;
            line = sr.ReadLine();
            line = sr.ReadLine();
            line = sr.ReadLine();
            string[] dividedPosistions = line.Split(',');
            int[] posistionData = new int[4];
            posistionSelect.Text = "Vice";
            vicePosistion.BackColor = Color.FromArgb(35, 35, 35);
            togglePosistionDrop();
            vicePosistion.BackColor = Color.FromArgb(46, 47, 49);
            rotationP.Text = dividedPosistions[0];
            mainArmP.Text = dividedPosistions[1];
            secondaryArmP.Text = dividedPosistions[2];
            effectorYawP.Text = dividedPosistions[3];
            effectorPitchP.Text = dividedPosistions[4];
        }

        private void abovePickupPosistion_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dataFilePath);
            string line;
            line = sr.ReadLine();
            line = sr.ReadLine();
            line = sr.ReadLine();
            line = sr.ReadLine();
            string[] dividedPosistions = line.Split(',');
            int[] posistionData = new int[4];
            posistionSelect.Text = "Above Pickup";
            abovePickupPosistion.BackColor = Color.FromArgb(35, 35, 35);
            togglePosistionDrop();
            abovePickupPosistion.BackColor = Color.FromArgb(46, 47, 49);
            rotationP.Text = dividedPosistions[0];
            mainArmP.Text = dividedPosistions[1];
            secondaryArmP.Text = dividedPosistions[2];
            effectorYawP.Text = dividedPosistions[3];
            effectorPitchP.Text = dividedPosistions[4];
        }

        private void pickupPosistion_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dataFilePath);
            string line;
            line = sr.ReadLine();
            line = sr.ReadLine();
            line = sr.ReadLine();
            line = sr.ReadLine();
            line = sr.ReadLine();
            string[] dividedPosistions = line.Split(',');
            int[] posistionData = new int[4];
            posistionSelect.Text = "Pickup";
            pickupPosistion.BackColor = Color.FromArgb(35, 35, 35);
            togglePosistionDrop();
            pickupPosistion.BackColor = Color.FromArgb(46, 47, 49);
            rotationP.Text = dividedPosistions[0];
            mainArmP.Text = dividedPosistions[1];
            secondaryArmP.Text = dividedPosistions[2];
            effectorYawP.Text = dividedPosistions[3];
            effectorPitchP.Text = dividedPosistions[4];
        }

        private void recordPosistion_Click(object sender, EventArgs e)
        {
            recordPosistion.Top -= 3;
            rotationP.Text = rotationE.Text;
            mainArmP.Text = mainArmE.Text;
            secondaryArmP.Text = secondaryArmE.Text;
            effectorYawP.Text = effectorYawE.Text;
            effectorPitchP.Text = effectorPitchE.Text;
            /*sendSerial(3, 5, Convert.ToDouble(mainArmP.Text));
            sendSerial(3, 5, Convert.ToDouble(secondaryArmP.Text));
            sendSerial(3, 5, Convert.ToDouble(effectorYawP.Text));
            sendSerial(3, 5, Convert.ToDouble(effectorPitchP.Text));*/
            try
            {
                using (StreamWriter sw = File.CreateText(dataFilePath))
                {
                    if (posistionSelect.Text == "Home")
                    {
                        selectedPosistion = 0;
                    }
                    else if (posistionSelect.Text == "Above Vice")
                    {
                        selectedPosistion = 1;
                    }
                    else if (posistionSelect.Text == "Vice")
                    {
                        selectedPosistion = 2;
                    }
                    else if (posistionSelect.Text == "Above Pickup")
                    {
                        selectedPosistion = 3;
                    }
                    else if (posistionSelect.Text == "Pickup")
                    {
                        selectedPosistion = 4;
                    }
                    sendSerial(3, selectedPosistion + 5, Convert.ToInt32(rotationE.Text));
                    sendSerial(3, selectedPosistion + 5, Convert.ToInt32(mainArmE.Text));
                    sendSerial(3, selectedPosistion + 5, Convert.ToInt32(secondaryArmE.Text));
                    sendSerial(3, selectedPosistion + 5, Convert.ToInt32(effectorYawE.Text));
                    sendSerial(3, selectedPosistion + 5, Convert.ToInt32(effectorPitchE.Text));
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == selectedPosistion)
                        {
                            sw.WriteLine(rotationE.Text + "," + mainArmE.Text + "," + secondaryArmE.Text + "," + effectorYawE.Text + "," + effectorPitchE.Text);
                            posistionArray[selectedPosistion * 5] = Convert.ToInt32(rotationE.Text);
                            posistionArray[selectedPosistion * 5 + 1] = Convert.ToInt32(mainArmE.Text);
                            posistionArray[selectedPosistion * 5 + 2] = Convert.ToInt32(secondaryArmE.Text);
                            posistionArray[selectedPosistion * 5 + 3] = Convert.ToInt32(effectorYawE.Text);
                            posistionArray[selectedPosistion * 5 + 4] = Convert.ToInt32(effectorPitchE.Text);
                            if (i == 4)
                            {
                                break;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        sw.WriteLine(posistionArray[0 + i * 5] + "," + posistionArray[1 + i * 5] + "," + posistionArray[2 + i * 5] + "," + posistionArray[3 + i * 5] + "," + posistionArray[4 + i * 5]);
                    }
                }
            }
            
            catch(Exception)
            {
                    Thread.Sleep(3000);
                    using (StreamWriter sw = File.CreateText(dataFilePath))
                    {
                        if (posistionSelect.Text == "Home")
                        {
                            selectedPosistion = 0;
                        }
                        else if (posistionSelect.Text == "Above Vice")
                        {
                            selectedPosistion = 1;
                        }
                        else if (posistionSelect.Text == "Vice")
                        {
                            selectedPosistion = 2;
                        }
                        else if (posistionSelect.Text == "Above Pickup")
                        {
                            selectedPosistion = 3;
                        }
                        else if (posistionSelect.Text == "Pickup")
                        {
                            selectedPosistion = 4;
                        }
                        sendSerial(3, selectedPosistion + 5, Convert.ToInt32(rotationE.Text));
                        sendSerial(3, selectedPosistion + 5, Convert.ToInt32(mainArmE.Text));
                        sendSerial(3, selectedPosistion + 5, Convert.ToInt32(secondaryArmE.Text));
                        sendSerial(3, selectedPosistion + 5, Convert.ToInt32(effectorYawE.Text));
                        sendSerial(3, selectedPosistion + 5, Convert.ToInt32(effectorPitchE.Text));
                        for (int i = 0; i < 5; i++)
                        {
                            if (i == selectedPosistion)
                            {
                                sw.WriteLine(rotationE.Text + "," + mainArmE.Text + "," + secondaryArmE.Text + "," + effectorYawE.Text + "," + effectorPitchE.Text);
                                posistionArray[selectedPosistion * 5] = Convert.ToInt32(rotationE.Text);
                                posistionArray[selectedPosistion * 5 + 1] = Convert.ToInt32(mainArmE.Text);
                                posistionArray[selectedPosistion * 5 + 2] = Convert.ToInt32(secondaryArmE.Text);
                                posistionArray[selectedPosistion * 5 + 3] = Convert.ToInt32(effectorYawE.Text);
                                posistionArray[selectedPosistion * 5 + 4] = Convert.ToInt32(effectorPitchE.Text);
                                if (i == 4)
                                {
                                    break;
                                }
                                else
                                {
                                    i++;
                                }
                            }
                            sw.WriteLine(posistionArray[0 + i * 5] + "," + posistionArray[1 + i * 5] + "," + posistionArray[2 + i * 5] + "," + posistionArray[3 + i * 5] + "," + posistionArray[4 + i * 5]);
                        }
                    }
            }
        }
        

        private void recordPosistion_MouseDown(object sender, MouseEventArgs e)
        {
            recordPosistion.Top += 3;
        }

        private void moveToPosistion_Click(object sender, EventArgs e)
        {
            moveToPosistion.Top -= 3;
            sendSerial(3, 21, Convert.ToInt32(speedText.Text));
            sendSerial(3, 21, Convert.ToInt32(rotationP.Text));
            sendSerial(3, 21, Convert.ToInt32(mainArmP.Text));
            sendSerial(3, 21, Convert.ToInt32(secondaryArmP.Text));
            sendSerial(3, 21, Convert.ToInt32(effectorYawP.Text));
            sendSerial(3, 21, Convert.ToInt32(effectorPitchP.Text));
        }

        private void moveToPosistion_MouseDown(object sender, MouseEventArgs e)
        {
            moveToPosistion.Top += 3;
        }

        private void speedUp_Click(object sender, EventArgs e)
        {
            speedUp.Top -= 3;
            if (Convert.ToInt32(speedText.Text) < 127)
            {
                speedText.Text = (Convert.ToInt32(speedText.Text) + 1).ToString();
            }
        }

        private void speedUp_MouseDown(object sender, MouseEventArgs e)
        {
            speedUp.Top += 3;
        }

        private void speedDown_Click(object sender, EventArgs e)
        {
            speedDown.Top -= 3;
            if (Convert.ToInt32(speedText.Text) > 0)
            {
                speedText.Text = (Convert.ToInt32(speedText.Text) - 1).ToString();
            }
        }

        private void speedDown_MouseDown(object sender, MouseEventArgs e)
        {
            speedDown.Top += 3;
        }

        private void rotationP_Click(object sender, EventArgs e)
        {
            valueBeforeChange = rotationP.Text;
            rotationP.Clear();
        }

        private void rotationP_Leave(object sender, EventArgs e)
        {
            if (rotationP.Text == "")
            {
                rotationP.Text = valueBeforeChange;
            }
        }

        private void mainArmP_Click(object sender, EventArgs e)
        {
            valueBeforeChange = mainArmP.Text;
            mainArmP.Clear();
        }

        private void mainArmP_Leave(object sender, EventArgs e)
        {
            if (mainArmP.Text == "")
            {
                mainArmP.Text = valueBeforeChange;
            }
        }

        private void secondaryArmP_Click(object sender, EventArgs e)
        {
            valueBeforeChange = secondaryArmP.Text;
            secondaryArmP.Clear();
        }

        private void secondaryArmP_Leave(object sender, EventArgs e)
        {
            if (secondaryArmP.Text == "")
            {
                secondaryArmP.Text = valueBeforeChange;
            }
        }

        private void effectorYawP_Click(object sender, EventArgs e)
        {
            valueBeforeChange = effectorYawP.Text;
            effectorYawP.Clear();
        }

        private void effectorYawP_Leave(object sender, EventArgs e)
        {
            if (effectorYawP.Text == "")
            {
                effectorYawP.Text = valueBeforeChange;
            }
        }

        private void effectorPitchP_Click(object sender, EventArgs e)
        {
            valueBeforeChange = effectorPitchP.Text;
            effectorPitchP.Clear();
        }

        private void effectorPitchP_Leave(object sender, EventArgs e)
        {
            if (effectorPitchP.Text == "")
            {
                effectorPitchP.Text = valueBeforeChange;
            }
        }

        private void posistionSelect_Click_1(object sender, EventArgs e)
        {
            if (posistionSelect.Text == "Home")
            {
                selectedPosistion = 0;
            }
            else if (posistionSelect.Text == "Above Vice")
            {
                selectedPosistion = 1;
            }
            else if (posistionSelect.Text == "Vice")
            {
                selectedPosistion = 2;
            }
            else if (posistionSelect.Text == "Above Pickup")
            {
                selectedPosistion = 3;
            }
            else if (posistionSelect.Text == "Pickup")
            {
                selectedPosistion = 4;
            }
            rotationP.Text = posistionArray[selectedPosistion].ToString();
            mainArmP.Text = posistionArray[selectedPosistion + 1].ToString();
            secondaryArmP.Text = posistionArray[selectedPosistion + 2].ToString();
            effectorYawP.Text = posistionArray[selectedPosistion + 3].ToString();
            effectorPitchP.Text = posistionArray[selectedPosistion + 4].ToString();
        }

        private void actuateVice_Click(object sender, EventArgs e)
        {
            actuateVice.Top -= 3;
            if(viceState == 0)
            {
                sendSerial(3, 24, 0);
                viceState = 1;
                actuateVice.Text = "Release";
            }
            else
            {
                sendSerial(3, 24, 1);
                viceState = 0;
                actuateVice.Text = "Clamp";
            }
        }

        private void actuateVice_MouseDown(object sender, MouseEventArgs e)
        {
            actuateVice.Top += 3;
        }

        private void clawServoUp_Click(object sender, EventArgs e)
        {
            moveClaw.Text = (Convert.ToInt32(moveClaw.Text) + 1).ToString();
            clawServoUp.Top -= 3;
        }

        private void clawServoUp_MouseDown(object sender, MouseEventArgs e)
        {
            clawServoUp.Top += 3;

        }

        private void clawServoDown_Click(object sender, EventArgs e)
        {
            //moveClaw.Text = clawTarget.ToString();
            clawServoDown.Top -= 3;
            if (Convert.ToInt32(moveClaw.Text) > 0)
            {
                moveClaw.Text = (Convert.ToInt32(moveClaw.Text) - 1).ToString();
            }
        }

        private void clawServoDown_MouseDown(object sender, MouseEventArgs e)
        {
            clawServoDown.Top += 3;
            clawTarget--;
        }

        private void moveClaw_Click(object sender, EventArgs e)
        {
            sendSerial(3, 23, clawTarget);
            moveClaw.Top -= 3;
        }

        private void moveClaw_MouseDown(object sender, MouseEventArgs e)
        {
            moveClaw.Top += 3;
        }

        private void comPortDrop_Click(object sender, EventArgs e)
        {
            if (comDropState == 0)
            {
                comDropState = 1;
                String[] availableComPorts = System.IO.Ports.SerialPort.GetPortNames();
                switch (availableComPorts.Length)
                {
                    case 1:
                        comOption1.Text = availableComPorts[0];
                        comOption1.Visible = true;
                        comOption1.Enabled = true;
                        break;
                    case 2:
                        comOption1.Text = availableComPorts[0];
                        comOption2.Text = availableComPorts[1];
                        comOption1.Visible = true;
                        comOption2.Visible = true;
                        comOption1.Enabled = true;
                        comOption2.Enabled = true;
                        break;
                    case 3:
                        comOption1.Text = availableComPorts[0];
                        comOption2.Text = availableComPorts[1];
                        comOption3.Text = availableComPorts[2];
                        comOption1.Visible = true;
                        comOption2.Visible = true;
                        comOption3.Visible = true;
                        comOption1.Enabled = true;
                        comOption2.Enabled = true;
                        comOption3.Enabled = true;
                        break;
                    case 4:
                        comOption1.Text = availableComPorts[0];
                        comOption2.Text = availableComPorts[1];
                        comOption3.Text = availableComPorts[2];
                        comOption4.Text = availableComPorts[3];
                        comOption1.Visible = true;
                        comOption2.Visible = true;
                        comOption3.Visible = true;
                        comOption4.Visible = true;
                        comOption1.Enabled = true;
                        comOption2.Enabled = true;
                        comOption3.Enabled = true;
                        comOption4.Enabled = true;
                        break;
                    default:
                        comOption1.Text = availableComPorts[0];
                        comOption2.Text = availableComPorts[1];
                        comOption3.Text = availableComPorts[2];
                        comOption4.Text = availableComPorts[3];
                        comOption5.Text = availableComPorts[4];
                        comOption1.Visible = true;
                        comOption2.Visible = true;
                        comOption3.Visible = true;
                        comOption4.Visible = true;
                        comOption5.Visible = true;
                        comOption1.Enabled = true;
                        comOption2.Enabled = true;
                        comOption3.Enabled = true;
                        comOption4.Enabled = true;
                        comOption5.Enabled = true;
                        break;
                }
            }
            else
            {
                comDropState = 0;
                comOption5.Visible = false;
                Thread.Sleep(20);
                comOption4.Visible = false;
                Thread.Sleep(20);
                comOption3.Visible = false;
                Thread.Sleep(20);
                comOption2.Visible = false;
                Thread.Sleep(20);
                comOption1.Visible = false;
                Thread.Sleep(20);
            }
        }

        private void comOption1_Click(object sender, EventArgs e)
        {
            comOption4.Visible = false;
            Thread.Sleep(20);
            comOption3.Visible = false;
            Thread.Sleep(20);
            comOption2.Visible = false;
            Thread.Sleep(20);
            comOption1.Visible = false;
            Thread.Sleep(20);
            comPortSelection.Text = comOption1.Text;
        }

        private void comOption2_Click(object sender, EventArgs e)
        {
            comOption5.Visible = false;
            Thread.Sleep(20);
            comOption4.Visible = false;
            Thread.Sleep(20);
            comOption3.Visible = false;
            Thread.Sleep(20);
            comOption2.Visible = false;
            Thread.Sleep(20);
            comOption1.Visible = false;
            Thread.Sleep(20);
            comPortSelection.Text = comOption2.Text;
        }

        private void comOption3_Click(object sender, EventArgs e)
        {
            comOption5.Visible = false;
            Thread.Sleep(20);
            comOption4.Visible = false;
            Thread.Sleep(20);
            comOption3.Visible = false;
            Thread.Sleep(20);
            comOption2.Visible = false;
            Thread.Sleep(20);
            comOption1.Visible = false;
            Thread.Sleep(20);
            comPortSelection.Text = comOption3.Text;
        }

        private void comOption4_Click(object sender, EventArgs e)
        {
            comOption5.Visible = false;
            Thread.Sleep(20);
            comOption4.Visible = false;
            Thread.Sleep(20);
            comOption3.Visible = false;
            Thread.Sleep(20);
            comOption2.Visible = false;
            Thread.Sleep(20);
            comOption1.Visible = false;
            Thread.Sleep(20);
            comPortSelection.Text = comOption4.Text;
        }

        private void comOption5_Click(object sender, EventArgs e)
        {
            comOption5.Visible = false;
            Thread.Sleep(20);
            comOption4.Visible = false;
            Thread.Sleep(20);
            comOption3.Visible = false;
            Thread.Sleep(20);
            comOption2.Visible = false;
            Thread.Sleep(20);
            comOption1.Visible = false;
            Thread.Sleep(20);
            comPortSelection.Text = comOption5.Text;
        }
        private void serialLink_MouseDown(object sender, MouseEventArgs e)
        {
            serialLink.Top += 3;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            serialLink.Top -= 3;
            if (portIsOpen == 0) { 
                try
                {
                    if (comPortSelection.Text == "COM Port" || baudRateSelection.Text == "Baud Rate")
                    {
                    }
                    else
                    {
                        serialPort1.PortName = comPortSelection.Text;
                        serialPort1.BaudRate = Convert.ToInt32(baudRateSelection.Text);
                        if (serialPort1.IsOpen == false)
                        {
                            serialLink.Text = "Close Link";
                            portIsOpen = 1;
                            serialPort1.Open();
                            linkPanel.Visible = false;
                            linkPanel.Enabled = false;
                            posistionControlPanel.Visible = true;
                            posistionControlPanel.Enabled = true;
                            componentControlPanel.Visible = true;
                            componentControlPanel.Enabled = true;
                            runPanel.Visible = true;
                            runPanel.Enabled = true;
                            motorSpeedPanel.Visible = true;
                            motorSpeedPanel.Enabled = true;
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                }
            }
            else
            {
                serialLink.Text = "Establish Link";
                portIsOpen = 0;
                serialPort1.Close();
            }
        }

        private void baudRateDrop_Click(object sender, EventArgs e)
        {
            if (baudDropState == 0)
            {
                baudDropState = 1;
                baud4800.Visible = true;
                baud9600.Visible = true;
                baud19200.Visible = true;
                baud4800.Enabled = true;
                baud9600.Enabled = true;
                baud19200.Enabled = true;
            }
            else
            {
                baudDropState = 0;
                baud19200.Visible = false;
                baud19200.Enabled = true;
                Thread.Sleep(20);
                baud9600.Visible = false;
                baud9600.Enabled = true;
                Thread.Sleep(20);
                baud4800.Visible = false;
                baud4800.Enabled = true;
                Thread.Sleep(20);
            }
        }

        private void baud4800_Click(object sender, EventArgs e)
        {
            baud19200.Visible = false;
            Thread.Sleep(20);
            baud9600.Visible = false;
            Thread.Sleep(20);
            baud4800.Visible = false;
            Thread.Sleep(20);
            baudRateSelection.Text = "4800";
        }

        private void baud9600_Click(object sender, EventArgs e)
        {
            baud19200.Visible = false;
            Thread.Sleep(20);
            baud9600.Visible = false;
            Thread.Sleep(20);
            baud4800.Visible = false;
            Thread.Sleep(20);
            baudRateSelection.Text = "9600";
        }

        private void baud19200_Click(object sender, EventArgs e)
        {
            baud19200.Visible = false;
            Thread.Sleep(20);
            baud9600.Visible = false;
            Thread.Sleep(20);
            baud4800.Visible = false;
            Thread.Sleep(20);
            baudRateSelection.Text = "19200";
        }

        private void comPortSelection_Click(object sender, EventArgs e)
        {

        }

        private void browseImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Data Files | *txt";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileToImport.Text = fileDialog.FileName;
            }
        }

        private void importFile_Click(object sender, EventArgs e)
        {
            dataFilePath = fileToImport.Text;
            importFile.Top -= 3;
            dataFilePanel.Visible = false;
            dataFilePanel.Enabled = false;
            linkPanel.Visible = true;
            linkPanel.Enabled = true;
            StreamReader sr = new StreamReader(dataFilePath);
            string[] homePosistions = new string[5];
            string[] aboveVicePosistions = new string[5];
            string[] vicePosistions = new string[5];
            string[] abovePickupPosistions = new string[5];
            string[] pickupPosistions = new string[5];
            homePosistions = sr.ReadLine().Split(',');
            aboveVicePosistions = sr.ReadLine().Split(',');
            vicePosistions = sr.ReadLine().Split(',');
            abovePickupPosistions = sr.ReadLine().Split(',');
            pickupPosistions = sr.ReadLine().Split(',');
            for (int i = 0; i < 5; i++)
            {
                posistionArray[i] = Convert.ToInt32(homePosistions[i]);
            }
            for (int i = 5; i < 10; i++)
            {
                posistionArray[i] = Convert.ToInt32(aboveVicePosistions[i - 5]);
            }
            for (int i = 10; i < 15; i++)
            {
                posistionArray[i] = Convert.ToInt32(vicePosistions[i - 10]);
            }
            for (int i = 15; i < 20; i++)
            {
                posistionArray[i] = Convert.ToInt32(abovePickupPosistions[i - 15]);
            }
            for (int i = 20; i < 25; i++)
            {
                posistionArray[i] = Convert.ToInt32(pickupPosistions[i - 20]);
            }
            rotationP.Text = posistionArray[0].ToString();
            mainArmP.Text = posistionArray[1].ToString();
            secondaryArmP.Text = posistionArray[2].ToString();
            effectorYawP.Text = posistionArray[3].ToString();
            effectorPitchP.Text = posistionArray[4].ToString();
        }

        private void importFile_MouseDown(object sender, MouseEventArgs e)
        {
            importFile.Top += 3;
        }

        private void millRewind_Click(object sender, EventArgs e)
        {
            millRewind.Top -= 3;
            sendSerial(3, 25, 2);
        }

        private void millRewind_MouseDown(object sender, MouseEventArgs e)
        {
            millRewind.Top += 3;
        }
        private void moveClaw_Click_1(object sender, EventArgs e)
        {
            valueBeforeChange = moveClaw.Text;
            moveClaw.Clear();
        }

        private void moveClaw_Leave(object sender, EventArgs e)
        {
            if (moveClaw.Text == "")
            {
                moveClaw.Text = valueBeforeChange;
            }
        }

        private void speedText_Leave(object sender, EventArgs e)
        {
            if (speedText.Text == "")
            {
                speedText.Text = valueBeforeChange;
            }
        }

        private void speedText_Click(object sender, EventArgs e)
        {
            valueBeforeChange = speedText.Text;
            speedText.Clear();
        }

        private void partsToRun_Leave(object sender, EventArgs e)
        {
            if (partsToRun.Text == "")
            {
                partsToRun.Text = valueBeforeChange;
            }
        }

        private void partsToRun_Click(object sender, EventArgs e)
        {
            valueBeforeChange = partsToRun.Text;
            partsToRun.Clear();
        }

        private void millStart_Click(object sender, EventArgs e)
        {
            millStart.Top -= 3;
            sendSerial(3, 25, 1);
        }

        private void millStart_MouseDown(object sender, MouseEventArgs e)
        {
            millStart.Top += 3;
        }

        private void millStop_Click(object sender, EventArgs e)
        {
           millStop.Top -= 3;
           sendSerial(3, 25, 1);
        }

        private void millStop_MouseDown(object sender, MouseEventArgs e)
        {
            millStop.Top += 3;
        }

        private void runBatch_Click(object sender, EventArgs e)
        {
            runBatch.Top -= 3;
            sendSerial(3, 26, Convert.ToInt32(partsToRun.Text));
        }

        private void runBatch_MouseDown(object sender, MouseEventArgs e)
        {
            runBatch.Top += 3;
        }

        private void actuateClaw_Click(object sender, EventArgs e)
        {
            actuateClaw.Top -= 3;
            if (clawState == 0) {
                actuateClaw.Text = "Open";
                clawState = 1;
                sendSerial(3, 27, Convert.ToInt32(moveClaw.Text) * 100 + 1);
            }
            else
            {
                actuateClaw.Text = "Close";
                clawState = 0;
                sendSerial(3, 27, Convert.ToInt32(moveClaw.Text) * 100);
            }
        }

        private void actuateClaw_MouseDown(object sender, MouseEventArgs e)
        {
            actuateClaw.Top += 3;
        }

        private void partsToRunDown_Click(object sender, EventArgs e)
        {
            partsToRunDown.Top -= 3;
            if (Convert.ToInt32(partsToRun.Text) > 0)
            {
                partsToRun.Text = (Convert.ToInt32(partsToRun.Text) - 1).ToString();
            }
        }

        private void partsToRunDown_MouseDown(object sender, MouseEventArgs e)
        {
            partsToRunDown.Top += 3;
        }

        private void partsToRunUp_Click(object sender, EventArgs e)
        {
            partsToRunUp.Top -= 3;
            partsToRun.Text = (Convert.ToInt32(partsToRun.Text) + 1).ToString();
        }

        private void partsToRunUp_MouseDown(object sender, MouseEventArgs e)
        {
            partsToRunUp.Top += 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
