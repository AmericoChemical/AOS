'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:08 PM
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
	MustInherit Public Class esViewAPISRawMaterialNeededCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAPISRawMaterialNeededCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAPISRawMaterialNeededQuery)
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
            Me.InitQuery(CType(query, esViewAPISRawMaterialNeededQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAPISRawMaterialNeeded) As ViewAPISRawMaterialNeeded
			Return CType(MyBase.DetachEntity(entity), ViewAPISRawMaterialNeeded)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAPISRawMaterialNeeded) As ViewAPISRawMaterialNeeded
			Return CType(MyBase.AttachEntity(entity), ViewAPISRawMaterialNeeded)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAPISRawMaterialNeededCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAPISRawMaterialNeeded
            Get
                Return TryCast(MyBase.Item(index), ViewAPISRawMaterialNeeded)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAPISRawMaterialNeeded)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAPISRawMaterialNeeded	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAPISRawMaterialNeededQuery
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
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Apisdesc"
							Me.str.Apisdesc = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Qtycontainers"
							Me.str.Qtycontainers = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Qtyunits"
							Me.str.Qtyunits = CType(value, string)
												
						Case "Expr1"
							Me.str.Expr1 = CType(value, string)
												
						Case "Materialdesc"
							Me.str.Materialdesc = CType(value, string)
												
						Case "Inventory"
							Me.str.Inventory = CType(value, string)
												
						Case "Inprocess"
							Me.str.Inprocess = CType(value, string)
												
						Case "Available"
							Me.str.Available = CType(value, string)
												
						Case "Needed"
							Me.str.Needed = CType(value, string)
												
						Case "Balance"
							Me.str.Balance = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtycontainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtycontainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qtyunits = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Inventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Inventory = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Inprocess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Inprocess = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Available"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Available = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Needed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Needed = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Balance"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Balance = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewAPISRawMaterialNeeded.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.APISDESC
		' </summary>
		Public Overridable Property Apisdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Apisdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Apisdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISRawMaterialNeededMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISRawMaterialNeededMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISRawMaterialNeededMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.QTYUNITS
		' </summary>
		Public Overridable Property Qtyunits As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewAPISRawMaterialNeededMetadata.ColumnNames.Qtyunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewAPISRawMaterialNeededMetadata.ColumnNames.Qtyunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.Expr1
		' </summary>
		Public Overridable Property Expr1 As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Expr1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Expr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISRawMaterialNeededMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.INVENTORY
		' </summary>
		Public Overridable Property Inventory As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewAPISRawMaterialNeededMetadata.ColumnNames.Inventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewAPISRawMaterialNeededMetadata.ColumnNames.Inventory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.INPROCESS
		' </summary>
		Public Overridable Property Inprocess As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewAPISRawMaterialNeededMetadata.ColumnNames.Inprocess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewAPISRawMaterialNeededMetadata.ColumnNames.Inprocess, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.AVAILABLE
		' </summary>
		Public Overridable Property Available As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewAPISRawMaterialNeededMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewAPISRawMaterialNeededMetadata.ColumnNames.Available, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.NEEDED
		' </summary>
		Public Overridable Property Needed As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISRawMaterialNeededMetadata.ColumnNames.Needed)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISRawMaterialNeededMetadata.ColumnNames.Needed, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISRawMaterialNeeded.BALANCE
		' </summary>
		Public Overridable Property Balance As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISRawMaterialNeededMetadata.ColumnNames.Balance)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISRawMaterialNeededMetadata.ColumnNames.Balance, value)
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
		
			Public Sub New(ByVal entity As esViewAPISRawMaterialNeeded)
				Me.entity = entity
			End Sub				
		
	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisdesc As System.String 
				Get
					Dim data_ As System.String = entity.Apisdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisdesc = Nothing
					Else
						entity.Apisdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productid = Nothing
					Else
						entity.Productid = Convert.ToInt32(Value)
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
		  	
			Public Property Qtycontainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtycontainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtycontainers = Nothing
					Else
						entity.Qtycontainers = Convert.ToInt32(Value)
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
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Units
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Units = Nothing
					Else
						entity.Units = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitcost = Nothing
					Else
						entity.Unitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qtyunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyunits = Nothing
					Else
						entity.Qtyunits = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr1 As System.String 
				Get
					Dim data_ As System.String = entity.Expr1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr1 = Nothing
					Else
						entity.Expr1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialdesc As System.String 
				Get
					Dim data_ As System.String = entity.Materialdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialdesc = Nothing
					Else
						entity.Materialdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventory As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Inventory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventory = Nothing
					Else
						entity.Inventory = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inprocess As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Inprocess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inprocess = Nothing
					Else
						entity.Inprocess = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Available As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Available
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Available = Nothing
					Else
						entity.Available = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Needed As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Needed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Needed = Nothing
					Else
						entity.Needed = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Balance As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Balance
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Balance = Nothing
					Else
						entity.Balance = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAPISRawMaterialNeeded
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAPISRawMaterialNeededQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAPISRawMaterialNeeded can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAPISRawMaterialNeededQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAPISRawMaterialNeededMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Apisdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Qtyunits, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Expr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Expr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Inventory, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Inprocess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Inprocess, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Available, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Needed As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Needed, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Balance As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISRawMaterialNeededMetadata.ColumnNames.Balance, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAPISRawMaterialNeededCollection")> _
	Partial Public Class ViewAPISRawMaterialNeededCollection
		Inherits esViewAPISRawMaterialNeededCollection
		Implements IEnumerable(Of ViewAPISRawMaterialNeeded)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAPISRawMaterialNeededCollection) As List(Of ViewAPISRawMaterialNeeded)
            Dim list As List(Of ViewAPISRawMaterialNeeded) = New List(Of ViewAPISRawMaterialNeeded)
            Dim emp As ViewAPISRawMaterialNeeded

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAPISRawMaterialNeededMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAPISRawMaterialNeededQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAPISRawMaterialNeeded(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAPISRawMaterialNeeded()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAPISRawMaterialNeededQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAPISRawMaterialNeededQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAPISRawMaterialNeededQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAPISRawMaterialNeeded 
			Return CType(MyBase.AddNewEntity(), ViewAPISRawMaterialNeeded)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAPISRawMaterialNeeded) Implements IEnumerable(Of ViewAPISRawMaterialNeeded).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAPISRawMaterialNeeded)(Me)
        End Function
		
		Private _query As ViewAPISRawMaterialNeededQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAPISRawMaterialNeeded' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAPISRawMaterialNeeded ()")> _
	<Serializable> _
	Partial Public Class ViewAPISRawMaterialNeeded 
		Inherits esViewAPISRawMaterialNeeded

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAPISRawMaterialNeededMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAPISRawMaterialNeededQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAPISRawMaterialNeededQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAPISRawMaterialNeededQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAPISRawMaterialNeededQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAPISRawMaterialNeededQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAPISRawMaterialNeededQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAPISRawMaterialNeededQuery
		inherits esViewAPISRawMaterialNeededQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAPISRawMaterialNeededQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAPISRawMaterialNeededMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Apisnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Apisdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Apisdesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Qtycontainers, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Uom, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Units, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Unitcost, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Materialid, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Qtyunits, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Qtyunits
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Expr1, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Expr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Materialdesc, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Inventory, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Inventory
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Inprocess, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Inprocess
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Available, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Available
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Needed, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Needed
			c.NumericPrecision = 1
			c.NumericScale = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISRawMaterialNeededMetadata.ColumnNames.Balance, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISRawMaterialNeededMetadata.PropertyNames.Balance
			c.NumericPrecision = 1
			c.NumericScale = 1
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAPISRawMaterialNeededMetadata
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
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Apisdesc As String = "APISDESC"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Container As String = "CONTAINER"
			 Public Const Qtycontainers As String = "QTYCONTAINERS"
			 Public Const Uom As String = "UOM"
			 Public Const Units As String = "UNITS"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Qtyunits As String = "QTYUNITS"
			 Public Const Expr1 As String = "Expr1"
			 Public Const Materialdesc As String = "MATERIALDESC"
			 Public Const Inventory As String = "INVENTORY"
			 Public Const Inprocess As String = "INPROCESS"
			 Public Const Available As String = "AVAILABLE"
			 Public Const Needed As String = "NEEDED"
			 Public Const Balance As String = "BALANCE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Apisdesc As String = "Apisdesc"
			 Public Const Productid As String = "Productid"
			 Public Const Container As String = "Container"
			 Public Const Qtycontainers As String = "Qtycontainers"
			 Public Const Uom As String = "Uom"
			 Public Const Units As String = "Units"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Materialid As String = "Materialid"
			 Public Const Qtyunits As String = "Qtyunits"
			 Public Const Expr1 As String = "Expr1"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const Inventory As String = "Inventory"
			 Public Const Inprocess As String = "Inprocess"
			 Public Const Available As String = "Available"
			 Public Const Needed As String = "Needed"
			 Public Const Balance As String = "Balance"
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
            SyncLock GetType(ViewAPISRawMaterialNeededMetadata)
			
				If ViewAPISRawMaterialNeededMetadata.mapDelegates Is Nothing Then
					ViewAPISRawMaterialNeededMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAPISRawMaterialNeededMetadata._meta Is Nothing Then
                    ViewAPISRawMaterialNeededMetadata._meta = New ViewAPISRawMaterialNeededMetadata()
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
				

				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtycontainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyunits", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Expr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Materialdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventory", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Inprocess", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Available", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Needed", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Balance", new esTypeMap("numeric", "System.Decimal"))			
				
				
				 
				meta.Source = "viewAPISRawMaterialNeeded"
				meta.Destination = "viewAPISRawMaterialNeeded"
				
				meta.spInsert = "proc_viewAPISRawMaterialNeededInsert"
				meta.spUpdate = "proc_viewAPISRawMaterialNeededUpdate"
				meta.spDelete = "proc_viewAPISRawMaterialNeededDelete"
				meta.spLoadAll = "proc_viewAPISRawMaterialNeededLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAPISRawMaterialNeededLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAPISRawMaterialNeededMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
