'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.1.0209.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/2/2011 6:56:24 PM
'===============================================================================

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data

Imports EntitySpaces.Interfaces

Namespace BusinessObjects

	Partial Public Class Materialproduct 
		Inherits esMaterialproduct

        Public Function LoadByPriority(materialId As Integer, priority As Integer) As Boolean
            Dim materialProducts As New MaterialproductCollection
            materialProducts.Query.Where(materialProducts.Query.Materialid = materialId And materialProducts.Query.Priority = priority)
            If materialProducts.Query.Load() AndAlso materialProducts.Count > 0 Then
                Return Me.LoadByPrimaryKey(materialProducts(0).Mpid)
            End If
            Return False
        End Function
    End Class

End Namespace
