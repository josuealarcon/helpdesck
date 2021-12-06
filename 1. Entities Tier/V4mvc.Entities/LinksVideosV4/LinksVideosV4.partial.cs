
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class LinksVideosV4
    {
        #region [ Variables ]

        #endregion

		#region [ Propiedades ]
        
        public string NOMBRE_ARCHIVO { get; set; }

        public string NOMBRE_ARCHIVO_SIN_EXT
        {
            get
            {
                return (Utils.ExtlessFilename(NOMBRE_ARCHIVO));
            }
        }

        public string DESCRIPCION { get; set; }
        public string VERSION { get; set; }

        #endregion
    }
}
	