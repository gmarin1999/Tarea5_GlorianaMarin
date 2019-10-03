using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Tarea5.TablasMultiplicar
{
    public class cls_TablasMultiplicar_DAL
    {
        private int tablaDel;
        private int tablaHasta;
        private string selectedItem;
        private List<string> _multList = new List<string>();
        private List<string> _operacionesList = new List<string>();
        private string[] _operacionesArr;

        public List<string> MultList
        {
            get
            {
                return _multList;
            }

            set
            {
                _multList = value;
            }
        }

        public int TablaDel
        {
            get
            {
                return tablaDel;
            }

            set
            {
                tablaDel = value;
            }
        }

        public int TablaHasta
        {
            get
            {
                return tablaHasta;
            }

            set
            {
                tablaHasta = value;
            }
        }

        public string SelectedItem
        {
            get
            {
                return selectedItem;
            }

            set
            {
                selectedItem = value;
            }
        }

        public List<string> OperacionesList
        {
            get
            {
                return _operacionesList;
            }

            set
            {
                _operacionesList = value;
            }
        }

        public string[] OperacionesArr
        {
            get
            {
                return _operacionesArr;
            }

            set
            {
                _operacionesArr = value;
            }
        }
    }
}
