Module GHSProcessing
    Public Sub viewPrintSDSDocumentByProduct(vProductID As Integer)

        If IsDBNull(vProductID) Then
            Exit Sub
        End If

        Dim oProduct As New Product
        If Not oProduct.LoadByPrimaryKey(vProductID) Then
            MsgBox("Could not locate Product record.", MsgBoxStyle.Critical, "Error - Missing Product Record")
            Exit Sub
        End If

        If IsDBNull(oProduct.Chemicalid) Then
            MsgBox("Product has no Chemical linked to it. Cannot View/Print SDS Document.", MsgBoxStyle.Critical, "Error - Missing Chemical Link")
            Exit Sub
        End If

        If Not viewPrintSDS(oProduct.Chemicalid) Then
            MsgBox("There was an error in viewing/printing the SDS document for the selected Product", MsgBoxStyle.Critical, "Error - Missing or Incorrect Chemical Data")
        End If

    End Sub

    Public Sub viewPrintSDSDocumentByChemical(vChemicalID As Integer)
        If IsDBNull(vChemicalID) Then
            Exit Sub
        End If
        If Not viewPrintSDS(vChemicalID) Then
            MsgBox("There was an error in viewing/printing the SDS document for the selected Chemical", MsgBoxStyle.Critical, "Error - Missing or Incorrect Chemical Data")
        End If
    End Sub

    Private Function viewPrintSDS(vChemicalID As Integer) As Boolean

        If IsDBNull(vChemicalID) Then
            Return False
        End If

        Dim oChem As New Chemical
        If Not oChem.LoadByPrimaryKey(vChemicalID) Then
            Return False
        End If

        If IsDBNull(oChem.Sdsfilepath) Then
            Return False
        End If

        If oChem.Sdsfilepath = Nothing Then
            Return False
        End If

        Dim frm As New frmPDFViewer
        frm.vSDSDocPath = oChem.Sdsfilepath
        frm.ShowDialog()

        Return True

    End Function
End Module
