using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public OSTArbol GetOneOSTArbol(string OST, string MADRE, string EMPRESA, Int16 NIVEL)
        {
            try
            {
                return this.BL_OSTArbol.GetOne(OST, MADRE, EMPRESA, NIVEL);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public OSTArbol GetOstArbolReferencia_Mdte(string OST, string MADRE, string EMPRESA, Int16 NIVEL)
        {
            try
            {
                return this.BL_OSTArbol.GetOstArbolReferencia_Mdte(OST, MADRE, EMPRESA, NIVEL);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<OSTArbol> GetAllOstArbolTurnos_Mdte(string EMPRESA)
        {
            try
            {
                return this.BL_OSTArbol.GetAllOstArbolTurnos_Mdte(EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveOstArbol_Mdte(ref OSTArbol Item)
        {
            try
            {
                return this.BL_OSTArbol.SaveOstArbol_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public OSTArbol SaveOstArbolOST_Mdte(ref OSTArbol Item)
        {
            try
            {
                return this.BL_OSTArbol.SaveOstArbolOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
