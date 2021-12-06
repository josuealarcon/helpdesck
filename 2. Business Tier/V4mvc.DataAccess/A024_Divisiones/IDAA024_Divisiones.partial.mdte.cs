using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAA024_Divisiones
    {

        #region [ Consultas ]

        ObservableCollection<A024_Divisiones> GetAllA024DivisionesMandante_Mdte(string MANDANTE);

        ObservableCollection<A024_Divisiones> GetAllA024DivisionesMandante_Mdte();

        ObservableCollection<A024_Divisiones> GetAllA024Divisiones_CertificacionMdte(string DIVISIONES);

        ObservableCollection<A024_Divisiones> GetAllA024Divisiones_CertificacionMdte();
        ObservableCollection<A024_Divisiones> GetListDivisionesChecked_Mdte(string DIVCOD);


        ObservableCollection<A024_Divisiones> GetAllA024DivisionesCharlasCheked_Mdte(int IdCharla);


        #endregion

    }
}
