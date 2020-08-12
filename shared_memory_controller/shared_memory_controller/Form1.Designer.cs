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
            this.angleBar = new System.Windows.Forms.TrackBar();
            this.angleLabel = new System.Windows.Forms.Label();
            this.angleDisp = new System.Windows.Forms.NumericUpDown();
            this.ballPosLabel = new System.Windows.Forms.Label();
            this.controllerLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ballBeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ballPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ballPosDisp = new System.Windows.Forms.NumericUpDown();
            this.sharedMemoryLabel = new System.Windows.Forms.Label();
            this.sharedMemoryStatusLabel = new System.Windows.Forms.Label();
            this.controllerStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.angleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleDisp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballPosDisp)).BeginInit();
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
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(96, 172);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 1;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            // 
            // angleBar
            // 
            this.angleBar.Location = new System.Drawing.Point(52, 35);
            this.angleBar.Maximum = 20;
            this.angleBar.Minimum = -20;
            this.angleBar.Name = "angleBar";
            this.angleBar.Size = new System.Drawing.Size(165, 45);
            this.angleBar.TabIndex = 2;
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Location = new System.Drawing.Point(12, 35);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(34, 13);
            this.angleLabel.TabIndex = 3;
            this.angleLabel.Text = "Angle";
            // 
            // angleDisp
            // 
            this.angleDisp.Location = new System.Drawing.Point(223, 35);
            this.angleDisp.Name = "angleDisp";
            this.angleDisp.Size = new System.Drawing.Size(59, 20);
            this.angleDisp.TabIndex = 4;
            // 
            // ballPosLabel
            // 
            this.ballPosLabel.AutoSize = true;
            this.ballPosLabel.Location = new System.Drawing.Point(12, 79);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ballBeamToolStripMenuItem,
            this.ballPlaneToolStripMenuItem,
            this.pendulumToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 70);
            // 
            // ballBeamToolStripMenuItem
            // 
            this.ballBeamToolStripMenuItem.Name = "ballBeamToolStripMenuItem";
            this.ballBeamToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ballBeamToolStripMenuItem.Text = "ball beam";
            // 
            // ballPlaneToolStripMenuItem
            // 
            this.ballPlaneToolStripMenuItem.Name = "ballPlaneToolStripMenuItem";
            this.ballPlaneToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ballPlaneToolStripMenuItem.Text = "ball plane";
            // 
            // pendulumToolStripMenuItem
            // 
            this.pendulumToolStripMenuItem.Name = "pendulumToolStripMenuItem";
            this.pendulumToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pendulumToolStripMenuItem.Text = "pendulum";
            // 
            // ballPosDisp
            // 
            this.ballPosDisp.Location = new System.Drawing.Point(96, 77);
            this.ballPosDisp.Name = "ballPosDisp";
            this.ballPosDisp.ReadOnly = true;
            this.ballPosDisp.Size = new System.Drawing.Size(59, 20);
            this.ballPosDisp.TabIndex = 5;
            this.ballPosDisp.ThousandsSeparator = true;
            // 
            // sharedMemoryLabel
            // 
            this.sharedMemoryLabel.AutoSize = true;
            this.sharedMemoryLabel.Location = new System.Drawing.Point(15, 214);
            this.sharedMemoryLabel.Name = "sharedMemoryLabel";
            this.sharedMemoryLabel.Size = new System.Drawing.Size(117, 13);
            this.sharedMemoryLabel.TabIndex = 8;
            this.sharedMemoryLabel.Text = "Shared Memory Status:";
            // 
            // sharedMemoryStatusLabel
            // 
            this.sharedMemoryStatusLabel.AutoSize = true;
            this.sharedMemoryStatusLabel.Location = new System.Drawing.Point(139, 214);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.controllerStatusLabel);
            this.Controls.Add(this.sharedMemoryStatusLabel);
            this.Controls.Add(this.sharedMemoryLabel);
            this.Controls.Add(this.controllerLabel);
            this.Controls.Add(this.ballPosLabel);
            this.Controls.Add(this.ballPosDisp);
            this.Controls.Add(this.angleDisp);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.angleBar);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Execute);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.angleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleDisp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ballPosDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.TrackBar angleBar;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.NumericUpDown angleDisp;
        private System.Windows.Forms.Label ballPosLabel;
        private System.Windows.Forms.Label controllerLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ballBeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ballPlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendulumToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown ballPosDisp;
        private System.Windows.Forms.Label sharedMemoryLabel;
        private System.Windows.Forms.Label sharedMemoryStatusLabel;
        private System.Windows.Forms.Label controllerStatusLabel;
    }
}

