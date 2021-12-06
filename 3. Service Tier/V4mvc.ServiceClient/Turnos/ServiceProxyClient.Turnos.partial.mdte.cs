using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]

        public ObservableCollection<Turnos> GetTurnos_Mdte(ref Turnos model)
        {
            try
            {
                return this.BL_Turnos.GetTurnos_Mdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Turnos GetOneTurno_Mdte(int IDTURNO)
        {
            try
            {
                return this.BL_Turnos.GetOneTurno_Mdte(IDTURNO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
