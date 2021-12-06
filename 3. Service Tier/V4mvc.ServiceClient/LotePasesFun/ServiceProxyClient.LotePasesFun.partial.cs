using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public LotePasesFun GetLotePasesFunConduccionPase(string RUT, string DIVCOD)
        {
            try
            {
                return this.BL_LotePasesFun.GetLotePasesFunConduccionPase(RUT, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_PasesCtta(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                return this.BL_LotePasesFun.GetAllLotePasesFun_PasesCtta(IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN, TIPO_PASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_v2_PasesCtta(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN)
        {
            try
            {
                return this.BL_LotePasesFun.GetAllLotePasesFun_v2_PasesCtta(IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public int ValidarFuncionarioPase(string RUT, int IDPASE, string DIVISION, string TIPOPASE, string FEC_INI, string FEC_FIN, string TABLA)
        {
            try
            {
                return this.BL_LotePasesFun.ValidarFuncionarioPase(RUT, IDPASE, DIVISION, TIPOPASE, FEC_INI, FEC_FIN, TABLA);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ValidarContDotacionSubCat_PasesCtta(string OST, int TIPO, int CONT_DOTACION, int LOTENUM, string FEC_INI, string FEC_FIN)
        {
            try
            {
                return this.BL_LotePasesFun.ValidarContDotacionSubCat_PasesCtta(OST, TIPO, CONT_DOTACION, LOTENUM, FEC_INI, FEC_FIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarCantOST_PasesCtta(string OST, int CONT_RUT_HOTEL, int LOTENUM, string FEC_INI, string FEC_FIN, out int err_value)
        {
            try
            {
                return this.BL_LotePasesFun.ValidarCantOST_PasesCtta(OST, CONT_RUT_HOTEL, LOTENUM, FEC_INI, FEC_FIN, out err_value);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #region [ Informes ]
        public ObservableCollection<LotePasesFun> GetLotePasesFun_VehiculosInformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                return this.BL_LotePasesFun.GetLotePasesFun_VehiculosInformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<LotePasesFun> GetLotePasesFun_FuncionariosInformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                return this.BL_LotePasesFun.GetLotePasesFun_FuncionariosInformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public LotePasesFun GetLotePasesFun_DatosPaseInformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                return this.BL_LotePasesFun.GetLotePasesFun_DatosPaseInformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public LotePasesFun GetLotePasesFun_ValidaExistenciaNlote_InformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                return this.BL_LotePasesFun.GetLotePasesFun_ValidaExistenciaNlote_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<LotePasesFun> GetLotePasesFun_PasesHistoricos_InformeConsultasAdicionalesCtta(LotePasesFun request)
        {
            try
            {
                return this.BL_LotePasesFun.GetLotePasesFun_PasesHistoricos_InformeConsultasAdicionalesCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }        
        #endregion
        #region [ Metodos ]

        public bool SaveLotePasesFunQuitarConduccionPase(string RUT, string IDEMPRESA, string DIVCOD, string LICONDLT)
        {
            try
            {
                return this.BL_LotePasesFun.SaveLotePasesFunQuitarConduccionPase(RUT, IDEMPRESA, DIVCOD,LICONDLT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SavePase_PasesCtta(int IDPASE,string DIVCOD, string ID_EMPRESA, string USUARIO, ObservableCollection<LotePasesFun> funcionarios, ObservableCollection<LotePasesFun> rem_funcionarios, ObservableCollection<LotePasesFun> vehiculos, ObservableCollection<LotePasesFun> rem_vehiculos)
        {
            try
            {
                return this.BL_LotePasesFun.SavePase_PasesCtta(IDPASE, DIVCOD, ID_EMPRESA, USUARIO, funcionarios, rem_funcionarios, vehiculos, rem_vehiculos);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
