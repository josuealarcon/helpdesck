using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs
	{
        #region[ Consultas ]
        ObservableCollection<Docs> GetExistencia_DOCS_Mdte();
        ObservableCollection<Docs> GetAllDocsAcredFuncionario_Mdte(ref Docs modelo);
        ObservableCollection<Docs> GetAllDocsAcredFuncionarioConduccion_Mdte(ref Docs modelo);
        ObservableCollection<Docs> GetAllDocsAcredVehiculo_Mdte(ref Docs modelo);
        ObservableCollection<Docs> GetAllDocs_CertificacionMdte(string PATENTE, string DIVCOD, string TIPO_VEHICULO);
        ObservableCollection<Docs> GetAllDocs_CertificacionDocsMdte(ref Docs modelo);     
        ObservableCollection<Docs> GetAllCertificadosPases_Mdte(string RUT, string DIVCOD, int NRO, int OPCION);
        Docs GetListDocsDocumentos_Mdte(int ID_DOC, string PATENTE, string EMPRESA, string DIVCOD);
        ObservableCollection<Docs> GetListDocumentos_Mdte();
        #endregion

        #region Metodos

        bool SaveDocsVehiculos_Mdte(ref Docs Docs);

        #endregion

    }
}

