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
	public partial class Colab_Usuario 
	{
		#region [ Variables ]
		private String m_idempresa;
		private String m_rut;
		private String m_clave;
		private String m_correo_electronico;
		private String m_tipousuario;
		private String m_activo;
		private String m_envioalertas;
		private Nullable<DateTime> m_fecha_creacion;
		private Nullable<DateTime> m_fecha_modificacion;
		private Nullable<DateTime> m_ultimo_acceso;
		private String m_fechavence;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Colab_Usuario.
		/// </summary>
		public Colab_Usuario()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: IdEmpresa.
		/// </summary>
		public String IdEmpresa
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
		/// Gets or sets el valor de: Rut.
		/// </summary>
		public String Rut
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
		/// Gets or sets el valor de: Clave.
		/// </summary>
		public String Clave
		{
			get { return m_clave; }
			set
			{
				if (m_clave != value)
				{
					m_clave = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: Correo_Electronico.
		/// </summary>
		public String Correo_Electronico
		{
			get { return m_correo_electronico; }
			set
			{
				if (m_correo_electronico != value)
				{
					m_correo_electronico = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TipoUsuario.
		/// </summary>
		public String TipoUsuario
		{
			get { return m_tipousuario; }
			set
			{
				if (m_tipousuario != value)
				{
					m_tipousuario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: Activo.
		/// </summary>
		public String Activo
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
		/// Gets or sets el valor de: EnvioAlertas.
		/// </summary>
		public String EnvioAlertas
		{
			get { return m_envioalertas; }
			set
			{
				if (m_envioalertas != value)
				{
					m_envioalertas = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: Fecha_Creacion.
		/// </summary>
		public Nullable<DateTime> Fecha_Creacion
		{
			get { return m_fecha_creacion; }
			set
			{
				if (m_fecha_creacion != value)
				{
					m_fecha_creacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: Fecha_Modificacion.
		/// </summary>
		public Nullable<DateTime> Fecha_Modificacion
		{
			get { return m_fecha_modificacion; }
			set
			{
				if (m_fecha_modificacion != value)
				{
					m_fecha_modificacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: Ultimo_Acceso.
		/// </summary>
		public Nullable<DateTime> Ultimo_Acceso
		{
			get { return m_ultimo_acceso; }
			set
			{
				if (m_ultimo_acceso != value)
				{
					m_ultimo_acceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FechaVence.
		/// </summary>
		public String FechaVence
		{
			get { return m_fechavence; }
			set
			{
				if (m_fechavence != value)
				{
					m_fechavence = value;
				}
			}
		}
		#endregion

		#region [ Instance Entity ]
		public InstanceEntity m_instance;
		
		public InstanceEntity Instance
		{
			get { return m_instance; }
			set { m_instance = value; }
		}
		
		#endregion


	}
}
