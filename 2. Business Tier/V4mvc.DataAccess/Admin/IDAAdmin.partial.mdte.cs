namespace V4mvc.DataAccess
{
    public partial interface IDAAdmin
    {

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]

        bool UpdateClaveAdmin(string RUT, string NEWPASSWORD);
        bool ValidarClaveMdte(string RUT, string CLAVE);
        bool ValidarClaveHistoricoMdte(string RUT, string CLAVE);
        bool CambioClaveMdte(string RUT, string NUEVACLAVE);
        bool CambioClaveHistoricoMdte(string RUT, string NUEVACLAVE, string IP);

        #endregion

    }
}
