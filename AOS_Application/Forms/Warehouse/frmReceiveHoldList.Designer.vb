<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceiveHoldList


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceiveHoldList))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnBack = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReturnToPriorStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReceivedToInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnChangeItemStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnResolveItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGHSLabel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colRecvholdid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEventid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReasoncode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReasontext = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoldtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.bsEvents = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomDevExGridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colEventID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEventTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEventWho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEventType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvItemNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLabelWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScaleWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEventNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPallet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFailedLabelWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFailedMaterialWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsautolabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.ViewReceivedHoldItemsCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnBack, Me.rbtnReturnToPriorStatus, Me.rbtnReceivedToInventory, Me.rbtnChangeItemStatus, Me.rbtnResolveItem, Me.rbtnGHSLabel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 12
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1266, 116)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnBack
        '
        Me.btnBack.Caption = "Back"
        Me.btnBack.Id = 5
        Me.btnBack.ImageOptions.LargeImageIndex = 36
        Me.btnBack.Name = "btnBack"
        '
        'rbtnReturnToPriorStatus
        '
        Me.rbtnReturnToPriorStatus.Caption = "Return to Prior Status"
        Me.rbtnReturnToPriorStatus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnReturnToPriorStatus.Id = 7
        Me.rbtnReturnToPriorStatus.ImageOptions.LargeImageIndex = 37
        Me.rbtnReturnToPriorStatus.Name = "rbtnReturnToPriorStatus"
        '
        'rbtnReceivedToInventory
        '
        Me.rbtnReceivedToInventory.Caption = "Move to Next Status"
        Me.rbtnReceivedToInventory.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnReceivedToInventory.Id = 8
        Me.rbtnReceivedToInventory.ImageOptions.LargeImageIndex = 38
        Me.rbtnReceivedToInventory.Name = "rbtnReceivedToInventory"
        '
        'rbtnChangeItemStatus
        '
        Me.rbtnChangeItemStatus.Caption = "Change Item Status"
        Me.rbtnChangeItemStatus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnChangeItemStatus.Id = 9
        Me.rbtnChangeItemStatus.ImageOptions.LargeImageIndex = 39
        Me.rbtnChangeItemStatus.Name = "rbtnChangeItemStatus"
        '
        'rbtnResolveItem
        '
        Me.rbtnResolveItem.Caption = "Resolve Item"
        Me.rbtnResolveItem.Id = 10
        Me.rbtnResolveItem.ImageOptions.LargeImageIndex = 27
        Me.rbtnResolveItem.Name = "rbtnResolveItem"
        '
        'rbtnGHSLabel
        '
        Me.rbtnGHSLabel.Caption = "Print GHS Label && Continue"
        Me.rbtnGHSLabel.Id = 11
        Me.rbtnGHSLabel.ImageOptions.LargeImageIndex = 24
        Me.rbtnGHSLabel.Name = "rbtnGHSLabel"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnBack)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnReturnToPriorStatus)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnReceivedToInventory)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnChangeItemStatus, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnResolveItem)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Item Processing"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnGHSLabel)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Auto Label"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 116)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1266, 276)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Inventory Items on Received / Hold Status"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bs
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1262, 254)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecvholdid, Me.colInvitemnumber, Me.colEventid, Me.colReasoncode, Me.colReasontext, Me.colHoldtime, Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colLotnumber, Me.colItemstatus})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colRecvholdid
        '
        Me.colRecvholdid.FieldName = "Recvholdid"
        Me.colRecvholdid.Name = "colRecvholdid"
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Item#"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 0
        Me.colInvitemnumber.Width = 72
        '
        'colEventid
        '
        Me.colEventid.Caption = "Event ID"
        Me.colEventid.FieldName = "Eventid"
        Me.colEventid.Name = "colEventid"
        Me.colEventid.Visible = True
        Me.colEventid.VisibleIndex = 1
        Me.colEventid.Width = 60
        '
        'colReasoncode
        '
        Me.colReasoncode.Caption = "Reason Code"
        Me.colReasoncode.FieldName = "Reasoncode"
        Me.colReasoncode.Name = "colReasoncode"
        Me.colReasoncode.Visible = True
        Me.colReasoncode.VisibleIndex = 2
        Me.colReasoncode.Width = 115
        '
        'colReasontext
        '
        Me.colReasontext.Caption = "Reason Text"
        Me.colReasontext.FieldName = "Reasontext"
        Me.colReasontext.Name = "colReasontext"
        Me.colReasontext.Visible = True
        Me.colReasontext.VisibleIndex = 3
        Me.colReasontext.Width = 351
        '
        'colHoldtime
        '
        Me.colHoldtime.Caption = "Hold Time"
        Me.colHoldtime.FieldName = "Holdtime"
        Me.colHoldtime.Name = "colHoldtime"
        Me.colHoldtime.Visible = True
        Me.colHoldtime.VisibleIndex = 4
        Me.colHoldtime.Width = 79
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 5
        Me.colProductid.Width = 60
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 6
        Me.colProductdesc.Width = 278
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 7
        Me.colContainer.Width = 59
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot #"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 8
        Me.colLotnumber.Width = 96
        '
        'colItemstatus
        '
        Me.colItemstatus.Caption = "Curr Status"
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 9
        Me.colItemstatus.Width = 92
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 392)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1266, 163)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Inventory Items on Received / Hold Status"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsEvents
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.MainView = Me.CustomDevExGridView1
        Me.GridControl2.MenuManager = Me.RibbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1262, 141)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CustomDevExGridView1})
        '
        'bsEvents
        '
        Me.bsEvents.DataSource = GetType(AOS.BusinessObjects.ReceivingeventCollection)
        '
        'CustomDevExGridView1
        '
        Me.CustomDevExGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEventID1, Me.colEventTime, Me.colEventWho, Me.colEventType, Me.colInvItemNumber1, Me.colDocumentType, Me.colDocumentID, Me.colLabelWeight, Me.colScaleWeight, Me.colLotNumber1, Me.colEventNotes, Me.colPallet, Me.colProductID1, Me.colContainer1, Me.colFailedLabelWeight, Me.colFailedMaterialWeight, Me.colIsautolabel, Me.colItemStatus1})
        Me.CustomDevExGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.CustomDevExGridView1.GridControl = Me.GridControl2
        Me.CustomDevExGridView1.Name = "CustomDevExGridView1"
        Me.CustomDevExGridView1.OptionsBehavior.Editable = False
        Me.CustomDevExGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CustomDevExGridView1.OptionsView.ShowAutoFilterRow = True
        Me.CustomDevExGridView1.OptionsView.ShowGroupPanel = False
        Me.CustomDevExGridView1.OptionsView.ShowIndicator = False
        '
        'colEventID1
        '
        Me.colEventID1.FieldName = "EventID"
        Me.colEventID1.Name = "colEventID1"
        Me.colEventID1.Visible = True
        Me.colEventID1.VisibleIndex = 0
        '
        'colEventTime
        '
        Me.colEventTime.FieldName = "EventTime"
        Me.colEventTime.Name = "colEventTime"
        Me.colEventTime.Visible = True
        Me.colEventTime.VisibleIndex = 1
        '
        'colEventWho
        '
        Me.colEventWho.FieldName = "EventWho"
        Me.colEventWho.Name = "colEventWho"
        Me.colEventWho.Visible = True
        Me.colEventWho.VisibleIndex = 2
        '
        'colEventType
        '
        Me.colEventType.FieldName = "EventType"
        Me.colEventType.Name = "colEventType"
        Me.colEventType.Visible = True
        Me.colEventType.VisibleIndex = 3
        '
        'colInvItemNumber1
        '
        Me.colInvItemNumber1.FieldName = "InvItemNumber"
        Me.colInvItemNumber1.Name = "colInvItemNumber1"
        Me.colInvItemNumber1.Visible = True
        Me.colInvItemNumber1.VisibleIndex = 4
        '
        'colDocumentType
        '
        Me.colDocumentType.FieldName = "DocumentType"
        Me.colDocumentType.Name = "colDocumentType"
        Me.colDocumentType.Visible = True
        Me.colDocumentType.VisibleIndex = 5
        '
        'colDocumentID
        '
        Me.colDocumentID.FieldName = "DocumentID"
        Me.colDocumentID.Name = "colDocumentID"
        Me.colDocumentID.Visible = True
        Me.colDocumentID.VisibleIndex = 6
        '
        'colLabelWeight
        '
        Me.colLabelWeight.FieldName = "LabelWeight"
        Me.colLabelWeight.Name = "colLabelWeight"
        Me.colLabelWeight.Visible = True
        Me.colLabelWeight.VisibleIndex = 7
        '
        'colScaleWeight
        '
        Me.colScaleWeight.FieldName = "ScaleWeight"
        Me.colScaleWeight.Name = "colScaleWeight"
        Me.colScaleWeight.Visible = True
        Me.colScaleWeight.VisibleIndex = 8
        '
        'colLotNumber1
        '
        Me.colLotNumber1.FieldName = "LotNumber"
        Me.colLotNumber1.Name = "colLotNumber1"
        Me.colLotNumber1.Visible = True
        Me.colLotNumber1.VisibleIndex = 9
        '
        'colEventNotes
        '
        Me.colEventNotes.FieldName = "EventNotes"
        Me.colEventNotes.Name = "colEventNotes"
        Me.colEventNotes.Visible = True
        Me.colEventNotes.VisibleIndex = 10
        '
        'colPallet
        '
        Me.colPallet.FieldName = "Pallet"
        Me.colPallet.Name = "colPallet"
        Me.colPallet.Visible = True
        Me.colPallet.VisibleIndex = 11
        '
        'colProductID1
        '
        Me.colProductID1.FieldName = "ProductID"
        Me.colProductID1.Name = "colProductID1"
        Me.colProductID1.Visible = True
        Me.colProductID1.VisibleIndex = 12
        '
        'colContainer1
        '
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 13
        '
        'colFailedLabelWeight
        '
        Me.colFailedLabelWeight.FieldName = "FailedLabelWeight"
        Me.colFailedLabelWeight.Name = "colFailedLabelWeight"
        Me.colFailedLabelWeight.Visible = True
        Me.colFailedLabelWeight.VisibleIndex = 14
        '
        'colFailedMaterialWeight
        '
        Me.colFailedMaterialWeight.FieldName = "FailedMaterialWeight"
        Me.colFailedMaterialWeight.Name = "colFailedMaterialWeight"
        Me.colFailedMaterialWeight.Visible = True
        Me.colFailedMaterialWeight.VisibleIndex = 15
        '
        'colIsautolabel
        '
        Me.colIsautolabel.FieldName = "Isautolabel"
        Me.colIsautolabel.Name = "colIsautolabel"
        Me.colIsautolabel.Visible = True
        Me.colIsautolabel.VisibleIndex = 16
        '
        'colItemStatus1
        '
        Me.colItemStatus1.FieldName = "ItemStatus"
        Me.colItemStatus1.Name = "colItemStatus1"
        Me.colItemStatus1.Visible = True
        Me.colItemStatus1.VisibleIndex = 17
        '
        'frmReceiveHoldList
        '
        Me.ClientSize = New System.Drawing.Size(1266, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReceiveHoldList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory Items on Received / Hold Status"
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnBack As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents rbtnReturnToPriorStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnReceivedToInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnChangeItemStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colRecvholdid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReasoncode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReasontext As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoldtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEventid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend CustomDevExGridView1 As CustomDevExGridView
    Friend WithEvents bsEvents As BindingSource
    Friend WithEvents colEventID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEventTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEventWho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEventType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvItemNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLabelWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScaleWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEventNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPallet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFailedLabelWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFailedMaterialWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnResolveItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colIsautolabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnGHSLabel As DevExpress.XtraBars.BarButtonItem
End Class
