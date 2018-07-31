<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectProduct
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectProduct))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.Label25 = New System.Windows.Forms.Label
        Me.Caption = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dg = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSaveChanges = New System.Windows.Forms.Button
        Me.btnCancelChanges = New System.Windows.Forms.Button
        Me.Header = New System.Windows.Forms.Panel
        Me.pPictureHolder = New System.Windows.Forms.Panel
        Me.pictOperation = New System.Windows.Forms.PictureBox
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductdescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContainerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StdgallonsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Stdweight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.pPictureHolder.SuspendLayout()
        CType(Me.pictOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha4.Parent = Nothing
        '
        'Label25
        '
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label25.Location = New System.Drawing.Point(465, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 24)
        Me.Label25.TabIndex = 1
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Caption
        '
        Me.Caption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Caption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caption.ForeColor = System.Drawing.Color.White
        Me.Caption.Location = New System.Drawing.Point(33, 0)
        Me.Caption.Name = "Caption"
        Me.Caption.Size = New System.Drawing.Size(432, 24)
        Me.Caption.TabIndex = 0
        Me.Caption.Text = "Caption"
        Me.Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Search.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.AOS.My.MySettings.Default.ColorLight0
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 315)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dg)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel3.Size = New System.Drawing.Size(555, 275)
        Me.Panel3.TabIndex = 102
        '
        'dg
        '
        Me.dg.AutoGenerateColumns = False
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductidDataGridViewTextBoxColumn, Me.ProductdescDataGridViewTextBoxColumn, Me.ContainerDataGridViewTextBoxColumn, Me.StdgallonsDataGridViewTextBoxColumn, Me.Stdweight})
        Me.dg.DataSource = Me.bsProducts
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Location = New System.Drawing.Point(6, 6)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersVisible = False
        Me.dg.Size = New System.Drawing.Size(543, 263)
        Me.dg.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnSaveChanges)
        Me.Panel2.Controls.Add(Me.btnCancelChanges)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 275)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(555, 40)
        Me.Panel2.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(555, 2)
        Me.Label1.TabIndex = 89
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveChanges.Location = New System.Drawing.Point(415, 8)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(128, 23)
        Me.btnSaveChanges.TabIndex = 9
        Me.btnSaveChanges.Text = "Select"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnCancelChanges
        '
        Me.btnCancelChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelChanges.Location = New System.Drawing.Point(281, 8)
        Me.btnCancelChanges.Name = "btnCancelChanges"
        Me.btnCancelChanges.Size = New System.Drawing.Size(128, 23)
        Me.btnCancelChanges.TabIndex = 10
        Me.btnCancelChanges.Text = "Cancel"
        Me.btnCancelChanges.UseVisualStyleBackColor = True
        '
        'Header
        '
        Me.Header.BackColor = Global.AOS.My.MySettings.Default.ColorDark0
        Me.Header.Controls.Add(Me.Caption)
        Me.Header.Controls.Add(Me.pPictureHolder)
        Me.Header.Controls.Add(Me.Label25)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(2, 2)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(555, 24)
        Me.Header.TabIndex = 2
        '
        'pPictureHolder
        '
        Me.pPictureHolder.Controls.Add(Me.pictOperation)
        Me.pPictureHolder.Dock = System.Windows.Forms.DockStyle.Left
        Me.pPictureHolder.Location = New System.Drawing.Point(0, 0)
        Me.pPictureHolder.Name = "pPictureHolder"
        Me.pPictureHolder.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pPictureHolder.Size = New System.Drawing.Size(33, 24)
        Me.pPictureHolder.TabIndex = 2
        '
        'pictOperation
        '
        Me.pictOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictOperation.Location = New System.Drawing.Point(2, 0)
        Me.pictOperation.Name = "pictOperation"
        Me.pictOperation.Size = New System.Drawing.Size(29, 24)
        Me.pictOperation.TabIndex = 0
        Me.pictOperation.TabStop = False
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        Me.bsProducts.Sort = ""
        '
        'ProductidDataGridViewTextBoxColumn
        '
        Me.ProductidDataGridViewTextBoxColumn.DataPropertyName = "Productid"
        Me.ProductidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.ProductidDataGridViewTextBoxColumn.Name = "ProductidDataGridViewTextBoxColumn"
        Me.ProductidDataGridViewTextBoxColumn.Width = 50
        '
        'ProductdescDataGridViewTextBoxColumn
        '
        Me.ProductdescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductdescDataGridViewTextBoxColumn.DataPropertyName = "Productdesc"
        Me.ProductdescDataGridViewTextBoxColumn.HeaderText = "Product Description"
        Me.ProductdescDataGridViewTextBoxColumn.Name = "ProductdescDataGridViewTextBoxColumn"
        '
        'ContainerDataGridViewTextBoxColumn
        '
        Me.ContainerDataGridViewTextBoxColumn.DataPropertyName = "Container"
        Me.ContainerDataGridViewTextBoxColumn.HeaderText = "Container"
        Me.ContainerDataGridViewTextBoxColumn.Name = "ContainerDataGridViewTextBoxColumn"
        Me.ContainerDataGridViewTextBoxColumn.Width = 80
        '
        'StdgallonsDataGridViewTextBoxColumn
        '
        Me.StdgallonsDataGridViewTextBoxColumn.DataPropertyName = "Stdgallons"
        Me.StdgallonsDataGridViewTextBoxColumn.HeaderText = "Gallons"
        Me.StdgallonsDataGridViewTextBoxColumn.Name = "StdgallonsDataGridViewTextBoxColumn"
        Me.StdgallonsDataGridViewTextBoxColumn.Width = 80
        '
        'Stdweight
        '
        Me.Stdweight.DataPropertyName = "Stdweight"
        Me.Stdweight.HeaderText = "Weight"
        Me.Stdweight.Name = "Stdweight"
        Me.Stdweight.Width = 80
        '
        'frmSelectProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.AOS.My.MySettings.Default.ColorDark0
        Me.ClientSize = New System.Drawing.Size(559, 343)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Header)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSelectProduct"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        Me.pPictureHolder.ResumeLayout(False)
        CType(Me.pictOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents Caption As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents pPictureHolder As System.Windows.Forms.Panel
    Friend WithEvents pictOperation As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnCancelChanges As System.Windows.Forms.Button
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents ProductidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductdescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContainerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StdgallonsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stdweight As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
