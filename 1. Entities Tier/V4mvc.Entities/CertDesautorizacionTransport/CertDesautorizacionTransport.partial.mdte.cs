using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

	public partial class CertDesautorizacionTransport
	{
		#region [ Variables ]

		#endregion

		#region [ Propiedades ]

		public string NOMBRE { get; set; }

        public string ARCHIVO_ADJUNTO { get; set; }

        public int MAX_FILESIZE_MB { get; set; } = 2;
        public int MAX_FILES { get; set; } = 1;
        public bool ALLOW_MULTIPLE_FILES { get; set; } = false;
        public int MAX_FILENAME_LENGTH { get; set; } = 45;

        public string BASE_ALLOWED_EXTENSIONS { get; set; }
        public string ALLOWED_EXTENSIONS
        {
            get
            {
                return Utils.generateAllExtensions(this.BASE_ALLOWED_EXTENSIONS);
            }
        }

        public Archivos archivo;

        #endregion
    }
}