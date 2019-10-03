using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Tarea5.Fechas;

namespace BLL_Tarea5.Fechas
{
    public class cls_Fechas_BLL
    {
        public void signoZodiacal(ref cls_Fechas_DAL Obj_Fechas_DAL) {
            if (((Obj_Fechas_DAL.Mes == 3) && (Obj_Fechas_DAL.Dia >= 21 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 4) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 20)))
            {
                Obj_Fechas_DAL.Signo = "Aries";
                return;
            }
            if (((Obj_Fechas_DAL.Mes == 4) && (Obj_Fechas_DAL.Dia >= 21 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 5) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 21)))
            {
                Obj_Fechas_DAL.Signo = "Tauro";
                return;
            }
            if (((Obj_Fechas_DAL.Mes == 5) && (Obj_Fechas_DAL.Dia >= 21 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 6) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 21)))
            {
                Obj_Fechas_DAL.Signo = "Geminis";
                return;
            }
            if (((Obj_Fechas_DAL.Mes == 6) && (Obj_Fechas_DAL.Dia >= 22 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 7) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 22)))
            {
                Obj_Fechas_DAL.Signo = "Cáncer";
                return;
            }
            if (((Obj_Fechas_DAL.Mes == 7) && (Obj_Fechas_DAL.Dia >= 23 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 8) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 22)))
            {
                Obj_Fechas_DAL.Signo = "Leo";
                return;
            }
            if (((Obj_Fechas_DAL.Mes == 8) && (Obj_Fechas_DAL.Dia >= 23 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 9) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 21)))
            {
                Obj_Fechas_DAL.Signo = "Virgo";
                return;
            }
            if ((Obj_Fechas_DAL.Mes == 9 && (Obj_Fechas_DAL.Dia >= 22 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 10) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 22)))
            {
                Obj_Fechas_DAL.Signo = "Libra";
                return;
            }
            if ((Obj_Fechas_DAL.Mes == 10 && (Obj_Fechas_DAL.Dia >= 23 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 11) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 21)))
            {
                Obj_Fechas_DAL.Signo = "Escorpio";
                return;
            }
            if ((Obj_Fechas_DAL.Mes == 11 && (Obj_Fechas_DAL.Dia >= 22 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 12) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 21)))
            {
                Obj_Fechas_DAL.Signo = "Sagitario";
                return;
            }
            if (((Obj_Fechas_DAL.Mes == 12) && (Obj_Fechas_DAL.Dia >= 22 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 1) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 20)))
            {
                Obj_Fechas_DAL.Signo = "Capriciornio";
                return;
            }
            if (((Obj_Fechas_DAL.Mes == 1) && (Obj_Fechas_DAL.Dia >= 21 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 2) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 19)))
            {
                Obj_Fechas_DAL.Signo = "Acuario";
                return;
            }
            if ((Obj_Fechas_DAL.Mes == 2 && (Obj_Fechas_DAL.Dia >= 20 && Obj_Fechas_DAL.Dia <= 31)) || ((Obj_Fechas_DAL.Mes == 3) && (Obj_Fechas_DAL.Dia >= 01 && Obj_Fechas_DAL.Dia <= 20)))
            {
                Obj_Fechas_DAL.Signo = "Piscis";
                return;
            }
        }

        public bool fechas(ref cls_Fechas_DAL Obj_Fechas_DAL) {
            var date = DateTime.MaxValue;
            if (DateTime.TryParse(Obj_Fechas_DAL.Fecha, out date))
            {
                Obj_Fechas_DAL.Fecha = date.ToLongDateString();
                
            }
            else {
                return false;
            }
            Obj_Fechas_DAL.TDia = date.Day.ToString();
            Obj_Fechas_DAL.TMes = date.Month.ToString();
            Obj_Fechas_DAL.TAnio = date.Year.ToString();
            Obj_Fechas_DAL.DiaSemana = date.DayOfWeek.ToString();
            return true;
        }

        public bool validarFechas(ref cls_Fechas_DAL Obj_Fechas_DAL) {
            var date = DateTime.MaxValue;
            if (DateTime.TryParse(Obj_Fechas_DAL.FechaFinal, out date) && DateTime.TryParse(Obj_Fechas_DAL.FechaInicial, out date))
            {
                return true;

            }
            else {
                return false;
            }
            
        }
        public void difFechas(ref cls_Fechas_DAL Obj_Fechas_DAL)
        {

            TimeSpan tiempo = Convert.ToDateTime(Obj_Fechas_DAL.FechaFinal).Subtract(Convert.ToDateTime(Obj_Fechas_DAL.FechaInicial));
            Obj_Fechas_DAL.DifDias = Convert.ToInt32(tiempo.TotalDays); //61 días
            Obj_Fechas_DAL.DifHoras = Convert.ToInt32(tiempo.TotalHours);//87840
            Obj_Fechas_DAL.Dif_Minutos = Convert.ToInt32(tiempo.TotalMinutes);
        
        }

    }
}
