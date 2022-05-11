using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmVermelho : Form
    {
        public FrmVermelho()
        {
            InitializeComponent();
        }

        private void exibirFormAmarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo frm = new FrmAmarelo(); //Indico qual form será aberto
            this.Close(); //fechar o atual
            frm.ShowDialog();
        }

        private void exibirFormVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho(); //Indico qual form será aberto
            this.Close(); //fechar o atual
            frm.ShowDialog();
        }

        private void exibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul(); //Indico qual form será aberto
            this.Close(); //fechar o atual
            frm.ShowDialog();
        }
    }
}
