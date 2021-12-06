using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDABonosValor
	{

		#region [ Consultas ]

		BonosValor GetBonosValorCtta(string TIPO_BONO, string PERIODO, string DIVISION);

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
