using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_Single_Game : Form
    {
        Deck deck_computer = new Deck();
        internal List<Card> ListCardComputer = new List<Card>();
        
        public Form_Single_Game()
        {
            InitializeComponent();
        }

        private void Form_Single_Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_single_player_back_Click(object sender, EventArgs e)
        {
            Form_black_jack f_black_jack = new Form_black_jack();
            this.Hide();
            f_black_jack.ShowDialog();
        }

        private void btn_single_player_start_game_Click(object sender, EventArgs e)
        {
            Tb_List_Player.Text = string.Empty;
            Tb_List_Computer.Text = string.Empty;
            Form_Single_Player.ListCardPlayer.Clear();
            Form_Single_Player.ListCardComputer.Clear();
            Form_Single_Player.ResultComputer = 0;

            Form_Single_Player f_single_player = new Form_Single_Player();
            f_single_player.ShowDialog();

            var resultPlayer = Form_Single_Player.ResultPlayer;
            var resultComputer = Form_Single_Player.ResultComputer;
            label_Result.Text = WhoWin(resultPlayer, resultComputer);


            foreach (var item in Form_Single_Player.ListCardPlayer)
            {
                Tb_List_Player.Text += string.Join(" ", item.ToString());
            }
            foreach (var item in Form_Single_Player.ListCardComputer)
            {
                Tb_List_Computer.Text += string.Join(" ", item.ToString());
            }

        }


        public string WhoWin(int result1, int result2)
        {
            var player1 = 21 - result1;
            var player2 = 21 - result2;
            if (Math.Abs(player1) < Math.Abs(player2)) return "Wygrał pierwszy gracz!";
            else if (Math.Abs(player1) > Math.Abs(player2)) return "Wygrał Computer!";
            else return "REMIS!!";
        }
    }
}
