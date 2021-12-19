using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V4mvc.Presentation
{
    public static class Constants
    {
        public const String USUARIO_USUARIO = "USER";
        public const String USUARIO_ADMINISTRADOR = "ADMIN";
        public const Boolean ACTIVADO_DELEGADO_OST = true;
        public enum DISPUTA_ORIGEN
        {
            //CERT_DEUDAS = 98,
            //CERT_TASAS = 96,
            //CERT_NO_DEUDAS = 160,
            //COMP_PAGO_SUELDOS = 107,
            //_F29 = 95,
            //F30 = 92,
            //F30_1 = 93,
            //LIBRO_REMUN_PROPIO = 115,
            //PLANILLA_PAGO_COTIZ = 108,
            //POLIZA_MUERTE_ACC = 110,
            //POLIZA_MUERTE_NAT = -1,
            //POLIZA_SEG_SALUD = 109,
            //CARGA_MASIVA_LIQUIDACIONES = 116,
            //CARGA_LIQUIDACION = -2

            CERT_DEUDAS = 98,
            CERT_TASAS = 96,
            CERT_NO_DEUDAS = 160,
            POLIZA_MUERTE_ACC = 110,
            POLIZA_MUERTE_NAT = -1,
            POLIZA_SEG_SALUD = 109,
            CARGA_MASIVA_LIQUIDACIONES = 116,
            CARGA_LIQUIDACION = -2,

            COMP_PAGO_SUELDOS = 144,
            _F29 = 139,
            F30 = 137,
            F30_1 = 138,
            LIBRO_REMUN_PROPIO = 148,
            PLANILLA_PAGO_COTIZ = 145

            


        }
    }
}