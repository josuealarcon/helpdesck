using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAA054_MotivoFiniquito
	{

        #region [ Consultas ]

        ObservableCollection<A054_MotivoFiniquito> GetA054_MotivoFiniquitosCertificacion(string RUT, int ID_DOC, string DIVCOD, string IDEMPRESA);
        ObservableCollection<A054_MotivoFiniquito> GetMotivosFiniquito_FuncionariosCtta(string RUT, string EMPRESA);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
