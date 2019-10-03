using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Tarea5.Fechas;
using BLL_Tarea5.Fechas;

namespace UI_Tarea5.Pantallas
{
    public partial class frm_Fechas : Form
    {
        cls_Fechas_DAL Obj_Fechas_DAL = new cls_Fechas_DAL();
        cls_Fechas_BLL Obj_Fechas_BLL = new cls_Fechas_BLL();
        public frm_Fechas()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Principal frmMenu = new frm_Principal();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void btn_Extraer_Click(object sender, EventArgs e)
        {
            Obj_Fechas_DAL.Fecha = txtFecha.Text;
            if (Obj_Fechas_BLL.fechas(ref Obj_Fechas_DAL))
            {
                Obj_Fechas_DAL.Mes = Convert.ToInt16(Obj_Fechas_DAL.TMes);
                Obj_Fechas_DAL.Dia = Convert.ToInt16(Obj_Fechas_DAL.TDia);
                Obj_Fechas_DAL.Anio = Convert.ToInt16(Obj_Fechas_DAL.TAnio);
                Obj_Fechas_BLL.signoZodiacal(ref Obj_Fechas_DAL);
                txtDia.Text = Obj_Fechas_DAL.TDia;
                txtMes.Text = Obj_Fechas_DAL.TMes;
                txtAnio.Text = Obj_Fechas_DAL.TAnio;
                txtDiaSemana.Text = Obj_Fechas_DAL.DiaSemana;
                txtZodiac.Text = Obj_Fechas_DAL.Signo;
            }
            else {
                MessageBox.Show("Por favor ingresar una fecha válida");
            }
            
            
        }

        private void btn_VerFechas_Click(object sender, EventArgs e)
        {
            Obj_Fechas_DAL.FechaInicial = txtFechaInicio.Text;
            Obj_Fechas_DAL.FechaFinal = txtFechaFinal.Text;
            if (Obj_Fechas_BLL.validarFechas(ref Obj_Fechas_DAL))
            {
                Obj_Fechas_BLL.difFechas(ref Obj_Fechas_DAL);
                txtdifDias.Text = Obj_Fechas_DAL.DifDias.ToString();
                txtDifHoras.Text = Obj_Fechas_DAL.DifHoras.ToString();
                txtDifMin.Text = Obj_Fechas_DAL.Dif_Minutos.ToString();
            }
            else {
                MessageBox.Show("Por favor ingresar un rango de fechas válido");
            }
            
        }
    }
}
