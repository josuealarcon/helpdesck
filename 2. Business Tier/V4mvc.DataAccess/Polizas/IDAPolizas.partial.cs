using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAPolizas
	{

		#region [ Consultas ]
		ObservableCollection<Polizas> GetPolizasDatatablePolizasCtta();
		ObservableCollection<Polizas> GetPolizasEditarDatatablePolizasCtta(Polizas Item);
		ObservableCollection<Polizas> GetOstsubcComboPolizasCtta(Polizas Item);
		ObservableCollection<Polizas> GetPolizasNominaDatatablePolizasCtta(Polizas Item);
		ObservableCollection<Polizas> GetPolizasPagoPolizasCtta(Polizas Item);
		Polizas GetOnePolizaCargada(int IDDOC, string NROPOLIZA);
		#endregion

		#region [ Metodos ]
		bool InsertPolizaEditarPolizasCtta(Polizas Item);
		bool DeletePolizaEditarPolizasCtta(Polizas Item);
		Polizas DeletePolizaPagoPolizasCtta(Polizas Item);
		bool InsertPolizaNominaPolizasCtta(Polizas Item);
		bool DeletePolizaNominaPorNroPolizaPolizasCtta(Polizas Item);
		bool InsertPolizaPagoPolizasCtta(Polizas Item);
		#endregion
	}
}
