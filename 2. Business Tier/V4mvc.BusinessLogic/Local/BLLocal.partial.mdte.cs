using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLLocal
    {

        #region [ Consultas ]

        public ObservableCollection<Local> GetAllLocal_v2_PasesMdte(string RUT, string DIVISION, int IDPASE, string ID_EMPRESA)
        {
            try
            {
                return this.Repository.GetAllLocal_v2_PasesMdte(RUT, DIVISION, IDPASE, ID_EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Local> GetAllLocal_PasesMdte(string DIVCOD)
        {
            try
            {
                return this.Repository.GetAllLocal_PasesMdte(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
