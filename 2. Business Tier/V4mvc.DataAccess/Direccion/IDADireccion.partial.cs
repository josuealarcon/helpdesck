using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADireccion
	{

        #region [ Consultas ]

        ObservableCollection<Direccion> GetAllPaises();
        ObservableCollection<Direccion> GetAllRegionesByPais(String PAIS);
        ObservableCollection<Direccion> GetAllCiudadByRegion(String REGION);
        ObservableCollection<Direccion> GetAllComunaByCiudad(String CIUDAD);
        ObservableCollection<Direccion> GetAllCiudad();

        #endregion

        #region [ Metodos ]

        bool SaveDireccionCtta(ref Direccion item);
        bool SaveDireccionCovidF00(ref Direccion item);
        bool SaveDireccionCovidF100(ref Direccion item);
        bool SaveDireccionCovidF300(ref Direccion item);
        bool SaveDireccionCelularRut(String CELULAR, String RUT);

        #endregion
    }
}
