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
    internal delegate void ActionChoice();

    public partial class Fight : Form
    {
        const int hp = 100;
        const string botNickname = "CPU";

        private readonly UserActionForm userActionForm;
        private readonly Logging logging;
        
        readonly Player human;
        readonly Player bot;

        readonly Round round;

        public Fight(string humanNickname)
        {
            InitializeComponent();
            
            human = new Player(humanNickname, hp);
            bot = new Player(botNickname, hp);

            round = new Round(human, bot);

            ActionChoice actionChoice = new ActionChoice(ActionChoosen);
            userActionForm = new UserActionForm(actionChoice);
            logging = new Logging(humanNickname);

            
            human.Block += logging.Write;
            human.Wound += logging.Write;

            bot.Block += logging.Write;
            bot.Wound += logging.Write;

            userActionForm.Show();
            logging.Show();


            SetControlsInfo();
            StartNewRound();
        }

        private void SetControlsInfo()
        {
            player1Name_label.Text = human.Name;
            player2Name_label.Text = botNickname;

            if (round.Attacker == human)
            {
                player1Symb_label.Text = "🛡️";
                player2Symb_label.Text = "⚔️";
            }
            else
            {
                player1Symb_label.Text = "⚔️";
                player2Symb_label.Text = "🛡️";
            }
        }



        private void UpdatePlayersHPInfo()
        {

            player1_progressBar.Value = human.Hp;
            player2_progressBar.Value = bot.Hp;

            player1HP_label.Text = human.Hp.ToString();
            player2HP_label.Text = bot.Hp.ToString();

        }

        private void UpdatePlayersRolesInfo()
        {
            string temp = player1Symb_label.Text;
            player1Symb_label.Text = player2Symb_label.Text;

            player2Symb_label.Text = temp;
        }

        private void StartNewRound()
        {
            UpdatePlayersHPInfo();

            if (human.Hp == 0 || bot.Hp == 0)
            {
                GameOver((human.Hp == 0) ? human.Name : bot.Name);
                return;
            }
            else
            {
                UpdatePlayersRolesInfo();
            }

            logging.Write($"Round {round.RoundNumber}!");

            if (round.Attacker == human)
            {
                userActionForm.UserAction = UserAction.Attack;
                logging.Write($"{human.Name} is attacking now.");
            }
            else
            {
                userActionForm.UserAction = UserAction.Defense;
                logging.Write($"{botNickname} is attacking now.");
            }
            
            userActionForm.Enabled = true;
        }


        private void ActionChoosen()
        {
            userActionForm.Enabled = false;

            CyberAttack botAction = Bot.GenerateCPUAction();
            int damage = GenerateDamage();

            if (userActionForm.UserAction == UserAction.Defense)
            {
                human.SetBlock(userActionForm.cyberAction);
                human.GetHit(botAction, damage);
            }
            else
            {
                bot.SetBlock(botAction);
                bot.GetHit(userActionForm.cyberAction, damage);
            }
                        
            round.NextRound();
            StartNewRound();
        }

        private void GameOver(string winner_name)
        {
            MessageBox.Show($"Game over! {winner_name} has won!", "Fight over", MessageBoxButtons.OK);
            this.Close();
        }

        private int GenerateDamage()
        {
            Random random = new Random();
            return random.Next(5, 20);

        }

        private void Fight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
