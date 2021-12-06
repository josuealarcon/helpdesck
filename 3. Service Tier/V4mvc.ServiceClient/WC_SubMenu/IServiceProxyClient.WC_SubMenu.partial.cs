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

        ObservableCollection<WC_SubMenu> GetAllSubMenuCtta(String TIPOUSUARIO);
        ObservableCollection<WC_SubMenu> GetAllSubMenuMdte(String ADMTIPO, String ADMLUGAR);

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
