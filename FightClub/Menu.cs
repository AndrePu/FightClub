using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.name_textBox.Focus();
            this.ActiveControl = name_textBox;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            string player_name = name_textBox.Text;
            if (player_name == String.Empty)
            {
                errorLabel.Visible = true;
                this.ActiveControl = name_textBox;
                return;
            }

            Fight fight = new Fight(player_name);


            fight.Show();
            this.Hide();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                start_button_Click(sender, e);
            }
        }

        private void name_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                start_button_Click(sender, e);
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
