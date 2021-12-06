using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDivisiones
	{

        #region [ Consultas ]

        public ObservableCollection<Divisiones> GetDivisionesLaborales(String RUT) {
            try
            {
                return this.Repository.GetDivisionesLaborales(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetDivisionesConPase(int ID_DOC)
        {
            try
            {
                return this.Repository.GetDivisionesConPase(ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetAllDivisionesMDTE(String ADMRUT)
        {
            try
            {
                return this.Repository.GetAllDivisionesMDTE(ADMRUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetDivisionesFichaEmpresa(String IDEMPRESA)
        {
            try
            {
                return this.Repository.GetDivisionesFichaEmpresa(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetAllDivisiones_PasesCtta(String IDEMPRESA)
        {
            try
            {
                return this.Repository.GetAllDivisiones_PasesCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarOSTFinal_PasesCtta(string OST, string IDEMPRESA, string DIVISION, out bool m_apr, out bool m_arranque)
        {
            try
            {
                return this.Repository.ValidarOSTFinal_PasesCtta(OST, IDEMPRESA, DIVISION, out m_apr, out m_arranque);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
