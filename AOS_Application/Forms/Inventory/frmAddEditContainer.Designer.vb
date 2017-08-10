<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditContainer

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
        Dim UnitcostLabel1 As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim UnitsLabel As System.Windows.Forms.Label
        Dim UomLabel As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eUOM = New DevExpress.XtraEditors.TextEdit()
        Me.eUnits = New DevExpress.XtraEditors.TextEdit()
        Me.eTareWeight = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        UnitcostLabel1 = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        UnitsLabel = New System.Windows.Forms.Label()
        UomLabel = New System.Windows.Forms.Label()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eTareWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UnitcostLabel1
        '
        UnitcostLabel1.AutoSize = True
        UnitcostLabel1.Location = New System.Drawing.Point(3, 181)
        UnitcostLabel1.Name = "UnitcostLabel1"
        UnitcostLabel1.Size = New System.Drawing.Size(66, 13)
        UnitcostLabel1.TabIndex = 23
        UnitcostLabel1.Text = "Tare Weight"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(15, 103)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 25
        ContainerLabel.Text = "Container"
        '
        'UnitsLabel
        '
        UnitsLabel.AutoSize = True
        UnitsLabel.Location = New System.Drawing.Point(38, 129)
        UnitsLabel.Name = "UnitsLabel"
        UnitsLabel.Size = New System.Drawing.Size(31, 13)
        UnitsLabel.TabIndex = 27
        UnitsLabel.Text = "Units"
        '
        'UomLabel
        '
        UomLabel.AutoSize = True
        UomLabel.Location = New System.Drawing.Point(39, 155)
        UomLabel.Name = "UomLabel"
        UomLabel.Size = New System.Drawing.Size(30, 13)
        UomLabel.TabIndex = 28
        UomLabel.Text = "UOM"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Container)
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(75, 100)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Size = New System.Drawing.Size(116, 20)
        Me.eContainer.TabIndex = 0
        '
        'eUOM
        '
        Me.eUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Uom", True))
        Me.eUOM.Location = New System.Drawing.Point(75, 152)
        Me.eUOM.Name = "eUOM"
        Me.eUOM.Size = New System.Drawing.Size(76, 20)
        Me.eUOM.TabIndex = 2
        '
        'eUnits
        '
        Me.eUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Units", True))
        Me.eUnits.Location = New System.Drawing.Point(75, 126)
        Me.eUnits.Name = "eUnits"
        Me.eUnits.Size = New System.Drawing.Size(47, 20)
        Me.eUnits.TabIndex = 1
        '
        'eTareWeight
        '
        Me.eTareWeight.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "TareWeight", True))
        Me.eTareWeight.Location = New System.Drawing.Point(75, 178)
        Me.eTareWeight.Name = "eTareWeight"
        Me.eTareWeight.Size = New System.Drawing.Size(47, 20)
        Me.eTareWeight.TabIndex = 3
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.BarButtonItem1, Me.BarButtonItem2})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(212, 93)
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Save"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Cancel"
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.BarButtonItem2.Name = "BarButtonItem2"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'frmAddEditContainer
        '
        Me.ClientSize = New System.Drawing.Size(212, 216)
        Me.ControlBox = False
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.eTareWeight)
        Me.Controls.Add(Me.eUnits)
        Me.Controls.Add(UomLabel)
        Me.Controls.Add(Me.eUOM)
        Me.Controls.Add(UnitsLabel)
        Me.Controls.Add(ContainerLabel)
        Me.Controls.Add(Me.eContainer)
        Me.Controls.Add(UnitcostLabel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditContainer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Container Information"
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eTareWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eTareWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
