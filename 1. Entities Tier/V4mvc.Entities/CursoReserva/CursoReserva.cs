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
	public partial class CursoReserva
	{
		#region [ Variables ]
		private Int32 m_codigo;
		private String m_rut;
		private String m_empresa;
		private String m_fechares;
		private String m_horares;
		private String m_whomake;
		private String m_asistio;
		private String m_aprobo;
		private String m_obs;
		private String m_orador;
		private Nullable<Int32> m_nota;
		private String m_fecharesp;
		private String m_horaresp;
		private Nullable<Int32> m_area;
		private Nullable<Int32> m_rollab;
		private String m_turno;
		private String m_localtrabajo;
		private Nullable<Int32> m_notaqv;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CursoReserva.
		/// </summary>
		public CursoReserva()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CODIGO.
		/// </summary>
		public Int32 CODIGO
		{
			get { return m_codigo; }
			set
			{
				if (m_codigo != value)
				{
					m_codigo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RUT.
		/// </summary>
		public String RUT
		{
			get { return m_rut; }
			set
			{
				if (m_rut != value)
				{
					m_rut = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPRESA.
		/// </summary>
		public String EMPRESA
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
		/// Gets or sets el valor de: FECHARES.
		/// </summary>
		public String FECHARES
		{
			get { return m_fechares; }
			set
			{
				if (m_fechares != value)
				{
					m_fechares = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORARES.
		/// </summary>
		public String HORARES
		{
			get { return m_horares; }
			set
			{
				if (m_horares != value)
				{
					m_horares = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: WHOMAKE.
		/// </summary>
		public String WHOMAKE
		{
			get { return m_whomake; }
			set
			{
				if (m_whomake != value)
				{
					m_whomake = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ASISTIO.
		/// </summary>
		public String ASISTIO
		{
			get { return m_asistio; }
			set
			{
				if (m_asistio != value)
				{
					m_asistio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: APROBO.
		/// </summary>
		public String APROBO
		{
			get { return m_aprobo; }
			set
			{
				if (m_aprobo != value)
				{
					m_aprobo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBS.
		/// </summary>
		public String OBS
		{
			get { return m_obs; }
			set
			{
				if (m_obs != value)
				{
					m_obs = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ORADOR.
		/// </summary>
		public String ORADOR
		{
			get { return m_orador; }
			set
			{
				if (m_orador != value)
				{
					m_orador = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOTA.
		/// </summary>
		public Nullable<Int32> NOTA
		{
			get { return m_nota; }
			set
			{
				if (m_nota != value)
				{
					m_nota = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHARESP.
		/// </summary>
		public String FECHARESP
		{
			get { return m_fecharesp; }
			set
			{
				if (m_fecharesp != value)
				{
					m_fecharesp = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORARESP.
		/// </summary>
		public String HORARESP
		{
			get { return m_horaresp; }
			set
			{
				if (m_horaresp != value)
				{
					m_horaresp = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AREA.
		/// </summary>
		public Nullable<Int32> AREA
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
		/// Gets or sets el valor de: ROLLAB.
		/// </summary>
		public Nullable<Int32> ROLLAB
		{
			get { return m_rollab; }
			set
			{
				if (m_rollab != value)
				{
					m_rollab = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TURNO.
		/// </summary>
		public String TURNO
		{
			get { return m_turno; }
			set
			{
				if (m_turno != value)
				{
					m_turno = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOCALTRABAJO.
		/// </summary>
		public String LOCALTRABAJO
		{
			get { return m_localtrabajo; }
			set
			{
				if (m_localtrabajo != value)
				{
					m_localtrabajo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOTAQV.
		/// </summary>
		public Nullable<Int32> NOTAQV
		{
			get { return m_notaqv; }
			set
			{
				if (m_notaqv != value)
				{
					m_notaqv = value;
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
