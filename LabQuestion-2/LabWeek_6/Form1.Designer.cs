namespace LabWeek_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            btnStartTimer = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            lblCountDown = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // btnStartTimer
            // 
            btnStartTimer.Location = new Point(304, 127);
            btnStartTimer.Name = "btnStartTimer";
            btnStartTimer.Size = new Size(139, 107);
            btnStartTimer.TabIndex = 0;
            btnStartTimer.Text = "Start Timer";
            btnStartTimer.UseVisualStyleBackColor = true;
            btnStartTimer.Click += btnStartTimer_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 472);
            progressBar1.Maximum = 60;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(766, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 444);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Remaining Time : ";
            // 
            // lblCountDown
            // 
            lblCountDown.AutoSize = true;
            lblCountDown.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblCountDown.Location = new Point(385, 430);
            lblCountDown.Name = "lblCountDown";
            lblCountDown.Size = new Size(42, 32);
            lblCountDown.TabIndex = 3;
            lblCountDown.Text = "60";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 495);
            Controls.Add(lblCountDown);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(btnStartTimer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button btnStartTimer;
        private ProgressBar progressBar1;
        private Label label1;
        private Label lblCountDown;
    }
}