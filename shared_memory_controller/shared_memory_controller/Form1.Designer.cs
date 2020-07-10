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
            this.Execute = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Angle_bar = new System.Windows.Forms.TrackBar();
            this.angle_label = new System.Windows.Forms.Label();
            this.Angle_disp = new System.Windows.Forms.NumericUpDown();
            this.ballPos_disp = new System.Windows.Forms.NumericUpDown();
            this.ballPos_label = new System.Windows.Forms.Label();
            this.controller_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Angle_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle_disp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPos_disp)).BeginInit();
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
            // Angle_bar
            // 
            this.Angle_bar.Location = new System.Drawing.Point(52, 35);
            this.Angle_bar.Maximum = 20;
            this.Angle_bar.Minimum = -20;
            this.Angle_bar.Name = "Angle_bar";
            this.Angle_bar.Size = new System.Drawing.Size(165, 45);
            this.Angle_bar.TabIndex = 2;
            // 
            // angle_label
            // 
            this.angle_label.AutoSize = true;
            this.angle_label.Location = new System.Drawing.Point(12, 35);
            this.angle_label.Name = "angle_label";
            this.angle_label.Size = new System.Drawing.Size(34, 13);
            this.angle_label.TabIndex = 3;
            this.angle_label.Text = "Angle";
            // 
            // Angle_disp
            // 
            this.Angle_disp.Location = new System.Drawing.Point(223, 35);
            this.Angle_disp.Name = "Angle_disp";
            this.Angle_disp.Size = new System.Drawing.Size(59, 20);
            this.Angle_disp.TabIndex = 4;
            // 
            // ballPos_disp
            // 
            this.ballPos_disp.Location = new System.Drawing.Point(96, 77);
            this.ballPos_disp.Name = "ballPos_disp";
            this.ballPos_disp.Size = new System.Drawing.Size(59, 20);
            this.ballPos_disp.TabIndex = 5;
            // 
            // ballPos_label
            // 
            this.ballPos_label.AutoSize = true;
            this.ballPos_label.Location = new System.Drawing.Point(12, 79);
            this.ballPos_label.Name = "ballPos_label";
            this.ballPos_label.Size = new System.Drawing.Size(63, 13);
            this.ballPos_label.TabIndex = 6;
            this.ballPos_label.Text = "Ball position";
            // 
            // controller_label
            // 
            this.controller_label.AutoSize = true;
            this.controller_label.Location = new System.Drawing.Point(15, 153);
            this.controller_label.Name = "controller_label";
            this.controller_label.Size = new System.Drawing.Size(72, 13);
            this.controller_label.TabIndex = 7;
            this.controller_label.Text = "Auto stabilizer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.controller_label);
            this.Controls.Add(this.ballPos_label);
            this.Controls.Add(this.ballPos_disp);
            this.Controls.Add(this.Angle_disp);
            this.Controls.Add(this.angle_label);
            this.Controls.Add(this.Angle_bar);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Execute);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Angle_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle_disp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPos_disp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.TrackBar Angle_bar;
        private System.Windows.Forms.Label angle_label;
        private System.Windows.Forms.NumericUpDown Angle_disp;
        private System.Windows.Forms.NumericUpDown ballPos_disp;
        private System.Windows.Forms.Label ballPos_label;
        private System.Windows.Forms.Label controller_label;
    }
}

