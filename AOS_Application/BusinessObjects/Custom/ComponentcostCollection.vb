'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/29/2018 11:03:05 AM
'===============================================================================

Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Reflection

Imports EntitySpaces.Interfaces
Imports EntitySpaces.Core

Namespace BusinessObjects

	Partial Public Class ComponentcostCollection
		Inherits esComponentcostCollection
		
        Public Sub New()
			' It is recommended that you do not put code in here
        End Sub
        Public Function GetComponentCostCollectionByComponentId(ByVal vComponentId As Integer) As ComponentcostCollection
            Dim oCosts As New ComponentcostCollection
            oCosts.Query.Where(oCosts.Query.ComponentId.Equal(vComponentId))
            oCosts.Query.Load()
            oCosts.Sort = "IsDefault Desc, IsActive DESC, EFFECTIVEDATE DESC"
            Return oCosts
        End Function
    End Class

End Namespace
