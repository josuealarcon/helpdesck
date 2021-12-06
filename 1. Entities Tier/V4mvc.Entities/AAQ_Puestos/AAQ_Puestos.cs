using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class AAQ_Puestos
	{
		#region [ Variables ]

		private Int32 m_idpuesto;
		private Int32 m_idcategoria;
		private string m_nombre;
		private string m_descripcion;
		private string m_activo;
		private string m_categorianom;
		private string m_clasificacionnom;
		private string m_identificador;
		private string m_habilitacion;

		#endregion

		#region [ Constructores ]
		public AAQ_Puestos()
		{ }

		#endregion

		#region [ Propiedades ]

		public Int32 IDPUESTO
		{
			get { return m_idpuesto; }
			set
			{
				if (m_idpuesto != value)
				{
					m_idpuesto = value;
				}
			}
		}

		public Int32 IDCATEGORIA
		{
			get { return m_idcategoria; }
			set
			{
				if (m_idcategoria != value)
				{
					m_idcategoria = value;
				}
			}
		}

		public string NOMBRE
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

		public string DESCRIPCION
		{
			get { return m_descripcion; }
			set
			{
				if (m_descripcion != value)
				{
					m_descripcion = value;
				}
			}
		}

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

		public string IDENTIFICADOR
		{
			get { return m_identificador; }
			set
			{
				if (m_identificador != value)
				{
					m_identificador = value;
				}
			}
		}

		public string HABILITACION
		{
			get { return m_habilitacion; }
			set
			{
				if (m_habilitacion != value)
				{
					m_habilitacion = value;
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

		public string CATEGORIANOM
		{
			get { return m_categorianom; }
			set
			{
				if (m_categorianom != value)
				{
					m_categorianom = value;
				}
			}
		}

		public string CLASIFICACIONNOM
		{
			get { return m_clasificacionnom; }
			set
			{
				if (m_clasificacionnom != value)
				{
					m_clasificacionnom = value;
				}
			}
		}


		#endregion
	}
}

