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
	MustInherit Public Class esCommissionpmtCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "CommissionpmtCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esCommissionpmtQuery)
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
            Me.InitQuery(CType(query, esCommissionpmtQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Commissionpmt) As Commissionpmt
			Return CType(MyBase.DetachEntity(entity), Commissionpmt)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Commissionpmt) As Commissionpmt
			Return CType(MyBase.AttachEntity(entity), Commissionpmt)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As CommissionpmtCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Commissionpmt
            Get
                Return TryCast(MyBase.Item(index), Commissionpmt)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Commissionpmt)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esCommissionpmt	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esCommissionpmtQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal commissionpmtid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(commissionpmtid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(commissionpmtid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal commissionpmtid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(commissionpmtid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(commissionpmtid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal commissionpmtid As System.Int32) As Boolean
		
			Dim query As esCommissionpmtQuery = Me.GetDynamicQuery()
			query.Where(query.Commissionpmtid.Equal(commissionpmtid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal commissionpmtid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("COMMISSIONPMTID", commissionpmtid)
			
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
												
						Case "Commissionpmtid"
							Me.str.Commissionpmtid = CType(value, string)
												
						Case "Commissionpmtdate"
							Me.str.Commissionpmtdate = CType(value, string)
												
						Case "Commissionpmtamt"
							Me.str.Commissionpmtamt = CType(value, string)
												
						Case "Salespersonid"
							Me.str.Salespersonid = CType(value, string)
												
						Case "Commissionpmttype"
							Me.str.Commissionpmttype = CType(value, string)
												
						Case "Commissionpmtnote"
							Me.str.Commissionpmtnote = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Commissionpmtid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Commissionpmtid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Commissionpmtdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Commissionpmtdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Commissionpmtamt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Commissionpmtamt = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Salespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Salespersonid = CType(value, Nullable(Of System.Int32))
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
		' Maps to COMMISSIONPMT.COMMISSIONPMTID
		' </summary>
		Public Overridable Property Commissionpmtid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionpmtMetadata.ColumnNames.Commissionpmtid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionpmtMetadata.ColumnNames.Commissionpmtid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONPMT.COMMISSIONPMTDATE
		' </summary>
		Public Overridable Property Commissionpmtdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CommissionpmtMetadata.ColumnNames.Commissionpmtdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CommissionpmtMetadata.ColumnNames.Commissionpmtdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONPMT.COMMISSIONPMTAMT
		' </summary>
		Public Overridable Property Commissionpmtamt As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(CommissionpmtMetadata.ColumnNames.Commissionpmtamt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(CommissionpmtMetadata.ColumnNames.Commissionpmtamt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONPMT.SALESPERSONID
		' </summary>
		Public Overridable Property Salespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionpmtMetadata.ColumnNames.Salespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionpmtMetadata.ColumnNames.Salespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONPMT.COMMISSIONPMTTYPE
		' </summary>
		Public Overridable Property Commissionpmttype As System.String
			Get
				Return MyBase.GetSystemString(CommissionpmtMetadata.ColumnNames.Commissionpmttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CommissionpmtMetadata.ColumnNames.Commissionpmttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSIONPMT.COMMISSIONPMTNOTE
		' </summary>
		Public Overridable Property Commissionpmtnote As System.String
			Get
				Return MyBase.GetSystemString(CommissionpmtMetadata.ColumnNames.Commissionpmtnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CommissionpmtMetadata.ColumnNames.Commissionpmtnote, value)
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
		
			Public Sub New(ByVal entity As esCommissionpmt)
				Me.entity = entity
			End Sub				
		
	
			Public Property Commissionpmtid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Commissionpmtid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionpmtid = Nothing
					Else
						entity.Commissionpmtid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionpmtdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Commissionpmtdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionpmtdate = Nothing
					Else
						entity.Commissionpmtdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionpmtamt As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Commissionpmtamt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionpmtamt = Nothing
					Else
						entity.Commissionpmtamt = Convert.ToDecimal(Value)
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
		  	
			Public Property Commissionpmttype As System.String 
				Get
					Dim data_ As System.String = entity.Commissionpmttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionpmttype = Nothing
					Else
						entity.Commissionpmttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionpmtnote As System.String 
				Get
					Dim data_ As System.String = entity.Commissionpmtnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionpmtnote = Nothing
					Else
						entity.Commissionpmtnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCommissionpmt
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esCommissionpmtQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esCommissionpmt can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Commissionpmt 
		Inherits esCommissionpmt
		
	
		
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
	MustInherit Public Class esCommissionpmtQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommissionpmtMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Commissionpmtid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionpmtMetadata.ColumnNames.Commissionpmtid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionpmtdate As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionpmtMetadata.ColumnNames.Commissionpmtdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionpmtamt As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionpmtMetadata.ColumnNames.Commissionpmtamt, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionpmtMetadata.ColumnNames.Salespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionpmttype As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionpmtMetadata.ColumnNames.Commissionpmttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionpmtnote As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionpmtMetadata.ColumnNames.Commissionpmtnote, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("CommissionpmtCollection")> _
	Partial Public Class CommissionpmtCollection
		Inherits esCommissionpmtCollection
		Implements IEnumerable(Of Commissionpmt)
		
        Public Shared Widening Operator CType(ByVal coll As CommissionpmtCollection) As List(Of Commissionpmt)
            Dim list As List(Of Commissionpmt) = New List(Of Commissionpmt)
            Dim emp As Commissionpmt

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommissionpmtMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New CommissionpmtQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Commissionpmt(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Commissionpmt()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As CommissionpmtQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New CommissionpmtQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CommissionpmtQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Commissionpmt 
			Return CType(MyBase.AddNewEntity(), Commissionpmt)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal commissionpmtid As System.Int32) As Commissionpmt
			Return CType(MyBase.FindByPrimaryKey(commissionpmtid), Commissionpmt)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Commissionpmt) Implements IEnumerable(Of Commissionpmt).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Commissionpmt)(Me)
        End Function
		
		Private _query As CommissionpmtQuery

	End Class
	


	' <summary>
	' Encapsulates the 'COMMISSIONPMT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Commissionpmt ({Commissionpmtid.Value})")> _
	<Serializable> _
	Partial Public Class Commissionpmt 
		Inherits esCommissionpmt

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return CommissionpmtMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esCommissionpmtQuery

			If Me._query Is Nothing Then
				Me._query = New CommissionpmtQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As CommissionpmtQuery
			Get

				If Me._query Is Nothing then
					Me._query = New CommissionpmtQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CommissionpmtQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As CommissionpmtQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class CommissionpmtQuery
		inherits esCommissionpmtQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "CommissionpmtQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class CommissionpmtMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CommissionpmtMetadata.ColumnNames.Commissionpmtid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionpmtMetadata.PropertyNames.Commissionpmtid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionpmtMetadata.ColumnNames.Commissionpmtdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CommissionpmtMetadata.PropertyNames.Commissionpmtdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionpmtMetadata.ColumnNames.Commissionpmtamt, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = CommissionpmtMetadata.PropertyNames.Commissionpmtamt
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionpmtMetadata.ColumnNames.Salespersonid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionpmtMetadata.PropertyNames.Salespersonid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionpmtMetadata.ColumnNames.Commissionpmttype, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommissionpmtMetadata.PropertyNames.Commissionpmttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionpmtMetadata.ColumnNames.Commissionpmtnote, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommissionpmtMetadata.PropertyNames.Commissionpmtnote
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As CommissionpmtMetadata
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
			 Public Const Commissionpmtid As String = "COMMISSIONPMTID"
			 Public Const Commissionpmtdate As String = "COMMISSIONPMTDATE"
			 Public Const Commissionpmtamt As String = "COMMISSIONPMTAMT"
			 Public Const Salespersonid As String = "SALESPERSONID"
			 Public Const Commissionpmttype As String = "COMMISSIONPMTTYPE"
			 Public Const Commissionpmtnote As String = "COMMISSIONPMTNOTE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Commissionpmtid As String = "Commissionpmtid"
			 Public Const Commissionpmtdate As String = "Commissionpmtdate"
			 Public Const Commissionpmtamt As String = "Commissionpmtamt"
			 Public Const Salespersonid As String = "Salespersonid"
			 Public Const Commissionpmttype As String = "Commissionpmttype"
			 Public Const Commissionpmtnote As String = "Commissionpmtnote"
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
            SyncLock GetType(CommissionpmtMetadata)
			
				If CommissionpmtMetadata.mapDelegates Is Nothing Then
					CommissionpmtMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If CommissionpmtMetadata._meta Is Nothing Then
                    CommissionpmtMetadata._meta = New CommissionpmtMetadata()
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
				

				meta.AddTypeMap("Commissionpmtid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissionpmtdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Commissionpmtamt", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Salespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissionpmttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Commissionpmtnote", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "COMMISSIONPMT"
				meta.Destination = "COMMISSIONPMT"
				
				meta.spInsert = "proc_COMMISSIONPMTInsert"
				meta.spUpdate = "proc_COMMISSIONPMTUpdate"
				meta.spDelete = "proc_COMMISSIONPMTDelete"
				meta.spLoadAll = "proc_COMMISSIONPMTLoadAll"
				meta.spLoadByPrimaryKey = "proc_COMMISSIONPMTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As CommissionpmtMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
