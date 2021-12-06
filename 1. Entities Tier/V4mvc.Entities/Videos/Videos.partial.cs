
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class Videos
    {
        #region [ Variables ]

        #endregion

		#region [ Propiedades ]
        public string CONTENIDO_BASE64 { get; set; }

        public string STR_ID { get; set; }

        public string USUARIO_NOMBRES { get; set; }

        public string VISTA_LINK { get; set; }

        public string EXTENSION
        {
            get
            {
                return (string.IsNullOrEmpty(NOMBRE_ARCHIVO) ? NOMBRE_ARCHIVO : Utils.getExtension(NOMBRE_ARCHIVO).ToLower());
            }
        }

        #endregion
    }
}
	