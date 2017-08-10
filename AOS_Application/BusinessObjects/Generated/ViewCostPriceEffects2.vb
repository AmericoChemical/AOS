'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/31/2017 9:32:24 AM
'===============================================================================

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.ComponentModel
Imports System.Xml.Serialization


Imports EntitySpaces.Interfaces
Imports EntitySpaces.Core
Imports EntitySpaces.DynamicQuery

 
Namespace BusinessObjects


	<Serializable> _
	MustInherit Public Class esViewCostPriceEffects2Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCostPriceEffects2Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCostPriceEffects2Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntityCollection).Connection
		End Sub

        Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
            Me.PopulateCollection(table)

            If Me.RowCount > 0 Then
                Return True
            Else
                Return False
            End If
        End Function
		
        Protected Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
            Me.InitQuery(CType(query, esViewCostPriceEffects2Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCostPriceEffects2) As ViewCostPriceEffects2
			Return CType(MyBase.DetachEntity(entity), ViewCostPriceEffects2)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCostPriceEffects2) As ViewCostPriceEffects2
			Return CType(MyBase.AttachEntity(entity), ViewCostPriceEffects2)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCostPriceEffects2Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCostPriceEffects2
            Get
                Return TryCast(MyBase.Item(index), ViewCostPriceEffects2)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCostPriceEffects2)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCostPriceEffects2	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCostPriceEffects2Query
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		
#End Region
			
		
#Region "Properties"

		Public Overrides Sub SetProperties(values as IDictionary)

		Dim propertyName As String
			For Each propertyName In values.Keys
				Me.SetProperty(propertyName, values(propertyName))
			Next

		End Sub

		Public Overrides Sub SetProperty(name as string, value as object)

			If Me.Row Is Nothing Then
				Me.AddNew()
			End IF
			
			Dim col As esColumnMetadata = Me.Meta.Columns.FindByPropertyName(name)
			If Not col Is Nothing Then

				If value Is Nothing OrElse value.GetType().ToString() = "System.String" Then

					' Use the strongly typed property
					Select Case name
												
						Case "ProductID"
							Me.str.ProductID = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Changetype"
							Me.str.Changetype = CType(value, string)
												
						Case "Changedate"
							Me.str.Changedate = CType(value, string)
												
						Case "Whychanged"
							Me.str.Whychanged = CType(value, string)
												
						Case "Oldcost"
							Me.str.Oldcost = CType(value, string)
												
						Case "Newcost"
							Me.str.Newcost = CType(value, string)
												
						Case "Costdelta"
							Me.str.Costdelta = CType(value, string)
												
						Case "VolOld"
							Me.str.VolOld = CType(value, string)
												
						Case "VolNew"
							Me.str.VolNew = CType(value, string)
												
						Case "WgtOld"
							Me.str.WgtOld = CType(value, string)
												
						Case "WgtNew"
							Me.str.WgtNew = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Salesprice"
							Me.str.Salesprice = CType(value, string)
												
						Case "Pricingmethod"
							Me.str.Pricingmethod = CType(value, string)
												
						Case "Per"
							Me.str.Per = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "ProductID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProductID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Changedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Changedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Oldcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Oldcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Newcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Newcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Costdelta"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Costdelta = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "VolOld"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.VolOld = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "VolNew"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.VolNew = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "WgtOld"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WgtOld = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "WgtNew"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WgtNew = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Salesprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Salesprice = CType(value, Nullable(Of System.Decimal))
							End If
						
					
						Case Else
						
					End Select
				End If

			Else If Me.Row.Table.Columns.Contains(name) Then
				Me.Row(name) = value
			Else
				throw New Exception("SetProperty Error: '" + name + "' not found")
			End If	

		End Sub
		
			
		' <summary>
		' Maps to viewCostPriceEffects2.ProductID
		' </summary>
		Public Overridable Property ProductID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCostPriceEffects2Metadata.ColumnNames.ProductID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCostPriceEffects2Metadata.ColumnNames.ProductID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.CHANGETYPE
		' </summary>
		Public Overridable Property Changetype As System.String
			Get
				Return MyBase.GetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Changetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Changetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.CHANGEDATE
		' </summary>
		Public Overridable Property Changedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCostPriceEffects2Metadata.ColumnNames.Changedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCostPriceEffects2Metadata.ColumnNames.Changedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.WHYCHANGED
		' </summary>
		Public Overridable Property Whychanged As System.String
			Get
				Return MyBase.GetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Whychanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Whychanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.OLDCOST
		' </summary>
		Public Overridable Property Oldcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.Oldcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.Oldcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.NEWCOST
		' </summary>
		Public Overridable Property Newcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.Newcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.Newcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.COSTDELTA
		' </summary>
		Public Overridable Property Costdelta As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.Costdelta)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.Costdelta, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.VOL_OLD
		' </summary>
		Public Overridable Property VolOld As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.VolOld)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.VolOld, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.VOL_NEW
		' </summary>
		Public Overridable Property VolNew As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.VolNew)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.VolNew, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.WGT_OLD
		' </summary>
		Public Overridable Property WgtOld As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.WgtOld)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.WgtOld, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.WGT_NEW
		' </summary>
		Public Overridable Property WgtNew As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.WgtNew)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.WgtNew, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.SALESPRICE
		' </summary>
		Public Overridable Property Salesprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.Salesprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostPriceEffects2Metadata.ColumnNames.Salesprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.PRICINGMETHOD
		' </summary>
		Public Overridable Property Pricingmethod As System.String
			Get
				Return MyBase.GetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Pricingmethod)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Pricingmethod, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.PER
		' </summary>
		Public Overridable Property Per As System.String
			Get
				Return MyBase.GetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Per)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Per, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostPriceEffects2.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostPriceEffects2Metadata.ColumnNames.Uom, value)
			End Set
		End Property		
		
#End Region	

#Region "String Properties"


		<BrowsableAttribute( false )> _
		Public ReadOnly Property str As esStrings
			Get
				If _esstrings Is Nothing Then
					_esstrings = New esStrings(Me)
				End If
				Return _esstrings
			End Get
		End Property


		<Serializable> _
		NotInheritable Public Class esStrings
		
			Public Sub New(ByVal entity As esViewCostPriceEffects2)
				Me.entity = entity
			End Sub				
		
	
			Public Property ProductID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProductID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProductID = Nothing
					Else
						entity.ProductID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productdesc As System.String 
				Get
					Dim data_ As System.String = entity.Productdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productdesc = Nothing
					Else
						entity.Productdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Container As System.String 
				Get
					Dim data_ As System.String = entity.Container
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Container = Nothing
					Else
						entity.Container = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changetype As System.String 
				Get
					Dim data_ As System.String = entity.Changetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changetype = Nothing
					Else
						entity.Changetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Changedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changedate = Nothing
					Else
						entity.Changedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whychanged As System.String 
				Get
					Dim data_ As System.String = entity.Whychanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whychanged = Nothing
					Else
						entity.Whychanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Oldcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Oldcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Oldcost = Nothing
					Else
						entity.Oldcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Newcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newcost = Nothing
					Else
						entity.Newcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Costdelta As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Costdelta
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Costdelta = Nothing
					Else
						entity.Costdelta = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property VolOld As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.VolOld
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VolOld = Nothing
					Else
						entity.VolOld = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property VolNew As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.VolNew
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VolNew = Nothing
					Else
						entity.VolNew = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WgtOld As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WgtOld
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WgtOld = Nothing
					Else
						entity.WgtOld = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WgtNew As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WgtNew
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WgtNew = Nothing
					Else
						entity.WgtNew = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custname As System.String 
				Get
					Dim data_ As System.String = entity.Custname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custname = Nothing
					Else
						entity.Custname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salesprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Salesprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salesprice = Nothing
					Else
						entity.Salesprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pricingmethod As System.String 
				Get
					Dim data_ As System.String = entity.Pricingmethod
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pricingmethod = Nothing
					Else
						entity.Pricingmethod = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Per As System.String 
				Get
					Dim data_ As System.String = entity.Per
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Per = Nothing
					Else
						entity.Per = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCostPriceEffects2
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCostPriceEffects2Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCostPriceEffects2 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCostPriceEffects2Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCostPriceEffects2Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property ProductID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.ProductID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Changetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Changedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Whychanged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Whychanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Oldcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Oldcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Newcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Newcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Costdelta As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Costdelta, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property VolOld As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.VolOld, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property VolNew As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.VolNew, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WgtOld As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.WgtOld, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WgtNew As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.WgtNew, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Salesprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Salesprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pricingmethod As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Pricingmethod, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Per As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Per, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostPriceEffects2Metadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCostPriceEffects2Collection")> _
	Partial Public Class ViewCostPriceEffects2Collection
		Inherits esViewCostPriceEffects2Collection
		Implements IEnumerable(Of ViewCostPriceEffects2)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCostPriceEffects2Collection) As List(Of ViewCostPriceEffects2)
            Dim list As List(Of ViewCostPriceEffects2) = New List(Of ViewCostPriceEffects2)
            Dim emp As ViewCostPriceEffects2

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCostPriceEffects2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCostPriceEffects2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCostPriceEffects2(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCostPriceEffects2()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCostPriceEffects2Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCostPriceEffects2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCostPriceEffects2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCostPriceEffects2 
			Return CType(MyBase.AddNewEntity(), ViewCostPriceEffects2)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCostPriceEffects2) Implements IEnumerable(Of ViewCostPriceEffects2).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCostPriceEffects2)(Me)
        End Function
		
		Private _query As ViewCostPriceEffects2Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewCostPriceEffects2' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCostPriceEffects2 ()")> _
	<Serializable> _
	Partial Public Class ViewCostPriceEffects2 
		Inherits esViewCostPriceEffects2

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCostPriceEffects2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCostPriceEffects2Query

			If Me._query Is Nothing Then
				Me._query = New ViewCostPriceEffects2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCostPriceEffects2Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCostPriceEffects2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCostPriceEffects2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCostPriceEffects2Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCostPriceEffects2Query
		inherits esViewCostPriceEffects2Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCostPriceEffects2Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCostPriceEffects2Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.ProductID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.ProductID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Changetype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Changetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Changedate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Changedate
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Whychanged, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Whychanged
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Oldcost, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Oldcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Newcost, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Newcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Costdelta, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Costdelta
			c.NumericPrecision = 19
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.VolOld, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.VolOld
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.VolNew, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.VolNew
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.WgtOld, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.WgtOld
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.WgtNew, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.WgtNew
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Custname, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Salesprice, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Salesprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Pricingmethod, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Pricingmethod
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Per, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Per
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostPriceEffects2Metadata.ColumnNames.Uom, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostPriceEffects2Metadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCostPriceEffects2Metadata
            Return _meta
		End Function
		
        Public ReadOnly Property DataID() As System.Guid Implements IMetadata.DataID
            Get
                Return MyBase._dataID
            End Get
        End Property

        Public ReadOnly Property MultiProviderMode() As Boolean Implements IMetadata.MultiProviderMode
            Get
                Return false
            End Get
        End Property

        Public ReadOnly Property Columns() As esColumnMetadataCollection Implements IMetadata.Columns
            Get
                Return MyBase._columns
            End Get
        End Property		

		
#Region "ColumnNames"
		Public Class ColumnNames
			 Public Const ProductID As String = "ProductID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Changetype As String = "CHANGETYPE"
			 Public Const Changedate As String = "CHANGEDATE"
			 Public Const Whychanged As String = "WHYCHANGED"
			 Public Const Oldcost As String = "OLDCOST"
			 Public Const Newcost As String = "NEWCOST"
			 Public Const Costdelta As String = "COSTDELTA"
			 Public Const VolOld As String = "VOL_OLD"
			 Public Const VolNew As String = "VOL_NEW"
			 Public Const WgtOld As String = "WGT_OLD"
			 Public Const WgtNew As String = "WGT_NEW"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Salesprice As String = "SALESPRICE"
			 Public Const Pricingmethod As String = "PRICINGMETHOD"
			 Public Const Per As String = "PER"
			 Public Const Uom As String = "UOM"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const ProductID As String = "ProductID"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Changetype As String = "Changetype"
			 Public Const Changedate As String = "Changedate"
			 Public Const Whychanged As String = "Whychanged"
			 Public Const Oldcost As String = "Oldcost"
			 Public Const Newcost As String = "Newcost"
			 Public Const Costdelta As String = "Costdelta"
			 Public Const VolOld As String = "VolOld"
			 Public Const VolNew As String = "VolNew"
			 Public Const WgtOld As String = "WgtOld"
			 Public Const WgtNew As String = "WgtNew"
			 Public Const Custname As String = "Custname"
			 Public Const Salesprice As String = "Salesprice"
			 Public Const Pricingmethod As String = "Pricingmethod"
			 Public Const Per As String = "Per"
			 Public Const Uom As String = "Uom"
		End Class
#End Region	

        Public Function GetProviderMetadata(ByVal mapName As String) As esProviderSpecificMetadata _
            Implements IMetadata.GetProviderMetadata

            Dim mapMethod As MapToMeta = mapDelegates(mapName)

            If (Not mapMethod = Nothing) Then
                Return mapMethod(mapName)
            Else
                Return Nothing
            End If

        End Function	
		
#Region "MAP esDefault"

        Private Shared Function RegisterDelegateesDefault() As Integer
		
            ' This is only executed once per the life of the application
            SyncLock GetType(ViewCostPriceEffects2Metadata)
			
				If ViewCostPriceEffects2Metadata.mapDelegates Is Nothing Then
					ViewCostPriceEffects2Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCostPriceEffects2Metadata._meta Is Nothing Then
                    ViewCostPriceEffects2Metadata._meta = New ViewCostPriceEffects2Metadata()
                End If

                Dim mapMethod As New MapToMeta(AddressOf _meta.esDefault)
                mapDelegates.Add("esDefault", mapMethod)
                mapMethod("esDefault")
                Return 0

            End SyncLock			
			
        End Function

        Private Function esDefault(ByVal mapName As String) As esProviderSpecificMetadata

            If (Not _providerMetadataMaps.ContainsKey(mapName)) Then
			
				Dim meta As esProviderSpecificMetadata = New esProviderSpecificMetadata()
				

				meta.AddTypeMap("ProductID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Changetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Changedate", new esTypeMap("date", "System.DateTime"))
				meta.AddTypeMap("Whychanged", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Oldcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Newcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Costdelta", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("VolOld", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("VolNew", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("WgtOld", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("WgtNew", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Salesprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Pricingmethod", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Per", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCostPriceEffects2"
				meta.Destination = "viewCostPriceEffects2"
				
				meta.spInsert = "proc_viewCostPriceEffects2Insert"
				meta.spUpdate = "proc_viewCostPriceEffects2Update"
				meta.spDelete = "proc_viewCostPriceEffects2Delete"
				meta.spLoadAll = "proc_viewCostPriceEffects2LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCostPriceEffects2LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCostPriceEffects2Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
