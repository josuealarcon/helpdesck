using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]

        public ObservableCollection<CursoProg> GetAllCursosProgCtta()
        {
            try
            {
                return this.BL_CursoProg.GetAllCursosProgCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CursoProg> GetListCargarCursosCtta(CursoProg model)
        {
            try
            {
                return this.BL_CursoProg.GetListCargarCursosCtta(model);
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
                return this.BL_CursoProg.GetCursoProg_Grid_CharlasyReservas_InformeFuncionariosCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
