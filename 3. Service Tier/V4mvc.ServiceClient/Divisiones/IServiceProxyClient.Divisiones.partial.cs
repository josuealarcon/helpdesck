using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

        #region [ Consultas ]

        ObservableCollection<Divisiones> GetDivisionesLaborales(String RUT);
        ObservableCollection<Divisiones> GetDivisionesConPase(int ID_DOC);
        ObservableCollection<Divisiones> GetAllDivisionesMDTE(String ADMRUT);
        ObservableCollection<Divisiones> GetDivisionesFichaEmpresa(String IDEMPRESA);

        ObservableCollection<Divisiones> GetAllDivisiones_PasesCtta(String IDEMPRESA);

        bool ValidarOSTFinal_PasesCtta(string OST, string IDEMPRESA, string DIVISION, out bool m_apr, out bool m_arranque);

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
