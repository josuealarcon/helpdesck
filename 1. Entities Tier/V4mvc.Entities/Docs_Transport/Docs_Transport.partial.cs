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
	public partial class Docs_Transport
	{
		public int VALOR { get; set; }
        public string FECHA_MOD_FORMAT
        {
            get
            {
                return (Utils.Fec_User(FECHA_MOD, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string CERTFECHA_FORMAT
        {
            get
            {
                return (Utils.Fec_User(CERTFECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string NOMBRE { get; set; }
        public string ESTADO { get; set; }
        public int ID_DISPUTA { get; set; }
        public ObservableCollection<Docs_Transport_Rechazo> docs_Tipo_Rechazos { get; set; }
        public string OBSERVACION_REVAL { get; set; }
        public string DIVCOD { get; set; }
        public Archivos ARCHIVO_CARGADO { get; set; }
        public Transport TRANSPORT { get; set; }
        public ObservableCollection<Docs_Fec> LISTA_FECHAS { get; set; }
        public string MOTIVO_RECHAZO { get; set; }
        public string PATENTE_FORMATO
        {
            get
            {
                return (Utils.FormatoPatente(PATENTE));
            }
        }
        public string RUT_USUARIO_F
        {
            get
            {
                return Utils.strRut(USUARIO);
            }
        }

    }
}
