using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLA407_dotacion_docs_emp_2
    {

        #region [ Consultas ]
        public ObservableCollection<A407_dotacion_docs_emp_2> Get_View_A407_dotacion_docs_emp_2_InformeControlLaboralCtta(A407_dotacion_docs_emp_2 Item)
        {
            try
            {
                return Repository.Get_View_A407_dotacion_docs_emp_2_InformeControlLaboralCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }     
        
        #endregion

    }
}
