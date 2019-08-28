using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fighting;

namespace FightClub
{   
    public partial class UserActionForm : Form
    {
        private UserAction userAction;
        private Action actionChosen;
        public UserAction UserAction
        {
            get
            {
                return userAction;
            }
            set
            {
                if (value == UserAction.Attack)
                {
                    main_label.Text = "Attack";
                }
                else
                {
                    main_label.Text = "Defend";
                }
                userAction = value;
            }
        }
        public CyberAttack cyberAction { get; private set; }

        internal UserActionForm(Action actionChoose)
        {
            InitializeComponent();

            actionChosen = actionChoose;
        }

        private void CyberAction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mailbombing_button_Click(object sender, EventArgs e)
        {
            cyberAction = CyberAttack.Mailbombing;
            actionChosen();
        }

        private void mitm_button_Click(object sender, EventArgs e)
        {
            cyberAction = CyberAttack.ManInTheMiddle;
            actionChosen();
        }

        private void dos_button_Click(object sender, EventArgs e)
        {
            cyberAction = CyberAttack.DOSAttack;
            actionChosen();
        }
    }
}
