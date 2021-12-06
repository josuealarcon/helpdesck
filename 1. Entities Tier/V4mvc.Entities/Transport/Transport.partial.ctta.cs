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
        public string ACRONIMO { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string DSCTIPOV { get; set; }
        public int CERTVEH { get; set; }
        public string PATENTE_FORMATEADA { get { return (Utils.FormatoPatente(PATENTE)); } }
        public string COUNT_TRANSPORT { get; set; }
        public String NOMBRE_EMPRESA { get; set; }
        public Nullable<Boolean> PERTENECE_NOMINA { get; set; }
        public Nullable<Int32> PASES_ACTIVOS { get; set; }
        public String SINOLT { get; set; }
        public String TIPO_TXT { get; set; }
        public string ACRONIMO_PROPIETARIO { get; set; }
        public string IDEMPRESA { get; set; }
        public string FECHA { get; set; }
        public bool EXISTE { get; set; }
        public String DIVCOD { get; set; }
        public int CERT { get; set; }
        public String TIPOVEHICULO { get; set; }
        public String DIVISION { get; set; }
        public string PERIODO_DESDE { get; set; }
        public string COLUMNAS { get; set; }
        public string REQUISITOS { get; set; }
        public string ESTADO { get; set; }
        public string PATENTE_FORMATO { get { return (Utils.FormatoPatente(PATENTE)); } }
        public string IDEMPRESA_FORMATO { get { return (Utils.strRut(IDEMPRESA)); } }
        public string RUT_PROPIETARIO_FORMATO { get { return (Utils.strRut(RUT_PROPIETARIO)); } }
        public int COUNT { get; set; }
        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public Nullable<Int32> TIPO_TRANS { get; set; }
        public string IDCERTIFICADOMANTENCION { get; set; }
    }
}
