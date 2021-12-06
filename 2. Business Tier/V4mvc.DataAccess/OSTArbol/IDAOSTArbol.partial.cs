using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAOSTArbol
	{

		#region [ Consultas ]

		ObservableCollection<OSTArbol> GetOstDocFecVarios(string IDEMPRESA);
		ObservableCollection<OSTArbol> GetOstPorEmpresaTurnosCtta(string EMPRESA);
		ObservableCollection<OSTArbol> GetOstPorDivEmpresa_Informe(string DIVISION, string EMPRESA);
		ObservableCollection<OSTArbol> GetInformeContratosCArranqueCtta(string IDEMPRESA);
		ObservableCollection<OSTArbol> GetInformeContratosCArranqueOstArbolCtta(ref OSTArbol model);
		ObservableCollection<OSTArbol> GetInformeContratosEmpresa_InformesEmpresasCtta(OSTArbol Item);
		OSTArbol GetOneOSTArbol_ControlLaboralCtta(string EMPRESA);
        ObservableCollection<OSTArbol> GetOSTsPorEmpresa(string IDEMPRESA);
		#endregion

		#region [ Metodos ]
		bool UpdateOSTArbol_ContratOSTCtta(int ID_DOC, string EXT, string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL);
		
		#endregion
	}
}
