using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Tarea5.Fechas
{
    public class cls_Fechas_DAL
    {
        private int _dia;
        private int _mes;
        private int _anio;
        private string _signo;
        private string _diaSemana;
        private string _fecha;
        private DateTime date;
        private string _tDia;
        private string _tMes;
        private string _tAnio;

        private string _fechaInicial;
        private string _fechaFinal;
        private int _difDias;
        private int _difHoras;
        private int dif_Minutos;
        public int Dia
        {
            get
            {
                return _dia;
            }

            set
            {
                _dia = value;
            }
        }

        public int Mes
        {
            get
            {
                return _mes;
            }

            set
            {
                _mes = value;
            }
        }

        public int Anio
        {
            get
            {
                return _anio;
            }

            set
            {
                _anio = value;
            }
        }

        public string Signo
        {
            get
            {
                return _signo;
            }

            set
            {
                _signo = value;
            }
        }

        public string DiaSemana
        {
            get
            {
                return _diaSemana;
            }

            set
            {
                _diaSemana = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        public string TDia
        {
            get
            {
                return _tDia;
            }

            set
            {
                _tDia = value;
            }
        }

        public string TMes
        {
            get
            {
                return _tMes;
            }

            set
            {
                _tMes = value;
            }
        }

        public string TAnio
        {
            get
            {
                return _tAnio;
            }

            set
            {
                _tAnio = value;
            }
        }

        public string FechaInicial
        {
            get
            {
                return _fechaInicial;
            }

            set
            {
                _fechaInicial = value;
            }
        }

        public string FechaFinal
        {
            get
            {
                return _fechaFinal;
            }

            set
            {
                _fechaFinal = value;
            }
        }

        public int DifDias
        {
            get
            {
                return _difDias;
            }

            set
            {
                _difDias = value;
            }
        }

        public int DifHoras
        {
            get
            {
                return _difHoras;
            }

            set
            {
                _difHoras = value;
            }
        }

        public int Dif_Minutos
        {
            get
            {
                return dif_Minutos;
            }

            set
            {
                dif_Minutos = value;
            }
        }
    }
}
