<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditShippedItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditShippedItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Caption = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pProductItem = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.eBatch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.eStdWeight = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.eContainer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.eTotalWeight = New System.Windows.Forms.TextBox()
        Me.btnSelectProduct = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.eProductID = New System.Windows.Forms.TextBox()
        Me.eQtyContainers = New System.Windows.Forms.TextBox()
        Me.eProductDesc = New System.Windows.Forms.TextBox()
        Me.pBlankItem = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mTotalWeight = New System.Windows.Forms.TextBox()
        Me.mQtyContainers = New System.Windows.Forms.TextBox()
        Me.mProductDesc = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnCancelChanges = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbMisc = New System.Windows.Forms.RadioButton()
        Me.rbProduct = New System.Windows.Forms.RadioButton()
        Me.Header = New System.Windows.Forms.Panel()
        Me.pPictureHolder = New System.Windows.Forms.Panel()
        Me.pictOperation = New System.Windows.Forms.PictureBox()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pProductItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pBlankItem.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.pPictureHolder.SuspendLayout()
        CType(Me.pictOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label25.Location = New System.Drawing.Point(382, 0)
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
        Me.Caption.Size = New System.Drawing.Size(349, 24)
        Me.Caption.TabIndex = 0
        Me.Caption.Text = "Caption"
        Me.Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Add24.png")
        Me.ImageList1.Images.SetKeyName(1, "Edit24.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.AOS.My.MySettings.Default.ColorLight0
        Me.Panel1.Controls.Add(Me.pProductItem)
        Me.Panel1.Controls.Add(Me.pBlankItem)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 199)
        Me.Panel1.TabIndex = 1
        '
        'pProductItem
        '
        Me.pProductItem.Controls.Add(Me.GroupBox1)
        Me.pProductItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pProductItem.Location = New System.Drawing.Point(0, 30)
        Me.pProductItem.Name = "pProductItem"
        Me.pProductItem.Padding = New System.Windows.Forms.Padding(12)
        Me.pProductItem.Size = New System.Drawing.Size(472, 129)
        Me.pProductItem.TabIndex = 102
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.eBatch)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.eStdWeight)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.eContainer)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.eTotalWeight)
        Me.GroupBox1.Controls.Add(Me.btnSelectProduct)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.eProductID)
        Me.GroupBox1.Controls.Add(Me.eQtyContainers)
        Me.GroupBox1.Controls.Add(Me.eProductDesc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Standard Product Item"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(264, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "Batch Number"
        '
        'eBatch
        '
        Me.eBatch.Location = New System.Drawing.Point(267, 72)
        Me.eBatch.Name = "eBatch"
        Me.eBatch.Size = New System.Drawing.Size(169, 21)
        Me.eBatch.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(111, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Std Wgt"
        '
        'eStdWeight
        '
        Me.eStdWeight.Location = New System.Drawing.Point(114, 72)
        Me.eStdWeight.Name = "eStdWeight"
        Me.eStdWeight.ReadOnly = True
        Me.eStdWeight.Size = New System.Drawing.Size(60, 21)
        Me.eStdWeight.TabIndex = 132
        Me.eStdWeight.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(373, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "Container"
        '
        'eContainer
        '
        Me.eContainer.Location = New System.Drawing.Point(376, 33)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(60, 21)
        Me.eContainer.TabIndex = 130
        Me.eContainer.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Total Weight"
        '
        'eTotalWeight
        '
        Me.eTotalWeight.Location = New System.Drawing.Point(180, 72)
        Me.eTotalWeight.Name = "eTotalWeight"
        Me.eTotalWeight.Size = New System.Drawing.Size(81, 21)
        Me.eTotalWeight.TabIndex = 2
        '
        'btnSelectProduct
        '
        Me.btnSelectProduct.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectProduct.Image = Global.AOS.My.Resources.Resources.Search
        Me.btnSelectProduct.Location = New System.Drawing.Point(80, 33)
        Me.btnSelectProduct.Name = "btnSelectProduct"
        Me.btnSelectProduct.Size = New System.Drawing.Size(21, 21)
        Me.btnSelectProduct.TabIndex = 127
        Me.btnSelectProduct.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Product ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Qty Containers"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Product Description"
        '
        'eProductID
        '
        Me.eProductID.Location = New System.Drawing.Point(11, 33)
        Me.eProductID.Name = "eProductID"
        Me.eProductID.ReadOnly = True
        Me.eProductID.Size = New System.Drawing.Size(74, 21)
        Me.eProductID.TabIndex = 123
        Me.eProductID.TabStop = False
        '
        'eQtyContainers
        '
        Me.eQtyContainers.Location = New System.Drawing.Point(11, 72)
        Me.eQtyContainers.Name = "eQtyContainers"
        Me.eQtyContainers.Size = New System.Drawing.Size(90, 21)
        Me.eQtyContainers.TabIndex = 1
        '
        'eProductDesc
        '
        Me.eProductDesc.Location = New System.Drawing.Point(114, 33)
        Me.eProductDesc.Name = "eProductDesc"
        Me.eProductDesc.Size = New System.Drawing.Size(256, 21)
        Me.eProductDesc.TabIndex = 0
        '
        'pBlankItem
        '
        Me.pBlankItem.Controls.Add(Me.GroupBox2)
        Me.pBlankItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBlankItem.Location = New System.Drawing.Point(0, 30)
        Me.pBlankItem.Name = "pBlankItem"
        Me.pBlankItem.Padding = New System.Windows.Forms.Padding(12)
        Me.pBlankItem.Size = New System.Drawing.Size(472, 129)
        Me.pBlankItem.TabIndex = 103
        Me.pBlankItem.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.mTotalWeight)
        Me.GroupBox2.Controls.Add(Me.mQtyContainers)
        Me.GroupBox2.Controls.Add(Me.mProductDesc)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 105)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Miscellaneous Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Total Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Qty Containers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Item Description"
        '
        'mTotalWeight
        '
        Me.mTotalWeight.Location = New System.Drawing.Point(107, 72)
        Me.mTotalWeight.Name = "mTotalWeight"
        Me.mTotalWeight.Size = New System.Drawing.Size(81, 21)
        Me.mTotalWeight.TabIndex = 3
        '
        'mQtyContainers
        '
        Me.mQtyContainers.Location = New System.Drawing.Point(11, 72)
        Me.mQtyContainers.Name = "mQtyContainers"
        Me.mQtyContainers.Size = New System.Drawing.Size(90, 21)
        Me.mQtyContainers.TabIndex = 1
        '
        'mProductDesc
        '
        Me.mProductDesc.Location = New System.Drawing.Point(11, 33)
        Me.mProductDesc.Name = "mProductDesc"
        Me.mProductDesc.Size = New System.Drawing.Size(327, 21)
        Me.mProductDesc.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnSaveChanges)
        Me.Panel2.Controls.Add(Me.btnCancelChanges)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 159)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 40)
        Me.Panel2.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 2)
        Me.Label1.TabIndex = 89
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveChanges.Location = New System.Drawing.Point(332, 8)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(128, 23)
        Me.btnSaveChanges.TabIndex = 0
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnCancelChanges
        '
        Me.btnCancelChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelChanges.Location = New System.Drawing.Point(198, 8)
        Me.btnCancelChanges.Name = "btnCancelChanges"
        Me.btnCancelChanges.Size = New System.Drawing.Size(128, 23)
        Me.btnCancelChanges.TabIndex = 1
        Me.btnCancelChanges.Text = "Cancel Changes"
        Me.btnCancelChanges.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = Global.AOS.My.MySettings.Default.ColorLight2
        Me.Panel3.Controls.Add(Me.rbMisc)
        Me.Panel3.Controls.Add(Me.rbProduct)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(472, 30)
        Me.Panel3.TabIndex = 118
        '
        'rbMisc
        '
        Me.rbMisc.AutoSize = True
        Me.rbMisc.Location = New System.Drawing.Point(94, 6)
        Me.rbMisc.Name = "rbMisc"
        Me.rbMisc.Size = New System.Drawing.Size(103, 17)
        Me.rbMisc.TabIndex = 1
        Me.rbMisc.Text = "Miscellaneous"
        Me.rbMisc.UseVisualStyleBackColor = True
        '
        'rbProduct
        '
        Me.rbProduct.AutoSize = True
        Me.rbProduct.Checked = True
        Me.rbProduct.Location = New System.Drawing.Point(12, 6)
        Me.rbProduct.Name = "rbProduct"
        Me.rbProduct.Size = New System.Drawing.Size(68, 17)
        Me.rbProduct.TabIndex = 0
        Me.rbProduct.TabStop = True
        Me.rbProduct.Text = "Product"
        Me.rbProduct.UseVisualStyleBackColor = True
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
        Me.Header.Size = New System.Drawing.Size(472, 24)
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
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Shipmentdetail)
        '
        'frmAddEditShippedItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.AOS.My.MySettings.Default.ColorDark0
        Me.ClientSize = New System.Drawing.Size(476, 227)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Header)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddEditShippedItem"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.Panel1.ResumeLayout(False)
        Me.pProductItem.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pBlankItem.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Header.ResumeLayout(False)
        Me.pPictureHolder.ResumeLayout(False)
        CType(Me.pictOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents pBlankItem As System.Windows.Forms.Panel
    Friend WithEvents pProductItem As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mProductDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents mQtyContainers As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectProduct As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents eProductID As System.Windows.Forms.TextBox
    Friend WithEvents eQtyContainers As System.Windows.Forms.TextBox
    Friend WithEvents eProductDesc As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents eTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents eContainer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents eStdWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents eBatch As System.Windows.Forms.TextBox
    Friend WithEvents rbMisc As System.Windows.Forms.RadioButton
    Friend WithEvents rbProduct As System.Windows.Forms.RadioButton
End Class
