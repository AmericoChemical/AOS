'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/25/2017 3:19:45 PM
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
	MustInherit Public Class esViewInvItemsCurrentStatusCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewInvItemsCurrentStatusCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewInvItemsCurrentStatusQuery)
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
            Me.InitQuery(CType(query, esViewInvItemsCurrentStatusQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewInvItemsCurrentStatus) As ViewInvItemsCurrentStatus
			Return CType(MyBase.DetachEntity(entity), ViewInvItemsCurrentStatus)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewInvItemsCurrentStatus) As ViewInvItemsCurrentStatus
			Return CType(MyBase.AttachEntity(entity), ViewInvItemsCurrentStatus)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewInvItemsCurrentStatusCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewInvItemsCurrentStatus
            Get
                Return TryCast(MyBase.Item(index), ViewInvItemsCurrentStatus)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewInvItemsCurrentStatus)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewInvItemsCurrentStatus	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewInvItemsCurrentStatusQuery
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "QAvail"
							Me.str.QAvail = CType(value, string)
												
						Case "QTesting"
							Me.str.QTesting = CType(value, string)
												
						Case "QInProd"
							Me.str.QInProd = CType(value, string)
												
						Case "QPending"
							Me.str.QPending = CType(value, string)
												
						Case "QHold"
							Me.str.QHold = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QAvail"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QAvail = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QTesting"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QTesting = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QInProd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QInProd = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QPending"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QPending = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QHold"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QHold = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewInvItemsCurrentStatus.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsCurrentStatus.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemsCurrentStatusMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemsCurrentStatusMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsCurrentStatus.QAvail
		' </summary>
		Public Overridable Property QAvail As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QAvail)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QAvail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsCurrentStatus.QTesting
		' </summary>
		Public Overridable Property QTesting As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QTesting)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QTesting, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsCurrentStatus.QInProd
		' </summary>
		Public Overridable Property QInProd As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QInProd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QInProd, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsCurrentStatus.QPending
		' </summary>
		Public Overridable Property QPending As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QPending)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QPending, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsCurrentStatus.QHold
		' </summary>
		Public Overridable Property QHold As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QHold)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsCurrentStatusMetadata.ColumnNames.QHold, value)
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
		
			Public Sub New(ByVal entity As esViewInvItemsCurrentStatus)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property QAvail As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QAvail
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QAvail = Nothing
					Else
						entity.QAvail = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property QTesting As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QTesting
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QTesting = Nothing
					Else
						entity.QTesting = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property QInProd As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QInProd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QInProd = Nothing
					Else
						entity.QInProd = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property QPending As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QPending
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QPending = Nothing
					Else
						entity.QPending = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property QHold As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QHold
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QHold = Nothing
					Else
						entity.QHold = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewInvItemsCurrentStatus
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewInvItemsCurrentStatusQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewInvItemsCurrentStatus can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewInvItemsCurrentStatusQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemsCurrentStatusMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsCurrentStatusMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsCurrentStatusMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QAvail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsCurrentStatusMetadata.ColumnNames.QAvail, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QTesting As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsCurrentStatusMetadata.ColumnNames.QTesting, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QInProd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsCurrentStatusMetadata.ColumnNames.QInProd, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QPending As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsCurrentStatusMetadata.ColumnNames.QPending, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QHold As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsCurrentStatusMetadata.ColumnNames.QHold, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewInvItemsCurrentStatusCollection")> _
	Partial Public Class ViewInvItemsCurrentStatusCollection
		Inherits esViewInvItemsCurrentStatusCollection
		Implements IEnumerable(Of ViewInvItemsCurrentStatus)
		
        Public Shared Widening Operator CType(ByVal coll As ViewInvItemsCurrentStatusCollection) As List(Of ViewInvItemsCurrentStatus)
            Dim list As List(Of ViewInvItemsCurrentStatus) = New List(Of ViewInvItemsCurrentStatus)
            Dim emp As ViewInvItemsCurrentStatus

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemsCurrentStatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemsCurrentStatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewInvItemsCurrentStatus(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewInvItemsCurrentStatus()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewInvItemsCurrentStatusQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewInvItemsCurrentStatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemsCurrentStatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewInvItemsCurrentStatus 
			Return CType(MyBase.AddNewEntity(), ViewInvItemsCurrentStatus)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewInvItemsCurrentStatus) Implements IEnumerable(Of ViewInvItemsCurrentStatus).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewInvItemsCurrentStatus)(Me)
        End Function
		
		Private _query As ViewInvItemsCurrentStatusQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewInvItemsCurrentStatus' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewInvItemsCurrentStatus ()")> _
	<Serializable> _
	Partial Public Class ViewInvItemsCurrentStatus 
		Inherits esViewInvItemsCurrentStatus

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewInvItemsCurrentStatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewInvItemsCurrentStatusQuery

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemsCurrentStatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewInvItemsCurrentStatusQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewInvItemsCurrentStatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemsCurrentStatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewInvItemsCurrentStatusQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewInvItemsCurrentStatusQuery
		inherits esViewInvItemsCurrentStatusQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewInvItemsCurrentStatusQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewInvItemsCurrentStatusMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewInvItemsCurrentStatusMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsCurrentStatusMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsCurrentStatusMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemsCurrentStatusMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsCurrentStatusMetadata.ColumnNames.QAvail, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsCurrentStatusMetadata.PropertyNames.QAvail
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsCurrentStatusMetadata.ColumnNames.QTesting, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsCurrentStatusMetadata.PropertyNames.QTesting
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsCurrentStatusMetadata.ColumnNames.QInProd, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsCurrentStatusMetadata.PropertyNames.QInProd
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsCurrentStatusMetadata.ColumnNames.QPending, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsCurrentStatusMetadata.PropertyNames.QPending
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsCurrentStatusMetadata.ColumnNames.QHold, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsCurrentStatusMetadata.PropertyNames.QHold
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewInvItemsCurrentStatusMetadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const QAvail As String = "QAvail"
			 Public Const QTesting As String = "QTesting"
			 Public Const QInProd As String = "QInProd"
			 Public Const QPending As String = "QPending"
			 Public Const QHold As String = "QHold"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const QAvail As String = "QAvail"
			 Public Const QTesting As String = "QTesting"
			 Public Const QInProd As String = "QInProd"
			 Public Const QPending As String = "QPending"
			 Public Const QHold As String = "QHold"
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
            SyncLock GetType(ViewInvItemsCurrentStatusMetadata)
			
				If ViewInvItemsCurrentStatusMetadata.mapDelegates Is Nothing Then
					ViewInvItemsCurrentStatusMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewInvItemsCurrentStatusMetadata._meta Is Nothing Then
                    ViewInvItemsCurrentStatusMetadata._meta = New ViewInvItemsCurrentStatusMetadata()
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
				

				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QAvail", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QTesting", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QInProd", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QPending", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QHold", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewInvItemsCurrentStatus"
				meta.Destination = "viewInvItemsCurrentStatus"
				
				meta.spInsert = "proc_viewInvItemsCurrentStatusInsert"
				meta.spUpdate = "proc_viewInvItemsCurrentStatusUpdate"
				meta.spDelete = "proc_viewInvItemsCurrentStatusDelete"
				meta.spLoadAll = "proc_viewInvItemsCurrentStatusLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewInvItemsCurrentStatusLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewInvItemsCurrentStatusMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
