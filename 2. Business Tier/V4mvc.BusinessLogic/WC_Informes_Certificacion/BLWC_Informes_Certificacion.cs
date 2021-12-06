using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLWC_Informes_Certificacion : IBLWC_Informes_Certificacion
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAWC_Informes_Certificacion Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLWC_Informes_Certificacion(IDAWC_Informes_Certificacion x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<WC_Informes_Certificacion> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public WC_Informes_Certificacion GetOne(Decimal CODMENU)
        {
            try
            {
                return this.Repository.GetOne(CODMENU);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        #endregion

    }
}
