using System;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLBonosValor
	{

        #region [ Consultas ]

        public BonosValor GetBonosValorCtta(string TIPO_BONO, string PERIODO, string DIVISION)
        {
            try
            {
                return this.Repository.GetBonosValorCtta(TIPO_BONO, PERIODO, DIVISION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
