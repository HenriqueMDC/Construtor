using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Time time = new Time(txtNome.Text, txtPais.Text, txtSerie.Text)
            {
                Faturamento = Convert.ToDecimal(txtFaturamento.Text)
            };
        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            Time time = new Time(txtSerie2.Text, txtNome2.Text);
        }
    }
}
