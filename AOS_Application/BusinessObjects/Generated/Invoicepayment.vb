'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:56 PM
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
	MustInherit Public Class esInvoicepaymentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "InvoicepaymentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esInvoicepaymentQuery)
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
            Me.InitQuery(CType(query, esInvoicepaymentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Invoicepayment) As Invoicepayment
			Return CType(MyBase.DetachEntity(entity), Invoicepayment)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Invoicepayment) As Invoicepayment
			Return CType(MyBase.AttachEntity(entity), Invoicepayment)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As InvoicepaymentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Invoicepayment
            Get
                Return TryCast(MyBase.Item(index), Invoicepayment)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Invoicepayment)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esInvoicepayment	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esInvoicepaymentQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal invoicepmtid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoicepmtid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoicepmtid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal invoicepmtid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoicepmtid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoicepmtid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal invoicepmtid As System.Int32) As Boolean
		
			Dim query As esInvoicepaymentQuery = Me.GetDynamicQuery()
			query.Where(query.Invoicepmtid.Equal(invoicepmtid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal invoicepmtid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("INVOICEPMTID", invoicepmtid)
			
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
												
						Case "Invoicepmtid"
							Me.str.Invoicepmtid = CType(value, string)
												
						Case "Customerpmtid"
							Me.str.Customerpmtid = CType(value, string)
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Invoicepmtamount"
							Me.str.Invoicepmtamount = CType(value, string)
												
						Case "Invoicediscount"
							Me.str.Invoicediscount = CType(value, string)
												
						Case "Discountreason"
							Me.str.Discountreason = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invoicepmtid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicepmtid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Customerpmtid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Customerpmtid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicepmtamount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Invoicepmtamount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Invoicediscount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Invoicediscount = CType(value, Nullable(Of System.Decimal))
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
		' Maps to INVOICEPAYMENT.INVOICEPMTID
		' </summary>
		Public Overridable Property Invoicepmtid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicepaymentMetadata.ColumnNames.Invoicepmtid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicepaymentMetadata.ColumnNames.Invoicepmtid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEPAYMENT.CUSTOMERPMTID
		' </summary>
		Public Overridable Property Customerpmtid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicepaymentMetadata.ColumnNames.Customerpmtid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicepaymentMetadata.ColumnNames.Customerpmtid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEPAYMENT.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicepaymentMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicepaymentMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEPAYMENT.INVOICEPMTAMOUNT
		' </summary>
		Public Overridable Property Invoicepmtamount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicepaymentMetadata.ColumnNames.Invoicepmtamount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicepaymentMetadata.ColumnNames.Invoicepmtamount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEPAYMENT.INVOICEDISCOUNT
		' </summary>
		Public Overridable Property Invoicediscount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicepaymentMetadata.ColumnNames.Invoicediscount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicepaymentMetadata.ColumnNames.Invoicediscount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEPAYMENT.DISCOUNTREASON
		' </summary>
		Public Overridable Property Discountreason As System.String
			Get
				Return MyBase.GetSystemString(InvoicepaymentMetadata.ColumnNames.Discountreason)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicepaymentMetadata.ColumnNames.Discountreason, value)
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
		
			Public Sub New(ByVal entity As esInvoicepayment)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invoicepmtid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicepmtid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicepmtid = Nothing
					Else
						entity.Invoicepmtid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Customerpmtid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Customerpmtid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerpmtid = Nothing
					Else
						entity.Customerpmtid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoicenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicenumber = Nothing
					Else
						entity.Invoicenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoicepmtamount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Invoicepmtamount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicepmtamount = Nothing
					Else
						entity.Invoicepmtamount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoicediscount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Invoicediscount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicediscount = Nothing
					Else
						entity.Invoicediscount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Discountreason As System.String 
				Get
					Dim data_ As System.String = entity.Discountreason
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Discountreason = Nothing
					Else
						entity.Discountreason = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esInvoicepayment
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esInvoicepaymentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esInvoicepayment can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Invoicepayment 
		Inherits esInvoicepayment
		
	
		
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
	MustInherit Public Class esInvoicepaymentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvoicepaymentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicepmtid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicepaymentMetadata.ColumnNames.Invoicepmtid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpmtid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicepaymentMetadata.ColumnNames.Customerpmtid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicepaymentMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicepmtamount As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicepaymentMetadata.ColumnNames.Invoicepmtamount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicediscount As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicepaymentMetadata.ColumnNames.Invoicediscount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Discountreason As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicepaymentMetadata.ColumnNames.Discountreason, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("InvoicepaymentCollection")> _
	Partial Public Class InvoicepaymentCollection
		Inherits esInvoicepaymentCollection
		Implements IEnumerable(Of Invoicepayment)
		
        Public Shared Widening Operator CType(ByVal coll As InvoicepaymentCollection) As List(Of Invoicepayment)
            Dim list As List(Of Invoicepayment) = New List(Of Invoicepayment)
            Dim emp As Invoicepayment

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvoicepaymentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New InvoicepaymentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Invoicepayment(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Invoicepayment()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As InvoicepaymentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New InvoicepaymentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvoicepaymentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Invoicepayment 
			Return CType(MyBase.AddNewEntity(), Invoicepayment)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal invoicepmtid As System.Int32) As Invoicepayment
			Return CType(MyBase.FindByPrimaryKey(invoicepmtid), Invoicepayment)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Invoicepayment) Implements IEnumerable(Of Invoicepayment).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Invoicepayment)(Me)
        End Function
		
		Private _query As InvoicepaymentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'INVOICEPAYMENT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Invoicepayment ({Invoicepmtid.Value})")> _
	<Serializable> _
	Partial Public Class Invoicepayment 
		Inherits esInvoicepayment

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return InvoicepaymentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esInvoicepaymentQuery

			If Me._query Is Nothing Then
				Me._query = New InvoicepaymentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As InvoicepaymentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New InvoicepaymentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvoicepaymentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As InvoicepaymentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class InvoicepaymentQuery
		inherits esInvoicepaymentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "InvoicepaymentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class InvoicepaymentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(InvoicepaymentMetadata.ColumnNames.Invoicepmtid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicepaymentMetadata.PropertyNames.Invoicepmtid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicepaymentMetadata.ColumnNames.Customerpmtid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicepaymentMetadata.PropertyNames.Customerpmtid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicepaymentMetadata.ColumnNames.Invoicenumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicepaymentMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicepaymentMetadata.ColumnNames.Invoicepmtamount, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicepaymentMetadata.PropertyNames.Invoicepmtamount
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicepaymentMetadata.ColumnNames.Invoicediscount, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicepaymentMetadata.PropertyNames.Invoicediscount
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicepaymentMetadata.ColumnNames.Discountreason, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicepaymentMetadata.PropertyNames.Discountreason
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As InvoicepaymentMetadata
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
			 Public Const Invoicepmtid As String = "INVOICEPMTID"
			 Public Const Customerpmtid As String = "CUSTOMERPMTID"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Invoicepmtamount As String = "INVOICEPMTAMOUNT"
			 Public Const Invoicediscount As String = "INVOICEDISCOUNT"
			 Public Const Discountreason As String = "DISCOUNTREASON"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invoicepmtid As String = "Invoicepmtid"
			 Public Const Customerpmtid As String = "Customerpmtid"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Invoicepmtamount As String = "Invoicepmtamount"
			 Public Const Invoicediscount As String = "Invoicediscount"
			 Public Const Discountreason As String = "Discountreason"
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
            SyncLock GetType(InvoicepaymentMetadata)
			
				If InvoicepaymentMetadata.mapDelegates Is Nothing Then
					InvoicepaymentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If InvoicepaymentMetadata._meta Is Nothing Then
                    InvoicepaymentMetadata._meta = New InvoicepaymentMetadata()
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
				

				meta.AddTypeMap("Invoicepmtid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Customerpmtid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicepmtamount", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Invoicediscount", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Discountreason", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "INVOICEPAYMENT"
				meta.Destination = "INVOICEPAYMENT"
				
				meta.spInsert = "proc_INVOICEPAYMENTInsert"
				meta.spUpdate = "proc_INVOICEPAYMENTUpdate"
				meta.spDelete = "proc_INVOICEPAYMENTDelete"
				meta.spLoadAll = "proc_INVOICEPAYMENTLoadAll"
				meta.spLoadByPrimaryKey = "proc_INVOICEPAYMENTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As InvoicepaymentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
