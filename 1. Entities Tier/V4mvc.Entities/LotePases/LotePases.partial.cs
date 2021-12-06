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
    public partial class LotePases
    {

        #region [ Variables ]

        public string LOTEFINICIO_FORMAT
        {
            get
            {
                return (Utils.Fec_User(LOTEFINICIO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string LOTEFFINAL_FORMAT
        {
            get
            {
                return (Utils.Fec_User(LOTEFFINAL, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public int NUMFUNCIONARIOS { get; set; }
        public int NUMVEHICULOS { get; set; }

        #endregion

        #region [ Propiedades ]
        public String DIVCOD { get; set; }

        public String TPASE { get; set; }

        public String OSTLT { get; set; }

        public String TIPO_PASE { get; set; }

        public String W_OST { get; set; }

        public String W_NOMBRES { get; set; }

        public String W_EMAIL { get; set; }

        public String ACRONIMO { get; set; }
        public String HOY { get; set; }

        public String DESC_ESTADO { get; set; }

        public Nullable<Int32> FUN { get; set; }
        public Nullable<Int32> EMP { get; set; }
        public Nullable<Int32> VEH { get; set; }
        public Nullable<Int32> TOD { get; set; }

        public String W_ADMIN { get; set; }

        public String LOTEFECHA_FRMTD
        {
            get
            {
                return (Utils.Fec_User(LOTEFECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public String LOTEFINICIO_FRMTD
        {
            get
            {
                return (Utils.Fec_User(LOTEFINICIO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public String LOTEFFINAL_FRMTD
        {
            get
            {
                return (Utils.Fec_User(LOTEFFINAL, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public int IDPASE { get; set; }

        public string IDEMPRESA { get; set; }
        public string USUARIO { get; set; }
        public string EMAIL_AUT { get; set; }
        public string RUT_AUT { get; set; }        
        public string IDSOLICITA { get; set; }
        public string EMAILSOLICITA { get; set; }
        public string AREAVISITA { get; set; }
        public string IDAUTORIZADOR { get; set; }

        public int ACTIVADO_DELEGADO_OST { get; set; }

        public int RET_OK { get; set; }

        public string JSON_RET { get; set; }

        public ObservableCollection<LotePasesFun> LISTAFUNCIONARIOS { get; set; }
        public ObservableCollection<LotePasesFun> LISTAVEHICULOS { get; set; }
        public ObservableCollection<LotePasesFun> rem_funcionarios { get; set; }
        public ObservableCollection<LotePasesFun> rem_vehiculos { get; set; }
        public ObservableCollection<TypeTrans> LISTATIPOVEHICULOS { get; set; }
        public ObservableCollection<Local> LISTAZONASCONDUCCION { get; set; }
        public ObservableCollection<Local> LISTAZONASACCESO { get; set; }
        public ObservableCollection<LotePases> LISTALUGARESVISITA { get; set; }
        public ObservableCollection<LotePasesFun> funcionarios { get; set; }
        public ObservableCollection<LotePasesFun> vehiculos { get; set; }
        public string LUGAR { get; set; }

        #endregion

    }
}
