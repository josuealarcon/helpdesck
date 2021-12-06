using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Tab_Tipocotizacion
	{
		#region [ Variables ]

		private Int16 m_id;
		private string m_descripcion;
		private string m_activo;
		private string m_extension;
		private string m_envio_externo;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Tab_Tipocotizacion.
		/// </summary>
		public Tab_Tipocotizacion()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Int16 ID
		{
			get { return m_id; }
			set
			{
				if (m_id != value)
				{
					m_id = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
		public string DESCRIPCION
		{
			get { return m_descripcion; }
			set
			{
				if (m_descripcion != value)
				{
					m_descripcion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACTIVO.
		/// </summary>
		public string ACTIVO
		{
			get { return m_activo; }
			set
			{
				if (m_activo != value)
				{
					m_activo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXTENSION.
		/// </summary>
		public string EXTENSION
		{
			get { return m_extension; }
			set
			{
				if (m_extension != value)
				{
					m_extension = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENVIO_EXTERNO.
		/// </summary>
		public string ENVIO_EXTERNO
		{
			get { return m_envio_externo; }
			set
			{
				if (m_envio_externo != value)
				{
					m_envio_externo = value;
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
