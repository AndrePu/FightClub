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
    public partial class Logging : Form
    {
        public Logging(string playerName)
        {
            InitializeComponent();

            Write($"{playerName} is preparing to fight!");
        }

        public void Write(string text)
        {
            logging_textBox.Text += String.Format("{0}: {1}", DateTime.Now.ToLongTimeString(), text);
            logging_textBox.Text += "\r\n\n\n\n";
        }

        public void Write(string player_name, int hp)
        {
            Write($"{player_name} has {hp} HP.");
        }
    }
}
