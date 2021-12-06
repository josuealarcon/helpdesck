using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Transport
	{

		#region [ Consultas ]
		public Docs_Transport GetDocTransportsDisputa(string ID, string DIVCOD, int ID_DISPUTA)
		{
			try
			{
				Docs_Transport docs_transport = Repository.GetDocTransportsDisputa(ID, DIVCOD, ID_DISPUTA);
				docs_transport.docs_Tipo_Rechazos = RepositoryDocs_Transport_Rechazo.GetDocsTransportRechazoSelectDisputa(ID);
				return docs_transport;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean SaveTransportHistoryMaintenance(ref Docs_Transport Item)
		{
			try
			{
				using (TransactionScope tran = new TransactionScope())
				{
					var archivo = Item.ARCHIVO_CARGADO;
					if (archivo.ARCHIVO != null) {
						this.RepositoryArchivos.Save(ref archivo); 
						Item.ID = archivo.ID;
					}
                    if (Item != null)
                    {
                        if (Item.LISTA_FECHAS != null)
                        {
                            foreach (var fecha in Item.LISTA_FECHAS)
                            {
                                Docs_Fec_Workers docs_Fec_Workers = new Docs_Fec_Workers();
                                docs_Fec_Workers.RUT = Item.PATENTE;
                                docs_Fec_Workers.ID_DOC_FEC = fecha.ID_DOC_FEC;
                                docs_Fec_Workers.EMPRESA = Item.EMPRESA;
                                docs_Fec_Workers.DIVISION = Item.DIVCOD;
                                docs_Fec_Workers.FECHA = fecha.FECHA;
                                docs_Fec_Workers.USUARIO = Item.USUARIO;
                                if (RepositoryDocsFecWorkers.GetDocumentacionTransportFechaCtta(Item.PATENTE, fecha.ID_DOC_FEC, Item.DIVCOD, Item.EMPRESA) != null)
                                    docs_Fec_Workers.Instance = InstanceEntity.Modify;
                                else
                                    docs_Fec_Workers.Instance = InstanceEntity.New;
                                RepositoryDocsFecWorkers.Save(ref docs_Fec_Workers); 
                            }
                        }
                        this.Repository.DocsTransport_Insert_HistoricoVehiculosCtta(Item);
                    }
                    tran.Complete();
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
