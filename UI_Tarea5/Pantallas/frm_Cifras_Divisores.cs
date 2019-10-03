using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Tarea5;
using BLL_Tarea5;

namespace UI_Tarea5.Pantallas
{
   
    public partial class frm_Cifras_Divisores : Form
    {
        #region VARIABLES
        cls_Divisores_DAL Obj_Divisores_DAL = new cls_Divisores_DAL();
        cls_Divisores_BLL Obj_Divisores_BLL = new cls_Divisores_BLL();
        #endregion
        public frm_Cifras_Divisores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Obj_Divisores_DAL = new cls_Divisores_DAL();
            Obj_Divisores_BLL = new cls_Divisores_BLL();
            txtCantCif.Text = "";
            txtCifMayor.Text = "";
            txtCifMenor.Text = "";
            txtNumDivs.Text = "";
            txtSumCifImpar.Text = "";
            txtSumCifPar.Text = "";
            lbox_Divisores.Items.Clear();
            btn_VerResultados.Enabled = true;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            btn_VerResultados.Enabled = false;
            Obj_Divisores_DAL.Num = Convert.ToInt32(txtNumDivs.Text);
            Obj_Divisores_BLL.calc_Divisores(ref Obj_Divisores_DAL);

            int[] array;
            array = Obj_Divisores_DAL.DivList.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                lbox_Divisores.Items.Add(array[i]);
            }

            Obj_Divisores_BLL.calculos_Numeros(ref Obj_Divisores_DAL);

            txtCantCif.Text = Obj_Divisores_DAL.CantCifras.ToString();
            txtSumCifPar.Text = Obj_Divisores_DAL.SumaPares.ToString();
            txtSumCifImpar.Text = Obj_Divisores_DAL.SumaImpares.ToString();
            txtCifMayor.Text = Obj_Divisores_DAL.CifMayor.ToString();
            txtCifMenor.Text = Obj_Divisores_DAL.CifMenor.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Principal frmMenu = new frm_Principal();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void txtNumDivs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten valores numéricos positivos");
                e.Handled = true;
            }
        }
    }
}
