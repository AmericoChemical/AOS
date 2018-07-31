Imports AOS.BusinessObjects

Public Class frmAddEditShippedItem

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)

    Public vShipmentNumber As Integer
    Public vShippedItemID As Integer
    Public vCustomerPO As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Shipped Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Shipmentdetail
    Dim oProduct As Product

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            pictOperation.Image = Me.ImageList1.Images(0)
            Caption.Text = "Adding New " & vObjectName
        Else
            pictOperation.Image = Me.ImageList1.Images(1)
            Caption.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadProduct(ByVal vProdID As Integer)
        If vProdID = 0 Then
            Exit Sub
        End If

        oProduct = New Product
        oProduct.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProduct.LoadByPrimaryKey(vProdID)

    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vShippedItemID)
        End If
    End Sub

    Private Sub addNewObject()
        oItem = New Shipmentdetail
        oItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oItem.AddNew()
        oItem.Shipmentnumber = vShipmentNumber
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Me.Close()
            Exit Sub
        End If
        oItem = New Shipmentdetail
        oItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem

        If bsItem.Current.ProductID <> 0 Then
            rbProduct.Checked = True
            'look up product information
            loadProduct(bsItem.Current.ProductID)

            'fill Product boxes
            eProductID.Text = bsItem.Current.ProductID
            eProductDesc.Text = bsItem.Current.productdesc
            eQtyContainers.Text = bsItem.Current.QtyContainers
            eTotalWeight.Text = bsItem.Current.TotalWeight
            eBatch.Text = bsItem.Current.batchnumber
            eStdWeight.Text = oProduct.Stdweight
            eContainer.Text = oProduct.Container

        Else
            'fill Miscellaneous Boxes
            rbMisc.Checked = True
            mProductDesc.Text = bsItem.Current.ProductDesc
            mQtyContainers.Text = bsItem.Current.qtycontainers
            mTotalWeight.Text = bsItem.Current.totalweight
        End If

    End Sub

    Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click
        calcdata()
        updateItem()
        bsItem.EndEdit()
        oItem.EndEdit()
        oItem.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelChanges.Click
        oItem.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbProduct_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbProduct.CheckedChanged
        If rbProduct.Checked Then
            Me.pProductItem.Visible = True
            Me.pBlankItem.Visible = False
        Else
            Me.pProductItem.Visible = False
            Me.pBlankItem.Visible = True
        End If
    End Sub

    Private Sub updateItem()
        'reload bsitem with reconfigured data

        Dim vStr As String

        If rbProduct.Checked Then
            'Product item
            bsItem.Current.ProductID = eProductID.Text
            bsItem.Current.ProductDesc = eProductDesc.Text
            bsItem.Current.QtyContainers = eQtyContainers.Text
            bsItem.Current.TotalWeight = eTotalWeight.Text
            bsItem.Current.ClassRate = oProduct.Classrate
            bsItem.Current.BatchNumber = eBatch.Text
            bsItem.Current.DOTDesc = oProduct.Dotdesc
            bsItem.Current.HazmatDesc = oProduct.Hazmatdesc
            bsItem.Current.StdWeight = oProduct.Stdweight
            bsItem.Current.StdGallons = oProduct.Stdgallons
            bsItem.Current.UNLine = oProduct.Unline
            bsItem.Current.LD1 = oProduct.Dotdesc & " " & oProduct.Hazmatdesc
            bsItem.Current.LD2 = oProduct.Unline
            vStr = oProduct.Container & "/" & oProduct.Stdweight.ToString & " LB. " & Trim(eProductDesc.Text) & " - " & oProduct.Stdgallons.ToString & " gal."
            If vCustomerPO <> "" Then
                vStr = vStr & "(PO# " & vCustomerPO & ")"
            End If
            bsItem.Current.LD3 = vStr

        Else
            'Miscellaneous item
            bsItem.Current.ProductID = 0
            bsItem.Current.ProductDesc = mProductDesc.Text
            bsItem.Current.QtyContainers = mQtyContainers.Text
            bsItem.Current.TotalWeight = mTotalWeight.Text
            bsItem.Current.ClassRate = ""
            bsItem.Current.BatchNumber = ""
            bsItem.Current.DOTDesc = ""
            bsItem.Current.HazmatDesc = ""
            bsItem.Current.StdWeight = 0
            bsItem.Current.StdGallons = 0
            bsItem.Current.UNLine = ""
            bsItem.Current.LD1 = ""
            bsItem.Current.LD2 = ""
            bsItem.Current.LD3 = Trim(mProductDesc.Text)
        End If

    End Sub

    Private Sub btnSelectProduct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelectProduct.Click

        Dim vID As Integer          'Product ID

        Dim frm As New frmSelectProduct
        frm.vID = 0
        frm.ShowDialog()

        vID = frm.vID
        
        If vID = 0 Then
            Exit Sub
        End If

        loadProduct(vID)

        'fill Product boxes
        eProductID.Text = vID
        eProductDesc.Text = oProduct.Productdesc
        eStdWeight.Text = oProduct.Stdweight
        eContainer.Text = oProduct.Container

        eQtyContainers.Focus()

    End Sub
    Private Sub calcdata()

        Dim vContainers As Integer = 0
        Dim vStdWeight As Integer = 0
        Dim vTotalWeight As Integer = 0
        Dim vTareWeight As Integer = 0
        Dim oContainer As New Container
        Dim vContainer As String = ""

        vContainer = eContainer.Text
        Try
            If oContainer.LoadByPrimaryKey(vContainer) Then
                If oContainer.TareWeight <= 0 Then
                    MsgBox("Tare weight for this container is not correct. Please see you data adminstrator", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                vTareWeight = oContainer.TareWeight
            Else
                vTareWeight = 0
            End If
        Catch ex As Exception
            MsgBox("Error in getting retrieving container tare weight. See your data administrator", MsgBoxStyle.Critical, "Gross Weight Error")
            Exit Sub
        End Try

        Try
            If eQtyContainers.Text = "" Then
                vContainers = 0
            Else
                vContainers = CInt(eQtyContainers.Text)
            End If
            If eStdWeight.Text = "" Then
                vStdWeight = 0
            Else
                vStdWeight = CInt(eStdWeight.Text)
            End If
        Catch ex As Exception
            Exit Sub
        End Try

        'do calculations
        vTotalWeight = vContainers * (vStdWeight + vTareWeight)
        eTotalWeight.Text = vTotalWeight

    End Sub

    Private Sub eQtyContainers_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eQtyContainers.TextChanged
        calcdata()
    End Sub
End Class