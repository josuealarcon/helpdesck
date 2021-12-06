using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDotacion_Servicios_Ost
	{

        #region [ Consultas ]

        public ObservableCollection<Dotacion_Servicios_Ost> GetAllServiciosOST_Mdte(string OST, string MANDANTE, string USUARIO)
        {
            try
            {
                return this.Repository.GetAllServiciosOST_Mdte(OST, MANDANTE, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }


        #endregion

        #region [ Metodos ]

        public bool SaveDotacionServiciosOST_Mdte(ref Dotacion_Servicios_Ost Item)
        {
            try
            {
                return this.Repository.SaveDotacionServiciosOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDotacionServiciosOST_Mdte(ObservableCollection<Dotacion_Servicios_Ost> Items)
        {
            try
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items.ElementAt(i);
                    this.Repository.SaveDotacionServiciosOST_Mdte(ref item);
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
