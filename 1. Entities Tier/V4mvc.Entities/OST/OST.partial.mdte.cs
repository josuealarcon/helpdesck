using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
    public partial class OST
    {

        #region [ MDTE - Contratos/OST]

        public string ESTADO { get; set; }
        public string ACTIVO { get; set; }
        public string ACRONIMOCTTA { get; set; }
        public string ACRONIMOMADRE { get; set; }
        public string OLDFECHAESEFORMAT { get; set; }
        public string FECHAESEFORMAT { get; set; }
        public string HORAESEFORMAT { get; set; }
        public string NOMBRES_APELLIDOS_USUARIO { get; set; }
        public string FECHAMOD_FORMATO { get { return Utils.Fec_User(FECHAMOD, Utils.Formato_Fecha.GuionMesLetras); } }
        public string FECINICIO_FORMATO { get { return Utils.Fec_User(FECINICIO, Utils.Formato_Fecha.Guion); } }
        public string FECTERM_FORMATO { get { return Utils.Fec_User(FECTERM, Utils.Formato_Fecha.Guion); } }
        public string FECCIERRE_FORMATO { get { return Utils.Fec_User(FECCIERRE, Utils.Formato_Fecha.Guion); } }
        public string FECHAESEFORMAT_FORMATO { get { return Utils.Fec_User(FECHAESEFORMAT, Utils.Formato_Fecha.Guion); } }
        public string SUBC { get; set; }
        public string ADMINSUBC { get; set; }
        public OSTArbol OSTARBOL { get; set; }
        public ObservableCollection<OSTDivLocal> LIST_OSTDIVLOCAL { get; set; }
        public ObservableCollection<A024_Divisiones> LIST_A024_DIVISIONES { get; set; }
        public ObservableCollection<OSTAdmin> LIST_OSTADMIN { get; set; }
        public ObservableCollection<InstalacionFaena> LIST_INSTALACION_FAENA { get; set; }
        public ObservableCollection<Enterprise> LIST_ENTERPRISE { get; set; }
        public ObservableCollection<OSTCombust> LIST_OSTCOMBUST { get; set; }
        public ObservableCollection<Dotacion_Servicios_Ost> LIST_SERVICIO { get; set; }
        public ObservableCollection<Departamento> LIST_DEPARTAMENTO { get; set; }
        public ObservableCollection<Sector> LIST_SECTOR { get; set; }
        public ObservableCollection<Tipo_Sector> LIST_TIPO_SECTOR { get; set; }

        #endregion

    }
}
