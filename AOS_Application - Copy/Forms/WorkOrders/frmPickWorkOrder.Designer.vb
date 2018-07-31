<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickWorkOrder

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
        Dim WorkordernumberLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsWorkOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkordernumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eInvItemNum = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grpPicked = New DevExpress.XtraEditors.GroupControl()
        Me.grPicked = New DevExpress.XtraGrid.GridControl()
        Me.bsPicked = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWorkOrderInvItems2 = New AOS.dsWorkOrderInvItems()
        Me.GridView2 = New CustomDevExGridView()
        Me.colINVITEMNUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRODUCTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProducts2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.colLOTNUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWAREHOUSELOCATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.grpAllocated = New DevExpress.XtraEditors.GroupControl()
        Me.grAllocated = New DevExpress.XtraGrid.GridControl()
        Me.bsAllocated = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New CustomDevExGridView()
        Me.colINVITEMNUMBER1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRODUCTID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProducts = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colLOTNUMBER1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWAREHOUSELOCATION1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DsWorkOrderInvItems1 = New AOS.dsWorkOrderInvItems()
        WorkordernumberLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvItemNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grpPicked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPicked.SuspendLayout()
        CType(Me.grPicked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPicked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWorkOrderInvItems2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProducts2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpAllocated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAllocated.SuspendLayout()
        CType(Me.grAllocated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAllocated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWorkOrderInvItems1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WorkordernumberLabel
        '
        WorkordernumberLabel.AutoSize = True
        WorkordernumberLabel.Location = New System.Drawing.Point(10, 15)
        WorkordernumberLabel.Name = "WorkordernumberLabel"
        WorkordernumberLabel.Size = New System.Drawing.Size(74, 13)
        WorkordernumberLabel.TabIndex = 1
        WorkordernumberLabel.Text = "Work Order #"
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(10, 41)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(53, 13)
        CustidLabel.TabIndex = 3
        CustidLabel.Text = "Customer"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(454, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(213, 13)
        Label1.TabIndex = 5
        Label1.Text = "Scan Inventory Item or Enter Number here"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnSave)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 414)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(885, 39)
        Me.PanelControl1.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(785, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Finished"
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(885, 2)
        Me.LabelControl1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Label1)
        Me.PanelControl2.Controls.Add(CustidLabel)
        Me.PanelControl2.Controls.Add(Me.CustidLookUpEdit)
        Me.PanelControl2.Controls.Add(WorkordernumberLabel)
        Me.PanelControl2.Controls.Add(Me.WorkordernumberTextEdit)
        Me.PanelControl2.Controls.Add(Me.eInvItemNum)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(885, 100)
        Me.PanelControl2.TabIndex = 1
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Custid", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(90, 38)
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CustidLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CustidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.CustidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "Custid", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustidLookUpEdit.Properties.DataSource = Me.bsCustomers
        Me.CustidLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustidLookUpEdit.Properties.NullText = ""
        Me.CustidLookUpEdit.Properties.ReadOnly = True
        Me.CustidLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(202, 20)
        Me.CustidLookUpEdit.TabIndex = 4
        Me.CustidLookUpEdit.TabStop = False
        '
        'bsWorkOrder
        '
        Me.bsWorkOrder.DataSource = GetType(AOS.BusinessObjects.Workorder)
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'WorkordernumberTextEdit
        '
        Me.WorkordernumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Workordernumber", True))
        Me.WorkordernumberTextEdit.Location = New System.Drawing.Point(90, 12)
        Me.WorkordernumberTextEdit.Name = "WorkordernumberTextEdit"
        Me.WorkordernumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.WorkordernumberTextEdit.TabIndex = 2
        Me.WorkordernumberTextEdit.TabStop = False
        '
        'eInvItemNum
        '
        Me.eInvItemNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.eInvItemNum.Location = New System.Drawing.Point(457, 38)
        Me.eInvItemNum.Name = "eInvItemNum"
        Me.eInvItemNum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eInvItemNum.Properties.Appearance.Options.UseFont = True
        Me.eInvItemNum.Size = New System.Drawing.Size(238, 46)
        Me.eInvItemNum.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.grpPicked)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Controls.Add(Me.grpAllocated)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 100)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl3.Size = New System.Drawing.Size(885, 314)
        Me.PanelControl3.TabIndex = 2
        '
        'grpPicked
        '
        Me.grpPicked.Controls.Add(Me.grPicked)
        Me.grpPicked.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPicked.Location = New System.Drawing.Point(440, 6)
        Me.grpPicked.Name = "grpPicked"
        Me.grpPicked.Size = New System.Drawing.Size(439, 302)
        Me.grpPicked.TabIndex = 2
        Me.grpPicked.Text = "Picked Items"
        '
        'grPicked
        '
        Me.grPicked.DataMember = "WORKORDERINVITEM"
        Me.grPicked.DataSource = Me.bsPicked
        Me.grPicked.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPicked.Location = New System.Drawing.Point(2, 21)
        Me.grPicked.MainView = Me.GridView2
        Me.grPicked.Name = "grPicked"
        Me.grPicked.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProducts2})
        Me.grPicked.Size = New System.Drawing.Size(435, 279)
        Me.grPicked.TabIndex = 0
        Me.grPicked.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsPicked
        '
        Me.bsPicked.DataSource = Me.DsWorkOrderInvItems2
        Me.bsPicked.Position = 0
        '
        'DsWorkOrderInvItems2
        '
        Me.DsWorkOrderInvItems2.DataSetName = "dsWorkOrderInvItems"
        Me.DsWorkOrderInvItems2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colINVITEMNUMBER, Me.colPRODUCTID, Me.colLOTNUMBER, Me.colWAREHOUSELOCATION})
        Me.GridView2.GridControl = Me.grPicked
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colINVITEMNUMBER
        '
        Me.colINVITEMNUMBER.Caption = "Inv Item #"
        Me.colINVITEMNUMBER.FieldName = "INVITEMNUMBER"
        Me.colINVITEMNUMBER.Name = "colINVITEMNUMBER"
        Me.colINVITEMNUMBER.OptionsColumn.AllowEdit = False
        Me.colINVITEMNUMBER.Visible = True
        Me.colINVITEMNUMBER.VisibleIndex = 0
        Me.colINVITEMNUMBER.Width = 81
        '
        'colPRODUCTID
        '
        Me.colPRODUCTID.Caption = "Product"
        Me.colPRODUCTID.ColumnEdit = Me.luProducts2
        Me.colPRODUCTID.FieldName = "PRODUCTID"
        Me.colPRODUCTID.Name = "colPRODUCTID"
        Me.colPRODUCTID.OptionsColumn.AllowEdit = False
        Me.colPRODUCTID.Visible = True
        Me.colPRODUCTID.VisibleIndex = 1
        Me.colPRODUCTID.Width = 154
        '
        'luProducts2
        '
        Me.luProducts2.AutoHeight = False
        Me.luProducts2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luProducts2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luProducts2.DataSource = Me.bsProducts
        Me.luProducts2.DisplayMember = "Productdesc"
        Me.luProducts2.Name = "luProducts2"
        Me.luProducts2.ReadOnly = True
        Me.luProducts2.ValueMember = "Productid"
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'colLOTNUMBER
        '
        Me.colLOTNUMBER.Caption = "Lot #"
        Me.colLOTNUMBER.FieldName = "LOTNUMBER"
        Me.colLOTNUMBER.Name = "colLOTNUMBER"
        Me.colLOTNUMBER.OptionsColumn.AllowEdit = False
        Me.colLOTNUMBER.Visible = True
        Me.colLOTNUMBER.VisibleIndex = 2
        Me.colLOTNUMBER.Width = 114
        '
        'colWAREHOUSELOCATION
        '
        Me.colWAREHOUSELOCATION.Caption = "Bin"
        Me.colWAREHOUSELOCATION.FieldName = "WAREHOUSELOCATION"
        Me.colWAREHOUSELOCATION.Name = "colWAREHOUSELOCATION"
        Me.colWAREHOUSELOCATION.OptionsColumn.AllowEdit = False
        Me.colWAREHOUSELOCATION.Visible = True
        Me.colWAREHOUSELOCATION.VisibleIndex = 3
        Me.colWAREHOUSELOCATION.Width = 65
        '
        'PanelControl4
        '
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl4.Location = New System.Drawing.Point(434, 6)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(6, 302)
        Me.PanelControl4.TabIndex = 1
        '
        'grpAllocated
        '
        Me.grpAllocated.Controls.Add(Me.grAllocated)
        Me.grpAllocated.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpAllocated.Location = New System.Drawing.Point(6, 6)
        Me.grpAllocated.Name = "grpAllocated"
        Me.grpAllocated.Size = New System.Drawing.Size(428, 302)
        Me.grpAllocated.TabIndex = 0
        Me.grpAllocated.Text = "Allocated Items"
        '
        'grAllocated
        '
        Me.grAllocated.DataMember = "WORKORDERINVITEM"
        Me.grAllocated.DataSource = Me.bsAllocated
        Me.grAllocated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAllocated.Location = New System.Drawing.Point(2, 21)
        Me.grAllocated.MainView = Me.GridView1
        Me.grAllocated.Name = "grAllocated"
        Me.grAllocated.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProducts})
        Me.grAllocated.Size = New System.Drawing.Size(424, 279)
        Me.grAllocated.TabIndex = 0
        Me.grAllocated.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsAllocated
        '
        Me.bsAllocated.DataSource = Me.DsWorkOrderInvItems2
        Me.bsAllocated.Position = 0
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colINVITEMNUMBER1, Me.colPRODUCTID1, Me.colLOTNUMBER1, Me.colWAREHOUSELOCATION1})
        Me.GridView1.GridControl = Me.grAllocated
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colINVITEMNUMBER1
        '
        Me.colINVITEMNUMBER1.Caption = "Inv Item #"
        Me.colINVITEMNUMBER1.FieldName = "INVITEMNUMBER"
        Me.colINVITEMNUMBER1.Name = "colINVITEMNUMBER1"
        Me.colINVITEMNUMBER1.OptionsColumn.AllowEdit = False
        Me.colINVITEMNUMBER1.Visible = True
        Me.colINVITEMNUMBER1.VisibleIndex = 0
        Me.colINVITEMNUMBER1.Width = 80
        '
        'colPRODUCTID1
        '
        Me.colPRODUCTID1.Caption = "Product"
        Me.colPRODUCTID1.ColumnEdit = Me.luProducts
        Me.colPRODUCTID1.FieldName = "PRODUCTID"
        Me.colPRODUCTID1.Name = "colPRODUCTID1"
        Me.colPRODUCTID1.OptionsColumn.AllowEdit = False
        Me.colPRODUCTID1.Visible = True
        Me.colPRODUCTID1.VisibleIndex = 1
        Me.colPRODUCTID1.Width = 166
        '
        'luProducts
        '
        Me.luProducts.AutoHeight = False
        Me.luProducts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luProducts.DataSource = Me.bsProducts
        Me.luProducts.DisplayMember = "Productdesc"
        Me.luProducts.Name = "luProducts"
        Me.luProducts.ReadOnly = True
        Me.luProducts.ValueMember = "Productid"
        '
        'colLOTNUMBER1
        '
        Me.colLOTNUMBER1.Caption = "Lot #"
        Me.colLOTNUMBER1.FieldName = "LOTNUMBER"
        Me.colLOTNUMBER1.Name = "colLOTNUMBER1"
        Me.colLOTNUMBER1.OptionsColumn.AllowEdit = False
        Me.colLOTNUMBER1.Visible = True
        Me.colLOTNUMBER1.VisibleIndex = 2
        Me.colLOTNUMBER1.Width = 97
        '
        'colWAREHOUSELOCATION1
        '
        Me.colWAREHOUSELOCATION1.Caption = "Bin"
        Me.colWAREHOUSELOCATION1.FieldName = "WAREHOUSELOCATION"
        Me.colWAREHOUSELOCATION1.Name = "colWAREHOUSELOCATION1"
        Me.colWAREHOUSELOCATION1.OptionsColumn.AllowEdit = False
        Me.colWAREHOUSELOCATION1.Visible = True
        Me.colWAREHOUSELOCATION1.VisibleIndex = 3
        Me.colWAREHOUSELOCATION1.Width = 60
        '
        'DsWorkOrderInvItems1
        '
        Me.DsWorkOrderInvItems1.DataSetName = "dsWorkOrderInvItems"
        Me.DsWorkOrderInvItems1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmPickWorkOrder
        '
        Me.ClientSize = New System.Drawing.Size(885, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPickWorkOrder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Picking Work Order"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvItemNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grpPicked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPicked.ResumeLayout(False)
        CType(Me.grPicked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPicked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWorkOrderInvItems2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProducts2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpAllocated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAllocated.ResumeLayout(False)
        CType(Me.grAllocated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAllocated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWorkOrderInvItems1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents eInvItemNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpAllocated As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpPicked As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsWorkOrder As System.Windows.Forms.BindingSource
    Friend WithEvents bsAllocated As System.Windows.Forms.BindingSource
    Friend WithEvents bsPicked As System.Windows.Forms.BindingSource
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WorkordernumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsWorkOrderInvItems2 As AOS.dsWorkOrderInvItems
    Friend WithEvents DsWorkOrderInvItems1 As AOS.dsWorkOrderInvItems
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents grPicked As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents grAllocated As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colPRODUCTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINVITEMNUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOTNUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWAREHOUSELOCATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRODUCTID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINVITEMNUMBER1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOTNUMBER1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWAREHOUSELOCATION1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luProducts As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luProducts2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
