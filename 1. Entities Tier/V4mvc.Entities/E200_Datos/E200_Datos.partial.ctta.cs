using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace V4mvc.Entities
{

	public partial class E200_Datos
	{
        #region [ Variables ]

        #endregion

        #region [ Propiedades ]
        public int START { get; set; }
        public int LENGTH { get; set; }
        public int COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
        public string COL4 { get; set; }
        public string COL5 { get; set; }
        public string COL6 { get; set; }
        public int TAB { get; set; }
        public string DESCRIPCION { get; set; }
        public string ACRONIMO { get; set; }
        public ObservableCollection<Local> listLocal{ get; set; }
        public ObservableCollection<Divisiones> listDivisiones { get; set; }
        public ObservableCollection<OSTArbol> listOST { get; set; }
        public string EXTENSION { get; set; }
        public string GLOSA { get; set; }
        public string NOMBRE { get; set; }
        public string NTIPO { get; set; }
        public string FECHA_GML
        {
            get
            {
                return Utils.Fec_User(PERIODO, Utils.Formato_Fecha.GuionMesLetras);
            }

        }
        public string FECHA_MOD_GML
        {
            get
            {
                return Utils.Fec_User(FECHAMOD, Utils.Formato_Fecha.GuionMesLetras);
            }

        }
        public string RUT_F
        {
            get
            {
                return Utils.strRut(EMPRESA);
            }

        }
        public string ESTADO { get; set; }
        public string DESCGENERAL { get; set; }
        public string DESCGERENCIA { get; set; }
        public string DESCAREA { get; set; }
        public string OBSERVACION { get; set; }
        public ObservableCollection<E200_Dothh> listSubContratos { get; set; }
        #endregion
    }
}