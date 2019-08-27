namespace FightClub
{
    partial class Menu
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
            this.start_button = new System.Windows.Forms.Button();
            this.enterName_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(108, 315);
            this.start_button.Margin = new System.Windows.Forms.Padding(0);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(217, 83);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start fight";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // enterName_label
            // 
            this.enterName_label.AutoSize = true;
            this.enterName_label.BackColor = System.Drawing.Color.Transparent;
            this.enterName_label.Location = new System.Drawing.Point(13, 46);
            this.enterName_label.Margin = new System.Windows.Forms.Padding(0);
            this.enterName_label.Name = "enterName_label";
            this.enterName_label.Size = new System.Drawing.Size(199, 26);
            this.enterName_label.TabIndex = 1;
            this.enterName_label.Text = "Enter your name:";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(18, 92);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(395, 32);
            this.name_textBox.TabIndex = 2;
            this.name_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_textBox_KeyDown);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(13, 144);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(218, 26);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Error: empty field";
            this.errorLabel.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 471);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.enterName_label);
            this.Controls.Add(this.start_button);
            this.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label enterName_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label errorLabel;
    }
}