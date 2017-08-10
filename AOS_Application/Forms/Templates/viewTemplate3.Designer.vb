<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewTemplate3

    'UserControl overrides dispose to clean up the component list.
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
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.grHeader = New CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormCaption
        '
        Me.FormCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormCaption.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCaption.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.FormCaption.EmbeddedNavigator.Appearance.Options.UseTextOptions = True
        Me.FormCaption.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.FormCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCaption.Location = New System.Drawing.Point(0, 0)
        Me.FormCaption.LookAndFeel.SkinName = "Money Twins"
        Me.FormCaption.MainView = Me.grHeader
        Me.FormCaption.Name = "FormCaption"
        Me.FormCaption.Size = New System.Drawing.Size(776, 33)
        Me.FormCaption.TabIndex = 3
        Me.FormCaption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grHeader})
        '
        'grHeader
        '
        Me.grHeader.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.grHeader.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grHeader.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.grHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grHeader.GridControl = Me.FormCaption
        Me.grHeader.GroupPanelText = "View Name"
        Me.grHeader.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.grHeader.Name = "grHeader"
        Me.grHeader.OptionsBehavior.SmartVertScrollBar = False
        Me.grHeader.OptionsCustomization.AllowFilter = False
        Me.grHeader.OptionsCustomization.AllowGroup = False
        Me.grHeader.OptionsCustomization.AllowSort = False
        Me.grHeader.OptionsMenu.EnableColumnMenu = False
        Me.grHeader.OptionsView.ShowColumnHeaders = False
        Me.grHeader.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.grHeader.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ApplicationCaption = "dsadsdsa"
        Me.RibbonControl1.ApplicationDocumentCaption = "dsdsadsa"
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddCustomer, Me.btnEditCustomer, Me.btnDeleteCustomer})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 51
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(776, 115)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Caption = "Add New"
        Me.btnAddCustomer.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddCustomer.Id = 41
        Me.btnAddCustomer.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddCustomer.Name = "btnAddCustomer"
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Caption = "Edit"
        Me.btnEditCustomer.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCustomer.Id = 42
        Me.btnEditCustomer.Name = "btnEditCustomer"
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Caption = "Delete"
        Me.btnDeleteCustomer.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCustomer.Id = 43
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Group 1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddCustomer)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditCustomer)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDeleteCustomer)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Group 1 Info"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl9)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl8)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl7)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 148)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(776, 275)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl9
        '
        Me.RibbonPanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl9.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl9.Name = "RibbonPanelControl9"
        Me.RibbonPanelControl9.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl9.TabIndex = 6
        '
        'RibbonPanelControl8
        '
        Me.RibbonPanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl8.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl8.Name = "RibbonPanelControl8"
        Me.RibbonPanelControl8.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl8.TabIndex = 5
        '
        'RibbonPanelControl7
        '
        Me.RibbonPanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl7.Name = "RibbonPanelControl7"
        Me.RibbonPanelControl7.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl7.TabIndex = 4
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl5.TabIndex = 3
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl1.TabIndex = 2
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl2.TabIndex = 1
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(776, 275)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'viewDataAnalysis
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewDataAnalysis"
        Me.Size = New System.Drawing.Size(776, 423)
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents grHeader As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAddCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
