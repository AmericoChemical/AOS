Imports AOS.BusinessObjects
Imports System.Text

Public Class frmAddEditComponents
    Inherits DevExpress.XtraEditors.XtraForm


    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)  
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Component"

    'here is where you dimension your object variables for the form
    Dim oComponent As New Component
    Dim oAltcomponent As Altcomponent

    Dim oComponentCollection As ViewAltComponentCollection
    Dim orgUnitCost As Decimal

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()
        getComponent()
    End Sub

    Private Sub loadLookupTables()
        Dim oVendor As New VendorCollection
        oVendor.LoadAll()
        Me.bsVendor.DataSource = oVendor
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub
    Private Sub addNewObject()
        oComponent.AddNew()
        oComponent.Unitcost = 0
        oComponent.Save()
        Me.bsComponent.DataSource = oComponent
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        If oComponent.LoadByPrimaryKey(vID) Then
            orgUnitCost = oComponent.Unitcost
        End If
        Me.bsComponent.DataSource = oComponent
    End Sub

    Private Function changesSaved() As Boolean
        bsComponent.EndEdit()
        oComponent.Vendorname = VendorItemLookUpEdit.Text
        oComponent.EndEdit()
        If orgUnitCost <> oComponent.Unitcost Then
            If MsgBox("Are you sure you want to UPDATE the Unit COSTS for this component? This will Update Product Costs to CALCULATED APIS COSTS?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                Return False
            End If

            If MsgBox("If you make this change, it cannot be undone. ARE YOU SURE YOU WANT TO CONTINUE?", MsgBoxStyle.YesNo, "CONFIRM REQUEST") = MsgBoxResult.No Then
                Return False
            End If
            oComponent.Save()

            ProcessComponentCostChanges(vID, "COMPONENT CHNG - COMP " & vID, "STD COST", vID, "COMP COST CHNG-" & vID)
        End If
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bsComponent.CancelEdit()
        Try
            If vEditType = "ADD" Then

                Dim oAltComponents As New AltcomponentCollection
                oAltComponents.Query.Where(oAltComponents.Query.Componentid.Equal(bsComponent.Current.componentID))
                oAltComponents.LoadAll()

                For Each oAltComponent As Altcomponent In oAltComponents
                    Dim oAlt As New Altcomponent
                    oAlt.LoadByPrimaryKey(oAltComponent.Recid)
                    oAlt.MarkAsDeleted()
                    oAlt.Save()
                Next

                oComponent.MarkAsDeleted()
                oComponent.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick
        If ValidateControls() Then
            If changesSaved() Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub getComponent()
        oComponentCollection = New ViewAltComponentCollection
        oComponentCollection.Query.Where(oComponentCollection.Query.Componentid.Equal(oComponent.Componentid))
        oComponentCollection.Query.Load()
        bsAltComponents.DataSource = oComponentCollection
    End Sub

    Private Function ValidateControls() As Boolean
        If String.IsNullOrEmpty(Me.AmericoDescTextEdit.Text) Then
            MsgBox("Americo Description is required. Please enter the description.", MsgBoxStyle.Critical, "Validate Component - Error")
            AmericoDescTextEdit.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.VendorItemLookUpEdit.Text) Then
            MsgBox("Vendor Name is required. Please select a vendor name.", MsgBoxStyle.Critical, "Validate Component - Error")
            VendorItemLookUpEdit.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnAlterAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterAdd.ItemClick
        bsComponent.EndEdit()
        Using frm As New frmAddEditAlternateComponents() With
            {
                .vID = bsComponent.Current.componentID,
                .vComponent = oComponent,
                .vEditType = "ADD"
            }
            frm.ShowDialog()
        End Using
        getComponent()
    End Sub

    Private Sub btnAlterEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterEdit.ItemClick
        bsComponent.EndEdit()
        If bsAltComponents.Count <= 0 Then
            Exit Sub
        End If

        Using frm As New frmAddEditAlternateComponents() With
            {
                .vID = bsAltComponents.Current.componentID,
                .vComponent = oComponent,
                .vRecID = bsAltComponents.Current.recID,
                .vEditType = "EDIT"
            }
            frm.ShowDialog()
        End Using
        getComponent()
    End Sub

    Private Sub btnAlterDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterDelete.ItemClick

        If bsAltComponents.Count <= 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete the selected component alternate item?", MsgBoxStyle.YesNo, "Delete Component Alternate - Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim oAltcomponent As New Altcomponent
            If oAltcomponent.LoadByPrimaryKey(bsAltComponents.Current.recID) Then
                oAltcomponent.MarkAsDeleted()
                oAltcomponent.Save()
                MsgBox("Component Alternate successfully deleted.", MsgBoxStyle.Information, "Delete Component Alternate - Success")
            Else
                MsgBox("Could not delete selected component alternate item.", MsgBoxStyle.Critical, "Delete Component Alternate - Error")
            End If

        Catch ex As Exception
            MsgBox("Error in deleting selected component alternate", MsgBoxStyle.Critical, "Delete Component Alternate - Error")
        End Try
        getComponent()
    End Sub

    Private Sub btnComponentCostRecords_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnComponentCostRecords.ItemClick
        Dim frm As New frmViewComponentCostRecords
        frm.vComponentID = oComponent.Componentid
        frm.ShowDialog()
        editObject(oComponent.Componentid)
    End Sub
End Class