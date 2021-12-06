using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLA024_Divisiones
    {

        #region [ Consultas ]

        ObservableCollection<A024_Divisiones> GetAllA024DivisionesMandante_Mdte(string MANDANTE);

        ObservableCollection<A024_Divisiones> GetAllA024DivisionesMandante_Mdte();

        ObservableCollection<A024_Divisiones> GetAllA024Divisiones_CertificacionMdte();

        ObservableCollection<A024_Divisiones> GetAllA024DivisionesCharlasCheked_Mdte(int IdCharla);
        #endregion

    }
}
