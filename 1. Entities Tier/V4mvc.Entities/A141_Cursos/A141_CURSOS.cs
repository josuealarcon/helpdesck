using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class A141_CURSOS
	{
		#region [ Variables ]

		private Int32 m_codigo;
		private Int32? m_curso;
		private string m_fecha;
		private string m_hora;
		private string m_lugar;
		private string m_sala;
		private string m_activo;
		private Int32? m_capacidad;
		private string m_ubicacion;
		private string m_activa;
		private string m_charla;
		private string m_descrip;
		private Int32? m_horas;
		private Int32? m_vencimiento;
		private Int32 m_cantidad;
		private string m_realizado;
		private string m_orador;
		private DateTime? m_horatermino;
		private string m_finalizado;
		private string m_observacion;
		private string m_obligatorio;
		private Int32? m_notaorador;
		private string m_division;
		private string m_tipocurso;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase A141Cursos.
		/// </summary>
		public A141_CURSOS()
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
		/// Gets or sets el valor de: CAPACIDAD.
		/// </summary>
		public Int32? CAPACIDAD
		{
			get { return m_capacidad; }
			set
			{
				if (m_capacidad != value)
				{
					m_capacidad = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: UBICACION.
		/// </summary>
		public string UBICACION
		{
			get { return m_ubicacion; }
			set
			{
				if (m_ubicacion != value)
				{
					m_ubicacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACTIVA.
		/// </summary>
		public string ACTIVA
		{
			get { return m_activa; }
			set
			{
				if (m_activa != value)
				{
					m_activa = value;
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
		/// Gets or sets el valor de: CANTIDAD.
		/// </summary>
		public Int32 CANTIDAD
		{
			get { return m_cantidad; }
			set
			{
				if (m_cantidad != value)
				{
					m_cantidad = value;
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
		/// Gets or sets el valor de: HORATERMINO.
		/// </summary>
		public DateTime? HORATERMINO
		{
			get { return m_horatermino; }
			set
			{
				if (m_horatermino != value)
				{
					m_horatermino = value;
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
		/// Gets or sets el valor de: OBLIGATORIO.
		/// </summary>
		public string OBLIGATORIO
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
