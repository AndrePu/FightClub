namespace FightClub
{
    partial class Fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.player1_pictureBox = new System.Windows.Forms.PictureBox();
            this.player2_pictureBox = new System.Windows.Forms.PictureBox();
            this.player1_progressBar = new System.Windows.Forms.ProgressBar();
            this.player2_progressBar = new System.Windows.Forms.ProgressBar();
            this.player1HP_label = new System.Windows.Forms.Label();
            this.player2HP_label = new System.Windows.Forms.Label();
            this.HP_label1 = new System.Windows.Forms.Label();
            this.HP_label2 = new System.Windows.Forms.Label();
            this.player1Name_label = new System.Windows.Forms.Label();
            this.player2Name_label = new System.Windows.Forms.Label();
            this.player1Symb_label = new System.Windows.Forms.Label();
            this.player2Symb_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // player1_pictureBox
            // 
            this.player1_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("player1_pictureBox.Image")));
            this.player1_pictureBox.Location = new System.Drawing.Point(72, 67);
            this.player1_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.player1_pictureBox.Name = "player1_pictureBox";
            this.player1_pictureBox.Size = new System.Drawing.Size(250, 250);
            this.player1_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1_pictureBox.TabIndex = 0;
            this.player1_pictureBox.TabStop = false;
            // 
            // player2_pictureBox
            // 
            this.player2_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("player2_pictureBox.Image")));
            this.player2_pictureBox.Location = new System.Drawing.Point(418, 67);
            this.player2_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.player2_pictureBox.Name = "player2_pictureBox";
            this.player2_pictureBox.Size = new System.Drawing.Size(250, 250);
            this.player2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2_pictureBox.TabIndex = 1;
            this.player2_pictureBox.TabStop = false;
            // 
            // player1_progressBar
            // 
            this.player1_progressBar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.player1_progressBar.ForeColor = System.Drawing.SystemColors.Info;
            this.player1_progressBar.Location = new System.Drawing.Point(72, 325);
            this.player1_progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.player1_progressBar.Name = "player1_progressBar";
            this.player1_progressBar.Size = new System.Drawing.Size(250, 38);
            this.player1_progressBar.Step = 1;
            this.player1_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.player1_progressBar.TabIndex = 2;
            this.player1_progressBar.Value = 20;
            // 
            // player2_progressBar
            // 
            this.player2_progressBar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.player2_progressBar.ForeColor = System.Drawing.SystemColors.Info;
            this.player2_progressBar.Location = new System.Drawing.Point(418, 325);
            this.player2_progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.player2_progressBar.Name = "player2_progressBar";
            this.player2_progressBar.Size = new System.Drawing.Size(250, 38);
            this.player2_progressBar.Step = 1;
            this.player2_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.player2_progressBar.TabIndex = 3;
            this.player2_progressBar.Value = 20;
            // 
            // player1HP_label
            // 
            this.player1HP_label.AutoSize = true;
            this.player1HP_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1HP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.player1HP_label.Location = new System.Drawing.Point(161, 367);
            this.player1HP_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1HP_label.Name = "player1HP_label";
            this.player1HP_label.Size = new System.Drawing.Size(64, 25);
            this.player1HP_label.TabIndex = 4;
            this.player1HP_label.Text = "label1";
            // 
            // player2HP_label
            // 
            this.player2HP_label.AutoSize = true;
            this.player2HP_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player2HP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.player2HP_label.Location = new System.Drawing.Point(509, 367);
            this.player2HP_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2HP_label.Name = "player2HP_label";
            this.player2HP_label.Size = new System.Drawing.Size(64, 25);
            this.player2HP_label.TabIndex = 5;
            this.player2HP_label.Text = "label1";
            // 
            // HP_label1
            // 
            this.HP_label1.AutoSize = true;
            this.HP_label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HP_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HP_label1.Location = new System.Drawing.Point(102, 367);
            this.HP_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HP_label1.Name = "HP_label1";
            this.HP_label1.Size = new System.Drawing.Size(45, 25);
            this.HP_label1.TabIndex = 6;
            this.HP_label1.Text = "HP:";
            // 
            // HP_label2
            // 
            this.HP_label2.AutoSize = true;
            this.HP_label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HP_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HP_label2.Location = new System.Drawing.Point(446, 367);
            this.HP_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HP_label2.Name = "HP_label2";
            this.HP_label2.Size = new System.Drawing.Size(45, 25);
            this.HP_label2.TabIndex = 7;
            this.HP_label2.Text = "HP:";
            // 
            // player1Name_label
            // 
            this.player1Name_label.AutoSize = true;
            this.player1Name_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.player1Name_label.Location = new System.Drawing.Point(161, 29);
            this.player1Name_label.Margin = new System.Windows.Forms.Padding(104, 0, 504, 0);
            this.player1Name_label.Name = "player1Name_label";
            this.player1Name_label.Size = new System.Drawing.Size(83, 25);
            this.player1Name_label.TabIndex = 8;
            this.player1Name_label.Text = "Player 1";
            this.player1Name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2Name_label
            // 
            this.player2Name_label.AutoSize = true;
            this.player2Name_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player2Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.player2Name_label.Location = new System.Drawing.Point(509, 29);
            this.player2Name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2Name_label.Name = "player2Name_label";
            this.player2Name_label.Size = new System.Drawing.Size(54, 25);
            this.player2Name_label.TabIndex = 9;
            this.player2Name_label.Text = "CPU";
            this.player2Name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player1Symb_label
            // 
            this.player1Symb_label.AutoSize = true;
            this.player1Symb_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1Symb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.player1Symb_label.Location = new System.Drawing.Point(113, 18);
            this.player1Symb_label.Margin = new System.Windows.Forms.Padding(104, 0, 504, 0);
            this.player1Symb_label.Name = "player1Symb_label";
            this.player1Symb_label.Size = new System.Drawing.Size(38, 39);
            this.player1Symb_label.TabIndex = 10;
            this.player1Symb_label.Text = "⚔️";
            this.player1Symb_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2Symb_label
            // 
            this.player2Symb_label.AutoSize = true;
            this.player2Symb_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player2Symb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.player2Symb_label.Location = new System.Drawing.Point(465, 18);
            this.player2Symb_label.Margin = new System.Windows.Forms.Padding(104, 0, 504, 0);
            this.player2Symb_label.Name = "player2Symb_label";
            this.player2Symb_label.Size = new System.Drawing.Size(45, 39);
            this.player2Symb_label.TabIndex = 11;
            this.player2Symb_label.Text = "🛡️";
            this.player2Symb_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.player2Symb_label);
            this.Controls.Add(this.player1Symb_label);
            this.Controls.Add(this.player2Name_label);
            this.Controls.Add(this.player1Name_label);
            this.Controls.Add(this.HP_label2);
            this.Controls.Add(this.HP_label1);
            this.Controls.Add(this.player2HP_label);
            this.Controls.Add(this.player1HP_label);
            this.Controls.Add(this.player2_progressBar);
            this.Controls.Add(this.player1_progressBar);
            this.Controls.Add(this.player2_pictureBox);
            this.Controls.Add(this.player1_pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Location = new System.Drawing.Point(300, 40);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fight";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fight_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.player1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1_pictureBox;
        private System.Windows.Forms.PictureBox player2_pictureBox;
        private System.Windows.Forms.ProgressBar player1_progressBar;
        private System.Windows.Forms.ProgressBar player2_progressBar;
        private System.Windows.Forms.Label player1HP_label;
        private System.Windows.Forms.Label player2HP_label;
        private System.Windows.Forms.Label HP_label1;
        private System.Windows.Forms.Label HP_label2;
        private System.Windows.Forms.Label player1Name_label;
        private System.Windows.Forms.Label player2Name_label;
        private System.Windows.Forms.Label player1Symb_label;
        private System.Windows.Forms.Label player2Symb_label;
    }
}