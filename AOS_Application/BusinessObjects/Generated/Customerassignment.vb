'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:55 PM
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
	MustInherit Public Class esCustomerassignmentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "CustomerassignmentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esCustomerassignmentQuery)
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
            Me.InitQuery(CType(query, esCustomerassignmentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Customerassignment) As Customerassignment
			Return CType(MyBase.DetachEntity(entity), Customerassignment)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Customerassignment) As Customerassignment
			Return CType(MyBase.AttachEntity(entity), Customerassignment)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As CustomerassignmentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Customerassignment
            Get
                Return TryCast(MyBase.Item(index), Customerassignment)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Customerassignment)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esCustomerassignment	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esCustomerassignmentQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal custAssignID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(custAssignID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(custAssignID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal custAssignID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(custAssignID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(custAssignID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal custAssignID As System.Int32) As Boolean
		
			Dim query As esCustomerassignmentQuery = Me.GetDynamicQuery()
			query.Where(query.CustAssignID.Equal(custAssignID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal custAssignID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("CustAssignID", custAssignID)
			
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
												
						Case "CustAssignID"
							Me.str.CustAssignID = CType(value, string)
												
						Case "SalespersonID"
							Me.str.SalespersonID = CType(value, string)
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
												
						Case "CommissionRate"
							Me.str.CommissionRate = CType(value, string)
												
						Case "CommissionType"
							Me.str.CommissionType = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "CustAssignID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustAssignID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SalespersonID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalespersonID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CommissionRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CommissionRate = CType(value, Nullable(Of System.Double))
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
		' Maps to CUSTOMERASSIGNMENT.CustAssignID
		' </summary>
		Public Overridable Property CustAssignID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerassignmentMetadata.ColumnNames.CustAssignID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerassignmentMetadata.ColumnNames.CustAssignID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMERASSIGNMENT.SalespersonID
		' </summary>
		Public Overridable Property SalespersonID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerassignmentMetadata.ColumnNames.SalespersonID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerassignmentMetadata.ColumnNames.SalespersonID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMERASSIGNMENT.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerassignmentMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerassignmentMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMERASSIGNMENT.CommissionRate
		' </summary>
		Public Overridable Property CommissionRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CustomerassignmentMetadata.ColumnNames.CommissionRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(CustomerassignmentMetadata.ColumnNames.CommissionRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMERASSIGNMENT.CommissionType
		' </summary>
		Public Overridable Property CommissionType As System.String
			Get
				Return MyBase.GetSystemString(CustomerassignmentMetadata.ColumnNames.CommissionType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerassignmentMetadata.ColumnNames.CommissionType, value)
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
		
			Public Sub New(ByVal entity As esCustomerassignment)
				Me.entity = entity
			End Sub				
		
	
			Public Property CustAssignID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CustAssignID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustAssignID = Nothing
					Else
						entity.CustAssignID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SalespersonID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalespersonID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalespersonID = Nothing
					Else
						entity.SalespersonID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CustID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustID = Nothing
					Else
						entity.CustID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CommissionRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionRate = Nothing
					Else
						entity.CommissionRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionType As System.String 
				Get
					Dim data_ As System.String = entity.CommissionType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionType = Nothing
					Else
						entity.CommissionType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCustomerassignment
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esCustomerassignmentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esCustomerassignment can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Customerassignment 
		Inherits esCustomerassignment
		
	
		
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
	MustInherit Public Class esCustomerassignmentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CustomerassignmentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property CustAssignID As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerassignmentMetadata.ColumnNames.CustAssignID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SalespersonID As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerassignmentMetadata.ColumnNames.SalespersonID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerassignmentMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionRate As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerassignmentMetadata.ColumnNames.CommissionRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionType As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerassignmentMetadata.ColumnNames.CommissionType, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("CustomerassignmentCollection")> _
	Partial Public Class CustomerassignmentCollection
		Inherits esCustomerassignmentCollection
		Implements IEnumerable(Of Customerassignment)
		
        Public Shared Widening Operator CType(ByVal coll As CustomerassignmentCollection) As List(Of Customerassignment)
            Dim list As List(Of Customerassignment) = New List(Of Customerassignment)
            Dim emp As Customerassignment

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CustomerassignmentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New CustomerassignmentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Customerassignment(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Customerassignment()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As CustomerassignmentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New CustomerassignmentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CustomerassignmentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Customerassignment 
			Return CType(MyBase.AddNewEntity(), Customerassignment)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal custAssignID As System.Int32) As Customerassignment
			Return CType(MyBase.FindByPrimaryKey(custAssignID), Customerassignment)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Customerassignment) Implements IEnumerable(Of Customerassignment).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Customerassignment)(Me)
        End Function
		
		Private _query As CustomerassignmentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'CUSTOMERASSIGNMENT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Customerassignment ({CustAssignID.Value})")> _
	<Serializable> _
	Partial Public Class Customerassignment 
		Inherits esCustomerassignment

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return CustomerassignmentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esCustomerassignmentQuery

			If Me._query Is Nothing Then
				Me._query = New CustomerassignmentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As CustomerassignmentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New CustomerassignmentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CustomerassignmentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As CustomerassignmentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class CustomerassignmentQuery
		inherits esCustomerassignmentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "CustomerassignmentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class CustomerassignmentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CustomerassignmentMetadata.ColumnNames.CustAssignID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerassignmentMetadata.PropertyNames.CustAssignID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerassignmentMetadata.ColumnNames.SalespersonID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerassignmentMetadata.PropertyNames.SalespersonID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerassignmentMetadata.ColumnNames.CustID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerassignmentMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerassignmentMetadata.ColumnNames.CommissionRate, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CustomerassignmentMetadata.PropertyNames.CommissionRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerassignmentMetadata.ColumnNames.CommissionType, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerassignmentMetadata.PropertyNames.CommissionType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As CustomerassignmentMetadata
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
			 Public Const CustAssignID As String = "CustAssignID"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const CustID As String = "CustID"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const CommissionType As String = "CommissionType"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const CustAssignID As String = "CustAssignID"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const CustID As String = "CustID"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const CommissionType As String = "CommissionType"
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
            SyncLock GetType(CustomerassignmentMetadata)
			
				If CustomerassignmentMetadata.mapDelegates Is Nothing Then
					CustomerassignmentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If CustomerassignmentMetadata._meta Is Nothing Then
                    CustomerassignmentMetadata._meta = New CustomerassignmentMetadata()
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
				

				meta.AddTypeMap("CustAssignID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SalespersonID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CommissionRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CommissionType", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "CUSTOMERASSIGNMENT"
				meta.Destination = "CUSTOMERASSIGNMENT"
				
				meta.spInsert = "proc_CUSTOMERASSIGNMENTInsert"
				meta.spUpdate = "proc_CUSTOMERASSIGNMENTUpdate"
				meta.spDelete = "proc_CUSTOMERASSIGNMENTDelete"
				meta.spLoadAll = "proc_CUSTOMERASSIGNMENTLoadAll"
				meta.spLoadByPrimaryKey = "proc_CUSTOMERASSIGNMENTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As CustomerassignmentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
