using System;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_black_jack : Form
    {
        public Form_black_jack()
        {
            InitializeComponent();
        }
        #region Button
        private void btn_Single_Player_Click(object sender, EventArgs e)
        {
            Form_Single_Game f_single = new Form_Single_Game();
            this.Hide();
            f_single.Show();
        }

        private void btn_Multi_Player_Click(object sender, EventArgs e)
        {
            Form_multi_player f_multi = new Form_multi_player();
            this.Hide();
            f_multi.Show();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            Form_about f_about = new Form_about();
            this.Hide();
            f_about.Show();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Event
        private void Form_black_jack_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        
    }
}
