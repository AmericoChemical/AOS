Imports System.Drawing.Printing
Imports AOS.BusinessObjects

Public Class rptPOList3

    Public Sub New(vPONum As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fillDataSet(vPONum)
    End Sub

    Private Sub fillDataSet(vPONum As Integer)

        Dim oPO As New Purchase
        If oPO.LoadByPrimaryKey(vPONum) Then
            Select Case oPO.Purchasetype
                Case "DIRECT"
                    Dim oRpt As New ViewRptDirectPurchaseOrders2Collection
                    oRpt.Query.Where(oRpt.Query.Ponumber.Equal(vPONum))
                    If oRpt.Query.Load Then
                        bsPurchaseOrders.DataSource = oRpt
                    Else
                        MsgBox("Error in loading data for PO#" + vPONum.ToString, MsgBoxStyle.Critical, "Error - Missing Data")
                        Me.ClosePreview
                    End If

                Case Else
                    Dim oRpt2 As New ViewPurchaseOrderProductListCollection
                    oRpt2.Query.Where(oRpt2.Query.Ponumber.Equal(vPONum))
                    If oRpt2.Query.Load Then
                        bsPurchaseOrders.DataSource = oRpt2
                    Else
                        MsgBox("Error in loading data for PO#" + vPONum.ToString, MsgBoxStyle.Critical, "Error - Missing Data")
                        Me.ClosePreview
                    End If

            End Select
        End If

    End Sub

    Private Sub lblPOType_BeforePrint(sender As Object, e As PrintEventArgs) Handles lblPOType.BeforePrint
        If lblPOType.Text = "DIRECT" Then
            lblCustomerPONumber.Visible = True
            hdrCustomerPO.Visible = True
        Else
            lblCustomerPONumber.Visible = False
            hdrCustomerPO.Visible = False
        End If
    End Sub
End Class