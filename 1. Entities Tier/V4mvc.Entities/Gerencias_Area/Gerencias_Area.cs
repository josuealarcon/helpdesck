using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Gerencias_Area
	{
		#region [ Variables ]

		private decimal m_idarea;
		private string m_descripcion;
		private string m_activo;
		private Int32? m_idgerencia;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Gerencias_Area.
		/// </summary>
		public Gerencias_Area()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDAREA.
		/// </summary>
		public decimal IDAREA
		{
			get { return m_idarea; }
			set
			{
				if (m_idarea != value)
				{
					m_idarea = value;
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
		/// Gets or sets el valor de: IDGERENCIA.
		/// </summary>
		public Int32? IDGERENCIA
		{
			get { return m_idgerencia; }
			set
			{
				if (m_idgerencia != value)
				{
					m_idgerencia = value;
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
