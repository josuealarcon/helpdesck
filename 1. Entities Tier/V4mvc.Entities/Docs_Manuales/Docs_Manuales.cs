using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Docs_Manuales
	{
		#region [ Variables ]

		private Int32 m_id_doc;
		private string m_division;
		private string m_categoria;
		private string m_tipo;
		private string m_nombre_archivo;
		private string m_fecha_mod;
		private string m_hora_mod;
		private string m_tipo_contenido;
		private byte[] m_archivo;
		private string m_grabo;
		private string m_usuario;
		private string m_descrip;
		
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Manuales.
		/// </summary>
		public Docs_Manuales()
		{ }

		#endregion

		#region [ Propiedades ]

		/// <summary>
		/// Gets or sets el valor de: ID_DOC.
		/// </summary>
		public Int32 ID_DOC
		{
			get { return m_id_doc; }
			set
			{
				if (m_id_doc != value)
				{
					m_id_doc = value;
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
		/// Gets or sets el valor de: CATEGORIA.
		/// </summary>
		public string CATEGORIA
		{
			get { return m_categoria; }
			set
			{
				if (m_categoria != value)
				{
					m_categoria = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO.
		/// </summary>
		public string TIPO
		{
			get { return m_tipo; }
			set
			{
				if (m_tipo != value)
				{
					m_tipo = value;
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
		/// Gets or sets el valor de: FECHA_MOD.
		/// </summary>
		public string FECHA_MOD
		{
			get { return m_fecha_mod; }
			set
			{
				if (m_fecha_mod != value)
				{
					m_fecha_mod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORA_MOD.
		/// </summary>
		public string HORA_MOD
		{
			get { return m_hora_mod; }
			set
			{
				if (m_hora_mod != value)
				{
					m_hora_mod = value;
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
