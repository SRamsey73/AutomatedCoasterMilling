namespace Automated_Coaster_Milling_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.mainArmLabel = new System.Windows.Forms.Label();
            this.mainArmE = new System.Windows.Forms.Label();
            this.secondaryArmE = new System.Windows.Forms.Label();
            this.secondaryArmLabel = new System.Windows.Forms.Label();
            this.effectorYawE = new System.Windows.Forms.Label();
            this.effectorYawLabel = new System.Windows.Forms.Label();
            this.effectorPitchE = new System.Windows.Forms.Label();
            this.effectorPitchLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.homePosistion = new System.Windows.Forms.Label();
            this.aboveVicePosistion = new System.Windows.Forms.Label();
            this.abovePickupPosistion = new System.Windows.Forms.Label();
            this.vicePosistion = new System.Windows.Forms.Label();
            this.pickupPosistion = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.recordPosistion = new System.Windows.Forms.Button();
            this.moveToPosistion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mainArmBackground = new System.Windows.Forms.Label();
            this.secondaryArmBackground = new System.Windows.Forms.Label();
            this.effectorYawBackground = new System.Windows.Forms.Label();
            this.effectorPitchBackground = new System.Windows.Forms.Label();
            this.mainArmP = new System.Windows.Forms.TextBox();
            this.secondaryArmP = new System.Windows.Forms.TextBox();
            this.effectorYawP = new System.Windows.Forms.TextBox();
            this.effectorPitchP = new System.Windows.Forms.TextBox();
            this.rotationP = new System.Windows.Forms.TextBox();
            this.rotationE = new System.Windows.Forms.Label();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.rotationBackground = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.speedDown = new System.Windows.Forms.Button();
            this.speedUp = new System.Windows.Forms.Button();
            this.rotationDown = new System.Windows.Forms.Button();
            this.rotationUp = new System.Windows.Forms.Button();
            this.posistionDropButton = new System.Windows.Forms.Button();
            this.secondaryArmUp = new System.Windows.Forms.Button();
            this.effectorYawUp = new System.Windows.Forms.Button();
            this.effectorPitchUp = new System.Windows.Forms.Button();
            this.effectorPitchDown = new System.Windows.Forms.Button();
            this.effectorYawDown = new System.Windows.Forms.Button();
            this.secondaryArmDown = new System.Windows.Forms.Button();
            this.mainArmDown = new System.Windows.Forms.Button();
            this.mainArmUp = new System.Windows.Forms.Button();
            this.posistionSelect = new System.Windows.Forms.Button();
            this.motorSpeedLabel = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.clawServoUp = new System.Windows.Forms.Button();
            this.clawServoDown = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.actuateVice = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.moveClawBackground = new System.Windows.Forms.Label();
            this.actuateClaw = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.comPortSelection = new System.Windows.Forms.Button();
            this.comOption4 = new System.Windows.Forms.Label();
            this.comOption3 = new System.Windows.Forms.Label();
            this.comOption2 = new System.Windows.Forms.Label();
            this.comOption1 = new System.Windows.Forms.Label();
            this.comPortDrop = new System.Windows.Forms.Button();
            this.baudRateSelection = new System.Windows.Forms.Button();
            this.baud19200 = new System.Windows.Forms.Label();
            this.baud9600 = new System.Windows.Forms.Label();
            this.baud4800 = new System.Windows.Forms.Label();
            this.baudRateDrop = new System.Windows.Forms.Button();
            this.serialLink = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.runBatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.partsToRun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partsToRunUp = new System.Windows.Forms.Button();
            this.partsToRunDown = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.partsToRunBackground = new System.Windows.Forms.Label();
            this.importFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fileToImport = new System.Windows.Forms.TextBox();
            this.addressBorder = new System.Windows.Forms.Label();
            this.addressBackground = new System.Windows.Forms.Label();
            this.browseBorder = new System.Windows.Forms.Label();
            this.browseImport = new System.Windows.Forms.Label();
            this.selectDataFile = new System.Windows.Forms.Label();
            this.linkParamaters = new System.Windows.Forms.Label();
            this.speedText = new System.Windows.Forms.TextBox();
            this.moveClaw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.posistionSelectLabel = new System.Windows.Forms.Label();
            this.rotationPosistionLabel = new System.Windows.Forms.Label();
            this.effectorPitchPosistionLabel = new System.Windows.Forms.Label();
            this.effectorYawPosistionLabel = new System.Windows.Forms.Label();
            this.secondaryArmPosistionLabel = new System.Windows.Forms.Label();
            this.mainArmPosistionLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.millStop = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.millStart = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.millRewind = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.posistionControlPanel = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.componentControlPanel = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.linkPanel = new System.Windows.Forms.Panel();
            this.comOption5 = new System.Windows.Forms.Label();
            this.dataFilePanel = new System.Windows.Forms.Panel();
            this.runPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.motorSpeedPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.posistionControlPanel.SuspendLayout();
            this.componentControlPanel.SuspendLayout();
            this.linkPanel.SuspendLayout();
            this.dataFilePanel.SuspendLayout();
            this.runPanel.SuspendLayout();
            this.motorSpeedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // mainArmLabel
            // 
            this.mainArmLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.mainArmLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainArmLabel.ForeColor = System.Drawing.Color.White;
            this.mainArmLabel.Location = new System.Drawing.Point(55, 114);
            this.mainArmLabel.Name = "mainArmLabel";
            this.mainArmLabel.Padding = new System.Windows.Forms.Padding(2);
            this.mainArmLabel.Size = new System.Drawing.Size(185, 29);
            this.mainArmLabel.TabIndex = 30;
            this.mainArmLabel.Text = "Main Arm";
            this.mainArmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainArmE
            // 
            this.mainArmE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.mainArmE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainArmE.ForeColor = System.Drawing.Color.White;
            this.mainArmE.Location = new System.Drawing.Point(284, 114);
            this.mainArmE.Name = "mainArmE";
            this.mainArmE.Padding = new System.Windows.Forms.Padding(3);
            this.mainArmE.Size = new System.Drawing.Size(96, 29);
            this.mainArmE.TabIndex = 31;
            this.mainArmE.Text = "Value";
            this.mainArmE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondaryArmE
            // 
            this.secondaryArmE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.secondaryArmE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryArmE.ForeColor = System.Drawing.Color.White;
            this.secondaryArmE.Location = new System.Drawing.Point(284, 149);
            this.secondaryArmE.Name = "secondaryArmE";
            this.secondaryArmE.Padding = new System.Windows.Forms.Padding(3);
            this.secondaryArmE.Size = new System.Drawing.Size(96, 29);
            this.secondaryArmE.TabIndex = 33;
            this.secondaryArmE.Text = "Value";
            this.secondaryArmE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondaryArmLabel
            // 
            this.secondaryArmLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.secondaryArmLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryArmLabel.ForeColor = System.Drawing.Color.White;
            this.secondaryArmLabel.Location = new System.Drawing.Point(55, 149);
            this.secondaryArmLabel.Name = "secondaryArmLabel";
            this.secondaryArmLabel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.secondaryArmLabel.Size = new System.Drawing.Size(185, 29);
            this.secondaryArmLabel.TabIndex = 32;
            this.secondaryArmLabel.Text = "Secondary Arm";
            this.secondaryArmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectorYawE
            // 
            this.effectorYawE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorYawE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectorYawE.ForeColor = System.Drawing.Color.White;
            this.effectorYawE.Location = new System.Drawing.Point(284, 184);
            this.effectorYawE.Name = "effectorYawE";
            this.effectorYawE.Padding = new System.Windows.Forms.Padding(3);
            this.effectorYawE.Size = new System.Drawing.Size(96, 29);
            this.effectorYawE.TabIndex = 35;
            this.effectorYawE.Text = "Value";
            this.effectorYawE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectorYawLabel
            // 
            this.effectorYawLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorYawLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectorYawLabel.ForeColor = System.Drawing.Color.White;
            this.effectorYawLabel.Location = new System.Drawing.Point(55, 184);
            this.effectorYawLabel.Name = "effectorYawLabel";
            this.effectorYawLabel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.effectorYawLabel.Size = new System.Drawing.Size(185, 29);
            this.effectorYawLabel.TabIndex = 34;
            this.effectorYawLabel.Text = "Effector Yaw";
            this.effectorYawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectorPitchE
            // 
            this.effectorPitchE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorPitchE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectorPitchE.ForeColor = System.Drawing.Color.White;
            this.effectorPitchE.Location = new System.Drawing.Point(284, 219);
            this.effectorPitchE.Name = "effectorPitchE";
            this.effectorPitchE.Padding = new System.Windows.Forms.Padding(3);
            this.effectorPitchE.Size = new System.Drawing.Size(96, 29);
            this.effectorPitchE.TabIndex = 37;
            this.effectorPitchE.Text = "Value";
            this.effectorPitchE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectorPitchLabel
            // 
            this.effectorPitchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorPitchLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectorPitchLabel.ForeColor = System.Drawing.Color.White;
            this.effectorPitchLabel.Location = new System.Drawing.Point(55, 219);
            this.effectorPitchLabel.Name = "effectorPitchLabel";
            this.effectorPitchLabel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.effectorPitchLabel.Size = new System.Drawing.Size(185, 29);
            this.effectorPitchLabel.TabIndex = 36;
            this.effectorPitchLabel.Text = "Effector Pitch";
            this.effectorPitchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(385, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 3);
            this.label14.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label16.Location = new System.Drawing.Point(385, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 3);
            this.label16.TabIndex = 52;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label18.Location = new System.Drawing.Point(245, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 3);
            this.label18.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label19.Location = new System.Drawing.Point(245, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 3);
            this.label19.TabIndex = 54;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label20.Location = new System.Drawing.Point(245, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 3);
            this.label20.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label21.Location = new System.Drawing.Point(245, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 3);
            this.label21.TabIndex = 56;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label22.Location = new System.Drawing.Point(385, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 3);
            this.label22.TabIndex = 57;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label23.Location = new System.Drawing.Point(385, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 3);
            this.label23.TabIndex = 58;
            // 
            // homePosistion
            // 
            this.homePosistion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.homePosistion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePosistion.ForeColor = System.Drawing.Color.White;
            this.homePosistion.Location = new System.Drawing.Point(30, 131);
            this.homePosistion.Name = "homePosistion";
            this.homePosistion.Padding = new System.Windows.Forms.Padding(2);
            this.homePosistion.Size = new System.Drawing.Size(170, 29);
            this.homePosistion.TabIndex = 60;
            this.homePosistion.Text = "Home";
            this.homePosistion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homePosistion.Visible = false;
            this.homePosistion.Click += new System.EventHandler(this.homePosistion_Click);
            // 
            // aboveVicePosistion
            // 
            this.aboveVicePosistion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.aboveVicePosistion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboveVicePosistion.ForeColor = System.Drawing.Color.White;
            this.aboveVicePosistion.Location = new System.Drawing.Point(30, 161);
            this.aboveVicePosistion.Name = "aboveVicePosistion";
            this.aboveVicePosistion.Padding = new System.Windows.Forms.Padding(2);
            this.aboveVicePosistion.Size = new System.Drawing.Size(170, 29);
            this.aboveVicePosistion.TabIndex = 61;
            this.aboveVicePosistion.Text = "Above Vice";
            this.aboveVicePosistion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboveVicePosistion.Visible = false;
            this.aboveVicePosistion.Click += new System.EventHandler(this.aboveVicePosistion_Click);
            // 
            // abovePickupPosistion
            // 
            this.abovePickupPosistion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.abovePickupPosistion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abovePickupPosistion.ForeColor = System.Drawing.Color.White;
            this.abovePickupPosistion.Location = new System.Drawing.Point(30, 221);
            this.abovePickupPosistion.Name = "abovePickupPosistion";
            this.abovePickupPosistion.Padding = new System.Windows.Forms.Padding(2);
            this.abovePickupPosistion.Size = new System.Drawing.Size(170, 29);
            this.abovePickupPosistion.TabIndex = 63;
            this.abovePickupPosistion.Text = "Above Pickup";
            this.abovePickupPosistion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abovePickupPosistion.Visible = false;
            this.abovePickupPosistion.Click += new System.EventHandler(this.abovePickupPosistion_Click);
            // 
            // vicePosistion
            // 
            this.vicePosistion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.vicePosistion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vicePosistion.ForeColor = System.Drawing.Color.White;
            this.vicePosistion.Location = new System.Drawing.Point(30, 191);
            this.vicePosistion.Name = "vicePosistion";
            this.vicePosistion.Padding = new System.Windows.Forms.Padding(2);
            this.vicePosistion.Size = new System.Drawing.Size(170, 29);
            this.vicePosistion.TabIndex = 62;
            this.vicePosistion.Text = "Vice";
            this.vicePosistion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vicePosistion.Visible = false;
            this.vicePosistion.Click += new System.EventHandler(this.vicePosistion_Click);
            // 
            // pickupPosistion
            // 
            this.pickupPosistion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.pickupPosistion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupPosistion.ForeColor = System.Drawing.Color.White;
            this.pickupPosistion.Location = new System.Drawing.Point(30, 251);
            this.pickupPosistion.Name = "pickupPosistion";
            this.pickupPosistion.Padding = new System.Windows.Forms.Padding(2);
            this.pickupPosistion.Size = new System.Drawing.Size(170, 29);
            this.pickupPosistion.TabIndex = 64;
            this.pickupPosistion.Text = "Pickup";
            this.pickupPosistion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pickupPosistion.Visible = false;
            this.pickupPosistion.Click += new System.EventHandler(this.pickupPosistion_Click);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(87)))), ((int)(((byte)(153)))));
            this.label29.Location = new System.Drawing.Point(280, 91);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(245, 3);
            this.label29.TabIndex = 71;
            // 
            // recordPosistion
            // 
            this.recordPosistion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.recordPosistion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recordPosistion.FlatAppearance.BorderSize = 0;
            this.recordPosistion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(87)))), ((int)(((byte)(153)))));
            this.recordPosistion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.recordPosistion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordPosistion.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordPosistion.Location = new System.Drawing.Point(280, 65);
            this.recordPosistion.Margin = new System.Windows.Forms.Padding(0);
            this.recordPosistion.Name = "recordPosistion";
            this.recordPosistion.Size = new System.Drawing.Size(245, 26);
            this.recordPosistion.TabIndex = 72;
            this.recordPosistion.Text = "Record Current Posistion";
            this.recordPosistion.UseVisualStyleBackColor = false;
            this.recordPosistion.Click += new System.EventHandler(this.recordPosistion_Click);
            this.recordPosistion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recordPosistion_MouseDown);
            // 
            // moveToPosistion
            // 
            this.moveToPosistion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.moveToPosistion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveToPosistion.FlatAppearance.BorderSize = 0;
            this.moveToPosistion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(87)))), ((int)(((byte)(153)))));
            this.moveToPosistion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.moveToPosistion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveToPosistion.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveToPosistion.Location = new System.Drawing.Point(30, 65);
            this.moveToPosistion.Margin = new System.Windows.Forms.Padding(0);
            this.moveToPosistion.Name = "moveToPosistion";
            this.moveToPosistion.Size = new System.Drawing.Size(245, 26);
            this.moveToPosistion.TabIndex = 73;
            this.moveToPosistion.Text = "Move To Posistion";
            this.moveToPosistion.UseVisualStyleBackColor = false;
            this.moveToPosistion.Click += new System.EventHandler(this.moveToPosistion_Click);
            this.moveToPosistion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveToPosistion_MouseDown);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(87)))), ((int)(((byte)(153)))));
            this.label10.Location = new System.Drawing.Point(30, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 3);
            this.label10.TabIndex = 74;
            // 
            // mainArmBackground
            // 
            this.mainArmBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.mainArmBackground.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainArmBackground.ForeColor = System.Drawing.Color.White;
            this.mainArmBackground.Location = new System.Drawing.Point(427, 135);
            this.mainArmBackground.Name = "mainArmBackground";
            this.mainArmBackground.Padding = new System.Windows.Forms.Padding(2);
            this.mainArmBackground.Size = new System.Drawing.Size(99, 29);
            this.mainArmBackground.TabIndex = 65;
            this.mainArmBackground.Text = "Value";
            this.mainArmBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondaryArmBackground
            // 
            this.secondaryArmBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.secondaryArmBackground.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryArmBackground.ForeColor = System.Drawing.Color.White;
            this.secondaryArmBackground.Location = new System.Drawing.Point(426, 170);
            this.secondaryArmBackground.Name = "secondaryArmBackground";
            this.secondaryArmBackground.Padding = new System.Windows.Forms.Padding(2);
            this.secondaryArmBackground.Size = new System.Drawing.Size(99, 29);
            this.secondaryArmBackground.TabIndex = 66;
            this.secondaryArmBackground.Text = "Value";
            this.secondaryArmBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectorYawBackground
            // 
            this.effectorYawBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.effectorYawBackground.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectorYawBackground.ForeColor = System.Drawing.Color.White;
            this.effectorYawBackground.Location = new System.Drawing.Point(426, 205);
            this.effectorYawBackground.Name = "effectorYawBackground";
            this.effectorYawBackground.Padding = new System.Windows.Forms.Padding(2);
            this.effectorYawBackground.Size = new System.Drawing.Size(99, 29);
            this.effectorYawBackground.TabIndex = 67;
            this.effectorYawBackground.Text = "Value";
            this.effectorYawBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectorPitchBackground
            // 
            this.effectorPitchBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.effectorPitchBackground.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectorPitchBackground.ForeColor = System.Drawing.Color.White;
            this.effectorPitchBackground.Location = new System.Drawing.Point(426, 240);
            this.effectorPitchBackground.Name = "effectorPitchBackground";
            this.effectorPitchBackground.Padding = new System.Windows.Forms.Padding(2);
            this.effectorPitchBackground.Size = new System.Drawing.Size(99, 29);
            this.effectorPitchBackground.TabIndex = 68;
            this.effectorPitchBackground.Text = "Value";
            this.effectorPitchBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainArmP
            // 
            this.mainArmP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.mainArmP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainArmP.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.mainArmP.ForeColor = System.Drawing.Color.White;
            this.mainArmP.Location = new System.Drawing.Point(430, 138);
            this.mainArmP.Name = "mainArmP";
            this.mainArmP.Size = new System.Drawing.Size(93, 23);
            this.mainArmP.TabIndex = 76;
            this.mainArmP.Text = "Value";
            this.mainArmP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainArmP.Click += new System.EventHandler(this.mainArmP_Click);
            this.mainArmP.Leave += new System.EventHandler(this.mainArmP_Leave);
            // 
            // secondaryArmP
            // 
            this.secondaryArmP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.secondaryArmP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondaryArmP.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryArmP.ForeColor = System.Drawing.Color.White;
            this.secondaryArmP.Location = new System.Drawing.Point(429, 173);
            this.secondaryArmP.Name = "secondaryArmP";
            this.secondaryArmP.Size = new System.Drawing.Size(93, 24);
            this.secondaryArmP.TabIndex = 77;
            this.secondaryArmP.Text = "Value";
            this.secondaryArmP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondaryArmP.Click += new System.EventHandler(this.secondaryArmP_Click);
            this.secondaryArmP.Leave += new System.EventHandler(this.secondaryArmP_Leave);
            // 
            // effectorYawP
            // 
            this.effectorYawP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.effectorYawP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.effectorYawP.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.effectorYawP.ForeColor = System.Drawing.Color.White;
            this.effectorYawP.Location = new System.Drawing.Point(429, 208);
            this.effectorYawP.Name = "effectorYawP";
            this.effectorYawP.Size = new System.Drawing.Size(93, 23);
            this.effectorYawP.TabIndex = 78;
            this.effectorYawP.Text = "Value";
            this.effectorYawP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.effectorYawP.Click += new System.EventHandler(this.effectorYawP_Click);
            this.effectorYawP.Leave += new System.EventHandler(this.effectorYawP_Leave);
            // 
            // effectorPitchP
            // 
            this.effectorPitchP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.effectorPitchP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.effectorPitchP.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.effectorPitchP.ForeColor = System.Drawing.Color.White;
            this.effectorPitchP.Location = new System.Drawing.Point(429, 243);
            this.effectorPitchP.Name = "effectorPitchP";
            this.effectorPitchP.Size = new System.Drawing.Size(93, 23);
            this.effectorPitchP.TabIndex = 79;
            this.effectorPitchP.Text = "Value";
            this.effectorPitchP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.effectorPitchP.Click += new System.EventHandler(this.effectorPitchP_Click);
            this.effectorPitchP.Leave += new System.EventHandler(this.effectorPitchP_Leave);
            // 
            // rotationP
            // 
            this.rotationP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.rotationP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rotationP.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.rotationP.ForeColor = System.Drawing.Color.White;
            this.rotationP.Location = new System.Drawing.Point(430, 103);
            this.rotationP.Name = "rotationP";
            this.rotationP.Size = new System.Drawing.Size(93, 23);
            this.rotationP.TabIndex = 87;
            this.rotationP.Text = "Value";
            this.rotationP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rotationP.Click += new System.EventHandler(this.rotationP_Click);
            this.rotationP.Leave += new System.EventHandler(this.rotationP_Leave);
            // 
            // rotationE
            // 
            this.rotationE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.rotationE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationE.ForeColor = System.Drawing.Color.White;
            this.rotationE.Location = new System.Drawing.Point(284, 79);
            this.rotationE.Name = "rotationE";
            this.rotationE.Padding = new System.Windows.Forms.Padding(3);
            this.rotationE.Size = new System.Drawing.Size(96, 29);
            this.rotationE.TabIndex = 81;
            this.rotationE.Text = "Value";
            this.rotationE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotationLabel
            // 
            this.rotationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.rotationLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationLabel.ForeColor = System.Drawing.Color.White;
            this.rotationLabel.Location = new System.Drawing.Point(55, 79);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Padding = new System.Windows.Forms.Padding(2);
            this.rotationLabel.Size = new System.Drawing.Size(185, 29);
            this.rotationLabel.TabIndex = 80;
            this.rotationLabel.Text = "Rotation";
            this.rotationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label26.Location = new System.Drawing.Point(385, 105);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 3);
            this.label26.TabIndex = 85;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label28.Location = new System.Drawing.Point(245, 105);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 3);
            this.label28.TabIndex = 84;
            // 
            // rotationBackground
            // 
            this.rotationBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.rotationBackground.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationBackground.ForeColor = System.Drawing.Color.White;
            this.rotationBackground.Location = new System.Drawing.Point(427, 100);
            this.rotationBackground.Name = "rotationBackground";
            this.rotationBackground.Padding = new System.Windows.Forms.Padding(2);
            this.rotationBackground.Size = new System.Drawing.Size(99, 29);
            this.rotationBackground.TabIndex = 86;
            this.rotationBackground.Text = "Value";
            this.rotationBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.label31.Location = new System.Drawing.Point(148, 78);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 3);
            this.label31.TabIndex = 91;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.label32.Location = new System.Drawing.Point(27, 77);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 3);
            this.label32.TabIndex = 93;
            // 
            // speedDown
            // 
            this.speedDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.speedDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.speedDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.speedDown.FlatAppearance.BorderSize = 0;
            this.speedDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(145)))), ((int)(((byte)(19)))));
            this.speedDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.speedDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedDown.Image = global::Automated_Coaster_Milling_GUI.Properties.Resources.Minus;
            this.speedDown.Location = new System.Drawing.Point(27, 52);
            this.speedDown.Name = "speedDown";
            this.speedDown.Size = new System.Drawing.Size(29, 26);
            this.speedDown.TabIndex = 92;
            this.speedDown.UseVisualStyleBackColor = false;
            this.speedDown.Click += new System.EventHandler(this.speedDown_Click);
            this.speedDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.speedDown_MouseDown);
            // 
            // speedUp
            // 
            this.speedUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.speedUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.speedUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.speedUp.FlatAppearance.BorderSize = 0;
            this.speedUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(145)))), ((int)(((byte)(19)))));
            this.speedUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.speedUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedUp.Image = global::Automated_Coaster_Milling_GUI.Properties.Resources.Plus3;
            this.speedUp.Location = new System.Drawing.Point(148, 52);
            this.speedUp.Margin = new System.Windows.Forms.Padding(0);
            this.speedUp.Name = "speedUp";
            this.speedUp.Size = new System.Drawing.Size(29, 26);
            this.speedUp.TabIndex = 90;
            this.speedUp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.speedUp.UseVisualStyleBackColor = false;
            this.speedUp.Click += new System.EventHandler(this.speedUp_Click);
            this.speedUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.speedUp_MouseDown);
            // 
            // rotationDown
            // 
            this.rotationDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.rotationDown.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Down_White_Arrow;
            this.rotationDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rotationDown.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.rotationDown.FlatAppearance.BorderSize = 0;
            this.rotationDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.rotationDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.rotationDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotationDown.Location = new System.Drawing.Point(245, 79);
            this.rotationDown.Name = "rotationDown";
            this.rotationDown.Size = new System.Drawing.Size(34, 26);
            this.rotationDown.TabIndex = 83;
            this.rotationDown.UseVisualStyleBackColor = false;
            this.rotationDown.Click += new System.EventHandler(this.rotationDown_Click);
            this.rotationDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotationDown_MouseDown);
            // 
            // rotationUp
            // 
            this.rotationUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.rotationUp.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.White_Arrow;
            this.rotationUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rotationUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rotationUp.FlatAppearance.BorderSize = 0;
            this.rotationUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.rotationUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.rotationUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotationUp.Location = new System.Drawing.Point(385, 79);
            this.rotationUp.Name = "rotationUp";
            this.rotationUp.Size = new System.Drawing.Size(34, 26);
            this.rotationUp.TabIndex = 82;
            this.rotationUp.UseVisualStyleBackColor = false;
            this.rotationUp.Click += new System.EventHandler(this.rotationUp_Click);
            this.rotationUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotationUp_MouseDown);
            // 
            // posistionDropButton
            // 
            this.posistionDropButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.posistionDropButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.posistionDropButton.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Drop_Down_Arrow1;
            this.posistionDropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.posistionDropButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.posistionDropButton.FlatAppearance.BorderSize = 0;
            this.posistionDropButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posistionDropButton.Location = new System.Drawing.Point(201, 100);
            this.posistionDropButton.Name = "posistionDropButton";
            this.posistionDropButton.Size = new System.Drawing.Size(29, 29);
            this.posistionDropButton.TabIndex = 59;
            this.posistionDropButton.UseVisualStyleBackColor = false;
            this.posistionDropButton.Click += new System.EventHandler(this.posistionDropButton_Click);
            this.posistionDropButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.posistionDropButton_MouseDown);
            // 
            // secondaryArmUp
            // 
            this.secondaryArmUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.secondaryArmUp.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.White_Arrow;
            this.secondaryArmUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secondaryArmUp.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.secondaryArmUp.FlatAppearance.BorderSize = 0;
            this.secondaryArmUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.secondaryArmUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.secondaryArmUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondaryArmUp.Location = new System.Drawing.Point(385, 149);
            this.secondaryArmUp.Name = "secondaryArmUp";
            this.secondaryArmUp.Size = new System.Drawing.Size(34, 26);
            this.secondaryArmUp.TabIndex = 49;
            this.secondaryArmUp.UseVisualStyleBackColor = false;
            this.secondaryArmUp.Click += new System.EventHandler(this.secondaryArmUp_Click);
            this.secondaryArmUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secondaryArmUp_MouseDown);
            // 
            // effectorYawUp
            // 
            this.effectorYawUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorYawUp.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.White_Arrow;
            this.effectorYawUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.effectorYawUp.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.effectorYawUp.FlatAppearance.BorderSize = 0;
            this.effectorYawUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.effectorYawUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.effectorYawUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effectorYawUp.Location = new System.Drawing.Point(385, 184);
            this.effectorYawUp.Name = "effectorYawUp";
            this.effectorYawUp.Size = new System.Drawing.Size(34, 26);
            this.effectorYawUp.TabIndex = 48;
            this.effectorYawUp.UseVisualStyleBackColor = false;
            this.effectorYawUp.Click += new System.EventHandler(this.effectorYawUp_Click);
            this.effectorYawUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.effectorYawUp_MouseDown);
            // 
            // effectorPitchUp
            // 
            this.effectorPitchUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorPitchUp.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.White_Arrow;
            this.effectorPitchUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.effectorPitchUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorPitchUp.FlatAppearance.BorderSize = 0;
            this.effectorPitchUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.effectorPitchUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.effectorPitchUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effectorPitchUp.Location = new System.Drawing.Point(385, 219);
            this.effectorPitchUp.Name = "effectorPitchUp";
            this.effectorPitchUp.Size = new System.Drawing.Size(34, 26);
            this.effectorPitchUp.TabIndex = 47;
            this.effectorPitchUp.UseVisualStyleBackColor = false;
            this.effectorPitchUp.Click += new System.EventHandler(this.effectorPitchUp_Click);
            this.effectorPitchUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.effectorPitchUp_MouseDown);
            // 
            // effectorPitchDown
            // 
            this.effectorPitchDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorPitchDown.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Down_White_Arrow;
            this.effectorPitchDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.effectorPitchDown.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.effectorPitchDown.FlatAppearance.BorderSize = 0;
            this.effectorPitchDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.effectorPitchDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.effectorPitchDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effectorPitchDown.Location = new System.Drawing.Point(245, 219);
            this.effectorPitchDown.Name = "effectorPitchDown";
            this.effectorPitchDown.Size = new System.Drawing.Size(34, 26);
            this.effectorPitchDown.TabIndex = 45;
            this.effectorPitchDown.UseVisualStyleBackColor = false;
            this.effectorPitchDown.Click += new System.EventHandler(this.effectorPitchDown_Click);
            this.effectorPitchDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.effectorPitchDown_MouseDown);
            // 
            // effectorYawDown
            // 
            this.effectorYawDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.effectorYawDown.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Down_White_Arrow;
            this.effectorYawDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.effectorYawDown.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.effectorYawDown.FlatAppearance.BorderSize = 0;
            this.effectorYawDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.effectorYawDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.effectorYawDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effectorYawDown.Location = new System.Drawing.Point(245, 184);
            this.effectorYawDown.Name = "effectorYawDown";
            this.effectorYawDown.Size = new System.Drawing.Size(34, 26);
            this.effectorYawDown.TabIndex = 44;
            this.effectorYawDown.UseVisualStyleBackColor = false;
            this.effectorYawDown.Click += new System.EventHandler(this.effectorYawDown_Click);
            this.effectorYawDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.effectorYawDown_MouseDown);
            // 
            // secondaryArmDown
            // 
            this.secondaryArmDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.secondaryArmDown.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Down_White_Arrow;
            this.secondaryArmDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secondaryArmDown.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.secondaryArmDown.FlatAppearance.BorderSize = 0;
            this.secondaryArmDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.secondaryArmDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.secondaryArmDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondaryArmDown.Location = new System.Drawing.Point(245, 149);
            this.secondaryArmDown.Name = "secondaryArmDown";
            this.secondaryArmDown.Size = new System.Drawing.Size(34, 26);
            this.secondaryArmDown.TabIndex = 43;
            this.secondaryArmDown.UseVisualStyleBackColor = false;
            this.secondaryArmDown.Click += new System.EventHandler(this.secondaryArmDown_Click);
            this.secondaryArmDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secondaryArmDown_MouseDown);
            // 
            // mainArmDown
            // 
            this.mainArmDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.mainArmDown.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Down_White_Arrow;
            this.mainArmDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainArmDown.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.mainArmDown.FlatAppearance.BorderSize = 0;
            this.mainArmDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.mainArmDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.mainArmDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainArmDown.Location = new System.Drawing.Point(245, 114);
            this.mainArmDown.Name = "mainArmDown";
            this.mainArmDown.Size = new System.Drawing.Size(34, 26);
            this.mainArmDown.TabIndex = 39;
            this.mainArmDown.UseVisualStyleBackColor = false;
            this.mainArmDown.Click += new System.EventHandler(this.mainArmDown_Click);
            this.mainArmDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainArmDown_MouseDown_1);
            // 
            // mainArmUp
            // 
            this.mainArmUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.mainArmUp.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.White_Arrow;
            this.mainArmUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainArmUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mainArmUp.FlatAppearance.BorderSize = 0;
            this.mainArmUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.mainArmUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.mainArmUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainArmUp.Location = new System.Drawing.Point(385, 114);
            this.mainArmUp.Name = "mainArmUp";
            this.mainArmUp.Size = new System.Drawing.Size(34, 26);
            this.mainArmUp.TabIndex = 38;
            this.mainArmUp.UseVisualStyleBackColor = false;
            this.mainArmUp.Click += new System.EventHandler(this.mainArmUp_Click);
            this.mainArmUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainArmUp_MouseDown_1);
            // 
            // posistionSelect
            // 
            this.posistionSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.posistionSelect.FlatAppearance.BorderSize = 0;
            this.posistionSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(87)))), ((int)(((byte)(153)))));
            this.posistionSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.posistionSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posistionSelect.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posistionSelect.Location = new System.Drawing.Point(30, 100);
            this.posistionSelect.Name = "posistionSelect";
            this.posistionSelect.Size = new System.Drawing.Size(170, 29);
            this.posistionSelect.TabIndex = 94;
            this.posistionSelect.Text = "Home";
            this.posistionSelect.UseVisualStyleBackColor = false;
            this.posistionSelect.Click += new System.EventHandler(this.posistionSelect_Click_1);
            // 
            // motorSpeedLabel
            // 
            this.motorSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.motorSpeedLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.motorSpeedLabel.Location = new System.Drawing.Point(28, 18);
            this.motorSpeedLabel.Name = "motorSpeedLabel";
            this.motorSpeedLabel.Padding = new System.Windows.Forms.Padding(2);
            this.motorSpeedLabel.Size = new System.Drawing.Size(150, 28);
            this.motorSpeedLabel.TabIndex = 95;
            this.motorSpeedLabel.Text = "Motor Speed";
            this.motorSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.label33.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(227, 278);
            this.label33.Name = "label33";
            this.label33.Padding = new System.Windows.Forms.Padding(2);
            this.label33.Size = new System.Drawing.Size(0, 0);
            this.label33.TabIndex = 97;
            this.label33.Text = "Value";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clawServoUp
            // 
            this.clawServoUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.clawServoUp.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Plus3;
            this.clawServoUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clawServoUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.clawServoUp.FlatAppearance.BorderSize = 0;
            this.clawServoUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.clawServoUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.clawServoUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clawServoUp.Location = new System.Drawing.Point(285, 254);
            this.clawServoUp.Name = "clawServoUp";
            this.clawServoUp.Size = new System.Drawing.Size(34, 27);
            this.clawServoUp.TabIndex = 101;
            this.clawServoUp.UseVisualStyleBackColor = false;
            this.clawServoUp.Click += new System.EventHandler(this.clawServoUp_Click);
            this.clawServoUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clawServoUp_MouseDown);
            // 
            // clawServoDown
            // 
            this.clawServoDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.clawServoDown.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Minus;
            this.clawServoDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clawServoDown.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.clawServoDown.FlatAppearance.BorderSize = 0;
            this.clawServoDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.clawServoDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.clawServoDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clawServoDown.Location = new System.Drawing.Point(145, 254);
            this.clawServoDown.Name = "clawServoDown";
            this.clawServoDown.Size = new System.Drawing.Size(34, 27);
            this.clawServoDown.TabIndex = 100;
            this.clawServoDown.UseVisualStyleBackColor = false;
            this.clawServoDown.Click += new System.EventHandler(this.clawServoDown_Click);
            this.clawServoDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clawServoDown_MouseDown);
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label35.Location = new System.Drawing.Point(145, 281);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 3);
            this.label35.TabIndex = 103;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label36.Location = new System.Drawing.Point(285, 281);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 3);
            this.label36.TabIndex = 102;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.label37.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(438, 140);
            this.label37.Name = "label37";
            this.label37.Padding = new System.Windows.Forms.Padding(3);
            this.label37.Size = new System.Drawing.Size(0, 0);
            this.label37.TabIndex = 104;
            this.label37.Text = "Claw:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label38.Location = new System.Drawing.Point(258, 280);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(10, 0);
            this.label38.TabIndex = 105;
            // 
            // actuateVice
            // 
            this.actuateVice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.actuateVice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.actuateVice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.actuateVice.FlatAppearance.BorderSize = 0;
            this.actuateVice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.actuateVice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.actuateVice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actuateVice.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.actuateVice.Location = new System.Drawing.Point(325, 254);
            this.actuateVice.Name = "actuateVice";
            this.actuateVice.Size = new System.Drawing.Size(94, 27);
            this.actuateVice.TabIndex = 106;
            this.actuateVice.Text = "Clamp";
            this.actuateVice.UseVisualStyleBackColor = false;
            this.actuateVice.Click += new System.EventHandler(this.actuateVice_Click);
            this.actuateVice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.actuateVice_MouseDown);
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label39.Location = new System.Drawing.Point(325, 281);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(94, 3);
            this.label39.TabIndex = 107;
            // 
            // moveClawBackground
            // 
            this.moveClawBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.moveClawBackground.Location = new System.Drawing.Point(185, 254);
            this.moveClawBackground.Name = "moveClawBackground";
            this.moveClawBackground.Size = new System.Drawing.Size(94, 29);
            this.moveClawBackground.TabIndex = 113;
            // 
            // actuateClaw
            // 
            this.actuateClaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.actuateClaw.FlatAppearance.BorderSize = 0;
            this.actuateClaw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.actuateClaw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.actuateClaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actuateClaw.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.actuateClaw.Location = new System.Drawing.Point(55, 254);
            this.actuateClaw.Name = "actuateClaw";
            this.actuateClaw.Size = new System.Drawing.Size(84, 27);
            this.actuateClaw.TabIndex = 114;
            this.actuateClaw.Text = "Close";
            this.actuateClaw.UseVisualStyleBackColor = false;
            this.actuateClaw.Click += new System.EventHandler(this.actuateClaw_Click);
            this.actuateClaw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.actuateClaw_MouseDown);
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label34.Location = new System.Drawing.Point(55, 281);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(84, 3);
            this.label34.TabIndex = 115;
            // 
            // comPortSelection
            // 
            this.comPortSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.comPortSelection.FlatAppearance.BorderSize = 0;
            this.comPortSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.comPortSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.comPortSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comPortSelection.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.comPortSelection.Location = new System.Drawing.Point(35, 93);
            this.comPortSelection.Name = "comPortSelection";
            this.comPortSelection.Size = new System.Drawing.Size(120, 29);
            this.comPortSelection.TabIndex = 123;
            this.comPortSelection.Text = "COM Port";
            this.comPortSelection.UseVisualStyleBackColor = false;
            this.comPortSelection.Click += new System.EventHandler(this.comPortSelection_Click);
            // 
            // comOption4
            // 
            this.comOption4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.comOption4.Enabled = false;
            this.comOption4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comOption4.ForeColor = System.Drawing.Color.White;
            this.comOption4.Location = new System.Drawing.Point(35, 214);
            this.comOption4.Name = "comOption4";
            this.comOption4.Padding = new System.Windows.Forms.Padding(2);
            this.comOption4.Size = new System.Drawing.Size(120, 29);
            this.comOption4.TabIndex = 120;
            this.comOption4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comOption4.Visible = false;
            this.comOption4.Click += new System.EventHandler(this.comOption4_Click);
            // 
            // comOption3
            // 
            this.comOption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.comOption3.Enabled = false;
            this.comOption3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comOption3.ForeColor = System.Drawing.Color.White;
            this.comOption3.Location = new System.Drawing.Point(35, 184);
            this.comOption3.Name = "comOption3";
            this.comOption3.Padding = new System.Windows.Forms.Padding(2);
            this.comOption3.Size = new System.Drawing.Size(120, 29);
            this.comOption3.TabIndex = 119;
            this.comOption3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comOption3.Visible = false;
            this.comOption3.Click += new System.EventHandler(this.comOption3_Click);
            // 
            // comOption2
            // 
            this.comOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.comOption2.Enabled = false;
            this.comOption2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comOption2.ForeColor = System.Drawing.Color.White;
            this.comOption2.Location = new System.Drawing.Point(35, 154);
            this.comOption2.Name = "comOption2";
            this.comOption2.Padding = new System.Windows.Forms.Padding(2);
            this.comOption2.Size = new System.Drawing.Size(120, 29);
            this.comOption2.TabIndex = 118;
            this.comOption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comOption2.Visible = false;
            this.comOption2.Click += new System.EventHandler(this.comOption2_Click);
            // 
            // comOption1
            // 
            this.comOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.comOption1.Enabled = false;
            this.comOption1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comOption1.ForeColor = System.Drawing.Color.White;
            this.comOption1.Location = new System.Drawing.Point(35, 124);
            this.comOption1.Name = "comOption1";
            this.comOption1.Padding = new System.Windows.Forms.Padding(2);
            this.comOption1.Size = new System.Drawing.Size(120, 29);
            this.comOption1.TabIndex = 117;
            this.comOption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comOption1.Visible = false;
            this.comOption1.Click += new System.EventHandler(this.comOption1_Click);
            // 
            // comPortDrop
            // 
            this.comPortDrop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comPortDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.comPortDrop.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Drop_Down_Arrow1;
            this.comPortDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.comPortDrop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.comPortDrop.FlatAppearance.BorderSize = 0;
            this.comPortDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comPortDrop.Location = new System.Drawing.Point(156, 93);
            this.comPortDrop.Name = "comPortDrop";
            this.comPortDrop.Size = new System.Drawing.Size(29, 29);
            this.comPortDrop.TabIndex = 116;
            this.comPortDrop.UseVisualStyleBackColor = false;
            this.comPortDrop.Click += new System.EventHandler(this.comPortDrop_Click);
            // 
            // baudRateSelection
            // 
            this.baudRateSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.baudRateSelection.FlatAppearance.BorderSize = 0;
            this.baudRateSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.baudRateSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.baudRateSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baudRateSelection.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.baudRateSelection.Location = new System.Drawing.Point(190, 93);
            this.baudRateSelection.Name = "baudRateSelection";
            this.baudRateSelection.Size = new System.Drawing.Size(120, 29);
            this.baudRateSelection.TabIndex = 131;
            this.baudRateSelection.Text = "Baud Rate";
            this.baudRateSelection.UseVisualStyleBackColor = false;
            // 
            // baud19200
            // 
            this.baud19200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.baud19200.Enabled = false;
            this.baud19200.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud19200.ForeColor = System.Drawing.Color.White;
            this.baud19200.Location = new System.Drawing.Point(190, 184);
            this.baud19200.Name = "baud19200";
            this.baud19200.Padding = new System.Windows.Forms.Padding(2);
            this.baud19200.Size = new System.Drawing.Size(120, 29);
            this.baud19200.TabIndex = 127;
            this.baud19200.Text = "19200";
            this.baud19200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baud19200.Visible = false;
            this.baud19200.Click += new System.EventHandler(this.baud19200_Click);
            // 
            // baud9600
            // 
            this.baud9600.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.baud9600.Enabled = false;
            this.baud9600.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud9600.ForeColor = System.Drawing.Color.White;
            this.baud9600.Location = new System.Drawing.Point(190, 154);
            this.baud9600.Name = "baud9600";
            this.baud9600.Padding = new System.Windows.Forms.Padding(2);
            this.baud9600.Size = new System.Drawing.Size(120, 29);
            this.baud9600.TabIndex = 126;
            this.baud9600.Text = "9600";
            this.baud9600.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baud9600.Visible = false;
            this.baud9600.Click += new System.EventHandler(this.baud9600_Click);
            // 
            // baud4800
            // 
            this.baud4800.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.baud4800.Enabled = false;
            this.baud4800.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud4800.ForeColor = System.Drawing.Color.White;
            this.baud4800.Location = new System.Drawing.Point(190, 124);
            this.baud4800.Name = "baud4800";
            this.baud4800.Padding = new System.Windows.Forms.Padding(2);
            this.baud4800.Size = new System.Drawing.Size(120, 29);
            this.baud4800.TabIndex = 125;
            this.baud4800.Text = "4800";
            this.baud4800.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baud4800.Visible = false;
            this.baud4800.Click += new System.EventHandler(this.baud4800_Click);
            // 
            // baudRateDrop
            // 
            this.baudRateDrop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baudRateDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.baudRateDrop.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Drop_Down_Arrow1;
            this.baudRateDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.baudRateDrop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.baudRateDrop.FlatAppearance.BorderSize = 0;
            this.baudRateDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baudRateDrop.Location = new System.Drawing.Point(311, 93);
            this.baudRateDrop.Name = "baudRateDrop";
            this.baudRateDrop.Size = new System.Drawing.Size(29, 29);
            this.baudRateDrop.TabIndex = 124;
            this.baudRateDrop.UseVisualStyleBackColor = false;
            this.baudRateDrop.Click += new System.EventHandler(this.baudRateDrop_Click);
            // 
            // serialLink
            // 
            this.serialLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.serialLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.serialLink.FlatAppearance.BorderSize = 0;
            this.serialLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.serialLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.serialLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serialLink.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.serialLink.Location = new System.Drawing.Point(35, 60);
            this.serialLink.Margin = new System.Windows.Forms.Padding(0);
            this.serialLink.Name = "serialLink";
            this.serialLink.Size = new System.Drawing.Size(305, 26);
            this.serialLink.TabIndex = 132;
            this.serialLink.Text = "Establish Link";
            this.serialLink.UseVisualStyleBackColor = false;
            this.serialLink.Click += new System.EventHandler(this.button3_Click);
            this.serialLink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.serialLink_MouseDown);
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.label41.Location = new System.Drawing.Point(35, 86);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(305, 3);
            this.label41.TabIndex = 133;
            // 
            // runBatch
            // 
            this.runBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.runBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.runBatch.FlatAppearance.BorderSize = 0;
            this.runBatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.runBatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.runBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runBatch.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBatch.Location = new System.Drawing.Point(49, 28);
            this.runBatch.Margin = new System.Windows.Forms.Padding(0);
            this.runBatch.Name = "runBatch";
            this.runBatch.Size = new System.Drawing.Size(305, 32);
            this.runBatch.TabIndex = 134;
            this.runBatch.Text = "Run Batch";
            this.runBatch.UseVisualStyleBackColor = false;
            this.runBatch.Click += new System.EventHandler(this.runBatch_Click);
            this.runBatch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.runBatch_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(49, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 3);
            this.label1.TabIndex = 135;
            // 
            // partsToRun
            // 
            this.partsToRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.partsToRun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partsToRun.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsToRun.ForeColor = System.Drawing.Color.White;
            this.partsToRun.Location = new System.Drawing.Point(156, 73);
            this.partsToRun.Name = "partsToRun";
            this.partsToRun.Size = new System.Drawing.Size(90, 24);
            this.partsToRun.TabIndex = 142;
            this.partsToRun.Text = "0";
            this.partsToRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partsToRun.Click += new System.EventHandler(this.partsToRun_Click);
            this.partsToRun.Leave += new System.EventHandler(this.partsToRun_Leave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(227, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 0);
            this.label3.TabIndex = 140;
            // 
            // partsToRunUp
            // 
            this.partsToRunUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.partsToRunUp.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Plus3;
            this.partsToRunUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.partsToRunUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.partsToRunUp.FlatAppearance.BorderSize = 0;
            this.partsToRunUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.partsToRunUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.partsToRunUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partsToRunUp.Location = new System.Drawing.Point(254, 70);
            this.partsToRunUp.Name = "partsToRunUp";
            this.partsToRunUp.Size = new System.Drawing.Size(34, 27);
            this.partsToRunUp.TabIndex = 137;
            this.partsToRunUp.UseVisualStyleBackColor = false;
            this.partsToRunUp.Click += new System.EventHandler(this.partsToRunUp_Click);
            this.partsToRunUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.partsToRunUp_MouseDown);
            // 
            // partsToRunDown
            // 
            this.partsToRunDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.partsToRunDown.BackgroundImage = global::Automated_Coaster_Milling_GUI.Properties.Resources.Minus;
            this.partsToRunDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.partsToRunDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.partsToRunDown.FlatAppearance.BorderSize = 0;
            this.partsToRunDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.partsToRunDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.partsToRunDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partsToRunDown.Location = new System.Drawing.Point(114, 70);
            this.partsToRunDown.Name = "partsToRunDown";
            this.partsToRunDown.Size = new System.Drawing.Size(34, 27);
            this.partsToRunDown.TabIndex = 136;
            this.partsToRunDown.UseVisualStyleBackColor = false;
            this.partsToRunDown.Click += new System.EventHandler(this.partsToRunDown_Click);
            this.partsToRunDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.partsToRunDown_MouseDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.label4.Location = new System.Drawing.Point(114, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 3);
            this.label4.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.label5.Location = new System.Drawing.Point(254, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 3);
            this.label5.TabIndex = 138;
            // 
            // partsToRunBackground
            // 
            this.partsToRunBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.partsToRunBackground.Location = new System.Drawing.Point(154, 70);
            this.partsToRunBackground.Name = "partsToRunBackground";
            this.partsToRunBackground.Size = new System.Drawing.Size(94, 30);
            this.partsToRunBackground.TabIndex = 143;
            // 
            // importFile
            // 
            this.importFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.importFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.importFile.FlatAppearance.BorderSize = 0;
            this.importFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(145)))), ((int)(((byte)(19)))));
            this.importFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.importFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFile.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.importFile.Location = new System.Drawing.Point(222, 89);
            this.importFile.Margin = new System.Windows.Forms.Padding(0);
            this.importFile.Name = "importFile";
            this.importFile.Size = new System.Drawing.Size(136, 26);
            this.importFile.TabIndex = 144;
            this.importFile.Text = "Import";
            this.importFile.UseVisualStyleBackColor = false;
            this.importFile.Click += new System.EventHandler(this.importFile_Click);
            this.importFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.importFile_MouseDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(222, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 3);
            this.label6.TabIndex = 145;
            // 
            // fileToImport
            // 
            this.fileToImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.fileToImport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileToImport.Font = new System.Drawing.Font("Calibri", 10.25F, System.Drawing.FontStyle.Bold);
            this.fileToImport.ForeColor = System.Drawing.Color.White;
            this.fileToImport.Location = new System.Drawing.Point(12, 59);
            this.fileToImport.Name = "fileToImport";
            this.fileToImport.Size = new System.Drawing.Size(512, 17);
            this.fileToImport.TabIndex = 147;
            this.fileToImport.Text = "H:\\Automated Coaster Milling\\GUI\\Automated Coaster Milling GUI\\Data.txt";
            this.fileToImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addressBorder
            // 
            this.addressBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.addressBorder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBorder.ForeColor = System.Drawing.Color.White;
            this.addressBorder.Location = new System.Drawing.Point(10, 53);
            this.addressBorder.Name = "addressBorder";
            this.addressBorder.Padding = new System.Windows.Forms.Padding(2);
            this.addressBorder.Size = new System.Drawing.Size(516, 28);
            this.addressBorder.TabIndex = 148;
            this.addressBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressBackground
            // 
            this.addressBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.addressBackground.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBackground.ForeColor = System.Drawing.Color.White;
            this.addressBackground.Location = new System.Drawing.Point(12, 55);
            this.addressBackground.Name = "addressBackground";
            this.addressBackground.Padding = new System.Windows.Forms.Padding(2);
            this.addressBackground.Size = new System.Drawing.Size(512, 24);
            this.addressBackground.TabIndex = 149;
            this.addressBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseBorder
            // 
            this.browseBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.browseBorder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBorder.ForeColor = System.Drawing.Color.White;
            this.browseBorder.Location = new System.Drawing.Point(530, 53);
            this.browseBorder.Name = "browseBorder";
            this.browseBorder.Padding = new System.Windows.Forms.Padding(2);
            this.browseBorder.Size = new System.Drawing.Size(33, 28);
            this.browseBorder.TabIndex = 150;
            this.browseBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseImport
            // 
            this.browseImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.browseImport.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseImport.ForeColor = System.Drawing.Color.White;
            this.browseImport.Location = new System.Drawing.Point(532, 55);
            this.browseImport.Name = "browseImport";
            this.browseImport.Padding = new System.Windows.Forms.Padding(2);
            this.browseImport.Size = new System.Drawing.Size(29, 24);
            this.browseImport.TabIndex = 151;
            this.browseImport.Text = "...";
            this.browseImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.browseImport.Click += new System.EventHandler(this.browseImport_Click);
            // 
            // selectDataFile
            // 
            this.selectDataFile.AutoSize = true;
            this.selectDataFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDataFile.Location = new System.Drawing.Point(201, 22);
            this.selectDataFile.Name = "selectDataFile";
            this.selectDataFile.Size = new System.Drawing.Size(180, 25);
            this.selectDataFile.TabIndex = 152;
            this.selectDataFile.Text = "Select Data File";
            // 
            // linkParamaters
            // 
            this.linkParamaters.AutoSize = true;
            this.linkParamaters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.linkParamaters.Location = new System.Drawing.Point(58, 29);
            this.linkParamaters.Name = "linkParamaters";
            this.linkParamaters.Size = new System.Drawing.Size(262, 26);
            this.linkParamaters.TabIndex = 153;
            this.linkParamaters.Text = "Define Link Parameters";
            // 
            // speedText
            // 
            this.speedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.speedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speedText.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.speedText.ForeColor = System.Drawing.Color.White;
            this.speedText.Location = new System.Drawing.Point(66, 55);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(73, 23);
            this.speedText.TabIndex = 154;
            this.speedText.Text = "50";
            this.speedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedText.Click += new System.EventHandler(this.speedText_Click);
            this.speedText.Leave += new System.EventHandler(this.speedText_Leave);
            // 
            // moveClaw
            // 
            this.moveClaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.moveClaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moveClaw.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.moveClaw.ForeColor = System.Drawing.Color.White;
            this.moveClaw.Location = new System.Drawing.Point(187, 257);
            this.moveClaw.Name = "moveClaw";
            this.moveClaw.Size = new System.Drawing.Size(90, 23);
            this.moveClaw.TabIndex = 156;
            this.moveClaw.Text = "20";
            this.moveClaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moveClaw.Click += new System.EventHandler(this.moveClaw_Click_1);
            this.moveClaw.Leave += new System.EventHandler(this.moveClaw_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(187, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label9.Location = new System.Drawing.Point(428, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 158;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label11.Location = new System.Drawing.Point(428, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 159;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label12.Location = new System.Drawing.Point(428, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 25);
            this.label12.TabIndex = 160;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label13.Location = new System.Drawing.Point(429, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 25);
            this.label13.TabIndex = 161;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label15.Location = new System.Drawing.Point(429, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 25);
            this.label15.TabIndex = 162;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label17.Location = new System.Drawing.Point(65, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 25);
            this.label17.TabIndex = 163;
            // 
            // posistionSelectLabel
            // 
            this.posistionSelectLabel.AutoSize = true;
            this.posistionSelectLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.posistionSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.posistionSelectLabel.Location = new System.Drawing.Point(181, 31);
            this.posistionSelectLabel.Name = "posistionSelectLabel";
            this.posistionSelectLabel.Size = new System.Drawing.Size(194, 26);
            this.posistionSelectLabel.TabIndex = 165;
            this.posistionSelectLabel.Text = "Posistion Control";
            // 
            // rotationPosistionLabel
            // 
            this.rotationPosistionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.rotationPosistionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationPosistionLabel.ForeColor = System.Drawing.Color.White;
            this.rotationPosistionLabel.Location = new System.Drawing.Point(237, 100);
            this.rotationPosistionLabel.Name = "rotationPosistionLabel";
            this.rotationPosistionLabel.Padding = new System.Windows.Forms.Padding(2);
            this.rotationPosistionLabel.Size = new System.Drawing.Size(185, 29);
            this.rotationPosistionLabel.TabIndex = 170;
            this.rotationPosistionLabel.Text = "Rotation";
            this.rotationPosistionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectorPitchPosistionLabel
            // 
            this.effectorPitchPosistionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.effectorPitchPosistionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectorPitchPosistionLabel.ForeColor = System.Drawing.Color.White;
            this.effectorPitchPosistionLabel.Location = new System.Drawing.Point(236, 240);
            this.effectorPitchPosistionLabel.Name = "effectorPitchPosistionLabel";
            this.effectorPitchPosistionLabel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.effectorPitchPosistionLabel.Size = new System.Drawing.Size(185, 29);
            this.effectorPitchPosistionLabel.TabIndex = 169;
            this.effectorPitchPosistionLabel.Text = "Effector Pitch";
            this.effectorPitchPosistionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // effectorYawPosistionLabel
            // 
            this.effectorYawPosistionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.effectorYawPosistionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectorYawPosistionLabel.ForeColor = System.Drawing.Color.White;
            this.effectorYawPosistionLabel.Location = new System.Drawing.Point(236, 205);
            this.effectorYawPosistionLabel.Name = "effectorYawPosistionLabel";
            this.effectorYawPosistionLabel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.effectorYawPosistionLabel.Size = new System.Drawing.Size(185, 29);
            this.effectorYawPosistionLabel.TabIndex = 168;
            this.effectorYawPosistionLabel.Text = "Effector Yaw";
            this.effectorYawPosistionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondaryArmPosistionLabel
            // 
            this.secondaryArmPosistionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.secondaryArmPosistionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryArmPosistionLabel.ForeColor = System.Drawing.Color.White;
            this.secondaryArmPosistionLabel.Location = new System.Drawing.Point(236, 170);
            this.secondaryArmPosistionLabel.Name = "secondaryArmPosistionLabel";
            this.secondaryArmPosistionLabel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.secondaryArmPosistionLabel.Size = new System.Drawing.Size(185, 29);
            this.secondaryArmPosistionLabel.TabIndex = 167;
            this.secondaryArmPosistionLabel.Text = "Secondary Arm";
            this.secondaryArmPosistionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainArmPosistionLabel
            // 
            this.mainArmPosistionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.mainArmPosistionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainArmPosistionLabel.ForeColor = System.Drawing.Color.White;
            this.mainArmPosistionLabel.Location = new System.Drawing.Point(175, 688);
            this.mainArmPosistionLabel.Name = "mainArmPosistionLabel";
            this.mainArmPosistionLabel.Padding = new System.Windows.Forms.Padding(2);
            this.mainArmPosistionLabel.Size = new System.Drawing.Size(185, 29);
            this.mainArmPosistionLabel.TabIndex = 166;
            this.mainArmPosistionLabel.Text = "Main Arm";
            this.mainArmPosistionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label24.Location = new System.Drawing.Point(55, 317);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 3);
            this.label24.TabIndex = 172;
            // 
            // millStop
            // 
            this.millStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.millStop.FlatAppearance.BorderSize = 0;
            this.millStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.millStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.millStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.millStop.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.millStop.Location = new System.Drawing.Point(55, 290);
            this.millStop.Name = "millStop";
            this.millStop.Size = new System.Drawing.Size(117, 27);
            this.millStop.TabIndex = 171;
            this.millStop.Text = "Start";
            this.millStop.UseVisualStyleBackColor = false;
            this.millStop.Click += new System.EventHandler(this.millStop_Click);
            this.millStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.millStop_MouseDown);
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label44.Location = new System.Drawing.Point(178, 317);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(118, 3);
            this.label44.TabIndex = 174;
            // 
            // millStart
            // 
            this.millStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.millStart.FlatAppearance.BorderSize = 0;
            this.millStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.millStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.millStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.millStart.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.millStart.Location = new System.Drawing.Point(178, 290);
            this.millStart.Name = "millStart";
            this.millStart.Size = new System.Drawing.Size(118, 27);
            this.millStart.TabIndex = 173;
            this.millStart.Text = "Stop";
            this.millStart.UseVisualStyleBackColor = false;
            this.millStart.Click += new System.EventHandler(this.millStart_Click);
            this.millStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.millStart_MouseDown);
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.label45.Location = new System.Drawing.Point(302, 317);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(117, 3);
            this.label45.TabIndex = 176;
            // 
            // millRewind
            // 
            this.millRewind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.millRewind.FlatAppearance.BorderSize = 0;
            this.millRewind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.millRewind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(94)))));
            this.millRewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.millRewind.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.millRewind.Location = new System.Drawing.Point(302, 290);
            this.millRewind.Name = "millRewind";
            this.millRewind.Size = new System.Drawing.Size(117, 27);
            this.millRewind.TabIndex = 175;
            this.millRewind.Text = "Rewind";
            this.millRewind.UseVisualStyleBackColor = false;
            this.millRewind.Click += new System.EventHandler(this.millRewind_Click);
            this.millRewind.MouseDown += new System.Windows.Forms.MouseEventHandler(this.millRewind_MouseDown);
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label47.Location = new System.Drawing.Point(8, 21);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(542, 273);
            this.label47.TabIndex = 179;
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.label48.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(6, 19);
            this.label48.Name = "label48";
            this.label48.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label48.Size = new System.Drawing.Size(546, 277);
            this.label48.TabIndex = 180;
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label49.Location = new System.Drawing.Point(29, 36);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(414, 300);
            this.label49.TabIndex = 181;
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.label50.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(27, 34);
            this.label50.Name = "label50";
            this.label50.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label50.Size = new System.Drawing.Size(418, 304);
            this.label50.TabIndex = 182;
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label51.Location = new System.Drawing.Point(30, 15);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(345, 96);
            this.label51.TabIndex = 183;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(63)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 52);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 155;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posistionControlPanel
            // 
            this.posistionControlPanel.Controls.Add(this.rotationP);
            this.posistionControlPanel.Controls.Add(this.label15);
            this.posistionControlPanel.Controls.Add(this.rotationBackground);
            this.posistionControlPanel.Controls.Add(this.mainArmP);
            this.posistionControlPanel.Controls.Add(this.label13);
            this.posistionControlPanel.Controls.Add(this.mainArmBackground);
            this.posistionControlPanel.Controls.Add(this.secondaryArmP);
            this.posistionControlPanel.Controls.Add(this.label12);
            this.posistionControlPanel.Controls.Add(this.secondaryArmBackground);
            this.posistionControlPanel.Controls.Add(this.effectorYawP);
            this.posistionControlPanel.Controls.Add(this.label11);
            this.posistionControlPanel.Controls.Add(this.effectorPitchP);
            this.posistionControlPanel.Controls.Add(this.label9);
            this.posistionControlPanel.Controls.Add(this.label25);
            this.posistionControlPanel.Controls.Add(this.posistionDropButton);
            this.posistionControlPanel.Controls.Add(this.rotationPosistionLabel);
            this.posistionControlPanel.Controls.Add(this.homePosistion);
            this.posistionControlPanel.Controls.Add(this.effectorPitchPosistionLabel);
            this.posistionControlPanel.Controls.Add(this.aboveVicePosistion);
            this.posistionControlPanel.Controls.Add(this.effectorYawPosistionLabel);
            this.posistionControlPanel.Controls.Add(this.vicePosistion);
            this.posistionControlPanel.Controls.Add(this.secondaryArmPosistionLabel);
            this.posistionControlPanel.Controls.Add(this.abovePickupPosistion);
            this.posistionControlPanel.Controls.Add(this.pickupPosistion);
            this.posistionControlPanel.Controls.Add(this.posistionSelectLabel);
            this.posistionControlPanel.Controls.Add(this.label29);
            this.posistionControlPanel.Controls.Add(this.recordPosistion);
            this.posistionControlPanel.Controls.Add(this.moveToPosistion);
            this.posistionControlPanel.Controls.Add(this.label10);
            this.posistionControlPanel.Controls.Add(this.posistionSelect);
            this.posistionControlPanel.Controls.Add(this.label33);
            this.posistionControlPanel.Controls.Add(this.label37);
            this.posistionControlPanel.Controls.Add(this.effectorYawBackground);
            this.posistionControlPanel.Controls.Add(this.effectorPitchBackground);
            this.posistionControlPanel.Controls.Add(this.label47);
            this.posistionControlPanel.Controls.Add(this.label48);
            this.posistionControlPanel.Enabled = false;
            this.posistionControlPanel.Location = new System.Drawing.Point(60, 306);
            this.posistionControlPanel.Name = "posistionControlPanel";
            this.posistionControlPanel.Size = new System.Drawing.Size(565, 308);
            this.posistionControlPanel.TabIndex = 185;
            this.posistionControlPanel.Visible = false;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.label25.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(237, 135);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(2);
            this.label25.Size = new System.Drawing.Size(185, 29);
            this.label25.TabIndex = 181;
            this.label25.Text = "Main Arm";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // componentControlPanel
            // 
            this.componentControlPanel.Controls.Add(this.millRewind);
            this.componentControlPanel.Controls.Add(this.millStart);
            this.componentControlPanel.Controls.Add(this.millStop);
            this.componentControlPanel.Controls.Add(this.mainArmUp);
            this.componentControlPanel.Controls.Add(this.mainArmDown);
            this.componentControlPanel.Controls.Add(this.secondaryArmDown);
            this.componentControlPanel.Controls.Add(this.effectorYawDown);
            this.componentControlPanel.Controls.Add(this.effectorPitchDown);
            this.componentControlPanel.Controls.Add(this.effectorPitchUp);
            this.componentControlPanel.Controls.Add(this.effectorYawUp);
            this.componentControlPanel.Controls.Add(this.secondaryArmUp);
            this.componentControlPanel.Controls.Add(this.rotationUp);
            this.componentControlPanel.Controls.Add(this.rotationDown);
            this.componentControlPanel.Controls.Add(this.clawServoDown);
            this.componentControlPanel.Controls.Add(this.clawServoUp);
            this.componentControlPanel.Controls.Add(this.actuateVice);
            this.componentControlPanel.Controls.Add(this.actuateClaw);
            this.componentControlPanel.Controls.Add(this.label27);
            this.componentControlPanel.Controls.Add(this.moveClaw);
            this.componentControlPanel.Controls.Add(this.label8);
            this.componentControlPanel.Controls.Add(this.moveClawBackground);
            this.componentControlPanel.Controls.Add(this.label45);
            this.componentControlPanel.Controls.Add(this.label14);
            this.componentControlPanel.Controls.Add(this.label44);
            this.componentControlPanel.Controls.Add(this.label16);
            this.componentControlPanel.Controls.Add(this.label18);
            this.componentControlPanel.Controls.Add(this.label24);
            this.componentControlPanel.Controls.Add(this.label19);
            this.componentControlPanel.Controls.Add(this.label20);
            this.componentControlPanel.Controls.Add(this.label21);
            this.componentControlPanel.Controls.Add(this.label22);
            this.componentControlPanel.Controls.Add(this.label23);
            this.componentControlPanel.Controls.Add(this.mainArmLabel);
            this.componentControlPanel.Controls.Add(this.mainArmE);
            this.componentControlPanel.Controls.Add(this.secondaryArmLabel);
            this.componentControlPanel.Controls.Add(this.secondaryArmE);
            this.componentControlPanel.Controls.Add(this.effectorYawLabel);
            this.componentControlPanel.Controls.Add(this.effectorYawE);
            this.componentControlPanel.Controls.Add(this.effectorPitchLabel);
            this.componentControlPanel.Controls.Add(this.effectorPitchE);
            this.componentControlPanel.Controls.Add(this.label28);
            this.componentControlPanel.Controls.Add(this.label26);
            this.componentControlPanel.Controls.Add(this.rotationLabel);
            this.componentControlPanel.Controls.Add(this.rotationE);
            this.componentControlPanel.Controls.Add(this.label36);
            this.componentControlPanel.Controls.Add(this.label35);
            this.componentControlPanel.Controls.Add(this.label38);
            this.componentControlPanel.Controls.Add(this.label39);
            this.componentControlPanel.Controls.Add(this.label34);
            this.componentControlPanel.Controls.Add(this.label49);
            this.componentControlPanel.Controls.Add(this.label50);
            this.componentControlPanel.Enabled = false;
            this.componentControlPanel.Location = new System.Drawing.Point(693, 278);
            this.componentControlPanel.Name = "componentControlPanel";
            this.componentControlPanel.Size = new System.Drawing.Size(479, 361);
            this.componentControlPanel.TabIndex = 186;
            this.componentControlPanel.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(129, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(218, 26);
            this.label27.TabIndex = 183;
            this.label27.Text = "Component Control";
            // 
            // linkPanel
            // 
            this.linkPanel.Controls.Add(this.comOption5);
            this.linkPanel.Controls.Add(this.linkParamaters);
            this.linkPanel.Controls.Add(this.baudRateDrop);
            this.linkPanel.Controls.Add(this.comPortDrop);
            this.linkPanel.Controls.Add(this.comOption1);
            this.linkPanel.Controls.Add(this.comOption2);
            this.linkPanel.Controls.Add(this.comOption3);
            this.linkPanel.Controls.Add(this.comOption4);
            this.linkPanel.Controls.Add(this.comPortSelection);
            this.linkPanel.Controls.Add(this.baud4800);
            this.linkPanel.Controls.Add(this.baud9600);
            this.linkPanel.Controls.Add(this.baud19200);
            this.linkPanel.Controls.Add(this.baudRateSelection);
            this.linkPanel.Controls.Add(this.label41);
            this.linkPanel.Controls.Add(this.serialLink);
            this.linkPanel.Enabled = false;
            this.linkPanel.Location = new System.Drawing.Point(448, 232);
            this.linkPanel.Name = "linkPanel";
            this.linkPanel.Size = new System.Drawing.Size(372, 354);
            this.linkPanel.TabIndex = 187;
            this.linkPanel.Visible = false;
            // 
            // comOption5
            // 
            this.comOption5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.comOption5.Enabled = false;
            this.comOption5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comOption5.ForeColor = System.Drawing.Color.White;
            this.comOption5.Location = new System.Drawing.Point(34, 244);
            this.comOption5.Name = "comOption5";
            this.comOption5.Padding = new System.Windows.Forms.Padding(2);
            this.comOption5.Size = new System.Drawing.Size(120, 29);
            this.comOption5.TabIndex = 154;
            this.comOption5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comOption5.Visible = false;
            this.comOption5.Click += new System.EventHandler(this.comOption5_Click);
            // 
            // dataFilePanel
            // 
            this.dataFilePanel.Controls.Add(this.selectDataFile);
            this.dataFilePanel.Controls.Add(this.label6);
            this.dataFilePanel.Controls.Add(this.importFile);
            this.dataFilePanel.Controls.Add(this.fileToImport);
            this.dataFilePanel.Controls.Add(this.browseImport);
            this.dataFilePanel.Controls.Add(this.addressBackground);
            this.dataFilePanel.Controls.Add(this.addressBorder);
            this.dataFilePanel.Controls.Add(this.browseBorder);
            this.dataFilePanel.Location = new System.Drawing.Point(347, 241);
            this.dataFilePanel.Name = "dataFilePanel";
            this.dataFilePanel.Size = new System.Drawing.Size(570, 142);
            this.dataFilePanel.TabIndex = 188;
            // 
            // runPanel
            // 
            this.runPanel.Controls.Add(this.label1);
            this.runPanel.Controls.Add(this.partsToRun);
            this.runPanel.Controls.Add(this.label3);
            this.runPanel.Controls.Add(this.label5);
            this.runPanel.Controls.Add(this.label4);
            this.runPanel.Controls.Add(this.partsToRunDown);
            this.runPanel.Controls.Add(this.partsToRunUp);
            this.runPanel.Controls.Add(this.runBatch);
            this.runPanel.Controls.Add(this.label2);
            this.runPanel.Controls.Add(this.partsToRunBackground);
            this.runPanel.Controls.Add(this.label51);
            this.runPanel.Controls.Add(this.label52);
            this.runPanel.Enabled = false;
            this.runPanel.Location = new System.Drawing.Point(438, 78);
            this.runPanel.Name = "runPanel";
            this.runPanel.Size = new System.Drawing.Size(408, 121);
            this.runPanel.TabIndex = 189;
            this.runPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(156, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 191;
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.label52.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(28, 13);
            this.label52.Name = "label52";
            this.label52.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.label52.Size = new System.Drawing.Size(349, 100);
            this.label52.TabIndex = 184;
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motorSpeedPanel
            // 
            this.motorSpeedPanel.Controls.Add(this.motorSpeedLabel);
            this.motorSpeedPanel.Controls.Add(this.label31);
            this.motorSpeedPanel.Controls.Add(this.speedUp);
            this.motorSpeedPanel.Controls.Add(this.label32);
            this.motorSpeedPanel.Controls.Add(this.speedDown);
            this.motorSpeedPanel.Controls.Add(this.speedText);
            this.motorSpeedPanel.Controls.Add(this.label17);
            this.motorSpeedPanel.Controls.Add(this.label7);
            this.motorSpeedPanel.Enabled = false;
            this.motorSpeedPanel.Location = new System.Drawing.Point(535, 205);
            this.motorSpeedPanel.Name = "motorSpeedPanel";
            this.motorSpeedPanel.Size = new System.Drawing.Size(200, 100);
            this.motorSpeedPanel.TabIndex = 190;
            this.motorSpeedPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1154, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 191;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1114, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 30);
            this.button2.TabIndex = 192;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.motorSpeedPanel);
            this.Controls.Add(this.dataFilePanel);
            this.Controls.Add(this.linkPanel);
            this.Controls.Add(this.runPanel);
            this.Controls.Add(this.mainArmPosistionLabel);
            this.Controls.Add(this.posistionControlPanel);
            this.Controls.Add(this.componentControlPanel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.posistionControlPanel.ResumeLayout(false);
            this.posistionControlPanel.PerformLayout();
            this.componentControlPanel.ResumeLayout(false);
            this.componentControlPanel.PerformLayout();
            this.linkPanel.ResumeLayout(false);
            this.linkPanel.PerformLayout();
            this.dataFilePanel.ResumeLayout(false);
            this.dataFilePanel.PerformLayout();
            this.runPanel.ResumeLayout(false);
            this.runPanel.PerformLayout();
            this.motorSpeedPanel.ResumeLayout(false);
            this.motorSpeedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label mainArmLabel;
        private System.Windows.Forms.Label mainArmE;
        private System.Windows.Forms.Label secondaryArmE;
        private System.Windows.Forms.Label secondaryArmLabel;
        private System.Windows.Forms.Label effectorYawE;
        private System.Windows.Forms.Label effectorYawLabel;
        private System.Windows.Forms.Label effectorPitchE;
        private System.Windows.Forms.Label effectorPitchLabel;
        private System.Windows.Forms.Button mainArmUp;
        private System.Windows.Forms.Button mainArmDown;
        private System.Windows.Forms.Button secondaryArmDown;
        private System.Windows.Forms.Button effectorYawDown;
        private System.Windows.Forms.Button effectorPitchDown;
        private System.Windows.Forms.Button effectorPitchUp;
        private System.Windows.Forms.Button effectorYawUp;
        private System.Windows.Forms.Button secondaryArmUp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button posistionDropButton;
        private System.Windows.Forms.Label homePosistion;
        private System.Windows.Forms.Label aboveVicePosistion;
        private System.Windows.Forms.Label abovePickupPosistion;
        private System.Windows.Forms.Label vicePosistion;
        private System.Windows.Forms.Label pickupPosistion;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button recordPosistion;
        private System.Windows.Forms.Button moveToPosistion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label mainArmBackground;
        private System.Windows.Forms.Label secondaryArmBackground;
        private System.Windows.Forms.Label effectorYawBackground;
        private System.Windows.Forms.Label effectorPitchBackground;
        private System.Windows.Forms.TextBox mainArmP;
        private System.Windows.Forms.TextBox secondaryArmP;
        private System.Windows.Forms.TextBox effectorYawP;
        private System.Windows.Forms.TextBox effectorPitchP;
        private System.Windows.Forms.TextBox rotationP;
        private System.Windows.Forms.Button rotationDown;
        private System.Windows.Forms.Button rotationUp;
        private System.Windows.Forms.Label rotationE;
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label rotationBackground;
        private System.Windows.Forms.Button speedUp;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button speedDown;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button posistionSelect;
        private System.Windows.Forms.Label motorSpeedLabel;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button clawServoUp;
        private System.Windows.Forms.Button clawServoDown;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button actuateVice;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label moveClawBackground;
        private System.Windows.Forms.Button actuateClaw;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button comPortSelection;
        private System.Windows.Forms.Label comOption4;
        private System.Windows.Forms.Label comOption3;
        private System.Windows.Forms.Label comOption2;
        private System.Windows.Forms.Label comOption1;
        private System.Windows.Forms.Button comPortDrop;
        private System.Windows.Forms.Button baudRateSelection;
        private System.Windows.Forms.Label baud19200;
        private System.Windows.Forms.Label baud9600;
        private System.Windows.Forms.Label baud4800;
        private System.Windows.Forms.Button baudRateDrop;
        private System.Windows.Forms.Button serialLink;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button runBatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partsToRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button partsToRunUp;
        private System.Windows.Forms.Button partsToRunDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label partsToRunBackground;
        private System.Windows.Forms.Button importFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileToImport;
        private System.Windows.Forms.Label addressBorder;
        private System.Windows.Forms.Label addressBackground;
        private System.Windows.Forms.Label browseBorder;
        private System.Windows.Forms.Label browseImport;
        private System.Windows.Forms.Label selectDataFile;
        private System.Windows.Forms.Label linkParamaters;
        private System.Windows.Forms.TextBox speedText;
        private System.Windows.Forms.TextBox moveClaw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label posistionSelectLabel;
        private System.Windows.Forms.Label rotationPosistionLabel;
        private System.Windows.Forms.Label effectorPitchPosistionLabel;
        private System.Windows.Forms.Label effectorYawPosistionLabel;
        private System.Windows.Forms.Label secondaryArmPosistionLabel;
        private System.Windows.Forms.Label mainArmPosistionLabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button millStop;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button millStart;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button millRewind;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel posistionControlPanel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel componentControlPanel;
        private System.Windows.Forms.Panel linkPanel;
        private System.Windows.Forms.Panel dataFilePanel;
        private System.Windows.Forms.Panel runPanel;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel motorSpeedPanel;
        private System.Windows.Forms.Label comOption5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

