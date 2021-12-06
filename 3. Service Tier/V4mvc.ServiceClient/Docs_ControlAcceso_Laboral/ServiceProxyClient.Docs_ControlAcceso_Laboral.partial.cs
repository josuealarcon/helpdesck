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

        public ObservableCollection<Docs_ControlAcceso_Laboral> GetDocs_ControlAcceso_LaboralHistorico(int ID_DOC, string RUT)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.GetDocs_ControlAcceso_LaboralHistorico(ID_DOC, RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDocsControlAccesoLaboral(ref Docs_ControlAcceso_Laboral Item)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.SaveDocsControlAccesoLaboral(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool DeleteDocsControlAccesoLaboral(ref Docs_ControlAcceso_Laboral Item)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.DeleteDocsControlAccesoLaboral(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_ControlAcceso_Laboral GetDocs_ControlAcceso_LaboralDisputa(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC, int ID_DISPUTA)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.GetDocs_ControlAcceso_LaboralDisputa(RUT, FECHA_INI, FECHA_FIN, ID_DOC, ID_DISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_ControlAcceso_Laboral GetDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.GetDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(RUT, FECHA_INI, FECHA_FIN, ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool InsertDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC, string OBSERVACION, string USUARIO)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.InsertDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(RUT, FECHA_INI, FECHA_FIN, ID_DOC, OBSERVACION, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool Delete_Docs_ControlAcceso_Laboral_FuncionariosCtta(int ID, int ID_DISPUTA, string USUARIO)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.Delete_Docs_ControlAcceso_Laboral_FuncionariosCtta(ID, ID_DISPUTA, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
