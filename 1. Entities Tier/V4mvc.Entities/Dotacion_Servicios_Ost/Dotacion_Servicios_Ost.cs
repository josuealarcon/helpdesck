using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Dotacion_Servicios_Ost
	{
		#region [ Variables ]

		private string m_servicio;
		private Int32 m_dotacion;
		private string m_division;
		private string m_ost;
		private string m_fecregistra;
		private string m_horaregistra;
		private string m_usrregistra;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Dotacion_Servicios_Ost.
		/// </summary>
		public Dotacion_Servicios_Ost()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: SERVICIO.
		/// </summary>
		public string SERVICIO
		{
			get { return m_servicio; }
			set
			{
				if (m_servicio != value)
				{
					m_servicio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOTACION.
		/// </summary>
		public Int32 DOTACION
		{
			get { return m_dotacion; }
			set
			{
				if (m_dotacion != value)
				{
					m_dotacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIVISION.
		/// </summary>
		public string DIVISION
		{
			get { return m_division; }
			set
			{
				if (m_division != value)
				{
					m_division = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OST.
		/// </summary>
		public string OST
		{
			get { return m_ost; }
			set
			{
				if (m_ost != value)
				{
					m_ost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECREGISTRA.
		/// </summary>
		public string FECREGISTRA
		{
			get { return m_fecregistra; }
			set
			{
				if (m_fecregistra != value)
				{
					m_fecregistra = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAREGISTRA.
		/// </summary>
		public string HORAREGISTRA
		{
			get { return m_horaregistra; }
			set
			{
				if (m_horaregistra != value)
				{
					m_horaregistra = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USRREGISTRA.
		/// </summary>
		public string USRREGISTRA
		{
			get { return m_usrregistra; }
			set
			{
				if (m_usrregistra != value)
				{
					m_usrregistra = value;
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
