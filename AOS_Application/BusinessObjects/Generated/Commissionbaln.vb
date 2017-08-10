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
	MustInherit Public Class esCommissionbalnCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "CommissionbalnCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esCommissionbalnQuery)
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
            Me.InitQuery(CType(query, esCommissionbalnQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Commissionbaln) As Commissionbaln
			Return CType(MyBase.DetachEntity(entity), Commissionbaln)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Commissionbaln) As Commissionbaln
			Return CType(MyBase.AttachEntity(entity), Commissionbaln)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As CommissionbalnCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Commissionbaln
            Get
                Return TryCast(MyBase.Item(index), Commissionbaln)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Commissionbaln)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esCommissionbaln	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esCommissionbalnQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal commissionbalnid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(commissionbalnid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(commissionbalnid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal commissionbalnid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(commissionbalnid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(commissionbalnid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal commissionbalnid As System.Int32) As Boolean
		
			Dim query As esCommissionbalnQuery = Me.GetDynamicQuery()
			query.Where(query.Commissionbalnid.Equal(commissionbalnid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal commissionbalnid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("COMMISSIONBALNID", commissionbalnid)
			
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
												
						Case "Commissionbalnid"
							Me.str.Commissionbalnid = CType(value, string)
												
						Case "Salespersonid"
							Me.str.Salespersonid = CType(value, string)
												
						Case "Commissiontype"
							Me.str.Commissiontype = CType(value, string)
												
						Case "Commissionbalndue"
							Me.str.Commissionbalndue = CType(value, string)
												
						Case "Commissionbalndate"
							Me.str.Commissionbalndate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Commissionbalnid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Commissionbalnid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Salespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Salespersonid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Commissionbalndue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Commissionbalndue = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Commissionbalndate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Commissionbalndate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to COMMISSIONBALN.COMMISSIONBALNID
		' </summary>
		Public Overridable Property Commissionbalnid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionbalnMetadata.ColumnNames.Commissionbalnid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionbalnMetadata.ColumnNames.Commissionbalnid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONBALN.SALESPERSONID
		' </summary>
		Public Overridable Property Salespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionbalnMetadata.ColumnNames.Salespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionbalnMetadata.ColumnNames.Salespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONBALN.COMMISSIONTYPE
		' </summary>
		Public Overridable Property Commissiontype As System.String
			Get
				Return MyBase.GetSystemString(CommissionbalnMetadata.ColumnNames.Commissiontype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CommissionbalnMetadata.ColumnNames.Commissiontype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONBALN.COMMISSIONBALNDUE
		' </summary>
		Public Overridable Property Commissionbalndue As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(CommissionbalnMetadata.ColumnNames.Commissionbalndue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(CommissionbalnMetadata.ColumnNames.Commissionbalndue, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONBALN.COMMISSIONBALNDATE
		' </summary>
		Public Overridable Property Commissionbalndate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CommissionbalnMetadata.ColumnNames.Commissionbalndate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CommissionbalnMetadata.ColumnNames.Commissionbalndate, value)
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
		
			Public Sub New(ByVal entity As esCommissionbaln)
				Me.entity = entity
			End Sub				
		
	
			Public Property Commissionbalnid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Commissionbalnid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionbalnid = Nothing
					Else
						entity.Commissionbalnid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Salespersonid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonid = Nothing
					Else
						entity.Salespersonid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissiontype As System.String 
				Get
					Dim data_ As System.String = entity.Commissiontype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissiontype = Nothing
					Else
						entity.Commissiontype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionbalndue As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Commissionbalndue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionbalndue = Nothing
					Else
						entity.Commissionbalndue = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionbalndate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Commissionbalndate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionbalndate = Nothing
					Else
						entity.Commissionbalndate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCommissionbaln
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esCommissionbalnQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esCommissionbaln can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Commissionbaln 
		Inherits esCommissionbaln
		
	
		
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
	MustInherit Public Class esCommissionbalnQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommissionbalnMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Commissionbalnid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionbalnMetadata.ColumnNames.Commissionbalnid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionbalnMetadata.ColumnNames.Salespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissiontype As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionbalnMetadata.ColumnNames.Commissiontype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionbalndue As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionbalnMetadata.ColumnNames.Commissionbalndue, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionbalndate As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionbalnMetadata.ColumnNames.Commissionbalndate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("CommissionbalnCollection")> _
	Partial Public Class CommissionbalnCollection
		Inherits esCommissionbalnCollection
		Implements IEnumerable(Of Commissionbaln)
		
        Public Shared Widening Operator CType(ByVal coll As CommissionbalnCollection) As List(Of Commissionbaln)
            Dim list As List(Of Commissionbaln) = New List(Of Commissionbaln)
            Dim emp As Commissionbaln

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommissionbalnMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New CommissionbalnQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Commissionbaln(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Commissionbaln()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As CommissionbalnQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New CommissionbalnQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CommissionbalnQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Commissionbaln 
			Return CType(MyBase.AddNewEntity(), Commissionbaln)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal commissionbalnid As System.Int32) As Commissionbaln
			Return CType(MyBase.FindByPrimaryKey(commissionbalnid), Commissionbaln)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Commissionbaln) Implements IEnumerable(Of Commissionbaln).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Commissionbaln)(Me)
        End Function
		
		Private _query As CommissionbalnQuery

	End Class
	


	' <summary>
	' Encapsulates the 'COMMISSIONBALN' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Commissionbaln ({Commissionbalnid.Value})")> _
	<Serializable> _
	Partial Public Class Commissionbaln 
		Inherits esCommissionbaln

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return CommissionbalnMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esCommissionbalnQuery

			If Me._query Is Nothing Then
				Me._query = New CommissionbalnQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As CommissionbalnQuery
			Get

				If Me._query Is Nothing then
					Me._query = New CommissionbalnQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CommissionbalnQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As CommissionbalnQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class CommissionbalnQuery
		inherits esCommissionbalnQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "CommissionbalnQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class CommissionbalnMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CommissionbalnMetadata.ColumnNames.Commissionbalnid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionbalnMetadata.PropertyNames.Commissionbalnid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionbalnMetadata.ColumnNames.Salespersonid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionbalnMetadata.PropertyNames.Salespersonid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionbalnMetadata.ColumnNames.Commissiontype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommissionbalnMetadata.PropertyNames.Commissiontype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionbalnMetadata.ColumnNames.Commissionbalndue, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = CommissionbalnMetadata.PropertyNames.Commissionbalndue
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionbalnMetadata.ColumnNames.Commissionbalndate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CommissionbalnMetadata.PropertyNames.Commissionbalndate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As CommissionbalnMetadata
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
			 Public Const Commissionbalnid As String = "COMMISSIONBALNID"
			 Public Const Salespersonid As String = "SALESPERSONID"
			 Public Const Commissiontype As String = "COMMISSIONTYPE"
			 Public Const Commissionbalndue As String = "COMMISSIONBALNDUE"
			 Public Const Commissionbalndate As String = "COMMISSIONBALNDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Commissionbalnid As String = "Commissionbalnid"
			 Public Const Salespersonid As String = "Salespersonid"
			 Public Const Commissiontype As String = "Commissiontype"
			 Public Const Commissionbalndue As String = "Commissionbalndue"
			 Public Const Commissionbalndate As String = "Commissionbalndate"
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
            SyncLock GetType(CommissionbalnMetadata)
			
				If CommissionbalnMetadata.mapDelegates Is Nothing Then
					CommissionbalnMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If CommissionbalnMetadata._meta Is Nothing Then
                    CommissionbalnMetadata._meta = New CommissionbalnMetadata()
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
				

				meta.AddTypeMap("Commissionbalnid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissiontype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Commissionbalndue", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Commissionbalndate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "COMMISSIONBALN"
				meta.Destination = "COMMISSIONBALN"
				
				meta.spInsert = "proc_COMMISSIONBALNInsert"
				meta.spUpdate = "proc_COMMISSIONBALNUpdate"
				meta.spDelete = "proc_COMMISSIONBALNDelete"
				meta.spLoadAll = "proc_COMMISSIONBALNLoadAll"
				meta.spLoadByPrimaryKey = "proc_COMMISSIONBALNLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As CommissionbalnMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
