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
	MustInherit Public Class esLbifdtCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LbifdtCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLbifdtQuery)
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
            Me.InitQuery(CType(query, esLbifdtQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Lbifdt) As Lbifdt
			Return CType(MyBase.DetachEntity(entity), Lbifdt)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Lbifdt) As Lbifdt
			Return CType(MyBase.AttachEntity(entity), Lbifdt)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LbifdtCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Lbifdt
            Get
                Return TryCast(MyBase.Item(index), Lbifdt)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Lbifdt)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLbifdt	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLbifdtQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey() As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic() As Boolean
		
			Dim query As esLbifdtQuery = Me.GetDynamicQuery()
			query.Where()
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure() As Boolean
		
			Dim parms As esParameters = New esParameters()

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
												
						Case "Ldid"
							Me.str.Ldid = CType(value, string)
												
						Case "Ldsect"
							Me.str.Ldsect = CType(value, string)
												
						Case "Ldvalu"
							Me.str.Ldvalu = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Ldid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ldid = CType(value, Nullable(Of System.Decimal))
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
		' Maps to LBIFDT.LDID
		' </summary>
		Public Overridable Property Ldid As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifdtMetadata.ColumnNames.Ldid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifdtMetadata.ColumnNames.Ldid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFDT.LDSECT
		' </summary>
		Public Overridable Property Ldsect As System.String
			Get
				Return MyBase.GetSystemString(LbifdtMetadata.ColumnNames.Ldsect)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifdtMetadata.ColumnNames.Ldsect, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFDT.LDVALU
		' </summary>
		Public Overridable Property Ldvalu As System.String
			Get
				Return MyBase.GetSystemString(LbifdtMetadata.ColumnNames.Ldvalu)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifdtMetadata.ColumnNames.Ldvalu, value)
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
		
			Public Sub New(ByVal entity As esLbifdt)
				Me.entity = entity
			End Sub				
		
	
			Public Property Ldid As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ldid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ldid = Nothing
					Else
						entity.Ldid = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ldsect As System.String 
				Get
					Dim data_ As System.String = entity.Ldsect
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ldsect = Nothing
					Else
						entity.Ldsect = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ldvalu As System.String 
				Get
					Dim data_ As System.String = entity.Ldvalu
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ldvalu = Nothing
					Else
						entity.Ldvalu = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLbifdt
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLbifdtQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLbifdt can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Lbifdt 
		Inherits esLbifdt
		
	
		
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
	MustInherit Public Class esLbifdtQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LbifdtMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Ldid As esQueryItem
			Get
				Return New esQueryItem(Me, LbifdtMetadata.ColumnNames.Ldid, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ldsect As esQueryItem
			Get
				Return New esQueryItem(Me, LbifdtMetadata.ColumnNames.Ldsect, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ldvalu As esQueryItem
			Get
				Return New esQueryItem(Me, LbifdtMetadata.ColumnNames.Ldvalu, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LbifdtCollection")> _
	Partial Public Class LbifdtCollection
		Inherits esLbifdtCollection
		Implements IEnumerable(Of Lbifdt)
		
        Public Shared Widening Operator CType(ByVal coll As LbifdtCollection) As List(Of Lbifdt)
            Dim list As List(Of Lbifdt) = New List(Of Lbifdt)
            Dim emp As Lbifdt

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LbifdtMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LbifdtQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Lbifdt(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Lbifdt()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LbifdtQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LbifdtQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LbifdtQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Lbifdt 
			Return CType(MyBase.AddNewEntity(), Lbifdt)
		End Function

		Public Overloads Function FindByPrimaryKey() As Lbifdt
			Return CType(MyBase.FindByPrimaryKey(), Lbifdt)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Lbifdt) Implements IEnumerable(Of Lbifdt).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Lbifdt)(Me)
        End Function
		
		Private _query As LbifdtQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LBIFDT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Lbifdt ()")> _
	<Serializable> _
	Partial Public Class Lbifdt 
		Inherits esLbifdt

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LbifdtMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLbifdtQuery

			If Me._query Is Nothing Then
				Me._query = New LbifdtQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LbifdtQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LbifdtQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LbifdtQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LbifdtQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LbifdtQuery
		inherits esLbifdtQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LbifdtQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LbifdtMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LbifdtMetadata.ColumnNames.Ldid, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifdtMetadata.PropertyNames.Ldid
			c.NumericPrecision = 11
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifdtMetadata.ColumnNames.Ldsect, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifdtMetadata.PropertyNames.Ldsect
			c.CharacterMaxLength = 255
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifdtMetadata.ColumnNames.Ldvalu, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifdtMetadata.PropertyNames.Ldvalu
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LbifdtMetadata
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
			 Public Const Ldid As String = "LDID"
			 Public Const Ldsect As String = "LDSECT"
			 Public Const Ldvalu As String = "LDVALU"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Ldid As String = "Ldid"
			 Public Const Ldsect As String = "Ldsect"
			 Public Const Ldvalu As String = "Ldvalu"
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
            SyncLock GetType(LbifdtMetadata)
			
				If LbifdtMetadata.mapDelegates Is Nothing Then
					LbifdtMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LbifdtMetadata._meta Is Nothing Then
                    LbifdtMetadata._meta = New LbifdtMetadata()
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
				

				meta.AddTypeMap("Ldid", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ldsect", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ldvalu", new esTypeMap("ntext", "System.String"))			
				
				
				 
				meta.Source = "LBIFDT"
				meta.Destination = "LBIFDT"
				
				meta.spInsert = "proc_LBIFDTInsert"
				meta.spUpdate = "proc_LBIFDTUpdate"
				meta.spDelete = "proc_LBIFDTDelete"
				meta.spLoadAll = "proc_LBIFDTLoadAll"
				meta.spLoadByPrimaryKey = "proc_LBIFDTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LbifdtMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
