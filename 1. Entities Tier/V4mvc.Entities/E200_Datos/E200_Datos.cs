using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class E200_Datos
	{
		#region [ Variables ]

		private Guid m_id;
		private string m_empresa;
		private string m_ost;
		private string m_periodo;
		private decimal? m_general;
		private Int32? m_gerencia;
		private decimal? m_area;
		private string m_contable;
		private string m_mutualidad;
		private string m_paritario;
		private string m_division;
		private string m_fechamod;
		private string m_horamod;
		private string m_usuariomod;
		private string m_local;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase E200_Datos.
		/// </summary>
		public E200_Datos()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Guid ID
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
		/// Gets or sets el valor de: EMPRESA.
		/// </summary>
		public string EMPRESA
		{
			get { return m_empresa; }
			set
			{
				if (m_empresa != value)
				{
					m_empresa = value;
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
		/// Gets or sets el valor de: PERIODO.
		/// </summary>
		public string PERIODO
		{
			get { return m_periodo; }
			set
			{
				if (m_periodo != value)
				{
					m_periodo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GENERAL.
		/// </summary>
		public decimal? GENERAL
		{
			get { return m_general; }
			set
			{
				if (m_general != value)
				{
					m_general = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GERENCIA.
		/// </summary>
		public Int32? GERENCIA
		{
			get { return m_gerencia; }
			set
			{
				if (m_gerencia != value)
				{
					m_gerencia = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AREA.
		/// </summary>
		public decimal? AREA
		{
			get { return m_area; }
			set
			{
				if (m_area != value)
				{
					m_area = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONTABLE.
		/// </summary>
		public string CONTABLE
		{
			get { return m_contable; }
			set
			{
				if (m_contable != value)
				{
					m_contable = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MUTUALIDAD.
		/// </summary>
		public string MUTUALIDAD
		{
			get { return m_mutualidad; }
			set
			{
				if (m_mutualidad != value)
				{
					m_mutualidad = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PARITARIO.
		/// </summary>
		public string PARITARIO
		{
			get { return m_paritario; }
			set
			{
				if (m_paritario != value)
				{
					m_paritario = value;
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
		/// Gets or sets el valor de: USUARIOMOD.
		/// </summary>
		public string USUARIOMOD
		{
			get { return m_usuariomod; }
			set
			{
				if (m_usuariomod != value)
				{
					m_usuariomod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOCAL.
		/// </summary>
		public string LOCAL
		{
			get { return m_local; }
			set
			{
				if (m_local != value)
				{
					m_local = value;
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
