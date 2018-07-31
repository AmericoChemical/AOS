<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditLoadQuote

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
        Dim LoadIDLabel As System.Windows.Forms.Label
        Dim CarrierIDLabel As System.Windows.Forms.Label
        Dim LogisticsProviderIDLabel As System.Windows.Forms.Label
        Dim QuoteAmountLabel As System.Windows.Forms.Label
        Dim QuoteDateLabel As System.Windows.Forms.Label
        Dim CarrierQuoteNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditLoadQuote))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsQuote = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CarrierIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LogisticsProviderIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.QuoteAmountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QuoteDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CarrierQuoteNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        LoadIDLabel = New System.Windows.Forms.Label()
        CarrierIDLabel = New System.Windows.Forms.Label()
        LogisticsProviderIDLabel = New System.Windows.Forms.Label()
        QuoteAmountLabel = New System.Windows.Forms.Label()
        QuoteDateLabel = New System.Windows.Forms.Label()
        CarrierQuoteNumberLabel = New System.Windows.Forms.Label()
        CType(Me.bsQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrierIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticsProviderIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteAmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrierQuoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadIDLabel
        '
        LoadIDLabel.AutoSize = True
        LoadIDLabel.Location = New System.Drawing.Point(84, 111)
        LoadIDLabel.Name = "LoadIDLabel"
        LoadIDLabel.Size = New System.Drawing.Size(41, 13)
        LoadIDLabel.TabIndex = 1
        LoadIDLabel.Text = "Load #"
        '
        'CarrierIDLabel
        '
        CarrierIDLabel.AutoSize = True
        CarrierIDLabel.Location = New System.Drawing.Point(85, 162)
        CarrierIDLabel.Name = "CarrierIDLabel"
        CarrierIDLabel.Size = New System.Drawing.Size(40, 13)
        CarrierIDLabel.TabIndex = 3
        CarrierIDLabel.Text = "Carrier"
        '
        'LogisticsProviderIDLabel
        '
        LogisticsProviderIDLabel.AutoSize = True
        LogisticsProviderIDLabel.Location = New System.Drawing.Point(35, 188)
        LogisticsProviderIDLabel.Name = "LogisticsProviderIDLabel"
        LogisticsProviderIDLabel.Size = New System.Drawing.Size(90, 13)
        LogisticsProviderIDLabel.TabIndex = 5
        LogisticsProviderIDLabel.Text = "Logistics Provider"
        '
        'QuoteAmountLabel
        '
        QuoteAmountLabel.AutoSize = True
        QuoteAmountLabel.Location = New System.Drawing.Point(48, 214)
        QuoteAmountLabel.Name = "QuoteAmountLabel"
        QuoteAmountLabel.Size = New System.Drawing.Size(77, 13)
        QuoteAmountLabel.TabIndex = 7
        QuoteAmountLabel.Text = "Quote Amount"
        '
        'QuoteDateLabel
        '
        QuoteDateLabel.AutoSize = True
        QuoteDateLabel.Location = New System.Drawing.Point(62, 240)
        QuoteDateLabel.Name = "QuoteDateLabel"
        QuoteDateLabel.Size = New System.Drawing.Size(63, 13)
        QuoteDateLabel.TabIndex = 9
        QuoteDateLabel.Text = "Quote Date"
        '
        'CarrierQuoteNumberLabel
        '
        CarrierQuoteNumberLabel.AutoSize = True
        CarrierQuoteNumberLabel.Location = New System.Drawing.Point(12, 266)
        CarrierQuoteNumberLabel.Name = "CarrierQuoteNumberLabel"
        CarrierQuoteNumberLabel.Size = New System.Drawing.Size(113, 13)
        CarrierQuoteNumberLabel.TabIndex = 11
        CarrierQuoteNumberLabel.Text = "Carrier Quote Number"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsQuote
        '
        Me.bsQuote.DataSource = GetType(AOS.BusinessObjects.Loadquote)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(478, 94)
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
        Me.btnSave.LargeImageIndex = 1
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 2
        Me.btnCancel.Name = "btnCancel"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
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
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'LoadIDTextEdit
        '
        Me.LoadIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsQuote, "LoadID", True))
        Me.LoadIDTextEdit.Location = New System.Drawing.Point(135, 108)
        Me.LoadIDTextEdit.MenuManager = Me.RibbonControl1
        Me.LoadIDTextEdit.Name = "LoadIDTextEdit"
        Me.LoadIDTextEdit.Properties.ReadOnly = True
        Me.LoadIDTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.LoadIDTextEdit.TabIndex = 2
        Me.LoadIDTextEdit.TabStop = False
        '
        'CarrierIDLookUpEdit
        '
        Me.CarrierIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsQuote, "CarrierID", True))
        Me.CarrierIDLookUpEdit.Location = New System.Drawing.Point(135, 159)
        Me.CarrierIDLookUpEdit.MenuManager = Me.RibbonControl1
        Me.CarrierIDLookUpEdit.Name = "CarrierIDLookUpEdit"
        Me.CarrierIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CarrierIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierID", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierCity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierState", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CarrierIDLookUpEdit.Properties.DataSource = Me.bsCarriers
        Me.CarrierIDLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.CarrierIDLookUpEdit.Properties.NullText = ""
        Me.CarrierIDLookUpEdit.Properties.ValueMember = "CarrierID"
        Me.CarrierIDLookUpEdit.Size = New System.Drawing.Size(323, 20)
        Me.CarrierIDLookUpEdit.TabIndex = 4
        '
        'LogisticsProviderIDLookUpEdit
        '
        Me.LogisticsProviderIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsQuote, "LogisticsProviderID", True))
        Me.LogisticsProviderIDLookUpEdit.Location = New System.Drawing.Point(135, 185)
        Me.LogisticsProviderIDLookUpEdit.MenuManager = Me.RibbonControl1
        Me.LogisticsProviderIDLookUpEdit.Name = "LogisticsProviderIDLookUpEdit"
        Me.LogisticsProviderIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LogisticsProviderIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsname", "Provider", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LogisticsProviderIDLookUpEdit.Properties.DataSource = Me.bsLogistics
        Me.LogisticsProviderIDLookUpEdit.Properties.DisplayMember = "Logisticsname"
        Me.LogisticsProviderIDLookUpEdit.Properties.NullText = ""
        Me.LogisticsProviderIDLookUpEdit.Properties.ValueMember = "Logisticsid"
        Me.LogisticsProviderIDLookUpEdit.Size = New System.Drawing.Size(323, 20)
        Me.LogisticsProviderIDLookUpEdit.TabIndex = 6
        '
        'QuoteAmountTextEdit
        '
        Me.QuoteAmountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsQuote, "QuoteAmount", True))
        Me.QuoteAmountTextEdit.Location = New System.Drawing.Point(135, 211)
        Me.QuoteAmountTextEdit.MenuManager = Me.RibbonControl1
        Me.QuoteAmountTextEdit.Name = "QuoteAmountTextEdit"
        Me.QuoteAmountTextEdit.Properties.DisplayFormat.FormatString = "c2"
        Me.QuoteAmountTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QuoteAmountTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.QuoteAmountTextEdit.TabIndex = 8
        '
        'QuoteDateDateEdit
        '
        Me.QuoteDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsQuote, "QuoteDate", True))
        Me.QuoteDateDateEdit.EditValue = Nothing
        Me.QuoteDateDateEdit.Location = New System.Drawing.Point(135, 237)
        Me.QuoteDateDateEdit.MenuManager = Me.RibbonControl1
        Me.QuoteDateDateEdit.Name = "QuoteDateDateEdit"
        Me.QuoteDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QuoteDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.QuoteDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.QuoteDateDateEdit.TabIndex = 10
        '
        'CarrierQuoteNumberTextEdit
        '
        Me.CarrierQuoteNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsQuote, "CarrierQuoteNumber", True))
        Me.CarrierQuoteNumberTextEdit.Location = New System.Drawing.Point(135, 263)
        Me.CarrierQuoteNumberTextEdit.MenuManager = Me.RibbonControl1
        Me.CarrierQuoteNumberTextEdit.Name = "CarrierQuoteNumberTextEdit"
        Me.CarrierQuoteNumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CarrierQuoteNumberTextEdit.TabIndex = 12
        '
        'frmAddEditLoadQuote
        '
        Me.ClientSize = New System.Drawing.Size(478, 314)
        Me.ControlBox = False
        Me.Controls.Add(CarrierQuoteNumberLabel)
        Me.Controls.Add(Me.CarrierQuoteNumberTextEdit)
        Me.Controls.Add(QuoteDateLabel)
        Me.Controls.Add(Me.QuoteDateDateEdit)
        Me.Controls.Add(QuoteAmountLabel)
        Me.Controls.Add(Me.QuoteAmountTextEdit)
        Me.Controls.Add(LogisticsProviderIDLabel)
        Me.Controls.Add(Me.LogisticsProviderIDLookUpEdit)
        Me.Controls.Add(CarrierIDLabel)
        Me.Controls.Add(Me.CarrierIDLookUpEdit)
        Me.Controls.Add(LoadIDLabel)
        Me.Controls.Add(Me.LoadIDTextEdit)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditLoadQuote"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Load Quote"
        CType(Me.bsQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrierIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticsProviderIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteAmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrierQuoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsQuote As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents LoadIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CarrierIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LogisticsProviderIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents QuoteAmountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QuoteDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CarrierQuoteNumberTextEdit As DevExpress.XtraEditors.TextEdit
End Class
