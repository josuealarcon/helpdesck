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
	public partial class Direccion 
	{
		#region [ Variables ]
		private String m_rut;
		private String m_direccion;
		private String m_zona;
		private String m_comuna;
		private String m_ciudad;
		private String m_region;
		private String m_pais;
		private String m_fonohelp;
		private String m_fono;
		private String m_celular;
		private String m_email;
		private String m_fechamod;
		private String m_horamod;
		private String m_grabo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Direccion.
		/// </summary>
		public Direccion()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// Gets or sets el valor de: ZONA.
		/// </summary>
		public String ZONA
		{
			get { return m_zona; }
			set
			{
				if (m_zona != value)
				{
					m_zona = value;
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
		/// Gets or sets el valor de: FONOHELP.
		/// </summary>
		public String FONOHELP
		{
			get { return m_fonohelp; }
			set
			{
				if (m_fonohelp != value)
				{
					m_fonohelp = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FONO.
		/// </summary>
		public String FONO
		{
			get { return m_fono; }
			set
			{
				if (m_fono != value)
				{
					m_fono = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CELULAR.
		/// </summary>
		public String CELULAR
		{
			get { return m_celular; }
			set
			{
				if (m_celular != value)
				{
					m_celular = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMAIL.
		/// </summary>
		public String EMAIL
		{
			get { return m_email; }
			set
			{
				if (m_email != value)
				{
					m_email = value;
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
