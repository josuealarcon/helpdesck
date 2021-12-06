using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class A036_CursoParametros
	{

		#region [ Variables ]

		private Int32 m_id_parametro;
		private String m_nombre;
		private String m_valor;

		#endregion

		#region [ Constructores ]

		/// <summary>
		/// Inicializar una nueva instancia de la clase A036_CursoParametros.
		/// </summary>
		public A036_CursoParametros()
		{ }

		#endregion

		#region [ Propiedades ]

		/// <summary>
		/// Gets or sets el valor de: ID_PARAMETRO.
		/// </summary>
		public Int32 ID_PARAMETRO
		{
			get { return m_id_parametro; }
			set
			{
				if (m_id_parametro != value)
				{
					m_id_parametro = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRE.
		/// </summary>
		public String NOMBRE
		{
			get { return m_nombre; }
			set
			{
				if (m_nombre != value)
				{
					m_nombre = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALOR.
		/// </summary>
		public String VALOR
		{
			get { return m_valor; }
			set
			{
				if (m_valor != value)
				{
					m_valor = value;
				}
			}
		}

		#endregion

		#region [ Instance Entity ]

		public InstanceEntity m_instance;

		/// <summary>
		/// Gets or sets el valor de: InstanceEntity.
		/// </summary>
		public InstanceEntity Instance
		{
			get { return m_instance; }
			set { m_instance = value; }
		}

		#endregion

	}
}