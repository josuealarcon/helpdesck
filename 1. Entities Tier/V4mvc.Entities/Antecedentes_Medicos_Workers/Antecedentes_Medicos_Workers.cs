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
	public partial class Antecedentes_Medicos_Workers 
	{
		#region [ Variables ]
		private String m_rut;
		private Nullable<Int32> m_codantecedente;
		private String m_comentario;
        private Boolean m_checked;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Antecedentes_Medicos_Workers.
		/// </summary>
		public Antecedentes_Medicos_Workers()
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
		/// Gets or sets el valor de: CODANTECEDENTE.
		/// </summary>
		public Nullable<Int32> CODANTECEDENTE
		{
			get { return m_codantecedente; }
			set
			{
				if (m_codantecedente != value)
				{
					m_codantecedente = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMENTARIO.
		/// </summary>
		public String COMENTARIO
		{
			get { return m_comentario; }
			set
			{
				if (m_comentario != value)
				{
					m_comentario = value;
				}
			}
		}

        /// <summary>
		/// Gets or sets el valor de: CHECKED.
		/// </summary>
		public Boolean CHECKED
        {
            get { return m_checked; }
            set
            {
                if (m_checked != value)
                {
                    m_checked = value;
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
