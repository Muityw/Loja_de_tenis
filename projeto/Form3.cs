using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void nomecompletobox_TextChanged(object sender, EventArgs e)
        {
            Fashion_Games.Form3 outroform = new Fashion_Games.Form3();
            this.Hide();
            outroform.ShowDialog();

        }
    }
}
