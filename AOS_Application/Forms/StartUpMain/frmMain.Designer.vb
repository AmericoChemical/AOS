<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.viewPanel = New DevExpress.XtraEditors.PanelControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.mainMenuBar = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem9 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.mnuPurchasing = New DevExpress.XtraBars.BarSubItem()
        Me.mnuProduction = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem10 = New DevExpress.XtraBars.BarSubItem()
        Me.mnuWarehouse = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem12 = New DevExpress.XtraBars.BarSubItem()
        Me.mnuBDF = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.mnuDataAnalysis = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem14 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem8 = New DevExpress.XtraBars.BarSubItem()
        Me.SkinsList = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.StatusVersionNum = New DevExpress.XtraBars.BarStaticItem()
        Me.StatusSQLServerName = New DevExpress.XtraBars.BarStaticItem()
        Me.StatusSQLServerDBName = New DevExpress.XtraBars.BarStaticItem()
        Me.StatusUserFullName = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.StatusCurrentDateTime = New DevExpress.XtraBars.BarStaticItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem11 = New DevExpress.XtraBars.BarSubItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.viewPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewPanel
        '
        Me.viewPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.viewPanel.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.viewPanel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.viewPanel.Appearance.Options.UseBackColor = True
        Me.viewPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewPanel.Location = New System.Drawing.Point(0, 22)
        Me.viewPanel.LookAndFeel.SkinName = "Money Twins"
        Me.viewPanel.Name = "viewPanel"
        Me.viewPanel.Size = New System.Drawing.Size(1315, 582)
        Me.viewPanel.TabIndex = 5
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.mainMenuBar, Me.Bar1})
        Me.BarManager1.Controller = Me.BarAndDockingController1
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem5, Me.BarSubItem6, Me.mnuWarehouse, Me.mnuProduction, Me.BarSubItem7, Me.BarSubItem8, Me.SkinsList, Me.StatusVersionNum, Me.StatusSQLServerName, Me.StatusUserFullName, Me.StatusCurrentDateTime, Me.BarStaticItem4, Me.BarSubItem9, Me.BarSubItem12, Me.BarSubItem10, Me.mnuBDF, Me.BarSubItem11, Me.mnuDataAnalysis, Me.StatusSQLServerDBName, Me.BarSubItem14, Me.mnuPurchasing})
        Me.BarManager1.MainMenu = Me.mainMenuBar
        Me.BarManager1.MaxItemId = 34
        Me.BarManager1.StatusBar = Me.Bar1
        '
        'mainMenuBar
        '
        Me.mainMenuBar.BarName = "Main menu"
        Me.mainMenuBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.mainMenuBar.DockCol = 0
        Me.mainMenuBar.DockRow = 0
        Me.mainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.mainMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuPurchasing), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuProduction), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuWarehouse), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuBDF), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDataAnalysis), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem7)})
        Me.mainMenuBar.OptionsBar.AllowQuickCustomization = False
        Me.mainMenuBar.OptionsBar.DrawDragBorder = False
        Me.mainMenuBar.OptionsBar.RotateWhenVertical = False
        Me.mainMenuBar.OptionsBar.UseWholeRow = True
        Me.mainMenuBar.Text = "Main menu"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Home"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Sales/Customers"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.Name = "BarSubItem2"
        Me.BarSubItem2.Tag = "10"
        '
        'BarSubItem9
        '
        Me.BarSubItem9.Caption = "Work Orders"
        Me.BarSubItem9.Id = 19
        Me.BarSubItem9.Name = "BarSubItem9"
        Me.BarSubItem9.Tag = "14"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Inventory"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.Name = "BarSubItem4"
        Me.BarSubItem4.Tag = "13"
        '
        'mnuPurchasing
        '
        Me.mnuPurchasing.Caption = "Purchasing"
        Me.mnuPurchasing.Id = 31
        Me.mnuPurchasing.Name = "mnuPurchasing"
        Me.mnuPurchasing.Tag = "64"
        '
        'mnuProduction
        '
        Me.mnuProduction.Caption = "Production"
        Me.mnuProduction.Id = 7
        Me.mnuProduction.Name = "mnuProduction"
        Me.mnuProduction.Tag = "15"
        '
        'BarSubItem10
        '
        Me.BarSubItem10.Caption = "Chem Lab"
        Me.BarSubItem10.Id = 24
        Me.BarSubItem10.Name = "BarSubItem10"
        Me.BarSubItem10.Tag = "19"
        '
        'mnuWarehouse
        '
        Me.mnuWarehouse.Caption = "Warehouse"
        Me.mnuWarehouse.Id = 6
        Me.mnuWarehouse.Name = "mnuWarehouse"
        Me.mnuWarehouse.Tag = "12"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Shipping"
        Me.BarSubItem5.Id = 4
        Me.BarSubItem5.Name = "BarSubItem5"
        Me.BarSubItem5.Tag = "17"
        '
        'BarSubItem12
        '
        Me.BarSubItem12.Caption = "Freight Mgmt"
        Me.BarSubItem12.Id = 23
        Me.BarSubItem12.Name = "BarSubItem12"
        Me.BarSubItem12.Tag = "16"
        '
        'mnuBDF
        '
        Me.mnuBDF.Caption = "BDF"
        Me.mnuBDF.Id = 25
        Me.mnuBDF.Name = "mnuBDF"
        Me.mnuBDF.Tag = "60"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Administration"
        Me.BarSubItem6.Id = 5
        Me.BarSubItem6.Name = "BarSubItem6"
        Me.BarSubItem6.Tag = "18"
        '
        'mnuDataAnalysis
        '
        Me.mnuDataAnalysis.Caption = "Data Analysis"
        Me.mnuDataAnalysis.Id = 28
        Me.mnuDataAnalysis.Name = "mnuDataAnalysis"
        Me.mnuDataAnalysis.Tag = "62"
        '
        'BarSubItem14
        '
        Me.BarSubItem14.Caption = "Audit"
        Me.BarSubItem14.Id = 31
        Me.BarSubItem14.Name = "BarSubItem14"
        Me.BarSubItem14.Tag = "63"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSubItem7.Caption = "User Settings"
        Me.BarSubItem7.Id = 8
        Me.BarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem8)})
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarSubItem8
        '
        Me.BarSubItem8.Caption = "Appearance"
        Me.BarSubItem8.Id = 9
        Me.BarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SkinsList)})
        Me.BarSubItem8.Name = "BarSubItem8"
        '
        'SkinsList
        '
        Me.SkinsList.Caption = "Skins List"
        Me.SkinsList.Id = 10
        Me.SkinsList.Name = "SkinsList"
        '
        'Bar1
        '
        Me.Bar1.BarName = "StatusBar"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.StatusVersionNum), New DevExpress.XtraBars.LinkPersistInfo(Me.StatusSQLServerName), New DevExpress.XtraBars.LinkPersistInfo(Me.StatusSQLServerDBName), New DevExpress.XtraBars.LinkPersistInfo(Me.StatusUserFullName), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.StatusCurrentDateTime)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "StatusBar"
        '
        'StatusVersionNum
        '
        Me.StatusVersionNum.Caption = "Version: 1.013"
        Me.StatusVersionNum.Id = 11
        Me.StatusVersionNum.Name = "StatusVersionNum"
        Me.StatusVersionNum.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'StatusSQLServerName
        '
        Me.StatusSQLServerName.Caption = "ACPI-SQL\AMERICO"
        Me.StatusSQLServerName.Id = 12
        Me.StatusSQLServerName.Name = "StatusSQLServerName"
        Me.StatusSQLServerName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'StatusSQLServerDBName
        '
        Me.StatusSQLServerDBName.Caption = "AOSData"
        Me.StatusSQLServerDBName.Id = 29
        Me.StatusSQLServerDBName.Name = "StatusSQLServerDBName"
        Me.StatusSQLServerDBName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'StatusUserFullName
        '
        Me.StatusUserFullName.Caption = "User Fullname"
        Me.StatusUserFullName.Id = 13
        Me.StatusUserFullName.Name = "StatusUserFullName"
        Me.StatusUserFullName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.BarStaticItem4.Caption = " "
        Me.BarStaticItem4.Id = 17
        Me.BarStaticItem4.Name = "BarStaticItem4"
        Me.BarStaticItem4.Size = New System.Drawing.Size(250, 0)
        Me.BarStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'StatusCurrentDateTime
        '
        Me.StatusCurrentDateTime.Caption = "Saturday, February 5, 2011  6:32pm"
        Me.StatusCurrentDateTime.Id = 16
        Me.StatusCurrentDateTime.Name = "StatusCurrentDateTime"
        Me.StatusCurrentDateTime.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1315, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 604)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1315, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 582)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1315, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 582)
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Purchasing_Old"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.Name = "BarSubItem3"
        Me.BarSubItem3.Tag = "11"
        '
        'BarSubItem11
        '
        Me.BarSubItem11.Caption = "BarSubItem11"
        Me.BarSubItem11.Id = 26
        Me.BarSubItem11.Name = "BarSubItem11"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Seven"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1315, 633)
        Me.Controls.Add(Me.viewPanel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AOS - Americo Operations System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.viewPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents mainMenuBar As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents mnuWarehouse As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuProduction As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem8 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents SkinsList As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents StatusVersionNum As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents StatusSQLServerName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents StatusUserFullName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents StatusCurrentDateTime As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarSubItem9 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem10 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem12 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents mnuBDF As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuDataAnalysis As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem11 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents StatusSQLServerDBName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarSubItem14 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuPurchasing As DevExpress.XtraBars.BarSubItem
End Class
