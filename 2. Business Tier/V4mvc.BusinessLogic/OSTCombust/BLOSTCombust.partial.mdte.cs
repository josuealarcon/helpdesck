using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLOSTCombust
	{

		#region [ Consultas ]

		public ObservableCollection<OSTCombust> GetAllOSTCombust_Mdte(string NROOST, string IDEMPRESA)
		{
			try
			{
				return this.Repository.GetAllOSTCombust_Mdte(NROOST,IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

        #endregion

        #region [ Metodos ]

        public bool DeleteOstCombustOST_Mdte(ref OST Item)
        {
            try
            {
                return this.Repository.DeleteOstCombustOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveOstCombustOST_Mdte(ref OSTCombust Item)
        {
            try
            {
                return this.Repository.SaveOstCombustOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveOstCombustOST_Mdte(ObservableCollection<OSTCombust> Items)
        {
            try
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items.ElementAt(i);
                    this.Repository.SaveOstCombustOST_Mdte(ref item);
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
