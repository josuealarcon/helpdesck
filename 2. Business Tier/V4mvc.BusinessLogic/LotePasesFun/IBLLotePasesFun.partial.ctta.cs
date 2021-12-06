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

        LotePasesFun GetLotePasesFunConduccionPase(string RUT, string DIVCOD);

        ObservableCollection<LotePasesFun> GetAllLotePasesFun_PasesCtta(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE);

        ObservableCollection<LotePasesFun> GetAllLotePasesFun_v2_PasesCtta(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN);
        #endregion

        bool ValidarContDotacionSubCat_PasesCtta(string OST, int TIPO, int CONT_DOTACION, int LOTENUM, string FEC_INI, string FEC_FIN);

        bool ValidarCantOST_PasesCtta(string OST, int CONT_RUT_HOTEL, int LOTENUM, string FEC_INI, string FEC_FIN, out int err_value);

        #region [ Informes ]
        ObservableCollection<LotePasesFun> GetLotePasesFun_VehiculosInformeConsultaRapidaCtta(LotePasesFun request);
        ObservableCollection<LotePasesFun> GetLotePasesFun_FuncionariosInformeConsultaRapidaCtta(LotePasesFun request);
        LotePasesFun GetLotePasesFun_DatosPaseInformeConsultaRapidaCtta(LotePasesFun request);
        LotePasesFun GetLotePasesFun_ValidaExistenciaNlote_InformeConsultaRapidaCtta(LotePasesFun request);
        ObservableCollection<LotePasesFun> GetLotePasesFun_PasesHistoricos_InformeConsultasAdicionalesCtta(LotePasesFun request);
        #endregion
        #region [ Metodos ]

        bool SaveLotePasesFunQuitarConduccionPase(string RUT, string IDEMPRESA, string DIVCOD, string LICONDLT);

        bool SavePase_PasesCtta(int IDPASE, string ID_EMPRESA, string USUARIO, ObservableCollection<LotePasesFun> funcionarios, ObservableCollection<LotePasesFun> rem_funcionarios, ObservableCollection<LotePasesFun> vehiculos, ObservableCollection<LotePasesFun> rem_vehiculos);

        #endregion

    }
}
