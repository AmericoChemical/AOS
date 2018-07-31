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
	MustInherit Public Class esCommissionexceptionCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "CommissionexceptionCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esCommissionexceptionQuery)
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
            Me.InitQuery(CType(query, esCommissionexceptionQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Commissionexception) As Commissionexception
			Return CType(MyBase.DetachEntity(entity), Commissionexception)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Commissionexception) As Commissionexception
			Return CType(MyBase.AttachEntity(entity), Commissionexception)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As CommissionexceptionCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Commissionexception
            Get
                Return TryCast(MyBase.Item(index), Commissionexception)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Commissionexception)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esCommissionexception	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esCommissionexceptionQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal exceptionID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(exceptionID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(exceptionID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal exceptionID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(exceptionID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(exceptionID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal exceptionID As System.Int32) As Boolean
		
			Dim query As esCommissionexceptionQuery = Me.GetDynamicQuery()
			query.Where(query.ExceptionID.Equal(exceptionID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal exceptionID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("ExceptionID", exceptionID)
			
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
												
						Case "ExceptionID"
							Me.str.ExceptionID = CType(value, string)
												
						Case "CustAssignID"
							Me.str.CustAssignID = CType(value, string)
												
						Case "ProductID"
							Me.str.ProductID = CType(value, string)
												
						Case "CommissionRate"
							Me.str.CommissionRate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "ExceptionID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExceptionID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CustAssignID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustAssignID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ProductID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProductID = CType(value, Nullable(Of System.Int32))
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
		' Maps to COMMISSIONEXCEPTION.ExceptionID
		' </summary>
		Public Overridable Property ExceptionID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionexceptionMetadata.ColumnNames.ExceptionID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionexceptionMetadata.ColumnNames.ExceptionID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONEXCEPTION.CustAssignID
		' </summary>
		Public Overridable Property CustAssignID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionexceptionMetadata.ColumnNames.CustAssignID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionexceptionMetadata.ColumnNames.CustAssignID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONEXCEPTION.ProductID
		' </summary>
		Public Overridable Property ProductID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionexceptionMetadata.ColumnNames.ProductID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionexceptionMetadata.ColumnNames.ProductID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONEXCEPTION.CommissionRate
		' </summary>
		Public Overridable Property CommissionRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CommissionexceptionMetadata.ColumnNames.CommissionRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(CommissionexceptionMetadata.ColumnNames.CommissionRate, value)
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
		
			Public Sub New(ByVal entity As esCommissionexception)
				Me.entity = entity
			End Sub				
		
	
			Public Property ExceptionID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ExceptionID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExceptionID = Nothing
					Else
						entity.ExceptionID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  

			Private entity As esCommissionexception
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esCommissionexceptionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esCommissionexception can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Commissionexception 
		Inherits esCommissionexception
		
	
		
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
	MustInherit Public Class esCommissionexceptionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommissionexceptionMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property ExceptionID As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionexceptionMetadata.ColumnNames.ExceptionID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CustAssignID As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionexceptionMetadata.ColumnNames.CustAssignID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProductID As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionexceptionMetadata.ColumnNames.ProductID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionRate As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionexceptionMetadata.ColumnNames.CommissionRate, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("CommissionexceptionCollection")> _
	Partial Public Class CommissionexceptionCollection
		Inherits esCommissionexceptionCollection
		Implements IEnumerable(Of Commissionexception)
		
        Public Shared Widening Operator CType(ByVal coll As CommissionexceptionCollection) As List(Of Commissionexception)
            Dim list As List(Of Commissionexception) = New List(Of Commissionexception)
            Dim emp As Commissionexception

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommissionexceptionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New CommissionexceptionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Commissionexception(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Commissionexception()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As CommissionexceptionQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New CommissionexceptionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CommissionexceptionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Commissionexception 
			Return CType(MyBase.AddNewEntity(), Commissionexception)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal exceptionID As System.Int32) As Commissionexception
			Return CType(MyBase.FindByPrimaryKey(exceptionID), Commissionexception)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Commissionexception) Implements IEnumerable(Of Commissionexception).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Commissionexception)(Me)
        End Function
		
		Private _query As CommissionexceptionQuery

	End Class
	


	' <summary>
	' Encapsulates the 'COMMISSIONEXCEPTION' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Commissionexception ({ExceptionID.Value})")> _
	<Serializable> _
	Partial Public Class Commissionexception 
		Inherits esCommissionexception

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return CommissionexceptionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esCommissionexceptionQuery

			If Me._query Is Nothing Then
				Me._query = New CommissionexceptionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As CommissionexceptionQuery
			Get

				If Me._query Is Nothing then
					Me._query = New CommissionexceptionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CommissionexceptionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As CommissionexceptionQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class CommissionexceptionQuery
		inherits esCommissionexceptionQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "CommissionexceptionQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class CommissionexceptionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CommissionexceptionMetadata.ColumnNames.ExceptionID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionexceptionMetadata.PropertyNames.ExceptionID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionexceptionMetadata.ColumnNames.CustAssignID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionexceptionMetadata.PropertyNames.CustAssignID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionexceptionMetadata.ColumnNames.ProductID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionexceptionMetadata.PropertyNames.ProductID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionexceptionMetadata.ColumnNames.CommissionRate, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CommissionexceptionMetadata.PropertyNames.CommissionRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As CommissionexceptionMetadata
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
			 Public Const ExceptionID As String = "ExceptionID"
			 Public Const CustAssignID As String = "CustAssignID"
			 Public Const ProductID As String = "ProductID"
			 Public Const CommissionRate As String = "CommissionRate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const ExceptionID As String = "ExceptionID"
			 Public Const CustAssignID As String = "CustAssignID"
			 Public Const ProductID As String = "ProductID"
			 Public Const CommissionRate As String = "CommissionRate"
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
            SyncLock GetType(CommissionexceptionMetadata)
			
				If CommissionexceptionMetadata.mapDelegates Is Nothing Then
					CommissionexceptionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If CommissionexceptionMetadata._meta Is Nothing Then
                    CommissionexceptionMetadata._meta = New CommissionexceptionMetadata()
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
				

				meta.AddTypeMap("ExceptionID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CustAssignID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProductID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CommissionRate", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "COMMISSIONEXCEPTION"
				meta.Destination = "COMMISSIONEXCEPTION"
				
				meta.spInsert = "proc_COMMISSIONEXCEPTIONInsert"
				meta.spUpdate = "proc_COMMISSIONEXCEPTIONUpdate"
				meta.spDelete = "proc_COMMISSIONEXCEPTIONDelete"
				meta.spLoadAll = "proc_COMMISSIONEXCEPTIONLoadAll"
				meta.spLoadByPrimaryKey = "proc_COMMISSIONEXCEPTIONLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As CommissionexceptionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
