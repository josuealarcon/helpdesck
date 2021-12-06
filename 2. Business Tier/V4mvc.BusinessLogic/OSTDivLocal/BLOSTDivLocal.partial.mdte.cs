using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLOSTDivLocal
    {

        #region [ Consultas ]
        public ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_Mdte(string NROOST, string MANDANTE, string EMPRESA)
        {
            try
            {
                return this.Repository.GetAllOSTDivLocal_Mdte(NROOST, MANDANTE, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool SaveOstDivLocalOST_Mdte(ref OSTDivLocal Item)
        {
            try
            {
                return this.Repository.SaveOstDivLocalOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveOstDivLocalOST_Mdte(ObservableCollection<OSTDivLocal> Items)
        {
            try
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items.ElementAt(i);
                    this.Repository.SaveOstDivLocalOST_Mdte(ref item);
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
