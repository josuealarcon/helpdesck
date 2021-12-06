using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAA407_dotacion_docs_emp_2
    {
        #region [ Consultas ]
        public ObservableCollection<A407_dotacion_docs_emp_2> Get_View_A407_dotacion_docs_emp_2_InformeControlLaboralCtta(A407_dotacion_docs_emp_2 Item)
        {
            try
            {
                ObservableCollection<A407_dotacion_docs_emp_2> items = new ObservableCollection<A407_dotacion_docs_emp_2>();
                A407_dotacion_docs_emp_2 item = new A407_dotacion_docs_emp_2();
                Instance.DAAsignarProcedure("V4MVC_A407_DOTACION_DOCS_EMP_2_SELECT_INFORME_DOCUMENTOSCARGADOSAUDITORIALABORALMENSUAL_INFORME_CONTROLLABAROAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", Item.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);               
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A407_dotacion_docs_emp_2();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        item.PERIODOCOSULTA= Utils.Fec_User(Item.PERIODO, Utils.Formato_Fecha.GuionMesLetras);
                        item.EMPRESA_COD = Utils.strRut(Item.EMPRESA);
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
        #region [ Metodos ]
        #endregion
    }
}