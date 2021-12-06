using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
    public partial class Check_Checkinginghead
    {
        #region [ Variables Validación ]
        public String FECHAINI_INF1 { get; set; }
        public String FECHAFIN_INF1 { get; set; }
        public String FECHAINI_INF2 { get; set; }
        public String FECHAFIN_INF2 { get; set; }
        public String FECHAINI_INF3 { get; set; }
        public String FECHAFIN_INF3 { get; set; }
        public int ID_CHECK_DET { get; set; }
        public String FECHAINI_INF4 { get; set; }
        public String FECHAFIN_INF4 { get; set; }
        public int TIPOVEHICULO { get; set; }
        public string FECHA_LETRA { get; set; }
        public String CHECKLIST { get; set; }
        public String RUT { get; set; }
        public String PERIODOCOSULTA { get; set; }
        public String ACRONIMO { get; set; }
        public String PATENTE { get; set; }
        public String TIPO { get; set; }
        public String ESTADO { get; set; }
        public String NOMBRE_IDENTIFICADOR { get; set; }
        public Guid? ID_ARCHIVO { get; set; }
        public String HORA { get; set; }
        //InformeChecklist_TestDeVehiculo
        public String NOMBRES { get; set; }
        public String APELLIDOS { get; set; }
        //InformeChecklist_TestDeFatigaSomnolencia
        public String NOMBRE_APELLIDOS { get; set; }
        public String MARCA { get; set; }
        public String PERIODO { get; set; }
        public String COMBO_CHECKLIST_TEXT { get; set; }
        public String COMBO_TIPOCHECKLIST_TEXT { get; set; }

        public int TOTAL { get; set; }
        //Detalle
        public string OBSERVACION { get; set; }
        public string VALOR { get; set; }
        public string DESCRIPCION { get; set; }
        //Paginacion
        public int LENGTH { get; set; }
        public int START { get; set; }
        public int TOTALREGISTROS { get; set; }
        public int ROWNUMBER { get; set; }
        public string NOMBREARCHIVO { get; set; }
        public string EMPRESA_FORMATO
        {
            get
            {
                return (Utils.strRut(EMPRESA));
            }
        }
        public string IDENTIFICADOR_FORMATO
        {
            get
            {
                return (Utils.FormatoPatente(IDENTIFICADOR));
            }
        }
        public string USRCREA_FORMATO
        {
            get
            {
                return (Utils.strRut(USRCREA));
            }
        }
        public string RUT_FORMATO
        {
            get
            {
                return (Utils.strRut(RUT));
            }
        }

        public string FECHA_GML
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string FECHA_M
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.Mes));
            }
        }

        public ObservableCollection<CheckDetail> ListCheckDetail { get; set; }
        public List<CheckDetail> ListCheckGroup { get; set; }

        public int COUNT { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
        public string COL4 { get; set; }
        public string COL5 { get; set; }
        public string COL6 { get; set; }
        public string COL7 { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public string RESULTADO { get; set; }
        public string VALIDA { get; set; }
        public string ID_CHECKDET { get; set; }
        public string PREGUNTA { get; set; }
        public string OPCIONES { get; set; }
        public string GRUPO { get; set; }
        public string ORDEN { get; set; }

    }

    #endregion
}
