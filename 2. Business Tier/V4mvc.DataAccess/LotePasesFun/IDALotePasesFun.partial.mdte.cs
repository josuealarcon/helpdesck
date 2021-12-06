using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALotePasesFun
	{

        #region [ Consultas ]

        ObservableCollection<LotePasesFun> GetAllLotePasesFun_PasesMdte(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE);

        ObservableCollection<LotePasesFun> GetAllLotePasesFun_v2_PasesMdte(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE);

        ObservableCollection<LotePasesFun> GetAllLotePasesFun_Funcionarios_CertificacionMdte(LotePases modelo);

        ObservableCollection<LotePasesFun> GetAllLotePasesFun_Empresas_CertificacionMdte(int IDPASE);

        ObservableCollection<LotePasesFun> GetAllLotePasesFun_Vehiculos_CertificacionMdte(int IDPASE);

        bool ValidarContDotacionSubCat_PasesMdte(string OST, int TIPO, int CONT_DOTACION, int LOTENUM, string FEC_INI, string FEC_FIN);

        #endregion

        #region [ Informes ]

        #endregion

        #region [ Metodos ]
        bool SaveLotePasesFun_PasesMdte(LotePasesFun funcionario);

        bool SaveLotePasesFun_v2_PasesMdte(LotePasesFun vehiculo);

        bool DelLotePasesFun_PasesMdte(LotePasesFun funcionario);

        bool DelLotePasesFun_v2_PasesMdte(LotePasesFun vehiculo);

        #endregion
    }
}
