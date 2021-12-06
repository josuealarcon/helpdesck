using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]

        OST GetOneOST_Mdte(string NROOST);
        bool ValidateOST(string NROOST);
        bool GetStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE);

        #endregion

        #region [ Metodos ]

        bool UpdateStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE);
        bool SaveContratoOST_Mdte(ref OST model);

        #endregion

    }
}
