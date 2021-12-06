using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLCursoProg
    {

        #region [ Consultas ]

        public ObservableCollection<CursoProg> GetAllCursosProgCtta()
        {
            try
            {
                return this.Repository.GetAllCursosProgCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CursoProg> GetListCargarCursosCtta(CursoProg model)
        {
            try
            {
                return this.Repository.GetListCargarCursosCtta(model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Informes ]

        public ObservableCollection<CursoProg> GetCursoProg_Grid_CharlasyReservas_InformeFuncionariosCtta(CursoProg request)
        {
            try
            {
                return this.Repository.GetCursoProg_Grid_CharlasyReservas_InformeFuncionariosCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
