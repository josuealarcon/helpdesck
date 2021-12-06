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
		public ObservableCollection<Turnos> GetTurnosByEmpOST_Ctta(string ID_EMPRESA, string OST)
        {
			try
			{
				return this.BL_Turnos.GetTurnosByEmpOST_Ctta(ID_EMPRESA, OST);
			}
			catch (Exception ex)
			{ throw ex; }
		}

        public ObservableCollection<Turnos> GetAllTurnosCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Turnos.GetAllTurnosCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Turnos> GetAllCalendarioTurnosCtta(int IDTURNO, string IDEMPRESA, string TURNO, string ANIO, string MES)
        {
            try
            {
                return this.BL_Turnos.GetAllCalendarioTurnosCtta(IDTURNO, IDEMPRESA, TURNO, ANIO, MES);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Turnos GetTurnoEdit_TurnosCtta(int IDTURNO)
        {
            try
            {
                return this.BL_Turnos.GetTurnoEdit_TurnosCtta(IDTURNO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveTurno_TurnosCtta(Turnos Item)
        {
            try
            {
                return this.BL_Turnos.SaveTurno_TurnosCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }        
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
