using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLTurnos
	{

		#region [ Consultas ]
		public ObservableCollection<Turnos> GetTurnosByEmpOST_Ctta(string ID_EMPRESA, string OST)
        {
            try
            {
                return this.Repository.GetTurnosByEmpOST_Ctta(ID_EMPRESA, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Turnos> GetAllTurnosCtta(string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetAllTurnosCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Turnos> GetAllCalendarioTurnosCtta(int IDTURNO, string IDEMPRESA, string TURNO, string ANIO, string MES)
        {
            try
            {
                return this.Repository.GetAllCalendarioTurnosCtta(IDTURNO, IDEMPRESA, TURNO, ANIO, MES);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Turnos GetTurnoEdit_TurnosCtta(int IDTURNO)
        {
            try
            {
                return this.Repository.UpdateTurnoTurnosCtta(IDTURNO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveTurno_TurnosCtta(Turnos Item)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    var archivo = Item.CERTIFICADO;
                    if (archivo.ARCHIVO != null)
                    {
                        this.RepositoryArchivos.Save(ref archivo);
                        Item.ID = archivo.ID;
                    }                                
                    if (Item.ACCION == "EDI")
                    {
                        Item.Instance = InstanceEntity.Modify;
                        this.Repository.Save(ref Item);
                    }
                    else
                    {
                        var turno = Repository.GetTurnoPorTurnoOstTurnosCtta(Item);
                        if (turno == null)
                        {
                            Item.Instance = InstanceEntity.New;
                            this.Repository.Save(ref Item);
                        }
                        else {
                            Item.Instance = InstanceEntity.Modify;
                            this.Repository.UpdateTurnoPorTurnoOstTurnosCtta(Item);
                        }
                    }
                    tran.Complete();
                }

                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
