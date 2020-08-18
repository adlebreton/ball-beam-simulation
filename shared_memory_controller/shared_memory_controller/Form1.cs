using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PidController;



namespace shared_memory_controller {
    public partial class Form1 : Form {

        //variables for controller
        private float targetPos = 0;
        private float prevError = 0;
        private float prevU = 0;
        private float T = 0.07f;
        private float k = 1;
        private float a=7;
        private double targetAngle = 0;
        private bool useController = false;
        public Form1() {
            InitializeComponent();
        }

        //turn on and off the controller
        private void Execute_Click(object sender, EventArgs e) {
            controllerStatusLabel.Text = "On";
            Execute.Enabled = false;
            Pause.Enabled = true;
            useController = true;
        }

        private void Pause_Click(object sender, EventArgs e) {
            controllerStatusLabel.Text = "Off";
            Execute.Enabled = true;
            Pause.Enabled = false;
            useController = false;
        }

        private void targetposBar_Scroll(object sender, EventArgs e) {
            targetPos = targetPosBar.Value;
            TargetPosDisp.Value = Convert.ToDecimal(targetPos);
        }

        private void timerTick_Tick(object sender, EventArgs e) {//this will be used arround 60 times a second
            float currPos = SharingMemory.getPos();
            float delta = SharingMemory.getDelta();
            float temp1 =T/(T+delta);
            float temp2 = k * (delta * a * T) / (delta + T);
            float temp3 = -(k * a * T) / (delta + T);
            float error = (targetPos - currPos) * 0.1024f;
            float U = temp1 * prevU + temp2 * error + temp3 * prevError;
            prevError = error;
            targetAngle = Math.Max(Math.Min(45.0, U), -45.0);
            prevU = (float)targetAngle;
            if (useController) {
                SharingMemory.setAngle(Convert.ToSingle(targetAngle));// should you choose to use it or not, the previously mentionned value can be transmitted to the other program
            }
        }

        private void timerUI_Tick(object sender, EventArgs e) {
            //refresh the UI values
            float currPos = SharingMemory.getPos();
            float currAngle = SharingMemory.getAngle();
            currentAngleDisp.Value = Convert.ToDecimal(currAngle);
            ballPosDisp.Value = Convert.ToDecimal(currPos);
            targetAngleDisp.Value = Convert.ToDecimal(targetAngle);
        }

        private void shareMemoryButton_Click(object sender, EventArgs e) {
            if (SharingMemory.ConnectMappedMemory()) {
                sharedMemoryStatusLabel.Text = "Connected";
                shareMemoryButton.Enabled = false;
                timerTick.Enabled = true;
                timerUI.Enabled = true;
            } else
                sharedMemoryStatusLabel.Text = "Error, could not connect";
        }
    }
}