'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/16/2018 1:59:42 PM
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
	MustInherit Public Class esViewPrimeListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewPrimeListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewPrimeListQuery)
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
            Me.InitQuery(CType(query, esViewPrimeListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewPrimeList) As ViewPrimeList
			Return CType(MyBase.DetachEntity(entity), ViewPrimeList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewPrimeList) As ViewPrimeList
			Return CType(MyBase.AttachEntity(entity), ViewPrimeList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewPrimeListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewPrimeList
            Get
                Return TryCast(MyBase.Item(index), ViewPrimeList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewPrimeList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewPrimeList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewPrimeListQuery
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
												
						Case "Fillwgt"
							Me.str.Fillwgt = CType(value, string)
												
						Case "Monthvol"
							Me.str.Monthvol = CType(value, string)
												
						Case "Matid"
							Me.str.Matid = CType(value, string)
												
						Case "Matname"
							Me.str.Matname = CType(value, string)
												
						Case "RMPerc"
							Me.str.RMPerc = CType(value, string)
												
						Case "CntWgt"
							Me.str.CntWgt = CType(value, string)
												
						Case "MonthlyWgt"
							Me.str.MonthlyWgt = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Productid = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Fillwgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Fillwgt = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Monthvol"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Monthvol = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Matid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Matid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "RMPerc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RMPerc = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "CntWgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.CntWgt = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "MonthlyWgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MonthlyWgt = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewPrimeList.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewPrimeListMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewPrimeListMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPrimeList.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewPrimeListMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPrimeListMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPrimeList.FILLWGT
		' </summary>
		Public Overridable Property Fillwgt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewPrimeListMetadata.ColumnNames.Fillwgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewPrimeListMetadata.ColumnNames.Fillwgt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPrimeList.MONTHVOL
		' </summary>
		Public Overridable Property Monthvol As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewPrimeListMetadata.ColumnNames.Monthvol)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewPrimeListMetadata.ColumnNames.Monthvol, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPrimeList.MATID
		' </summary>
		Public Overridable Property Matid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPrimeListMetadata.ColumnNames.Matid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPrimeListMetadata.ColumnNames.Matid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPrimeList.MATNAME
		' </summary>
		Public Overridable Property Matname As System.String
			Get
				Return MyBase.GetSystemString(ViewPrimeListMetadata.ColumnNames.Matname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPrimeListMetadata.ColumnNames.Matname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPrimeList.RMPerc
		' </summary>
		Public Overridable Property RMPerc As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPrimeListMetadata.ColumnNames.RMPerc)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPrimeListMetadata.ColumnNames.RMPerc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPrimeList.CntWgt
		' </summary>
		Public Overridable Property CntWgt As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPrimeListMetadata.ColumnNames.CntWgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPrimeListMetadata.ColumnNames.CntWgt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPrimeList.MonthlyWgt
		' </summary>
		Public Overridable Property MonthlyWgt As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPrimeListMetadata.ColumnNames.MonthlyWgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPrimeListMetadata.ColumnNames.MonthlyWgt, value)
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
		
			Public Sub New(ByVal entity As esViewPrimeList)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Fillwgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Fillwgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fillwgt = Nothing
					Else
						entity.Fillwgt = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Monthvol As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Monthvol
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Monthvol = Nothing
					Else
						entity.Monthvol = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Matid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Matid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Matid = Nothing
					Else
						entity.Matid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Matname As System.String 
				Get
					Dim data_ As System.String = entity.Matname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Matname = Nothing
					Else
						entity.Matname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMPerc As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RMPerc
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMPerc = Nothing
					Else
						entity.RMPerc = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property CntWgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.CntWgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CntWgt = Nothing
					Else
						entity.CntWgt = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property MonthlyWgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MonthlyWgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MonthlyWgt = Nothing
					Else
						entity.MonthlyWgt = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewPrimeList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewPrimeListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewPrimeList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewPrimeListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPrimeListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.Productid, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fillwgt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.Fillwgt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Monthvol As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.Monthvol, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Matid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.Matid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Matname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.Matname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RMPerc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.RMPerc, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property CntWgt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.CntWgt, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MonthlyWgt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPrimeListMetadata.ColumnNames.MonthlyWgt, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewPrimeListCollection")> _
	Partial Public Class ViewPrimeListCollection
		Inherits esViewPrimeListCollection
		Implements IEnumerable(Of ViewPrimeList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewPrimeListCollection) As List(Of ViewPrimeList)
            Dim list As List(Of ViewPrimeList) = New List(Of ViewPrimeList)
            Dim emp As ViewPrimeList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPrimeListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewPrimeListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewPrimeList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewPrimeList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewPrimeListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewPrimeListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPrimeListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewPrimeList 
			Return CType(MyBase.AddNewEntity(), ViewPrimeList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewPrimeList) Implements IEnumerable(Of ViewPrimeList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewPrimeList)(Me)
        End Function
		
		Private _query As ViewPrimeListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewPrimeList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewPrimeList ()")> _
	<Serializable> _
	Partial Public Class ViewPrimeList 
		Inherits esViewPrimeList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewPrimeListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewPrimeListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewPrimeListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewPrimeListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewPrimeListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPrimeListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewPrimeListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewPrimeListQuery
		inherits esViewPrimeListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewPrimeListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewPrimeListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.Productid, 0, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.Productid
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.Fillwgt, 2, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.Fillwgt
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.Monthvol, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.Monthvol
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.Matid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.Matid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.Matname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.Matname
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.RMPerc, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.RMPerc
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.CntWgt, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.CntWgt
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPrimeListMetadata.ColumnNames.MonthlyWgt, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPrimeListMetadata.PropertyNames.MonthlyWgt
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewPrimeListMetadata
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
			 Public Const Fillwgt As String = "FILLWGT"
			 Public Const Monthvol As String = "MONTHVOL"
			 Public Const Matid As String = "MATID"
			 Public Const Matname As String = "MATNAME"
			 Public Const RMPerc As String = "RMPerc"
			 Public Const CntWgt As String = "CntWgt"
			 Public Const MonthlyWgt As String = "MonthlyWgt"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Fillwgt As String = "Fillwgt"
			 Public Const Monthvol As String = "Monthvol"
			 Public Const Matid As String = "Matid"
			 Public Const Matname As String = "Matname"
			 Public Const RMPerc As String = "RMPerc"
			 Public Const CntWgt As String = "CntWgt"
			 Public Const MonthlyWgt As String = "MonthlyWgt"
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
            SyncLock GetType(ViewPrimeListMetadata)
			
				If ViewPrimeListMetadata.mapDelegates Is Nothing Then
					ViewPrimeListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewPrimeListMetadata._meta Is Nothing Then
                    ViewPrimeListMetadata._meta = New ViewPrimeListMetadata()
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
				

				meta.AddTypeMap("Productid", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Productdesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fillwgt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Monthvol", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Matid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Matname", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RMPerc", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("CntWgt", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("MonthlyWgt", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewPrimeList"
				meta.Destination = "viewPrimeList"
				
				meta.spInsert = "proc_viewPrimeListInsert"
				meta.spUpdate = "proc_viewPrimeListUpdate"
				meta.spDelete = "proc_viewPrimeListDelete"
				meta.spLoadAll = "proc_viewPrimeListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewPrimeListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewPrimeListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
