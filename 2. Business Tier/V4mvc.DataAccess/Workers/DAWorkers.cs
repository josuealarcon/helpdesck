using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAWorkers : IDAWorkers
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Workers> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAWorkers(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<Workers>();
			Workers item = new Workers();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Workers> GetAll()
		{
			try
			{
				ObservableCollection<Workers> items = new ObservableCollection<Workers>();
				Workers item = new Workers();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Workers();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Workers GetOne(String RUT)
		{
			try
			{
				Workers item = new Workers();
				Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);

						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ return null; }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Workers Getworkersctta(String RUT, string EMPRESA)
		{
			try
			{
				Workers item = new Workers();
				Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_FINIQUITO_CTTA");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);

						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ return null; }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
		#endregion

		#region [ Metodos ]
		public bool Save(ref Workers item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@NOMBRES", item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@APELLIDOS", item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHNACIM", item.FECHNACIM, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CASTIGO", item.CASTIGO, SqlDbType.NVarChar, 3, ParameterDirection.Input);
						Instance.DAAgregarParametro("@POLICLIN", item.POLICLIN, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHARLA", item.FECHARLA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CONTRATO", item.CONTRATO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CEDULA", item.CEDULA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EXPREOCUP", item.EXPREOCUP, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CERTANTEC", item.CERTANTEC, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECEXPIREX", item.FECEXPIREX, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LICCONDUC", item.LICCONDUC, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECEXPIRALIC", item.FECEXPIRALIC, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CLASE", item.CLASE, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PARTES", item.PARTES, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ROL", item.ROL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@STAFF", item.STAFF, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PIEZA", item.PIEZA, SqlDbType.SmallInt, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AUTOR", item.AUTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CCOSTO", item.CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AUTCASINO", item.AUTCASINO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRUPO", item.GRUPO, SqlDbType.SmallInt, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ZONA", item.ZONA, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CLAVE", item.CLAVE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AUTORVISITA", item.AUTORVISITA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CASINODES", item.CASINODES, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CASINOALM", item.CASINOALM, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CASINOCEN", item.CASINOCEN, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CASINOCEN2", item.CASINOCEN2, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CASINOOTR", item.CASINOOTR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CASINOPERM1", item.CASINOPERM1, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPOPASE", item.TIPOPASE, SqlDbType.NVarChar, 9, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TURNO", item.TURNO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRUPOTURN", item.GRUPOTURN, SqlDbType.NVarChar, 9, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHABLOQUEO", item.FECHABLOQUEO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SEXO", item.SEXO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FINIPASE", item.FINIPASE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FFINPASE", item.FFINPASE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECEXPLICINT", item.FECEXPLICINT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@COOL", item.COOL, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMAIL", item.EMAIL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DEFECHA", item.DEFECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VIP", item.VIP, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CARGO", item.CARGO, SqlDbType.NVarChar, 3, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOC_DAS", item.DOC_DAS, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOC_REGINT", item.DOC_REGINT, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOC_PSICOTEC", item.DOC_PSICOTEC, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPOVEHIC", item.TIPOVEHIC, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SICOFECHA", item.SICOFECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CONTRATOFEC", item.CONTRATOFEC, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CONTRATOTIP", item.CONTRATOTIP, SqlDbType.NVarChar, 15, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOC_HVIDA", item.DOC_HVIDA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NACIONALIDAD", item.NACIONALIDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LOTE", item.LOTE, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FINGRESO", item.FINGRESO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FINIQUITO", item.FINIQUITO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MOTIVO", item.MOTIVO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOC_FINIQUITO", item.DOC_FINIQUITO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOC_FOTO", item.DOC_FOTO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AUTOR_EXT", item.AUTOR_EXT, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECMEDICO", item.FECMEDICO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OKMEDICO", item.OKMEDICO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOC_MANEJO", item.DOC_MANEJO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FEC_DAS", item.FEC_DAS, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@QUIEN", item.QUIEN, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FINIQUITO2", item.FINIQUITO2, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOC_FINIQUITO2", item.DOC_FINIQUITO2, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ALTURAEX", item.ALTURAEX, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_AREA", item.ID_AREA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GSANGRE", item.GSANGRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AUT_COND_MAND", item.AUT_COND_MAND, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TDOC", item.TDOC, SqlDbType.NVarChar, 3, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDGERENCIA", item.IDGERENCIA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDUNIDAD", item.IDUNIDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FUNCION", item.FUNCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SAP", item.SAP, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FISCALIZADO", item.FISCALIZADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@UBIGEO", item.UBIGEO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CODCONSTCIVIL", item.CODCONSTCIVIL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RESIDENTE", item.RESIDENTE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CALIFICADO", item.CALIFICADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MANOOBRALOCAL", item.MANOOBRALOCAL, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GINSTRUCCION", item.GINSTRUCCION, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@COD_HABILITACION", item.COD_HABILITACION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ROL_AAQ", item.ROL_AAQ, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SALARIO", item.SALARIO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECINICASINO", item.FECINICASINO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECFINCASINO", item.FECFINCASINO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LOCAL_TRABAJO_AAQ", item.LOCAL_TRABAJO_AAQ, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDSYNC", item.IDSYNC, SqlDbType.BigInt, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RESTCREDENCIAL", item.RESTCREDENCIAL, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OBSCREDENCIAL", item.OBSCREDENCIAL, SqlDbType.NVarChar, 100, ParameterDirection.Input);
					}
					
					
					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
