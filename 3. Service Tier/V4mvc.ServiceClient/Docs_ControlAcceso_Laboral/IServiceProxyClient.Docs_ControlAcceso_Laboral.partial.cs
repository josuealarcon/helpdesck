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

        ObservableCollection<Docs_ControlAcceso_Laboral> GetDocs_ControlAcceso_LaboralHistorico(int ID_DOC, string RUT);
        bool SaveDocsControlAccesoLaboral(ref Docs_ControlAcceso_Laboral Item);
        bool DeleteDocsControlAccesoLaboral(ref Docs_ControlAcceso_Laboral Item);
        Docs_ControlAcceso_Laboral GetDocs_ControlAcceso_LaboralDisputa(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC, int ID_DISPUTA);
        Docs_ControlAcceso_Laboral GetDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC);
        bool InsertDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC, string OBSERVACION, string USUARIO);
        bool Delete_Docs_ControlAcceso_Laboral_FuncionariosCtta(int ID, int ID_DISPUTA, string USUARIO);
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
