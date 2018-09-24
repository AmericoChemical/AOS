<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateComponentUnitCost

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Me.ComponentidLabel = New System.Windows.Forms.Label()
        Me.ComponentdescLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComponentidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComponentdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.eReason = New DevExpress.XtraEditors.TextEdit()
        Me.eUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.bsComponentCost = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.eChangeDate = New DevExpress.XtraEditors.DateEdit()
        Me.eVendor = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCostType = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsUOMWeight = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsUOMVolume = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnUpdateComponentStandardCosts = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsCostMethod = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        CType(Me.ComponentidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.eReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComponentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChangeDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChangeDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCostType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCostMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(13, 31)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(90, 13)
        Label3.TabIndex = 0
        Label3.Text = "Preferred Vendor"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(29, 332)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(76, 13)
        Label4.TabIndex = 30
        Label4.Text = "Effective Date"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(68, 306)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(35, 13)
        Label7.TabIndex = 28
        Label7.Text = "Notes"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(57, 218)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(51, 13)
        Label10.TabIndex = 15
        Label10.Text = "Unit Cost"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(12, 377)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(162, 13)
        Label13.TabIndex = 33
        Label13.Text = "Reason for Vendor Cost Change"
        '
        'ComponentidLabel
        '
        Me.ComponentidLabel.AutoSize = True
        Me.ComponentidLabel.Location = New System.Drawing.Point(12, 26)
        Me.ComponentidLabel.Name = "ComponentidLabel"
        Me.ComponentidLabel.Size = New System.Drawing.Size(48, 13)
        Me.ComponentidLabel.TabIndex = 0
        Me.ComponentidLabel.Text = "Comp ID"
        '
        'ComponentdescLabel
        '
        Me.ComponentdescLabel.AutoSize = True
        Me.ComponentdescLabel.Location = New System.Drawing.Point(68, 26)
        Me.ComponentdescLabel.Name = "ComponentdescLabel"
        Me.ComponentdescLabel.Size = New System.Drawing.Size(118, 13)
        Me.ComponentdescLabel.TabIndex = 2
        Me.ComponentdescLabel.Text = "Component Description"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ComponentidTextEdit
        '
        Me.ComponentidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Componentid", True))
        Me.ComponentidTextEdit.Location = New System.Drawing.Point(15, 42)
        Me.ComponentidTextEdit.Name = "ComponentidTextEdit"
        Me.ComponentidTextEdit.Properties.ReadOnly = True
        Me.ComponentidTextEdit.Size = New System.Drawing.Size(49, 20)
        Me.ComponentidTextEdit.TabIndex = 1
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.Component)
        '
        'ComponentdescTextEdit
        '
        Me.ComponentdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Componentdesc", True))
        Me.ComponentdescTextEdit.Location = New System.Drawing.Point(71, 42)
        Me.ComponentdescTextEdit.Name = "ComponentdescTextEdit"
        Me.ComponentdescTextEdit.Properties.ReadOnly = True
        Me.ComponentdescTextEdit.Size = New System.Drawing.Size(211, 20)
        Me.ComponentdescTextEdit.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Label13)
        Me.GroupControl2.Controls.Add(Me.eReason)
        Me.GroupControl2.Controls.Add(Label10)
        Me.GroupControl2.Controls.Add(Me.eUnitCost)
        Me.GroupControl2.Controls.Add(Label7)
        Me.GroupControl2.Controls.Add(Me.TextEdit1)
        Me.GroupControl2.Controls.Add(Me.eChangeDate)
        Me.GroupControl2.Controls.Add(Label4)
        Me.GroupControl2.Controls.Add(Me.eVendor)
        Me.GroupControl2.Controls.Add(Label3)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 192)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(380, 406)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Component Cost Information"
        '
        'eReason
        '
        Me.eReason.Location = New System.Drawing.Point(15, 393)
        Me.eReason.Name = "eReason"
        Me.eReason.Size = New System.Drawing.Size(355, 20)
        Me.eReason.TabIndex = 32
        '
        'eUnitCost
        '
        Me.eUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponentCost, "UnitCost", True))
        Me.eUnitCost.EditValue = ""
        Me.eUnitCost.Location = New System.Drawing.Point(138, 215)
        Me.eUnitCost.Name = "eUnitCost"
        Me.eUnitCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eUnitCost.Properties.Mask.EditMask = "f4"
        Me.eUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.eUnitCost.Properties.MaxLength = 19
        Me.eUnitCost.Size = New System.Drawing.Size(75, 20)
        Me.eUnitCost.TabIndex = 16
        '
        'bsComponentCost
        '
        Me.bsComponentCost.DataSource = GetType(AOS.BusinessObjects.Componentcost)
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponentCost, "Notes", True))
        Me.TextEdit1.Location = New System.Drawing.Point(138, 303)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "c3"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Size = New System.Drawing.Size(232, 20)
        Me.TextEdit1.TabIndex = 29
        '
        'eChangeDate
        '
        Me.eChangeDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponentCost, "Effectivedate", True))
        Me.eChangeDate.EditValue = Nothing
        Me.eChangeDate.Location = New System.Drawing.Point(138, 329)
        Me.eChangeDate.Name = "eChangeDate"
        Me.eChangeDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eChangeDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eChangeDate.Size = New System.Drawing.Size(75, 20)
        Me.eChangeDate.TabIndex = 31
        '
        'eVendor
        '
        Me.eVendor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponentCost, "Vendorid", True))
        Me.eVendor.Location = New System.Drawing.Point(138, 28)
        Me.eVendor.Name = "eVendor"
        Me.eVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eVendor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorname", "Vendor Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorcity", "City", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eVendor.Properties.DataSource = Me.bsVendors
        Me.eVendor.Properties.DisplayMember = "Vendorname"
        Me.eVendor.Properties.NullText = ""
        Me.eVendor.Properties.ValueMember = "Vendorid"
        Me.eVendor.Size = New System.Drawing.Size(232, 20)
        Me.eVendor.TabIndex = 1
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'bsCostType
        '
        Me.bsCostType.DataSource = GetType(AOS.BusinessObjects.ListCosttypeCollection)
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'bsUOMWeight
        '
        Me.bsUOMWeight.DataSource = GetType(AOS.BusinessObjects.ViewUOMByWeightCollection)
        '
        'bsUOMVolume
        '
        Me.bsUOMVolume.DataSource = GetType(AOS.BusinessObjects.ViewUOMByVolumeCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnSave, Me.rbtnCancel, Me.rbtnUpdateComponentStandardCosts})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 29
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(380, 116)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnSave
        '
        Me.rbtnSave.Caption = "Save"
        Me.rbtnSave.Id = 4
        Me.rbtnSave.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.SaveChanges
        Me.rbtnSave.Name = "rbtnSave"
        Me.rbtnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'rbtnCancel
        '
        Me.rbtnCancel.Caption = "Cancel"
        Me.rbtnCancel.Id = 5
        Me.rbtnCancel.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.CancelChanges
        Me.rbtnCancel.Name = "rbtnCancel"
        Me.rbtnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'rbtnUpdateComponentStandardCosts
        '
        Me.rbtnUpdateComponentStandardCosts.Caption = "Set Component Standard Costs"
        Me.rbtnUpdateComponentStandardCosts.Id = 28
        Me.rbtnUpdateComponentStandardCosts.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.document_text_edit
        Me.rbtnUpdateComponentStandardCosts.Name = "rbtnUpdateComponentStandardCosts"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnUpdateComponentStandardCosts)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Standard Costs"
        Me.RibbonPageGroup1.Visible = False
        '
        'bsCostMethod
        '
        Me.bsCostMethod.DataSource = GetType(AOS.BusinessObjects.ListCostmethodCollection)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ComponentdescTextEdit)
        Me.GroupControl1.Controls.Add(Me.ComponentidTextEdit)
        Me.GroupControl1.Controls.Add(Me.ComponentidLabel)
        Me.GroupControl1.Controls.Add(Me.ComponentdescLabel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 116)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(380, 76)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Component Information"
        '
        'frmUpdateComponentUnitCost
        '
        Me.ClientSize = New System.Drawing.Size(380, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUpdateComponentUnitCost"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Edit Information"
        CType(Me.ComponentidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.eReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComponentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChangeDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChangeDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCostType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCostMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents ComponentidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComponentdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eVendor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents bsComponentCost As System.Windows.Forms.BindingSource
    Friend WithEvents eChangeDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsUOMVolume As System.Windows.Forms.BindingSource
    Friend WithEvents bsUOMWeight As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rbtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsCostType As System.Windows.Forms.BindingSource
    Friend WithEvents bsCostMethod As System.Windows.Forms.BindingSource
    Friend WithEvents eReason As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnUpdateComponentStandardCosts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ComponentidLabel As Label
    Friend WithEvents ComponentdescLabel As Label
End Class
