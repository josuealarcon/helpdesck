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
		public ObservableCollection<OSTArbol> GetOstDocFecVarios(string IDEMPRESA)
		{
			try
			{
				return this.BL_OSTArbol.GetOstDocFecVarios(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<OSTArbol> GetOstPorEmpresaTurnosCtta(string EMPRESA)
		{
			try
			{
				return this.BL_OSTArbol.GetOstPorEmpresaTurnosCtta(EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<OSTArbol> GetOstPorDivEmpresa_Informe(string DIVISION, string EMPRESA)
		{
			try
			{
				return this.BL_OSTArbol.GetOstPorDivEmpresa_Informe(DIVISION,EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<OSTArbol> GetInformeContratosCArranqueCtta(string IDEMPRESA)
		{
			try
			{
				return this.BL_OSTArbol.GetInformeContratosCArranqueCtta(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<OSTArbol> GetInformeContratosCArranqueOstArbolCtta(ref OSTArbol model)
		{
			try
			{
				return this.BL_OSTArbol.GetInformeContratosCArranqueOstArbolCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<OSTArbol> GetInformeContratosEmpresa_InformesEmpresasCtta(OSTArbol Item)
		{
			try
			{
				return this.BL_OSTArbol.GetInformeContratosEmpresa_InformesEmpresasCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public OSTArbol GetOneOSTArbol_ControlLaboralCtta(string EMPRESA)
		{
			try
			{
				return this.BL_OSTArbol.GetOneOSTArbol_ControlLaboralCtta(EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

        public ObservableCollection<OSTArbol> GetOSTsPorEmpresa(string IDEMPRESA)
        {
            try
            {
                return this.BL_OSTArbol.GetOSTsPorEmpresa(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
		
		#endregion

		#region [ Metodos ]
		public bool SaveFileDocContratOSTCtta(Archivos archivo, int ID_DOC, string EXT, string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL, string USUARIO)
		{
			try
			{
				return this.BL_OSTArbol.SaveFileDocContratOSTCtta(archivo, ID_DOC, EXT, NROOST, MADRE, IDEMPRESA, NIVEL, USUARIO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
