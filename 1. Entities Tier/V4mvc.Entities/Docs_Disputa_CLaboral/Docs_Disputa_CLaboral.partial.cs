
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class Docs_Disputa_CLaboral
    {
        #region [ Variables ]

        #endregion

		#region [ Propiedades ]
        public String ACRONIMO { get; set; }
        public String NOMBRE { get; set; }

        public String STRUT_EMPRESA { get; set; }

        public String MOTIVOS { get; set; }

        public List<String> LISTA_MOTIVOS
        {
            get
            {
                List<String> result = new List<string>();
                if (!String.IsNullOrEmpty(this.MOTIVOS))
                {
                    result = this.MOTIVOS.Split(new char[] { ';' }).ToList();
                }
                return result;
            }
        }

        public String NOMBRE_USUARIO { get; set; }

        public string FRMT_FECHA
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.Guion));
            }
        }

        public string DOC_ID { get; set; }
        public int ORIGEN { get; set; }

        public int CERTIFICADO_ID { get; set; }

        #endregion
    }
}
	