using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Tarea5.TablasMultiplicar;
using BLL_Tarea5.TablasMultiplicar;

namespace UI_Tarea5.Pantallas
{
    public partial class frm_TablasMultiplicar : Form
    {
        #region VARIABLES
        cls_TablasMultiplicar_DAL Obj_TablasMultiplicar_DAL = new cls_TablasMultiplicar_DAL();
        cls_TablasMultiplicar_BLL Obj_TablasMultiplicar_BLL = new cls_TablasMultiplicar_BLL();
        #endregion
        public frm_TablasMultiplicar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ud_tablaDe.Value <= ud_TablaAl.Value)
            {
                btn_Cargar.Enabled = false;
                Obj_TablasMultiplicar_DAL.TablaDel = Convert.ToInt16(ud_tablaDe.Value);
                Obj_TablasMultiplicar_DAL.TablaHasta = Convert.ToInt16(ud_TablaAl.Value);
                Obj_TablasMultiplicar_BLL.itemsCombo(ref Obj_TablasMultiplicar_DAL);

                string[] array;
                array = Obj_TablasMultiplicar_DAL.MultList.ToArray();
                for (int i = 0; i < array.Length; i++)
                {
                    cmb_Tablas.Items.Add(array[i]);
                }
            }
            else {
                MessageBox.Show("El valor en el campo 'Del' no puede ser mayor al valor del campo 'Al'");
            }
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Principal frmMenu = new frm_Principal();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void cmb_Tablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbox_Operaciones.Items.Clear();
            Obj_TablasMultiplicar_DAL.OperacionesList.Clear();
            Obj_TablasMultiplicar_DAL.SelectedItem = cmb_Tablas.SelectedItem.ToString();
            Obj_TablasMultiplicar_BLL.cargarTabla(ref Obj_TablasMultiplicar_DAL);
            string[] array = Obj_TablasMultiplicar_DAL.OperacionesList.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                lbox_Operaciones.Items.Add(array[i]);
            }
            string xce = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Obj_TablasMultiplicar_DAL = new cls_TablasMultiplicar_DAL();
            Obj_TablasMultiplicar_BLL = new cls_TablasMultiplicar_BLL();
            lbox_Operaciones.Items.Clear();
            ud_TablaAl.Text = "";
            ud_tablaDe.Text = "";
            cmb_Tablas.ResetText();
            cmb_Tablas.Items.Clear();
            btn_Cargar.Enabled = true;
        }
    }
}
