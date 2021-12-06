using System;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLOSTArbol
	{

		#region [ Consultas ]
		public ObservableCollection<OSTArbol> GetOstDocFecVarios(string IDEMPRESA)
		{
			try
			{
				return this.Repository.GetOstDocFecVarios(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<OSTArbol> GetOstPorEmpresaTurnosCtta(string EMPRESA)
		{
			try
			{
				return this.Repository.GetOstPorEmpresaTurnosCtta(EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<OSTArbol> GetOstPorDivEmpresa_Informe(string DIVISION, string EMPRESA)
		{
			try
			{
				return this.Repository.GetOstPorDivEmpresa_Informe(DIVISION,EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<OSTArbol> GetInformeContratosCArranqueCtta(string IDEMPRESA)
		{
			try
			{
				return this.Repository.GetInformeContratosCArranqueCtta(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<OSTArbol> GetInformeContratosCArranqueOstArbolCtta(ref OSTArbol model)
		{
			try
			{
				return this.Repository.GetInformeContratosCArranqueOstArbolCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<OSTArbol> GetInformeContratosEmpresa_InformesEmpresasCtta(OSTArbol Item)
		{
			try
			{
				return this.Repository.GetInformeContratosEmpresa_InformesEmpresasCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public OSTArbol GetOneOSTArbol_ControlLaboralCtta(string EMPRESA)
		{
			try
			{
				return this.Repository.GetOneOSTArbol_ControlLaboralCtta(EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

        public ObservableCollection<OSTArbol> GetOSTsPorEmpresa(string IDEMPRESA) {
            try
            {
                return this.Repository.GetOSTsPorEmpresa(IDEMPRESA);
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
                using (TransactionScope tran = new TransactionScope())
                {
					if (this.Repository.UpdateOSTArbol_ContratOSTCtta(ID_DOC, EXT, NROOST, MADRE, IDEMPRESA, NIVEL)){
						this.ArchivoRepository.Save(ref archivo);
						this.RepositoryDocsOST2.InsertDocsOST2_ContratOSTCtta(archivo.ID, ID_DOC, NROOST, MADRE, IDEMPRESA, NIVEL, USUARIO);
					}
					tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            {
				throw ex; 
			}
        }
        #endregion

    }
}
