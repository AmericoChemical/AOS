<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMergeProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grRemove = New DevExpress.XtraGrid.GridControl()
        Me.bsKeep = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New CustomDevExGridView()
        Me.colProductid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grKeep = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblKeep = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblReplace = New DevExpress.XtraEditors.LabelControl()
        Me.btnMerge = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnFinished = New DevExpress.XtraEditors.SimpleButton()
        Me.bsRemove = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKeep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grKeep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.bsRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.PanelControl3)
        Me.GroupControl1.Controls.Add(Me.PanelControl2)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(460, 566)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Product Maintenance: Merging One Product into Another Product"
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.grRemove)
        Me.PanelControl3.Controls.Add(Me.grKeep)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(2, 85)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(456, 445)
        Me.PanelControl3.TabIndex = 2
        '
        'grRemove
        '
        Me.grRemove.DataSource = Me.bsKeep
        Me.grRemove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grRemove.Location = New System.Drawing.Point(0, 220)
        Me.grRemove.MainView = Me.GridView2
        Me.grRemove.Name = "grRemove"
        Me.grRemove.Size = New System.Drawing.Size(456, 225)
        Me.grRemove.TabIndex = 1
        Me.grRemove.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsKeep
        '
        Me.bsKeep.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid1, Me.colProductdesc1, Me.colContainer1})
        Me.GridView2.GridControl = Me.grRemove
        Me.GridView2.GroupPanelText = "This Product will be REMOVED"
        Me.GridView2.Name = "GridView2"
        '
        'colProductid1
        '
        Me.colProductid1.Caption = "Prod ID"
        Me.colProductid1.FieldName = "Productid"
        Me.colProductid1.Name = "colProductid1"
        Me.colProductid1.OptionsColumn.AllowEdit = False
        Me.colProductid1.Visible = True
        Me.colProductid1.VisibleIndex = 0
        Me.colProductid1.Width = 69
        '
        'colProductdesc1
        '
        Me.colProductdesc1.Caption = "Product Description"
        Me.colProductdesc1.FieldName = "Productdesc"
        Me.colProductdesc1.Name = "colProductdesc1"
        Me.colProductdesc1.OptionsColumn.AllowEdit = False
        Me.colProductdesc1.Visible = True
        Me.colProductdesc1.VisibleIndex = 1
        Me.colProductdesc1.Width = 246
        '
        'colContainer1
        '
        Me.colContainer1.Caption = "Container"
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.OptionsColumn.AllowEdit = False
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 2
        Me.colContainer1.Width = 124
        '
        'grKeep
        '
        Me.grKeep.DataSource = Me.bsKeep
        Me.grKeep.Dock = System.Windows.Forms.DockStyle.Top
        Me.grKeep.Location = New System.Drawing.Point(0, 0)
        Me.grKeep.MainView = Me.GridView1
        Me.grKeep.Name = "grKeep"
        Me.grKeep.Size = New System.Drawing.Size(456, 220)
        Me.grKeep.TabIndex = 0
        Me.grKeep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colContainer})
        Me.GridView1.GridControl = Me.grKeep
        Me.GridView1.GroupPanelText = "This Product will REPLACE the one selected below"
        Me.GridView1.Name = "GridView1"
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.AllowEdit = False
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 70
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.OptionsColumn.AllowEdit = False
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 245
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.OptionsColumn.AllowEdit = False
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 2
        Me.colContainer.Width = 124
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.lblKeep)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.lblReplace)
        Me.PanelControl2.Controls.Add(Me.btnMerge)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 21)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(456, 64)
        Me.PanelControl2.TabIndex = 1
        '
        'lblKeep
        '
        Me.lblKeep.Location = New System.Drawing.Point(42, 44)
        Me.lblKeep.Name = "lblKeep"
        Me.lblKeep.Size = New System.Drawing.Size(6, 13)
        Me.lblKeep.TabIndex = 3
        Me.lblKeep.Text = "Y"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "with"
        '
        'lblReplace
        '
        Me.lblReplace.Location = New System.Drawing.Point(10, 8)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(50, 13)
        Me.lblReplace.TabIndex = 1
        Me.lblReplace.Text = "Replace X "
        '
        'btnMerge
        '
        Me.btnMerge.Location = New System.Drawing.Point(348, 20)
        Me.btnMerge.Name = "btnMerge"
        Me.btnMerge.Size = New System.Drawing.Size(102, 23)
        Me.btnMerge.TabIndex = 0
        Me.btnMerge.Text = "Merge Products"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnFinished)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 530)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(456, 34)
        Me.PanelControl1.TabIndex = 0
        '
        'btnFinished
        '
        Me.btnFinished.Location = New System.Drawing.Point(375, 6)
        Me.btnFinished.Name = "btnFinished"
        Me.btnFinished.Size = New System.Drawing.Size(75, 23)
        Me.btnFinished.TabIndex = 0
        Me.btnFinished.Text = "Finished"
        '
        'bsRemove
        '
        Me.bsRemove.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'frmMergeProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(464, 570)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMergeProducts"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMergeProducts"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKeep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grKeep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.bsRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grRemove As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsKeep As System.Windows.Forms.BindingSource
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents colProductid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grKeep As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsRemove As System.Windows.Forms.BindingSource
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnMerge As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFinished As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblKeep As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblReplace As DevExpress.XtraEditors.LabelControl
End Class
