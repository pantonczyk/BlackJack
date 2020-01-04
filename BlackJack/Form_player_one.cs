using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_player_one : Form
    {
        internal Deck deck_player_one = new Deck();
        public static int ResultPlayerOne;
        internal static List<Card> ListCardPlayerOne = new List<Card>();


        public Form_player_one()
        {
            InitializeComponent();
        }

        #region Button
        private void btn_player_one_random_Click(object sender, EventArgs e)
        {
            try
            {
                if (deck_player_one.currentlyUsedDeckOfCards.Count == 0) btn_player_one_random.Enabled = false;
                else
                {
                    var CardRandom = deck_player_one.RandomCard(deck_player_one.currentlyUsedDeckOfCards);
                    ListCardPlayerOne.Add(CardRandom);
                    deck_player_one.wylosowane.Add(CardRandom);
                    deck_player_one.currentlyUsedDeckOfCards.Remove(CardRandom);
                    Tb_List_Random_Cards.Text += string.Join(" ", CardRandom.ToString());
                    var result = deck_player_one.CountPoints(deck_player_one.wylosowane);
                    ResultPlayerOne = result;
                    label3.Text = string.Join(" ", result);
                }
            }
            catch
            {
                MessageBox.Show("Wylosowałeś wszystkie karty!!");
            }
        }

        private void btn_player_one_next_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        private void Form_player_one_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
