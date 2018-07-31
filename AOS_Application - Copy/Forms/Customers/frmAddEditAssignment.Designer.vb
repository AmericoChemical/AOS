<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditAssignment

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
        Dim SalespersonIDLabel As System.Windows.Forms.Label
        Dim CustIDLabel As System.Windows.Forms.Label
        Dim CommissionRateLabel As System.Windows.Forms.Label
        Dim CommissionTypeLabel1 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SalespersonIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsSalespersons = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommissionRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CommissionTypeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCommTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSaveAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddException = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditException = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteException = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grExceptions = New DevExpress.XtraGrid.GridControl()
        Me.bsExceptions = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView8 = New CustomDevExGridView()
        Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCommissionRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grpAssignment = New DevExpress.XtraEditors.GroupControl()
        SalespersonIDLabel = New System.Windows.Forms.Label()
        CustIDLabel = New System.Windows.Forms.Label()
        CommissionRateLabel = New System.Windows.Forms.Label()
        CommissionTypeLabel1 = New System.Windows.Forms.Label()
        CType(Me.SalespersonIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalespersons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCommTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grExceptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsExceptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpAssignment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAssignment.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalespersonIDLabel
        '
        SalespersonIDLabel.AutoSize = True
        SalespersonIDLabel.Location = New System.Drawing.Point(7, 33)
        SalespersonIDLabel.Name = "SalespersonIDLabel"
        SalespersonIDLabel.Size = New System.Drawing.Size(65, 13)
        SalespersonIDLabel.TabIndex = 1
        SalespersonIDLabel.Text = "Salesperson"
        '
        'CustIDLabel
        '
        CustIDLabel.AutoSize = True
        CustIDLabel.Location = New System.Drawing.Point(7, 59)
        CustIDLabel.Name = "CustIDLabel"
        CustIDLabel.Size = New System.Drawing.Size(53, 13)
        CustIDLabel.TabIndex = 3
        CustIDLabel.Text = "Customer"
        '
        'CommissionRateLabel
        '
        CommissionRateLabel.AutoSize = True
        CommissionRateLabel.Location = New System.Drawing.Point(7, 111)
        CommissionRateLabel.Name = "CommissionRateLabel"
        CommissionRateLabel.Size = New System.Drawing.Size(88, 13)
        CommissionRateLabel.TabIndex = 7
        CommissionRateLabel.Text = "Commission Rate"
        '
        'CommissionTypeLabel1
        '
        CommissionTypeLabel1.AutoSize = True
        CommissionTypeLabel1.Location = New System.Drawing.Point(7, 85)
        CommissionTypeLabel1.Name = "CommissionTypeLabel1"
        CommissionTypeLabel1.Size = New System.Drawing.Size(89, 13)
        CommissionTypeLabel1.TabIndex = 8
        CommissionTypeLabel1.Text = "Commission Type"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SalespersonIDLookUpEdit
        '
        Me.SalespersonIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "SalespersonID", True))
        Me.SalespersonIDLookUpEdit.Location = New System.Drawing.Point(99, 27)
        Me.SalespersonIDLookUpEdit.Name = "SalespersonIDLookUpEdit"
        Me.SalespersonIDLookUpEdit.Properties.DataSource = Me.bsSalespersons
        Me.SalespersonIDLookUpEdit.Properties.DisplayMember = "Salespersonfullname"
        Me.SalespersonIDLookUpEdit.Properties.NullText = ""
        Me.SalespersonIDLookUpEdit.Properties.ReadOnly = True
        Me.SalespersonIDLookUpEdit.Properties.ValueMember = "Salespersonid"
        Me.SalespersonIDLookUpEdit.Size = New System.Drawing.Size(300, 20)
        Me.SalespersonIDLookUpEdit.TabIndex = 2
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.Customerassignment)
        '
        'bsSalespersons
        '
        Me.bsSalespersons.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'CustIDLookUpEdit
        '
        Me.CustIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "CustID", True))
        Me.CustIDLookUpEdit.Location = New System.Drawing.Point(99, 53)
        Me.CustIDLookUpEdit.Name = "CustIDLookUpEdit"
        Me.CustIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 110, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustIDLookUpEdit.Properties.DataSource = Me.bsCustomers
        Me.CustIDLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustIDLookUpEdit.Properties.NullText = ""
        Me.CustIDLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustIDLookUpEdit.Size = New System.Drawing.Size(300, 20)
        Me.CustIDLookUpEdit.TabIndex = 4
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'CommissionRateTextEdit
        '
        Me.CommissionRateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "CommissionRate", True))
        Me.CommissionRateTextEdit.Location = New System.Drawing.Point(99, 105)
        Me.CommissionRateTextEdit.Name = "CommissionRateTextEdit"
        Me.CommissionRateTextEdit.Properties.DisplayFormat.FormatString = "P"
        Me.CommissionRateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CommissionRateTextEdit.Size = New System.Drawing.Size(53, 20)
        Me.CommissionRateTextEdit.TabIndex = 8
        '
        'CommissionTypeLookUpEdit
        '
        Me.CommissionTypeLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "CommissionType", True))
        Me.CommissionTypeLookUpEdit.Location = New System.Drawing.Point(99, 79)
        Me.CommissionTypeLookUpEdit.Name = "CommissionTypeLookUpEdit"
        Me.CommissionTypeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommissionTypeLookUpEdit.Properties.DataSource = Me.bsCommTypes
        Me.CommissionTypeLookUpEdit.Properties.DisplayMember = "Commissiontype"
        Me.CommissionTypeLookUpEdit.Properties.DropDownRows = 4
        Me.CommissionTypeLookUpEdit.Properties.NullText = ""
        Me.CommissionTypeLookUpEdit.Properties.ShowFooter = False
        Me.CommissionTypeLookUpEdit.Properties.ShowHeader = False
        Me.CommissionTypeLookUpEdit.Properties.ValueMember = "Commissiontype"
        Me.CommissionTypeLookUpEdit.Size = New System.Drawing.Size(75, 20)
        Me.CommissionTypeLookUpEdit.TabIndex = 9
        '
        'bsCommTypes
        '
        Me.bsCommTypes.DataSource = GetType(AOS.BusinessObjects.ListCommissiontypeCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSaveAssignment, Me.btnCancelAssignment, Me.btnAddException, Me.btnEditException, Me.btnDeleteException})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(436, 96)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSaveAssignment
        '
        Me.btnSaveAssignment.Caption = "Save"
        Me.btnSaveAssignment.Id = 0
        Me.btnSaveAssignment.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSaveAssignment.Name = "btnSaveAssignment"
        '
        'btnCancelAssignment
        '
        Me.btnCancelAssignment.Caption = "Cancel"
        Me.btnCancelAssignment.Id = 1
        Me.btnCancelAssignment.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancelAssignment.Name = "btnCancelAssignment"
        '
        'btnAddException
        '
        Me.btnAddException.Caption = "Add Exception"
        Me.btnAddException.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddException.Id = 2
        Me.btnAddException.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddException.Name = "btnAddException"
        '
        'btnEditException
        '
        Me.btnEditException.Caption = "Edit Exception"
        Me.btnEditException.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditException.Id = 3
        Me.btnEditException.Name = "btnEditException"
        '
        'btnDeleteException
        '
        Me.btnDeleteException.Caption = "Delete Exception"
        Me.btnDeleteException.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteException.Id = 4
        Me.btnDeleteException.Name = "btnDeleteException"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSaveAssignment)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancelAssignment)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Customer Assignments"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddException)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditException)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeleteException)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Commission Exceptions"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.grpAssignment)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 96)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl1.Size = New System.Drawing.Size(436, 431)
        Me.PanelControl1.TabIndex = 10
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grExceptions)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(8, 150)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(420, 273)
        Me.GroupControl2.TabIndex = 12
        Me.GroupControl2.Text = "Commission Exceptions"
        '
        'grExceptions
        '
        Me.grExceptions.DataSource = Me.bsExceptions
        Me.grExceptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grExceptions.Location = New System.Drawing.Point(2, 21)
        Me.grExceptions.LookAndFeel.SkinName = "Money Twins"
        Me.grExceptions.MainView = Me.GridView8
        Me.grExceptions.Name = "grExceptions"
        Me.grExceptions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit1})
        Me.grExceptions.Size = New System.Drawing.Size(416, 250)
        Me.grExceptions.TabIndex = 1
        Me.grExceptions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'bsExceptions
        '
        Me.bsExceptions.DataSource = GetType(AOS.BusinessObjects.CommissionexceptionCollection)
        '
        'GridView8
        '
        Me.GridView8.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView8.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView8.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView8.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView8.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView8.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView8.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView8.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView8.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView8.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView8.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView8.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView8.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView8.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView8.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView8.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView8.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView8.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView8.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView8.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView8.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView8.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView8.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView8.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView8.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView8.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductID, Me.colProductID1, Me.colCommissionRate})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView8.GridControl = Me.grExceptions
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.Editable = False
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'colProductID
        '
        Me.colProductID.Caption = "Prod ID"
        Me.colProductID.FieldName = "ProductID"
        Me.colProductID.Name = "colProductID"
        Me.colProductID.OptionsColumn.AllowEdit = False
        Me.colProductID.Visible = True
        Me.colProductID.VisibleIndex = 0
        Me.colProductID.Width = 65
        '
        'colProductID1
        '
        Me.colProductID1.Caption = "Product Description"
        Me.colProductID1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colProductID1.FieldName = "ProductID"
        Me.colProductID1.Name = "colProductID1"
        Me.colProductID1.OptionsColumn.AllowEdit = False
        Me.colProductID1.Visible = True
        Me.colProductID1.VisibleIndex = 1
        Me.colProductID1.Width = 238
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit1.DropDownRows = 10
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'colCommissionRate
        '
        Me.colCommissionRate.Caption = "Commission Rate"
        Me.colCommissionRate.DisplayFormat.FormatString = "P2"
        Me.colCommissionRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCommissionRate.FieldName = "CommissionRate"
        Me.colCommissionRate.Name = "colCommissionRate"
        Me.colCommissionRate.OptionsColumn.AllowEdit = False
        Me.colCommissionRate.Visible = True
        Me.colCommissionRate.VisibleIndex = 2
        Me.colCommissionRate.Width = 113
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ReadOnly = True
        Me.RepositoryItemLookUpEdit2.ValueMember = "Custid"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(8, 144)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(420, 6)
        Me.PanelControl2.TabIndex = 11
        '
        'grpAssignment
        '
        Me.grpAssignment.Controls.Add(Me.CustIDLookUpEdit)
        Me.grpAssignment.Controls.Add(Me.SalespersonIDLookUpEdit)
        Me.grpAssignment.Controls.Add(Me.CommissionRateTextEdit)
        Me.grpAssignment.Controls.Add(SalespersonIDLabel)
        Me.grpAssignment.Controls.Add(CommissionRateLabel)
        Me.grpAssignment.Controls.Add(CommissionTypeLabel1)
        Me.grpAssignment.Controls.Add(CustIDLabel)
        Me.grpAssignment.Controls.Add(Me.CommissionTypeLookUpEdit)
        Me.grpAssignment.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpAssignment.Location = New System.Drawing.Point(8, 8)
        Me.grpAssignment.Name = "grpAssignment"
        Me.grpAssignment.Size = New System.Drawing.Size(420, 136)
        Me.grpAssignment.TabIndex = 10
        Me.grpAssignment.Text = "Customer Assignment and General Commission"
        '
        'frmAddEditAssignment
        '
        Me.ClientSize = New System.Drawing.Size(436, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditAssignment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Edit Information"
        CType(Me.SalespersonIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalespersons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCommTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grExceptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsExceptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpAssignment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAssignment.ResumeLayout(False)
        Me.grpAssignment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents SalespersonIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CommissionRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommissionTypeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsSalespersons As System.Windows.Forms.BindingSource
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsCommTypes As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSaveAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddException As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditException As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteException As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpAssignment As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grExceptions As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsExceptions As System.Windows.Forms.BindingSource
    Friend WithEvents colProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommissionRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
End Class
