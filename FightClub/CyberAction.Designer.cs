namespace FightClub
{
    partial class CyberAction
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
            this.mailbombing_button = new System.Windows.Forms.Button();
            this.dos_button = new System.Windows.Forms.Button();
            this.mitm_button = new System.Windows.Forms.Button();
            this.main_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mailbombing_button
            // 
            this.mailbombing_button.Location = new System.Drawing.Point(67, 151);
            this.mailbombing_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mailbombing_button.Name = "mailbombing_button";
            this.mailbombing_button.Size = new System.Drawing.Size(252, 56);
            this.mailbombing_button.TabIndex = 0;
            this.mailbombing_button.Text = "Mailbombing";
            this.mailbombing_button.UseVisualStyleBackColor = true;
            this.mailbombing_button.Click += new System.EventHandler(this.mailbombing_button_Click);
            // 
            // dos_button
            // 
            this.dos_button.Location = new System.Drawing.Point(67, 215);
            this.dos_button.Margin = new System.Windows.Forms.Padding(4);
            this.dos_button.Name = "dos_button";
            this.dos_button.Size = new System.Drawing.Size(252, 56);
            this.dos_button.TabIndex = 1;
            this.dos_button.Text = "DOS-attack";
            this.dos_button.UseVisualStyleBackColor = true;
            this.dos_button.Click += new System.EventHandler(this.dos_button_Click);
            // 
            // mitm_button
            // 
            this.mitm_button.Location = new System.Drawing.Point(67, 279);
            this.mitm_button.Margin = new System.Windows.Forms.Padding(4);
            this.mitm_button.Name = "mitm_button";
            this.mitm_button.Size = new System.Drawing.Size(252, 56);
            this.mitm_button.TabIndex = 2;
            this.mitm_button.Text = "Man-in-the-middle";
            this.mitm_button.UseVisualStyleBackColor = true;
            this.mitm_button.Click += new System.EventHandler(this.mitm_button_Click);
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.main_label.Location = new System.Drawing.Point(12, 41);
            this.main_label.MaximumSize = new System.Drawing.Size(350, 0);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(345, 58);
            this.main_label.TabIndex = 3;
            this.main_label.Text = "Choose a way to attack another hacker:";
            // 
            // CyberAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.mitm_button);
            this.Controls.Add(this.dos_button);
            this.Controls.Add(this.mailbombing_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Location = new System.Drawing.Point(1110, 40);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CyberAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CyberAction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CyberAction_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mailbombing_button;
        private System.Windows.Forms.Button dos_button;
        private System.Windows.Forms.Button mitm_button;
        private System.Windows.Forms.Label main_label;
    }
}