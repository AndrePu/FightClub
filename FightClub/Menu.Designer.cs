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
            this.start_button.Location = new System.Drawing.Point(150, 300);
            this.start_button.Margin = new System.Windows.Forms.Padding(0);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(200, 80);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start fight";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // enterName_label
            // 
            this.enterName_label.AutoSize = true;
            this.enterName_label.BackColor = System.Drawing.Color.Transparent;
            this.enterName_label.Location = new System.Drawing.Point(12, 44);
            this.enterName_label.Margin = new System.Windows.Forms.Padding(0);
            this.enterName_label.Name = "enterName_label";
            this.enterName_label.Size = new System.Drawing.Size(161, 25);
            this.enterName_label.TabIndex = 1;
            this.enterName_label.Text = "Enter your name:";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(17, 88);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(450, 30);
            this.name_textBox.TabIndex = 2;
            this.name_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_textBox_KeyDown);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(12, 138);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(158, 25);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Error: empty field";
            this.errorLabel.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.enterName_label);
            this.Controls.Add(this.start_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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