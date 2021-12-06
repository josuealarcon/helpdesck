using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Runtime.Remoting.Channels;

namespace V4mvc.Entities
{
    public partial class Docs
    {

        #region [ Variables ]

        public string OBLIGATORIO { get; set; }
        public Guid? ID { get; set; }

        public string VALIDADO { get; set; }

        public string TIPOPASE { get; set; }

        public Docs_Disputa DISPUTA { get; set; }
        public Docs_Disputa_Trans DISPUTA_TRANS { get; set; }

        public ObservableCollection<Docs_Fec> LISTA_FECHAS { get; set; }

        public ObservableCollection<Docs_Workers> LISTA_DOCS_WORKERS { get; set; }

        public ObservableCollection<Docs> LISTA_DEPENDENCIAS { get; set; }

        public ObservableCollection<Mutualidad> LISTA_MUTUALIDAD { get; set; }

        public ObservableCollection<A054_MotivoFiniquito> LISTA_MOTIVOSFINIQUITOS { get; set; }

        public string EXTENSIONES { get; set; }

        public ObservableCollection<Tab_TipoContrato> LISTA_TIPOCONTRATO { get; set; }

        public ObservableCollection<Licencias> LISTA_LICENCIAS { get; set; }

        public ObservableCollection<Docs_Transport> LISTA_HISTORICO { get; set; }
        public ObservableCollection<ReqVal_Docs> LISTA_REQUISITOSVALIDACION { get; set; }

        public ObservableCollection<Tab_Combustible> LISTA_COMBUSTIBLES { get; set; }
        public ObservableCollection<Tab_Traccion> LISTA_TRACCIONES { get; set; }
        public string DIVCOD { get; set; }

        public string LOTENUM { get; set; }
        public bool CERTCOND { get; set; }

        public string CTRL_CONDUCC { get; set; }
        public string DIVISION { get; set; }

        public string RUT { get; set; }

        public string CAMPO_BD { get; set; }

        public string PAIS { get; set; }

        public string ENCR_DIVCOD { get; set; }
        public string ENCR_ID_DOC { get; set; }

        public string SALARIO { get; set; }
        public string SUELDO_BASE { get; set; }

        public Nullable<Int32> ID_CARGO { get; set; }

        public string TURNO { get; set; }

        public string OST { get; set; }

        public string ID_EMPRESA {get;set;}

        public string USUARIO { get; set; }

        public string FILENAME { get; set; }
        public string EXT { get { return System.IO.Path.GetExtension(this.FILENAME); } }
        public Parametros_V2 parametros { get; set; }

        #endregion

        #region [ Propiedades ]
        public Nullable<Guid> ID_ARCHIVO { get; set; }
        public Int16 EXISTE_DOC_OST { get; set; }

        public String VVALIDADO { get; set; }

        public String VALIDADO_ADMINOST { get; set; }

        public Nullable<Guid> ID_ARCHIVO2 { get; set; }

        public String EEXT { get; set; }
        public int IDGRUPO { get; set; }
        public int ID_DOC_FEC { get; set; }
        public String FECHA { get; set; }
        public string FECHA_LETRA
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public List<String> CLEANED_EXTS
        {
            get
            {
                List<String> result = new List<string>();
                if(this.EEXT != null && this.EEXT.Trim().Length > 0)
                {
                    var tokens = this.EEXT.Split(new char[] {' ', ';', ','});
                    foreach(var token in tokens)
                    {
                        var cleaned_ext = token.Replace(".", "").ToLower();
                        result.Add(cleaned_ext);
                    }
                }
                return result;
            }
        }

        public String NOM_ARCHIVO2 { get; set; }

        public String CLEANED_EXT { 
            get {
                String ext = "";
                if(this.NOM_ARCHIVO2 != null && this.NOM_ARCHIVO2.Trim().Length > 0)
                {
                    ext = System.IO.Path.GetExtension(this.NOM_ARCHIVO2).Replace(".", "").ToLower();
                }
                return ext;
            } 
        }

        public string FILE_ICON_PATH { get; set; }

        public String NROOST { get; set; }
        public String MADRE { get; set; }

        public String IDEMPRESA { get; set; }

        public Int16 NIVEL { get; set; }

        public Archivos ADJUNTO { get; set; }        
        public string LISTA_LICENCIAS_CADENA { get; set; }
        public string LISTA_TIPOCONTRATO_CADENA { get; set; }

        public ObservableCollection<V_Ctrl_Lab_Ultimo> LISTA_CONTROL_LAB_ULTIMO { get; set; }
        public String PATENTE { get; set; }
        public String NOMBRE_FECHA { get; set; }
        public String COLORFECHA { get; set; }
        public String ESTADO { get; set; }
        public String LICONDLT { get; set; }
        public String ENTREGADO { get; set; }
        public int CERT { get; set; }
        public String FECHA_MENOR { get; set; }

        public string INFORMACION_ARCHIVO { get; set; }
        public string ACTIVO_SUBEDOC { get; set; }
        public ObservableCollection<Direccion> LIST_DIRECCION { get; set; }
        public ObservableCollection<A024_Divisiones> LIST_A024DIVISIONES { get; set; }
        public string CIUDAD { get; set; }
        public string DIRECCION { get; set; }
        public string RUT_FORMATO
        {
            get
            {
                return Utils.strRut(RUT);
            }
        }
        public string RUT_USUARIO_F
        {
            get
            {
                return Utils.strRut(USUARIO);
            }
        }
        public int existePase { get; set; }

        public int REDIRECCIONA { get; set; }
        #endregion

    }
}