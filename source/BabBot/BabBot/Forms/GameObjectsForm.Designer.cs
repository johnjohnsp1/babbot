﻿namespace BabBot.Forms
{
    partial class GameObjectsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lbGameObjList = new System.Windows.Forms.ListBox();
            this.popGameObject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteGameObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsGameObjects = new System.Windows.Forms.BindingSource(this.components);
            this.botDataSet = new BabBot.Data.BotDataSet();
            this.labelWoWVersion = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.lbActiveServices = new System.Windows.Forms.ListBox();
            this.popServiceActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindToInnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fkGameObjectsNpcServices = new System.Windows.Forms.BindingSource(this.components);
            this.tbFaction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAvailServices = new System.Windows.Forms.ComboBox();
            this.bsServiceTypesFiltered = new System.Windows.Forms.BindingSource(this.components);
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddCoord = new System.Windows.Forms.Button();
            this.lbCoordinates = new System.Windows.Forms.ListBox();
            this.popCoordinates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteCoordinatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fKCoordinatesZoneCoordinates = new System.Windows.Forms.BindingSource(this.components);
            this.fKGameObjectsCoordinatesZone = new System.Windows.Forms.BindingSource(this.components);
            this.gbQuestList = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbQuestObjectives = new System.Windows.Forms.ListBox();
            this.popQuestItemActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recordRouteFromNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordRouteToNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fKQuestListQuestItemsObjectives = new System.Windows.Forms.BindingSource(this.components);
            this.fkGameObjectsQuestList = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.lbQuestItems = new System.Windows.Forms.ListBox();
            this.fKQuestListQuestItemsChoice = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lbQuestList = new System.Windows.Forms.ListBox();
            this.popQuestActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acceptQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliverQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.executeQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddQuest = new System.Windows.Forms.Button();
            this.btnAddNPC = new System.Windows.Forms.Button();
            this.cbServiceList = new System.Windows.Forms.ComboBox();
            this.bsServiceTypesFull = new System.Windows.Forms.BindingSource(this.components);
            this.btnMoveToNearest = new System.Windows.Forms.Button();
            this.labelServices = new System.Windows.Forms.Label();
            this.gbDebug = new System.Windows.Forms.GroupBox();
            this.cbLearnSkills = new System.Windows.Forms.CheckBox();
            this.cbUseState = new System.Windows.Forms.CheckBox();
            this.gbCoordinates = new System.Windows.Forms.GroupBox();
            this.cbCoordZone = new System.Windows.Forms.ComboBox();
            this.btnAddPlayerTargetCoord = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPlayerTarget = new System.Windows.Forms.ComboBox();
            this.btnAddNewObj = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cbItemList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAllZones = new System.Windows.Forms.ComboBox();
            this.bsZoneList = new System.Windows.Forms.BindingSource(this.components);
            this.gbAddCoord = new System.Windows.Forms.GroupBox();
            this.cbCoordType = new System.Windows.Forms.ComboBox();
            this.bsCoordTypes = new System.Windows.Forms.BindingSource(this.components);
            this.gbAutoAdd = new System.Windows.Forms.GroupBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.popGameObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGameObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botDataSet)).BeginInit();
            this.gbDescription.SuspendLayout();
            this.popServiceActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fkGameObjectsNpcServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTypesFiltered)).BeginInit();
            this.popCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKCoordinatesZoneCoordinates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGameObjectsCoordinatesZone)).BeginInit();
            this.gbQuestList.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.popQuestItemActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestListQuestItemsObjectives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkGameObjectsQuestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestListQuestItemsChoice)).BeginInit();
            this.popQuestActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTypesFull)).BeginInit();
            this.gbDebug.SuspendLayout();
            this.gbCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsZoneList)).BeginInit();
            this.gbAddCoord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoordTypes)).BeginInit();
            this.gbAutoAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 458);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(631, 458);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(550, 458);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "WoW Version:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(238, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 18);
            this.labelTitle.TabIndex = 33;
            this.labelTitle.Text = "Game Object List";
            // 
            // lbGameObjList
            // 
            this.lbGameObjList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGameObjList.ContextMenuStrip = this.popGameObject;
            this.lbGameObjList.DataSource = this.bsGameObjects;
            this.lbGameObjList.DisplayMember = "NAME";
            this.lbGameObjList.FormattingEnabled = true;
            this.lbGameObjList.Location = new System.Drawing.Point(12, 37);
            this.lbGameObjList.MultiColumn = true;
            this.lbGameObjList.Name = "lbGameObjList";
            this.lbGameObjList.Size = new System.Drawing.Size(574, 186);
            this.lbGameObjList.TabIndex = 34;
            this.lbGameObjList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbGameObjectList_KeyDown);
            // 
            // popGameObject
            // 
            this.popGameObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.moveToObjectToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteGameObjectToolStripMenuItem});
            this.popGameObject.Name = "popNpc";
            this.popGameObject.Size = new System.Drawing.Size(153, 76);
            this.popGameObject.Opening += new System.ComponentModel.CancelEventHandler(this.popGameObject_Opening);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export to XML";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // moveToObjectToolStripMenuItem
            // 
            this.moveToObjectToolStripMenuItem.Name = "moveToObjectToolStripMenuItem";
            this.moveToObjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moveToObjectToolStripMenuItem.Text = "Move To ";
            this.moveToObjectToolStripMenuItem.Click += new System.EventHandler(this.moveToObjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // deleteGameObjectToolStripMenuItem
            // 
            this.deleteGameObjectToolStripMenuItem.Name = "deleteGameObjectToolStripMenuItem";
            this.deleteGameObjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteGameObjectToolStripMenuItem.Text = "Delete";
            this.deleteGameObjectToolStripMenuItem.Click += new System.EventHandler(this.deleteGameObjectToolStripMenuItem_Click);
            // 
            // bsGameObjects
            // 
            this.bsGameObjects.DataMember = "GameObjects";
            this.bsGameObjects.DataSource = this.botDataSet;
            this.bsGameObjects.Sort = "NAME";
            this.bsGameObjects.CurrentChanged += new System.EventHandler(this.gameObjectsBindingSource_CurrentChanged);
            // 
            // botDataSet
            // 
            this.botDataSet.DataSetName = "BotDataSet";
            this.botDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelWoWVersion
            // 
            this.labelWoWVersion.AutoSize = true;
            this.labelWoWVersion.Location = new System.Drawing.Point(85, 9);
            this.labelWoWVersion.Name = "labelWoWVersion";
            this.labelWoWVersion.Size = new System.Drawing.Size(0, 13);
            this.labelWoWVersion.TabIndex = 35;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(481, 458);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(63, 23);
            this.btnImport.TabIndex = 36;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGameObjects, "NAME", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbName.Location = new System.Drawing.Point(9, 30);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 38;
            // 
            // gbDescription
            // 
            this.gbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDescription.Controls.Add(this.btnAddService);
            this.gbDescription.Controls.Add(this.tbName);
            this.gbDescription.Controls.Add(this.lbActiveServices);
            this.gbDescription.Controls.Add(this.tbFaction);
            this.gbDescription.Controls.Add(this.label4);
            this.gbDescription.Controls.Add(this.tbDescr);
            this.gbDescription.Controls.Add(this.label1);
            this.gbDescription.Controls.Add(this.cbAvailServices);
            this.gbDescription.Controls.Add(this.label3);
            this.gbDescription.Location = new System.Drawing.Point(12, 260);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(161, 192);
            this.gbDescription.TabIndex = 39;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Object Description";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(120, 83);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(35, 23);
            this.btnAddService.TabIndex = 42;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbActiveServices
            // 
            this.lbActiveServices.ContextMenuStrip = this.popServiceActions;
            this.lbActiveServices.DataSource = this.fkGameObjectsNpcServices;
            this.lbActiveServices.DisplayMember = "FULL_NAME";
            this.lbActiveServices.FormattingEnabled = true;
            this.lbActiveServices.Location = new System.Drawing.Point(9, 138);
            this.lbActiveServices.Name = "lbActiveServices";
            this.lbActiveServices.ScrollAlwaysVisible = true;
            this.lbActiveServices.Size = new System.Drawing.Size(145, 43);
            this.lbActiveServices.TabIndex = 39;
            this.lbActiveServices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbActiveServices_KeyDown);
            // 
            // popServiceActions
            // 
            this.popServiceActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteServiceToolStripMenuItem,
            this.bindToInnToolStripMenuItem});
            this.popServiceActions.Name = "popServiceActions";
            this.popServiceActions.Size = new System.Drawing.Size(155, 48);
            this.popServiceActions.Opening += new System.ComponentModel.CancelEventHandler(this.popServiceActions_Opening);
            // 
            // deleteServiceToolStripMenuItem
            // 
            this.deleteServiceToolStripMenuItem.Name = "deleteServiceToolStripMenuItem";
            this.deleteServiceToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteServiceToolStripMenuItem.Text = "Delete Service";
            this.deleteServiceToolStripMenuItem.Click += new System.EventHandler(this.deleteServiceToolStripMenuItem_Click);
            // 
            // bindToInnToolStripMenuItem
            // 
            this.bindToInnToolStripMenuItem.Name = "bindToInnToolStripMenuItem";
            this.bindToInnToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bindToInnToolStripMenuItem.Text = "Bind to Inn";
            this.bindToInnToolStripMenuItem.Click += new System.EventHandler(this.bindToInnToolStripMenuItem_Click);
            // 
            // fkGameObjectsNpcServices
            // 
            this.fkGameObjectsNpcServices.DataMember = "FK_GameObjects_NpcServices";
            this.fkGameObjectsNpcServices.DataSource = this.bsGameObjects;
            this.fkGameObjectsNpcServices.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsFKGameObjectsNpcServices_ListChanged);
            // 
            // tbFaction
            // 
            this.tbFaction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGameObjects, "FACTION", true));
            this.tbFaction.Location = new System.Drawing.Point(55, 56);
            this.tbFaction.Name = "tbFaction";
            this.tbFaction.ReadOnly = true;
            this.tbFaction.Size = new System.Drawing.Size(100, 20);
            this.tbFaction.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Faction";
            // 
            // tbDescr
            // 
            this.tbDescr.Location = new System.Drawing.Point(55, 112);
            this.tbDescr.Name = "tbDescr";
            this.tbDescr.Size = new System.Drawing.Size(100, 20);
            this.tbDescr.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Descr";
            // 
            // cbAvailServices
            // 
            this.cbAvailServices.DataSource = this.bsServiceTypesFiltered;
            this.cbAvailServices.DisplayMember = "NAME";
            this.cbAvailServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailServices.FormattingEnabled = true;
            this.cbAvailServices.Location = new System.Drawing.Point(9, 85);
            this.cbAvailServices.Name = "cbAvailServices";
            this.cbAvailServices.Size = new System.Drawing.Size(104, 21);
            this.cbAvailServices.TabIndex = 41;
            // 
            // bsServiceTypesFiltered
            // 
            this.bsServiceTypesFiltered.DataMember = "ServiceTypes";
            this.bsServiceTypesFiltered.DataSource = this.botDataSet;
            this.bsServiceTypesFiltered.CurrentChanged += new System.EventHandler(this.bsServiceTypesFiltered_CurrentChanged);
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(23, 125);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(71, 20);
            this.tbZ.TabIndex = 78;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(23, 99);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(71, 20);
            this.tbY.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Y";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(23, 73);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(71, 20);
            this.tbX.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "X";
            // 
            // btnAddCoord
            // 
            this.btnAddCoord.Location = new System.Drawing.Point(57, 163);
            this.btnAddCoord.Name = "btnAddCoord";
            this.btnAddCoord.Size = new System.Drawing.Size(37, 23);
            this.btnAddCoord.TabIndex = 70;
            this.btnAddCoord.Text = "Add";
            this.btnAddCoord.UseVisualStyleBackColor = true;
            this.btnAddCoord.Click += new System.EventHandler(this.btnAddCoord_Click);
            // 
            // lbCoordinates
            // 
            this.lbCoordinates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCoordinates.ContextMenuStrip = this.popCoordinates;
            this.lbCoordinates.DataSource = this.fKCoordinatesZoneCoordinates;
            this.lbCoordinates.DisplayMember = "COORD";
            this.lbCoordinates.FormattingEnabled = true;
            this.lbCoordinates.Location = new System.Drawing.Point(6, 49);
            this.lbCoordinates.Name = "lbCoordinates";
            this.lbCoordinates.ScrollAlwaysVisible = true;
            this.lbCoordinates.Size = new System.Drawing.Size(173, 121);
            this.lbCoordinates.TabIndex = 70;
            this.lbCoordinates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbCoordinates_KeyDown);
            // 
            // popCoordinates
            // 
            this.popCoordinates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCoordinatesToolStripMenuItem});
            this.popCoordinates.Name = "popCoordinates";
            this.popCoordinates.Size = new System.Drawing.Size(178, 26);
            this.popCoordinates.Opening += new System.ComponentModel.CancelEventHandler(this.popCoordinates_Opening);
            // 
            // deleteCoordinatesToolStripMenuItem
            // 
            this.deleteCoordinatesToolStripMenuItem.Name = "deleteCoordinatesToolStripMenuItem";
            this.deleteCoordinatesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteCoordinatesToolStripMenuItem.Text = "Delete Coordinates";
            this.deleteCoordinatesToolStripMenuItem.Click += new System.EventHandler(this.deleteCoordinatesToolStripMenuItem_Click);
            // 
            // fKCoordinatesZoneCoordinates
            // 
            this.fKCoordinatesZoneCoordinates.DataMember = "FK_CoordinatesZone_Coordinates";
            this.fKCoordinatesZoneCoordinates.DataSource = this.fKGameObjectsCoordinatesZone;
            // 
            // fKGameObjectsCoordinatesZone
            // 
            this.fKGameObjectsCoordinatesZone.DataMember = "FK_GameObjects_CoordinatesZone";
            this.fKGameObjectsCoordinatesZone.DataSource = this.bsGameObjects;
            this.fKGameObjectsCoordinatesZone.Sort = "ZONE_NAME";
            this.fKGameObjectsCoordinatesZone.CurrentChanged += new System.EventHandler(this.fKGameObjectsCoordinatesZone_CurrentChanged);
            // 
            // gbQuestList
            // 
            this.gbQuestList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuestList.Controls.Add(this.splitContainer1);
            this.gbQuestList.Controls.Add(this.lbQuestList);
            this.gbQuestList.Location = new System.Drawing.Point(480, 260);
            this.gbQuestList.Name = "gbQuestList";
            this.gbQuestList.Size = new System.Drawing.Size(226, 192);
            this.gbQuestList.TabIndex = 45;
            this.gbQuestList.TabStop = false;
            this.gbQuestList.Text = "Quest List";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 99);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbQuestObjectives);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbQuestItems);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Size = new System.Drawing.Size(214, 87);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 46;
            // 
            // lbQuestObjectives
            // 
            this.lbQuestObjectives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuestObjectives.ContextMenuStrip = this.popQuestItemActions;
            this.lbQuestObjectives.DataSource = this.fKQuestListQuestItemsObjectives;
            this.lbQuestObjectives.DisplayMember = "NAME";
            this.lbQuestObjectives.FormattingEnabled = true;
            this.lbQuestObjectives.HorizontalScrollbar = true;
            this.lbQuestObjectives.Location = new System.Drawing.Point(3, 18);
            this.lbQuestObjectives.Name = "lbQuestObjectives";
            this.lbQuestObjectives.Size = new System.Drawing.Size(101, 69);
            this.lbQuestObjectives.TabIndex = 49;
            // 
            // popQuestItemActions
            // 
            this.popQuestItemActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordRouteFromNPCToolStripMenuItem,
            this.recordRouteToNPCToolStripMenuItem});
            this.popQuestItemActions.Name = "popQuestItemActions";
            this.popQuestItemActions.Size = new System.Drawing.Size(202, 48);
            this.popQuestItemActions.Opening += new System.ComponentModel.CancelEventHandler(this.popQuestItemActions_Opening);
            // 
            // recordRouteFromNPCToolStripMenuItem
            // 
            this.recordRouteFromNPCToolStripMenuItem.Name = "recordRouteFromNPCToolStripMenuItem";
            this.recordRouteFromNPCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.recordRouteFromNPCToolStripMenuItem.Text = "Record Route From NPC";
            this.recordRouteFromNPCToolStripMenuItem.Click += new System.EventHandler(this.recordRouteFromNPCToolStripMenuItem_Click);
            // 
            // recordRouteToNPCToolStripMenuItem
            // 
            this.recordRouteToNPCToolStripMenuItem.Name = "recordRouteToNPCToolStripMenuItem";
            this.recordRouteToNPCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.recordRouteToNPCToolStripMenuItem.Text = "Record Route To NPC";
            // 
            // fKQuestListQuestItemsObjectives
            // 
            this.fKQuestListQuestItemsObjectives.DataMember = "FK_QuestList_QuestItems";
            this.fKQuestListQuestItemsObjectives.DataSource = this.fkGameObjectsQuestList;
            this.fKQuestListQuestItemsObjectives.Filter = "ITEM_TYPE_ID = 3";
            this.fKQuestListQuestItemsObjectives.Sort = "IDX";
            // 
            // fkGameObjectsQuestList
            // 
            this.fkGameObjectsQuestList.DataMember = "FK_GameObjects_QuestList";
            this.fkGameObjectsQuestList.DataSource = this.bsGameObjects;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(0, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Objectives";
            // 
            // lbQuestItems
            // 
            this.lbQuestItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuestItems.DataSource = this.fKQuestListQuestItemsChoice;
            this.lbQuestItems.DisplayMember = "NAME";
            this.lbQuestItems.FormattingEnabled = true;
            this.lbQuestItems.HorizontalScrollbar = true;
            this.lbQuestItems.Location = new System.Drawing.Point(2, 18);
            this.lbQuestItems.Name = "lbQuestItems";
            this.lbQuestItems.Size = new System.Drawing.Size(98, 69);
            this.lbQuestItems.TabIndex = 46;
            // 
            // fKQuestListQuestItemsChoice
            // 
            this.fKQuestListQuestItemsChoice.DataMember = "FK_QuestList_QuestItems";
            this.fKQuestListQuestItemsChoice.DataSource = this.fkGameObjectsQuestList;
            this.fKQuestListQuestItemsChoice.Filter = "ITEM_TYPE_ID = 2";
            this.fKQuestListQuestItemsChoice.Sort = "IDX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(-1, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Choice Rewards";
            // 
            // lbQuestList
            // 
            this.lbQuestList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuestList.ContextMenuStrip = this.popQuestActions;
            this.lbQuestList.DataSource = this.fkGameObjectsQuestList;
            this.lbQuestList.DisplayMember = "TITLE";
            this.lbQuestList.FormattingEnabled = true;
            this.lbQuestList.HorizontalScrollbar = true;
            this.lbQuestList.Location = new System.Drawing.Point(6, 16);
            this.lbQuestList.Name = "lbQuestList";
            this.lbQuestList.Size = new System.Drawing.Size(214, 82);
            this.lbQuestList.TabIndex = 45;
            this.lbQuestList.DoubleClick += new System.EventHandler(this.lbQuestList_DoubleClick);
            this.lbQuestList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbQuestList_KeyDown);
            // 
            // popQuestActions
            // 
            this.popQuestActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptQuestToolStripMenuItem,
            this.deliverQuestToolStripMenuItem,
            this.toolStripSeparator2,
            this.executeQuestToolStripMenuItem,
            this.deleteQuestToolStripMenuItem});
            this.popQuestActions.Name = "popQuestActions";
            this.popQuestActions.Size = new System.Drawing.Size(157, 98);
            this.popQuestActions.Text = "1";
            this.popQuestActions.Opening += new System.ComponentModel.CancelEventHandler(this.popQuestActions_Opening);
            // 
            // acceptQuestToolStripMenuItem
            // 
            this.acceptQuestToolStripMenuItem.Name = "acceptQuestToolStripMenuItem";
            this.acceptQuestToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.acceptQuestToolStripMenuItem.Text = "Accept Quest";
            this.acceptQuestToolStripMenuItem.Click += new System.EventHandler(this.acceptQuestToolStripMenuItem_Click);
            // 
            // deliverQuestToolStripMenuItem
            // 
            this.deliverQuestToolStripMenuItem.Name = "deliverQuestToolStripMenuItem";
            this.deliverQuestToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deliverQuestToolStripMenuItem.Text = "Deliver Quest";
            this.deliverQuestToolStripMenuItem.Click += new System.EventHandler(this.deliverQuestToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // executeQuestToolStripMenuItem
            // 
            this.executeQuestToolStripMenuItem.Name = "executeQuestToolStripMenuItem";
            this.executeQuestToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.executeQuestToolStripMenuItem.Text = "Execute Quest";
            this.executeQuestToolStripMenuItem.Click += new System.EventHandler(this.executeQuestToolStripMenuItem_Click);
            // 
            // deleteQuestToolStripMenuItem
            // 
            this.deleteQuestToolStripMenuItem.Name = "deleteQuestToolStripMenuItem";
            this.deleteQuestToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteQuestToolStripMenuItem.Text = "Delete Quest";
            this.deleteQuestToolStripMenuItem.Click += new System.EventHandler(this.deleteQuestToolStripMenuItem_Click);
            // 
            // btnAddQuest
            // 
            this.btnAddQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuest.Location = new System.Drawing.Point(400, 458);
            this.btnAddQuest.Name = "btnAddQuest";
            this.btnAddQuest.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuest.TabIndex = 44;
            this.btnAddQuest.Text = "Add Quest";
            this.btnAddQuest.UseVisualStyleBackColor = true;
            this.btnAddQuest.Click += new System.EventHandler(this.btnAddQuest_Click);
            // 
            // btnAddNPC
            // 
            this.btnAddNPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNPC.Location = new System.Drawing.Point(12, 229);
            this.btnAddNPC.Name = "btnAddNPC";
            this.btnAddNPC.Size = new System.Drawing.Size(99, 23);
            this.btnAddNPC.TabIndex = 64;
            this.btnAddNPC.Text = "Add Target NPC";
            this.btnAddNPC.UseVisualStyleBackColor = true;
            this.btnAddNPC.Click += new System.EventHandler(this.btnAddNPC_Click);
            // 
            // cbServiceList
            // 
            this.cbServiceList.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.botDataSet, "ServiceTypes.NAME", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbServiceList.DataSource = this.bsServiceTypesFull;
            this.cbServiceList.DisplayMember = "NAME";
            this.cbServiceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceList.FormattingEnabled = true;
            this.cbServiceList.Location = new System.Drawing.Point(6, 55);
            this.cbServiceList.Name = "cbServiceList";
            this.cbServiceList.Size = new System.Drawing.Size(102, 21);
            this.cbServiceList.TabIndex = 65;
            this.cbServiceList.SelectedIndexChanged += new System.EventHandler(this.cbServiceList_SelectedIndexChanged);
            // 
            // bsServiceTypesFull
            // 
            this.bsServiceTypesFull.DataMember = "ServiceTypes";
            this.bsServiceTypesFull.DataSource = this.botDataSet;
            // 
            // btnMoveToNearest
            // 
            this.btnMoveToNearest.Location = new System.Drawing.Point(6, 82);
            this.btnMoveToNearest.Name = "btnMoveToNearest";
            this.btnMoveToNearest.Size = new System.Drawing.Size(102, 23);
            this.btnMoveToNearest.TabIndex = 66;
            this.btnMoveToNearest.Text = "Move to Nearest NPC";
            this.btnMoveToNearest.UseVisualStyleBackColor = true;
            this.btnMoveToNearest.Click += new System.EventHandler(this.btnMoveToNearest_Click);
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Location = new System.Drawing.Point(6, 39);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(43, 13);
            this.labelServices.TabIndex = 67;
            this.labelServices.Text = "Service";
            // 
            // gbDebug
            // 
            this.gbDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDebug.Controls.Add(this.cbLearnSkills);
            this.gbDebug.Controls.Add(this.cbUseState);
            this.gbDebug.Controls.Add(this.labelServices);
            this.gbDebug.Controls.Add(this.cbServiceList);
            this.gbDebug.Controls.Add(this.btnMoveToNearest);
            this.gbDebug.Location = new System.Drawing.Point(592, 33);
            this.gbDebug.Name = "gbDebug";
            this.gbDebug.Size = new System.Drawing.Size(114, 190);
            this.gbDebug.TabIndex = 68;
            this.gbDebug.TabStop = false;
            this.gbDebug.Text = "Debug";
            // 
            // cbLearnSkills
            // 
            this.cbLearnSkills.AutoSize = true;
            this.cbLearnSkills.Location = new System.Drawing.Point(6, 140);
            this.cbLearnSkills.Name = "cbLearnSkills";
            this.cbLearnSkills.Size = new System.Drawing.Size(102, 17);
            this.cbLearnSkills.TabIndex = 72;
            this.cbLearnSkills.Text = "And Learn Skills";
            this.cbLearnSkills.UseVisualStyleBackColor = true;
            // 
            // cbUseState
            // 
            this.cbUseState.AutoSize = true;
            this.cbUseState.Checked = true;
            this.cbUseState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseState.Location = new System.Drawing.Point(6, 19);
            this.cbUseState.Name = "cbUseState";
            this.cbUseState.Size = new System.Drawing.Size(106, 17);
            this.cbUseState.TabIndex = 71;
            this.cbUseState.Text = "Use Travel State";
            this.cbUseState.UseVisualStyleBackColor = true;
            this.cbUseState.CheckedChanged += new System.EventHandler(this.cbUseState_CheckedChanged);
            // 
            // gbCoordinates
            // 
            this.gbCoordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbCoordinates.Controls.Add(this.cbCoordZone);
            this.gbCoordinates.Controls.Add(this.lbCoordinates);
            this.gbCoordinates.Location = new System.Drawing.Point(179, 260);
            this.gbCoordinates.Name = "gbCoordinates";
            this.gbCoordinates.Size = new System.Drawing.Size(189, 174);
            this.gbCoordinates.TabIndex = 69;
            this.gbCoordinates.TabStop = false;
            this.gbCoordinates.Text = "Coordinates";
            // 
            // cbCoordZone
            // 
            this.cbCoordZone.DataSource = this.fKGameObjectsCoordinatesZone;
            this.cbCoordZone.DisplayMember = "ZONE_NAME";
            this.cbCoordZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoordZone.FormattingEnabled = true;
            this.cbCoordZone.Location = new System.Drawing.Point(6, 19);
            this.cbCoordZone.Name = "cbCoordZone";
            this.cbCoordZone.Size = new System.Drawing.Size(173, 21);
            this.cbCoordZone.TabIndex = 83;
            this.cbCoordZone.SelectedIndexChanged += new System.EventHandler(this.cbCoordZone_SelectedIndexChanged);
            // 
            // btnAddPlayerTargetCoord
            // 
            this.btnAddPlayerTargetCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayerTargetCoord.Location = new System.Drawing.Point(147, 15);
            this.btnAddPlayerTargetCoord.Name = "btnAddPlayerTargetCoord";
            this.btnAddPlayerTargetCoord.Size = new System.Drawing.Size(36, 23);
            this.btnAddPlayerTargetCoord.TabIndex = 82;
            this.btnAddPlayerTargetCoord.Text = "Add";
            this.btnAddPlayerTargetCoord.UseVisualStyleBackColor = true;
            this.btnAddPlayerTargetCoord.Click += new System.EventHandler(this.btnAddPlayerTargetCoord_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "coord.";
            // 
            // cbPlayerTarget
            // 
            this.cbPlayerTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerTarget.FormattingEnabled = true;
            this.cbPlayerTarget.Items.AddRange(new object[] {
            "Player",
            "Target"});
            this.cbPlayerTarget.Location = new System.Drawing.Point(6, 17);
            this.cbPlayerTarget.Name = "cbPlayerTarget";
            this.cbPlayerTarget.Size = new System.Drawing.Size(88, 21);
            this.cbPlayerTarget.TabIndex = 80;
            // 
            // btnAddNewObj
            // 
            this.btnAddNewObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewObj.Location = new System.Drawing.Point(612, 231);
            this.btnAddNewObj.Name = "btnAddNewObj";
            this.btnAddNewObj.Size = new System.Drawing.Size(94, 23);
            this.btnAddNewObj.TabIndex = 70;
            this.btnAddNewObj.Text = "Add New Object";
            this.btnAddNewObj.UseVisualStyleBackColor = true;
            this.btnAddNewObj.Click += new System.EventHandler(this.btnAddNewObj_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.Location = new System.Drawing.Point(306, 231);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(39, 23);
            this.btnAddItem.TabIndex = 71;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cbItemList
            // 
            this.cbItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbItemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemList.FormattingEnabled = true;
            this.cbItemList.Location = new System.Drawing.Point(179, 231);
            this.cbItemList.Name = "cbItemList";
            this.cbItemList.Size = new System.Drawing.Size(121, 21);
            this.cbItemList.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Object";
            // 
            // cbAllZones
            // 
            this.cbAllZones.DataSource = this.bsZoneList;
            this.cbAllZones.DisplayMember = "NAME";
            this.cbAllZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllZones.FormattingEnabled = true;
            this.cbAllZones.Location = new System.Drawing.Point(6, 19);
            this.cbAllZones.Name = "cbAllZones";
            this.cbAllZones.Size = new System.Drawing.Size(88, 21);
            this.cbAllZones.TabIndex = 80;
            // 
            // bsZoneList
            // 
            this.bsZoneList.DataMember = "ZoneList";
            this.bsZoneList.DataSource = this.botDataSet;
            this.bsZoneList.Sort = "NAME";
            // 
            // gbAddCoord
            // 
            this.gbAddCoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAddCoord.Controls.Add(this.cbCoordType);
            this.gbAddCoord.Controls.Add(this.tbY);
            this.gbAddCoord.Controls.Add(this.cbAllZones);
            this.gbAddCoord.Controls.Add(this.label6);
            this.gbAddCoord.Controls.Add(this.btnAddCoord);
            this.gbAddCoord.Controls.Add(this.label8);
            this.gbAddCoord.Controls.Add(this.tbX);
            this.gbAddCoord.Controls.Add(this.tbZ);
            this.gbAddCoord.Controls.Add(this.label7);
            this.gbAddCoord.Location = new System.Drawing.Point(374, 260);
            this.gbAddCoord.Name = "gbAddCoord";
            this.gbAddCoord.Size = new System.Drawing.Size(100, 192);
            this.gbAddCoord.TabIndex = 75;
            this.gbAddCoord.TabStop = false;
            this.gbAddCoord.Text = "Add Coordinates";
            // 
            // cbCoordType
            // 
            this.cbCoordType.DataSource = this.bsCoordTypes;
            this.cbCoordType.DisplayMember = "TYPE";
            this.cbCoordType.FormattingEnabled = true;
            this.cbCoordType.Location = new System.Drawing.Point(6, 46);
            this.cbCoordType.Name = "cbCoordType";
            this.cbCoordType.Size = new System.Drawing.Size(88, 21);
            this.cbCoordType.TabIndex = 81;
            this.cbCoordType.ValueMember = "ID";
            // 
            // bsCoordTypes
            // 
            this.bsCoordTypes.DataMember = "CoordTypes";
            this.bsCoordTypes.DataSource = this.botDataSet;
            this.bsCoordTypes.CurrentChanged += new System.EventHandler(this.bsCoordTypes_CurrentChanged);
            // 
            // gbAutoAdd
            // 
            this.gbAutoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAutoAdd.Controls.Add(this.cbPlayerTarget);
            this.gbAutoAdd.Controls.Add(this.btnAddPlayerTargetCoord);
            this.gbAutoAdd.Controls.Add(this.label9);
            this.gbAutoAdd.Location = new System.Drawing.Point(179, 440);
            this.gbAutoAdd.Name = "gbAutoAdd";
            this.gbAutoAdd.Size = new System.Drawing.Size(189, 47);
            this.gbAutoAdd.TabIndex = 76;
            this.gbAutoAdd.TabStop = false;
            this.gbAutoAdd.Text = "Auto Add";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // GameObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(718, 493);
            this.Controls.Add(this.labelWoWVersion);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.gbDebug);
            this.Controls.Add(this.gbAutoAdd);
            this.Controls.Add(this.btnAddQuest);
            this.Controls.Add(this.gbAddCoord);
            this.Controls.Add(this.gbCoordinates);
            this.Controls.Add(this.lbGameObjList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewObj);
            this.Controls.Add(this.cbItemList);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.gbQuestList);
            this.Controls.Add(this.btnAddNPC);
            this.Controls.Add(this.btnAddItem);
            this.MinimumSize = new System.Drawing.Size(625, 490);
            this.Name = "GameObjectsForm";
            this.Text = "NPC List";
            this.Load += new System.EventHandler(this.GameObjectsForm_Load);
            this.Activated += new System.EventHandler(this.GameObjectsForm_Activated);
            this.Controls.SetChildIndex(this.btnAddItem, 0);
            this.Controls.SetChildIndex(this.btnAddNPC, 0);
            this.Controls.SetChildIndex(this.gbQuestList, 0);
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.cbItemList, 0);
            this.Controls.SetChildIndex(this.btnAddNewObj, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lbGameObjList, 0);
            this.Controls.SetChildIndex(this.gbCoordinates, 0);
            this.Controls.SetChildIndex(this.gbAddCoord, 0);
            this.Controls.SetChildIndex(this.btnAddQuest, 0);
            this.Controls.SetChildIndex(this.gbAutoAdd, 0);
            this.Controls.SetChildIndex(this.gbDebug, 0);
            this.Controls.SetChildIndex(this.btnImport, 0);
            this.Controls.SetChildIndex(this.gbDescription, 0);
            this.Controls.SetChildIndex(this.labelWoWVersion, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.popGameObject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGameObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botDataSet)).EndInit();
            this.gbDescription.ResumeLayout(false);
            this.gbDescription.PerformLayout();
            this.popServiceActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fkGameObjectsNpcServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTypesFiltered)).EndInit();
            this.popCoordinates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKCoordinatesZoneCoordinates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGameObjectsCoordinatesZone)).EndInit();
            this.gbQuestList.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.popQuestItemActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestListQuestItemsObjectives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkGameObjectsQuestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestListQuestItemsChoice)).EndInit();
            this.popQuestActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTypesFull)).EndInit();
            this.gbDebug.ResumeLayout(false);
            this.gbDebug.PerformLayout();
            this.gbCoordinates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsZoneList)).EndInit();
            this.gbAddCoord.ResumeLayout(false);
            this.gbAddCoord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoordTypes)).EndInit();
            this.gbAutoAdd.ResumeLayout(false);
            this.gbAutoAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox lbGameObjList;
        private System.Windows.Forms.Label labelWoWVersion;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.ListBox lbActiveServices;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ComboBox cbAvailServices;
        private System.Windows.Forms.Button btnAddNPC;
        private System.Windows.Forms.ComboBox cbServiceList;
        private System.Windows.Forms.Button btnMoveToNearest;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.ContextMenuStrip popServiceActions;
        private System.Windows.Forms.ContextMenuStrip popQuestActions;
        private System.Windows.Forms.ToolStripMenuItem deleteQuestToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip popGameObject;
        private System.Windows.Forms.ToolStripMenuItem deleteGameObjectToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbDebug;
        private System.Windows.Forms.CheckBox cbUseState;
        private System.Windows.Forms.CheckBox cbLearnSkills;
        private System.Windows.Forms.ToolStripMenuItem deleteServiceToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbQuestList;
        private System.Windows.Forms.Button btnAddQuest;
        private System.Windows.Forms.GroupBox gbCoordinates;
        private System.Windows.Forms.Button btnAddCoord;
        private System.Windows.Forms.ListBox lbCoordinates;
        private System.Windows.Forms.Button btnAddNewObj;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cbItemList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsGameObjects;
        private BabBot.Data.BotDataSet botDataSet;
        private System.Windows.Forms.BindingSource bsServiceTypesFiltered;
        private System.Windows.Forms.BindingSource fkGameObjectsNpcServices;
        private System.Windows.Forms.ContextMenuStrip popCoordinates;
        private System.Windows.Forms.ToolStripMenuItem deleteCoordinatesToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsServiceTypesFull;
        private System.Windows.Forms.ListBox lbQuestList;
        private System.Windows.Forms.BindingSource fkGameObjectsQuestList;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceptQuestToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbAllZones;
        private System.Windows.Forms.GroupBox gbAddCoord;
        private System.Windows.Forms.ComboBox cbPlayerTarget;
        private System.Windows.Forms.ComboBox cbCoordZone;
        private System.Windows.Forms.Button btnAddPlayerTargetCoord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource fKGameObjectsCoordinatesZone;
        private System.Windows.Forms.BindingSource bsZoneList;
        private System.Windows.Forms.BindingSource fKCoordinatesZoneCoordinates;
        private System.Windows.Forms.GroupBox gbAutoAdd;
        private System.Windows.Forms.ToolStripMenuItem moveToObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox tbDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCoordType;
        private System.Windows.Forms.BindingSource bsCoordTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFaction;
        private System.Windows.Forms.ToolStripMenuItem executeQuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliverQuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbQuestItems;
        private System.Windows.Forms.BindingSource fKQuestListQuestItemsChoice;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ContextMenuStrip popQuestItemActions;
        private System.Windows.Forms.ToolStripMenuItem recordRouteFromNPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordRouteToNPCToolStripMenuItem;
        private System.Windows.Forms.ListBox lbQuestObjectives;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource fKQuestListQuestItemsObjectives;
        private System.Windows.Forms.ToolStripMenuItem bindToInnToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
