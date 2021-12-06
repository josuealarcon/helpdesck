using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLBonosValor
	{

		#region [ Consultas ]

		BonosValor GetBonosValorCtta(string TIPO_BONO, string PERIODO, string DIVISION);

		#endregion

		#region [ Metodos ]

		#endregion

	}
}