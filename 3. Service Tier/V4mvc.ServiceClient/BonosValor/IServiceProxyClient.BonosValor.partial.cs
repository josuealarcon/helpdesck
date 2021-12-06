using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		BonosValor GetBonosValorCtta(string TIPO_BONO, string PERIODO, string DIVISION);

		#endregion

		#region [ Metodos ]

		#endregion

	}
}