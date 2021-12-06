using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLTransport_Division
    {

        #region [ Consultas ]

        public Transport_Division GetDocumentacionPasesVehiculosCtta(string DIVCOD, string PATENTE, string IDEMPRESA) 
        {
            try
            {
                var transport_division = Repository.GetTransport_DivisionAutorizada(DIVCOD, PATENTE);
                if (transport_division != null)
                {
                    transport_division.Empresa = RepositoryEnterprise.GetEnterpriseTransport_Ctta(DIVCOD, PATENTE, IDEMPRESA);
                    if (transport_division.PASES_VEHICULARES == "SI")
                        transport_division.ListPasesAutorizado = RepositoryTransportDivisionPases.GetTransportDivisionPasesAutorizados(DIVCOD, PATENTE);
                    if (transport_division.DOCUMENTACION == "SI") 
                    {
                        transport_division.ListDocumentos = this.RepositoryDocs.GetAllDocumentacionVehiculosCtta(DIVCOD, PATENTE);
                        foreach (var doc in transport_division.ListDocumentos)
                        {
                            var doc_transport = RepositoryDocsTransport.GetDocsTransportDocumentoValidado(DIVCOD, PATENTE, doc.ID_DOC, doc.COMUN_DIV, doc.COMUN, (transport_division.Empresa != null ? transport_division.Empresa.IDEMPRESA : null));
                            if (doc_transport != null)
                            {
                                doc.VALIDADO = doc_transport.VALIDADO;
                                doc.ID = doc_transport.ID;
                            }

                            doc.OBLIGATORIO = doc.ID_DOC_OPCION == 1 ? "*" : string.Empty;
                            doc.DISPUTA_TRANS = RepositoryDocs_Disputa_Trans.GetDocumentacionDisputaTranspotCtta(PATENTE, DIVCOD, doc.ID_DOC, doc.ID, doc.COMUN_DIV, IDEMPRESA);
                            var docs_fec = RepositoryDocsFec.GetDocsFecVehiculosCtta(doc.ID_DOC, DIVCOD, PATENTE, (transport_division.Empresa != null ? transport_division.Empresa.IDEMPRESA : null));
                            foreach (var fecha in docs_fec)
                            {
                                if (fecha.VALIDO_MAYOR_HOY > 0)
                                {
                                    if (!string.IsNullOrEmpty(fecha.FECHA))
                                    {
                                        if (Convert.ToInt32(fecha.FECHA) >= Convert.ToInt32(fecha.FECHAHOY))
                                            fecha.ESTILO = "text-primary";
                                        else
                                            fecha.ESTILO = "text-danger";
                                    }
                                    else
                                    {
                                        fecha.ESTILO = "text-danger";
                                    }
                                }
                                else
                                {
                                    fecha.ESTILO = "text-primary";
                                }
                            }

                            doc.LISTA_FECHAS = docs_fec;
                        }
                    }
                }

                return transport_division;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool ActivarPaseVehiculoCtta(string DIVCOD, string PATENTE, string IDEMPRESA)
        {
            try
            {
                return this.Repository.ActivarPaseVehiculoCtta(DIVCOD, PATENTE, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
