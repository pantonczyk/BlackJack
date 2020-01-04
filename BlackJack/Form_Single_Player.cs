using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_Single_Player : Form
    {
        internal Deck deck_player = new Deck();
        public static int ResultPlayer;
        internal static List<Card> ListCardPlayer = new List<Card>();

        internal Deck deck_computer = new Deck();
        public static int ResultComputer;
        internal static List<Card> ListCardComputer = new List<Card>();

        public Form_Single_Player()
        {
            InitializeComponent();
        }
        private void btn_single_player_random_Click(object sender, EventArgs e)
        {
            try
            {
                if (deck_player.currentlyUsedDeckOfCards.Count == 0) btn_single_player_random.Enabled = false;
                else
                {
                    var CardRandom = deck_player.RandomCard(deck_player.currentlyUsedDeckOfCards);
                    ListCardPlayer.Add(CardRandom);
                    deck_player.wylosowane.Add(CardRandom);
                    deck_player.currentlyUsedDeckOfCards.Remove(CardRandom);
                    Tb_List_Random_Cards.Text += string.Join(" ", CardRandom.ToString());
                    var result = deck_player.CountPoints(deck_player.wylosowane);
                    ResultPlayer = result;
                    label3.Text = string.Join(" ", result);
                }
            }
            catch
            {
                MessageBox.Show("Wylosowałeś wszystkie karty!!");
            }
        }

        private void btn_single_player_reuslt_Click(object sender, EventArgs e)
        {
            while (ResultComputer < 21)
            {
                var CardRandom = deck_computer.RandomCard(deck_computer.currentlyUsedDeckOfCards);
                ListCardComputer.Add(CardRandom);
                deck_computer.wylosowane.Add(CardRandom);
                deck_computer.currentlyUsedDeckOfCards.Remove(CardRandom);
                ResultComputer = deck_computer.CountPoints(deck_computer.wylosowane);
                if (ResultComputer >= 17) break;
            }
            this.Hide();
        }
        private void Form_Single_Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
