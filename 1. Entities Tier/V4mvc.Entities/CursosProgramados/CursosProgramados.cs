using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class CursosProgramados
	{
		#region [ Variables ]

		private Int32 m_codigo;
		private Int32? m_curso;
		private string m_fecha;
		private string m_hora;
		private string m_lugar;
		private string m_sala;
		private string m_activo;
		private string m_realizado;
		private string m_porquien;
		private string m_cuando;
		private string m_aqhoras;
		private string m_orador;
		private string m_finalizado;
		private string m_observacion;
		private Int32? m_notaorador;
		private string m_tipocurso;
		private Int32? m_duracion;
		private Int32? m_areatematica;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CursosProgramados.
		/// </summary>
		public CursosProgramados()
		{ }

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
		public Int32? CURSO
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
		public string FECHA
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
		public string HORA
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
		public string LUGAR
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
		public string SALA
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
		/// Gets or sets el valor de: REALIZADO.
		/// </summary>
		public string REALIZADO
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
		public string PORQUIEN
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
		public string CUANDO
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
		public string AQHORAS
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
		public string ORADOR
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
		public string FINALIZADO
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
		public string OBSERVACION
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
		public Int32? NOTAORADOR
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
		public string TIPOCURSO
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
		public Int32? DURACION
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
		public Int32? AREATEMATICA
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
