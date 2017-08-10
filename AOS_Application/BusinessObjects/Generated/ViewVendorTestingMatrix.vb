'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 19-12-2014 17:58:05
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
	MustInherit Public Class esViewVendorTestingMatrixCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewVendorTestingMatrixCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewVendorTestingMatrixQuery)
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
            Me.InitQuery(CType(query, esViewVendorTestingMatrixQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewVendorTestingMatrix) As ViewVendorTestingMatrix
			Return CType(MyBase.DetachEntity(entity), ViewVendorTestingMatrix)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewVendorTestingMatrix) As ViewVendorTestingMatrix
			Return CType(MyBase.AttachEntity(entity), ViewVendorTestingMatrix)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewVendorTestingMatrixCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewVendorTestingMatrix
            Get
                Return TryCast(MyBase.Item(index), ViewVendorTestingMatrix)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewVendorTestingMatrix)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewVendorTestingMatrix	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewVendorTestingMatrixQuery
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
												
						Case "Vendortestingmatrixid"
							Me.str.Vendortestingmatrixid = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Chemicalcategory"
							Me.str.Chemicalcategory = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Retainpercentage"
							Me.str.Retainpercentage = CType(value, string)
												
						Case "Testpercentage"
							Me.str.Testpercentage = CType(value, string)
												
						Case "Ph"
							Me.str.Ph = CType(value, string)
												
						Case "Sg"
							Me.str.Sg = CType(value, string)
												
						Case "Color"
							Me.str.Color = CType(value, string)
												
						Case "Appearance"
							Me.str.Appearance = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Vendortestingmatrixid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendortestingmatrixid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Retainpercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Retainpercentage = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Testpercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Testpercentage = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Ph"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Ph = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Sg"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Sg = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Color"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Color = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Appearance"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Appearance = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewVendorTestingMatrix.VENDORTESTINGMATRIXID
		' </summary>
		Public Overridable Property Vendortestingmatrixid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Vendortestingmatrixid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Vendortestingmatrixid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.CHEMICALCATEGORY
		' </summary>
		Public Overridable Property Chemicalcategory As System.String
			Get
				Return MyBase.GetSystemString(ViewVendorTestingMatrixMetadata.ColumnNames.Chemicalcategory)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewVendorTestingMatrixMetadata.ColumnNames.Chemicalcategory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewVendorTestingMatrixMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewVendorTestingMatrixMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.RETAINPERCENTAGE
		' </summary>
		Public Overridable Property Retainpercentage As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Retainpercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Retainpercentage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.TESTPERCENTAGE
		' </summary>
		Public Overridable Property Testpercentage As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Testpercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewVendorTestingMatrixMetadata.ColumnNames.Testpercentage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.PH
		' </summary>
		Public Overridable Property Ph As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Ph)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Ph, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.SG
		' </summary>
		Public Overridable Property Sg As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Sg)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Sg, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.COLOR
		' </summary>
		Public Overridable Property Color As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Color)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Color, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.APPEARANCE
		' </summary>
		Public Overridable Property Appearance As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Appearance)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Appearance, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewVendorTestingMatrix.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewVendorTestingMatrixMetadata.ColumnNames.Isactive, value)
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
		
			Public Sub New(ByVal entity As esViewVendorTestingMatrix)
				Me.entity = entity
			End Sub				
		
	
			Public Property Vendortestingmatrixid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendortestingmatrixid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendortestingmatrixid = Nothing
					Else
						entity.Vendortestingmatrixid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendorid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorid = Nothing
					Else
						entity.Vendorid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalcategory As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalcategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalcategory = Nothing
					Else
						entity.Chemicalcategory = Convert.ToString(Value)
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
		  	
			Public Property Retainpercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Retainpercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Retainpercentage = Nothing
					Else
						entity.Retainpercentage = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Testpercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Testpercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Testpercentage = Nothing
					Else
						entity.Testpercentage = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ph As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Ph
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ph = Nothing
					Else
						entity.Ph = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sg As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Sg
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sg = Nothing
					Else
						entity.Sg = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Color As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Color
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Color = Nothing
					Else
						entity.Color = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appearance As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Appearance
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appearance = Nothing
					Else
						entity.Appearance = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isactive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isactive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isactive = Nothing
					Else
						entity.Isactive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewVendorTestingMatrix
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewVendorTestingMatrixQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewVendorTestingMatrix can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewVendorTestingMatrixQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewVendorTestingMatrixMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Vendortestingmatrixid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Vendortestingmatrixid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalcategory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Chemicalcategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Retainpercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Retainpercentage, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Testpercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Testpercentage, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Ph As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Ph, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Sg As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Sg, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Color As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Color, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Appearance As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Appearance, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, ViewVendorTestingMatrixMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewVendorTestingMatrixCollection")> _
	Partial Public Class ViewVendorTestingMatrixCollection
		Inherits esViewVendorTestingMatrixCollection
		Implements IEnumerable(Of ViewVendorTestingMatrix)
		
        Public Shared Widening Operator CType(ByVal coll As ViewVendorTestingMatrixCollection) As List(Of ViewVendorTestingMatrix)
            Dim list As List(Of ViewVendorTestingMatrix) = New List(Of ViewVendorTestingMatrix)
            Dim emp As ViewVendorTestingMatrix

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewVendorTestingMatrixMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewVendorTestingMatrixQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewVendorTestingMatrix(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewVendorTestingMatrix()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewVendorTestingMatrixQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewVendorTestingMatrixQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewVendorTestingMatrixQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewVendorTestingMatrix 
			Return CType(MyBase.AddNewEntity(), ViewVendorTestingMatrix)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewVendorTestingMatrix) Implements IEnumerable(Of ViewVendorTestingMatrix).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewVendorTestingMatrix)(Me)
        End Function
		
		Private _query As ViewVendorTestingMatrixQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewVendorTestingMatrix' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewVendorTestingMatrix ()")> _
	<Serializable> _
	Partial Public Class ViewVendorTestingMatrix 
		Inherits esViewVendorTestingMatrix

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewVendorTestingMatrixMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewVendorTestingMatrixQuery

			If Me._query Is Nothing Then
				Me._query = New ViewVendorTestingMatrixQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewVendorTestingMatrixQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewVendorTestingMatrixQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewVendorTestingMatrixQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewVendorTestingMatrixQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewVendorTestingMatrixQuery
		inherits esViewVendorTestingMatrixQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewVendorTestingMatrixQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewVendorTestingMatrixMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Vendortestingmatrixid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Vendortestingmatrixid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Vendorid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Chemicalcategory, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Chemicalcategory
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Productid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Productdesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Retainpercentage, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Retainpercentage
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Testpercentage, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Testpercentage
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Ph, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Ph
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Sg, 8, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Sg
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Color, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Color
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Appearance, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Appearance
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewVendorTestingMatrixMetadata.ColumnNames.Isactive, 11, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewVendorTestingMatrixMetadata.PropertyNames.Isactive
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewVendorTestingMatrixMetadata
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
			 Public Const Vendortestingmatrixid As String = "VENDORTESTINGMATRIXID"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Chemicalcategory As String = "CHEMICALCATEGORY"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Retainpercentage As String = "RETAINPERCENTAGE"
			 Public Const Testpercentage As String = "TESTPERCENTAGE"
			 Public Const Ph As String = "PH"
			 Public Const Sg As String = "SG"
			 Public Const Color As String = "COLOR"
			 Public Const Appearance As String = "APPEARANCE"
			 Public Const Isactive As String = "ISACTIVE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Vendortestingmatrixid As String = "Vendortestingmatrixid"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Chemicalcategory As String = "Chemicalcategory"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Retainpercentage As String = "Retainpercentage"
			 Public Const Testpercentage As String = "Testpercentage"
			 Public Const Ph As String = "Ph"
			 Public Const Sg As String = "Sg"
			 Public Const Color As String = "Color"
			 Public Const Appearance As String = "Appearance"
			 Public Const Isactive As String = "Isactive"
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
            SyncLock GetType(ViewVendorTestingMatrixMetadata)
			
				If ViewVendorTestingMatrixMetadata.mapDelegates Is Nothing Then
					ViewVendorTestingMatrixMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewVendorTestingMatrixMetadata._meta Is Nothing Then
                    ViewVendorTestingMatrixMetadata._meta = New ViewVendorTestingMatrixMetadata()
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
				

				meta.AddTypeMap("Vendortestingmatrixid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalcategory", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Retainpercentage", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Testpercentage", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Ph", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Sg", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Color", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Appearance", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "viewVendorTestingMatrix"
				meta.Destination = "viewVendorTestingMatrix"
				
				meta.spInsert = "proc_viewVendorTestingMatrixInsert"
				meta.spUpdate = "proc_viewVendorTestingMatrixUpdate"
				meta.spDelete = "proc_viewVendorTestingMatrixDelete"
				meta.spLoadAll = "proc_viewVendorTestingMatrixLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewVendorTestingMatrixLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewVendorTestingMatrixMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
