Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Module CustomClasses

    Public Class CustomDevExGridView
        Inherits GridView
        Public Sub New(ByVal ownerGrid As DevExpress.XtraGrid.GridControl)
            MyBase.New(ownerGrid)

        End Sub
        Public Sub New()

        End Sub

        Protected Overrides Sub SetFilterRowValue(ByVal column As DevExpress.XtraGrid.Columns.GridColumn, ByVal _value As Object)
            MyBase.SetFilterRowValue(column, _value)
            SetCurrencyManagerPosition()
        End Sub

        Private Sub SetCurrencyManagerPosition()
            Dim manager As CurrencyManager = TryCast(GridControl.BindingContext(GridControl.DataSource, GridControl.DataMember), CurrencyManager)
            manager.Position = GetDataSourceRowIndex(0)
        End Sub

        Public Overrides Sub ClearColumnsFilter()
            MyBase.ClearColumnsFilter()
            If IsFilterRow(FocusedRowHandle) Then
                SetCurrencyManagerPosition()
            End If
        End Sub

    End Class



End Module
