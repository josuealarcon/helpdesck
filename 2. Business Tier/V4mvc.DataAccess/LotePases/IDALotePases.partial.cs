using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALotePases
	{

        #region [ Consultas ]

        ObservableCollection<LotePases> GetAllLotePases_PasesCtta(string IDEMPRESA, bool ACTUAL);
        LotePases GetOneLotePases_PasesCtta(int LOTENUM);

        ObservableCollection<LotePases> GetLugaresVisita();

        #endregion

        #region [ Metodos ]
        bool SendPase_PasesCtta(ref LotePases modelo);
        bool SaveLotePases_PasesCtta(string INS_OST, string INS_EMP, string INS_DIVCOD, string INS_FINICIO, string INS_FFINAL, string INS_TPASE, string INS_DESCRIP, string IDEMPRESA, string USUARIO, out int new_id);
        bool UpdatePase(LotePases paseUpdate);
        bool SaveLotePases_PaseVisitaCtta(LotePases pase, out int NEW_ID);
        bool SendPaseModelo_PasesCtta(ref LotePases modelo);

        #endregion
    }
}
