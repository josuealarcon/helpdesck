using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    public partial class Reservas_Revision_Vehicular
    {
        public int DISPONIBLES { get; set; }
        public string FECHARES_LETRA { get; set; }
        public int COUNT_RESERVAS { get; set; }
        public string MOTIVO_DESC { get; set; }
        public ObservableCollection<Reservas_Revision_Vehicular> MOTIVOS { get; set; }
        public string NROOST { get; set; }
        public Workers SOLICITANTE { get; set; }
        public bool EXITOSO { get; set; }
        public string MENSAJE { get; set; }
        public string CODDIV { get; set; }
        public bool CANCELAR { get; set; }
        public string IDS_CANCELAR { get; set; }

        public int ESTADO_OPERACION { get; set;  }

        public ObservableCollection<Transport> LIST_VEHICULOS { get; set; }

        public string TIPO { get; set; }


        #region [ Informes]

        public string FECHA_HOY { get; set; }
        public string FECHAINI { get; set; }
        public string FECHAFIN { get; set; }
        public string ESTADO { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string TIPOV { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string FECHARES_FORMATO
        {
            get
            {
                return Utils.Fec_User(FECHARES, Utils.Formato_Fecha.GuionMesLetras);
            }
        }
        public string PATENTE_FORMATO
        {
            get
            {
                return Utils.FormatoPatente(PATENTE);
            }
        }
        #endregion

    }
}
