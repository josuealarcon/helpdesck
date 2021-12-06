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
    public partial class Transport
    {
        public string TIPO_TRANSPORTE_LETRAS { get; set; }
        public int CERTIFICACION { get; set; }
        public string DIVISION_NOMBRE { get; set; }
        public string TIPO_VEHICULO { get; set; }
        public int CERTIFICATION_VALUE { get; set; }
        public string PATENTE_F { get { return (Utils.FormatoPatente(PATENTE)); } }
        public string FAMILIA { get; set; }
        public string FECHAFULL_MODIFICACION { get; set; }
        public string NOMBRES_AUTOR { get; set; }
        public string EMPRESA_ACRONIMO { get; set; }
        public string FUNC_PROPIETARIO_NOMBRES { get; set; }
        public string FUNC_PROPIETARIO_APELLIDOS { get; set; }
        public string EMP_PROPIETARIO_ACRONIMO { get; set; }
        public string CUMPLE_CERTIFICATION { get; set; }
        public string RFID { get; set; }
        public bool visibleEMPRESA { get; set; }
        public ObservableCollection<TypeTrans> ListTypeTrans { get; set; }
        public string RUT_PROPIETARIO_F { get { return (Utils.strRut(RUT_PROPIETARIO)); } }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
    }
}
