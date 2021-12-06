using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
        
        public ObservableCollection<A407_dotacion_docs_emp_2> Get_View_A407_dotacion_docs_emp_2_InformeControlLaboralCtta(A407_dotacion_docs_emp_2 Item)
        {
            try
            {
                return this.BL_A407_dotacion_docs_emp_2.Get_View_A407_dotacion_docs_emp_2_InformeControlLaboralCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }       
        #endregion

        #region [ Metodos ]
        #endregion

    }
}
