using System;
using projeto;
using Fashion_Games;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Games
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void emailboxregistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void registro_Load(object sender, EventArgs e)
        {
            
        }

        private void registrarbotao_Click(object sender, EventArgs e)
        {
            Fashion_Games.Form3 outroform = new Fashion_Games.Form3();
            this.Hide();
            outroform.ShowDialog();
        }
    }
}
