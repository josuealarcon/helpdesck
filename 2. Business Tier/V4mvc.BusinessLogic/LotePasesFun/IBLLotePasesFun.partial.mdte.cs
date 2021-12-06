using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLotePasesFun
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
        bool SavePase_PasesMdte(LotePases pase, ObservableCollection<LotePasesFun> funcionarios, ObservableCollection<LotePasesFun> vehiculos);

        #endregion

    }
}
