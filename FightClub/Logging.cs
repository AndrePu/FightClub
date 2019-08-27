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
            logging_textBox.AppendText(String.Format("{0}: {1}\r\n", DateTime.Now.ToLongTimeString(), text));
        }

        public void Write(string player_name, int hp)
        {
            Write($"{player_name} has {hp} HP.");
        }
    }
}
