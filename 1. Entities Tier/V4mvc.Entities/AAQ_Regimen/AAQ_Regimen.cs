using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class AAQ_Regimen
	{
		#region [ Variables ]

		private Int32 m_idregimen;
		private string m_nombre;
		private string m_reqcodconcivil;
		private string m_activo;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase AAQ_Regimen.
		/// </summary>
		public AAQ_Regimen()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDREGIMEN.
		/// </summary>
		public Int32 IDREGIMEN
		{
			get { return m_idregimen; }
			set
			{
				if (m_idregimen != value)
				{
					m_idregimen = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRE.
		/// </summary>
		public string NOMBRE
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
		/// Gets or sets el valor de: REQCODCONCIVIL.
		/// </summary>
		public string REQCODCONCIVIL
		{
			get { return m_reqcodconcivil; }
			set
			{
				if (m_reqcodconcivil != value)
				{
					m_reqcodconcivil = value;
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
