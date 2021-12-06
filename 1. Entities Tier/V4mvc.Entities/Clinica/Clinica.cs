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
	public partial class Clinica
	{
		#region [ Variables ]
		private String m_ruc;
		private Nullable<Int32> m_capacidad;
		private String m_nombre;
		private String m_telefono;
		private String m_pais;
		private String m_region;
		private String m_ciudad;
		private String m_comuna;
		private String m_direccion;
		private String m_atencionini;
		private String m_atencionfin;
		private String m_fecha;
		private String m_hora;
		private String m_fechamod;
		private String m_horamod;
		private String m_usuario;
		private String m_usuariomod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Clinica.
		/// </summary>
		public Clinica()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: RUC.
		/// </summary>
		public String RUC
		{
			get { return m_ruc; }
			set
			{
				if (m_ruc != value)
				{
					m_ruc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CAPACIDAD.
		/// </summary>
		public Nullable<Int32> CAPACIDAD
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
		/// Gets or sets el valor de: NOMBRE.
		/// </summary>
		public String NOMBRE
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
		/// Gets or sets el valor de: TELEFONO.
		/// </summary>
		public String TELEFONO
		{
			get { return m_telefono; }
			set
			{
				if (m_telefono != value)
				{
					m_telefono = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PAIS.
		/// </summary>
		public String PAIS
		{
			get { return m_pais; }
			set
			{
				if (m_pais != value)
				{
					m_pais = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REGION.
		/// </summary>
		public String REGION
		{
			get { return m_region; }
			set
			{
				if (m_region != value)
				{
					m_region = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CIUDAD.
		/// </summary>
		public String CIUDAD
		{
			get { return m_ciudad; }
			set
			{
				if (m_ciudad != value)
				{
					m_ciudad = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMUNA.
		/// </summary>
		public String COMUNA
		{
			get { return m_comuna; }
			set
			{
				if (m_comuna != value)
				{
					m_comuna = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIRECCION.
		/// </summary>
		public String DIRECCION
		{
			get { return m_direccion; }
			set
			{
				if (m_direccion != value)
				{
					m_direccion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ATENCIONINI.
		/// </summary>
		public String ATENCIONINI
		{
			get { return m_atencionini; }
			set
			{
				if (m_atencionini != value)
				{
					m_atencionini = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ATENCIONFIN.
		/// </summary>
		public String ATENCIONFIN
		{
			get { return m_atencionfin; }
			set
			{
				if (m_atencionfin != value)
				{
					m_atencionfin = value;
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
		/// Gets or sets el valor de: USUARIO.
		/// </summary>
		public String USUARIO
		{
			get { return m_usuario; }
			set
			{
				if (m_usuario != value)
				{
					m_usuario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIOMOD.
		/// </summary>
		public String USUARIOMOD
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
