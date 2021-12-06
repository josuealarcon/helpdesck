
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class LogDocsOST2
    {
        #region [ Variables ]

        public string CERTUSUARIO_FORMATO
        {
            get
            {
                return Utils.strRut(CERTUSUARIO);
            }
        }
        public string FECHA { get; set; }

        #endregion

        #region [ Propiedades ]

        public Nullable<Guid> IDVAL { get; set; }
        public String ARCHIVOVAL { get; set; }
        public String DOC { get; set; }
        public String VALIDADOR_FNOMBRES { get; set; }
        public String OBSFASE1 { get; set; }
        public String ARCHIVO_FASE1 { get; set; }
        public Nullable<Guid> IDARCHIVO_FASE1 { get; set; }
        public String FECHAFASE_1 { get; set; }
        public String HORAFASE_1 { get; set; }
        public String FASE { get; set; }
        public string FECHAFASE_1_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FECHAFASE_1, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        #endregion
    }
}
	