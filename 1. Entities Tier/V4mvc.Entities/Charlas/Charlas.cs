using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Charlas 
	{
		#region [ Variables ]
		private Int32 m_idcharla;
		private String m_charla;
		private String m_descrip;
		private Nullable<Int32> m_horas;
		private Nullable<Int32> m_vencimiento;
		private String m_area;
		private String m_proceso;
		private String m_vence;
		private String m_fechamod;
		private String m_horamod;
		private String m_grabo;
		private Nullable<Int32> m_id_doc_fec;
		private String m_division;
		private String m_campofec;
		private String m_obligatorio;
		private Nullable<Int32> m_id_area;
		private Nullable<Int32> m_porcentaje;
		private Nullable<Int32> m_id_clasifiacion;
		private Nullable<Int32> m_id_ambito;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Charlas.
		/// </summary>
		public Charlas()
		{  }
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
		public String CHARLA
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
		public String DESCRIP
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
		public Nullable<Int32> HORAS
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
		public Nullable<Int32> VENCIMIENTO
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
		public String AREA
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
		public String PROCESO
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
		public String VENCE
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
		public String FECHAMOD
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
		public String HORAMOD
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
		public String GRABO
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
		public Nullable<Int32> ID_DOC_FEC
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
		public String DIVISION
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
		public String CAMPOFEC
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
		/// <summary>
		/// Gets or sets el valor de: OBLIGATORIO.
		/// </summary>
		public String OBLIGATORIO
		{
			get { return m_obligatorio; }
			set
			{
				if (m_obligatorio != value)
				{
					m_obligatorio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_AREA.
		/// </summary>
		public Nullable<Int32> ID_AREA
		{
			get { return m_id_area; }
			set
			{
				if (m_id_area != value)
				{
					m_id_area = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PORCENTAJE.
		/// </summary>
		public Nullable<Int32> PORCENTAJE
		{
			get { return m_porcentaje; }
			set
			{
				if (m_porcentaje != value)
				{
					m_porcentaje = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_CLASIFIACION.
		/// </summary>
		public Nullable<Int32> ID_CLASIFIACION
		{
			get { return m_id_clasifiacion; }
			set
			{
				if (m_id_clasifiacion != value)
				{
					m_id_clasifiacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_AMBITO.
		/// </summary>
		public Nullable<Int32> ID_AMBITO
		{
			get { return m_id_ambito; }
			set
			{
				if (m_id_ambito != value)
				{
					m_id_ambito = value;
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
