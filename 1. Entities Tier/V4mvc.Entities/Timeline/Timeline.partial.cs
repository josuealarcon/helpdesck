
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class Timeline
    {
        #region [ Variables ]

        #endregion

		#region [ Propiedades ]
        public string DIAHOY { get; set; }
        public string MESHOY { get; set; }
        public int CLABORAL_MSG_EXISTE { get; set; }
        public int VALIDA { get; set; }
        public int CARGAR { get; set; }
        public int CM_EXISTEN_DOCS { get; set; }

        public string CM_NOMBRE { get; set; }
        public int CM_IDDOC { get; set; }

        public string NOMBRE_DOC { get; set; }

        public string IDEMPRESA { get; set; }

        #endregion
    }
}
	