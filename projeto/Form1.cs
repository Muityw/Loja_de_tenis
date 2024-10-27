using System;
using Fashion_Games;
using dados_registro;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            Fashion_Games.registro outroform = new Fashion_Games.registro();
            this.Hide();
            outroform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}