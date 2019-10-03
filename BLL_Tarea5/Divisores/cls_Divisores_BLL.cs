using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Tarea5;

namespace BLL_Tarea5
{
    public class cls_Divisores_BLL
    {
        public void calc_Divisores(ref cls_Divisores_DAL Obj_Divisores_DAL)
        {
            for (int i = 1; i <= Obj_Divisores_DAL.Num; i++) {
                if (Obj_Divisores_DAL.Num % i == 0) {

                    Obj_Divisores_DAL.DivList.Add(i);

                }
            }
            
        }

        public void calculos_Numeros(ref cls_Divisores_DAL Obj_Divisores_DAL) {
            string number = Obj_Divisores_DAL.Num.ToString();

            Obj_Divisores_DAL.CantCifras = number.Length;
            Obj_Divisores_DAL.CifMenor = 9;

            for (int i = 0; i < number.Length; i++)
            {
                if (Convert.ToInt16(number[i].ToString()) % 2 == 0)
                {
                    Obj_Divisores_DAL.SumaPares += Convert.ToInt16(number[i].ToString());
                }
                else {
                    Obj_Divisores_DAL.SumaImpares += Convert.ToInt16(number[i].ToString());
                }

                if (Convert.ToInt16(number[i].ToString()) > Obj_Divisores_DAL.CifMayor) {
                    Obj_Divisores_DAL.CifMayor = Convert.ToInt16(number[i].ToString());
                }

                if (Convert.ToInt16(number[i].ToString()) < Obj_Divisores_DAL.CifMenor) {
                    Obj_Divisores_DAL.CifMenor = Convert.ToInt16(number[i].ToString());
                }
                

            }
            
        }


    }
}
