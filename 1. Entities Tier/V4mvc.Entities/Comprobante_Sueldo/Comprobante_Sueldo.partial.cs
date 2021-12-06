
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class Comprobante_Sueldo
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
                return (Utils.Fec_User(PERIODO, Utils.Formato_Fecha.GuionMesLetras));
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
        public string ARCHIVO_ID { get; set; }
        public int TIPO_DOCUMENTO_ID { get; set; }

        public string DISPUTA_FECHA { get; set; }

        public string DISPUTA_EMPRESA { get; set; }
        public string DISPUTA_USUARIO { get; set; }

        public string PATENTE { get; set; }

        public int ORIGEN { get; set; }
        public string ACCION { get; set; }

        public string MSG_VALIDACION { get; set; }

        public string MSG_VALIDACION_PERIODO { get; set; }

        public string ARCHIVO_ADJUNTO { get; set; }
        public int MAX_FILESIZE_MB { get; set; } = 5;
        public int MAX_FILES { get; set; } = 1;
        public bool ALLOW_MULTIPLE_FILES { get; set; } = false;
        public int MAX_FILENAME_LENGTH { get; set; } = 45;

        public string BASE_ALLOWED_EXTENSIONS { get; set; } = ".pdf";
        public string ALLOWED_EXTENSIONS
        {
            get
            {
                return Utils.generateAllExtensions(this.BASE_ALLOWED_EXTENSIONS);
            }
        }

        #endregion

        #region [ Metodos ]

        public Utils.AlertaDispEliminadaArgs toAlertaDispEliminadaArgs()
        {
            var resultado = new Utils.AlertaDispEliminadaArgs
            {
                ID = this.DISPUTA_USUARIO,
                PATENTE = this.PATENTE,
                TIPO_DOCUMENTO_ID = this.TIPO_DOCUMENTO_ID,
                EMPRESA = this.DISPUTA_EMPRESA,
                PERIODO = this.DISPUTA_FECHA,
                ID_ELIM = this.USUARIO
            };
            return resultado;
        }

        #endregion


    }
}
	