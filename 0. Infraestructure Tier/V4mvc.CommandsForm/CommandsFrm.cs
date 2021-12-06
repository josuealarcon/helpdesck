using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using V4mvc.Commands;

namespace V4mvc.CommandsForm
{
    public partial class CommandsFrm : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public CommandsFrm()
        {
            InitializeComponent();
        }

        private void SetEnable(Control[] controls, bool value)
        {
            for(int i = 0; i < controls.Length; ++i)
            {
                controls[i].Enabled = value;
            }
        }
        private void tab0_btnBrowseFolder_Click(object sender, EventArgs e)
        {
            this.tab0_folderBrowseDlg.ShowDialog();
            string selected_path = this.tab0_folderBrowseDlg.SelectedPath;
            if (!string.IsNullOrEmpty(selected_path))
            {
                this.tab0_txtOutputFolder.Text = selected_path;
            }
        }

        private void restartSaveSpFilesValidation()
        {
            this.tab0_elblOutputFolder.ForeColor = SystemColors.ControlText;
            this.tab0_elblRangoInicio.ForeColor = SystemColors.ControlText;
            this.tab0_elblRangoFin.ForeColor = SystemColors.ControlText;
        }

        private bool doSaveSpFilesValidation()
        {
            restartSaveSpFilesValidation();
            if (string.IsNullOrEmpty(this.tab0_txtOutputFolder.Text))
            {
                this.tab0_elblOutputFolder.ForeColor = Color.Red;
                return false;
            }
            if (this.tab0_ckbExtraOptions.Checked)
            {
                if (this.tab0_dpRangoInicio.Value.CompareTo(this.tab0_dpRangoFin.Value) > 0)
                {
                    this.tab0_elblRangoInicio.ForeColor = Color.Red;
                    this.tab0_elblRangoFin.ForeColor = Color.Red;

                    MessageBox.Show("La Fecha Inicio del Rango debe ser menor o igual al la Fecha Fin");

                    return false;
                }
            }
            return true;
        }

        private async void tab0_btnStart_Click(object sender, EventArgs e)
        {
            var ctls = new Control[]{
                this.tab0_btnBrowseFolder,
                this.tab0_btnResetFrm,
                this.tab0_btnStart
            };

            string output_folder = String.Empty;
            V4mvc.Commands.Classes.Utils.FilterSpObject filter = null;

            if (!doSaveSpFilesValidation())
            {
                return;
            }

            output_folder = this.tab0_txtOutputFolder.Text;

            if (this.tab0_ckbExtraOptions.Checked)
            {
                filter = new Commands.Classes.Utils.FilterSpObject { 
                    start = this.tab0_dpRangoInicio.Value,
                    end = this.tab0_dpRangoFin.Value
                };                
            }

            SetEnable(ctls, false);

            lb_CommandOutput.Items.Clear();
            lb_CommandOutput.Items.Add("La Operacion de Generacion de Stored Procedures empezo ...");
            pib_CommandProgress.Visible = true;

            stopwatch.Restart();


            bool result = await Task.Factory.StartNew(
                () => V4mvc.CommandsForm.Classes.SecondThreadConcern.SaveStoredProcedureFiles(output_folder, filter),
                TaskCreationOptions.LongRunning
            );

            stopwatch.Stop();
            pib_CommandProgress.Visible = false;

            if (result)
            {
                lb_CommandOutput.Items.Add("La Operacion de Generacion de Stored Procedures fue exitosa");
            }
            else
            {
                lb_CommandOutput.Items.Add("La Operacion de Generacion de Stored Procedures fallo");
            }
            lb_CommandOutput.Items.Add(string.Format("La Operacion duro: {0}", CommandsForm.Classes.Utils.GetNearestUnitTime(stopwatch.ElapsedMilliseconds)));

            SetEnable(ctls, true);
        }

        private void tab0_btnResetFrm_Click(object sender, EventArgs e)
        {
            restartSaveSpFilesValidation();
            this.tab0_txtOutputFolder.Text = string.Empty;
            
            //Extra Options

            this.tab0_dpRangoInicio.Value = DateTime.Now;
            this.tab0_dpRangoFin.Value = DateTime.Now;

            this.tab0_ckbExtraOptions.Checked = false;
            this.tab0_dpRangoInicio.Enabled = false;
            this.tab0_dpRangoFin.Enabled = false;

            this.tab0_elblRangoInicio.ForeColor = SystemColors.ControlText;
            this.tab0_elblRangoFin.ForeColor = SystemColors.ControlText;
        }

        private void tab1_btnBrowseFolder_Click(object sender, EventArgs e)
        {
            this.tab1_folderBrowseDlg.ShowDialog();
            string selected_path = this.tab1_folderBrowseDlg.SelectedPath;
            if (!string.IsNullOrEmpty(selected_path))
            {
                this.tab1_txtOutputFolder.Text = selected_path;

            }
        }

        private void restartGenerateTiersValidation()
        {
            this.tab1_elblOutputFolder.ForeColor = SystemColors.ControlText;
            this.tab1_elblTableName.ForeColor = SystemColors.ControlText;
            this.tab1_elblEntityName.ForeColor = SystemColors.ControlText;
            this.tab1_elblEntitySingular.ForeColor = SystemColors.ControlText;
            this.tab1_elblEntityPlural.ForeColor = SystemColors.ControlText;
            this.tab1_elblOptionsGroup.ForeColor = SystemColors.ControlText;
        }

        private bool doGenerateTiersValidation()
        {
            var checkboxes = new CheckBox[]
            {
                this.tab1_ckbEntityTier,
                this.tab1_ckbDataAccessTier,
                this.tab1_ckbBusinessLogicTier,
                this.tab1_ckbServiceTier,
                this.tab1_ckbUnityFile,
                this.tab1_ckbStoredProcedures
            };
            restartGenerateTiersValidation();
            if (string.IsNullOrEmpty(this.tab1_txtOutputFolder.Text)) {
                this.tab1_elblOutputFolder.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(this.tab1_txtTableName.Text))
            {
                this.tab1_elblTableName.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(this.tab1_txtEntityName.Text))
            {
                this.tab1_elblEntityName.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(this.tab1_txtEntitySingular.Text))
            {
                this.tab1_elblEntitySingular.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(this.tab1_txtEntityPlural.Text))
            {
                this.tab1_elblEntityPlural.ForeColor = Color.Red;
                return false;
            }
            if (checkboxes.Where(x => x.Checked).Count() < 1)
            {
                this.tab1_elblOptionsGroup.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private async void tab1_btnStart_Click(object sender, EventArgs e)
        {
            var ctls = new Control[]
            {
                this.tab1_btnBrowseFolder,
                this.tab1_btnResetFrm,
                this.tab1_btnStart,
                this.tab1_btnValidateTableName
            };

            string db_table = String.Empty;
            string entity_name = String.Empty;
            string plural_name = String.Empty;
            string singular_name = String.Empty;
            string output_folder = String.Empty;
            bool gen_entity_tier = false;
            bool gen_dataccess_tier = false;
            bool gen_blogic_tier = false;
            bool gen_service_tier = false;
            bool gen_uconfig_file = false;
            bool gen_stored_procs = false;

            if (!doGenerateTiersValidation())
            {
                return;
            }

            db_table = this.tab1_txtTableName.Text;
            entity_name = this.tab1_txtEntityName.Text;
            plural_name = this.tab1_txtEntityPlural.Text;
            singular_name = this.tab1_txtEntitySingular.Text;
            output_folder = this.tab1_txtOutputFolder.Text;
            gen_entity_tier = this.tab1_ckbEntityTier.Checked;
            gen_dataccess_tier = this.tab1_ckbDataAccessTier.Checked;
            gen_blogic_tier = this.tab1_ckbBusinessLogicTier.Checked;
            gen_service_tier = this.tab1_ckbServiceTier.Checked;
            gen_uconfig_file = this.tab1_ckbUnityFile.Checked;
            gen_stored_procs = this.tab1_ckbStoredProcedures.Checked;

            SetEnable(ctls, false);

            lb_CommandOutput.Items.Clear();
            lb_CommandOutput.Items.Add("La Operacion de Generacion de Capas empezo ...");
            pib_CommandProgress.Visible = true;

            stopwatch.Restart();

            bool result = await Task.Factory.StartNew(
                () => V4mvc.CommandsForm.Classes.SecondThreadConcern.GenerateTiers(
                        db_table,
                        entity_name,
                        plural_name,
                        singular_name,
                        output_folder,
                        gen_entity_tier,
                        gen_dataccess_tier,
                        gen_blogic_tier,
                        gen_service_tier,
                        gen_uconfig_file,
                        gen_stored_procs
                ),
                TaskCreationOptions.LongRunning
            );

            stopwatch.Stop();
            pib_CommandProgress.Visible = false;

            if (result)
            {
                lb_CommandOutput.Items.Add("La Operacion de Generacion de Capas fue exitosa");
            }
            else
            {
                lb_CommandOutput.Items.Add("La Operacion de Generacion de Capas fallo");
            }
            lb_CommandOutput.Items.Add(string.Format("La Operacion duro: {0}", CommandsForm.Classes.Utils.GetNearestUnitTime(stopwatch.ElapsedMilliseconds)));

            SetEnable(ctls, true);

        }



        private async void tab1_btnValidateTableName_Click(object sender, EventArgs e)
        {
            string table_name = this.tab1_txtTableName.Text;
            if (!string.IsNullOrEmpty(table_name))
            {
                var ctls = new Control[]
                {
                    this.tab1_btnBrowseFolder,
                    this.tab1_btnResetFrm,
                    this.tab1_btnStart,
                    this.tab1_btnValidateTableName
                };

                SetEnable(ctls, false);

                int err_type = -1;
                bool result = await Task.Factory.StartNew(
                    () => V4mvc.CommandsForm.Classes.SecondThreadConcern.ValidateTableNameFunc(
                            table_name, out err_type
                    ),
                    TaskCreationOptions.LongRunning
                );
                if (result)
                {
                    string entity_name = Classes.SecondThreadConcern.GetSuggestedEntityName(table_name);
                    string singular = Classes.SecondThreadConcern.GetSuggestedSingularName(entity_name);
                    string plural = Classes.SecondThreadConcern.GetSuggestedPluralName(entity_name);

                    this.tab1_txtEntityName.Text = entity_name;
                    this.tab1_txtEntitySingular.Text = singular;
                    this.tab1_txtEntityPlural.Text = plural;

                    this.tab1_txtEntityName.Enabled = true;
                    this.tab1_txtEntitySingular.Enabled = true;
                    this.tab1_txtEntityPlural.Enabled = true;

                }
                else if (!result && err_type == 0)
                {
                    System.Windows.Forms.MessageBox.Show("El Campo Nombre de Tabla existe en la Base de Datos pero es UNA VISTA");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("El Campo Nombre de Tabla no existe en la Base de Datos");
                }
                
                SetEnable(ctls, true);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El Campo Nombre de Tabla esta vacio");
            }
            

        }

        private void tab1_btnResetFrm_Click(object sender, EventArgs e)
        {
            var checkboxes = new CheckBox[]
            {
                this.tab1_ckbEntityTier,
                this.tab1_ckbDataAccessTier,
                this.tab1_ckbBusinessLogicTier,
                this.tab1_ckbServiceTier,
                this.tab1_ckbUnityFile,
                this.tab1_ckbStoredProcedures
            };

            for(int i = 0; i < checkboxes.Length; ++i)
            {
                checkboxes[i].Checked = true;
            }

            restartGenerateTiersValidation();

            this.tab1_txtOutputFolder.Text = string.Empty;

            this.tab1_txtTableName.Text = string.Empty;

            this.tab1_txtEntityName.Text = string.Empty;
            this.tab1_txtEntityName.Enabled = false;

            this.tab1_txtEntitySingular.Text = string.Empty;
            this.tab1_txtEntitySingular.Enabled = false;

            this.tab1_txtEntityPlural.Text = string.Empty;
            this.tab1_txtEntityPlural.Enabled = false;

        }

        private void CommandsFrm_Load(object sender, EventArgs e)
        {


        }

        private void tab0_ckbExtraOptions_CheckedChanged(object sender, EventArgs e)
        {
            this.tab0_dpRangoInicio.Value = DateTime.Now;
            this.tab0_dpRangoFin.Value = DateTime.Now;

            this.tab0_elblRangoInicio.ForeColor = SystemColors.ControlText;
            this.tab0_elblRangoFin.ForeColor = SystemColors.ControlText;

            if (this.tab0_ckbExtraOptions.Checked)
            {
                this.tab0_dpRangoInicio.Enabled = true;
                this.tab0_dpRangoFin.Enabled = true;
            }
            else
            {
                this.tab0_dpRangoInicio.Enabled = false;
                this.tab0_dpRangoFin.Enabled = false;
            }
        }
    }
}
