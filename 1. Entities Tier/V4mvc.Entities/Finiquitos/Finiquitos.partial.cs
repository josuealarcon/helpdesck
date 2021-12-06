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
	public partial class Finiquitos
	{
        public Workers worker_documentacion { get; set; }
        public ObservableCollection<Docs_Fec> finiquitos_fechas { get; set; }
        public ObservableCollection<Divisiones> divisiones { get; set; }
        public ObservableCollection<A054_MotivoFiniquito> finiquitos_motivos { get; set; }
        public ObservableCollection<Docs_Workers> docs_worker { get; set; }
        public string observacion { get; set; }

        public string recordatorio { get; set; }

        public string ARCHIVO_ADJUNTO { get; set; }

        public int MAX_FILESIZE_MB { get; set; } = 5;
        public int MAX_FILES { get; set; } = 1;
        public bool ALLOW_MULTIPLE_FILES { get; set; } = false;
        public int MAX_FILENAME_LENGTH { get; set; } = 50;

        public string BASE_ALLOWED_EXTENSIONS { get; set; } = ".pdf";
        public string ALLOWED_EXTENSIONS
        {
            get
            {
                return Utils.generateAllExtensions(this.BASE_ALLOWED_EXTENSIONS);
            }
        }

    }
}
