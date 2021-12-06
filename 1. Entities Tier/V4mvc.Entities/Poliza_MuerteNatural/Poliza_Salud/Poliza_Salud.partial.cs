
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class Poliza_Salud
    {
        #region [ Variables ]

        #endregion

        #region [ Propiedades ]
        public Nullable<Int32> DISPUTA_ID { get; set; }
        public String DISPUTA_ESTADO { get; set; }
        public Nullable<Guid> DOC_ID { get; set; }

        public Int32 DISPUTA_EXISTE { get; set; }

        public String FRMT_PERIODO
        {
            get
            {
                return (Utils.Fec_User(PERIODO, Utils.Formato_Fecha.Guion));
            }
        }

        public String ACRO_EMPRESA { get; set; }

        public String STRUT_EMPRESA { get; set; }

        public String NOM_DOC { get; set; }

        public List<String> LISTA_OBSERVACIONES
        {
            get
            {
                List<String> resultado = new List<string>();
                if (this.OBSERVACION != null)
                {
                    resultado = this.OBSERVACION.Split(new char[] { ';' }).ToList();
                }
                return resultado;
            }
        }
        public byte[] ADJUNTO_CONTENIDO { get; set; }
        public string ADJUNTO_TIPOCONTENIDO { get; set; }
        public string ADJUNTO_NOMBRE { get; set; }
        public string ADJUNTO_BASE64 { get; set; }

        #endregion
    }
}
	