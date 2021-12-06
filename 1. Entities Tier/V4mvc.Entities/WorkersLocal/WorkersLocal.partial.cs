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
    public partial class WorkersLocal
    {

        #region [ Variables Validación ]

        public String ACRONIMO { get; set; }
        public string DIVCOD { get; set; }

        public string FECHA_INIFORMAT
        {
            get
            {
                return (Utils.Fec_User(FINIPASE, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string FECHA_FINFORMAT
        {
            get
            {
                return (Utils.Fec_User(FFINPASE, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public int SI_CANTIDAD { get; set; }
        public string SI_VALIDO { get; set; }
        public string CODIGO_DIV { get; set; }
        public int NO_CANTIDAD { get; set; }
        public string NO_VALIDO { get; set; }
        public int CANTIDAD { get; set; }
        public bool CERTFUN { get; set; }
        public int MANDANTE { get; set; }

        public int CUENTA_FUNCIONARIOS { get; set; }
        public int CUENTA_CERTIFICADOS { get; set; }
        public int CUENTA_NOCERTIFICADOS { get; set; }
        public int CUENTA_HISTORICO { get; set; }

        public int CUENTA_SI_AUTOR { get; set; }

        public int SUMA_SI_AUTOR_CTTA { get; set; }

        public int SUMA_SI_AUTOR_MDTE { get; set; }


        public string CERT { get; set; }
        public string TEMP { get; set; }
        public string CAMPOS_REPORT { get; set; }
        public string CAMPOS_CONDUCCION { get; set; }
        public string CAMPOS_DOC { get; set; }
        public string CAMPOS_FEC { get; set; }

        public int SUMA_FUNCIONARIOS_CTTA { get; set; }
        public int SUMA_CERTIFICADOS_CTTA { get; set; }
        public int SUMA_NOCERTIFICADOS_CTTA { get; set; }
        public int SUMA_HISTORICO_CTTA { get; set; }
        public int SUMA_FUNCIONARIOS_MDTE { get; set; }
        public int SUMA_CERTIFICADOS_MDTE { get; set; }
        public int SUMA_NOCERTIFICADOS_MDTE { get; set; }
        public int SUMA_HISTORICO_MDTE { get; set; }

        public string FINIPASE_LETRA
        {
            get
            {
                return (Utils.Fec_User(FINIPASE, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
		
        public string FFINPASE_LETRA
        {
            get
            {
                return (Utils.Fec_User(FFINPASE, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public int OPCION { get; set; }

        public string TITULO { get; set; }

        public string NOMBRES { get; set; }

        public string APELLIDOS { get; set; }

        public string GLOSA { get; set; }

        public string PASE_AUTORIZADO { get; set; }

        public string AUTOR_VALIDADO { get; set; }

        public string AUTOR_CONDUCTOR { get; set; }

        public string RESULTADO_CONDUCCION { get; set; }

        public string TEXTO_CONTRATO { get; set; }

        public string FECHA_CONTRATO { get; set; }
        public string RUT_COD { get; set; }

        public string FECHA_CONTRATO_GM
        {
            get
            {
                return (Utils.Fec_User(FECHA_CONTRATO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public int FECHA_CONTRATO_VERDE { get; set; }

        public string TEXTO_EXAMEN { get; set; }

        public string FECHA_EXAMEN { get; set; }

        public string FECHA_EXAMEN_GM
        {
            get
            {
                return (Utils.Fec_User(FECHA_EXAMEN, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public int FECHA_EXAMEN_VERDE { get; set; }


        #endregion

        #region [ Propiedades Validación ]
        #endregion

    }
}
