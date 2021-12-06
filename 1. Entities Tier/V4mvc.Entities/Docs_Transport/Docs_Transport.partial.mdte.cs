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

        #region [ Variables ]
        public string NOMBRE_DOC { get; set; }
        public string NOMBREDOC { get; set; }
        public string TIPOCONTENIDO { get; set; }
        public int ID_TIPO_RECHAZO { get; set; }
        public string TIPO_RECHAZO { get; set; }
        public string ADMEMAIL { get; set; }
        public string RUT_CERTUSUARIO { get; set; }
        public string USUARIO_DISPUTA { get; set; }
        public string FECHA_DISPUTA { get; set; }
        public string HORA_DISPUTA { get; set; }
        public string OBSERVACION_DISPUTA { get; set; }
        public string REVALUSUARIO_DISPUTA { get; set; }
        public string REVALFECHA_DISPUTA { get; set; }
        public string REVALHORA_DISPUTA { get; set; }
        public string OBSERVACION_REVAL_DISPUTA { get; set; }
        public string NOMBRE_CERTUSUARIO { get; set; }
        public string APELLIDO_CERTUSUARIO { get; set; }
        public string MARCA_VEHICULO { get; set; }
        public string MODELO_VEHICULO { get; set; }
        public string NOMBRES_USUARIO { get; set; }
        public string APELLIDOS_USUARIO { get; set; }
        public string NOMBRE_REVALUSUARIO_DISPUTA { get; set; }
        public string APELLIDO_REVALUSUARIO_DISPUTA { get; set; }
        public string NOMBRES_USUARIO_DISPUTA { get; set; }
        public string APELLIDOS_USUARIO_DISPUTA { get; set; }
        public string ACRONIMO { get; set; }
        public string CORREO { get; set; }

        public string EMPRESA_F
        {
            get { return Utils.strRut(EMPRESA); }
        }
        public string PATENTE_F
        {
            get { return Utils.FormatoPatente(PATENTE); }
        }
        public string RUT_USUARIO_F
        {
            get { return Utils.strRut(USUARIO); }
        }
        public string RUT_USUARIO_DISPUTA_F
        {
            get { return Utils.strRut(USUARIO_DISPUTA); }
        }
        public string RUT_CERTUSUARIO_F
        {
            get { return Utils.strRut(CERTUSUARIO); }
        }
        public string RUT_REVALUSUARIO_DISPUTA_F
        {
            get { return Utils.strRut(REVALUSUARIO_DISPUTA); }
        }
        public string CERTFECHA_GML
        {
            get { return Utils.Fec_User(CERTFECHA, Utils.Formato_Fecha.GuionMesLetras); }
        }
        public string FECHA_DISPUTA_GML
        {
            get { return Utils.Fec_User(FECHA_DISPUTA, Utils.Formato_Fecha.GuionMesLetras); }
        }
        public string REVALFECHA_DISPUTA_GML
        {
            get { return Utils.Fec_User(REVALFECHA_DISPUTA, Utils.Formato_Fecha.GuionMesLetras); }
        }
        public string FECHA_MOD_GML
        {
            get { return Utils.Fec_User(FECHA_MOD, Utils.Formato_Fecha.GuionMesLetras); }
        }
        #endregion

        #region [ Propiedades ]

        #endregion
    }
}
