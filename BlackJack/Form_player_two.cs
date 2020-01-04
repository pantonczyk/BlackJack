using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_player_two : Form
    {
        internal Deck deck_player_two = new Deck();
        public static int ResultPlayerTwo;
        internal static List<Card> ListCardPlayerTwo = new List<Card>();

        public Form_player_two()
        {
            InitializeComponent();
        }

        #region Button
        private void btn_player_two_random_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if (deck_player_two.currentlyUsedDeckOfCards.Count == 0) btn_player_two_random.Enabled = false;
                else
                {
                    var CardRandom = deck_player_two.RandomCard(deck_player_two.currentlyUsedDeckOfCards);
                    ListCardPlayerTwo.Add(CardRandom);
                    deck_player_two.wylosowane.Add(CardRandom);
                    deck_player_two.currentlyUsedDeckOfCards.Remove(CardRandom);
                    Tb_List_Random_Cards.Text += string.Join(" ", CardRandom.ToString());
                    var result = deck_player_two.CountPoints(deck_player_two.wylosowane);
                    ResultPlayerTwo = result;
                    label3.Text = string.Join(" ", result);
                }
            }
            catch
            {
                MessageBox.Show("Wylosowałeś wszystkie karty!!");
            }
        }

        private void btn_player_one_result_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        private void Form_player_two_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
