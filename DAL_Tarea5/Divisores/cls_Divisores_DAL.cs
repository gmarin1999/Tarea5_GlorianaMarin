using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Tarea5
{
    public class cls_Divisores_DAL
    {
        private int _num;
        private int _cantCifras;
        private int _sumaPares;
        private int _sumaImpares;
        private int _cifMayor;
        private int _cifMenor;
        private List<int> _divList = new List<int>();

        public int CantCifras
        {
            get
            {
                return _cantCifras;
            }

            set
            {
                _cantCifras = value;
            }
        }

        public int SumaPares
        {
            get
            {
                return _sumaPares;
            }

            set
            {
                _sumaPares = value;
            }
        }

        public int SumaImpares
        {
            get
            {
                return _sumaImpares;
            }

            set
            {
                _sumaImpares = value;
            }
        }

        public int CifMayor
        {
            get
            {
                return _cifMayor;
            }

            set
            {
                _cifMayor = value;
            }
        }

        public int CifMenor
        {
            get
            {
                return _cifMenor;
            }

            set
            {
                _cifMenor = value;
            }
        }

        public List<int> DivList
        {
            get
            {
                return _divList;
            }

            set
            {
                _divList = value;
            }
        }

        public int Num
        {
            get
            {
                return _num;
            }

            set
            {
                _num = value;
            }
        }
    }
}
