using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Tarea5.TablasMultiplicar;

namespace BLL_Tarea5.TablasMultiplicar
{
    public class cls_TablasMultiplicar_BLL
    {
       /* public void fn_multiplicar(ref cls_TablasMultiplicar_DAL Obj_TablasMultiplicar) {
            for (int i = Obj_TablasMultiplicar.NumeroInicio; i <= Obj_Dal.numeroFinal; i++)
            {
                Obj_TablasMultiplicar.ldt_tablas.Add("Tabla del " + i.ToString();
            }   
        }

        public void fn_llenar(ref cls_TablasMultiplicar_DAL Obj_tablas) {
            Obj_tablas.lst_resultados = new List<string>();
            for (int i = 0; i <) 12; i++)
            {
                Obj_tablas.resultado.Add
            }    
        }*/


        public void itemsCombo(ref cls_TablasMultiplicar_DAL Obj_TablasMultiplicar_DAL) {
            
            for (int i = Obj_TablasMultiplicar_DAL.TablaDel; i <= Obj_TablasMultiplicar_DAL.TablaHasta; i++)
            {
                Obj_TablasMultiplicar_DAL.MultList.Add("Tabla Multiplicar del "+i);
            }
        }

        public void cargarTabla(ref cls_TablasMultiplicar_DAL Obj_TablasMultiplicar_DAL) {
            int tabla = Convert.ToInt32(Obj_TablasMultiplicar_DAL.SelectedItem.Substring(22));
            for (int i = 0; i <= 20; i++)
            {
                Obj_TablasMultiplicar_DAL.OperacionesList.Add(tabla + " x " + i +" = " + (tabla * i));
            }
            string g = "";
        }
    }
}
