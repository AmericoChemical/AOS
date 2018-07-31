<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditAPIS

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FormulaidLabel As System.Windows.Forms.Label
        Dim FormuladescLabel As System.Windows.Forms.Label
        Dim StdlaborhoursLabel As System.Windows.Forms.Label
        Dim FormulanotesLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditAPIS))
        Me.bsAPIS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewInput = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditInput = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteInput = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewProcessStep = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditProcessStep = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteProcessStep = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintFormulaSheet = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddAPISNote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditAPISNote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteAPISNote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkAPISAsActive = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkAsSingleUse = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkAsArchived = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReviewCosts = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.pnlAPISProcessesNotes = New DevExpress.XtraEditors.PanelControl()
        Me.gcAPISNotes = New DevExpress.XtraEditors.GroupControl()
        Me.grAPISNotes = New DevExpress.XtraGrid.GridControl()
        Me.bsNotes = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colApisnoteid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisnote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.eTotalWeight = New DevExpress.XtraEditors.TextEdit()
        Me.eTotalVolume = New DevExpress.XtraEditors.TextEdit()
        Me.gcAPISProcesses = New DevExpress.XtraEditors.GroupControl()
        Me.grAPISProcesses = New DevExpress.XtraGrid.GridControl()
        Me.bsProcesses = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colApisprocnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisnum1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSequence1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisprocedure = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.pnlFormulaInputs = New DevExpress.XtraEditors.PanelControl()
        Me.grFormulaInputs = New DevExpress.XtraEditors.GroupControl()
        Me.grAPISInputs = New DevExpress.XtraGrid.GridControl()
        Me.bsInputs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colApisitemnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisnum2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsMaterials = New System.Windows.Forms.BindingSource(Me.components)
        Me.colQtyunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisitemnote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourceproductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsProductList = New System.Windows.Forms.BindingSource(Me.components)
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.pnlFormulaInfo = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eKitDescription = New DevExpress.XtraEditors.TextEdit()
        Me.eKitID = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsKitList = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.lblModified = New DevExpress.XtraEditors.LabelControl()
        Me.lblCreated = New DevExpress.XtraEditors.LabelControl()
        Me.eUOM = New DevExpress.XtraEditors.TextEdit()
        Me.eUnits = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.eProductDesc = New DevExpress.XtraEditors.TextEdit()
        Me.FormuladescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.LookUpEdit()
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCustomerList = New System.Windows.Forms.BindingSource(Me.components)
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.FormulanotesTextEdit = New DevExpress.XtraEditors.MemoEdit()
        FormulaidLabel = New System.Windows.Forms.Label()
        FormuladescLabel = New System.Windows.Forms.Label()
        StdlaborhoursLabel = New System.Windows.Forms.Label()
        FormulanotesLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.bsAPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.pnlAPISProcessesNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAPISProcessesNotes.SuspendLayout()
        CType(Me.gcAPISNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcAPISNotes.SuspendLayout()
        CType(Me.grAPISNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.eTotalWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eTotalVolume.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAPISProcesses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcAPISProcesses.SuspendLayout()
        CType(Me.grAPISProcesses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProcesses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlFormulaInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFormulaInputs.SuspendLayout()
        CType(Me.grFormulaInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grFormulaInputs.SuspendLayout()
        CType(Me.grAPISInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlFormulaInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFormulaInfo.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eKitDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eKitID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKitList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormuladescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulanotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormulaidLabel
        '
        FormulaidLabel.AutoSize = True
        FormulaidLabel.Location = New System.Drawing.Point(39, 35)
        FormulaidLabel.Name = "FormulaidLabel"
        FormulaidLabel.Size = New System.Drawing.Size(48, 13)
        FormulaidLabel.TabIndex = 0
        FormulaidLabel.Text = "APIS ID:"
        '
        'FormuladescLabel
        '
        FormuladescLabel.AutoSize = True
        FormuladescLabel.Location = New System.Drawing.Point(194, 34)
        FormuladescLabel.Name = "FormuladescLabel"
        FormuladescLabel.Size = New System.Drawing.Size(51, 13)
        FormuladescLabel.TabIndex = 2
        FormuladescLabel.Text = "Revision:"
        '
        'StdlaborhoursLabel
        '
        StdlaborhoursLabel.AutoSize = True
        StdlaborhoursLabel.Location = New System.Drawing.Point(26, 114)
        StdlaborhoursLabel.Name = "StdlaborhoursLabel"
        StdlaborhoursLabel.Size = New System.Drawing.Size(76, 13)
        StdlaborhoursLabel.TabIndex = 10
        StdlaborhoursLabel.Text = "Std Labor Hrs:"
        '
        'FormulanotesLabel
        '
        FormulanotesLabel.AutoSize = True
        FormulanotesLabel.Location = New System.Drawing.Point(633, 87)
        FormulanotesLabel.Name = "FormulanotesLabel"
        FormulanotesLabel.Size = New System.Drawing.Size(39, 13)
        FormulanotesLabel.TabIndex = 14
        FormulanotesLabel.Text = "Notes:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 61)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(90, 13)
        Label1.TabIndex = 16
        Label1.Text = "Finished Product:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(615, 61)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 13)
        Label2.TabIndex = 17
        Label2.Text = "Customer:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(341, 87)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(34, 13)
        Label3.TabIndex = 23
        Label3.Text = "UOM:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(447, 87)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(96, 13)
        Label4.TabIndex = 24
        Label4.Text = "Units in Container:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(187, 87)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(58, 13)
        Label5.TabIndex = 25
        Label5.Text = "Container:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(630, 35)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(42, 13)
        Label6.TabIndex = 29
        Label6.Text = "Status:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(192, 114)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(53, 13)
        Label7.TabIndex = 33
        Label7.Text = "Comp Kit:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(30, 9)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(74, 13)
        Label8.TabIndex = 21
        Label8.Text = "Total VOLUME"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(199, 9)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(74, 13)
        Label9.TabIndex = 23
        Label9.Text = "Total WEIGHT"
        '
        'bsAPIS
        '
        Me.bsAPIS.DataSource = GetType(AOS.BusinessObjects.Apis)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnAddNewInput, Me.btnEditInput, Me.btnDeleteInput, Me.rbtnAddNewProcessStep, Me.rbtnEditProcessStep, Me.rbtnDeleteProcessStep, Me.rbtnPrintFormulaSheet, Me.rbtnAddAPISNote, Me.rbtnEditAPISNote, Me.rbtnDeleteAPISNote, Me.rbtnMarkAPISAsActive, Me.rbtnMarkAsSingleUse, Me.rbtnMarkAsArchived, Me.rbtnReviewCosts})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 20
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1014, 116)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 0
        Me.btnSave.ImageOptions.LargeImageIndex = 5
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 1
        Me.btnCancel.ImageOptions.LargeImageIndex = 6
        Me.btnCancel.Name = "btnCancel"
        '
        'btnAddNewInput
        '
        Me.btnAddNewInput.Caption = "Add New Input"
        Me.btnAddNewInput.Id = 2
        Me.btnAddNewInput.ImageOptions.LargeImageIndex = 11
        Me.btnAddNewInput.Name = "btnAddNewInput"
        '
        'btnEditInput
        '
        Me.btnEditInput.Caption = " Edit  Input"
        Me.btnEditInput.Id = 3
        Me.btnEditInput.ImageOptions.LargeImageIndex = 12
        Me.btnEditInput.Name = "btnEditInput"
        '
        'btnDeleteInput
        '
        Me.btnDeleteInput.Caption = "Delete Input"
        Me.btnDeleteInput.Id = 4
        Me.btnDeleteInput.ImageOptions.LargeImageIndex = 13
        Me.btnDeleteInput.Name = "btnDeleteInput"
        '
        'rbtnAddNewProcessStep
        '
        Me.rbtnAddNewProcessStep.Caption = "Add New Process Step"
        Me.rbtnAddNewProcessStep.Id = 8
        Me.rbtnAddNewProcessStep.ImageOptions.LargeImageIndex = 17
        Me.rbtnAddNewProcessStep.Name = "rbtnAddNewProcessStep"
        '
        'rbtnEditProcessStep
        '
        Me.rbtnEditProcessStep.Caption = " Edit  Process Step"
        Me.rbtnEditProcessStep.Id = 9
        Me.rbtnEditProcessStep.ImageOptions.LargeImageIndex = 18
        Me.rbtnEditProcessStep.Name = "rbtnEditProcessStep"
        '
        'rbtnDeleteProcessStep
        '
        Me.rbtnDeleteProcessStep.Caption = "Delete Process Step"
        Me.rbtnDeleteProcessStep.Id = 10
        Me.rbtnDeleteProcessStep.ImageOptions.LargeImageIndex = 19
        Me.rbtnDeleteProcessStep.Name = "rbtnDeleteProcessStep"
        '
        'rbtnPrintFormulaSheet
        '
        Me.rbtnPrintFormulaSheet.Caption = "Print APIS Sheet"
        Me.rbtnPrintFormulaSheet.Id = 12
        Me.rbtnPrintFormulaSheet.ImageOptions.LargeImageIndex = 7
        Me.rbtnPrintFormulaSheet.Name = "rbtnPrintFormulaSheet"
        '
        'rbtnAddAPISNote
        '
        Me.rbtnAddAPISNote.Caption = "Add New Note"
        Me.rbtnAddAPISNote.Id = 13
        Me.rbtnAddAPISNote.ImageOptions.LargeImageIndex = 14
        Me.rbtnAddAPISNote.Name = "rbtnAddAPISNote"
        '
        'rbtnEditAPISNote
        '
        Me.rbtnEditAPISNote.Caption = " Edit  Note"
        Me.rbtnEditAPISNote.Id = 14
        Me.rbtnEditAPISNote.ImageOptions.LargeImageIndex = 15
        Me.rbtnEditAPISNote.Name = "rbtnEditAPISNote"
        '
        'rbtnDeleteAPISNote
        '
        Me.rbtnDeleteAPISNote.Caption = "Delete Note"
        Me.rbtnDeleteAPISNote.Id = 15
        Me.rbtnDeleteAPISNote.ImageOptions.LargeImageIndex = 16
        Me.rbtnDeleteAPISNote.Name = "rbtnDeleteAPISNote"
        '
        'rbtnMarkAPISAsActive
        '
        Me.rbtnMarkAPISAsActive.Caption = "Mark as Active"
        Me.rbtnMarkAPISAsActive.Id = 16
        Me.rbtnMarkAPISAsActive.ImageOptions.LargeImageIndex = 8
        Me.rbtnMarkAPISAsActive.Name = "rbtnMarkAPISAsActive"
        '
        'rbtnMarkAsSingleUse
        '
        Me.rbtnMarkAsSingleUse.Caption = "Mark as Single Use"
        Me.rbtnMarkAsSingleUse.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnMarkAsSingleUse.Id = 17
        Me.rbtnMarkAsSingleUse.ImageOptions.LargeImageIndex = 8
        Me.rbtnMarkAsSingleUse.Name = "rbtnMarkAsSingleUse"
        '
        'rbtnMarkAsArchived
        '
        Me.rbtnMarkAsArchived.Caption = "Mark as Archived"
        Me.rbtnMarkAsArchived.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnMarkAsArchived.Id = 18
        Me.rbtnMarkAsArchived.ImageOptions.LargeImageIndex = 8
        Me.rbtnMarkAsArchived.Name = "rbtnMarkAsArchived"
        '
        'rbtnReviewCosts
        '
        Me.rbtnReviewCosts.Caption = "Standard Cost Calculation"
        Me.rbtnReviewCosts.Id = 19
        Me.rbtnReviewCosts.ImageOptions.LargeImageIndex = 9
        Me.rbtnReviewCosts.Name = "rbtnReviewCosts"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup4, Me.RibbonPageGroup5, Me.RibbonPageGroup3, Me.RibbonPageGroup6, Me.RibbonPageGroup7})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "APIS"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddNewInput)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditInput)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeleteInput)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "APIS Inputs"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnAddNewProcessStep)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnEditProcessStep)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnDeleteProcessStep)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "APIS Processes"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnAddAPISNote)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnEditAPISNote)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnDeleteAPISNote)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "APIS Notes"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnPrintFormulaSheet, True)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Reports"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowMinimize = False
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnMarkAPISAsActive)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnMarkAsSingleUse)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnMarkAsArchived)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Status"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowMinimize = False
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnReviewCosts)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Review"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.pnlAPISProcessesNotes)
        Me.PanelControl1.Controls.Add(Me.pnlFormulaInputs)
        Me.PanelControl1.Controls.Add(Me.pnlFormulaInfo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 116)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1014, 622)
        Me.PanelControl1.TabIndex = 1
        '
        'pnlAPISProcessesNotes
        '
        Me.pnlAPISProcessesNotes.Controls.Add(Me.gcAPISNotes)
        Me.pnlAPISProcessesNotes.Controls.Add(Me.gcAPISProcesses)
        Me.pnlAPISProcessesNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAPISProcessesNotes.Location = New System.Drawing.Point(0, 335)
        Me.pnlAPISProcessesNotes.Name = "pnlAPISProcessesNotes"
        Me.pnlAPISProcessesNotes.Size = New System.Drawing.Size(1014, 287)
        Me.pnlAPISProcessesNotes.TabIndex = 8
        '
        'gcAPISNotes
        '
        Me.gcAPISNotes.Controls.Add(Me.grAPISNotes)
        Me.gcAPISNotes.Controls.Add(Me.PanelControl2)
        Me.gcAPISNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAPISNotes.Location = New System.Drawing.Point(504, 2)
        Me.gcAPISNotes.Name = "gcAPISNotes"
        Me.gcAPISNotes.Size = New System.Drawing.Size(508, 283)
        Me.gcAPISNotes.TabIndex = 2
        Me.gcAPISNotes.Text = "APIS Notes"
        '
        'grAPISNotes
        '
        Me.grAPISNotes.DataSource = Me.bsNotes
        Me.grAPISNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAPISNotes.Location = New System.Drawing.Point(2, 22)
        Me.grAPISNotes.MainView = Me.GridView3
        Me.grAPISNotes.Name = "grAPISNotes"
        Me.grAPISNotes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit7, Me.RepositoryItemLookUpEdit8, Me.RepositoryItemLookUpEdit9, Me.RepositoryItemCheckEdit3, Me.RepositoryItemLookUpEdit10})
        Me.grAPISNotes.Size = New System.Drawing.Size(504, 226)
        Me.grAPISNotes.TabIndex = 5
        Me.grAPISNotes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'bsNotes
        '
        Me.bsNotes.DataSource = GetType(AOS.BusinessObjects.ApisnoteCollection)
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colApisnoteid, Me.colApisnum, Me.colSequence, Me.colApisnote})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.grAPISNotes
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colApisnoteid
        '
        Me.colApisnoteid.FieldName = "Apisnoteid"
        Me.colApisnoteid.Name = "colApisnoteid"
        '
        'colApisnum
        '
        Me.colApisnum.FieldName = "Apisnum"
        Me.colApisnum.Name = "colApisnum"
        '
        'colSequence
        '
        Me.colSequence.Caption = "Seq"
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        Me.colSequence.Visible = True
        Me.colSequence.VisibleIndex = 0
        Me.colSequence.Width = 39
        '
        'colApisnote
        '
        Me.colApisnote.Caption = "Note"
        Me.colApisnote.FieldName = "Apisnote"
        Me.colApisnote.Name = "colApisnote"
        Me.colApisnote.Visible = True
        Me.colApisnote.VisibleIndex = 1
        Me.colApisnote.Width = 443
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.AutoHeight = False
        Me.RepositoryItemLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit7.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit7.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.NullText = ""
        Me.RepositoryItemLookUpEdit7.ReadOnly = True
        Me.RepositoryItemLookUpEdit7.ShowFooter = False
        Me.RepositoryItemLookUpEdit7.ShowHeader = False
        Me.RepositoryItemLookUpEdit7.ShowLines = False
        Me.RepositoryItemLookUpEdit7.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit8.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit8.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        Me.RepositoryItemLookUpEdit8.NullText = ""
        Me.RepositoryItemLookUpEdit8.ReadOnly = True
        Me.RepositoryItemLookUpEdit8.ShowFooter = False
        Me.RepositoryItemLookUpEdit8.ShowHeader = False
        Me.RepositoryItemLookUpEdit8.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit9
        '
        Me.RepositoryItemLookUpEdit9.AutoHeight = False
        Me.RepositoryItemLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit9.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit9.Name = "RepositoryItemLookUpEdit9"
        Me.RepositoryItemLookUpEdit9.NullText = ""
        Me.RepositoryItemLookUpEdit9.ReadOnly = True
        Me.RepositoryItemLookUpEdit9.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'RepositoryItemLookUpEdit10
        '
        Me.RepositoryItemLookUpEdit10.AutoHeight = False
        Me.RepositoryItemLookUpEdit10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit10.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit10.Name = "RepositoryItemLookUpEdit10"
        Me.RepositoryItemLookUpEdit10.NullText = ""
        Me.RepositoryItemLookUpEdit10.ValueMember = "Productid"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.eTotalWeight)
        Me.PanelControl2.Controls.Add(Label9)
        Me.PanelControl2.Controls.Add(Me.eTotalVolume)
        Me.PanelControl2.Controls.Add(Label8)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 248)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(504, 33)
        Me.PanelControl2.TabIndex = 6
        '
        'eTotalWeight
        '
        Me.eTotalWeight.Location = New System.Drawing.Point(281, 6)
        Me.eTotalWeight.MenuManager = Me.RibbonControl1
        Me.eTotalWeight.Name = "eTotalWeight"
        Me.eTotalWeight.Size = New System.Drawing.Size(73, 20)
        Me.eTotalWeight.TabIndex = 24
        '
        'eTotalVolume
        '
        Me.eTotalVolume.Location = New System.Drawing.Point(112, 6)
        Me.eTotalVolume.MenuManager = Me.RibbonControl1
        Me.eTotalVolume.Name = "eTotalVolume"
        Me.eTotalVolume.Size = New System.Drawing.Size(73, 20)
        Me.eTotalVolume.TabIndex = 22
        '
        'gcAPISProcesses
        '
        Me.gcAPISProcesses.Controls.Add(Me.grAPISProcesses)
        Me.gcAPISProcesses.Dock = System.Windows.Forms.DockStyle.Left
        Me.gcAPISProcesses.Location = New System.Drawing.Point(2, 2)
        Me.gcAPISProcesses.Name = "gcAPISProcesses"
        Me.gcAPISProcesses.Size = New System.Drawing.Size(502, 283)
        Me.gcAPISProcesses.TabIndex = 1
        Me.gcAPISProcesses.Text = "APIS Processes"
        '
        'grAPISProcesses
        '
        Me.grAPISProcesses.DataSource = Me.bsProcesses
        Me.grAPISProcesses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAPISProcesses.Location = New System.Drawing.Point(2, 22)
        Me.grAPISProcesses.MainView = Me.GridView2
        Me.grAPISProcesses.Name = "grAPISProcesses"
        Me.grAPISProcesses.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemCheckEdit2, Me.RepositoryItemLookUpEdit4})
        Me.grAPISProcesses.Size = New System.Drawing.Size(498, 259)
        Me.grAPISProcesses.TabIndex = 5
        Me.grAPISProcesses.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsProcesses
        '
        Me.bsProcesses.DataSource = GetType(AOS.BusinessObjects.ApisprocedureCollection)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colApisprocnum, Me.colApisnum1, Me.colSequence1, Me.colApisprocedure})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.grAPISProcesses
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colApisprocnum
        '
        Me.colApisprocnum.FieldName = "Apisprocnum"
        Me.colApisprocnum.Name = "colApisprocnum"
        '
        'colApisnum1
        '
        Me.colApisnum1.FieldName = "Apisnum"
        Me.colApisnum1.Name = "colApisnum1"
        '
        'colSequence1
        '
        Me.colSequence1.Caption = "Seq"
        Me.colSequence1.FieldName = "Sequence"
        Me.colSequence1.Name = "colSequence1"
        Me.colSequence1.Visible = True
        Me.colSequence1.VisibleIndex = 0
        Me.colSequence1.Width = 43
        '
        'colApisprocedure
        '
        Me.colApisprocedure.Caption = "Process Description"
        Me.colApisprocedure.FieldName = "Apisprocedure"
        Me.colApisprocedure.Name = "colApisprocedure"
        Me.colApisprocedure.Visible = True
        Me.colApisprocedure.VisibleIndex = 1
        Me.colApisprocedure.Width = 439
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ReadOnly = True
        Me.RepositoryItemLookUpEdit2.ShowFooter = False
        Me.RepositoryItemLookUpEdit2.ShowHeader = False
        Me.RepositoryItemLookUpEdit2.ShowLines = False
        Me.RepositoryItemLookUpEdit2.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ReadOnly = True
        Me.RepositoryItemLookUpEdit3.ShowFooter = False
        Me.RepositoryItemLookUpEdit3.ShowHeader = False
        Me.RepositoryItemLookUpEdit3.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ReadOnly = True
        Me.RepositoryItemLookUpEdit5.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ValueMember = "Productid"
        '
        'pnlFormulaInputs
        '
        Me.pnlFormulaInputs.Controls.Add(Me.grFormulaInputs)
        Me.pnlFormulaInputs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormulaInputs.Location = New System.Drawing.Point(0, 141)
        Me.pnlFormulaInputs.Name = "pnlFormulaInputs"
        Me.pnlFormulaInputs.Size = New System.Drawing.Size(1014, 194)
        Me.pnlFormulaInputs.TabIndex = 6
        '
        'grFormulaInputs
        '
        Me.grFormulaInputs.Controls.Add(Me.grAPISInputs)
        Me.grFormulaInputs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grFormulaInputs.Location = New System.Drawing.Point(2, 2)
        Me.grFormulaInputs.Name = "grFormulaInputs"
        Me.grFormulaInputs.Size = New System.Drawing.Size(1010, 190)
        Me.grFormulaInputs.TabIndex = 0
        Me.grFormulaInputs.Text = "APIS Inputs"
        '
        'grAPISInputs
        '
        Me.grAPISInputs.DataSource = Me.bsInputs
        Me.grAPISInputs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAPISInputs.Location = New System.Drawing.Point(2, 22)
        Me.grAPISInputs.MainView = Me.GridView1
        Me.grAPISInputs.Name = "grAPISInputs"
        Me.grAPISInputs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit6, Me.RepositoryItemLookUpEdit11, Me.RepositoryItemLookUpEdit12})
        Me.grAPISInputs.Size = New System.Drawing.Size(1006, 166)
        Me.grAPISInputs.TabIndex = 5
        Me.grAPISInputs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsInputs
        '
        Me.bsInputs.DataSource = GetType(AOS.BusinessObjects.ApisitemCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colApisitemnum, Me.colApisnum2, Me.colMaterialid, Me.GridColumn2, Me.colQtyunits, Me.colUom, Me.colApisitemnote, Me.colSourceproductid, Me.GridColumn1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.grAPISInputs
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colApisitemnum
        '
        Me.colApisitemnum.FieldName = "Apisitemnum"
        Me.colApisitemnum.Name = "colApisitemnum"
        '
        'colApisnum2
        '
        Me.colApisnum2.FieldName = "Apisnum"
        Me.colApisnum2.Name = "colApisnum2"
        '
        'colMaterialid
        '
        Me.colMaterialid.Caption = "Matl ID"
        Me.colMaterialid.FieldName = "Materialid"
        Me.colMaterialid.Name = "colMaterialid"
        Me.colMaterialid.Visible = True
        Me.colMaterialid.VisibleIndex = 0
        Me.colMaterialid.Width = 56
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Material Description"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemLookUpEdit12
        Me.GridColumn2.FieldName = "Materialid"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 272
        '
        'RepositoryItemLookUpEdit12
        '
        Me.RepositoryItemLookUpEdit12.AutoHeight = False
        Me.RepositoryItemLookUpEdit12.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialid", "ID", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialdesc", "Material Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialuom", "UOM", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit12.DataSource = Me.bsMaterials
        Me.RepositoryItemLookUpEdit12.DisplayMember = "Materialdesc"
        Me.RepositoryItemLookUpEdit12.Name = "RepositoryItemLookUpEdit12"
        Me.RepositoryItemLookUpEdit12.NullText = ""
        Me.RepositoryItemLookUpEdit12.ValueMember = "Materialid"
        '
        'bsMaterials
        '
        Me.bsMaterials.DataSource = GetType(AOS.BusinessObjects.MaterialCollection)
        '
        'colQtyunits
        '
        Me.colQtyunits.Caption = "Qty"
        Me.colQtyunits.FieldName = "Qtyunits"
        Me.colQtyunits.Name = "colQtyunits"
        Me.colQtyunits.Visible = True
        Me.colQtyunits.VisibleIndex = 2
        Me.colQtyunits.Width = 44
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 3
        Me.colUom.Width = 49
        '
        'colApisitemnote
        '
        Me.colApisitemnote.Caption = "Notes"
        Me.colApisitemnote.FieldName = "Apisitemnote"
        Me.colApisitemnote.Name = "colApisitemnote"
        Me.colApisitemnote.Visible = True
        Me.colApisitemnote.VisibleIndex = 6
        Me.colApisitemnote.Width = 200
        '
        'colSourceproductid
        '
        Me.colSourceproductid.Caption = "Source ID"
        Me.colSourceproductid.FieldName = "Sourceproductid"
        Me.colSourceproductid.Name = "colSourceproductid"
        Me.colSourceproductid.Visible = True
        Me.colSourceproductid.VisibleIndex = 4
        Me.colSourceproductid.Width = 80
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Source Desc"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit11
        Me.GridColumn1.FieldName = "Sourceproductid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 293
        '
        'RepositoryItemLookUpEdit11
        '
        Me.RepositoryItemLookUpEdit11.AutoHeight = False
        Me.RepositoryItemLookUpEdit11.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", "Desc 2", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit11.DataSource = Me.bsProductList
        Me.RepositoryItemLookUpEdit11.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit11.Name = "RepositoryItemLookUpEdit11"
        Me.RepositoryItemLookUpEdit11.NullText = ""
        Me.RepositoryItemLookUpEdit11.ShowFooter = False
        Me.RepositoryItemLookUpEdit11.ValueMember = "Productid"
        '
        'bsProductList
        '
        Me.bsProductList.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'luProductDesc
        '
        Me.luProductDesc.AutoHeight = False
        Me.luProductDesc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luProductDesc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luProductDesc.DisplayMember = "Productdesc"
        Me.luProductDesc.Name = "luProductDesc"
        Me.luProductDesc.NullText = ""
        Me.luProductDesc.ReadOnly = True
        Me.luProductDesc.ShowFooter = False
        Me.luProductDesc.ShowHeader = False
        Me.luProductDesc.ShowLines = False
        Me.luProductDesc.ValueMember = "Productid"
        '
        'luContainer
        '
        Me.luContainer.AutoHeight = False
        Me.luContainer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luContainer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luContainer.DisplayMember = "Container"
        Me.luContainer.Name = "luContainer"
        Me.luContainer.NullText = ""
        Me.luContainer.ReadOnly = True
        Me.luContainer.ShowFooter = False
        Me.luContainer.ShowHeader = False
        Me.luContainer.ValueMember = "Productid"
        '
        'luStdgallons
        '
        Me.luStdgallons.AutoHeight = False
        Me.luStdgallons.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luStdgallons.DisplayMember = "Stdgallons"
        Me.luStdgallons.Name = "luStdgallons"
        Me.luStdgallons.NullText = ""
        Me.luStdgallons.ReadOnly = True
        Me.luStdgallons.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.DataSource = Me.bsMaterials
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Materialdesc"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.ReadOnly = True
        Me.RepositoryItemLookUpEdit6.ValueMember = "Materialid"
        '
        'pnlFormulaInfo
        '
        Me.pnlFormulaInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlFormulaInfo.Controls.Add(Me.GroupControl1)
        Me.pnlFormulaInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormulaInfo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFormulaInfo.Name = "pnlFormulaInfo"
        Me.pnlFormulaInfo.Size = New System.Drawing.Size(1014, 141)
        Me.pnlFormulaInfo.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.eKitDescription)
        Me.GroupControl1.Controls.Add(Label7)
        Me.GroupControl1.Controls.Add(Me.eKitID)
        Me.GroupControl1.Controls.Add(Me.TextEdit4)
        Me.GroupControl1.Controls.Add(Label6)
        Me.GroupControl1.Controls.Add(Me.lblModified)
        Me.GroupControl1.Controls.Add(Me.lblCreated)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Me.eUOM)
        Me.GroupControl1.Controls.Add(Me.eUnits)
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(FormulanotesLabel)
        Me.GroupControl1.Controls.Add(Me.eProductDesc)
        Me.GroupControl1.Controls.Add(Me.FormuladescTextEdit)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Controls.Add(Me.CustidLookUpEdit)
        Me.GroupControl1.Controls.Add(FormulaidLabel)
        Me.GroupControl1.Controls.Add(StdlaborhoursLabel)
        Me.GroupControl1.Controls.Add(FormuladescLabel)
        Me.GroupControl1.Controls.Add(Me.eContainer)
        Me.GroupControl1.Controls.Add(Me.FormulanotesTextEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1014, 141)
        Me.GroupControl1.TabIndex = 14
        Me.GroupControl1.Text = "APIS Information"
        '
        'eKitDescription
        '
        Me.eKitDescription.Location = New System.Drawing.Point(344, 111)
        Me.eKitDescription.MenuManager = Me.RibbonControl1
        Me.eKitDescription.Name = "eKitDescription"
        Me.eKitDescription.Properties.ReadOnly = True
        Me.eKitDescription.Size = New System.Drawing.Size(248, 20)
        Me.eKitDescription.TabIndex = 34
        Me.eKitDescription.TabStop = False
        '
        'eKitID
        '
        Me.eKitID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Kitid", True))
        Me.eKitID.Location = New System.Drawing.Point(251, 111)
        Me.eKitID.MenuManager = Me.RibbonControl1
        Me.eKitID.Name = "eKitID"
        Me.eKitID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eKitID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kitid", "Kitid", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kitname", "Kitname", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eKitID.Properties.DataSource = Me.bsKitList
        Me.eKitID.Properties.DisplayMember = "Kitid"
        Me.eKitID.Properties.NullText = ""
        Me.eKitID.Properties.PopupWidth = 478
        Me.eKitID.Properties.ValueMember = "Kitid"
        Me.eKitID.Size = New System.Drawing.Size(73, 20)
        Me.eKitID.TabIndex = 31
        '
        'bsKitList
        '
        Me.bsKitList.DataSource = GetType(AOS.BusinessObjects.KitCollection)
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Apisstatus", True))
        Me.TextEdit4.Location = New System.Drawing.Point(678, 31)
        Me.TextEdit4.MenuManager = Me.RibbonControl1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(123, 20)
        Me.TextEdit4.TabIndex = 30
        Me.TextEdit4.TabStop = False
        '
        'lblModified
        '
        Me.lblModified.Appearance.Options.UseTextOptions = True
        Me.lblModified.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblModified.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblModified.Location = New System.Drawing.Point(587, 141)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(419, 0)
        Me.lblModified.TabIndex = 28
        '
        'lblCreated
        '
        Me.lblCreated.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblCreated.Location = New System.Drawing.Point(8, 141)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(419, 0)
        Me.lblCreated.TabIndex = 27
        '
        'eUOM
        '
        Me.eUOM.Location = New System.Drawing.Point(381, 84)
        Me.eUOM.MenuManager = Me.RibbonControl1
        Me.eUOM.Name = "eUOM"
        Me.eUOM.Properties.ReadOnly = True
        Me.eUOM.Size = New System.Drawing.Size(60, 20)
        Me.eUOM.TabIndex = 22
        Me.eUOM.TabStop = False
        '
        'eUnits
        '
        Me.eUnits.Location = New System.Drawing.Point(549, 84)
        Me.eUnits.MenuManager = Me.RibbonControl1
        Me.eUnits.Name = "eUnits"
        Me.eUnits.Properties.ReadOnly = True
        Me.eUnits.Size = New System.Drawing.Size(43, 20)
        Me.eUnits.TabIndex = 21
        Me.eUnits.TabStop = False
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Stdlaborhours", True))
        Me.TextEdit3.Location = New System.Drawing.Point(108, 111)
        Me.TextEdit3.MenuManager = Me.RibbonControl1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(73, 20)
        Me.TextEdit3.TabIndex = 20
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Qtycontainers", True))
        Me.TextEdit2.Location = New System.Drawing.Point(108, 84)
        Me.TextEdit2.MenuManager = Me.RibbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(73, 20)
        Me.TextEdit2.TabIndex = 19
        Me.TextEdit2.Visible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Apisnum", True))
        Me.TextEdit1.Location = New System.Drawing.Point(108, 31)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(73, 20)
        Me.TextEdit1.TabIndex = 18
        Me.TextEdit1.TabStop = False
        '
        'eProductDesc
        '
        Me.eProductDesc.Location = New System.Drawing.Point(187, 58)
        Me.eProductDesc.MenuManager = Me.RibbonControl1
        Me.eProductDesc.Name = "eProductDesc"
        Me.eProductDesc.Properties.ReadOnly = True
        Me.eProductDesc.Size = New System.Drawing.Size(405, 20)
        Me.eProductDesc.TabIndex = 14
        Me.eProductDesc.TabStop = False
        '
        'FormuladescTextEdit
        '
        Me.FormuladescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Revision", True))
        Me.FormuladescTextEdit.Location = New System.Drawing.Point(251, 31)
        Me.FormuladescTextEdit.MenuManager = Me.RibbonControl1
        Me.FormuladescTextEdit.Name = "FormuladescTextEdit"
        Me.FormuladescTextEdit.Size = New System.Drawing.Size(190, 20)
        Me.FormuladescTextEdit.TabIndex = 0
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(108, 58)
        Me.eProductID.MenuManager = Me.RibbonControl1
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", 75, "Prod ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", 200, "Product Description"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", 100, "Container")})
        Me.eProductID.Properties.DataSource = Me.bsProductList
        Me.eProductID.Properties.DisplayMember = "Productid"
        Me.eProductID.Properties.NullText = ""
        Me.eProductID.Properties.PopupWidth = 478
        Me.eProductID.Properties.ValueMember = "Productid"
        Me.eProductID.Size = New System.Drawing.Size(73, 20)
        Me.eProductID.TabIndex = 1
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Custid", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(678, 58)
        Me.CustidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", 200, "Customer Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", 100, "City")})
        Me.CustidLookUpEdit.Properties.DataSource = Me.bsCustomerList
        Me.CustidLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustidLookUpEdit.Properties.NullText = ""
        Me.CustidLookUpEdit.Properties.PopupWidth = 347
        Me.CustidLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(328, 20)
        Me.CustidLookUpEdit.TabIndex = 2
        '
        'bsCustomerList
        '
        Me.bsCustomerList.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(251, 84)
        Me.eContainer.MenuManager = Me.RibbonControl1
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(73, 20)
        Me.eContainer.TabIndex = 7
        Me.eContainer.TabStop = False
        '
        'FormulanotesTextEdit
        '
        Me.FormulanotesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAPIS, "Apisnote", True))
        Me.FormulanotesTextEdit.Location = New System.Drawing.Point(678, 84)
        Me.FormulanotesTextEdit.MenuManager = Me.RibbonControl1
        Me.FormulanotesTextEdit.Name = "FormulanotesTextEdit"
        Me.FormulanotesTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.FormulanotesTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.FormulanotesTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.FormulanotesTextEdit.Size = New System.Drawing.Size(328, 47)
        Me.FormulanotesTextEdit.TabIndex = 5
        '
        'frmAddEditAPIS
        '
        Me.ClientSize = New System.Drawing.Size(1014, 738)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditAPIS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "APIS - Americo Production Instruction Sheet"
        CType(Me.bsAPIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.pnlAPISProcessesNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAPISProcessesNotes.ResumeLayout(False)
        CType(Me.gcAPISNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcAPISNotes.ResumeLayout(False)
        CType(Me.grAPISNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.eTotalWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eTotalVolume.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAPISProcesses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcAPISProcesses.ResumeLayout(False)
        CType(Me.grAPISProcesses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProcesses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlFormulaInputs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFormulaInputs.ResumeLayout(False)
        CType(Me.grFormulaInputs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grFormulaInputs.ResumeLayout(False)
        CType(Me.grAPISInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlFormulaInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFormulaInfo.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eKitDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eKitID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKitList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormuladescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulanotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsAPIS As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlFormulaInfo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewInput As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditInput As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteInput As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FormuladescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsCustomerList As System.Windows.Forms.BindingSource
    Friend WithEvents bsProductList As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eProductDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlAPISProcessesNotes As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcAPISProcesses As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlFormulaInputs As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grFormulaInputs As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnAddNewProcessStep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditProcessStep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteProcessStep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintFormulaSheet As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsInputs As System.Windows.Forms.BindingSource
    Friend WithEvents bsProcesses As System.Windows.Forms.BindingSource
    Friend WithEvents grAPISProcesses As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grAPISInputs As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents luProductDesc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luContainer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luStdgallons As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsMaterials As System.Windows.Forms.BindingSource
    Friend WithEvents gcAPISNotes As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grAPISNotes As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsNotes As System.Windows.Forms.BindingSource
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents colApisnoteid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisnote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colApisprocnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisnum1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSequence1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisprocedure As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisitemnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisnum2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisitemnote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceproductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rbtnAddAPISNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditAPISNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteAPISNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FormulanotesTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblModified As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCreated As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rbtnMarkAPISAsActive As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnMarkAsSingleUse As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnMarkAsArchived As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eKitID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsKitList As System.Windows.Forms.BindingSource
    Friend WithEvents eKitDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents eTotalWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eTotalVolume As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnReviewCosts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
