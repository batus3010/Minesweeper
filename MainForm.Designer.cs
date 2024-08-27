namespace Minesweeper
{
    partial class MainForm
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
            this.RestartButton = new System.Windows.Forms.Button();
            this.BombsRemainingLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.DiffSelectButton = new System.Windows.Forms.Button();
            this.lblTimerLabelTxt = new System.Windows.Forms.Label();
            this.lblBombRemainingTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Yellow;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RestartButton.ForeColor = System.Drawing.Color.Black;
            this.RestartButton.Location = new System.Drawing.Point(382, 11);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(188, 86);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // BombsRemainingLabel
            // 
            this.BombsRemainingLabel.AutoSize = true;
            this.BombsRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BombsRemainingLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.BombsRemainingLabel.Location = new System.Drawing.Point(1107, 11);
            this.BombsRemainingLabel.Name = "BombsRemainingLabel";
            this.BombsRemainingLabel.Size = new System.Drawing.Size(75, 82);
            this.BombsRemainingLabel.TabIndex = 2;
            this.BombsRemainingLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TimerLabel.Location = new System.Drawing.Point(14, 11);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(75, 82);
            this.TimerLabel.TabIndex = 3;
            this.TimerLabel.Text = "0";
            // 
            // DiffSelectButton
            // 
            this.DiffSelectButton.BackColor = System.Drawing.Color.Yellow;
            this.DiffSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiffSelectButton.ForeColor = System.Drawing.Color.Black;
            this.DiffSelectButton.Location = new System.Drawing.Point(627, 11);
            this.DiffSelectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiffSelectButton.Name = "DiffSelectButton";
            this.DiffSelectButton.Size = new System.Drawing.Size(188, 86);
            this.DiffSelectButton.TabIndex = 4;
            this.DiffSelectButton.Text = "Select new difficulty";
            this.DiffSelectButton.UseVisualStyleBackColor = false;
            this.DiffSelectButton.Click += new System.EventHandler(this.DiffSelectButton_Click);
            // 
            // lblTimerLabelTxt
            // 
            this.lblTimerLabelTxt.AutoSize = true;
            this.lblTimerLabelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimerLabelTxt.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTimerLabelTxt.Location = new System.Drawing.Point(140, 38);
            this.lblTimerLabelTxt.Name = "lblTimerLabelTxt";
            this.lblTimerLabelTxt.Size = new System.Drawing.Size(191, 52);
            this.lblTimerLabelTxt.TabIndex = 5;
            this.lblTimerLabelTxt.Text = "seconds";
            // 
            // lblBombRemainingTxt
            // 
            this.lblBombRemainingTxt.AutoSize = true;
            this.lblBombRemainingTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBombRemainingTxt.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBombRemainingTxt.Location = new System.Drawing.Point(881, 38);
            this.lblBombRemainingTxt.Name = "lblBombRemainingTxt";
            this.lblBombRemainingTxt.Size = new System.Drawing.Size(228, 52);
            this.lblBombRemainingTxt.TabIndex = 6;
            this.lblBombRemainingTxt.Text = "mines left:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1217, 810);
            this.Controls.Add(this.lblBombRemainingTxt);
            this.Controls.Add(this.lblTimerLabelTxt);
            this.Controls.Add(this.DiffSelectButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.BombsRemainingLabel);
            this.Controls.Add(this.RestartButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label BombsRemainingLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button DiffSelectButton;
        private System.Windows.Forms.Label lblTimerLabelTxt;
        private System.Windows.Forms.Label lblBombRemainingTxt;
    }
}

