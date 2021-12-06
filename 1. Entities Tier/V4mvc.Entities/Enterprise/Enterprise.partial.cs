using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
	public partial class Enterprise
	{
		
		#region [ Variables Validación ]
		public Int32 COUNT_ENTERPRISES { get; set; }

        public ObservableCollection<Direccion> LISTA_PAISES { get; set; }
        public ObservableCollection<Region> LISTA_REGIONES { get; set; }
        public String ADMINAPE { get; set; }
        public String ADMNOM { get; set; }
        public String FECHABLOQUEO_FORMAT
        {
            get
            {
                return (Utils.Fec_User(FECHABLOQUEO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string IDEMPRESA_FORMATO
        {
            get
            {
                return Utils.strRut(IDEMPRESA);
            }
        }
        public string FECHA_HOY { get; set; }

        #endregion

        #region [ Propiedades Validación ]
        public Nullable<Int32> NIVEL { get; set; }
        public String EOPCION { get; set; }
        public string FECHA { get; set; }
        public string RUT { get; set; }
        #endregion


        #region [ DashBoard CTTA ]

        public int DOCS_VIGENTES { get; set; }
        public int DOCS_VENCIDOS { get; set; }
        public int VENCIMIENTO_OST { get; set; }
        public int VENCIMIENTO_VEH { get; set; }
        public int VENCIMIENTO_WORK { get; set; }
        public string OPERACIONES { get; set; }
        public string CANT_ACREDITADOS { get; set; }
        public string CANT_NOACREDITADOS { get; set; }
        public string CANT_PENDIENTES { get; set; }
        public string PROMEDIO { get; set; }

        #endregion

        #region [ DashBoard MDTE ]

        public string DATA_FAENA { get; set; }
        public string CASINO_CATEGORIAS { get; set; }
        public string DATA_CASINO { get; set; }
        public string DATA_MOVIMIENTOS { get; set; }

        #endregion
        public string DIVISION { get; set; }
        public int COUNT { get; set; }
        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }

    }
}
