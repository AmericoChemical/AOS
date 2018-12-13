'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11-11-2014 13:01:31
'===============================================================================

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data

Imports EntitySpaces.Interfaces

Namespace BusinessObjects

	Partial Public Class Productfulfillmentplan 
		Inherits esProductfulfillmentplan

        Public Function LoadByPriority(productId As Integer, priority As Integer) As Boolean
            Dim productPlans As New ProductfulfillmentplanCollection
            productPlans.Query.Where(productPlans.Query.Productid = productId And productPlans.Query.Priority = priority)
            If productPlans.Query.Load() AndAlso productPlans.Count > 0 Then
                Return Me.LoadByPrimaryKey(productPlans(0).Fulfillmentplanid)
            End If
            Return False
        End Function

    End Class

End Namespace
