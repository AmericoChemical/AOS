'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/15/2014 4:18:21 PM
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
	MustInherit Public Class esPoitemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "PoitemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esPoitemQuery)
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
            Me.InitQuery(CType(query, esPoitemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Poitem) As Poitem
			Return CType(MyBase.DetachEntity(entity), Poitem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Poitem) As Poitem
			Return CType(MyBase.AttachEntity(entity), Poitem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As PoitemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Poitem
            Get
                Return TryCast(MyBase.Item(index), Poitem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Poitem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esPoitem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esPoitemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal poitemnumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(poitemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(poitemnumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal poitemnumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(poitemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(poitemnumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal poitemnumber As System.Int32) As Boolean
		
			Dim query As esPoitemQuery = Me.GetDynamicQuery()
			query.Where(query.Poitemnumber.Equal(poitemnumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal poitemnumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("POITEMNUMBER", poitemnumber)
			
			Return Me.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
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
												
						Case "Poitemnumber"
							Me.str.Poitemnumber = CType(value, string)
												
						Case "Ponumber"
							Me.str.Ponumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Qtyordered"
							Me.str.Qtyordered = CType(value, string)
												
						Case "Qtyreleased"
							Me.str.Qtyreleased = CType(value, string)
												
						Case "Qtyreceived"
							Me.str.Qtyreceived = CType(value, string)
												
						Case "Qtycanceled"
							Me.str.Qtycanceled = CType(value, string)
												
						Case "Vendoritemnumber"
							Me.str.Vendoritemnumber = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Extcost"
							Me.str.Extcost = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Expecteddelivery"
							Me.str.Expecteddelivery = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Weightunits"
							Me.str.Weightunits = CType(value, string)
												
						Case "Weightstandardcost"
							Me.str.Weightstandardcost = CType(value, string)
												
						Case "Volumeuom"
							Me.str.Volumeuom = CType(value, string)
												
						Case "Volumeunits"
							Me.str.Volumeunits = CType(value, string)
												
						Case "Volumestandardcost"
							Me.str.Volumestandardcost = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Poitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Poitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Ponumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Ponumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyordered"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyordered = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtyreleased"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyreleased = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtyreceived"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyreceived = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtycanceled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtycanceled = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Expecteddelivery"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expecteddelivery = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Weightunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightstandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightstandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumeunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumestandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumestandardcost = CType(value, Nullable(Of System.Decimal))
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
		' Maps to POITEM.POITEMNUMBER
		' </summary>
		Public Overridable Property Poitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PoitemMetadata.ColumnNames.Poitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PoitemMetadata.ColumnNames.Poitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.PONUMBER
		' </summary>
		Public Overridable Property Ponumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PoitemMetadata.ColumnNames.Ponumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PoitemMetadata.ColumnNames.Ponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PoitemMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PoitemMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(PoitemMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoitemMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.QTYORDERED
		' </summary>
		Public Overridable Property Qtyordered As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Qtyordered)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Qtyordered, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.QTYRELEASED
		' </summary>
		Public Overridable Property Qtyreleased As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Qtyreleased)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Qtyreleased, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.QTYRECEIVED
		' </summary>
		Public Overridable Property Qtyreceived As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Qtyreceived)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Qtyreceived, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.QTYCANCELED
		' </summary>
		Public Overridable Property Qtycanceled As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Qtycanceled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Qtycanceled, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.VENDORITEMNUMBER
		' </summary>
		Public Overridable Property Vendoritemnumber As System.String
			Get
				Return MyBase.GetSystemString(PoitemMetadata.ColumnNames.Vendoritemnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoitemMetadata.ColumnNames.Vendoritemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(PoitemMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoitemMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(PoitemMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoitemMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(PoitemMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoitemMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PoitemMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PoitemMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.EXPECTEDDELIVERY
		' </summary>
		Public Overridable Property Expecteddelivery As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PoitemMetadata.ColumnNames.Expecteddelivery)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PoitemMetadata.ColumnNames.Expecteddelivery, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(PoitemMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoitemMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.WEIGHTUNITS
		' </summary>
		Public Overridable Property Weightunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Weightunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Weightunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.WEIGHTSTANDARDCOST
		' </summary>
		Public Overridable Property Weightstandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Weightstandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Weightstandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(PoitemMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoitemMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.VOLUMEUNITS
		' </summary>
		Public Overridable Property Volumeunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Volumeunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Volumeunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to POITEM.VOLUMESTANDARDCOST
		' </summary>
		Public Overridable Property Volumestandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoitemMetadata.ColumnNames.Volumestandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoitemMetadata.ColumnNames.Volumestandardcost, value)
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
		
			Public Sub New(ByVal entity As esPoitem)
				Me.entity = entity
			End Sub				
		
	
			Public Property Poitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Poitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Poitemnumber = Nothing
					Else
						entity.Poitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ponumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Ponumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ponumber = Nothing
					Else
						entity.Ponumber = Convert.ToInt32(Value)
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
		  	
			Public Property Qtyordered As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyordered
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyordered = Nothing
					Else
						entity.Qtyordered = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyreleased As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyreleased
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyreleased = Nothing
					Else
						entity.Qtyreleased = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyreceived As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyreceived
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyreceived = Nothing
					Else
						entity.Qtyreceived = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtycanceled As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtycanceled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtycanceled = Nothing
					Else
						entity.Qtycanceled = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoritemnumber As System.String 
				Get
					Dim data_ As System.String = entity.Vendoritemnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoritemnumber = Nothing
					Else
						entity.Vendoritemnumber = Convert.ToString(Value)
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
		  	
			Public Property Extcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extcost = Nothing
					Else
						entity.Extcost = Convert.ToDecimal(Value)
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
		  	
			Public Property Unitorcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Unitorcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitorcontainer = Nothing
					Else
						entity.Unitorcontainer = Convert.ToString(Value)
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
		  	
			Public Property Expecteddelivery As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expecteddelivery
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expecteddelivery = Nothing
					Else
						entity.Expecteddelivery = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightuom As System.String 
				Get
					Dim data_ As System.String = entity.Weightuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightuom = Nothing
					Else
						entity.Weightuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightunits = Nothing
					Else
						entity.Weightunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightstandardcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightstandardcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightstandardcost = Nothing
					Else
						entity.Weightstandardcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeuom As System.String 
				Get
					Dim data_ As System.String = entity.Volumeuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeuom = Nothing
					Else
						entity.Volumeuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeunits = Nothing
					Else
						entity.Volumeunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumestandardcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumestandardcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumestandardcost = Nothing
					Else
						entity.Volumestandardcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esPoitem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esPoitemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esPoitem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Poitem 
		Inherits esPoitem
		
	
		
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
        Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
        
            Dim props As New List(Of esPropertyDescriptor)
			

            Return props
			
        End Function	
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostOneSave.
		''' </summary>
		Protected Overrides Sub ApplyPostOneSaveKeys()
		
		End Sub
	End Class
	


	<Serializable> _
	MustInherit Public Class esPoitemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PoitemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Poitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Poitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Ponumber As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Ponumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyordered As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Qtyordered, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyreleased As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Qtyreleased, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyreceived As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Qtyreceived, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycanceled As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Qtycanceled, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoritemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Vendoritemnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Expecteddelivery As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Expecteddelivery, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightunits As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Weightunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightstandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Weightstandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeunits As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Volumeunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumestandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, PoitemMetadata.ColumnNames.Volumestandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("PoitemCollection")> _
	Partial Public Class PoitemCollection
		Inherits esPoitemCollection
		Implements IEnumerable(Of Poitem)
		
        Public Shared Widening Operator CType(ByVal coll As PoitemCollection) As List(Of Poitem)
            Dim list As List(Of Poitem) = New List(Of Poitem)
            Dim emp As Poitem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PoitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New PoitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Poitem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Poitem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As PoitemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New PoitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PoitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Poitem 
			Return CType(MyBase.AddNewEntity(), Poitem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal poitemnumber As System.Int32) As Poitem
			Return CType(MyBase.FindByPrimaryKey(poitemnumber), Poitem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Poitem) Implements IEnumerable(Of Poitem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Poitem)(Me)
        End Function
		
		Private _query As PoitemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'POITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Poitem ({Poitemnumber.Value})")> _
	<Serializable> _
	Partial Public Class Poitem 
		Inherits esPoitem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return PoitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esPoitemQuery

			If Me._query Is Nothing Then
				Me._query = New PoitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As PoitemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New PoitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PoitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As PoitemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class PoitemQuery
		inherits esPoitemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "PoitemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class PoitemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Poitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PoitemMetadata.PropertyNames.Poitemnumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Ponumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PoitemMetadata.PropertyNames.Ponumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PoitemMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Productdesc, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoitemMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Qtyordered, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Qtyordered
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Qtyreleased, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Qtyreleased
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Qtyreceived, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Qtyreceived
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Qtycanceled, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Qtycanceled
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Vendoritemnumber, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoitemMetadata.PropertyNames.Vendoritemnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Unitcost, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Extcost, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Extcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Uom, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoitemMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Container, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoitemMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Unitorcontainer, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoitemMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Units, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PoitemMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Expecteddelivery, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PoitemMetadata.PropertyNames.Expecteddelivery
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Weightuom, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoitemMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Weightunits, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Weightunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Weightstandardcost, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Weightstandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Volumeuom, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoitemMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Volumeunits, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Volumeunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoitemMetadata.ColumnNames.Volumestandardcost, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoitemMetadata.PropertyNames.Volumestandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As PoitemMetadata
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
			 Public Const Poitemnumber As String = "POITEMNUMBER"
			 Public Const Ponumber As String = "PONUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Qtyordered As String = "QTYORDERED"
			 Public Const Qtyreleased As String = "QTYRELEASED"
			 Public Const Qtyreceived As String = "QTYRECEIVED"
			 Public Const Qtycanceled As String = "QTYCANCELED"
			 Public Const Vendoritemnumber As String = "VENDORITEMNUMBER"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Extcost As String = "EXTCOST"
			 Public Const Uom As String = "UOM"
			 Public Const Container As String = "CONTAINER"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Expecteddelivery As String = "EXPECTEDDELIVERY"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Weightunits As String = "WEIGHTUNITS"
			 Public Const Weightstandardcost As String = "WEIGHTSTANDARDCOST"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Volumeunits As String = "VOLUMEUNITS"
			 Public Const Volumestandardcost As String = "VOLUMESTANDARDCOST"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Poitemnumber As String = "Poitemnumber"
			 Public Const Ponumber As String = "Ponumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Qtyordered As String = "Qtyordered"
			 Public Const Qtyreleased As String = "Qtyreleased"
			 Public Const Qtyreceived As String = "Qtyreceived"
			 Public Const Qtycanceled As String = "Qtycanceled"
			 Public Const Vendoritemnumber As String = "Vendoritemnumber"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Extcost As String = "Extcost"
			 Public Const Uom As String = "Uom"
			 Public Const Container As String = "Container"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Units As String = "Units"
			 Public Const Expecteddelivery As String = "Expecteddelivery"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Weightunits As String = "Weightunits"
			 Public Const Weightstandardcost As String = "Weightstandardcost"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Volumeunits As String = "Volumeunits"
			 Public Const Volumestandardcost As String = "Volumestandardcost"
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
            SyncLock GetType(PoitemMetadata)
			
				If PoitemMetadata.mapDelegates Is Nothing Then
					PoitemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If PoitemMetadata._meta Is Nothing Then
                    PoitemMetadata._meta = New PoitemMetadata()
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
				

				meta.AddTypeMap("Poitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Ponumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtyordered", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtyreleased", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtyreceived", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtycanceled", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Vendoritemnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Extcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Expecteddelivery", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightstandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumeunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumestandardcost", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "POITEM"
				meta.Destination = "POITEM"
				
				meta.spInsert = "proc_POITEMInsert"
				meta.spUpdate = "proc_POITEMUpdate"
				meta.spDelete = "proc_POITEMDelete"
				meta.spLoadAll = "proc_POITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_POITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As PoitemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
