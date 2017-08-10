
Imports AOS.BusinessObjects

Public Class frmManageContainers
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oContainers As New ContainerCollection


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getContainers()
    End Sub

    Private Sub getContainers()
        oContainers = New ContainerCollection
        If Not oContainers.LoadAll Then
            MsgBox("Error in retrieving Container records from database", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End If
        Try
            bsContainers.DataSource = oContainers
            grItems.DataSource = bsContainers
            grItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNewContainer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewContainer.ItemClick
        addNewContainer()
    End Sub

    Private Sub btnEditContainer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditContainer.ItemClick
        editContainer()
    End Sub

    Private Sub btnDeleteContainer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteContainer.ItemClick
        deleteContainer()
    End Sub

    Private Sub addNewContainer()
        Dim frm As New frmAddEditContainer
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getContainers()
    End Sub

    Private Sub editContainer()
        Dim frm As New frmAddEditContainer
        frm.vEditType = "EDIT"
        frm.vContainer = bsContainers.Current.Container
        frm.ShowDialog()
        getContainers()
    End Sub

    Private Sub deleteContainer()

        If bsContainers.Current.Container Is Nothing Then
            MsgBox("You must select a container record", MsgBoxStyle.Critical, "Error - No record selected")
            Exit Sub
        End If

        Dim oProducts As New ProductCollection
        oProducts.Query.Where(oProducts.Query.Container.Equal(bsContainers.Current.Container))
        If oProducts.Query.Load Then
            MsgBox(oProducts.Count.ToString & " products use the selected container type. You cannot delete this container record", MsgBoxStyle.Critical, "Error - Container in Use")
            Exit Sub
        End If

        ' at this point we have a container that has not been used in any current products
        Dim oContainer As New Container
        If oContainer.LoadByPrimaryKey(bsContainers.Current.Container) Then
            oContainer.MarkAsDeleted()
            oContainer.Save()
        End If

        getContainers()

    End Sub

End Class