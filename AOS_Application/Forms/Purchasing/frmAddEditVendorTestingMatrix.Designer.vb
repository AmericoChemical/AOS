<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditVendorTestingMatrix

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
        Dim VendornameLabel As System.Windows.Forms.Label
        Dim TestLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ActiveLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditVendorTestingMatrix))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsVendorTestingMatrix = New System.Windows.Forms.BindingSource(Me.components)
        Me.eVendorID = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.lblModified = New DevExpress.XtraEditors.LabelControl()
        Me.lblCreated = New DevExpress.XtraEditors.LabelControl()
        Me.bsChemicalCategoryCollection = New System.Windows.Forms.BindingSource(Me.components)
        Me.PHCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SGCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ColorCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AppearanceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.eProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsProductsCollection = New System.Windows.Forms.BindingSource(Me.components)
        Me.eRetain = New DevExpress.XtraEditors.TextEdit()
        Me.eTest = New DevExpress.XtraEditors.TextEdit()
        Me.ChemicalCategoryLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ActiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        VendornameLabel = New System.Windows.Forms.Label()
        TestLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ActiveLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.bsVendorTestingMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChemicalCategoryCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppearanceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductsCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eRetain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eTest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalCategoryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendornameLabel
        '
        VendornameLabel.AutoSize = True
        VendornameLabel.Location = New System.Drawing.Point(57, 210)
        VendornameLabel.Name = "VendornameLabel"
        VendornameLabel.Size = New System.Drawing.Size(52, 13)
        VendornameLabel.TabIndex = 6
        VendornameLabel.Text = "% Retain"
        '
        'TestLabel
        '
        TestLabel.AutoSize = True
        TestLabel.Location = New System.Drawing.Point(239, 210)
        TestLabel.Name = "TestLabel"
        TestLabel.Size = New System.Drawing.Size(42, 13)
        TestLabel.TabIndex = 8
        TestLabel.Text = "% Test"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(91, 123)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(18, 13)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        '
        'ActiveLabel
        '
        ActiveLabel.AutoSize = True
        ActiveLabel.Location = New System.Drawing.Point(72, 237)
        ActiveLabel.Name = "ActiveLabel"
        ActiveLabel.Size = New System.Drawing.Size(37, 13)
        ActiveLabel.TabIndex = 10
        ActiveLabel.Text = "Active"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(12, 152)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(97, 13)
        Label6.TabIndex = 2
        Label6.Text = "Chemical Category"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(65, 181)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(44, 13)
        Label2.TabIndex = 4
        Label2.Text = "Product"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(469, 123)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(44, 13)
        Label3.TabIndex = 12
        Label3.Text = "Test PH"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(404, 146)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(109, 26)
        Label4.TabIndex = 14
        Label4.Text = " Test Specific Gravity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                           (SG)"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(457, 181)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(56, 13)
        Label5.TabIndex = 16
        Label5.Text = "Test Color"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(424, 207)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(89, 13)
        Label7.TabIndex = 18
        Label7.Text = "Test Appearance"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsVendorTestingMatrix
        '
        Me.bsVendorTestingMatrix.DataSource = GetType(AOS.BusinessObjects.Vendortestingmatrix)
        '
        'eVendorID
        '
        Me.eVendorID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Vendortestingmatrixid", True))
        Me.eVendorID.Location = New System.Drawing.Point(122, 120)
        Me.eVendorID.Name = "eVendorID"
        Me.eVendorID.Properties.ReadOnly = True
        Me.eVendorID.Size = New System.Drawing.Size(61, 20)
        Me.eVendorID.TabIndex = 1
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.rbtnSave, Me.rbtnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(558, 96)
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
        'rbtnSave
        '
        Me.rbtnSave.Caption = "Save"
        Me.rbtnSave.Id = 4
        Me.rbtnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.rbtnSave.LargeImageIndex = 0
        Me.rbtnSave.Name = "rbtnSave"
        '
        'rbtnCancel
        '
        Me.rbtnCancel.Caption = "Cancel"
        Me.rbtnCancel.Id = 5
        Me.rbtnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.rbtnCancel.LargeImageIndex = 1
        Me.rbtnCancel.Name = "rbtnCancel"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'lblModified
        '
        Me.lblModified.Location = New System.Drawing.Point(18, 526)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(0, 13)
        Me.lblModified.TabIndex = 59
        '
        'lblCreated
        '
        Me.lblCreated.Location = New System.Drawing.Point(18, 507)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(0, 13)
        Me.lblCreated.TabIndex = 58
        '
        'bsChemicalCategoryCollection
        '
        Me.bsChemicalCategoryCollection.DataSource = GetType(AOS.BusinessObjects.ListChemicalcategoryCollection)
        '
        'PHCheckEdit
        '
        Me.PHCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Ph", True))
        Me.PHCheckEdit.Location = New System.Drawing.Point(519, 121)
        Me.PHCheckEdit.MenuManager = Me.RibbonControl1
        Me.PHCheckEdit.Name = "PHCheckEdit"
        Me.PHCheckEdit.Properties.Caption = ""
        Me.PHCheckEdit.Size = New System.Drawing.Size(24, 19)
        Me.PHCheckEdit.TabIndex = 13
        '
        'SGCheckEdit
        '
        Me.SGCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Sg", True))
        Me.SGCheckEdit.Location = New System.Drawing.Point(519, 152)
        Me.SGCheckEdit.Name = "SGCheckEdit"
        Me.SGCheckEdit.Properties.Caption = ""
        Me.SGCheckEdit.Size = New System.Drawing.Size(24, 19)
        Me.SGCheckEdit.TabIndex = 15
        '
        'ColorCheckEdit
        '
        Me.ColorCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Color", True))
        Me.ColorCheckEdit.Location = New System.Drawing.Point(519, 180)
        Me.ColorCheckEdit.Name = "ColorCheckEdit"
        Me.ColorCheckEdit.Properties.Caption = ""
        Me.ColorCheckEdit.Size = New System.Drawing.Size(24, 19)
        Me.ColorCheckEdit.TabIndex = 17
        '
        'AppearanceCheckEdit
        '
        Me.AppearanceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Appearance", True))
        Me.AppearanceCheckEdit.Location = New System.Drawing.Point(519, 206)
        Me.AppearanceCheckEdit.Name = "AppearanceCheckEdit"
        Me.AppearanceCheckEdit.Properties.Caption = ""
        Me.AppearanceCheckEdit.Size = New System.Drawing.Size(24, 19)
        Me.AppearanceCheckEdit.TabIndex = 19
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'eProduct
        '
        Me.eProduct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Productid", True))
        Me.eProduct.Location = New System.Drawing.Point(122, 178)
        Me.eProduct.Name = "eProduct"
        Me.eProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", 100, "Addn Desc"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProduct.Properties.DataSource = Me.bsProductsCollection
        Me.eProduct.Properties.DisplayMember = "Productdesc"
        Me.eProduct.Properties.NullText = ""
        Me.eProduct.Properties.PopupWidth = 400
        Me.eProduct.Properties.ValueMember = "Productid"
        Me.eProduct.Size = New System.Drawing.Size(240, 20)
        Me.eProduct.TabIndex = 5
        '
        'bsProductsCollection
        '
        Me.bsProductsCollection.DataSource = GetType(AOS.BusinessObjects.ViewPriceListProductsCollection)
        '
        'eRetain
        '
        Me.eRetain.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Retainpercentage", True))
        Me.eRetain.EditValue = ""
        Me.eRetain.Location = New System.Drawing.Point(122, 207)
        Me.eRetain.Name = "eRetain"
        Me.eRetain.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eRetain.Properties.Mask.EditMask = "d"
        Me.eRetain.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eRetain.Properties.MaxLength = 3
        Me.eRetain.Size = New System.Drawing.Size(77, 20)
        Me.eRetain.TabIndex = 7
        '
        'eTest
        '
        Me.eTest.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Testpercentage", True))
        Me.eTest.EditValue = ""
        Me.eTest.Location = New System.Drawing.Point(285, 207)
        Me.eTest.Name = "eTest"
        Me.eTest.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eTest.Properties.Mask.EditMask = "d"
        Me.eTest.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eTest.Properties.MaxLength = 3
        Me.eTest.Size = New System.Drawing.Size(77, 20)
        Me.eTest.TabIndex = 9
        '
        'ChemicalCategoryLookUpEdit
        '
        Me.ChemicalCategoryLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Chemicalcategory", True))
        Me.ChemicalCategoryLookUpEdit.Location = New System.Drawing.Point(122, 149)
        Me.ChemicalCategoryLookUpEdit.Name = "ChemicalCategoryLookUpEdit"
        Me.ChemicalCategoryLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChemicalCategoryLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Chemicalcategoryid", "Chemicalcategoryid", 116, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Chemicalcategory", "Chemicalcategory", 95, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ChemicalCategoryLookUpEdit.Properties.DataSource = Me.bsChemicalCategoryCollection
        Me.ChemicalCategoryLookUpEdit.Properties.DisplayMember = "Chemicalcategory"
        Me.ChemicalCategoryLookUpEdit.Properties.NullText = ""
        Me.ChemicalCategoryLookUpEdit.Properties.PopupWidth = 400
        Me.ChemicalCategoryLookUpEdit.Properties.ValueMember = "Chemicalcategory"
        Me.ChemicalCategoryLookUpEdit.Size = New System.Drawing.Size(115, 20)
        Me.ChemicalCategoryLookUpEdit.TabIndex = 3
        '
        'ActiveCheckEdit
        '
        Me.ActiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorTestingMatrix, "Isactive", True))
        Me.ActiveCheckEdit.Location = New System.Drawing.Point(120, 234)
        Me.ActiveCheckEdit.Name = "ActiveCheckEdit"
        Me.ActiveCheckEdit.Properties.Caption = ""
        Me.ActiveCheckEdit.Size = New System.Drawing.Size(24, 19)
        Me.ActiveCheckEdit.TabIndex = 11
        '
        'frmAddEditVendorTestingMatrix
        '
        Me.ClientSize = New System.Drawing.Size(558, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.ActiveCheckEdit)
        Me.Controls.Add(Me.ChemicalCategoryLookUpEdit)
        Me.Controls.Add(Me.eTest)
        Me.Controls.Add(Me.eRetain)
        Me.Controls.Add(Me.eProduct)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.AppearanceCheckEdit)
        Me.Controls.Add(Me.ColorCheckEdit)
        Me.Controls.Add(Me.SGCheckEdit)
        Me.Controls.Add(Me.PHCheckEdit)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.lblModified)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(ActiveLabel)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.eVendorID)
        Me.Controls.Add(Label1)
        Me.Controls.Add(VendornameLabel)
        Me.Controls.Add(TestLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditVendorTestingMatrix"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.bsVendorTestingMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChemicalCategoryCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppearanceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductsCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eRetain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eTest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalCategoryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents eVendorID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents lblModified As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCreated As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PHCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SGCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ColorCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AppearanceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents bsVendorTestingMatrix As System.Windows.Forms.BindingSource
    Friend WithEvents bsChemicalCategoryCollection As System.Windows.Forms.BindingSource
    Friend WithEvents eProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsProductsCollection As System.Windows.Forms.BindingSource
    Friend WithEvents eRetain As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eTest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChemicalCategoryLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ActiveCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
