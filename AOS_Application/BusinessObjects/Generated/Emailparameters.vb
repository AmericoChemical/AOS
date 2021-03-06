'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/23/2018 9:35:17 AM
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
	MustInherit Public Class esEmailparametersCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "EmailparametersCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esEmailparametersQuery)
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
            Me.InitQuery(CType(query, esEmailparametersQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Emailparameters) As Emailparameters
			Return CType(MyBase.DetachEntity(entity), Emailparameters)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Emailparameters) As Emailparameters
			Return CType(MyBase.AttachEntity(entity), Emailparameters)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As EmailparametersCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Emailparameters
            Get
                Return TryCast(MyBase.Item(index), Emailparameters)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Emailparameters)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esEmailparameters	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esEmailparametersQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal emailName As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(emailName)
			Else
				Return LoadByPrimaryKeyStoredProcedure(emailName)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal emailName As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(emailName)
			Else
				Return LoadByPrimaryKeyStoredProcedure(emailName)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal emailName As System.String) As Boolean
		
			Dim query As esEmailparametersQuery = Me.GetDynamicQuery()
			query.Where(query.EmailName.Equal(emailName))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal emailName As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("EmailName", emailName)
			
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
												
						Case "EmailName"
							Me.str.EmailName = CType(value, string)
												
						Case "EmailFrom"
							Me.str.EmailFrom = CType(value, string)
												
						Case "EmailTo"
							Me.str.EmailTo = CType(value, string)
												
						Case "EmailCC"
							Me.str.EmailCC = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
					
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
		' Maps to EMAILPARAMETERS.EmailName
		' </summary>
		Public Overridable Property EmailName As System.String
			Get
				Return MyBase.GetSystemString(EmailparametersMetadata.ColumnNames.EmailName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(EmailparametersMetadata.ColumnNames.EmailName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to EMAILPARAMETERS.EmailFrom
		' </summary>
		Public Overridable Property EmailFrom As System.String
			Get
				Return MyBase.GetSystemString(EmailparametersMetadata.ColumnNames.EmailFrom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(EmailparametersMetadata.ColumnNames.EmailFrom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to EMAILPARAMETERS.EmailTo
		' </summary>
		Public Overridable Property EmailTo As System.String
			Get
				Return MyBase.GetSystemString(EmailparametersMetadata.ColumnNames.EmailTo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(EmailparametersMetadata.ColumnNames.EmailTo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to EMAILPARAMETERS.EmailCC
		' </summary>
		Public Overridable Property EmailCC As System.String
			Get
				Return MyBase.GetSystemString(EmailparametersMetadata.ColumnNames.EmailCC)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(EmailparametersMetadata.ColumnNames.EmailCC, value)
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
		
			Public Sub New(ByVal entity As esEmailparameters)
				Me.entity = entity
			End Sub				
		
	
			Public Property EmailName As System.String 
				Get
					Dim data_ As System.String = entity.EmailName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmailName = Nothing
					Else
						entity.EmailName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmailFrom As System.String 
				Get
					Dim data_ As System.String = entity.EmailFrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmailFrom = Nothing
					Else
						entity.EmailFrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmailTo As System.String 
				Get
					Dim data_ As System.String = entity.EmailTo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmailTo = Nothing
					Else
						entity.EmailTo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmailCC As System.String 
				Get
					Dim data_ As System.String = entity.EmailCC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmailCC = Nothing
					Else
						entity.EmailCC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esEmailparameters
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esEmailparametersQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esEmailparameters can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Emailparameters 
		Inherits esEmailparameters
		
	
		
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
	MustInherit Public Class esEmailparametersQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EmailparametersMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property EmailName As esQueryItem
			Get
				Return New esQueryItem(Me, EmailparametersMetadata.ColumnNames.EmailName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmailFrom As esQueryItem
			Get
				Return New esQueryItem(Me, EmailparametersMetadata.ColumnNames.EmailFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmailTo As esQueryItem
			Get
				Return New esQueryItem(Me, EmailparametersMetadata.ColumnNames.EmailTo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmailCC As esQueryItem
			Get
				Return New esQueryItem(Me, EmailparametersMetadata.ColumnNames.EmailCC, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("EmailparametersCollection")> _
	Partial Public Class EmailparametersCollection
		Inherits esEmailparametersCollection
		Implements IEnumerable(Of Emailparameters)
		
        Public Shared Widening Operator CType(ByVal coll As EmailparametersCollection) As List(Of Emailparameters)
            Dim list As List(Of Emailparameters) = New List(Of Emailparameters)
            Dim emp As Emailparameters

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EmailparametersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New EmailparametersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Emailparameters(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Emailparameters()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As EmailparametersQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New EmailparametersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As EmailparametersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Emailparameters 
			Return CType(MyBase.AddNewEntity(), Emailparameters)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal emailName As System.String) As Emailparameters
			Return CType(MyBase.FindByPrimaryKey(emailName), Emailparameters)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Emailparameters) Implements IEnumerable(Of Emailparameters).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Emailparameters)(Me)
        End Function
		
		Private _query As EmailparametersQuery

	End Class
	


	' <summary>
	' Encapsulates the 'EMAILPARAMETERS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Emailparameters ({EmailName})")> _
	<Serializable> _
	Partial Public Class Emailparameters 
		Inherits esEmailparameters

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return EmailparametersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esEmailparametersQuery

			If Me._query Is Nothing Then
				Me._query = New EmailparametersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As EmailparametersQuery
			Get

				If Me._query Is Nothing then
					Me._query = New EmailparametersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As EmailparametersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As EmailparametersQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class EmailparametersQuery
		inherits esEmailparametersQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "EmailparametersQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class EmailparametersMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(EmailparametersMetadata.ColumnNames.EmailName, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmailparametersMetadata.PropertyNames.EmailName
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(EmailparametersMetadata.ColumnNames.EmailFrom, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmailparametersMetadata.PropertyNames.EmailFrom
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(EmailparametersMetadata.ColumnNames.EmailTo, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmailparametersMetadata.PropertyNames.EmailTo
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(EmailparametersMetadata.ColumnNames.EmailCC, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmailparametersMetadata.PropertyNames.EmailCC
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As EmailparametersMetadata
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
			 Public Const EmailName As String = "EmailName"
			 Public Const EmailFrom As String = "EmailFrom"
			 Public Const EmailTo As String = "EmailTo"
			 Public Const EmailCC As String = "EmailCC"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const EmailName As String = "EmailName"
			 Public Const EmailFrom As String = "EmailFrom"
			 Public Const EmailTo As String = "EmailTo"
			 Public Const EmailCC As String = "EmailCC"
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
            SyncLock GetType(EmailparametersMetadata)
			
				If EmailparametersMetadata.mapDelegates Is Nothing Then
					EmailparametersMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If EmailparametersMetadata._meta Is Nothing Then
                    EmailparametersMetadata._meta = New EmailparametersMetadata()
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
				

				meta.AddTypeMap("EmailName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmailFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmailTo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmailCC", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "EMAILPARAMETERS"
				meta.Destination = "EMAILPARAMETERS"
				
				meta.spInsert = "proc_EMAILPARAMETERSInsert"
				meta.spUpdate = "proc_EMAILPARAMETERSUpdate"
				meta.spDelete = "proc_EMAILPARAMETERSDelete"
				meta.spLoadAll = "proc_EMAILPARAMETERSLoadAll"
				meta.spLoadByPrimaryKey = "proc_EMAILPARAMETERSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As EmailparametersMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
