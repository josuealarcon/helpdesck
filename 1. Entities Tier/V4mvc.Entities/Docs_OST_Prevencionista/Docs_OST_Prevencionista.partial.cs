
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class Docs_OST_Prevencionista
    {
        #region [ Variables ]

        #endregion

		#region [ Propiedades ]
        public String NOMBRES { get; set; }
        public String APELLIDOS { get; set; }
        public String FONO { get; set; }
        public String EMAIL { get; set; }

        public Nullable<Int32> FLAG_SUBE_DOCS { get; set; }

        public String CERT_FNOMBRES { get; set; }

        public Nullable<Int32> NUM_SOLICITUD { get; set; }

        public String RUT { get; set; }
        
        public String IDEMPRESA { get; set; }
        public String USUARIO { get; set; }
        public String ESTADO_ANTERIOR { get; set; }

        public String ID_DOC { get; set; }

        public Boolean SEND_EMAIL { get; set; }

        public String CS_EMAILS { get; set; }

        public String MADRE_ACRONIMO { get; set; }

        public String EMPRESA_ACRONIMO { get; set; }

        public String OST_FECINICIO { get; set; }
        public String OST_FECTERM { get; set; }
        public String OST_DESCRIPOST { get; set; }
        public String OST_DOTTRANS { get; set; }

        public String OST_DOTACION { get; set; }

        public Boolean EMPTY { get; set; }

        public String NOMBRES_PREVENCIONISTA { get; set; }

        #endregion
    }
}
	