using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;
using System.Data.SqlClient;

namespace V4mvc.DataAccess
{
    public partial interface IDADocs
    {

        #region [ Consultas ]
        ObservableCollection<Docs> GetExistencia_DOCS_Mdte();
        ObservableCollection<Docs> GetAllAcredFuncionarioDocs_Mdte(ref Docs modelo);
        ObservableCollection<Docs> GetAllDocsAcredVehiculo_Mdte(ref Docs modelo);
        ObservableCollection<Docs> GetAllDocsAcredFuncionarioConduccion_Mdte(ref Docs modelo);
        ObservableCollection<Docs> GetAllDocs_CertificacionMdte(string PATENTE, string DIVCOD, string TIPO_VEHICULO);
        ObservableCollection<Docs> GetAllDocs_CertificacionDocsMdte(ref Docs modelo);
        Docs GetOneDocsNombreArchivo_Mdte(int ID_DOC, string PATENTE, string EMPRESA, string DIVCOD);
        ObservableCollection<Docs> GetAllCertificadosPases_Mdte(string RUT, string DIVCOD, int NRO, int OPCION);
        ObservableCollection<Docs> GetListDocumentos_Mdte();
        #endregion

    }
}
