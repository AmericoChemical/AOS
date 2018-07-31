Imports AOS.BusinessObjects
Imports System.Text

Public Class frmSelectAPIS
    Inherits DevExpress.XtraEditors.XtraForm

    Public vWID As Integer       'object primary key (passed in by calling form for edit mode)  
    Public vPID As Integer
    Public vSelectedAPISNumber As Integer

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
        getAPIS()
    End Sub

    Private Sub loadData()
        If vWID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        bsProduct.DataSource = getWorkOrderProductAPIS(vPID, vWID)
        If (Not IsNothing(bsProduct.DataSource)) Then
            Me.Text = String.Format("Select APIS for Work Order # {0}", bsProduct.Current.Workordernumber)
            WorkorderNoLabel.Text = bsProduct.Current.Workordernumber
            CustomerLabel.Text = String.Format("{0} - {1}", bsProduct.Current.CUSTID, bsProduct.Current.CUSTNAME)
            ProductDetLabel.Text = String.Format("{0} - {1} of {2} - {3} need to be put on a production order.", bsProduct.Current.QTY, bsProduct.Current.Container, bsProduct.Current.PRODUCTID, bsProduct.Current.PRODUCTDESC)
        End If
        bsProduct.EndEdit()
        bsProduct.ResetBindings(True)
    End Sub

    Private Sub getAPIS()
        bsAPISCollection.DataSource = getActiveAPIS(vPID)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelect.ItemClick
        bsAPISCollection.EndEdit()
        vSelectedAPISNumber = bsAPISCollection.Current.Apisnum
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class