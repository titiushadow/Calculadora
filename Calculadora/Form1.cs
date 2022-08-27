using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void n2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1Text_Click(object sender, EventArgs e)
        {

        }

        private void n2Text_Click(object sender, EventArgs e)
        {

        }

        private void n3Text_Click(object sender, EventArgs e)
        {

        }

        private void Btn_soma_Click(object sender, EventArgs e)
        {
            Result.Text = (Convert.ToDouble(n1Box.Text) +
                Convert.ToDouble(n2Box.Text)).ToString();
        }

        private void Btn_subtracao_Click(object sender, EventArgs e)
        {
            Result.Text = (Convert.ToDouble(n1Box.Text) -
                Convert.ToDouble(n2Box.Text)).ToString();
        }
        private void Btn_divisao_Click(object sender, EventArgs e)
        {
            Result.Text = (Convert.ToDouble(n1Box.Text) /
                Convert.ToDouble(n2Box.Text)).ToString();
        }

        private void Btn_multiplicacao_Click(object sender, EventArgs e)
        {
            Result.Text = (Convert.ToDouble(n1Box.Text) *
                Convert.ToDouble(n2Box.Text)).ToString();
        }
        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
