
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class InstalacionFaena
    {
        #region [ Variables ]

        #endregion

		#region [ Propiedades ]

        public String A_NOMBRE { get; set; }
        public String A_NOMBRE_ARCHIVO { get; set; }
        public Boolean FLAG_SUBE_DOCS { get; set; }
        public String D_NOMBRE { get; set; }
        public String D2_NOMBRE { get; set; }
        public String D3_NOMBRE { get; set; }
        public String D3_EXTS { get; set; }
        public String D4_NOMBRE { get; set; }
        public String D4_EXTS { get; set; }

        public String VALIDA_CARRANQUE { get; set; }

        public Nullable<Int32> CANT_DOCS_PENDIENTE { get; set; }

        public Nullable<Int32> NUM_SOLICITUD { get; set; }

        public String ESTADO_PREV { get; set; }

        public String VALIDA_PREV { get; set; }

        public String ID_DOC { get; set; }
        public String INFO_ARCHIVO { get; set; }
        public String NOMBRE_ARCHIVO { get; set; }

        #endregion
    }
}
	