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

        public ObservableCollection<Divisiones> GetDivisionesLaborales(String RUT)
        {
            try
            {
                return this.BL_Divisiones.GetDivisionesLaborales(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetDivisionesConPase(int ID_DOC)
        {
            try
            {
                return this.BL_Divisiones.GetDivisionesConPase(ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetAllDivisionesMDTE(String ADMRUT)
        {
            try
            {
                return this.BL_Divisiones.GetAllDivisionesMDTE(ADMRUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetDivisionesFichaEmpresa(String IDEMPRESA)
        {
            try
            {
                return this.BL_Divisiones.GetDivisionesFichaEmpresa(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetAllDivisiones_PasesCtta(String IDEMPRESA)
        {
            try
            {
                return this.BL_Divisiones.GetAllDivisiones_PasesCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarOSTFinal_PasesCtta(string OST, string IDEMPRESA, string DIVISION, out bool m_apr, out bool m_arranque)
        {
            try
            {
                return this.BL_Divisiones.ValidarOSTFinal_PasesCtta(OST, IDEMPRESA, DIVISION, out m_apr, out m_arranque);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
