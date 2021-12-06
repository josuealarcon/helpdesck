using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;


using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
    
{
	public partial class ServiceProxyClient 
	{

        #region [ Consultas ]
        public ObservableCollection<Docs_Disputa> GetListDocsDisputa_Mdte(ref Docs_Disputa item)
		{
			try
			{
				return this.BL_Docs_Disputa.GetListDocsDisputa_Mdte(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

        public Docs_Disputa GetOneDocsDisputaFuncionario_Mdte(string IDDISPUTA)
        {
            try
            {
                return this.BL_Docs_Disputa.GetOneDocsDisputaFuncionario_Mdte(IDDISPUTA);
            }
            catch (Exception ex)
            { throw ex; }

        }

        public Docs_Disputa GetOneDocsDisputaVehiculo_Mdte(string IDDISPUTA, string PATENTE)
        {
            try
            {
                return this.BL_Docs_Disputa.GetOneDocsDisputaVehiculo_Mdte(IDDISPUTA, PATENTE);
            }
            catch (Exception ex)
            { throw ex; }

        }
        #endregion

        #region [ Metodos ] 
        public bool SaveDocDisputaFuncionario(Docs_Disputa Item)
        {
            try
            {
                return this.BL_Docs_Disputa.SaveDocDisputaFuncionario(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        
        #endregion

    }
}
