using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Docs_Ost
	{
		#region [ Variables ]

		private string m_ost;
		private string m_empresa;
		private string m_madre;
		private Int16 m_nivel;
		private byte[] m_archivo;
		private string m_nombre_archivo;
		private string m_tipo_contenido;
		private string m_usuario;
		private string m_fechamod;
		private string m_horamod;
		private string m_division;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Ost.
		/// </summary>
		public Docs_Ost()
		{ }

		#endregion

		#region [ Propiedades ]

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
		/// Gets or sets el valor de: MADRE.
		/// </summary>
		public string MADRE
		{
			get { return m_madre; }
			set
			{
				if (m_madre != value)
				{
					m_madre = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NIVEL.
		/// </summary>
		public Int16 NIVEL
		{
			get { return m_nivel; }
			set
			{
				if (m_nivel != value)
				{
					m_nivel = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ARCHIVO.
		/// </summary>
		public byte[] ARCHIVO
		{
			get { return m_archivo; }
			set
			{
				if (m_archivo != value)
				{
					m_archivo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRE_ARCHIVO.
		/// </summary>
		public string NOMBRE_ARCHIVO
		{
			get { return m_nombre_archivo; }
			set
			{
				if (m_nombre_archivo != value)
				{
					m_nombre_archivo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CONTENIDO.
		/// </summary>
		public string TIPO_CONTENIDO
		{
			get { return m_tipo_contenido; }
			set
			{
				if (m_tipo_contenido != value)
				{
					m_tipo_contenido = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIO.
		/// </summary>
		public string USUARIO
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
