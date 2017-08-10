'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:09 PM
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
	MustInherit Public Class esViewLoadItemsDisplayCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadItemsDisplayCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadItemsDisplayQuery)
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
            Me.InitQuery(CType(query, esViewLoadItemsDisplayQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadItemsDisplay) As ViewLoadItemsDisplay
			Return CType(MyBase.DetachEntity(entity), ViewLoadItemsDisplay)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadItemsDisplay) As ViewLoadItemsDisplay
			Return CType(MyBase.AttachEntity(entity), ViewLoadItemsDisplay)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadItemsDisplayCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadItemsDisplay
            Get
                Return TryCast(MyBase.Item(index), ViewLoadItemsDisplay)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadItemsDisplay)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadItemsDisplay	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadItemsDisplayQuery
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
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "ItemType"
							Me.str.ItemType = CType(value, string)
												
						Case "ItemID"
							Me.str.ItemID = CType(value, string)
												
						Case "ItemDescription"
							Me.str.ItemDescription = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "QtyContainers"
							Me.str.QtyContainers = CType(value, string)
												
						Case "TotalWeight"
							Me.str.TotalWeight = CType(value, string)
												
						Case "SourceType"
							Me.str.SourceType = CType(value, string)
												
						Case "SourceID"
							Me.str.SourceID = CType(value, string)
												
						Case "HazMatInfoLine"
							Me.str.HazMatInfoLine = CType(value, string)
												
						Case "Classrate"
							Me.str.Classrate = CType(value, string)
												
						Case "Weightunits"
							Me.str.Weightunits = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Unnumber"
							Me.str.Unnumber = CType(value, string)
												
						Case "Hazclassnumber"
							Me.str.Hazclassnumber = CType(value, string)
												
						Case "Packagegroup"
							Me.str.Packagegroup = CType(value, string)
												
						Case "Idnumber"
							Me.str.Idnumber = CType(value, string)
												
						Case "Sourcedoc"
							Me.str.Sourcedoc = CType(value, string)
												
						Case "LoadItemID"
							Me.str.LoadItemID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ItemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ItemID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QtyContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QtyContainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TotalWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalWeight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SourceID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SourceID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Weightunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Unnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sourcedoc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedoc = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadItemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadItemID = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewLoadItemsDisplay.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.ItemType
		' </summary>
		Public Overridable Property ItemType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.ItemType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.ItemType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.ItemID
		' </summary>
		Public Overridable Property ItemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.ItemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.ItemID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.ItemDescription
		' </summary>
		Public Overridable Property ItemDescription As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.ItemDescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.ItemDescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.Container
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.QtyContainers
		' </summary>
		Public Overridable Property QtyContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.QtyContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.QtyContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.TotalWeight
		' </summary>
		Public Overridable Property TotalWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.TotalWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.TotalWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.SourceType
		' </summary>
		Public Overridable Property SourceType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.SourceType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.SourceType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.SourceID
		' </summary>
		Public Overridable Property SourceID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.SourceID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.SourceID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.HazMatInfoLine
		' </summary>
		Public Overridable Property HazMatInfoLine As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.HazMatInfoLine)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.HazMatInfoLine, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.WEIGHTUNITS
		' </summary>
		Public Overridable Property Weightunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadItemsDisplayMetadata.ColumnNames.Weightunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadItemsDisplayMetadata.ColumnNames.Weightunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.UNNUMBER
		' </summary>
		Public Overridable Property Unnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.Unnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.Unnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.HAZCLASSNUMBER
		' </summary>
		Public Overridable Property Hazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Hazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Hazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.PACKAGEGROUP
		' </summary>
		Public Overridable Property Packagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Packagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Packagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.IDNUMBER
		' </summary>
		Public Overridable Property Idnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Idnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadItemsDisplayMetadata.ColumnNames.Idnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.SOURCEDOC
		' </summary>
		Public Overridable Property Sourcedoc As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.Sourcedoc)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.Sourcedoc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadItemsDisplay.LoadItemID
		' </summary>
		Public Overridable Property LoadItemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.LoadItemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadItemsDisplayMetadata.ColumnNames.LoadItemID, value)
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
		
			Public Sub New(ByVal entity As esViewLoadItemsDisplay)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property ItemType As System.String 
				Get
					Dim data_ As System.String = entity.ItemType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemType = Nothing
					Else
						entity.ItemType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ItemID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ItemID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemID = Nothing
					Else
						entity.ItemID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ItemDescription As System.String 
				Get
					Dim data_ As System.String = entity.ItemDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemDescription = Nothing
					Else
						entity.ItemDescription = Convert.ToString(Value)
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
		  	
			Public Property QtyContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QtyContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QtyContainers = Nothing
					Else
						entity.QtyContainers = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TotalWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalWeight = Nothing
					Else
						entity.TotalWeight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SourceType As System.String 
				Get
					Dim data_ As System.String = entity.SourceType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceType = Nothing
					Else
						entity.SourceType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SourceID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SourceID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceID = Nothing
					Else
						entity.SourceID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazMatInfoLine As System.String 
				Get
					Dim data_ As System.String = entity.HazMatInfoLine
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazMatInfoLine = Nothing
					Else
						entity.HazMatInfoLine = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Classrate As System.String 
				Get
					Dim data_ As System.String = entity.Classrate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Classrate = Nothing
					Else
						entity.Classrate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightunits = Nothing
					Else
						entity.Weightunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightuom As System.String 
				Get
					Dim data_ As System.String = entity.Weightuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightuom = Nothing
					Else
						entity.Weightuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Unnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unnumber = Nothing
					Else
						entity.Unnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazclassnumber As System.String 
				Get
					Dim data_ As System.String = entity.Hazclassnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazclassnumber = Nothing
					Else
						entity.Hazclassnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Packagegroup As System.String 
				Get
					Dim data_ As System.String = entity.Packagegroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Packagegroup = Nothing
					Else
						entity.Packagegroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Idnumber As System.String 
				Get
					Dim data_ As System.String = entity.Idnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Idnumber = Nothing
					Else
						entity.Idnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcedoc As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedoc
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedoc = Nothing
					Else
						entity.Sourcedoc = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadItemID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadItemID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadItemID = Nothing
					Else
						entity.LoadItemID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadItemsDisplay
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadItemsDisplayQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadItemsDisplay can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadItemsDisplayQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadItemsDisplayMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ItemType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.ItemType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.ItemID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ItemDescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.ItemDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QtyContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.QtyContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.TotalWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SourceType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.SourceType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SourceID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.SourceID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property HazMatInfoLine As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.HazMatInfoLine, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Weightunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Unnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Hazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Packagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Packagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Idnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Idnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedoc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.Sourcedoc, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadItemID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadItemsDisplayMetadata.ColumnNames.LoadItemID, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadItemsDisplayCollection")> _
	Partial Public Class ViewLoadItemsDisplayCollection
		Inherits esViewLoadItemsDisplayCollection
		Implements IEnumerable(Of ViewLoadItemsDisplay)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadItemsDisplayCollection) As List(Of ViewLoadItemsDisplay)
            Dim list As List(Of ViewLoadItemsDisplay) = New List(Of ViewLoadItemsDisplay)
            Dim emp As ViewLoadItemsDisplay

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadItemsDisplayMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadItemsDisplayQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadItemsDisplay(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadItemsDisplay()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadItemsDisplayQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadItemsDisplayQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadItemsDisplayQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadItemsDisplay 
			Return CType(MyBase.AddNewEntity(), ViewLoadItemsDisplay)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadItemsDisplay) Implements IEnumerable(Of ViewLoadItemsDisplay).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadItemsDisplay)(Me)
        End Function
		
		Private _query As ViewLoadItemsDisplayQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadItemsDisplay' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadItemsDisplay ()")> _
	<Serializable> _
	Partial Public Class ViewLoadItemsDisplay 
		Inherits esViewLoadItemsDisplay

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadItemsDisplayMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadItemsDisplayQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadItemsDisplayQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadItemsDisplayQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadItemsDisplayQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadItemsDisplayQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadItemsDisplayQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadItemsDisplayQuery
		inherits esViewLoadItemsDisplayQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadItemsDisplayQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadItemsDisplayMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.LoadID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.ItemType, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.ItemType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.ItemID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.ItemID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.ItemDescription, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.ItemDescription
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Container, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.QtyContainers, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.QtyContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.TotalWeight, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.TotalWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.SourceType, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.SourceType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.SourceID, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.SourceID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.HazMatInfoLine, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.HazMatInfoLine
			c.CharacterMaxLength = 602
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Classrate, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Weightunits, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Weightunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Weightuom, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Unnumber, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Unnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Hazclassnumber, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Hazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Packagegroup, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Packagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Idnumber, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Idnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.Sourcedoc, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.Sourcedoc
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadItemsDisplayMetadata.ColumnNames.LoadItemID, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadItemsDisplayMetadata.PropertyNames.LoadItemID
			c.NumericPrecision = 10
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadItemsDisplayMetadata
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
			 Public Const LoadID As String = "LoadID"
			 Public Const ItemType As String = "ItemType"
			 Public Const ItemID As String = "ItemID"
			 Public Const ItemDescription As String = "ItemDescription"
			 Public Const Container As String = "Container"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const TotalWeight As String = "TotalWeight"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceID As String = "SourceID"
			 Public Const HazMatInfoLine As String = "HazMatInfoLine"
			 Public Const Classrate As String = "CLASSRATE"
			 Public Const Weightunits As String = "WEIGHTUNITS"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Unnumber As String = "UNNUMBER"
			 Public Const Hazclassnumber As String = "HAZCLASSNUMBER"
			 Public Const Packagegroup As String = "PACKAGEGROUP"
			 Public Const Idnumber As String = "IDNUMBER"
			 Public Const Sourcedoc As String = "SOURCEDOC"
			 Public Const LoadItemID As String = "LoadItemID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadID As String = "LoadID"
			 Public Const ItemType As String = "ItemType"
			 Public Const ItemID As String = "ItemID"
			 Public Const ItemDescription As String = "ItemDescription"
			 Public Const Container As String = "Container"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const TotalWeight As String = "TotalWeight"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceID As String = "SourceID"
			 Public Const HazMatInfoLine As String = "HazMatInfoLine"
			 Public Const Classrate As String = "Classrate"
			 Public Const Weightunits As String = "Weightunits"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Unnumber As String = "Unnumber"
			 Public Const Hazclassnumber As String = "Hazclassnumber"
			 Public Const Packagegroup As String = "Packagegroup"
			 Public Const Idnumber As String = "Idnumber"
			 Public Const Sourcedoc As String = "Sourcedoc"
			 Public Const LoadItemID As String = "LoadItemID"
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
            SyncLock GetType(ViewLoadItemsDisplayMetadata)
			
				If ViewLoadItemsDisplayMetadata.mapDelegates Is Nothing Then
					ViewLoadItemsDisplayMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadItemsDisplayMetadata._meta Is Nothing Then
                    ViewLoadItemsDisplayMetadata._meta = New ViewLoadItemsDisplayMetadata()
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
				

				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ItemType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ItemID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ItemDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QtyContainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TotalWeight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SourceType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SourceID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("HazMatInfoLine", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Classrate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Hazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Packagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Idnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedoc", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadItemID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewLoadItemsDisplay"
				meta.Destination = "viewLoadItemsDisplay"
				
				meta.spInsert = "proc_viewLoadItemsDisplayInsert"
				meta.spUpdate = "proc_viewLoadItemsDisplayUpdate"
				meta.spDelete = "proc_viewLoadItemsDisplayDelete"
				meta.spLoadAll = "proc_viewLoadItemsDisplayLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadItemsDisplayLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadItemsDisplayMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
