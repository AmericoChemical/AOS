'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.1.0209.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/2/2011 1:56:49 PM
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
	MustInherit Public Class esFormulaCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "FormulaCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esFormulaQuery)
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
            Me.InitQuery(CType(query, esFormulaQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Formula) As Formula
			Return CType(MyBase.DetachEntity(entity), Formula)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Formula) As Formula
			Return CType(MyBase.AttachEntity(entity), Formula)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As FormulaCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Formula
            Get
                Return TryCast(MyBase.Item(index), Formula)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Formula)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esFormula	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esFormulaQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal formulaid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(formulaid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(formulaid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal formulaid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(formulaid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(formulaid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal formulaid As System.Int32) As Boolean
		
			Dim query As esFormulaQuery = Me.GetDynamicQuery()
			query.Where(query.Formulaid.Equal(formulaid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal formulaid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FORMULAID", formulaid)
			
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
												
						Case "Formulaid"
							Me.str.Formulaid = CType(value, string)
												
						Case "Formuladesc"
							Me.str.Formuladesc = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Qtycontainers"
							Me.str.Qtycontainers = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Formulanotes"
							Me.str.Formulanotes = CType(value, string)
												
						Case "Stdlaborhours"
							Me.str.Stdlaborhours = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Formulaid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Formulaid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtycontainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtycontainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdlaborhours"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Stdlaborhours = CType(value, Nullable(Of System.Double))
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
		' Maps to FORMULA.FORMULAID
		' </summary>
		Public Overridable Property Formulaid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulaMetadata.ColumnNames.Formulaid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulaMetadata.ColumnNames.Formulaid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULA.FORMULADESC
		' </summary>
		Public Overridable Property Formuladesc As System.String
			Get
				Return MyBase.GetSystemString(FormulaMetadata.ColumnNames.Formuladesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FormulaMetadata.ColumnNames.Formuladesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULA.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulaMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulaMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULA.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(FormulaMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FormulaMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULA.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulaMetadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulaMetadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULA.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulaMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulaMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULA.FORMULANOTES
		' </summary>
		Public Overridable Property Formulanotes As System.String
			Get
				Return MyBase.GetSystemString(FormulaMetadata.ColumnNames.Formulanotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FormulaMetadata.ColumnNames.Formulanotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULA.STDLABORHOURS
		' </summary>
		Public Overridable Property Stdlaborhours As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(FormulaMetadata.ColumnNames.Stdlaborhours)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(FormulaMetadata.ColumnNames.Stdlaborhours, value)
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
		
			Public Sub New(ByVal entity As esFormula)
				Me.entity = entity
			End Sub				
		
	
			Public Property Formulaid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Formulaid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Formulaid = Nothing
					Else
						entity.Formulaid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Formuladesc As System.String 
				Get
					Dim data_ As System.String = entity.Formuladesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Formuladesc = Nothing
					Else
						entity.Formuladesc = Convert.ToString(Value)
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
		  	
			Public Property Qtycontainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtycontainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtycontainers = Nothing
					Else
						entity.Qtycontainers = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Custid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custid = Nothing
					Else
						entity.Custid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Formulanotes As System.String 
				Get
					Dim data_ As System.String = entity.Formulanotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Formulanotes = Nothing
					Else
						entity.Formulanotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdlaborhours As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Stdlaborhours
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdlaborhours = Nothing
					Else
						entity.Stdlaborhours = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esFormula
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esFormulaQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esFormula can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esFormulaQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FormulaMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Formulaid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaMetadata.ColumnNames.Formulaid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Formuladesc As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaMetadata.ColumnNames.Formuladesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaMetadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Formulanotes As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaMetadata.ColumnNames.Formulanotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdlaborhours As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaMetadata.ColumnNames.Stdlaborhours, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("FormulaCollection")> _
	Partial Public Class FormulaCollection
		Inherits esFormulaCollection
		Implements IEnumerable(Of Formula)
		
        Public Shared Widening Operator CType(ByVal coll As FormulaCollection) As List(Of Formula)
            Dim list As List(Of Formula) = New List(Of Formula)
            Dim emp As Formula

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FormulaMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New FormulaQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Formula(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Formula()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As FormulaQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New FormulaQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FormulaQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Formula 
			Return CType(MyBase.AddNewEntity(), Formula)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal formulaid As System.Int32) As Formula
			Return CType(MyBase.FindByPrimaryKey(formulaid), Formula)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Formula) Implements IEnumerable(Of Formula).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Formula)(Me)
        End Function
		
		Private _query As FormulaQuery

	End Class
	


	' <summary>
	' Encapsulates the 'FORMULA' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Formula ({Formulaid.Value})")> _
	<Serializable> _
	Partial Public Class Formula 
		Inherits esFormula

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return FormulaMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esFormulaQuery

			If Me._query Is Nothing Then
				Me._query = New FormulaQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As FormulaQuery
			Get

				If Me._query Is Nothing then
					Me._query = New FormulaQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FormulaQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As FormulaQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class FormulaQuery
		inherits esFormulaQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
				

	End Class




	<Serializable> _
	Partial Public Class FormulaMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(FormulaMetadata.ColumnNames.Formulaid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulaMetadata.PropertyNames.Formulaid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaMetadata.ColumnNames.Formuladesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = FormulaMetadata.PropertyNames.Formuladesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulaMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = FormulaMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaMetadata.ColumnNames.Qtycontainers, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulaMetadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaMetadata.ColumnNames.Custid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulaMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaMetadata.ColumnNames.Formulanotes, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = FormulaMetadata.PropertyNames.Formulanotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaMetadata.ColumnNames.Stdlaborhours, 7, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = FormulaMetadata.PropertyNames.Stdlaborhours
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c) 
				
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As FormulaMetadata
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
			 Public Const Formulaid As String = "FORMULAID"
			 Public Const Formuladesc As String = "FORMULADESC"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Container As String = "CONTAINER"
			 Public Const Qtycontainers As String = "QTYCONTAINERS"
			 Public Const Custid As String = "CUSTID"
			 Public Const Formulanotes As String = "FORMULANOTES"
			 Public Const Stdlaborhours As String = "STDLABORHOURS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Formulaid As String = "Formulaid"
			 Public Const Formuladesc As String = "Formuladesc"
			 Public Const Productid As String = "Productid"
			 Public Const Container As String = "Container"
			 Public Const Qtycontainers As String = "Qtycontainers"
			 Public Const Custid As String = "Custid"
			 Public Const Formulanotes As String = "Formulanotes"
			 Public Const Stdlaborhours As String = "Stdlaborhours"
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
            SyncLock GetType(FormulaMetadata)
			
				If FormulaMetadata.mapDelegates Is Nothing Then
					FormulaMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If FormulaMetadata._meta Is Nothing Then
                    FormulaMetadata._meta = New FormulaMetadata()
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
				

				meta.AddTypeMap("FORMULAID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FORMULADESC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PRODUCTID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CONTAINER", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QTYCONTAINERS", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CUSTID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FORMULANOTES", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("STDLABORHOURS", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "FORMULA"
				meta.Destination = "FORMULA"
				
				meta.spInsert = "proc_FORMULAInsert"
				meta.spUpdate = "proc_FORMULAUpdate"
				meta.spDelete = "proc_FORMULADelete"
				meta.spLoadAll = "proc_FORMULALoadAll"
				meta.spLoadByPrimaryKey = "proc_FORMULALoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As FormulaMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
