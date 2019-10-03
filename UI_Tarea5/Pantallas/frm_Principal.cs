using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Tarea5
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pantallas.frm_Cifras_Divisores frmDivisores = new Pantallas.frm_Cifras_Divisores();
            this.Hide();
            frmDivisores.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pantallas.frm_TablasMultiplicar frmTablasMultiplicar = new Pantallas.frm_TablasMultiplicar();
            this.Hide();
            frmTablasMultiplicar.ShowDialog();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pantallas.frm_Fechas frmFechas = new Pantallas.frm_Fechas();
            this.Hide();
            frmFechas.ShowDialog();
            this.Close();
        }
    }
}
