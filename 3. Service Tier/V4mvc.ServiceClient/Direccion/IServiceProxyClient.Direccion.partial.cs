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

        ObservableCollection<Direccion> GetAllPaises();
        ObservableCollection<Direccion> GetAllRegionesByPais(String PAIS);
        ObservableCollection<Direccion> GetAllCiudadByRegion(String REGION);
        ObservableCollection<Direccion> GetAllComunaByCiudad(String CIUDAD);
        ObservableCollection<Direccion> GetAllCiudad();

        #endregion

        #region [ Metodos ]

        Boolean SaveDireccionCtta(ref Direccion Item);
        bool SaveDireccionCovidF00(ref Direccion item);
        bool SaveDireccionCovidF100(ref Direccion item);
        bool SaveDireccionCovidF300(ref Direccion Item);
        bool SaveDireccionCelularRut(String CELULAR, String RUT);
        #endregion

    }
}
