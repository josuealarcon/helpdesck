
namespace V4mvc.CommandsForm
{
    partial class CommandsFrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandsFrm));
            this.tbCtlCommands = new System.Windows.Forms.TabControl();
            this.tbPgSpsGen = new System.Windows.Forms.TabPage();
            this.tab0_btnResetFrm = new System.Windows.Forms.Button();
            this.tab0_elblOutputFolder = new System.Windows.Forms.Label();
            this.tab0_btnStart = new System.Windows.Forms.Button();
            this.tab0_btnBrowseFolder = new System.Windows.Forms.Button();
            this.tab0_txtOutputFolder = new System.Windows.Forms.TextBox();
            this.tab0_lblOutputFolder = new System.Windows.Forms.Label();
            this.tbPgTierGen = new System.Windows.Forms.TabPage();
            this.tab1_btnResetFrm = new System.Windows.Forms.Button();
            this.tab1_elblOptionsGroup = new System.Windows.Forms.Label();
            this.tab1_btnValidateTableName = new System.Windows.Forms.Button();
            this.tab1_elblEntityPlural = new System.Windows.Forms.Label();
            this.tab1_elblEntitySingular = new System.Windows.Forms.Label();
            this.tab1_elblEntityName = new System.Windows.Forms.Label();
            this.tab1_elblTableName = new System.Windows.Forms.Label();
            this.tab1_elblOutputFolder = new System.Windows.Forms.Label();
            this.tab1_gbOptions = new System.Windows.Forms.GroupBox();
            this.tab1_ckbUnityFile = new System.Windows.Forms.CheckBox();
            this.tab1_ckbStoredProcedures = new System.Windows.Forms.CheckBox();
            this.tab1_ckbServiceTier = new System.Windows.Forms.CheckBox();
            this.tab1_ckbBusinessLogicTier = new System.Windows.Forms.CheckBox();
            this.tab1_ckbDataAccessTier = new System.Windows.Forms.CheckBox();
            this.tab1_ckbEntityTier = new System.Windows.Forms.CheckBox();
            this.tab1_txtEntityPlural = new System.Windows.Forms.TextBox();
            this.tab1_lblEntityPlural = new System.Windows.Forms.Label();
            this.tab1_txtEntitySingular = new System.Windows.Forms.TextBox();
            this.tab1_lblEntitySingular = new System.Windows.Forms.Label();
            this.tab1_txtEntityName = new System.Windows.Forms.TextBox();
            this.tab1_lblEntityName = new System.Windows.Forms.Label();
            this.tab1_txtTableName = new System.Windows.Forms.TextBox();
            this.tab1_lblTableName = new System.Windows.Forms.Label();
            this.tab1_btnStart = new System.Windows.Forms.Button();
            this.tab1_btnBrowseFolder = new System.Windows.Forms.Button();
            this.tab1_txtOutputFolder = new System.Windows.Forms.TextBox();
            this.tab1_lblOutputFolder = new System.Windows.Forms.Label();
            this.tab0_folderBrowseDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.tab1_folderBrowseDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_CommandOutput = new System.Windows.Forms.ListBox();
            this.pib_CommandProgress = new System.Windows.Forms.PictureBox();
            this.tab0_dpRangoFin = new System.Windows.Forms.DateTimePicker();
            this.tab0_lblRangoFin = new System.Windows.Forms.Label();
            this.tab0_dpRangoInicio = new System.Windows.Forms.DateTimePicker();
            this.tab0_lblRangoInicio = new System.Windows.Forms.Label();
            this.tab0_gbExtraOptions = new System.Windows.Forms.GroupBox();
            this.tab0_ckbExtraOptions = new System.Windows.Forms.CheckBox();
            this.tab0_elblRangoInicio = new System.Windows.Forms.Label();
            this.tab0_elblRangoFin = new System.Windows.Forms.Label();
            this.tab0_lblFmtRangoInicio = new System.Windows.Forms.Label();
            this.tab0_lblFmtRangoFin = new System.Windows.Forms.Label();
            this.tbCtlCommands.SuspendLayout();
            this.tbPgSpsGen.SuspendLayout();
            this.tbPgTierGen.SuspendLayout();
            this.tab1_gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_CommandProgress)).BeginInit();
            this.tab0_gbExtraOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtlCommands
            // 
            this.tbCtlCommands.Controls.Add(this.tbPgSpsGen);
            this.tbCtlCommands.Controls.Add(this.tbPgTierGen);
            this.tbCtlCommands.Location = new System.Drawing.Point(12, 59);
            this.tbCtlCommands.Name = "tbCtlCommands";
            this.tbCtlCommands.SelectedIndex = 0;
            this.tbCtlCommands.Size = new System.Drawing.Size(861, 482);
            this.tbCtlCommands.TabIndex = 0;
            // 
            // tbPgSpsGen
            // 
            this.tbPgSpsGen.Controls.Add(this.tab0_gbExtraOptions);
            this.tbPgSpsGen.Controls.Add(this.tab0_btnResetFrm);
            this.tbPgSpsGen.Controls.Add(this.tab0_elblOutputFolder);
            this.tbPgSpsGen.Controls.Add(this.tab0_btnStart);
            this.tbPgSpsGen.Controls.Add(this.tab0_btnBrowseFolder);
            this.tbPgSpsGen.Controls.Add(this.tab0_txtOutputFolder);
            this.tbPgSpsGen.Controls.Add(this.tab0_lblOutputFolder);
            this.tbPgSpsGen.Location = new System.Drawing.Point(4, 25);
            this.tbPgSpsGen.Name = "tbPgSpsGen";
            this.tbPgSpsGen.Size = new System.Drawing.Size(853, 453);
            this.tbPgSpsGen.TabIndex = 0;
            this.tbPgSpsGen.Text = "Generar SPs";
            this.tbPgSpsGen.UseVisualStyleBackColor = true;
            // 
            // tab0_btnResetFrm
            // 
            this.tab0_btnResetFrm.Location = new System.Drawing.Point(477, 67);
            this.tab0_btnResetFrm.Name = "tab0_btnResetFrm";
            this.tab0_btnResetFrm.Size = new System.Drawing.Size(173, 91);
            this.tab0_btnResetFrm.TabIndex = 5;
            this.tab0_btnResetFrm.Text = "Resetear Formulario";
            this.tab0_btnResetFrm.UseVisualStyleBackColor = true;
            this.tab0_btnResetFrm.Click += new System.EventHandler(this.tab0_btnResetFrm_Click);
            // 
            // tab0_elblOutputFolder
            // 
            this.tab0_elblOutputFolder.AutoSize = true;
            this.tab0_elblOutputFolder.Location = new System.Drawing.Point(157, 34);
            this.tab0_elblOutputFolder.Name = "tab0_elblOutputFolder";
            this.tab0_elblOutputFolder.Size = new System.Drawing.Size(23, 17);
            this.tab0_elblOutputFolder.TabIndex = 4;
            this.tab0_elblOutputFolder.Text = "(*)";
            // 
            // tab0_btnStart
            // 
            this.tab0_btnStart.Location = new System.Drawing.Point(656, 34);
            this.tab0_btnStart.Name = "tab0_btnStart";
            this.tab0_btnStart.Size = new System.Drawing.Size(183, 124);
            this.tab0_btnStart.TabIndex = 3;
            this.tab0_btnStart.Text = "Generar Archivos";
            this.tab0_btnStart.UseVisualStyleBackColor = true;
            this.tab0_btnStart.Click += new System.EventHandler(this.tab0_btnStart_Click);
            // 
            // tab0_btnBrowseFolder
            // 
            this.tab0_btnBrowseFolder.Location = new System.Drawing.Point(477, 32);
            this.tab0_btnBrowseFolder.Name = "tab0_btnBrowseFolder";
            this.tab0_btnBrowseFolder.Size = new System.Drawing.Size(173, 29);
            this.tab0_btnBrowseFolder.TabIndex = 2;
            this.tab0_btnBrowseFolder.Text = "Seleccionar Directorio";
            this.tab0_btnBrowseFolder.UseVisualStyleBackColor = true;
            this.tab0_btnBrowseFolder.Click += new System.EventHandler(this.tab0_btnBrowseFolder_Click);
            // 
            // tab0_txtOutputFolder
            // 
            this.tab0_txtOutputFolder.Location = new System.Drawing.Point(190, 35);
            this.tab0_txtOutputFolder.Name = "tab0_txtOutputFolder";
            this.tab0_txtOutputFolder.ReadOnly = true;
            this.tab0_txtOutputFolder.Size = new System.Drawing.Size(281, 22);
            this.tab0_txtOutputFolder.TabIndex = 1;
            // 
            // tab0_lblOutputFolder
            // 
            this.tab0_lblOutputFolder.AutoSize = true;
            this.tab0_lblOutputFolder.Location = new System.Drawing.Point(23, 35);
            this.tab0_lblOutputFolder.Name = "tab0_lblOutputFolder";
            this.tab0_lblOutputFolder.Size = new System.Drawing.Size(132, 17);
            this.tab0_lblOutputFolder.TabIndex = 0;
            this.tab0_lblOutputFolder.Text = "Directorio de Salida";
            // 
            // tbPgTierGen
            // 
            this.tbPgTierGen.Controls.Add(this.tab1_btnResetFrm);
            this.tbPgTierGen.Controls.Add(this.tab1_elblOptionsGroup);
            this.tbPgTierGen.Controls.Add(this.tab1_btnValidateTableName);
            this.tbPgTierGen.Controls.Add(this.tab1_elblEntityPlural);
            this.tbPgTierGen.Controls.Add(this.tab1_elblEntitySingular);
            this.tbPgTierGen.Controls.Add(this.tab1_elblEntityName);
            this.tbPgTierGen.Controls.Add(this.tab1_elblTableName);
            this.tbPgTierGen.Controls.Add(this.tab1_elblOutputFolder);
            this.tbPgTierGen.Controls.Add(this.tab1_gbOptions);
            this.tbPgTierGen.Controls.Add(this.tab1_txtEntityPlural);
            this.tbPgTierGen.Controls.Add(this.tab1_lblEntityPlural);
            this.tbPgTierGen.Controls.Add(this.tab1_txtEntitySingular);
            this.tbPgTierGen.Controls.Add(this.tab1_lblEntitySingular);
            this.tbPgTierGen.Controls.Add(this.tab1_txtEntityName);
            this.tbPgTierGen.Controls.Add(this.tab1_lblEntityName);
            this.tbPgTierGen.Controls.Add(this.tab1_txtTableName);
            this.tbPgTierGen.Controls.Add(this.tab1_lblTableName);
            this.tbPgTierGen.Controls.Add(this.tab1_btnStart);
            this.tbPgTierGen.Controls.Add(this.tab1_btnBrowseFolder);
            this.tbPgTierGen.Controls.Add(this.tab1_txtOutputFolder);
            this.tbPgTierGen.Controls.Add(this.tab1_lblOutputFolder);
            this.tbPgTierGen.Location = new System.Drawing.Point(4, 25);
            this.tbPgTierGen.Name = "tbPgTierGen";
            this.tbPgTierGen.Size = new System.Drawing.Size(853, 453);
            this.tbPgTierGen.TabIndex = 1;
            this.tbPgTierGen.Text = "Generar Capas";
            this.tbPgTierGen.UseVisualStyleBackColor = true;
            // 
            // tab1_btnResetFrm
            // 
            this.tab1_btnResetFrm.Location = new System.Drawing.Point(657, 36);
            this.tab1_btnResetFrm.Name = "tab1_btnResetFrm";
            this.tab1_btnResetFrm.Size = new System.Drawing.Size(183, 124);
            this.tab1_btnResetFrm.TabIndex = 24;
            this.tab1_btnResetFrm.Text = "Resetear Formulario";
            this.tab1_btnResetFrm.UseVisualStyleBackColor = true;
            this.tab1_btnResetFrm.Click += new System.EventHandler(this.tab1_btnResetFrm_Click);
            // 
            // tab1_elblOptionsGroup
            // 
            this.tab1_elblOptionsGroup.AutoSize = true;
            this.tab1_elblOptionsGroup.Location = new System.Drawing.Point(20, 422);
            this.tab1_elblOptionsGroup.Name = "tab1_elblOptionsGroup";
            this.tab1_elblOptionsGroup.Size = new System.Drawing.Size(243, 17);
            this.tab1_elblOptionsGroup.TabIndex = 23;
            this.tab1_elblOptionsGroup.Text = "(*) Al menos una opcion es requerida";
            // 
            // tab1_btnValidateTableName
            // 
            this.tab1_btnValidateTableName.Location = new System.Drawing.Point(478, 71);
            this.tab1_btnValidateTableName.Name = "tab1_btnValidateTableName";
            this.tab1_btnValidateTableName.Size = new System.Drawing.Size(173, 26);
            this.tab1_btnValidateTableName.TabIndex = 22;
            this.tab1_btnValidateTableName.Text = "Validar Nombre Tabla";
            this.tab1_btnValidateTableName.UseVisualStyleBackColor = true;
            this.tab1_btnValidateTableName.Click += new System.EventHandler(this.tab1_btnValidateTableName_Click);
            // 
            // tab1_elblEntityPlural
            // 
            this.tab1_elblEntityPlural.AutoSize = true;
            this.tab1_elblEntityPlural.Location = new System.Drawing.Point(153, 173);
            this.tab1_elblEntityPlural.Name = "tab1_elblEntityPlural";
            this.tab1_elblEntityPlural.Size = new System.Drawing.Size(23, 17);
            this.tab1_elblEntityPlural.TabIndex = 21;
            this.tab1_elblEntityPlural.Text = "(*)";
            // 
            // tab1_elblEntitySingular
            // 
            this.tab1_elblEntitySingular.AutoSize = true;
            this.tab1_elblEntitySingular.Location = new System.Drawing.Point(153, 140);
            this.tab1_elblEntitySingular.Name = "tab1_elblEntitySingular";
            this.tab1_elblEntitySingular.Size = new System.Drawing.Size(23, 17);
            this.tab1_elblEntitySingular.TabIndex = 20;
            this.tab1_elblEntitySingular.Text = "(*)";
            // 
            // tab1_elblEntityName
            // 
            this.tab1_elblEntityName.AutoSize = true;
            this.tab1_elblEntityName.Location = new System.Drawing.Point(154, 110);
            this.tab1_elblEntityName.Name = "tab1_elblEntityName";
            this.tab1_elblEntityName.Size = new System.Drawing.Size(23, 17);
            this.tab1_elblEntityName.TabIndex = 19;
            this.tab1_elblEntityName.Text = "(*)";
            // 
            // tab1_elblTableName
            // 
            this.tab1_elblTableName.AutoSize = true;
            this.tab1_elblTableName.Location = new System.Drawing.Point(154, 73);
            this.tab1_elblTableName.Name = "tab1_elblTableName";
            this.tab1_elblTableName.Size = new System.Drawing.Size(23, 17);
            this.tab1_elblTableName.TabIndex = 18;
            this.tab1_elblTableName.Text = "(*)";
            // 
            // tab1_elblOutputFolder
            // 
            this.tab1_elblOutputFolder.AutoSize = true;
            this.tab1_elblOutputFolder.Location = new System.Drawing.Point(154, 38);
            this.tab1_elblOutputFolder.Name = "tab1_elblOutputFolder";
            this.tab1_elblOutputFolder.Size = new System.Drawing.Size(23, 17);
            this.tab1_elblOutputFolder.TabIndex = 17;
            this.tab1_elblOutputFolder.Text = "(*)";
            // 
            // tab1_gbOptions
            // 
            this.tab1_gbOptions.Controls.Add(this.tab1_ckbUnityFile);
            this.tab1_gbOptions.Controls.Add(this.tab1_ckbStoredProcedures);
            this.tab1_gbOptions.Controls.Add(this.tab1_ckbServiceTier);
            this.tab1_gbOptions.Controls.Add(this.tab1_ckbBusinessLogicTier);
            this.tab1_gbOptions.Controls.Add(this.tab1_ckbDataAccessTier);
            this.tab1_gbOptions.Controls.Add(this.tab1_ckbEntityTier);
            this.tab1_gbOptions.Location = new System.Drawing.Point(18, 216);
            this.tab1_gbOptions.Name = "tab1_gbOptions";
            this.tab1_gbOptions.Size = new System.Drawing.Size(454, 203);
            this.tab1_gbOptions.TabIndex = 16;
            this.tab1_gbOptions.TabStop = false;
            this.tab1_gbOptions.Text = "Capas/Documentos a Generar";
            // 
            // tab1_ckbUnityFile
            // 
            this.tab1_ckbUnityFile.AutoSize = true;
            this.tab1_ckbUnityFile.Checked = true;
            this.tab1_ckbUnityFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1_ckbUnityFile.Location = new System.Drawing.Point(17, 168);
            this.tab1_ckbUnityFile.Name = "tab1_ckbUnityFile";
            this.tab1_ckbUnityFile.Size = new System.Drawing.Size(248, 21);
            this.tab1_ckbUnityFile.TabIndex = 5;
            this.tab1_ckbUnityFile.Text = "Archivo UnityConfig.cs Actualizado";
            this.tab1_ckbUnityFile.UseVisualStyleBackColor = true;
            // 
            // tab1_ckbStoredProcedures
            // 
            this.tab1_ckbStoredProcedures.AutoSize = true;
            this.tab1_ckbStoredProcedures.Checked = true;
            this.tab1_ckbStoredProcedures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1_ckbStoredProcedures.Location = new System.Drawing.Point(17, 141);
            this.tab1_ckbStoredProcedures.Name = "tab1_ckbStoredProcedures";
            this.tab1_ckbStoredProcedures.Size = new System.Drawing.Size(265, 21);
            this.tab1_ckbStoredProcedures.TabIndex = 4;
            this.tab1_ckbStoredProcedures.Text = "Procedimientos Almacenados(CRUD)";
            this.tab1_ckbStoredProcedures.UseVisualStyleBackColor = true;
            // 
            // tab1_ckbServiceTier
            // 
            this.tab1_ckbServiceTier.AutoSize = true;
            this.tab1_ckbServiceTier.Checked = true;
            this.tab1_ckbServiceTier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1_ckbServiceTier.Location = new System.Drawing.Point(17, 114);
            this.tab1_ckbServiceTier.Name = "tab1_ckbServiceTier";
            this.tab1_ckbServiceTier.Size = new System.Drawing.Size(144, 21);
            this.tab1_ckbServiceTier.TabIndex = 3;
            this.tab1_ckbServiceTier.Text = "Capa de Servicios";
            this.tab1_ckbServiceTier.UseVisualStyleBackColor = true;
            // 
            // tab1_ckbBusinessLogicTier
            // 
            this.tab1_ckbBusinessLogicTier.AutoSize = true;
            this.tab1_ckbBusinessLogicTier.Checked = true;
            this.tab1_ckbBusinessLogicTier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1_ckbBusinessLogicTier.Location = new System.Drawing.Point(17, 87);
            this.tab1_ckbBusinessLogicTier.Name = "tab1_ckbBusinessLogicTier";
            this.tab1_ckbBusinessLogicTier.Size = new System.Drawing.Size(212, 21);
            this.tab1_ckbBusinessLogicTier.TabIndex = 2;
            this.tab1_ckbBusinessLogicTier.Text = "Capa de Logica de Negocios";
            this.tab1_ckbBusinessLogicTier.UseVisualStyleBackColor = true;
            // 
            // tab1_ckbDataAccessTier
            // 
            this.tab1_ckbDataAccessTier.AutoSize = true;
            this.tab1_ckbDataAccessTier.Checked = true;
            this.tab1_ckbDataAccessTier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1_ckbDataAccessTier.Location = new System.Drawing.Point(17, 60);
            this.tab1_ckbDataAccessTier.Name = "tab1_ckbDataAccessTier";
            this.tab1_ckbDataAccessTier.Size = new System.Drawing.Size(186, 21);
            this.tab1_ckbDataAccessTier.TabIndex = 1;
            this.tab1_ckbDataAccessTier.Text = "Capa de Acceso a Datos";
            this.tab1_ckbDataAccessTier.UseVisualStyleBackColor = true;
            // 
            // tab1_ckbEntityTier
            // 
            this.tab1_ckbEntityTier.AutoSize = true;
            this.tab1_ckbEntityTier.Checked = true;
            this.tab1_ckbEntityTier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1_ckbEntityTier.Location = new System.Drawing.Point(17, 33);
            this.tab1_ckbEntityTier.Name = "tab1_ckbEntityTier";
            this.tab1_ckbEntityTier.Size = new System.Drawing.Size(150, 21);
            this.tab1_ckbEntityTier.TabIndex = 0;
            this.tab1_ckbEntityTier.Text = "Capa de Entidades";
            this.tab1_ckbEntityTier.UseVisualStyleBackColor = true;
            // 
            // tab1_txtEntityPlural
            // 
            this.tab1_txtEntityPlural.Enabled = false;
            this.tab1_txtEntityPlural.Location = new System.Drawing.Point(191, 173);
            this.tab1_txtEntityPlural.Name = "tab1_txtEntityPlural";
            this.tab1_txtEntityPlural.Size = new System.Drawing.Size(281, 22);
            this.tab1_txtEntityPlural.TabIndex = 15;
            // 
            // tab1_lblEntityPlural
            // 
            this.tab1_lblEntityPlural.AutoSize = true;
            this.tab1_lblEntityPlural.Location = new System.Drawing.Point(20, 173);
            this.tab1_lblEntityPlural.Name = "tab1_lblEntityPlural";
            this.tab1_lblEntityPlural.Size = new System.Drawing.Size(116, 17);
            this.tab1_lblEntityPlural.TabIndex = 14;
            this.tab1_lblEntityPlural.Text = "Entidad en Plural";
            // 
            // tab1_txtEntitySingular
            // 
            this.tab1_txtEntitySingular.Enabled = false;
            this.tab1_txtEntitySingular.Location = new System.Drawing.Point(191, 140);
            this.tab1_txtEntitySingular.Name = "tab1_txtEntitySingular";
            this.tab1_txtEntitySingular.Size = new System.Drawing.Size(281, 22);
            this.tab1_txtEntitySingular.TabIndex = 13;
            // 
            // tab1_lblEntitySingular
            // 
            this.tab1_lblEntitySingular.AutoSize = true;
            this.tab1_lblEntitySingular.Location = new System.Drawing.Point(18, 143);
            this.tab1_lblEntitySingular.Name = "tab1_lblEntitySingular";
            this.tab1_lblEntitySingular.Size = new System.Drawing.Size(132, 17);
            this.tab1_lblEntitySingular.TabIndex = 12;
            this.tab1_lblEntitySingular.Text = "Entidad en Singular";
            // 
            // tab1_txtEntityName
            // 
            this.tab1_txtEntityName.Enabled = false;
            this.tab1_txtEntityName.Location = new System.Drawing.Point(191, 107);
            this.tab1_txtEntityName.Name = "tab1_txtEntityName";
            this.tab1_txtEntityName.Size = new System.Drawing.Size(281, 22);
            this.tab1_txtEntityName.TabIndex = 11;
            // 
            // tab1_lblEntityName
            // 
            this.tab1_lblEntityName.AutoSize = true;
            this.tab1_lblEntityName.Location = new System.Drawing.Point(18, 112);
            this.tab1_lblEntityName.Name = "tab1_lblEntityName";
            this.tab1_lblEntityName.Size = new System.Drawing.Size(130, 17);
            this.tab1_lblEntityName.TabIndex = 10;
            this.tab1_lblEntityName.Text = "Nombre de Entidad";
            // 
            // tab1_txtTableName
            // 
            this.tab1_txtTableName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tab1_txtTableName.Location = new System.Drawing.Point(191, 73);
            this.tab1_txtTableName.Name = "tab1_txtTableName";
            this.tab1_txtTableName.Size = new System.Drawing.Size(281, 22);
            this.tab1_txtTableName.TabIndex = 9;
            // 
            // tab1_lblTableName
            // 
            this.tab1_lblTableName.AutoSize = true;
            this.tab1_lblTableName.Location = new System.Drawing.Point(18, 76);
            this.tab1_lblTableName.Name = "tab1_lblTableName";
            this.tab1_lblTableName.Size = new System.Drawing.Size(118, 17);
            this.tab1_lblTableName.TabIndex = 8;
            this.tab1_lblTableName.Text = "Nombre de Tabla";
            // 
            // tab1_btnStart
            // 
            this.tab1_btnStart.Location = new System.Drawing.Point(657, 173);
            this.tab1_btnStart.Name = "tab1_btnStart";
            this.tab1_btnStart.Size = new System.Drawing.Size(183, 124);
            this.tab1_btnStart.TabIndex = 7;
            this.tab1_btnStart.Text = "Generar Capas";
            this.tab1_btnStart.UseVisualStyleBackColor = true;
            this.tab1_btnStart.Click += new System.EventHandler(this.tab1_btnStart_Click);
            // 
            // tab1_btnBrowseFolder
            // 
            this.tab1_btnBrowseFolder.Location = new System.Drawing.Point(478, 36);
            this.tab1_btnBrowseFolder.Name = "tab1_btnBrowseFolder";
            this.tab1_btnBrowseFolder.Size = new System.Drawing.Size(173, 26);
            this.tab1_btnBrowseFolder.TabIndex = 6;
            this.tab1_btnBrowseFolder.Text = "Seleccionar Directorio";
            this.tab1_btnBrowseFolder.UseVisualStyleBackColor = true;
            this.tab1_btnBrowseFolder.Click += new System.EventHandler(this.tab1_btnBrowseFolder_Click);
            // 
            // tab1_txtOutputFolder
            // 
            this.tab1_txtOutputFolder.Location = new System.Drawing.Point(191, 38);
            this.tab1_txtOutputFolder.Name = "tab1_txtOutputFolder";
            this.tab1_txtOutputFolder.ReadOnly = true;
            this.tab1_txtOutputFolder.Size = new System.Drawing.Size(281, 22);
            this.tab1_txtOutputFolder.TabIndex = 5;
            // 
            // tab1_lblOutputFolder
            // 
            this.tab1_lblOutputFolder.AutoSize = true;
            this.tab1_lblOutputFolder.Location = new System.Drawing.Point(20, 41);
            this.tab1_lblOutputFolder.Name = "tab1_lblOutputFolder";
            this.tab1_lblOutputFolder.Size = new System.Drawing.Size(132, 17);
            this.tab1_lblOutputFolder.TabIndex = 4;
            this.tab1_lblOutputFolder.Text = "Directorio de Salida";
            // 
            // lb_CommandOutput
            // 
            this.lb_CommandOutput.FormattingEnabled = true;
            this.lb_CommandOutput.ItemHeight = 16;
            this.lb_CommandOutput.Location = new System.Drawing.Point(12, 554);
            this.lb_CommandOutput.Name = "lb_CommandOutput";
            this.lb_CommandOutput.Size = new System.Drawing.Size(857, 84);
            this.lb_CommandOutput.TabIndex = 1;
            // 
            // pib_CommandProgress
            // 
            this.pib_CommandProgress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pib_CommandProgress.Image = ((System.Drawing.Image)(resources.GetObject("pib_CommandProgress.Image")));
            this.pib_CommandProgress.Location = new System.Drawing.Point(763, 22);
            this.pib_CommandProgress.Margin = new System.Windows.Forms.Padding(0);
            this.pib_CommandProgress.Name = "pib_CommandProgress";
            this.pib_CommandProgress.Size = new System.Drawing.Size(84, 48);
            this.pib_CommandProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pib_CommandProgress.TabIndex = 2;
            this.pib_CommandProgress.TabStop = false;
            this.pib_CommandProgress.Visible = false;
            // 
            // tab0_dpRangoFin
            // 
            this.tab0_dpRangoFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.tab0_dpRangoFin.Enabled = false;
            this.tab0_dpRangoFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tab0_dpRangoFin.Location = new System.Drawing.Point(308, 119);
            this.tab0_dpRangoFin.Name = "tab0_dpRangoFin";
            this.tab0_dpRangoFin.Size = new System.Drawing.Size(281, 22);
            this.tab0_dpRangoFin.TabIndex = 42;
            // 
            // tab0_lblRangoFin
            // 
            this.tab0_lblRangoFin.AutoSize = true;
            this.tab0_lblRangoFin.Location = new System.Drawing.Point(22, 119);
            this.tab0_lblRangoFin.Name = "tab0_lblRangoFin";
            this.tab0_lblRangoFin.Size = new System.Drawing.Size(208, 17);
            this.tab0_lblRangoFin.TabIndex = 40;
            this.tab0_lblRangoFin.Text = "Rango Fin (Fecha Modificacion)";
            // 
            // tab0_dpRangoInicio
            // 
            this.tab0_dpRangoInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.tab0_dpRangoInicio.Enabled = false;
            this.tab0_dpRangoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tab0_dpRangoInicio.Location = new System.Drawing.Point(308, 80);
            this.tab0_dpRangoInicio.Name = "tab0_dpRangoInicio";
            this.tab0_dpRangoInicio.Size = new System.Drawing.Size(281, 22);
            this.tab0_dpRangoInicio.TabIndex = 39;
            // 
            // tab0_lblRangoInicio
            // 
            this.tab0_lblRangoInicio.AutoSize = true;
            this.tab0_lblRangoInicio.Location = new System.Drawing.Point(22, 80);
            this.tab0_lblRangoInicio.Name = "tab0_lblRangoInicio";
            this.tab0_lblRangoInicio.Size = new System.Drawing.Size(221, 17);
            this.tab0_lblRangoInicio.TabIndex = 37;
            this.tab0_lblRangoInicio.Text = "Rango Inicio (Fecha Modificacion)";
            // 
            // tab0_gbExtraOptions
            // 
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_lblFmtRangoFin);
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_lblFmtRangoInicio);
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_elblRangoFin);
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_elblRangoInicio);
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_ckbExtraOptions);
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_dpRangoFin);
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_lblRangoInicio);
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_lblRangoFin);
            this.tab0_gbExtraOptions.Controls.Add(this.tab0_dpRangoInicio);
            this.tab0_gbExtraOptions.Location = new System.Drawing.Point(26, 165);
            this.tab0_gbExtraOptions.Name = "tab0_gbExtraOptions";
            this.tab0_gbExtraOptions.Size = new System.Drawing.Size(813, 249);
            this.tab0_gbExtraOptions.TabIndex = 43;
            this.tab0_gbExtraOptions.TabStop = false;
            this.tab0_gbExtraOptions.Text = "Extra Opciones";
            // 
            // tab0_ckbExtraOptions
            // 
            this.tab0_ckbExtraOptions.AutoSize = true;
            this.tab0_ckbExtraOptions.Location = new System.Drawing.Point(25, 42);
            this.tab0_ckbExtraOptions.Name = "tab0_ckbExtraOptions";
            this.tab0_ckbExtraOptions.Size = new System.Drawing.Size(160, 21);
            this.tab0_ckbExtraOptions.TabIndex = 43;
            this.tab0_ckbExtraOptions.Text = "Usar Opciones Extra";
            this.tab0_ckbExtraOptions.UseVisualStyleBackColor = true;
            this.tab0_ckbExtraOptions.CheckedChanged += new System.EventHandler(this.tab0_ckbExtraOptions_CheckedChanged);
            // 
            // tab0_elblRangoInicio
            // 
            this.tab0_elblRangoInicio.AutoSize = true;
            this.tab0_elblRangoInicio.Location = new System.Drawing.Point(255, 83);
            this.tab0_elblRangoInicio.Name = "tab0_elblRangoInicio";
            this.tab0_elblRangoInicio.Size = new System.Drawing.Size(23, 17);
            this.tab0_elblRangoInicio.TabIndex = 44;
            this.tab0_elblRangoInicio.Text = "(*)";
            // 
            // tab0_elblRangoFin
            // 
            this.tab0_elblRangoFin.AutoSize = true;
            this.tab0_elblRangoFin.Location = new System.Drawing.Point(256, 119);
            this.tab0_elblRangoFin.Name = "tab0_elblRangoFin";
            this.tab0_elblRangoFin.Size = new System.Drawing.Size(23, 17);
            this.tab0_elblRangoFin.TabIndex = 45;
            this.tab0_elblRangoFin.Text = "(*)";
            // 
            // tab0_lblFmtRangoInicio
            // 
            this.tab0_lblFmtRangoInicio.AutoSize = true;
            this.tab0_lblFmtRangoInicio.Location = new System.Drawing.Point(605, 85);
            this.tab0_lblFmtRangoInicio.Name = "tab0_lblFmtRangoInicio";
            this.tab0_lblFmtRangoInicio.Size = new System.Drawing.Size(202, 17);
            this.tab0_lblFmtRangoInicio.TabIndex = 46;
            this.tab0_lblFmtRangoInicio.Text = "Ejemplo: 31/12/2021 23:30:13 ";
            // 
            // tab0_lblFmtRangoFin
            // 
            this.tab0_lblFmtRangoFin.AutoSize = true;
            this.tab0_lblFmtRangoFin.Location = new System.Drawing.Point(605, 119);
            this.tab0_lblFmtRangoFin.Name = "tab0_lblFmtRangoFin";
            this.tab0_lblFmtRangoFin.Size = new System.Drawing.Size(202, 17);
            this.tab0_lblFmtRangoFin.TabIndex = 47;
            this.tab0_lblFmtRangoFin.Text = "Ejemplo: 31/12/2021 23:30:13 ";
            // 
            // CommandsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 650);
            this.Controls.Add(this.pib_CommandProgress);
            this.Controls.Add(this.lb_CommandOutput);
            this.Controls.Add(this.tbCtlCommands);
            this.Name = "CommandsFrm";
            this.Text = "Formulario de Comandos";
            this.Load += new System.EventHandler(this.CommandsFrm_Load);
            this.tbCtlCommands.ResumeLayout(false);
            this.tbPgSpsGen.ResumeLayout(false);
            this.tbPgSpsGen.PerformLayout();
            this.tbPgTierGen.ResumeLayout(false);
            this.tbPgTierGen.PerformLayout();
            this.tab1_gbOptions.ResumeLayout(false);
            this.tab1_gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_CommandProgress)).EndInit();
            this.tab0_gbExtraOptions.ResumeLayout(false);
            this.tab0_gbExtraOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtlCommands;
        private System.Windows.Forms.TabPage tbPgSpsGen;
        private System.Windows.Forms.TabPage tbPgTierGen;
        private System.Windows.Forms.Label tab0_lblOutputFolder;
        private System.Windows.Forms.TextBox tab0_txtOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog tab0_folderBrowseDlg;
        private System.Windows.Forms.Button tab0_btnStart;
        private System.Windows.Forms.Button tab0_btnBrowseFolder;
        private System.Windows.Forms.Button tab1_btnStart;
        private System.Windows.Forms.Button tab1_btnBrowseFolder;
        private System.Windows.Forms.TextBox tab1_txtOutputFolder;
        private System.Windows.Forms.Label tab1_lblOutputFolder;
        private System.Windows.Forms.TextBox tab1_txtTableName;
        private System.Windows.Forms.Label tab1_lblTableName;
        private System.Windows.Forms.TextBox tab1_txtEntityPlural;
        private System.Windows.Forms.Label tab1_lblEntityPlural;
        private System.Windows.Forms.TextBox tab1_txtEntitySingular;
        private System.Windows.Forms.Label tab1_lblEntitySingular;
        private System.Windows.Forms.TextBox tab1_txtEntityName;
        private System.Windows.Forms.Label tab1_lblEntityName;
        private System.Windows.Forms.GroupBox tab1_gbOptions;
        private System.Windows.Forms.CheckBox tab1_ckbUnityFile;
        private System.Windows.Forms.CheckBox tab1_ckbStoredProcedures;
        private System.Windows.Forms.CheckBox tab1_ckbServiceTier;
        private System.Windows.Forms.CheckBox tab1_ckbBusinessLogicTier;
        private System.Windows.Forms.CheckBox tab1_ckbDataAccessTier;
        private System.Windows.Forms.CheckBox tab1_ckbEntityTier;
        private System.Windows.Forms.FolderBrowserDialog tab1_folderBrowseDlg;
        private System.Windows.Forms.Label tab1_elblEntityPlural;
        private System.Windows.Forms.Label tab1_elblEntitySingular;
        private System.Windows.Forms.Label tab1_elblEntityName;
        private System.Windows.Forms.Label tab1_elblTableName;
        private System.Windows.Forms.Label tab1_elblOutputFolder;
        private System.Windows.Forms.Button tab1_btnValidateTableName;
        private System.Windows.Forms.Label tab1_elblOptionsGroup;
        private System.Windows.Forms.Button tab1_btnResetFrm;
        private System.Windows.Forms.Label tab0_elblOutputFolder;
        private System.Windows.Forms.Button tab0_btnResetFrm;
        private System.Windows.Forms.ListBox lb_CommandOutput;
        private System.Windows.Forms.PictureBox pib_CommandProgress;
        private System.Windows.Forms.GroupBox tab0_gbExtraOptions;
        private System.Windows.Forms.DateTimePicker tab0_dpRangoFin;
        private System.Windows.Forms.Label tab0_lblRangoInicio;
        private System.Windows.Forms.Label tab0_lblRangoFin;
        private System.Windows.Forms.DateTimePicker tab0_dpRangoInicio;
        private System.Windows.Forms.CheckBox tab0_ckbExtraOptions;
        private System.Windows.Forms.Label tab0_elblRangoFin;
        private System.Windows.Forms.Label tab0_elblRangoInicio;
        private System.Windows.Forms.Label tab0_lblFmtRangoInicio;
        private System.Windows.Forms.Label tab0_lblFmtRangoFin;
    }
}

