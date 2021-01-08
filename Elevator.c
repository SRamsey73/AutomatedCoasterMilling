#pragma config(Sensor, dgtl1,  upB,            sensorTouch)
#pragma config(Sensor, dgtl2,  downB,          sensorTouch)
#pragma config(Motor,  port2,           elevatorM,     tmotorVex393_MC29, openLoop)
//*!!Code automatically generated by 'ROBOTC' configuration wizard               !!*//

void moveElevator(int state, int speed) {
	switch(state) {
		case 0:
			motor[elevatorM] = -speed;
			while(SensorValue(downB) != 1) {
			}
			motor[elevatorM] = 0;
		break;
		case 1:
			motor[elevatorM] = speed;
			while(SensorValue(upB) != 1) {
			}
			motor[elevatorM] = 0;
		break;
	}
}

task main() {

}