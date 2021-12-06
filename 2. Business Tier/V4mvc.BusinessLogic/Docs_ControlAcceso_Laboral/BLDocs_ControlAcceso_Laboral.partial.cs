using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_ControlAcceso_Laboral
	{

        #region [ Consultas ]

        public ObservableCollection<Docs_ControlAcceso_Laboral> GetDocs_ControlAcceso_LaboralHistorico(int ID_DOC, string RUT)
        {
            try
            {
                var docs =  this.Repository.GetDocs_ControlAcceso_LaboralHistorico(ID_DOC, RUT);
                if (docs != null)
                {
                    foreach (var doc in docs)
                    {
                        doc.DISPUTA = RepositoryDocs_ControlAcceso_Laboral_Disputa.GetDocs_ControlAcceso_Laboral_Disputa_Top(RUT, doc.FECHA_INI, doc.FECHA_FIN, doc.EMPRESA, ID_DOC, (Guid)doc.ID_ARCHIVO);                      
                    }
                }
                return docs;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveDocsControlAccesoLaboral(ref Docs_ControlAcceso_Laboral Item)
        {
            try
            {
				using (TransactionScope tran = new TransactionScope())
				{
					var archivo = Item.ARCHIVO;
					if (archivo.ARCHIVO != null)
					{
						this.RepositoryArchivos.Save(ref archivo);
					}
					Item.ID_ARCHIVO = archivo.ID;
                    Item.NOMBRE_ARCHIVO = archivo.NOMBRE;
                    Item.TIPO_CONTENIDO = archivo.TIPOCONTENIDO;
                    this.Repository.Save(ref Item);					

					tran.Complete();
				}

				return true;
			}
            catch (Exception ex)
            { throw ex; }
        }
        public bool DeleteDocsControlAccesoLaboral(ref Docs_ControlAcceso_Laboral Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_ControlAcceso_Laboral GetDocs_ControlAcceso_LaboralDisputa(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC, int ID_DISPUTA)
        {
            try
            {
                Docs_ControlAcceso_Laboral docs_controlAcceso = Repository.GetDocs_ControlAcceso_LaboralDisputa(RUT, FECHA_INI, FECHA_FIN, ID_DOC, ID_DISPUTA);
                docs_controlAcceso.docs_Tipo_Rechazos = RepositoryDocs_Tipo_Rechazo.GetDocsTipoRechazoDisputaFuncionariosCtta(FECHA_INI, FECHA_FIN, RUT, (Guid)docs_controlAcceso.ID_ARCHIVO);
                return docs_controlAcceso;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_ControlAcceso_Laboral GetDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC)
        {
            try
            {
                var response = Repository.GetDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(RUT, FECHA_INI, FECHA_FIN, ID_DOC);
                response.VALIDADO_DESC = response.VALIDADO == "RE" ? "RECHAZADO" : response.VALIDADO == "SI" ? "VALIDADO" : "PENDIENTE";
                response.docs_Tipo_Rechazos = RepositoryDocs_Tipo_Rechazo.GetDocsTipoRechazoDisputaFuncionariosCtta(FECHA_INI, FECHA_FIN, RUT, (Guid)response.ID_ARCHIVO);
                response.FECHA_INI_FORMAT = Utils.Fec_User(response.FECHA_INI, Utils.Formato_Fecha.Guion);  
                response.FECHA_FIN_FORMAT = Utils.Fec_User(response.FECHA_FIN, Utils.Formato_Fecha.Guion);  
                response.DISPUTA = RepositoryDocs_ControlAcceso_Laboral_Disputa.GetDocs_ControlAcceso_Laboral_Disputa_Top(RUT, FECHA_INI, FECHA_FIN, response.EMPRESA, ID_DOC, (Guid)response.ID_ARCHIVO);
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool InsertDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC, string OBSERVACION, string USUARIO)
        {
            try
            {
                return this.Repository.InsertDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(RUT, FECHA_INI, FECHA_FIN, ID_DOC, OBSERVACION, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool Delete_Docs_ControlAcceso_Laboral_FuncionariosCtta(int ID, int ID_DISPUTA, string USUARIO)
        {
            try
            {
                return this.Repository.Delete_Docs_ControlAcceso_Laboral_FuncionariosCtta(ID, ID_DISPUTA,  USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
