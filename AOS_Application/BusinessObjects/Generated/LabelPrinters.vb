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
	MustInherit Public Class esLabelPrintersCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LabelPrintersCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLabelPrintersQuery)
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
            Me.InitQuery(CType(query, esLabelPrintersQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As LabelPrinters) As LabelPrinters
			Return CType(MyBase.DetachEntity(entity), LabelPrinters)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As LabelPrinters) As LabelPrinters
			Return CType(MyBase.AttachEntity(entity), LabelPrinters)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LabelPrintersCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As LabelPrinters
            Get
                Return TryCast(MyBase.Item(index), LabelPrinters)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(LabelPrinters)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLabelPrinters	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLabelPrintersQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal printerid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(printerid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(printerid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal printerid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(printerid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(printerid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal printerid As System.Int32) As Boolean
		
			Dim query As esLabelPrintersQuery = Me.GetDynamicQuery()
			query.Where(query.Printerid.Equal(printerid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal printerid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PRINTERID", printerid)
			
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
												
						Case "Printerid"
							Me.str.Printerid = CType(value, string)
												
						Case "LabelType"
							Me.str.LabelType = CType(value, string)
												
						Case "PrinterIp"
							Me.str.PrinterIp = CType(value, string)
												
						Case "PrinterUsername"
							Me.str.PrinterUsername = CType(value, string)
												
						Case "PrinterPassword"
							Me.str.PrinterPassword = CType(value, string)
												
						Case "PrinterName"
							Me.str.PrinterName = CType(value, string)
												
						Case "Active"
							Me.str.Active = CType(value, string)
												
						Case "DisableScanner"
							Me.str.DisableScanner = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Printerid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Printerid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Active"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Active = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "DisableScanner"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.DisableScanner = CType(value, Nullable(Of System.Boolean))
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
		' Maps to LABEL_PRINTERS.PRINTERID
		' </summary>
		Public Overridable Property Printerid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LabelPrintersMetadata.ColumnNames.Printerid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LabelPrintersMetadata.ColumnNames.Printerid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LABEL_PRINTERS.LABEL_TYPE
		' </summary>
		Public Overridable Property LabelType As System.String
			Get
				Return MyBase.GetSystemString(LabelPrintersMetadata.ColumnNames.LabelType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LabelPrintersMetadata.ColumnNames.LabelType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LABEL_PRINTERS.PRINTER_IP
		' </summary>
		Public Overridable Property PrinterIp As System.String
			Get
				Return MyBase.GetSystemString(LabelPrintersMetadata.ColumnNames.PrinterIp)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LabelPrintersMetadata.ColumnNames.PrinterIp, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LABEL_PRINTERS.PRINTER_USERNAME
		' </summary>
		Public Overridable Property PrinterUsername As System.String
			Get
				Return MyBase.GetSystemString(LabelPrintersMetadata.ColumnNames.PrinterUsername)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LabelPrintersMetadata.ColumnNames.PrinterUsername, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LABEL_PRINTERS.PRINTER_PASSWORD
		' </summary>
		Public Overridable Property PrinterPassword As System.String
			Get
				Return MyBase.GetSystemString(LabelPrintersMetadata.ColumnNames.PrinterPassword)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LabelPrintersMetadata.ColumnNames.PrinterPassword, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LABEL_PRINTERS.PRINTER_NAME
		' </summary>
		Public Overridable Property PrinterName As System.String
			Get
				Return MyBase.GetSystemString(LabelPrintersMetadata.ColumnNames.PrinterName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LabelPrintersMetadata.ColumnNames.PrinterName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LABEL_PRINTERS.ACTIVE
		' </summary>
		Public Overridable Property Active As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LabelPrintersMetadata.ColumnNames.Active)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(LabelPrintersMetadata.ColumnNames.Active, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LABEL_PRINTERS.DISABLE_SCANNER
		' </summary>
		Public Overridable Property DisableScanner As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LabelPrintersMetadata.ColumnNames.DisableScanner)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(LabelPrintersMetadata.ColumnNames.DisableScanner, value)
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
		
			Public Sub New(ByVal entity As esLabelPrinters)
				Me.entity = entity
			End Sub				
		
	
			Public Property Printerid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Printerid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Printerid = Nothing
					Else
						entity.Printerid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LabelType As System.String 
				Get
					Dim data_ As System.String = entity.LabelType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LabelType = Nothing
					Else
						entity.LabelType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrinterIp As System.String 
				Get
					Dim data_ As System.String = entity.PrinterIp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrinterIp = Nothing
					Else
						entity.PrinterIp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrinterUsername As System.String 
				Get
					Dim data_ As System.String = entity.PrinterUsername
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrinterUsername = Nothing
					Else
						entity.PrinterUsername = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrinterPassword As System.String 
				Get
					Dim data_ As System.String = entity.PrinterPassword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrinterPassword = Nothing
					Else
						entity.PrinterPassword = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrinterName As System.String 
				Get
					Dim data_ As System.String = entity.PrinterName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrinterName = Nothing
					Else
						entity.PrinterName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Active As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Active
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Active = Nothing
					Else
						entity.Active = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property DisableScanner As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.DisableScanner
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DisableScanner = Nothing
					Else
						entity.DisableScanner = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLabelPrinters
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLabelPrintersQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLabelPrinters can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class LabelPrinters 
		Inherits esLabelPrinters
		
	
		
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
	MustInherit Public Class esLabelPrintersQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LabelPrintersMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Printerid As esQueryItem
			Get
				Return New esQueryItem(Me, LabelPrintersMetadata.ColumnNames.Printerid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LabelType As esQueryItem
			Get
				Return New esQueryItem(Me, LabelPrintersMetadata.ColumnNames.LabelType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrinterIp As esQueryItem
			Get
				Return New esQueryItem(Me, LabelPrintersMetadata.ColumnNames.PrinterIp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrinterUsername As esQueryItem
			Get
				Return New esQueryItem(Me, LabelPrintersMetadata.ColumnNames.PrinterUsername, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrinterPassword As esQueryItem
			Get
				Return New esQueryItem(Me, LabelPrintersMetadata.ColumnNames.PrinterPassword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrinterName As esQueryItem
			Get
				Return New esQueryItem(Me, LabelPrintersMetadata.ColumnNames.PrinterName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Active As esQueryItem
			Get
				Return New esQueryItem(Me, LabelPrintersMetadata.ColumnNames.Active, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property DisableScanner As esQueryItem
			Get
				Return New esQueryItem(Me, LabelPrintersMetadata.ColumnNames.DisableScanner, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LabelPrintersCollection")> _
	Partial Public Class LabelPrintersCollection
		Inherits esLabelPrintersCollection
		Implements IEnumerable(Of LabelPrinters)
		
        Public Shared Widening Operator CType(ByVal coll As LabelPrintersCollection) As List(Of LabelPrinters)
            Dim list As List(Of LabelPrinters) = New List(Of LabelPrinters)
            Dim emp As LabelPrinters

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LabelPrintersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LabelPrintersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New LabelPrinters(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New LabelPrinters()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LabelPrintersQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LabelPrintersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LabelPrintersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As LabelPrinters 
			Return CType(MyBase.AddNewEntity(), LabelPrinters)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal printerid As System.Int32) As LabelPrinters
			Return CType(MyBase.FindByPrimaryKey(printerid), LabelPrinters)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of LabelPrinters) Implements IEnumerable(Of LabelPrinters).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of LabelPrinters)(Me)
        End Function
		
		Private _query As LabelPrintersQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LABEL_PRINTERS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("LabelPrinters ({Printerid.Value})")> _
	<Serializable> _
	Partial Public Class LabelPrinters 
		Inherits esLabelPrinters

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LabelPrintersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLabelPrintersQuery

			If Me._query Is Nothing Then
				Me._query = New LabelPrintersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LabelPrintersQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LabelPrintersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LabelPrintersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LabelPrintersQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LabelPrintersQuery
		inherits esLabelPrintersQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LabelPrintersQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LabelPrintersMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LabelPrintersMetadata.ColumnNames.Printerid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LabelPrintersMetadata.PropertyNames.Printerid
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LabelPrintersMetadata.ColumnNames.LabelType, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = LabelPrintersMetadata.PropertyNames.LabelType
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(LabelPrintersMetadata.ColumnNames.PrinterIp, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = LabelPrintersMetadata.PropertyNames.PrinterIp
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(LabelPrintersMetadata.ColumnNames.PrinterUsername, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = LabelPrintersMetadata.PropertyNames.PrinterUsername
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(LabelPrintersMetadata.ColumnNames.PrinterPassword, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = LabelPrintersMetadata.PropertyNames.PrinterPassword
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(LabelPrintersMetadata.ColumnNames.PrinterName, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = LabelPrintersMetadata.PropertyNames.PrinterName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LabelPrintersMetadata.ColumnNames.Active, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LabelPrintersMetadata.PropertyNames.Active
			_columns.Add(c)
				
			c = New esColumnMetadata(LabelPrintersMetadata.ColumnNames.DisableScanner, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LabelPrintersMetadata.PropertyNames.DisableScanner
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LabelPrintersMetadata
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
			 Public Const Printerid As String = "PRINTERID"
			 Public Const LabelType As String = "LABEL_TYPE"
			 Public Const PrinterIp As String = "PRINTER_IP"
			 Public Const PrinterUsername As String = "PRINTER_USERNAME"
			 Public Const PrinterPassword As String = "PRINTER_PASSWORD"
			 Public Const PrinterName As String = "PRINTER_NAME"
			 Public Const Active As String = "ACTIVE"
			 Public Const DisableScanner As String = "DISABLE_SCANNER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Printerid As String = "Printerid"
			 Public Const LabelType As String = "LabelType"
			 Public Const PrinterIp As String = "PrinterIp"
			 Public Const PrinterUsername As String = "PrinterUsername"
			 Public Const PrinterPassword As String = "PrinterPassword"
			 Public Const PrinterName As String = "PrinterName"
			 Public Const Active As String = "Active"
			 Public Const DisableScanner As String = "DisableScanner"
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
            SyncLock GetType(LabelPrintersMetadata)
			
				If LabelPrintersMetadata.mapDelegates Is Nothing Then
					LabelPrintersMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LabelPrintersMetadata._meta Is Nothing Then
                    LabelPrintersMetadata._meta = New LabelPrintersMetadata()
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
				

				meta.AddTypeMap("Printerid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LabelType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PrinterIp", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PrinterUsername", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PrinterPassword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PrinterName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("DisableScanner", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "LABEL_PRINTERS"
				meta.Destination = "LABEL_PRINTERS"
				
				meta.spInsert = "proc_LABEL_PRINTERSInsert"
				meta.spUpdate = "proc_LABEL_PRINTERSUpdate"
				meta.spDelete = "proc_LABEL_PRINTERSDelete"
				meta.spLoadAll = "proc_LABEL_PRINTERSLoadAll"
				meta.spLoadByPrimaryKey = "proc_LABEL_PRINTERSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LabelPrintersMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
