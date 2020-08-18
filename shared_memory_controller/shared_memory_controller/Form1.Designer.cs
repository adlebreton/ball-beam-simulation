namespace shared_memory_controller {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Execute = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.targetPosBar = new System.Windows.Forms.TrackBar();
            this.targetPosLabel = new System.Windows.Forms.Label();
            this.TargetPosDisp = new System.Windows.Forms.NumericUpDown();
            this.ballPosLabel = new System.Windows.Forms.Label();
            this.controllerLabel = new System.Windows.Forms.Label();
            this.ballPosDisp = new System.Windows.Forms.NumericUpDown();
            this.sharedMemoryLabel = new System.Windows.Forms.Label();
            this.sharedMemoryStatusLabel = new System.Windows.Forms.Label();
            this.controllerStatusLabel = new System.Windows.Forms.Label();
            this.targetAngleLabel = new System.Windows.Forms.Label();
            this.targetAngleDisp = new System.Windows.Forms.NumericUpDown();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.currentAngleLabel = new System.Windows.Forms.Label();
            this.currentAngleDisp = new System.Windows.Forms.NumericUpDown();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.shareMemoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.targetPosBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPosDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPosDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetAngleDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentAngleDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(15, 172);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 23);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Pause
            // 
            this.Pause.Enabled = false;
            this.Pause.Location = new System.Drawing.Point(96, 172);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 1;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // targetPosBar
            // 
            this.targetPosBar.Location = new System.Drawing.Point(52, 35);
            this.targetPosBar.Maximum = 475;
            this.targetPosBar.Minimum = -475;
            this.targetPosBar.Name = "targetPosBar";
            this.targetPosBar.Size = new System.Drawing.Size(165, 45);
            this.targetPosBar.TabIndex = 2;
            this.targetPosBar.Scroll += new System.EventHandler(this.targetposBar_Scroll);
            // 
            // targetPosLabel
            // 
            this.targetPosLabel.AutoSize = true;
            this.targetPosLabel.Location = new System.Drawing.Point(12, 35);
            this.targetPosLabel.Name = "targetPosLabel";
            this.targetPosLabel.Size = new System.Drawing.Size(38, 13);
            this.targetPosLabel.TabIndex = 3;
            this.targetPosLabel.Text = "Target";
            // 
            // TargetPosDisp
            // 
            this.TargetPosDisp.Location = new System.Drawing.Point(223, 35);
            this.TargetPosDisp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TargetPosDisp.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.TargetPosDisp.Name = "TargetPosDisp";
            this.TargetPosDisp.ReadOnly = true;
            this.TargetPosDisp.Size = new System.Drawing.Size(59, 20);
            this.TargetPosDisp.TabIndex = 4;
            // 
            // ballPosLabel
            // 
            this.ballPosLabel.AutoSize = true;
            this.ballPosLabel.Location = new System.Drawing.Point(12, 81);
            this.ballPosLabel.Name = "ballPosLabel";
            this.ballPosLabel.Size = new System.Drawing.Size(64, 13);
            this.ballPosLabel.TabIndex = 6;
            this.ballPosLabel.Text = "Ball Position";
            // 
            // controllerLabel
            // 
            this.controllerLabel.AutoSize = true;
            this.controllerLabel.Location = new System.Drawing.Point(15, 153);
            this.controllerLabel.Name = "controllerLabel";
            this.controllerLabel.Size = new System.Drawing.Size(74, 13);
            this.controllerLabel.TabIndex = 7;
            this.controllerLabel.Text = "Auto Stabilizer";
            // 
            // ballPosDisp
            // 
            this.ballPosDisp.Location = new System.Drawing.Point(82, 79);
            this.ballPosDisp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ballPosDisp.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.ballPosDisp.Name = "ballPosDisp";
            this.ballPosDisp.ReadOnly = true;
            this.ballPosDisp.Size = new System.Drawing.Size(59, 20);
            this.ballPosDisp.TabIndex = 5;
            this.ballPosDisp.ThousandsSeparator = true;
            // 
            // sharedMemoryLabel
            // 
            this.sharedMemoryLabel.AutoSize = true;
            this.sharedMemoryLabel.Location = new System.Drawing.Point(14, 122);
            this.sharedMemoryLabel.Name = "sharedMemoryLabel";
            this.sharedMemoryLabel.Size = new System.Drawing.Size(117, 13);
            this.sharedMemoryLabel.TabIndex = 8;
            this.sharedMemoryLabel.Text = "Shared Memory Status:";
            // 
            // sharedMemoryStatusLabel
            // 
            this.sharedMemoryStatusLabel.AutoSize = true;
            this.sharedMemoryStatusLabel.Location = new System.Drawing.Point(138, 122);
            this.sharedMemoryStatusLabel.Name = "sharedMemoryStatusLabel";
            this.sharedMemoryStatusLabel.Size = new System.Drawing.Size(79, 13);
            this.sharedMemoryStatusLabel.TabIndex = 9;
            this.sharedMemoryStatusLabel.Text = "Not Connected";
            // 
            // controllerStatusLabel
            // 
            this.controllerStatusLabel.AutoSize = true;
            this.controllerStatusLabel.Location = new System.Drawing.Point(95, 153);
            this.controllerStatusLabel.Name = "controllerStatusLabel";
            this.controllerStatusLabel.Size = new System.Drawing.Size(21, 13);
            this.controllerStatusLabel.TabIndex = 10;
            this.controllerStatusLabel.Text = "Off";
            // 
            // targetAngleLabel
            // 
            this.targetAngleLabel.AutoSize = true;
            this.targetAngleLabel.Location = new System.Drawing.Point(8, 203);
            this.targetAngleLabel.Name = "targetAngleLabel";
            this.targetAngleLabel.Size = new System.Drawing.Size(68, 13);
            this.targetAngleLabel.TabIndex = 12;
            this.targetAngleLabel.Text = "Target Angle";
            // 
            // targetAngleDisp
            // 
            this.targetAngleDisp.Location = new System.Drawing.Point(82, 201);
            this.targetAngleDisp.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.targetAngleDisp.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
            this.targetAngleDisp.Name = "targetAngleDisp";
            this.targetAngleDisp.ReadOnly = true;
            this.targetAngleDisp.Size = new System.Drawing.Size(59, 20);
            this.targetAngleDisp.TabIndex = 11;
            this.targetAngleDisp.ThousandsSeparator = true;
            // 
            // timerTick
            // 
            this.timerTick.Interval = 20;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // currentAngleLabel
            // 
            this.currentAngleLabel.AutoSize = true;
            this.currentAngleLabel.Location = new System.Drawing.Point(149, 205);
            this.currentAngleLabel.Name = "currentAngleLabel";
            this.currentAngleLabel.Size = new System.Drawing.Size(71, 13);
            this.currentAngleLabel.TabIndex = 14;
            this.currentAngleLabel.Text = "Current Angle";
            // 
            // currentAngleDisp
            // 
            this.currentAngleDisp.Location = new System.Drawing.Point(223, 203);
            this.currentAngleDisp.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.currentAngleDisp.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.currentAngleDisp.Name = "currentAngleDisp";
            this.currentAngleDisp.ReadOnly = true;
            this.currentAngleDisp.Size = new System.Drawing.Size(59, 20);
            this.currentAngleDisp.TabIndex = 13;
            this.currentAngleDisp.ThousandsSeparator = true;
            // 
            // timerUI
            // 
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // shareMemoryButton
            // 
            this.shareMemoryButton.Location = new System.Drawing.Point(223, 117);
            this.shareMemoryButton.Name = "shareMemoryButton";
            this.shareMemoryButton.Size = new System.Drawing.Size(75, 23);
            this.shareMemoryButton.TabIndex = 15;
            this.shareMemoryButton.Text = "Connect";
            this.shareMemoryButton.UseVisualStyleBackColor = true;
            this.shareMemoryButton.Click += new System.EventHandler(this.shareMemoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 275);
            this.Controls.Add(this.shareMemoryButton);
            this.Controls.Add(this.currentAngleLabel);
            this.Controls.Add(this.currentAngleDisp);
            this.Controls.Add(this.targetAngleLabel);
            this.Controls.Add(this.targetAngleDisp);
            this.Controls.Add(this.controllerStatusLabel);
            this.Controls.Add(this.sharedMemoryStatusLabel);
            this.Controls.Add(this.sharedMemoryLabel);
            this.Controls.Add(this.controllerLabel);
            this.Controls.Add(this.ballPosLabel);
            this.Controls.Add(this.ballPosDisp);
            this.Controls.Add(this.TargetPosDisp);
            this.Controls.Add(this.targetPosLabel);
            this.Controls.Add(this.targetPosBar);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Execute);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.targetPosBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPosDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPosDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetAngleDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentAngleDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.TrackBar targetPosBar;
        private System.Windows.Forms.Label targetPosLabel;
        private System.Windows.Forms.NumericUpDown TargetPosDisp;
        private System.Windows.Forms.Label ballPosLabel;
        private System.Windows.Forms.Label controllerLabel;
        private System.Windows.Forms.NumericUpDown ballPosDisp;
        private System.Windows.Forms.Label sharedMemoryLabel;
        private System.Windows.Forms.Label sharedMemoryStatusLabel;
        private System.Windows.Forms.Label controllerStatusLabel;
        private System.Windows.Forms.Label targetAngleLabel;
        private System.Windows.Forms.NumericUpDown targetAngleDisp;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Label currentAngleLabel;
        private System.Windows.Forms.NumericUpDown currentAngleDisp;
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.Button shareMemoryButton;
    }
}

