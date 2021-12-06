using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLCursoReserva
	{

		#region [ Consultas ]

	
		public ObservableCollection<CursoReserva> GetList_A142_RESERVAS_Mdte(int CODIGO)
		{
			try
			{
				return this.Repository.GetList_A142_RESERVAS_Mdte(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<CursoReserva> GetList_A142_RESULTADOS_Mdte(int CODIGO)
		{
			try
			{
				return this.Repository.GetList_A142_RESULTADOS_Mdte(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
		public string ValidarReserva_Mdte(int CURSO, string RUT, int CODIGO)
		{
			try
			{
				return this.Repository.ValidarReserva_Mdte(CURSO, RUT, CODIGO);

			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean SaveCursoReserva_Mdte( CursoReserva Item)
		{
			try
			{
				return this.Repository.SaveCursoReserva_Mdte( Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

        public bool SaveParticipanteCursoRsultado_Mdte( CursoReserva item)
        {
            try
            {
                return this.Repository.SaveParticipanteCursoRsultado_Mdte( item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
