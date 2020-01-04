using System;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_multi_player : Form
    {
        public Form_multi_player()
        {
            InitializeComponent();
        }


        #region Button
        private void btn_start_game_Click(object sender, EventArgs e)
        {
            Tb_List_Player_One.Text = string.Empty;
            Tb_List_Player_Two.Text = string.Empty;
            Form_player_one.ListCardPlayerOne.Clear();
            Form_player_two.ListCardPlayerTwo.Clear();

            Form_player_one f_player_one = new Form_player_one();
            f_player_one.ShowDialog();
            Form_player_two f_player_two = new Form_player_two();
            f_player_two.ShowDialog();

            var resultOne = Form_player_one.ResultPlayerOne;
            var resultTwo = Form_player_two.ResultPlayerTwo;

            label5.Text = WhoWin(resultOne, resultTwo);

            foreach (var item in Form_player_one.ListCardPlayerOne)
            {
                Tb_List_Player_One.Text += string.Join(" ", item.ToString()); 
            }
            foreach (var item in Form_player_two.ListCardPlayerTwo)
            {
                Tb_List_Player_Two.Text += string.Join(" ", item.ToString());
            }
        }
        private void btn_multi_player_back_Click(object sender, EventArgs e)
        {
            Form_black_jack f_black_jack = new Form_black_jack();
            this.Hide();
            f_black_jack.Show();
        }
        #endregion

        private void Form_multi_player_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public string WhoWin(int result1, int result2)
        {
            var player1 = 21 - result1;
            var player2 = 21 - result2;
            if (Math.Abs(player1) < Math.Abs(player2)) return "Wygrał pierwszy gracz";
            else if (Math.Abs(player1) > Math.Abs(player2)) return "Wygrał drugi gracz";
            else return "REMIS!!";
        }
    }
}
