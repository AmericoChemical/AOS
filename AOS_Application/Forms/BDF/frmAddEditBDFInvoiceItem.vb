Imports AOS.BusinessObjects

Public Class frmAddEditBDFInvoiceItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (InvoiceItemNumber) (passed in by calling form for edit mode)
    Public vFKID As Integer     'foreign key values (InvoiceNumber) (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vCustID As Integer   'Customer ID from Invoice to which you are adding/editing item
    Public vTaxExempt As Boolean  'Customer may be marked in database as tax exempt, if so, Taxable control should be invisible

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "BDF Invoice Item"

    'here is where you dimension your object variables for the form
    Dim oItem As BDFInvoiceItem
    Dim oProduct As Product = Nothing
    Dim oContainer As Container = Nothing


    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

  

    Private Sub addNewObject()
        oItem = New BDFInvoiceItem
        oItem.AddNew()
        'assign foreign key values here
        oItem.BDFInvoiceNumber = vFKID
        Me.bsBDFItem.DataSource = oItem

        eQuantityTextEdit.Enabled = True

        eQuantityTextEdit.Properties.ReadOnly = False
        eExtPriceTextEdit.Properties.ReadOnly = False
        eRateTextEdit.Properties.ReadOnly = False


    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New BDFInvoiceItem
        oItem.LoadByPrimaryKey(vID)
        Me.bsBDFItem.DataSource = oItem
    End Sub

    

    Private Function changesCancelled() As Boolean
        Try
            bsBDFItem.CancelEdit()
            oItem.CancelEdit()
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function




    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Function changesSaved() As Boolean
        Try
            ' oItemList.Productdesc = eProduct.Text
            bsBDFItem.EndEdit()
            setItemTotals()
            bsBDFItem.EndEdit()

            oItem.EndEdit()
            oItem.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub setItemTotals()
        oItem.EndEdit()     'save user's last edits
        oItem.BeginEdit()
        If oItem.Quantity Is Nothing Then
            oItem.Quantity = 0
        End If

        ''if the product in the pricelist if priced by container, then you 
        ''have to adjust the "itemprice" to reflect the unit price * units in container
        'If eUC.EditValue = "C" Then
        '    oItemList.Itemprice = oItemList.Itemprice * oItemList.Units
        '    oItemList.Unitcost = oItemList.Unitcost * oItemList.Units
        'End If
        'bsItem.EndEdit()

        'oItemList.EndEdit()
        'oItemList.Extcost = CDbl(oItemList.Quantity) * CDbl(oItemList.Unitcost)
        'oItemList.Extprice = CDbl(oItemList.Quantity) * CDbl(oItemList.Itemprice)
        'oItemList.Grossprofit = CDbl(oItemList.ExtPrice) - CDbl(oItemList.Extcost)



        oItem.EndEdit()
        oItem.Save()
    End Sub



End Class