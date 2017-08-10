'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/25/2016 10:29:20 AM
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
	MustInherit Public Class esProductfulfillmentplanCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ProductfulfillmentplanCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esProductfulfillmentplanQuery)
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
            Me.InitQuery(CType(query, esProductfulfillmentplanQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Productfulfillmentplan) As Productfulfillmentplan
			Return CType(MyBase.DetachEntity(entity), Productfulfillmentplan)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Productfulfillmentplan) As Productfulfillmentplan
			Return CType(MyBase.AttachEntity(entity), Productfulfillmentplan)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ProductfulfillmentplanCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Productfulfillmentplan
            Get
                Return TryCast(MyBase.Item(index), Productfulfillmentplan)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Productfulfillmentplan)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esProductfulfillmentplan	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esProductfulfillmentplanQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fulfillmentplanid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fulfillmentplanid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fulfillmentplanid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fulfillmentplanid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fulfillmentplanid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fulfillmentplanid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fulfillmentplanid As System.Int32) As Boolean
		
			Dim query As esProductfulfillmentplanQuery = Me.GetDynamicQuery()
			query.Where(query.Fulfillmentplanid.Equal(fulfillmentplanid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fulfillmentplanid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FULFILLMENTPLANID", fulfillmentplanid)
			
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
												
						Case "Fulfillmentplanid"
							Me.str.Fulfillmentplanid = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Fulfillmenttypeid"
							Me.str.Fulfillmenttypeid = CType(value, string)
												
						Case "Priority"
							Me.str.Priority = CType(value, string)
												
						Case "Associatedproductid"
							Me.str.Associatedproductid = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
												
						Case "Stdlaborhrs"
							Me.str.Stdlaborhrs = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Fulfillmentplanid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fulfillmentplanid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Fulfillmenttypeid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fulfillmenttypeid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Priority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Priority = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Associatedproductid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Associatedproductid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Kitid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Kitid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdlaborhrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdlaborhrs = CType(value, Nullable(Of System.Decimal))
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
		' Maps to PRODUCTFULFILLMENTPLAN.FULFILLMENTPLANID
		' </summary>
		Public Overridable Property Fulfillmentplanid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Fulfillmentplanid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Fulfillmentplanid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.FULFILLMENTTYPEID
		' </summary>
		Public Overridable Property Fulfillmenttypeid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Fulfillmenttypeid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Fulfillmenttypeid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.PRIORITY
		' </summary>
		Public Overridable Property Priority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Priority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Priority, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.ASSOCIATEDPRODUCTID
		' </summary>
		Public Overridable Property Associatedproductid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Associatedproductid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Associatedproductid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ProductfulfillmentplanMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductfulfillmentplanMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductfulfillmentplanMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductfulfillmentplanMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ProductfulfillmentplanMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductfulfillmentplanMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductfulfillmentplanMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductfulfillmentplanMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductfulfillmentplanMetadata.ColumnNames.Kitid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTFULFILLMENTPLAN.STDLABORHRS
		' </summary>
		Public Overridable Property Stdlaborhrs As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductfulfillmentplanMetadata.ColumnNames.Stdlaborhrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductfulfillmentplanMetadata.ColumnNames.Stdlaborhrs, value)
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
		
			Public Sub New(ByVal entity As esProductfulfillmentplan)
				Me.entity = entity
			End Sub				
		
	
			Public Property Fulfillmentplanid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fulfillmentplanid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulfillmentplanid = Nothing
					Else
						entity.Fulfillmentplanid = Convert.ToInt32(Value)
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
		  	
			Public Property Fulfillmenttypeid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fulfillmenttypeid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulfillmenttypeid = Nothing
					Else
						entity.Fulfillmenttypeid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priority As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Priority
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priority = Nothing
					Else
						entity.Priority = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Associatedproductid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Associatedproductid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Associatedproductid = Nothing
					Else
						entity.Associatedproductid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifyby As System.String 
				Get
					Dim data_ As System.String = entity.Modifyby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifyby = Nothing
					Else
						entity.Modifyby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifytime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifytime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifytime = Nothing
					Else
						entity.Modifytime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Kitid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Kitid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitid = Nothing
					Else
						entity.Kitid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdlaborhrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdlaborhrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdlaborhrs = Nothing
					Else
						entity.Stdlaborhrs = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esProductfulfillmentplan
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esProductfulfillmentplanQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esProductfulfillmentplan can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Productfulfillmentplan 
		Inherits esProductfulfillmentplan
		
	
		
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
	MustInherit Public Class esProductfulfillmentplanQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProductfulfillmentplanMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Fulfillmentplanid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Fulfillmentplanid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fulfillmenttypeid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Fulfillmenttypeid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Priority As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Priority, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Associatedproductid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Associatedproductid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Kitid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdlaborhrs As esQueryItem
			Get
				Return New esQueryItem(Me, ProductfulfillmentplanMetadata.ColumnNames.Stdlaborhrs, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ProductfulfillmentplanCollection")> _
	Partial Public Class ProductfulfillmentplanCollection
		Inherits esProductfulfillmentplanCollection
		Implements IEnumerable(Of Productfulfillmentplan)
		
        Public Shared Widening Operator CType(ByVal coll As ProductfulfillmentplanCollection) As List(Of Productfulfillmentplan)
            Dim list As List(Of Productfulfillmentplan) = New List(Of Productfulfillmentplan)
            Dim emp As Productfulfillmentplan

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProductfulfillmentplanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ProductfulfillmentplanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Productfulfillmentplan(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Productfulfillmentplan()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ProductfulfillmentplanQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ProductfulfillmentplanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProductfulfillmentplanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Productfulfillmentplan 
			Return CType(MyBase.AddNewEntity(), Productfulfillmentplan)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal fulfillmentplanid As System.Int32) As Productfulfillmentplan
			Return CType(MyBase.FindByPrimaryKey(fulfillmentplanid), Productfulfillmentplan)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Productfulfillmentplan) Implements IEnumerable(Of Productfulfillmentplan).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Productfulfillmentplan)(Me)
        End Function
		
		Private _query As ProductfulfillmentplanQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PRODUCTFULFILLMENTPLAN' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Productfulfillmentplan ({Fulfillmentplanid.Value})")> _
	<Serializable> _
	Partial Public Class Productfulfillmentplan 
		Inherits esProductfulfillmentplan

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ProductfulfillmentplanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esProductfulfillmentplanQuery

			If Me._query Is Nothing Then
				Me._query = New ProductfulfillmentplanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ProductfulfillmentplanQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ProductfulfillmentplanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProductfulfillmentplanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ProductfulfillmentplanQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ProductfulfillmentplanQuery
		inherits esProductfulfillmentplanQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ProductfulfillmentplanQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ProductfulfillmentplanMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Fulfillmentplanid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Fulfillmentplanid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Fulfillmenttypeid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Fulfillmenttypeid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Priority, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Priority
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Associatedproductid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Associatedproductid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Createdby, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Createdtime, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Createdtime
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Modifyby, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Modifytime, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Kitid, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Kitid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductfulfillmentplanMetadata.ColumnNames.Stdlaborhrs, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductfulfillmentplanMetadata.PropertyNames.Stdlaborhrs
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ProductfulfillmentplanMetadata
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
			 Public Const Fulfillmentplanid As String = "FULFILLMENTPLANID"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Fulfillmenttypeid As String = "FULFILLMENTTYPEID"
			 Public Const Priority As String = "PRIORITY"
			 Public Const Associatedproductid As String = "ASSOCIATEDPRODUCTID"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Kitid As String = "KITID"
			 Public Const Stdlaborhrs As String = "STDLABORHRS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Fulfillmentplanid As String = "Fulfillmentplanid"
			 Public Const Productid As String = "Productid"
			 Public Const Fulfillmenttypeid As String = "Fulfillmenttypeid"
			 Public Const Priority As String = "Priority"
			 Public Const Associatedproductid As String = "Associatedproductid"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Kitid As String = "Kitid"
			 Public Const Stdlaborhrs As String = "Stdlaborhrs"
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
            SyncLock GetType(ProductfulfillmentplanMetadata)
			
				If ProductfulfillmentplanMetadata.mapDelegates Is Nothing Then
					ProductfulfillmentplanMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ProductfulfillmentplanMetadata._meta Is Nothing Then
                    ProductfulfillmentplanMetadata._meta = New ProductfulfillmentplanMetadata()
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
				

				meta.AddTypeMap("Fulfillmentplanid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fulfillmenttypeid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Priority", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Associatedproductid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Kitid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdlaborhrs", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "PRODUCTFULFILLMENTPLAN"
				meta.Destination = "PRODUCTFULFILLMENTPLAN"
				
				meta.spInsert = "proc_PRODUCTFULFILLMENTPLANInsert"
				meta.spUpdate = "proc_PRODUCTFULFILLMENTPLANUpdate"
				meta.spDelete = "proc_PRODUCTFULFILLMENTPLANDelete"
				meta.spLoadAll = "proc_PRODUCTFULFILLMENTPLANLoadAll"
				meta.spLoadByPrimaryKey = "proc_PRODUCTFULFILLMENTPLANLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ProductfulfillmentplanMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
