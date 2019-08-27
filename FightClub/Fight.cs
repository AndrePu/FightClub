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
    internal delegate void ActionChoose();

    public partial class Fight : Form
    {
        private readonly CyberAction actionForm;
        private readonly Logging logging;

        const int hp = 100;
        const string botNickname = "CPU";

        readonly Player human;
        readonly Player bot;

        readonly Round round;

        public Fight(string humanNickname)
        {
            InitializeComponent();

            player1Name_label.Text = humanNickname;
            player2Name_label.Text = botNickname;

            human = new Player(humanNickname, hp);
            bot = new Player(botNickname, hp);

            round = new Round(human, bot);

            ActionChoose actionChoose = new ActionChoose(ActionChoose);
            actionForm = new CyberAction(actionChoose);
            actionForm.Show();

            logging = new Logging(humanNickname);

            human.Block += logging.Write;
            human.Wound += logging.Write;

            bot.Block += logging.Write;
            bot.Wound += logging.Write;

            logging.Show();

            player1_progressBar.Value = human.Hp;
            player2_progressBar.Value = bot.Hp;

            player1HP_label.Text = human.Hp.ToString();
            player2HP_label.Text = bot.Hp.ToString();

            StartNewRound();
        }

        private void StartNewRound()
        {

            if (round.Attacker == human)
            {
                actionForm.ActionKind = KindOfAction.Attack;
            }
            else
            {
                actionForm.ActionKind = KindOfAction.Defense;
            }
        }

        private void ActionChoose()
        {
            CyberAttack botAction = GenerateCPUAction();
            int damage = GenerateDamage();
            if (actionForm.ActionKind == KindOfAction.Defense)
            {
                human.SetBlock(actionForm.cyberAction);
                human.GetHit(botAction, damage);
            }
            else
            {
                bot.SetBlock(botAction);
                bot.GetHit(actionForm.cyberAction, damage);
            }

            player1_progressBar.Value = human.Hp;
            player2_progressBar.Value = bot.Hp;

            player1HP_label.Text = human.Hp.ToString();
            player2HP_label.Text = bot.Hp.ToString();

            actionForm.Hide();
            if (bot.Hp != 0 && human.Hp != 0)
            {
                round.NextRound();
                actionForm.Show();
                StartNewRound();
            }
            else
            {
                MessageBox.Show("Game over!", "Fight over", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private int GenerateDamage()
        {
            Random random = new Random();
            return random.Next(5, 20);

        }

        private CyberAttack GenerateCPUAction()
        {
            var random = new Random();

            return (CyberAttack)random.Next(0, 2);
        }

        private void Fight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
