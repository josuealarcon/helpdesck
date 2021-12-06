using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLA024_Divisiones
    {

        #region [ Consultas ]

        public ObservableCollection<A024_Divisiones> GetAllA024DivisionesMandante_Mdte(string MANDANTE)
        {
            try
            {
                return Repository.GetAllA024DivisionesMandante_Mdte(MANDANTE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<A024_Divisiones> GetAllA024DivisionesMandante_Mdte()
        {
            try
            {
                return Repository.GetAllA024DivisionesMandante_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_CertificacionMdte()
        {
            try
            {
                return Repository.GetAllA024Divisiones_CertificacionMdte();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<A024_Divisiones> GetAllA024DivisionesCharlasCheked_Mdte(int IdCharla)
        {
            try
            {
                return Repository.GetAllA024DivisionesCharlasCheked_Mdte(IdCharla);
            }
            catch (Exception ex)
            { throw ex; }
        }
    }


    #endregion

}

