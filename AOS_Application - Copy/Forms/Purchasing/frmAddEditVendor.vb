Imports AOS.BusinessObjects

Public Class frmAddEditVendor

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vFKID As Integer     'foreign key values (passed in by calling form for add mode)
    Public vFKID2 As Integer    'foreign key values (passed in by calling form for add mode)
    Public vFKID3 As Integer    'foreign key values (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Vendor"

    'here is where you dimension your object variables for the form
    Dim oItem As New Vendor
    Dim oStatusOptions As New ListStatusoptionsCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadStatusOptions()
        loadData()
    End Sub

    Private Sub loadStatusOptions()
        Dim oStatusoptions As New ListStatusoptionsCollection
        oStatusoptions.LoadAll()
        bsStatusOptions.DataSource = oStatusoptions
    End Sub

    Private Sub updateTimeLabels()
        If IsDBNull(oItem.Createdby) Or oItem.Createdby = Nothing Then
            lblCreated.Text = ""
        Else
            lblCreated.Text = "Created on " & IIf(IsDBNull(oItem.Createdtime), "", FormatDateTime(oItem.Createdtime, DateFormat.GeneralDate)) & IIf(IsDBNull(oItem.Createdby), "", " by " & oItem.Createdby)
        End If
        If IsDBNull(oItem.Modifyby) Or oItem.Modifyby = Nothing Then
            lblModified.Text = ""
        Else
            lblModified.Text = "Last Modified on " & IIf(IsDBNull(oItem.Modifytime), "", FormatDateTime(oItem.Modifytime, DateFormat.GeneralDate)) & IIf(IsDBNull(oItem.Modifyby), "", " by " & oItem.Modifyby)
        End If
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
        loadVendorsTestingMatrix()
    End Sub
    Private Sub addNewObject()
        oItem.AddNew()
        oItem.Createdby = vCurrentUserLogin
        oItem.Createdtime = Now
        oItem.Modifyby = vCurrentUserLogin
        oItem.Modifytime = Now

        oItem.Save()
        vID = oItem.Vendorid
        Me.bs.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("Please select a record to edit", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem.LoadByPrimaryKey(vID)
        Me.bs.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean
        bs.EndEdit()
        oItem.EndEdit()
        oItem.Modifyby = vCurrentUserLogin
        oItem.Modifytime = Now
        oItem.Save()
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bs.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub rbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub rbtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
    Private Sub loadVendorsTestingMatrix()
        Dim oVendorTestingMatrixList As ViewVendorTestingMatrixCollection = getVendorTestingMatrixList(bs.Current.Vendorid)
        bsVendorTestingMatrix.DataSource = oVendorTestingMatrixList
        Me.grVendorTestingMatrix.DataSource = bsVendorTestingMatrix
        If oVendorTestingMatrixList.Count <= 0 Then
            EditVendTestingMatrix.Enabled = False
            DeleteVendTestingMatrix.Enabled = False
        Else
            EditVendTestingMatrix.Enabled = True
            DeleteVendTestingMatrix.Enabled = True
        End If
    End Sub

    Private Sub editVendorTestingMatrix()
        If bsVendorTestingMatrix.Count <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditVendorTestingMatrix
        frm.vVendorID = Me.bs.Current.Vendorid
        frm.vVendorName = Me.bs.Current.Vendorname
        frm.vVendorTestingMatrixID = Me.bsVendorTestingMatrix.Current.VENDORTESTINGMATRIXID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadVendorsTestingMatrix()
    End Sub
    Private Sub addVendorTestingMatrix()
        Dim frm As New frmAddEditVendorTestingMatrix
        frm.vEditType = "ADD"
        frm.vVendorID = Me.bs.Current.Vendorid
        frm.vVendorName = Me.bs.Current.Vendorname
        frm.ShowDialog()
        loadVendorsTestingMatrix()
    End Sub
    Private Sub AddVendTestingMatrix_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddVendTestingMatrix.ItemClick
        addVendorTestingMatrix()
    End Sub

    Private Sub EditVendTestingMatrix_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditVendTestingMatrix.ItemClick
        editVendorTestingMatrix()
    End Sub
    Private Sub deleteVendorTestingMatrix()
        Dim oVendorTestingMatrix As New Vendortestingmatrix
        oVendorTestingMatrix.LoadByPrimaryKey(bsVendorTestingMatrix.Current.VENDORTESTINGMATRIXID)
        oVendorTestingMatrix.MarkAsDeleted()
        oVendorTestingMatrix.Save()

        loadVendorsTestingMatrix()
    End Sub


    Private Sub DeleteVendTestingMatrix_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteVendTestingMatrix.ItemClick
        If bsVendorTestingMatrix.Count = 0 Then
            Exit Sub
        End If
        Dim str As String
        str = "Are you sure you want to delete this Vendor Testing Matrix?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        deleteVendorTestingMatrix()
    End Sub
End Class