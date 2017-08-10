'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.1.0209.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/8/2013 9:07:34 AM
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
 
Namespace BusinessObjects


	<Serializable> _
	MustInherit Public Class esRmfgCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "RmfgCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esRmfgQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntityCollection).Connection
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
            Me.InitQuery(CType(query, esRmfgQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Rmfg) As Rmfg
			Return CType(MyBase.DetachEntity(entity), Rmfg)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Rmfg) As Rmfg
			Return CType(MyBase.AttachEntity(entity), Rmfg)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As RmfgCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Rmfg
            Get
                Return TryCast(MyBase.Item(index), Rmfg)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Rmfg)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esRmfg	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esRmfgQuery
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
		
			Dim query As esRmfgQuery = Me.GetDynamicQuery()
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
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Warehouselocation"
							Me.str.Warehouselocation = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Unitsremaining"
							Me.str.Unitsremaining = CType(value, string)
												
						Case "FGContainers"
							Me.str.FGContainers = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Productid = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Unitsremaining"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Unitsremaining = CType(value, Nullable(Of System.Double))
							End If
						
						Case "FGContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.FGContainers = CType(value, Nullable(Of System.Double))
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
		' Maps to RMFG.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(RmfgMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(RmfgMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RMFG.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(RmfgMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(RmfgMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RMFG.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(RmfgMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RmfgMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RMFG.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(RmfgMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RmfgMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RMFG.WAREHOUSELOCATION
		' </summary>
		Public Overridable Property Warehouselocation As System.String
			Get
				Return MyBase.GetSystemString(RmfgMetadata.ColumnNames.Warehouselocation)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RmfgMetadata.ColumnNames.Warehouselocation, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RMFG.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(RmfgMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RmfgMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RMFG.UNITSREMAINING
		' </summary>
		Public Overridable Property Unitsremaining As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(RmfgMetadata.ColumnNames.Unitsremaining)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(RmfgMetadata.ColumnNames.Unitsremaining, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RMFG.FGContainers
		' </summary>
		Public Overridable Property FGContainers As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(RmfgMetadata.ColumnNames.FGContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(RmfgMetadata.ColumnNames.FGContainers, value)
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
		
			Public Sub New(ByVal entity As esRmfg)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Invitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnumber = Nothing
					Else
						entity.Invitemnumber = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productid As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Productid
					
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
						entity.Productid = Convert.ToDouble(Value)
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
		  	
			Public Property Warehouselocation As System.String 
				Get
					Dim data_ As System.String = entity.Warehouselocation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehouselocation = Nothing
					Else
						entity.Warehouselocation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Itemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemstatus = Nothing
					Else
						entity.Itemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitsremaining As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Unitsremaining
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsremaining = Nothing
					Else
						entity.Unitsremaining = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property FGContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.FGContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FGContainers = Nothing
					Else
						entity.FGContainers = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esRmfg
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esRmfgQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esRmfg can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Rmfg 
		Inherits esRmfg
		
	
		
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
	MustInherit Public Class esRmfgQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RmfgMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, RmfgMetadata.ColumnNames.Invitemnumber, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, RmfgMetadata.ColumnNames.Productid, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, RmfgMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, RmfgMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouselocation As esQueryItem
			Get
				Return New esQueryItem(Me, RmfgMetadata.ColumnNames.Warehouselocation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, RmfgMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsremaining As esQueryItem
			Get
				Return New esQueryItem(Me, RmfgMetadata.ColumnNames.Unitsremaining, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property FGContainers As esQueryItem
			Get
				Return New esQueryItem(Me, RmfgMetadata.ColumnNames.FGContainers, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("RmfgCollection")> _
	Partial Public Class RmfgCollection
		Inherits esRmfgCollection
		Implements IEnumerable(Of Rmfg)
		
        Public Shared Widening Operator CType(ByVal coll As RmfgCollection) As List(Of Rmfg)
            Dim list As List(Of Rmfg) = New List(Of Rmfg)
            Dim emp As Rmfg

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RmfgMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New RmfgQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Rmfg(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Rmfg()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As RmfgQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New RmfgQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RmfgQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Rmfg 
			Return CType(MyBase.AddNewEntity(), Rmfg)
		End Function

		Public Overloads Function FindByPrimaryKey() As Rmfg
			Return CType(MyBase.FindByPrimaryKey(), Rmfg)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Rmfg) Implements IEnumerable(Of Rmfg).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Rmfg)(Me)
        End Function
		
		Private _query As RmfgQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RMFG' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Rmfg ()")> _
	<Serializable> _
	Partial Public Class Rmfg 
		Inherits esRmfg

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return RmfgMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esRmfgQuery

			If Me._query Is Nothing Then
				Me._query = New RmfgQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As RmfgQuery
			Get

				If Me._query Is Nothing then
					Me._query = New RmfgQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RmfgQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As RmfgQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class RmfgQuery
		inherits esRmfgQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
				

	End Class




	<Serializable> _
	Partial Public Class RmfgMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(RmfgMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = RmfgMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(RmfgMetadata.ColumnNames.Productid, 1, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = RmfgMetadata.PropertyNames.Productid
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(RmfgMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = RmfgMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(RmfgMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = RmfgMetadata.PropertyNames.Container
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(RmfgMetadata.ColumnNames.Warehouselocation, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = RmfgMetadata.PropertyNames.Warehouselocation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(RmfgMetadata.ColumnNames.Itemstatus, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = RmfgMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(RmfgMetadata.ColumnNames.Unitsremaining, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = RmfgMetadata.PropertyNames.Unitsremaining
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(RmfgMetadata.ColumnNames.FGContainers, 7, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = RmfgMetadata.PropertyNames.FGContainers
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c) 
				
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As RmfgMetadata
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
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Warehouselocation As String = "WAREHOUSELOCATION"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Unitsremaining As String = "UNITSREMAINING"
			 Public Const FGContainers As String = "FGContainers"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Warehouselocation As String = "Warehouselocation"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Unitsremaining As String = "Unitsremaining"
			 Public Const FGContainers As String = "FGContainers"
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
            SyncLock GetType(RmfgMetadata)
			
				If RmfgMetadata.mapDelegates Is Nothing Then
					RmfgMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If RmfgMetadata._meta Is Nothing Then
                    RmfgMetadata._meta = New RmfgMetadata()
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
				

				meta.AddTypeMap("INVITEMNUMBER", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PRODUCTID", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PRODUCTDESC", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CONTAINER", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WAREHOUSELOCATION", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ITEMSTATUS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("UNITSREMAINING", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("FGContainers", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "RMFG"
				meta.Destination = "RMFG"
				
				meta.spInsert = "proc_RMFGInsert"
				meta.spUpdate = "proc_RMFGUpdate"
				meta.spDelete = "proc_RMFGDelete"
				meta.spLoadAll = "proc_RMFGLoadAll"
				meta.spLoadByPrimaryKey = "proc_RMFGLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As RmfgMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
