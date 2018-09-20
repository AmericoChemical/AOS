'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/6/2014 7:45:05 PM
'===============================================================================

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data

Imports EntitySpaces.Interfaces

Namespace BusinessObjects

	Partial Public Class Component 
		Inherits esComponent

        Public Function getComponentByComponentID(ByVal vComponentId As Integer) As Component
            Dim oComponent As New Component
            oComponent.LoadByPrimaryKey(vComponentId)
            Return oComponent
        End Function

    End Class

End Namespace
