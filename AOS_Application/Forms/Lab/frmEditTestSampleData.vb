Imports AOS.BusinessObjects

Public Class frmEditTestSampleData
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer
    Public vPassed As Boolean = False
    Private vNumTries As Integer = 0

    Public vEditType As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Test Sample"

    'here is where you dimension your object variables for the form
    Dim oSample As New Testsample
    Dim oAppearance As New ListAppearanceCollection
    Dim oProduct As New Product
    Dim oChemical As New Chemical

    Dim oColorList As ListChemicalcolorCollection
    Dim oClarityList As ListChemicalclarityCollection
    Dim oOdorList As ListChemodorCollection


#Region " SECURITY - RIBBON FUNCTIONS "

    Private Sub setRibbonOptions(ByVal vLevel As Integer)
        'used to control visibility of options presented on Ribbon control based on user security level of session
        Dim vPageNum As Integer = 0
        'iterate through the riboon pages and adjust visibility of whole page
        For vPageNum = 0 To Me.RibbonControl1.Pages.Count - 1
            If CInt(Me.RibbonControl1.Pages(vPageNum).Tag) > vLevel Then
                Me.RibbonControl1.Pages(vPageNum).Visible = False
            Else
                Me.RibbonControl1.Pages(vPageNum).Visible = True
                'if page will be visible, then iterate through page groups and adjust visibility of whole group
                Dim grpNum As Integer = 0
                For grpNum = 0 To Me.RibbonControl1.Pages(vPageNum).Groups.Count - 1
                    If CInt(Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Tag) > vLevel Then
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = False
                    Else
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = True
                    End If
                Next
            End If
        Next
        'have to iterate through individual items separately for whole ribbon and adjust visibility
        Dim itemNum As Integer = 0
        For itemNum = 0 To Me.RibbonControl1.Items.Count - 1
            If CInt(Me.RibbonControl1.Items(itemNum).Tag) > vLevel Then
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
        Next
    End Sub

#End Region

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setRibbonOptions(vCurrentUserSecurityLevel)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If vEditType = "EDIT" Then
            btnConfirm.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            btnCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            rbtnBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            btnConfirm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            rbtnBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        getLookupData()
        loadData()
    End Sub

    Private Sub loadData()
        editObject(vID)
    End Sub

    Private Sub getLookupData()
        oAppearance = New ListAppearanceCollection
        oAppearance.LoadAll()
        bsAppearance.DataSource = oAppearance

        oClarityList = New ListChemicalclarityCollection
        oClarityList.LoadAll()
        bsClarityList.DataSource = oClarityList

        oColorList = New ListChemicalcolorCollection
        oColorList.LoadAll()
        bsColorList.DataSource = oColorList

        oOdorList = New ListChemodorCollection
        oOdorList.LoadAll()
        bsOdorList.DataSource = oOdorList

    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oSample.LoadByPrimaryKey(vID)
        If oSample.Temperature Is Nothing Then
            oSample.Temperature = 70.0
        End If
        Me.bs.DataSource = oSample
        If Not getProductData(oSample.Productid) Then
            MsgBox("Error in retrieving Product/Chemical Reference Data for test. Test FAILED.", MsgBoxStyle.Critical, "Error - Missing Data")
            Me.Close()
        End If
    End Sub

    Private Function getProductData(vID As Integer) As Boolean

        Try
            oProduct = New Product
            oProduct.LoadByPrimaryKey(vID)
            eProductDesc.Text = oProduct.Productdesc
            eContainer.Text = oProduct.Container
        Catch ex As Exception
            Return False
        End Try

        If IsDBNull(oProduct.Chemicalid) Then
            Return False
        End If
        If oProduct.Chemicalid <= 0 Then
            Return False
        End If

        Try
            oChemical = New Chemical
            oChemical.LoadByPrimaryKey(oProduct.Chemicalid)
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Private Function confirmTestResults() As String

        bs.EndEdit()
        oSample.EndEdit()
        oSample.Testedby = vCurrentUserLogin
        oSample.Testtime = Now
        oSample.Save()

        'determine if sample passes chemistry standards tests
        Dim vPh As Boolean = False
        Dim vSG As Boolean = False
        Dim vColor As Boolean = False
        Dim vClarity As Boolean = False

        If oSample.Phresult >= oChemical.PHLOW And oSample.Phresult <= oChemical.PHHIGH Then
            oSample.Phaccepted = 1
            vPh = True
        End If

        If oSample.Sgresult >= oChemical.SgLow And oSample.Sgresult <= oChemical.SgHigh Then
            oSample.Sgaccepted = 1
            vSG = True
        End If

        If oSample.Clarity = oChemical.Chemicalclarity Then
            vClarity = True
        End If

        If oSample.Color = oChemical.Chemicalcolor Then
            vColor = True
        End If


        Dim vResult As String = Nothing

        If vPh And vSG And vColor And vClarity Then
            vResult = "PASSED"
            oSample.Passedtest = 1
            oSample.Passedby = vCurrentUserLogin
            oSample.Passedtime = Now
            vPassed = True
        End If

        If vPh And Not vSG Then
            vResult = "FAILED-SG"
            vPassed = False
        End If

        If Not vPh And vSG Then
            vResult = "FAILED-PH"
            vPassed = False
        End If

        If Not vPh And Not vSG Then
            vResult = "FAILED-BOTH"
            vPassed = False
        End If

        If Not vClarity Then
            vResult = "FAILED-CLARITY"
            vPassed = False
        End If

        If Not vColor Then
            vResult = "FAILED-COLOR"
            vPassed = False
        End If
        oSample.Save()

        Return vResult

    End Function

    Private Function changesCancelled() As Boolean
        If MsgBox("Are you sure you want to cancel this test?", MsgBoxStyle.YesNo, "Confirm Test Cancellation") = MsgBoxResult.No Then
            Return False
        End If
        bs.CancelEdit()
        Return True
    End Function

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            vPassed = False
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConfirm.ItemClick

        Dim vReason As String = confirmTestResults()

        Select Case vReason
            Case "PASSED"
                vPassed = True
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Case "FAILED-PH"
                vPassed = False
                MsgBox("The pH measurement is not within the required range for the selected product", MsgBoxStyle.Critical, "TEST FAILED")
            Case "FAILED-SG"
                vPassed = False
                MsgBox("The SG measurement is not within the required range for the selected product", MsgBoxStyle.Critical, "TEST FAILED")
            Case "FAILED-BOTH"
                vPassed = False
                MsgBox("Both the pH measurement and SG measurement are not within the required ranges for the selected product", MsgBoxStyle.Critical, "TEST FAILED")
            Case "FAILED-COLOR"
                vPassed = False
                MsgBox("The COLOR is not correct for the selected product", MsgBoxStyle.Critical, "TEST FAILED")
            Case "FAILED-CLARITY"
                vPassed = False
                MsgBox("The CLARITY is not correct for the selected product", MsgBoxStyle.Critical, "TEST FAILED")
        End Select

        If Not vPassed Then
            MsgBox("Your test results are not acceptable. Testing for the selected inventory items is now suspended. The Item(s) have been moved to a RECEIVED / HOLD status. Please see your supervisor for further instructions.", MsgBoxStyle.Critical, "Error - Testing Failed")

            Dim oItems As New InvitemCollection
            oItems.Query.Where(oItems.Query.Testsamplekey.Equal(vID))
            If oItems.Query.Load Then
                For Each oItem As Invitem In oItems
                    moveItemToRcvdHoldStatus(oItem.Invitemnumber, vReason)
                Next
            End If

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub

    Private Sub moveItemToRcvdHoldStatus(vItemID As Integer, vReason As String)
        Dim vPriorStatus As String = ""
        Dim oItem As New Invitem
        oItem.LoadByPrimaryKey(vItemID)
        vPriorStatus = oItem.Itemstatus
        oItem.Itemstatus = "RCVDHOLD"
        oItem.Save()
        addRcvdHoldRecord(vItemID, "CHEM TEST", vReason, vPriorStatus, False)
    End Sub

    Private Sub rbtnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnBack.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class