<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectProduct

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
        Me.grpTitle = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdgallons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHealth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFire = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReactivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonalprotection = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDotdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnline = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlacardrequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassrate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyonhand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyallocated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyonorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyforsale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyminonhand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReorderqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreferredvendorid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatecostlastchanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesc2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryclass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsliquid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRawmaterialgroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventorygrouping = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolumeuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolumeunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventorymethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifyby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifytime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhrangelow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhrangehigh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSgrangelow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSgrangehigh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeedstesting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShelflife = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazclassnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackagegroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChemicalid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsinhazox = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitle.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.PanelControl1)
        Me.grpTitle.Controls.Add(Me.SimpleButton1)
        Me.grpTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTitle.Location = New System.Drawing.Point(0, 0)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Padding = New System.Windows.Forms.Padding(6)
        Me.grpTitle.Size = New System.Drawing.Size(967, 327)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.Text = "Select a Product:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GridControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(8, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(951, 215)
        Me.PanelControl1.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsProducts
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(947, 211)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colStdweight, Me.colStdgallons, Me.colContainer, Me.colHealth, Me.colFire, Me.colReactivity, Me.colPersonalprotection, Me.colDotdesc, Me.colHazmatdesc, Me.colUnline, Me.colPlacardrequired, Me.colClassrate, Me.colHazmatid, Me.colQtyonhand, Me.colQtyallocated, Me.colQtyonorder, Me.colQtyforsale, Me.colQtyminonhand, Me.colReorderqty, Me.colPreferredvendorid, Me.colUnitcost, Me.colDatecostlastchanged, Me.colUnits, Me.colUom, Me.colDesc2, Me.colInventoryclass, Me.colIsactive, Me.colCustid, Me.colIsliquid, Me.colRawmaterialgroup, Me.colInventorygrouping, Me.colWeightuom, Me.colWeightunits, Me.colVolumeuom, Me.colProductstatus, Me.colVolumeunits, Me.colInventorymethod, Me.colUnnumber, Me.colCreatedby, Me.colCreatedtime, Me.colModifyby, Me.colModifytime, Me.colPhrangelow, Me.colPhrangehigh, Me.colSgrangelow, Me.colSgrangehigh, Me.colNeedstesting, Me.colShelflife, Me.colHazclassnumber, Me.colPackagegroup, Me.colChemicalid, Me.colIdnumber, Me.colState, Me.colIsinhazox})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 55
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Desc"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 289
        '
        'colStdweight
        '
        Me.colStdweight.FieldName = "Stdweight"
        Me.colStdweight.Name = "colStdweight"
        '
        'colStdgallons
        '
        Me.colStdgallons.FieldName = "Stdgallons"
        Me.colStdgallons.Name = "colStdgallons"
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 88
        '
        'colHealth
        '
        Me.colHealth.FieldName = "Health"
        Me.colHealth.Name = "colHealth"
        '
        'colFire
        '
        Me.colFire.FieldName = "Fire"
        Me.colFire.Name = "colFire"
        '
        'colReactivity
        '
        Me.colReactivity.FieldName = "Reactivity"
        Me.colReactivity.Name = "colReactivity"
        '
        'colPersonalprotection
        '
        Me.colPersonalprotection.FieldName = "Personalprotection"
        Me.colPersonalprotection.Name = "colPersonalprotection"
        '
        'colDotdesc
        '
        Me.colDotdesc.FieldName = "Dotdesc"
        Me.colDotdesc.Name = "colDotdesc"
        '
        'colHazmatdesc
        '
        Me.colHazmatdesc.FieldName = "Hazmatdesc"
        Me.colHazmatdesc.Name = "colHazmatdesc"
        '
        'colUnline
        '
        Me.colUnline.FieldName = "Unline"
        Me.colUnline.Name = "colUnline"
        '
        'colPlacardrequired
        '
        Me.colPlacardrequired.FieldName = "Placardrequired"
        Me.colPlacardrequired.Name = "colPlacardrequired"
        '
        'colClassrate
        '
        Me.colClassrate.FieldName = "Classrate"
        Me.colClassrate.Name = "colClassrate"
        '
        'colHazmatid
        '
        Me.colHazmatid.FieldName = "Hazmatid"
        Me.colHazmatid.Name = "colHazmatid"
        '
        'colQtyonhand
        '
        Me.colQtyonhand.FieldName = "Qtyonhand"
        Me.colQtyonhand.Name = "colQtyonhand"
        '
        'colQtyallocated
        '
        Me.colQtyallocated.FieldName = "Qtyallocated"
        Me.colQtyallocated.Name = "colQtyallocated"
        '
        'colQtyonorder
        '
        Me.colQtyonorder.FieldName = "Qtyonorder"
        Me.colQtyonorder.Name = "colQtyonorder"
        '
        'colQtyforsale
        '
        Me.colQtyforsale.FieldName = "Qtyforsale"
        Me.colQtyforsale.Name = "colQtyforsale"
        '
        'colQtyminonhand
        '
        Me.colQtyminonhand.FieldName = "Qtyminonhand"
        Me.colQtyminonhand.Name = "colQtyminonhand"
        '
        'colReorderqty
        '
        Me.colReorderqty.FieldName = "Reorderqty"
        Me.colReorderqty.Name = "colReorderqty"
        '
        'colPreferredvendorid
        '
        Me.colPreferredvendorid.FieldName = "Preferredvendorid"
        Me.colPreferredvendorid.Name = "colPreferredvendorid"
        '
        'colUnitcost
        '
        Me.colUnitcost.FieldName = "Unitcost"
        Me.colUnitcost.Name = "colUnitcost"
        '
        'colDatecostlastchanged
        '
        Me.colDatecostlastchanged.FieldName = "Datecostlastchanged"
        Me.colDatecostlastchanged.Name = "colDatecostlastchanged"
        '
        'colUnits
        '
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        '
        'colUom
        '
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        '
        'colDesc2
        '
        Me.colDesc2.Caption = "Addl Desc"
        Me.colDesc2.FieldName = "Desc2"
        Me.colDesc2.Name = "colDesc2"
        Me.colDesc2.Visible = True
        Me.colDesc2.VisibleIndex = 2
        Me.colDesc2.Width = 252
        '
        'colInventoryclass
        '
        Me.colInventoryclass.FieldName = "Inventoryclass"
        Me.colInventoryclass.Name = "colInventoryclass"
        '
        'colIsactive
        '
        Me.colIsactive.Caption = "Active"
        Me.colIsactive.FieldName = "Isactive"
        Me.colIsactive.Name = "colIsactive"
        Me.colIsactive.Width = 99
        '
        'colCustid
        '
        Me.colCustid.FieldName = "Custid"
        Me.colCustid.Name = "colCustid"
        '
        'colIsliquid
        '
        Me.colIsliquid.FieldName = "Isliquid"
        Me.colIsliquid.Name = "colIsliquid"
        '
        'colRawmaterialgroup
        '
        Me.colRawmaterialgroup.FieldName = "Rawmaterialgroup"
        Me.colRawmaterialgroup.Name = "colRawmaterialgroup"
        '
        'colInventorygrouping
        '
        Me.colInventorygrouping.FieldName = "Inventorygrouping"
        Me.colInventorygrouping.Name = "colInventorygrouping"
        '
        'colWeightuom
        '
        Me.colWeightuom.FieldName = "Weightuom"
        Me.colWeightuom.Name = "colWeightuom"
        '
        'colWeightunits
        '
        Me.colWeightunits.FieldName = "Weightunits"
        Me.colWeightunits.Name = "colWeightunits"
        '
        'colVolumeuom
        '
        Me.colVolumeuom.FieldName = "Volumeuom"
        Me.colVolumeuom.Name = "colVolumeuom"
        '
        'colProductstatus
        '
        Me.colProductstatus.Caption = "Status"
        Me.colProductstatus.FieldName = "Productstatus"
        Me.colProductstatus.Name = "colProductstatus"
        Me.colProductstatus.Visible = True
        Me.colProductstatus.VisibleIndex = 4
        '
        'colVolumeunits
        '
        Me.colVolumeunits.FieldName = "Volumeunits"
        Me.colVolumeunits.Name = "colVolumeunits"
        '
        'colInventorymethod
        '
        Me.colInventorymethod.FieldName = "Inventorymethod"
        Me.colInventorymethod.Name = "colInventorymethod"
        '
        'colUnnumber
        '
        Me.colUnnumber.FieldName = "Unnumber"
        Me.colUnnumber.Name = "colUnnumber"
        '
        'colCreatedby
        '
        Me.colCreatedby.FieldName = "Createdby"
        Me.colCreatedby.Name = "colCreatedby"
        '
        'colCreatedtime
        '
        Me.colCreatedtime.FieldName = "Createdtime"
        Me.colCreatedtime.Name = "colCreatedtime"
        '
        'colModifyby
        '
        Me.colModifyby.FieldName = "Modifyby"
        Me.colModifyby.Name = "colModifyby"
        '
        'colModifytime
        '
        Me.colModifytime.FieldName = "Modifytime"
        Me.colModifytime.Name = "colModifytime"
        '
        'colPhrangelow
        '
        Me.colPhrangelow.FieldName = "Phrangelow"
        Me.colPhrangelow.Name = "colPhrangelow"
        '
        'colPhrangehigh
        '
        Me.colPhrangehigh.FieldName = "Phrangehigh"
        Me.colPhrangehigh.Name = "colPhrangehigh"
        '
        'colSgrangelow
        '
        Me.colSgrangelow.FieldName = "Sgrangelow"
        Me.colSgrangelow.Name = "colSgrangelow"
        '
        'colSgrangehigh
        '
        Me.colSgrangehigh.FieldName = "Sgrangehigh"
        Me.colSgrangehigh.Name = "colSgrangehigh"
        '
        'colNeedstesting
        '
        Me.colNeedstesting.FieldName = "Needstesting"
        Me.colNeedstesting.Name = "colNeedstesting"
        '
        'colShelflife
        '
        Me.colShelflife.FieldName = "Shelflife"
        Me.colShelflife.Name = "colShelflife"
        '
        'colHazclassnumber
        '
        Me.colHazclassnumber.FieldName = "Hazclassnumber"
        Me.colHazclassnumber.Name = "colHazclassnumber"
        '
        'colPackagegroup
        '
        Me.colPackagegroup.FieldName = "Packagegroup"
        Me.colPackagegroup.Name = "colPackagegroup"
        '
        'colChemicalid
        '
        Me.colChemicalid.FieldName = "Chemicalid"
        Me.colChemicalid.Name = "colChemicalid"
        '
        'colIdnumber
        '
        Me.colIdnumber.FieldName = "Idnumber"
        Me.colIdnumber.Name = "colIdnumber"
        '
        'colState
        '
        Me.colState.FieldName = "State"
        Me.colState.Name = "colState"
        '
        'colIsinhazox
        '
        Me.colIsinhazox.FieldName = "Isinhazox"
        Me.colIsinhazox.Name = "colIsinhazox"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(419, 293)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(128, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "OK"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmSelectProduct
        '
        Me.ClientSize = New System.Drawing.Size(967, 327)
        Me.Controls.Add(Me.grpTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSelectProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGetDataItem"
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitle.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTitle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdgallons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHealth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFire As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReactivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonalprotection As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDotdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnline As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlacardrequired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassrate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyonhand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyallocated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyonorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyforsale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyminonhand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReorderqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreferredvendorid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatecostlastchanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryclass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsliquid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRawmaterialgroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventorygrouping As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolumeuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolumeunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventorymethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifyby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifytime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhrangelow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhrangehigh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSgrangelow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSgrangehigh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeedstesting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShelflife As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazclassnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackagegroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChemicalid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsinhazox As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents colProductstatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
