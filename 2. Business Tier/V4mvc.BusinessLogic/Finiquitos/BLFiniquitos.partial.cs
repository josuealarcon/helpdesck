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
	public partial class BLFiniquitos
	{

		#region [ Consultas ]


        public Finiquitos GetFiniquito_FuncionariosCtta(string RUT, string EMPRESA, int COMUN = 0)
        {
            try
            {
                Finiquitos finiquito = new Finiquitos();
                finiquito.worker_documentacion = WorkersRepository.Getworkersctta(RUT,EMPRESA);
                
                finiquito.finiquitos_fechas = DocFecsRepository.GetFechasFiniquito_FuncionariosCtta(RUT, EMPRESA);
                finiquito.divisiones = DivisionesRepository.GetAllA024Divisiones_FiniquitolCtta(RUT);
                finiquito.finiquitos_motivos = MotivFiniqRepo.GetMotivosFiniquito_FuncionariosCtta(RUT, EMPRESA);
                if(COMUN == 1)
                    finiquito.docs_worker = DocWorkersRepository.GetDocWorkersByRut_FuncionariosCtta(RUT,null, EMPRESA);
                else
                    finiquito.docs_worker = DocWorkersRepository.GetDocWorkersByRut_FuncionariosCtta(RUT,EMPRESA);

                return finiquito;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveFiniquito_FuncionariosCtta(Archivos archivo, string RUT, string IDEMPRESA, string USUARIO, Finiquitos finiquito)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    this.ArchivoRepository.Save(ref archivo);

                    if (finiquito.divisiones != null)
                    {
                        foreach (var division in finiquito.divisiones)
                        {
                            Docs_Workers docs_workers = new Docs_Workers();
                            docs_workers.RUT = RUT;
                            docs_workers.EMPRESA = IDEMPRESA;
                            docs_workers.DIVISION = division.DIVCOD;
                            docs_workers.USUARIO = USUARIO;
                            docs_workers.ID = archivo.ID;
                            docs_workers.Instance = InstanceEntity.New;
                            this.DocWorkersRepository.SaveDocWorkersDefaults_FuncionariosCtta(ref docs_workers);
                            if (finiquito.finiquitos_fechas != null)
                            {
                                foreach (var fec in finiquito.finiquitos_fechas)
                                {
                                    DFWorkersRepo.setFechaWLocal(RUT, fec.ID_DOC_FEC, division.DIVCOD, IDEMPRESA, Utils.ConvertDatetimeToDB(fec.FECHA), USUARIO);
                                    WorkersRepository.setWorkersDatos(RUT, IDEMPRESA, fec.FECHA, USUARIO, division.DIVCOD, archivo.ID, finiquito.observacion);
                                }
                            }
                        }
                    }

                    if (finiquito.finiquitos_motivos != null)
                    {
                        foreach (var fmotivo in finiquito.finiquitos_motivos)
                        {
                            Workers_MotivoFiniquito wmf = new Workers_MotivoFiniquito();
                            wmf.RUT = RUT;
                            wmf.EMPRESA = IDEMPRESA;
                            wmf.IDARCHIVO = archivo.ID;
                            wmf.MOTIVO = fmotivo.MOTIVO;
                            wmf.USRMOD = USUARIO;
                            wmf.ID_DOC = 18;
                            wmf.Instance = InstanceEntity.New;
                            this.WMotivFiniqRepo.SaveWorkerMotivFiniq_FuncionariosCtta(ref wmf);

                        }
                    }
                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool AprobarFiniquitoQv_FuncionariosCtta(string RUT, string USUARIO, string EMPRESA, ref string parametros_mail) {
            try
            {
               return this.Repository.AprobarFiniquitoQv_FuncionariosCtta(RUT, USUARIO, EMPRESA, ref parametros_mail);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
