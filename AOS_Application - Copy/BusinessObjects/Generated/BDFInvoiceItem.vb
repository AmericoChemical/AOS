'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/18/2014 12:58:51 PM
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
	MustInherit Public Class esBDFInvoiceItemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "BDFInvoiceItemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esBDFInvoiceItemQuery)
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
            Me.InitQuery(CType(query, esBDFInvoiceItemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As BDFInvoiceItem) As BDFInvoiceItem
			Return CType(MyBase.DetachEntity(entity), BDFInvoiceItem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As BDFInvoiceItem) As BDFInvoiceItem
			Return CType(MyBase.AttachEntity(entity), BDFInvoiceItem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As BDFInvoiceItemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As BDFInvoiceItem
            Get
                Return TryCast(MyBase.Item(index), BDFInvoiceItem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(BDFInvoiceItem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esBDFInvoiceItem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esBDFInvoiceItemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal bDFInvoiceItemNumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(bDFInvoiceItemNumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(bDFInvoiceItemNumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal bDFInvoiceItemNumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(bDFInvoiceItemNumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(bDFInvoiceItemNumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal bDFInvoiceItemNumber As System.Int32) As Boolean
		
			Dim query As esBDFInvoiceItemQuery = Me.GetDynamicQuery()
			query.Where(query.BDFInvoiceItemNumber.Equal(bDFInvoiceItemNumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal bDFInvoiceItemNumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("BDFInvoiceItemNumber", bDFInvoiceItemNumber)
			
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
												
						Case "BDFInvoiceItemNumber"
							Me.str.BDFInvoiceItemNumber = CType(value, string)
												
						Case "BDFInvoiceNumber"
							Me.str.BDFInvoiceNumber = CType(value, string)
												
						Case "APBatchID"
							Me.str.APBatchID = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "Quantity"
							Me.str.Quantity = CType(value, string)
												
						Case "ServiceDesc"
							Me.str.ServiceDesc = CType(value, string)
												
						Case "Weight"
							Me.str.Weight = CType(value, string)
												
						Case "Rate"
							Me.str.Rate = CType(value, string)
												
						Case "ExtPrice"
							Me.str.ExtPrice = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "BDFInvoiceItemNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BDFInvoiceItemNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "BDFInvoiceNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BDFInvoiceNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "APBatchID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.APBatchID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Quantity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Quantity = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Weight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ExtPrice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ExtPrice = CType(value, Nullable(Of System.Decimal))
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
		' Maps to BDFInvoiceItem.BDFInvoiceItemNumber
		' </summary>
		Public Overridable Property BDFInvoiceItemNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.BDFInvoiceItemNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.BDFInvoiceItemNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoiceItem.BDFInvoiceNumber
		' </summary>
		Public Overridable Property BDFInvoiceNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.BDFInvoiceNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.BDFInvoiceNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoiceItem.APBatchID
		' </summary>
		Public Overridable Property APBatchID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.APBatchID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.APBatchID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoiceItem.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoiceItem.Quantity
		' </summary>
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BDFInvoiceItemMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(BDFInvoiceItemMetadata.ColumnNames.Quantity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoiceItem.ServiceDesc
		' </summary>
		Public Overridable Property ServiceDesc As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceItemMetadata.ColumnNames.ServiceDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceItemMetadata.ColumnNames.ServiceDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoiceItem.Weight
		' </summary>
		Public Overridable Property Weight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.Weight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(BDFInvoiceItemMetadata.ColumnNames.Weight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoiceItem.Rate
		' </summary>
		Public Overridable Property Rate As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceItemMetadata.ColumnNames.Rate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceItemMetadata.ColumnNames.Rate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoiceItem.ExtPrice
		' </summary>
		Public Overridable Property ExtPrice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BDFInvoiceItemMetadata.ColumnNames.ExtPrice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(BDFInvoiceItemMetadata.ColumnNames.ExtPrice, value)
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
		
			Public Sub New(ByVal entity As esBDFInvoiceItem)
				Me.entity = entity
			End Sub				
		
	
			Public Property BDFInvoiceItemNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BDFInvoiceItemNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BDFInvoiceItemNumber = Nothing
					Else
						entity.BDFInvoiceItemNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BDFInvoiceNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BDFInvoiceNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BDFInvoiceNumber = Nothing
					Else
						entity.BDFInvoiceNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property APBatchID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.APBatchID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APBatchID = Nothing
					Else
						entity.APBatchID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadID = Nothing
					Else
						entity.LoadID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Quantity As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Quantity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Quantity = Nothing
					Else
						entity.Quantity = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ServiceDesc As System.String 
				Get
					Dim data_ As System.String = entity.ServiceDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ServiceDesc = Nothing
					Else
						entity.ServiceDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Weight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weight = Nothing
					Else
						entity.Weight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rate As System.String 
				Get
					Dim data_ As System.String = entity.Rate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rate = Nothing
					Else
						entity.Rate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExtPrice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ExtPrice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExtPrice = Nothing
					Else
						entity.ExtPrice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBDFInvoiceItem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esBDFInvoiceItemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esBDFInvoiceItem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class BDFInvoiceItem 
		Inherits esBDFInvoiceItem
		
	
		
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
	MustInherit Public Class esBDFInvoiceItemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BDFInvoiceItemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property BDFInvoiceItemNumber As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.BDFInvoiceItemNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BDFInvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.BDFInvoiceNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property APBatchID As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.APBatchID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ServiceDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.ServiceDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weight As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.Weight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rate As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.Rate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExtPrice As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceItemMetadata.ColumnNames.ExtPrice, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("BDFInvoiceItemCollection")> _
	Partial Public Class BDFInvoiceItemCollection
		Inherits esBDFInvoiceItemCollection
		Implements IEnumerable(Of BDFInvoiceItem)
		
        Public Shared Widening Operator CType(ByVal coll As BDFInvoiceItemCollection) As List(Of BDFInvoiceItem)
            Dim list As List(Of BDFInvoiceItem) = New List(Of BDFInvoiceItem)
            Dim emp As BDFInvoiceItem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BDFInvoiceItemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New BDFInvoiceItemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New BDFInvoiceItem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New BDFInvoiceItem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As BDFInvoiceItemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New BDFInvoiceItemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As BDFInvoiceItemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As BDFInvoiceItem 
			Return CType(MyBase.AddNewEntity(), BDFInvoiceItem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal bDFInvoiceItemNumber As System.Int32) As BDFInvoiceItem
			Return CType(MyBase.FindByPrimaryKey(bDFInvoiceItemNumber), BDFInvoiceItem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of BDFInvoiceItem) Implements IEnumerable(Of BDFInvoiceItem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of BDFInvoiceItem)(Me)
        End Function
		
		Private _query As BDFInvoiceItemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'BDFInvoiceItem' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("BDFInvoiceItem ({BDFInvoiceItemNumber.Value})")> _
	<Serializable> _
	Partial Public Class BDFInvoiceItem 
		Inherits esBDFInvoiceItem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return BDFInvoiceItemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esBDFInvoiceItemQuery

			If Me._query Is Nothing Then
				Me._query = New BDFInvoiceItemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As BDFInvoiceItemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New BDFInvoiceItemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As BDFInvoiceItemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As BDFInvoiceItemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class BDFInvoiceItemQuery
		inherits esBDFInvoiceItemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "BDFInvoiceItemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class BDFInvoiceItemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.BDFInvoiceItemNumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.BDFInvoiceItemNumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.BDFInvoiceNumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.BDFInvoiceNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.APBatchID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.APBatchID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.LoadID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.Quantity, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.Quantity
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.ServiceDesc, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.ServiceDesc
			c.CharacterMaxLength = 300
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.Weight, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.Weight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.Rate, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.Rate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceItemMetadata.ColumnNames.ExtPrice, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BDFInvoiceItemMetadata.PropertyNames.ExtPrice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As BDFInvoiceItemMetadata
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
			 Public Const BDFInvoiceItemNumber As String = "BDFInvoiceItemNumber"
			 Public Const BDFInvoiceNumber As String = "BDFInvoiceNumber"
			 Public Const APBatchID As String = "APBatchID"
			 Public Const LoadID As String = "LoadID"
			 Public Const Quantity As String = "Quantity"
			 Public Const ServiceDesc As String = "ServiceDesc"
			 Public Const Weight As String = "Weight"
			 Public Const Rate As String = "Rate"
			 Public Const ExtPrice As String = "ExtPrice"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const BDFInvoiceItemNumber As String = "BDFInvoiceItemNumber"
			 Public Const BDFInvoiceNumber As String = "BDFInvoiceNumber"
			 Public Const APBatchID As String = "APBatchID"
			 Public Const LoadID As String = "LoadID"
			 Public Const Quantity As String = "Quantity"
			 Public Const ServiceDesc As String = "ServiceDesc"
			 Public Const Weight As String = "Weight"
			 Public Const Rate As String = "Rate"
			 Public Const ExtPrice As String = "ExtPrice"
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
            SyncLock GetType(BDFInvoiceItemMetadata)
			
				If BDFInvoiceItemMetadata.mapDelegates Is Nothing Then
					BDFInvoiceItemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If BDFInvoiceItemMetadata._meta Is Nothing Then
                    BDFInvoiceItemMetadata._meta = New BDFInvoiceItemMetadata()
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
				

				meta.AddTypeMap("BDFInvoiceItemNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BDFInvoiceNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("APBatchID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Quantity", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ServiceDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExtPrice", new esTypeMap("money", "System.Decimal"))			
				
				
				 
				meta.Source = "BDFInvoiceItem"
				meta.Destination = "BDFInvoiceItem"
				
				meta.spInsert = "proc_BDFInvoiceItemInsert"
				meta.spUpdate = "proc_BDFInvoiceItemUpdate"
				meta.spDelete = "proc_BDFInvoiceItemDelete"
				meta.spLoadAll = "proc_BDFInvoiceItemLoadAll"
				meta.spLoadByPrimaryKey = "proc_BDFInvoiceItemLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As BDFInvoiceItemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
