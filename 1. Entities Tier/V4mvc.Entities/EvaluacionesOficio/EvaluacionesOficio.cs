using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class EvaluacionesOficio
	{
		#region [ Variables ]

		private Int32 m_idcharla;
		private string m_charla;
		private string m_descrip;
		private Int32? m_horas;
		private Int32? m_vencimiento;
		private string m_area;
		private string m_proceso;
		private string m_vence;
		private string m_fechamod;
		private string m_horamod;
		private string m_grabo;
		private Int32? m_id_doc_fec;
		private string m_division;
		private string m_campofec;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase EvaluacionesOficio.
		/// </summary>
		public EvaluacionesOficio()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDCHARLA.
		/// </summary>
		public Int32 IDCHARLA
		{
			get { return m_idcharla; }
			set
			{
				if (m_idcharla != value)
				{
					m_idcharla = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHARLA.
		/// </summary>
		public string CHARLA
		{
			get { return m_charla; }
			set
			{
				if (m_charla != value)
				{
					m_charla = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCRIP.
		/// </summary>
		public string DESCRIP
		{
			get { return m_descrip; }
			set
			{
				if (m_descrip != value)
				{
					m_descrip = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAS.
		/// </summary>
		public Int32? HORAS
		{
			get { return m_horas; }
			set
			{
				if (m_horas != value)
				{
					m_horas = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VENCIMIENTO.
		/// </summary>
		public Int32? VENCIMIENTO
		{
			get { return m_vencimiento; }
			set
			{
				if (m_vencimiento != value)
				{
					m_vencimiento = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AREA.
		/// </summary>
		public string AREA
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
		/// Gets or sets el valor de: PROCESO.
		/// </summary>
		public string PROCESO
		{
			get { return m_proceso; }
			set
			{
				if (m_proceso != value)
				{
					m_proceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VENCE.
		/// </summary>
		public string VENCE
		{
			get { return m_vence; }
			set
			{
				if (m_vence != value)
				{
					m_vence = value;
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
		/// Gets or sets el valor de: ID_DOC_FEC.
		/// </summary>
		public Int32? ID_DOC_FEC
		{
			get { return m_id_doc_fec; }
			set
			{
				if (m_id_doc_fec != value)
				{
					m_id_doc_fec = value;
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
		/// Gets or sets el valor de: CAMPOFEC.
		/// </summary>
		public string CAMPOFEC
		{
			get { return m_campofec; }
			set
			{
				if (m_campofec != value)
				{
					m_campofec = value;
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
