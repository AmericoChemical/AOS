<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditCustomerPayment

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
        Dim CustidLabel As System.Windows.Forms.Label
        Dim PaymentamountLabel As System.Windows.Forms.Label
        Dim PaymentdateLabel As System.Windows.Forms.Label
        Dim RemittanceadviceLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsCustomerPayment = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditInvoicePmt = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteInvoicePmt = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PaymentamountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PaymentdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RemittanceadviceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.pnlPmtInfo = New DevExpress.XtraEditors.PanelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.bsUnpaidInvoices = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsInvoicePayments = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlGridsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.pnlInvoicePayments = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.grInvoicePayments = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New CustomDevExGridView()
        Me.colInvoicenumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicepmtamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.pnlUnpaidInvoices = New DevExpress.XtraEditors.PanelControl()
        Me.btnAllocatePaymentToInvoice = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grUnpaidInvoices = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New CustomDevExGridView()
        Me.colInvoicenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicedate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvnumview = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CustidLabel = New System.Windows.Forms.Label()
        PaymentamountLabel = New System.Windows.Forms.Label()
        PaymentdateLabel = New System.Windows.Forms.Label()
        RemittanceadviceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.bsCustomerPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentamountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemittanceadviceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlPmtInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPmtInfo.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnpaidInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvoicePayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlGridsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGridsHolder.SuspendLayout()
        CType(Me.pnlInvoicePayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInvoicePayments.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grInvoicePayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlUnpaidInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUnpaidInvoices.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grUnpaidInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(52, 18)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(53, 13)
        CustidLabel.TabIndex = 1
        CustidLabel.Text = "Customer"
        '
        'PaymentamountLabel
        '
        PaymentamountLabel.AutoSize = True
        PaymentamountLabel.Location = New System.Drawing.Point(326, 44)
        PaymentamountLabel.Name = "PaymentamountLabel"
        PaymentamountLabel.Size = New System.Drawing.Size(89, 13)
        PaymentamountLabel.TabIndex = 3
        PaymentamountLabel.Text = "Payment Amount"
        '
        'PaymentdateLabel
        '
        PaymentdateLabel.AutoSize = True
        PaymentdateLabel.Location = New System.Drawing.Point(340, 18)
        PaymentdateLabel.Name = "PaymentdateLabel"
        PaymentdateLabel.Size = New System.Drawing.Size(75, 13)
        PaymentdateLabel.TabIndex = 5
        PaymentdateLabel.Text = "Payment Date"
        '
        'RemittanceadviceLabel
        '
        RemittanceadviceLabel.AutoSize = True
        RemittanceadviceLabel.Location = New System.Drawing.Point(9, 44)
        RemittanceadviceLabel.Name = "RemittanceadviceLabel"
        RemittanceadviceLabel.Size = New System.Drawing.Size(96, 13)
        RemittanceadviceLabel.TabIndex = 7
        RemittanceadviceLabel.Text = "Remittance Advice"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(410, 14)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 13)
        Label1.TabIndex = 9
        Label1.Text = "Left to Allocate"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsCustomerPayment
        '
        Me.bsCustomerPayment.DataSource = GetType(AOS.BusinessObjects.Customerpayment)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel, Me.btnEditInvoicePmt, Me.btnDeleteInvoicePmt})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 8
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(752, 96)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'btnEditInvoicePmt
        '
        Me.btnEditInvoicePmt.Caption = "Edit Invoice Allocation"
        Me.btnEditInvoicePmt.Id = 6
        Me.btnEditInvoicePmt.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditInvoicePmt.Name = "btnEditInvoicePmt"
        '
        'btnDeleteInvoicePmt
        '
        Me.btnDeleteInvoicePmt.Caption = "Delete Invoice Allocation"
        Me.btnDeleteInvoicePmt.Id = 7
        Me.btnDeleteInvoicePmt.LargeGlyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteInvoicePmt.Name = "btnDeleteInvoicePmt"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditInvoicePmt)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDeleteInvoicePmt)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Invoice Payment Allocation"
        '
        'bsCustomer
        '
        Me.bsCustomer.DataSource = GetType(AOS.BusinessObjects.Customer)
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomerPayment, "Custid", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(114, 15)
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.DataSource = Me.bsCustomer
        Me.CustidLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustidLookUpEdit.Properties.NullText = ""
        Me.CustidLookUpEdit.Properties.ReadOnly = True
        Me.CustidLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(202, 20)
        Me.CustidLookUpEdit.TabIndex = 0
        '
        'PaymentamountTextEdit
        '
        Me.PaymentamountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomerPayment, "Paymentamount", True))
        Me.PaymentamountTextEdit.Location = New System.Drawing.Point(424, 41)
        Me.PaymentamountTextEdit.Name = "PaymentamountTextEdit"
        Me.PaymentamountTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.PaymentamountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PaymentamountTextEdit.Properties.DisplayFormat.FormatString = "c2"
        Me.PaymentamountTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PaymentamountTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PaymentamountTextEdit.TabIndex = 3
        '
        'PaymentdateDateEdit
        '
        Me.PaymentdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomerPayment, "Paymentdate", True))
        Me.PaymentdateDateEdit.EditValue = Nothing
        Me.PaymentdateDateEdit.Location = New System.Drawing.Point(424, 15)
        Me.PaymentdateDateEdit.Name = "PaymentdateDateEdit"
        Me.PaymentdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PaymentdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PaymentdateDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.PaymentdateDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.PaymentdateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.PaymentdateDateEdit.TabIndex = 2
        '
        'RemittanceadviceTextEdit
        '
        Me.RemittanceadviceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomerPayment, "Remittanceadvice", True))
        Me.RemittanceadviceTextEdit.Location = New System.Drawing.Point(114, 41)
        Me.RemittanceadviceTextEdit.Name = "RemittanceadviceTextEdit"
        Me.RemittanceadviceTextEdit.Size = New System.Drawing.Size(202, 20)
        Me.RemittanceadviceTextEdit.TabIndex = 1
        '
        'pnlPmtInfo
        '
        Me.pnlPmtInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlPmtInfo.Controls.Add(Me.CustidLookUpEdit)
        Me.pnlPmtInfo.Controls.Add(CustidLabel)
        Me.pnlPmtInfo.Controls.Add(RemittanceadviceLabel)
        Me.pnlPmtInfo.Controls.Add(Me.PaymentamountTextEdit)
        Me.pnlPmtInfo.Controls.Add(Me.RemittanceadviceTextEdit)
        Me.pnlPmtInfo.Controls.Add(PaymentamountLabel)
        Me.pnlPmtInfo.Controls.Add(PaymentdateLabel)
        Me.pnlPmtInfo.Controls.Add(Me.PaymentdateDateEdit)
        Me.pnlPmtInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPmtInfo.Location = New System.Drawing.Point(0, 96)
        Me.pnlPmtInfo.Name = "pnlPmtInfo"
        Me.pnlPmtInfo.Size = New System.Drawing.Size(752, 76)
        Me.pnlPmtInfo.TabIndex = 10
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomerPayment, "Balance", True))
        Me.TextEdit1.Location = New System.Drawing.Point(405, 30)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "c2"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(90, 20)
        Me.TextEdit1.TabIndex = 10
        '
        'bsUnpaidInvoices
        '
        Me.bsUnpaidInvoices.DataSource = GetType(AOS.BusinessObjects.InvoiceCollection)
        '
        'bsInvoicePayments
        '
        Me.bsInvoicePayments.DataSource = GetType(AOS.BusinessObjects.InvoicepaymentCollection)
        '
        'pnlGridsHolder
        '
        Me.pnlGridsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlGridsHolder.Controls.Add(Me.pnlInvoicePayments)
        Me.pnlGridsHolder.Controls.Add(Me.pnlUnpaidInvoices)
        Me.pnlGridsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridsHolder.Location = New System.Drawing.Point(0, 172)
        Me.pnlGridsHolder.Name = "pnlGridsHolder"
        Me.pnlGridsHolder.Size = New System.Drawing.Size(752, 361)
        Me.pnlGridsHolder.TabIndex = 13
        '
        'pnlInvoicePayments
        '
        Me.pnlInvoicePayments.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.pnlInvoicePayments.Appearance.Options.UseBorderColor = True
        Me.pnlInvoicePayments.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlInvoicePayments.Controls.Add(Me.GroupControl3)
        Me.pnlInvoicePayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInvoicePayments.Location = New System.Drawing.Point(507, 0)
        Me.pnlInvoicePayments.Name = "pnlInvoicePayments"
        Me.pnlInvoicePayments.Padding = New System.Windows.Forms.Padding(6)
        Me.pnlInvoicePayments.Size = New System.Drawing.Size(245, 361)
        Me.pnlInvoicePayments.TabIndex = 14
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grInvoicePayments)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(6, 6)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(233, 349)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "Invoice Allocations"
        '
        'grInvoicePayments
        '
        Me.grInvoicePayments.DataSource = Me.bsInvoicePayments
        Me.grInvoicePayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInvoicePayments.Location = New System.Drawing.Point(2, 21)
        Me.grInvoicePayments.LookAndFeel.SkinName = "Money Twins"
        Me.grInvoicePayments.MainView = Me.GridView3
        Me.grInvoicePayments.Name = "grInvoicePayments"
        Me.grInvoicePayments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit6, Me.RepositoryItemLookUpEdit5})
        Me.grInvoicePayments.Size = New System.Drawing.Size(229, 326)
        Me.grInvoicePayments.TabIndex = 2
        Me.grInvoicePayments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView3.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoicenumber1, Me.colInvoicepmtamount, Me.colInvoiceDiscount})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView3.GridControl = Me.grInvoicePayments
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colInvoicenumber1
        '
        Me.colInvoicenumber1.Caption = "Inv #"
        Me.colInvoicenumber1.FieldName = "Invoicenumber"
        Me.colInvoicenumber1.Name = "colInvoicenumber1"
        Me.colInvoicenumber1.OptionsColumn.AllowEdit = False
        Me.colInvoicenumber1.Visible = True
        Me.colInvoicenumber1.VisibleIndex = 0
        Me.colInvoicenumber1.Width = 59
        '
        'colInvoicepmtamount
        '
        Me.colInvoicepmtamount.Caption = "Pmt Amount"
        Me.colInvoicepmtamount.DisplayFormat.FormatString = "c2"
        Me.colInvoicepmtamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInvoicepmtamount.FieldName = "Invoicepmtamount"
        Me.colInvoicepmtamount.Name = "colInvoicepmtamount"
        Me.colInvoicepmtamount.OptionsColumn.AllowEdit = False
        Me.colInvoicepmtamount.Visible = True
        Me.colInvoicepmtamount.VisibleIndex = 1
        Me.colInvoicepmtamount.Width = 90
        '
        'colInvoiceDiscount
        '
        Me.colInvoiceDiscount.Caption = "Discount"
        Me.colInvoiceDiscount.DisplayFormat.FormatString = "c2"
        Me.colInvoiceDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInvoiceDiscount.FieldName = "Invoicediscount"
        Me.colInvoiceDiscount.Name = "colInvoiceDiscount"
        Me.colInvoiceDiscount.OptionsColumn.AllowEdit = False
        Me.colInvoiceDiscount.Visible = True
        Me.colInvoiceDiscount.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.ReadOnly = True
        Me.RepositoryItemLookUpEdit6.ValueMember = "Custid"
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ValueMember = "Custid"
        '
        'pnlUnpaidInvoices
        '
        Me.pnlUnpaidInvoices.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.pnlUnpaidInvoices.Appearance.Options.UseBorderColor = True
        Me.pnlUnpaidInvoices.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlUnpaidInvoices.Controls.Add(Label1)
        Me.pnlUnpaidInvoices.Controls.Add(Me.TextEdit1)
        Me.pnlUnpaidInvoices.Controls.Add(Me.btnAllocatePaymentToInvoice)
        Me.pnlUnpaidInvoices.Controls.Add(Me.GroupControl2)
        Me.pnlUnpaidInvoices.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlUnpaidInvoices.Location = New System.Drawing.Point(0, 0)
        Me.pnlUnpaidInvoices.Name = "pnlUnpaidInvoices"
        Me.pnlUnpaidInvoices.Padding = New System.Windows.Forms.Padding(6)
        Me.pnlUnpaidInvoices.Size = New System.Drawing.Size(507, 361)
        Me.pnlUnpaidInvoices.TabIndex = 13
        '
        'btnAllocatePaymentToInvoice
        '
        Me.btnAllocatePaymentToInvoice.Location = New System.Drawing.Point(405, 71)
        Me.btnAllocatePaymentToInvoice.Name = "btnAllocatePaymentToInvoice"
        Me.btnAllocatePaymentToInvoice.Size = New System.Drawing.Size(93, 41)
        Me.btnAllocatePaymentToInvoice.TabIndex = 1
        Me.btnAllocatePaymentToInvoice.Text = "Pay Invoice -->"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grUnpaidInvoices)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl2.Location = New System.Drawing.Point(6, 6)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(383, 349)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Receivable Invoices"
        '
        'grUnpaidInvoices
        '
        Me.grUnpaidInvoices.DataSource = Me.bsUnpaidInvoices
        Me.grUnpaidInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grUnpaidInvoices.Location = New System.Drawing.Point(2, 21)
        Me.grUnpaidInvoices.LookAndFeel.SkinName = "Money Twins"
        Me.grUnpaidInvoices.MainView = Me.GridView2
        Me.grUnpaidInvoices.Name = "grUnpaidInvoices"
        Me.grUnpaidInvoices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit2})
        Me.grUnpaidInvoices.Size = New System.Drawing.Size(379, 326)
        Me.grUnpaidInvoices.TabIndex = 2
        Me.grUnpaidInvoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView2.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoicenumber, Me.colInvoicedate, Me.colTotal, Me.colInvnumview})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView2.GridControl = Me.grUnpaidInvoices
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colInvoicenumber
        '
        Me.colInvoicenumber.Caption = "Inv #"
        Me.colInvoicenumber.FieldName = "Invoicenumber"
        Me.colInvoicenumber.Name = "colInvoicenumber"
        Me.colInvoicenumber.OptionsColumn.AllowEdit = False
        Me.colInvoicenumber.Visible = True
        Me.colInvoicenumber.VisibleIndex = 1
        Me.colInvoicenumber.Width = 65
        '
        'colInvoicedate
        '
        Me.colInvoicedate.Caption = "Inv Date"
        Me.colInvoicedate.DisplayFormat.FormatString = "d"
        Me.colInvoicedate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colInvoicedate.FieldName = "Invoicedate"
        Me.colInvoicedate.Name = "colInvoicedate"
        Me.colInvoicedate.OptionsColumn.AllowEdit = False
        Me.colInvoicedate.Visible = True
        Me.colInvoicedate.VisibleIndex = 2
        Me.colInvoicedate.Width = 85
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "c2"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowEdit = False
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 3
        Me.colTotal.Width = 90
        '
        'colInvnumview
        '
        Me.colInvnumview.Caption = "QB #"
        Me.colInvnumview.FieldName = "Invnumview"
        Me.colInvnumview.Name = "colInvnumview"
        Me.colInvnumview.OptionsColumn.AllowEdit = False
        Me.colInvnumview.Visible = True
        Me.colInvnumview.VisibleIndex = 0
        Me.colInvnumview.Width = 56
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ReadOnly = True
        Me.RepositoryItemLookUpEdit4.ValueMember = "Custid"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "Custid"
        '
        'frmAddEditCustomerPayment
        '
        Me.ClientSize = New System.Drawing.Size(752, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlGridsHolder)
        Me.Controls.Add(Me.pnlPmtInfo)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditCustomerPayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Payment"
        CType(Me.bsCustomerPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentamountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemittanceadviceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlPmtInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPmtInfo.ResumeLayout(False)
        Me.pnlPmtInfo.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnpaidInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvoicePayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlGridsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGridsHolder.ResumeLayout(False)
        CType(Me.pnlInvoicePayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInvoicePayments.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grInvoicePayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlUnpaidInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUnpaidInvoices.ResumeLayout(False)
        Me.pnlUnpaidInvoices.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grUnpaidInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsCustomerPayment As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsCustomer As System.Windows.Forms.BindingSource
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PaymentamountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaymentdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RemittanceadviceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlPmtInfo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bsUnpaidInvoices As System.Windows.Forms.BindingSource
    Friend WithEvents bsInvoicePayments As System.Windows.Forms.BindingSource
    Friend WithEvents pnlGridsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlInvoicePayments As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grInvoicePayments As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlUnpaidInvoices As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grUnpaidInvoices As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colInvoicenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicedate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvnumview As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicenumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicepmtamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEditInvoicePmt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteInvoicePmt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAllocatePaymentToInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colInvoiceDiscount As DevExpress.XtraGrid.Columns.GridColumn
End Class
