Imports AOS.BusinessObjects

Public Class frmMergeLoads
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub

    Private Function mergeLoads() As Boolean

        'Validate the entered shipment numbers
        Try
            If IsDBNull(eShipment1.EditValue) Or eShipment1.EditValue <= 0 Then
                MsgBox("You must enter a valid value for Shipment #1", MsgBoxStyle.Critical, "Error - Invalid Shipment Number")
                Return False
            End If
            If IsDBNull(eShipment2.EditValue) Or eShipment2.EditValue <= 0 Then
                MsgBox("You must enter a valid value for Shipment #2", MsgBoxStyle.Critical, "Error - Invalid Shipment Number")
                Return False
            End If
            If eShipment2.EditValue = eShipment1.EditValue Then
                MsgBox("You must enter two different values for Shipment Numbers", MsgBoxStyle.Critical, "Error - Invalid Shipment Numbers")
                Return False
            End If
        Catch ex As Exception
            MsgBox("There was an error is processing the entered Shipment Numbers", MsgBoxStyle.Critical, "Error - Invalid Shipment Numbers")
            Return False
        End Try

        'retrieve the system parameter for Freeze Protection
        Dim oParm As New Sysparameters
        oParm.LoadByPrimaryKey(1)

        'retrieve the two shipment records and related item records
        Dim oShip1 As New Shipment
        Dim oShip2 As New Shipment
        Dim oItems1 As New ShipmentdetailCollection
        Dim oItems2 As New ShipmentdetailCollection

        Try
            If Not oShip1.LoadByPrimaryKey(eShipment1.EditValue) Then
                MsgBox("Shipment #1 could not be retrieved from the database. Merge failed.", MsgBoxStyle.Critical, "Error - Merge failed")
                Return False
            End If
            If Not oShip2.LoadByPrimaryKey(eShipment2.EditValue) Then
                MsgBox("Shipment #2 could not be retrieved from the database. Merge failed.", MsgBoxStyle.Critical, "Error - Merge failed")
                Return False
            End If
            If oShip1.Custid <> oShip2.Custid Then
                If MsgBox("You have selected two shipments for different customers. Are you sure you want to continue?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
                    Return False
                End If
            End If
            oItems1.Query.Where(oItems1.Query.Shipmentnumber.Equal(oShip1.Shipmentnumber))
            oItems2.Query.Where(oItems2.Query.Shipmentnumber.Equal(oShip2.Shipmentnumber))
            If Not oItems1.Query.Load Then
                MsgBox("Shipment #1 items could not be retrieved from the database. Merge failed.", MsgBoxStyle.Critical, "Error - Merge failed")
                Return False
            End If
            If Not oItems2.Query.Load Then
                MsgBox("Shipment #2 items could not be retrieved from the database. Merge failed.", MsgBoxStyle.Critical, "Error - Merge failed")
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error in retrieving Shipment data from the database.", MsgBoxStyle.Critical, "Error - Data Retrieval Failed")
            Return False
        End Try


        'set Freeze Protect Warning value for new merged shipment
        Dim vFreezeProtect As Boolean = False
        Select Case oShip1.Keepfromfreezing
            Case False
                If oShip2.Keepfromfreezing = False Then
                    vFreezeProtect = False
                Else
                    vFreezeProtect = oParm.FreezeWarning
                End If
            Case True
                If oShip2.Keepfromfreezing = True Then
                    vFreezeProtect = True
                Else
                    vFreezeProtect = oParm.FreezeWarning
                End If
        End Select


        'create a new shipment record using data from Shipment 1
        Dim oShipNew As New Shipment

        Try
            oShipNew.Keepfromfreezing = vFreezeProtect
            oShipNew.Shipmentdate = oShip1.Shipmentdate
            oShipNew.Workordernumber = oShip1.Workordernumber
            oShipNew.Custid = oShip1.Custid
            oShipNew.Customername = oShip1.Customername
            oShipNew.Shipfromid = oShip1.Shipfromid
            oShipNew.Shipfromname = oShip1.Shipfromname
            oShipNew.Shipfromaddress1 = oShip1.Shipfromaddress1
            oShipNew.Shipfromaddress2 = oShip1.Shipfromaddress2
            oShipNew.Shipfromcity = oShip1.Shipfromcity
            oShipNew.Shipfromstateprov = oShip1.Shipfromstateprov
            oShipNew.Shipfrompostalcode = oShip1.Shipfrompostalcode
            oShipNew.Shipfromcountry = oShip1.Shipfromcountry
            oShipNew.Shipfromphone = oShip1.Shipfromphone
            oShipNew.Shipfromfax = oShip1.Shipfromfax
            oShipNew.Shipfromcontact = oShip1.Shipfromcontact
            oShipNew.Shiptoid = oShip1.Shiptoid
            oShipNew.Shiptoname = oShip1.Shiptoname
            oShipNew.Shiptoaddress1 = oShip1.Shiptoaddress1
            oShipNew.Shiptoaddress2 = oShip1.Shiptoaddress2
            oShipNew.Shiptocity = oShip1.Shiptocity
            oShipNew.Shiptostateprov = oShip1.Shiptostateprov
            oShipNew.Shiptopostalcode = oShip1.Shiptopostalcode
            oShipNew.Shiptocountry = oShip1.Shiptocountry
            oShipNew.Shiptocontact = oShip1.Shiptocontact
            oShipNew.Shiptophone = oShip1.Shiptophone
            oShipNew.Carrierid = oShip1.Carrierid
            oShipNew.Freightcarrier = oShip1.Freightcarrier
            oShipNew.Fob = oShip1.Fob
            oShipNew.Customerpo = oShip1.Customerpo
            oShipNew.Placardsrequired = oShip1.Placardsrequired
            oShipNew.Placardssupplied = oShip1.Placardssupplied
            oShipNew.Shipmentstatus = oShip1.Shipmentstatus
            oShipNew.Logisticsid = oShip1.Logisticsid
            oShipNew.Comments = oShip1.Comments
            oShipNew.Createdby = vCurrentUserLogin
            oShipNew.Createdtime = Now
            oShipNew.Modifyby = vCurrentUserLogin
            oShipNew.Modifytime = Now
            oShipNew.Save()
        Catch ex As Exception
            MsgBox("Error creating new shipment record", MsgBoxStyle.Critical, "Error - New Shipment Record failed")
            Return False
        End Try

        'add detail records from both shipment 1 and shipment 2

        Try
            For Each oItem As Shipmentdetail In oItems1
                Dim oRec As New Shipmentdetail
                oRec.Shipmentnumber = oShipNew.Shipmentnumber
                oRec.Productid = oItem.Productid
                oRec.Productdesc = oItem.Productdesc
                oRec.Qtycontainers = oItem.Qtycontainers
                oRec.Totalweight = oItem.Totalweight
                oRec.Batchnumber = oItem.Batchnumber
                oRec.Stdweight = oItem.Stdweight
                oRec.Stdgallons = oItem.Stdgallons
                oRec.Container = oItem.Container
                oRec.Dotdesc = oItem.Dotdesc
                oRec.Hazmatdesc = oItem.Hazmatdesc
                oRec.Unline = oItem.Unline
                oRec.Classrate = oItem.Classrate
                oRec.Ld1 = oItem.Ld1
                oRec.Ld2 = oItem.Ld2
                oRec.Ld3 = oItem.Ld3
                oRec.Billable = 0
                oRec.Workorderitemnumber = oItem.Workorderitemnumber
                oRec.Itemtype = oItem.Itemtype
                oRec.Save()
            Next
        Catch ex As Exception
            MsgBox("Error creating new shipment detail record(s)", MsgBoxStyle.Critical, "Error - New Shipment Detail Record (Shipment #1)")
            Return False
        End Try

        Try
            For Each oItem As Shipmentdetail In oItems2
                Dim oRec As New Shipmentdetail
                oRec.Shipmentnumber = oShipNew.Shipmentnumber
                oRec.Productid = oItem.Productid
                oRec.Productdesc = oItem.Productdesc
                oRec.Qtycontainers = oItem.Qtycontainers
                oRec.Totalweight = oItem.Totalweight
                oRec.Batchnumber = oItem.Batchnumber
                oRec.Stdweight = oItem.Stdweight
                oRec.Stdgallons = oItem.Stdgallons
                oRec.Container = oItem.Container
                oRec.Dotdesc = oItem.Dotdesc
                oRec.Hazmatdesc = oItem.Hazmatdesc
                oRec.Unline = oItem.Unline
                oRec.Classrate = oItem.Classrate
                oRec.Ld1 = oItem.Ld1
                oRec.Ld2 = oItem.Ld2
                oRec.Ld3 = oItem.Ld3
                oRec.Billable = 0
                oRec.Workorderitemnumber = oItem.Workorderitemnumber
                oRec.Itemtype = oItem.Itemtype
                oRec.Save()
            Next
        Catch ex As Exception
            MsgBox("Error creating new shipment detail record(s)", MsgBoxStyle.Critical, "Error - New Shipment Detail Record (Shipment #2)")
            Return False
        End Try

        MsgBox("New Shipment #" & oShipNew.Shipmentnumber.ToString & " was created.", MsgBoxStyle.Information, "SUCCESS - Loads Merged")

        Return True

    End Function

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If mergeLoads() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


End Class