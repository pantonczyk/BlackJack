using System;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_about : Form
    {
        public Form_about()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_black_jack f_black_jack = new Form_black_jack();
            this.Close();
            f_black_jack.Show();
        }

        private void Form_about_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_black_jack f_black_jack = new Form_black_jack();    
            f_black_jack.Show();
        }
    }
}
