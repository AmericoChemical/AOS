Imports AOS.BusinessObjects

Public Class frmMergeProducts

    Dim oKeep As ProductCollection
    Dim oRemove As ProductCollection



    Private Sub frmMergeProducts_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        getProducts()

    End Sub

    Private Sub getProducts()

        oKeep = New ProductCollection
        oKeep.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oKeep.LoadAll()
        oKeep.Filter = ""
        oKeep.Sort = "PRODUCTDESC ASC"
        bsKeep.DataSource = oKeep
        Me.grKeep.DataSource = bsKeep
        Me.grKeep.Refresh()

        oRemove = New ProductCollection
        oRemove.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oRemove.LoadAll()
        oRemove.Filter = ""
        oRemove.Sort = "PRODUCTDESC ASC"
        bsRemove.DataSource = oRemove
        Me.grRemove.DataSource = bsRemove
        Me.grRemove.Refresh()


    End Sub

   
    Private Sub btnFinished_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinished.Click
        Me.Close()
    End Sub

   
    Private Sub bsRemove_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsRemove.CurrentChanged
        Me.lblReplace.Text = "Replace " & bsRemove.Current.ProductID & " - " & bsRemove.Current.ProductDesc
    End Sub

    Private Sub bsKeep_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsKeep.CurrentChanged
        Me.lblKeep.Text = bsKeep.Current.ProductID & " - " & bsKeep.Current.ProductDesc
    End Sub

    Private Sub btnMerge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMerge.Click

        Dim vKeepID As Integer = 0
        Dim vRemoveID As Integer = 0
        Dim tblName As String = ""

        Dim cmd As SqlClient.SqlCommand

        Try
            vKeepID = bsKeep.Current.productid
            vRemoveID = bsRemove.Current.productid
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim str As String = "This process will replace " & vRemoveID.ToString & " - " & bsRemove.Current.ProductDesc & Chr(13)
        str = str & "with " & vKeepID.ToString & " - " & bsKeep.Current.ProductDesc & Chr(13) & Chr(13)
        str = str & "Are you sure you want to do this? THIS CANNOT BE UNDONE!"

        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm change request") = MsgBoxResult.No Then
            Exit Sub
        End If

        'now run a series of update queries to change Product ID values in several tables:

        tblName = "INVITEM"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        tblName = "PRICELIST"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        tblName = "CUSTORDERITEM"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        tblName = "PURCHASEITEM"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        tblName = "PURCHASERELEASEITEM"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        tblName = "RECEIVERITEM"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        tblName = "WORKORDERITEM"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        tblName = "SHIPMENTDETAIL"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        tblName = "INVOICEITEM"
        str = "UPDATE " & tblName & " SET ProductID = " & vKeepID.ToString & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        str = "DELETE FROM PRODUCT" & " WHERE ProductID = " & vRemoveID.ToString
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try

        MsgBox("Updates completed successfully")


    End Sub

End Class