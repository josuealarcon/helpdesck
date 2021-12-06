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
	public partial class CursoProg 
	{
		#region [ Variables ]
		private Int32 m_codigo;
		private Nullable<Int32> m_curso;
		private String m_fecha;
		private String m_hora;
		private String m_lugar;
		private String m_sala;
		private String m_activo;
		private String m_realizado;
		private String m_porquien;
		private String m_cuando;
		private String m_aqhoras;
		private String m_orador;
		private String m_finalizado;
		private String m_observacion;
		private Nullable<Int32> m_notaorador;
		private Nullable<Int32> m_tipocurso;
		private Nullable<Int32> m_duracion;
		private Nullable<Int32> m_areatematica;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CursoProg.
		/// </summary>
		public CursoProg()
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
		/// Gets or sets el valor de: CURSO.
		/// </summary>
		public Nullable<Int32> CURSO
		{
			get { return m_curso; }
			set
			{
				if (m_curso != value)
				{
					m_curso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA.
		/// </summary>
		public String FECHA
		{
			get { return m_fecha; }
			set
			{
				if (m_fecha != value)
				{
					m_fecha = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORA.
		/// </summary>
		public String HORA
		{
			get { return m_hora; }
			set
			{
				if (m_hora != value)
				{
					m_hora = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LUGAR.
		/// </summary>
		public String LUGAR
		{
			get { return m_lugar; }
			set
			{
				if (m_lugar != value)
				{
					m_lugar = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SALA.
		/// </summary>
		public String SALA
		{
			get { return m_sala; }
			set
			{
				if (m_sala != value)
				{
					m_sala = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACTIVO.
		/// </summary>
		public String ACTIVO
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
		/// Gets or sets el valor de: REALIZADO.
		/// </summary>
		public String REALIZADO
		{
			get { return m_realizado; }
			set
			{
				if (m_realizado != value)
				{
					m_realizado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PORQUIEN.
		/// </summary>
		public String PORQUIEN
		{
			get { return m_porquien; }
			set
			{
				if (m_porquien != value)
				{
					m_porquien = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUANDO.
		/// </summary>
		public String CUANDO
		{
			get { return m_cuando; }
			set
			{
				if (m_cuando != value)
				{
					m_cuando = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AQHORAS.
		/// </summary>
		public String AQHORAS
		{
			get { return m_aqhoras; }
			set
			{
				if (m_aqhoras != value)
				{
					m_aqhoras = value;
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
		/// Gets or sets el valor de: FINALIZADO.
		/// </summary>
		public String FINALIZADO
		{
			get { return m_finalizado; }
			set
			{
				if (m_finalizado != value)
				{
					m_finalizado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBSERVACION.
		/// </summary>
		public String OBSERVACION
		{
			get { return m_observacion; }
			set
			{
				if (m_observacion != value)
				{
					m_observacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOTAORADOR.
		/// </summary>
		public Nullable<Int32> NOTAORADOR
		{
			get { return m_notaorador; }
			set
			{
				if (m_notaorador != value)
				{
					m_notaorador = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOCURSO.
		/// </summary>
		public Nullable<Int32> TIPOCURSO
		{
			get { return m_tipocurso; }
			set
			{
				if (m_tipocurso != value)
				{
					m_tipocurso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DURACION.
		/// </summary>
		public Nullable<Int32> DURACION
		{
			get { return m_duracion; }
			set
			{
				if (m_duracion != value)
				{
					m_duracion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AREATEMATICA.
		/// </summary>
		public Nullable<Int32> AREATEMATICA
		{
			get { return m_areatematica; }
			set
			{
				if (m_areatematica != value)
				{
					m_areatematica = value;
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
