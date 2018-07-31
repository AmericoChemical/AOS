<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditCommission

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
        Dim SalespersonidLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim CommissioncategoryLabel As System.Windows.Forms.Label
        Dim CommissiondateLabel As System.Windows.Forms.Label
        Dim CommissiondescLabel As System.Windows.Forms.Label
        Dim CommissionnoteLabel As System.Windows.Forms.Label
        Dim CommissionstatusLabel As System.Windows.Forms.Label
        Dim InvoicenumberLabel As System.Windows.Forms.Label
        Dim CommissionamountLabel As System.Windows.Forms.Label
        Dim DatecommissionpaidLabel As System.Windows.Forms.Label
        Dim DatecustomerpaidLabel As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsSalespersons = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCommCategories = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSaveAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DatecustomerpaidDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DatecommissionpaidDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CommissionamountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CommissionstatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CommissionnoteMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.CommissiondescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CommissiondateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CommissioncategoryLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.SalespersonidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.InvoicenumberTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsInvoices = New System.Windows.Forms.BindingSource(Me.components)
        SalespersonidLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        CommissioncategoryLabel = New System.Windows.Forms.Label()
        CommissiondateLabel = New System.Windows.Forms.Label()
        CommissiondescLabel = New System.Windows.Forms.Label()
        CommissionnoteLabel = New System.Windows.Forms.Label()
        CommissionstatusLabel = New System.Windows.Forms.Label()
        InvoicenumberLabel = New System.Windows.Forms.Label()
        CommissionamountLabel = New System.Windows.Forms.Label()
        DatecommissionpaidLabel = New System.Windows.Forms.Label()
        DatecustomerpaidLabel = New System.Windows.Forms.Label()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalespersons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCommCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DatecustomerpaidDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatecustomerpaidDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatecommissionpaidDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatecommissionpaidDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionamountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionstatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionnoteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissiondescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissiondateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissiondateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissioncategoryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalespersonidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicenumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalespersonidLabel
        '
        SalespersonidLabel.AutoSize = True
        SalespersonidLabel.Location = New System.Drawing.Point(14, 12)
        SalespersonidLabel.Name = "SalespersonidLabel"
        SalespersonidLabel.Size = New System.Drawing.Size(68, 13)
        SalespersonidLabel.TabIndex = 0
        SalespersonidLabel.Text = "Sales Person"
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(14, 224)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(53, 13)
        CustidLabel.TabIndex = 2
        CustidLabel.Text = "Customer"
        '
        'CommissioncategoryLabel
        '
        CommissioncategoryLabel.AutoSize = True
        CommissioncategoryLabel.Location = New System.Drawing.Point(250, 64)
        CommissioncategoryLabel.Name = "CommissioncategoryLabel"
        CommissioncategoryLabel.Size = New System.Drawing.Size(52, 13)
        CommissioncategoryLabel.TabIndex = 4
        CommissioncategoryLabel.Text = "Category"
        '
        'CommissiondateLabel
        '
        CommissiondateLabel.AutoSize = True
        CommissiondateLabel.Location = New System.Drawing.Point(14, 64)
        CommissiondateLabel.Name = "CommissiondateLabel"
        CommissiondateLabel.Size = New System.Drawing.Size(62, 13)
        CommissiondateLabel.TabIndex = 6
        CommissiondateLabel.Text = "Comm Date"
        '
        'CommissiondescLabel
        '
        CommissiondescLabel.AutoSize = True
        CommissiondescLabel.Location = New System.Drawing.Point(16, 38)
        CommissiondescLabel.Name = "CommissiondescLabel"
        CommissiondescLabel.Size = New System.Drawing.Size(60, 13)
        CommissiondescLabel.TabIndex = 8
        CommissiondescLabel.Text = "Description"
        '
        'CommissionnoteLabel
        '
        CommissionnoteLabel.AutoSize = True
        CommissionnoteLabel.Location = New System.Drawing.Point(14, 115)
        CommissionnoteLabel.Name = "CommissionnoteLabel"
        CommissionnoteLabel.Size = New System.Drawing.Size(67, 13)
        CommissionnoteLabel.TabIndex = 10
        CommissionnoteLabel.Text = "Comm Notes"
        '
        'CommissionstatusLabel
        '
        CommissionstatusLabel.AutoSize = True
        CommissionstatusLabel.Location = New System.Drawing.Point(250, 12)
        CommissionstatusLabel.Name = "CommissionstatusLabel"
        CommissionstatusLabel.Size = New System.Drawing.Size(38, 13)
        CommissionstatusLabel.TabIndex = 12
        CommissionstatusLabel.Text = "Status"
        '
        'InvoicenumberLabel
        '
        InvoicenumberLabel.AutoSize = True
        InvoicenumberLabel.Location = New System.Drawing.Point(14, 198)
        InvoicenumberLabel.Name = "InvoicenumberLabel"
        InvoicenumberLabel.Size = New System.Drawing.Size(42, 13)
        InvoicenumberLabel.TabIndex = 14
        InvoicenumberLabel.Text = "Invoice"
        '
        'CommissionamountLabel
        '
        CommissionamountLabel.AutoSize = True
        CommissionamountLabel.Location = New System.Drawing.Point(14, 90)
        CommissionamountLabel.Name = "CommissionamountLabel"
        CommissionamountLabel.Size = New System.Drawing.Size(76, 13)
        CommissionamountLabel.TabIndex = 16
        CommissionamountLabel.Text = "Comm Amount"
        '
        'DatecommissionpaidLabel
        '
        DatecommissionpaidLabel.AutoSize = True
        DatecommissionpaidLabel.Location = New System.Drawing.Point(250, 90)
        DatecommissionpaidLabel.Name = "DatecommissionpaidLabel"
        DatecommissionpaidLabel.Size = New System.Drawing.Size(53, 13)
        DatecommissionpaidLabel.TabIndex = 18
        DatecommissionpaidLabel.Text = "Date Paid"
        '
        'DatecustomerpaidLabel
        '
        DatecustomerpaidLabel.AutoSize = True
        DatecustomerpaidLabel.Location = New System.Drawing.Point(14, 250)
        DatecustomerpaidLabel.Name = "DatecustomerpaidLabel"
        DatecustomerpaidLabel.Size = New System.Drawing.Size(65, 13)
        DatecustomerpaidLabel.TabIndex = 20
        DatecustomerpaidLabel.Text = "Invoice Paid"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.Commission)
        '
        'bsSalespersons
        '
        Me.bsSalespersons.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'bsCommCategories
        '
        Me.bsCommCategories.DataSource = GetType(AOS.BusinessObjects.ListCommissioncategoryCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSaveAssignment, Me.btnCancelAssignment})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(412, 93)
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
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
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
        Me.RibbonPageGroup1.Text = "Data"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(DatecustomerpaidLabel)
        Me.PanelControl1.Controls.Add(Me.DatecustomerpaidDateEdit)
        Me.PanelControl1.Controls.Add(DatecommissionpaidLabel)
        Me.PanelControl1.Controls.Add(Me.DatecommissionpaidDateEdit)
        Me.PanelControl1.Controls.Add(CommissionamountLabel)
        Me.PanelControl1.Controls.Add(Me.CommissionamountTextEdit)
        Me.PanelControl1.Controls.Add(InvoicenumberLabel)
        Me.PanelControl1.Controls.Add(CommissionstatusLabel)
        Me.PanelControl1.Controls.Add(Me.CommissionstatusTextEdit)
        Me.PanelControl1.Controls.Add(CommissionnoteLabel)
        Me.PanelControl1.Controls.Add(Me.CommissionnoteMemoEdit)
        Me.PanelControl1.Controls.Add(CommissiondescLabel)
        Me.PanelControl1.Controls.Add(Me.CommissiondescTextEdit)
        Me.PanelControl1.Controls.Add(CommissiondateLabel)
        Me.PanelControl1.Controls.Add(Me.CommissiondateDateEdit)
        Me.PanelControl1.Controls.Add(CommissioncategoryLabel)
        Me.PanelControl1.Controls.Add(Me.CommissioncategoryLookUpEdit)
        Me.PanelControl1.Controls.Add(CustidLabel)
        Me.PanelControl1.Controls.Add(Me.CustidLookUpEdit)
        Me.PanelControl1.Controls.Add(SalespersonidLabel)
        Me.PanelControl1.Controls.Add(Me.SalespersonidLookUpEdit)
        Me.PanelControl1.Controls.Add(Me.InvoicenumberTextEdit)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 93)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl1.Size = New System.Drawing.Size(412, 279)
        Me.PanelControl1.TabIndex = 10
        '
        'DatecustomerpaidDateEdit
        '
        Me.DatecustomerpaidDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Datecustomerpaid", True))
        Me.DatecustomerpaidDateEdit.EditValue = Nothing
        Me.DatecustomerpaidDateEdit.Location = New System.Drawing.Point(97, 247)
        Me.DatecustomerpaidDateEdit.Name = "DatecustomerpaidDateEdit"
        Me.DatecustomerpaidDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DatecustomerpaidDateEdit.Properties.ReadOnly = True
        Me.DatecustomerpaidDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DatecustomerpaidDateEdit.Size = New System.Drawing.Size(134, 20)
        Me.DatecustomerpaidDateEdit.TabIndex = 10
        '
        'DatecommissionpaidDateEdit
        '
        Me.DatecommissionpaidDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Datecommissionpaid", True))
        Me.DatecommissionpaidDateEdit.EditValue = Nothing
        Me.DatecommissionpaidDateEdit.Location = New System.Drawing.Point(308, 87)
        Me.DatecommissionpaidDateEdit.Name = "DatecommissionpaidDateEdit"
        Me.DatecommissionpaidDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DatecommissionpaidDateEdit.Properties.ReadOnly = True
        Me.DatecommissionpaidDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DatecommissionpaidDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.DatecommissionpaidDateEdit.TabIndex = 6
        '
        'CommissionamountTextEdit
        '
        Me.CommissionamountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Commissionamount", True))
        Me.CommissionamountTextEdit.Location = New System.Drawing.Point(97, 87)
        Me.CommissionamountTextEdit.Name = "CommissionamountTextEdit"
        Me.CommissionamountTextEdit.Properties.DisplayFormat.FormatString = "c2"
        Me.CommissionamountTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CommissionamountTextEdit.Size = New System.Drawing.Size(134, 20)
        Me.CommissionamountTextEdit.TabIndex = 4
        '
        'CommissionstatusTextEdit
        '
        Me.CommissionstatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Commissionstatus", True))
        Me.CommissionstatusTextEdit.Location = New System.Drawing.Point(308, 9)
        Me.CommissionstatusTextEdit.Name = "CommissionstatusTextEdit"
        Me.CommissionstatusTextEdit.Properties.ReadOnly = True
        Me.CommissionstatusTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CommissionstatusTextEdit.TabIndex = 1
        '
        'CommissionnoteMemoEdit
        '
        Me.CommissionnoteMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Commissionnote", True))
        Me.CommissionnoteMemoEdit.Location = New System.Drawing.Point(97, 113)
        Me.CommissionnoteMemoEdit.Name = "CommissionnoteMemoEdit"
        Me.CommissionnoteMemoEdit.Size = New System.Drawing.Size(311, 58)
        Me.CommissionnoteMemoEdit.TabIndex = 7
        '
        'CommissiondescTextEdit
        '
        Me.CommissiondescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Commissiondesc", True))
        Me.CommissiondescTextEdit.Location = New System.Drawing.Point(97, 35)
        Me.CommissiondescTextEdit.Name = "CommissiondescTextEdit"
        Me.CommissiondescTextEdit.Size = New System.Drawing.Size(311, 20)
        Me.CommissiondescTextEdit.TabIndex = 2
        '
        'CommissiondateDateEdit
        '
        Me.CommissiondateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Commissiondate", True))
        Me.CommissiondateDateEdit.EditValue = Nothing
        Me.CommissiondateDateEdit.Location = New System.Drawing.Point(97, 61)
        Me.CommissiondateDateEdit.Name = "CommissiondateDateEdit"
        Me.CommissiondateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommissiondateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CommissiondateDateEdit.Size = New System.Drawing.Size(134, 20)
        Me.CommissiondateDateEdit.TabIndex = 3
        '
        'CommissioncategoryLookUpEdit
        '
        Me.CommissioncategoryLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Commissioncategory", True))
        Me.CommissioncategoryLookUpEdit.Location = New System.Drawing.Point(308, 61)
        Me.CommissioncategoryLookUpEdit.Name = "CommissioncategoryLookUpEdit"
        Me.CommissioncategoryLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommissioncategoryLookUpEdit.Properties.DataSource = Me.bsCommCategories
        Me.CommissioncategoryLookUpEdit.Properties.DisplayMember = "Commissioncategory"
        Me.CommissioncategoryLookUpEdit.Properties.NullText = ""
        Me.CommissioncategoryLookUpEdit.Properties.ShowFooter = False
        Me.CommissioncategoryLookUpEdit.Properties.ShowHeader = False
        Me.CommissioncategoryLookUpEdit.Properties.ValueMember = "Commissioncategory"
        Me.CommissioncategoryLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.CommissioncategoryLookUpEdit.TabIndex = 5
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Custid", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(97, 221)
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 45, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 45, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustidLookUpEdit.Properties.DataSource = Me.bsCustomers
        Me.CustidLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustidLookUpEdit.Properties.NullText = ""
        Me.CustidLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(311, 20)
        Me.CustidLookUpEdit.TabIndex = 9
        '
        'SalespersonidLookUpEdit
        '
        Me.SalespersonidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Salespersonid", True))
        Me.SalespersonidLookUpEdit.Location = New System.Drawing.Point(97, 9)
        Me.SalespersonidLookUpEdit.Name = "SalespersonidLookUpEdit"
        Me.SalespersonidLookUpEdit.Properties.DataSource = Me.bsSalespersons
        Me.SalespersonidLookUpEdit.Properties.DisplayMember = "Salespersonfullname"
        Me.SalespersonidLookUpEdit.Properties.NullText = ""
        Me.SalespersonidLookUpEdit.Properties.ReadOnly = True
        Me.SalespersonidLookUpEdit.Properties.ValueMember = "Salespersonid"
        Me.SalespersonidLookUpEdit.Size = New System.Drawing.Size(134, 20)
        Me.SalespersonidLookUpEdit.TabIndex = 0
        '
        'InvoicenumberTextEdit
        '
        Me.InvoicenumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Invoicenumber", True))
        Me.InvoicenumberTextEdit.Location = New System.Drawing.Point(97, 195)
        Me.InvoicenumberTextEdit.Name = "InvoicenumberTextEdit"
        Me.InvoicenumberTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoicenumberTextEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Invoicenumber", "Inv #", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Invoicedate", "Inv Date", 110, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Invnumview", "QB Invoice", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.InvoicenumberTextEdit.Properties.DataSource = Me.bsInvoices
        Me.InvoicenumberTextEdit.Properties.DisplayMember = "Invoicenumber"
        Me.InvoicenumberTextEdit.Properties.NullText = ""
        Me.InvoicenumberTextEdit.Properties.ValueMember = "Invoicenumber"
        Me.InvoicenumberTextEdit.Size = New System.Drawing.Size(134, 20)
        Me.InvoicenumberTextEdit.TabIndex = 8
        '
        'bsInvoices
        '
        Me.bsInvoices.DataSource = GetType(AOS.BusinessObjects.InvoiceCollection)
        '
        'frmAddEditCommission
        '
        Me.ClientSize = New System.Drawing.Size(412, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditCommission"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Commission Information"
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalespersons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCommCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DatecustomerpaidDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatecustomerpaidDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatecommissionpaidDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatecommissionpaidDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionamountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionstatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionnoteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissiondescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissiondateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissiondateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissioncategoryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalespersonidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicenumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents bsSalespersons As System.Windows.Forms.BindingSource
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsCommCategories As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSaveAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SalespersonidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DatecustomerpaidDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DatecommissionpaidDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CommissionamountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommissionstatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommissionnoteMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CommissiondescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommissiondateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CommissioncategoryLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsInvoices As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicenumberTextEdit As DevExpress.XtraEditors.LookUpEdit
End Class
