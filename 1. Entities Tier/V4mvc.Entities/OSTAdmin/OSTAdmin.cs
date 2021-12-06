using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class OSTAdmin
	{
		#region [ Variables ]

		private string m_nroost;
		private string m_idempresa;
		private string m_admrut;
		private string m_activo;
		private string m_grabo;
		private string m_fechamod;
		private string m_horamod;
		private string m_mandante;
		private string m_division;
		private string m_admdeleg;
		
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase OSTAdmin.
		/// </summary>
		public OSTAdmin()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: NROOST.
		/// </summary>
		public string NROOST
		{
			get { return m_nroost; }
			set
			{
				if (m_nroost != value)
				{
					m_nroost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDEMPRESA.
		/// </summary>
		public string IDEMPRESA
		{
			get { return m_idempresa; }
			set
			{
				if (m_idempresa != value)
				{
					m_idempresa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ADMRUT.
		/// </summary>
		public string ADMRUT
		{
			get { return m_admrut; }
			set
			{
				if (m_admrut != value)
				{
					m_admrut = value;
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
		/// Gets or sets el valor de: GRABO.
		/// </summary>
		public string GRABO
		{
			get { return m_grabo; }
			set
			{
				if (m_grabo != value)
				{
					m_grabo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHAMOD.
		/// </summary>
		public string FECHAMOD
		{
			get { return m_fechamod; }
			set
			{
				if (m_fechamod != value)
				{
					m_fechamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAMOD.
		/// </summary>
		public string HORAMOD
		{
			get { return m_horamod; }
			set
			{
				if (m_horamod != value)
				{
					m_horamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MANDANTE.
		/// </summary>
		public string MANDANTE
		{
			get { return m_mandante; }
			set
			{
				if (m_mandante != value)
				{
					m_mandante = value;
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
		/// Gets or sets el valor de: ADMDELEG.
		/// </summary>
		public string ADMDELEG
		{
			get { return m_admdeleg; }
			set
			{
				if (m_admdeleg != value)
				{
					m_admdeleg = value;
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
