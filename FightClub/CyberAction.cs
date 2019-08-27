using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fighters;

namespace FightClub
{   
    public partial class CyberAction : Form
    {
        private KindOfAction actionKind;
        private ActionChoose actionChosen;
        public KindOfAction ActionKind
        {
            get
            {
                return actionKind;
            }
            set
            {
                if (value == KindOfAction.Attack)
                {
                    main_label.Text = "Choose a way to attack another hacker:";
                }
                else
                {
                    main_label.Text = "Choose a way to defend against another hacker:";
                }
                actionKind = value;
            }
        }
        public CyberAttack cyberAction { get; private set; }

        internal CyberAction(ActionChoose actionChoose)
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
