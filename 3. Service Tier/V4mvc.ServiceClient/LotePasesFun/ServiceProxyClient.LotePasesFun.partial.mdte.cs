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


        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_PasesMdte(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                return this.BL_LotePasesFun.GetAllLotePasesFun_PasesMdte(IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN, TIPO_PASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_v2_PasesMdte(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                return this.BL_LotePasesFun.GetAllLotePasesFun_v2_PasesMdte(IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN, TIPO_PASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_Funcionarios_CertificacionMdte(LotePases modelo)
        {
            try
            {
                return this.BL_LotePasesFun.GetAllLotePasesFun_Funcionarios_CertificacionMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_Empresas_CertificacionMdte(int IDPASE)
        {
            try
            {
                return this.BL_LotePasesFun.GetAllLotePasesFun_Empresas_CertificacionMdte(IDPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_Vehiculos_CertificacionMdte(int IDPASE)
        {
            try
            {
                return this.BL_LotePasesFun.GetAllLotePasesFun_Vehiculos_CertificacionMdte(IDPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarContDotacionSubCat_PasesMdte(string OST, int TIPO, int CONT_DOTACION, int LOTENUM, string FEC_INI, string FEC_FIN)
        {
            try
            {
                return this.BL_LotePasesFun.ValidarContDotacionSubCat_PasesMdte(OST, TIPO, CONT_DOTACION, LOTENUM, FEC_INI, FEC_FIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Informes ]

        #endregion

        #region [ Metodos ]

        public bool SavePase_PasesMdte(LotePases pase, ObservableCollection<LotePasesFun> funcionarios, ObservableCollection<LotePasesFun> vehiculos)
        {
            try
            {
                return this.BL_LotePasesFun.SavePase_PasesMdte(pase, funcionarios, vehiculos);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
