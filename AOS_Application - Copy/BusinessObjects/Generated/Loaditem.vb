'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/28/2014 6:47:24 AM
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
	MustInherit Public Class esLoaditemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LoaditemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLoaditemQuery)
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
            Me.InitQuery(CType(query, esLoaditemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Loaditem) As Loaditem
			Return CType(MyBase.DetachEntity(entity), Loaditem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Loaditem) As Loaditem
			Return CType(MyBase.AttachEntity(entity), Loaditem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LoaditemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Loaditem
            Get
                Return TryCast(MyBase.Item(index), Loaditem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Loaditem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLoaditem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLoaditemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal loadItemID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(loadItemID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(loadItemID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal loadItemID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(loadItemID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(loadItemID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal loadItemID As System.Int32) As Boolean
		
			Dim query As esLoaditemQuery = Me.GetDynamicQuery()
			query.Where(query.LoadItemID.Equal(loadItemID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal loadItemID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LoadItemID", loadItemID)
			
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
												
						Case "LoadItemID"
							Me.str.LoadItemID = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "SourceType"
							Me.str.SourceType = CType(value, string)
												
						Case "SourceID"
							Me.str.SourceID = CType(value, string)
												
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
												
						Case "TotalVolume"
							Me.str.TotalVolume = CType(value, string)
												
						Case "VolumeUOM"
							Me.str.VolumeUOM = CType(value, string)
												
						Case "TotalWeight"
							Me.str.TotalWeight = CType(value, string)
												
						Case "WeightUOM"
							Me.str.WeightUOM = CType(value, string)
												
						Case "DOTIDNumber"
							Me.str.DOTIDNumber = CType(value, string)
												
						Case "HazmatID"
							Me.str.HazmatID = CType(value, string)
												
						Case "HazmatClass"
							Me.str.HazmatClass = CType(value, string)
												
						Case "HazmatPackageGroup"
							Me.str.HazmatPackageGroup = CType(value, string)
												
						Case "ClassRate"
							Me.str.ClassRate = CType(value, string)
												
						Case "DOTDesc"
							Me.str.DOTDesc = CType(value, string)
												
						Case "HazMatDesc"
							Me.str.HazMatDesc = CType(value, string)
												
						Case "UNLine"
							Me.str.UNLine = CType(value, string)
												
						Case "IsHazardous"
							Me.str.IsHazardous = CType(value, string)
												
						Case "PalletID"
							Me.str.PalletID = CType(value, string)
												
						Case "LoadItemNote"
							Me.str.LoadItemNote = CType(value, string)
												
						Case "Ld1"
							Me.str.Ld1 = CType(value, string)
												
						Case "Ld2"
							Me.str.Ld2 = CType(value, string)
												
						Case "Ld3"
							Me.str.Ld3 = CType(value, string)
												
						Case "CreatedTime"
							Me.str.CreatedTime = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "ModifiedTime"
							Me.str.ModifiedTime = CType(value, string)
												
						Case "ModifiedBy"
							Me.str.ModifiedBy = CType(value, string)
												
						Case "InvItemNumber"
							Me.str.InvItemNumber = CType(value, string)
												
						Case "LoadItemStatus"
							Me.str.LoadItemStatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadItemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadItemID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SourceID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SourceID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ItemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ItemID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QtyContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QtyContainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TotalVolume"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalVolume = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "TotalWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalWeight = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "HazmatID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.HazmatID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "IsHazardous"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsHazardous = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "PalletID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PalletID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CreatedTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CreatedTime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ModifiedTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ModifiedTime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "InvItemNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InvItemNumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to LOADITEM.LoadItemID
		' </summary>
		Public Overridable Property LoadItemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoaditemMetadata.ColumnNames.LoadItemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoaditemMetadata.ColumnNames.LoadItemID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoaditemMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoaditemMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.SourceType
		' </summary>
		Public Overridable Property SourceType As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.SourceType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.SourceType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.SourceID
		' </summary>
		Public Overridable Property SourceID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoaditemMetadata.ColumnNames.SourceID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoaditemMetadata.ColumnNames.SourceID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.ItemType
		' </summary>
		Public Overridable Property ItemType As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.ItemType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.ItemType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.ItemID
		' </summary>
		Public Overridable Property ItemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoaditemMetadata.ColumnNames.ItemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoaditemMetadata.ColumnNames.ItemID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.ItemDescription
		' </summary>
		Public Overridable Property ItemDescription As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.ItemDescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.ItemDescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.Container
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.QtyContainers
		' </summary>
		Public Overridable Property QtyContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoaditemMetadata.ColumnNames.QtyContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoaditemMetadata.ColumnNames.QtyContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.TotalVolume
		' </summary>
		Public Overridable Property TotalVolume As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LoaditemMetadata.ColumnNames.TotalVolume)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LoaditemMetadata.ColumnNames.TotalVolume, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.VolumeUOM
		' </summary>
		Public Overridable Property VolumeUOM As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.VolumeUOM)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.VolumeUOM, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.TotalWeight
		' </summary>
		Public Overridable Property TotalWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LoaditemMetadata.ColumnNames.TotalWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LoaditemMetadata.ColumnNames.TotalWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.WeightUOM
		' </summary>
		Public Overridable Property WeightUOM As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.WeightUOM)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.WeightUOM, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.DOTIDNumber
		' </summary>
		Public Overridable Property DOTIDNumber As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.DOTIDNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.DOTIDNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.HazmatID
		' </summary>
		Public Overridable Property HazmatID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoaditemMetadata.ColumnNames.HazmatID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoaditemMetadata.ColumnNames.HazmatID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.HazmatClass
		' </summary>
		Public Overridable Property HazmatClass As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.HazmatClass)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.HazmatClass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.HazmatPackageGroup
		' </summary>
		Public Overridable Property HazmatPackageGroup As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.HazmatPackageGroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.HazmatPackageGroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.ClassRate
		' </summary>
		Public Overridable Property ClassRate As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.ClassRate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.ClassRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.DOTDesc
		' </summary>
		Public Overridable Property DOTDesc As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.DOTDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.DOTDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.HazMatDesc
		' </summary>
		Public Overridable Property HazMatDesc As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.HazMatDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.HazMatDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.UNLine
		' </summary>
		Public Overridable Property UNLine As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.UNLine)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.UNLine, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.IsHazardous
		' </summary>
		Public Overridable Property IsHazardous As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LoaditemMetadata.ColumnNames.IsHazardous)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(LoaditemMetadata.ColumnNames.IsHazardous, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.PalletID
		' </summary>
		Public Overridable Property PalletID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoaditemMetadata.ColumnNames.PalletID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoaditemMetadata.ColumnNames.PalletID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.LoadItemNote
		' </summary>
		Public Overridable Property LoadItemNote As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.LoadItemNote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.LoadItemNote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.LD1
		' </summary>
		Public Overridable Property Ld1 As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.Ld1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.Ld1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.LD2
		' </summary>
		Public Overridable Property Ld2 As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.Ld2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.Ld2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.LD3
		' </summary>
		Public Overridable Property Ld3 As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.Ld3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.Ld3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.CreatedTime
		' </summary>
		Public Overridable Property CreatedTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LoaditemMetadata.ColumnNames.CreatedTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LoaditemMetadata.ColumnNames.CreatedTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.ModifiedTime
		' </summary>
		Public Overridable Property ModifiedTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LoaditemMetadata.ColumnNames.ModifiedTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LoaditemMetadata.ColumnNames.ModifiedTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.ModifiedBy
		' </summary>
		Public Overridable Property ModifiedBy As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.ModifiedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.ModifiedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.InvItemNumber
		' </summary>
		Public Overridable Property InvItemNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoaditemMetadata.ColumnNames.InvItemNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoaditemMetadata.ColumnNames.InvItemNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADITEM.LoadItemStatus
		' </summary>
		Public Overridable Property LoadItemStatus As System.String
			Get
				Return MyBase.GetSystemString(LoaditemMetadata.ColumnNames.LoadItemStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoaditemMetadata.ColumnNames.LoadItemStatus, value)
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
		
			Public Sub New(ByVal entity As esLoaditem)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property TotalVolume As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalVolume
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalVolume = Nothing
					Else
						entity.TotalVolume = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property VolumeUOM As System.String 
				Get
					Dim data_ As System.String = entity.VolumeUOM
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VolumeUOM = Nothing
					Else
						entity.VolumeUOM = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalWeight
					
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
						entity.TotalWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WeightUOM As System.String 
				Get
					Dim data_ As System.String = entity.WeightUOM
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WeightUOM = Nothing
					Else
						entity.WeightUOM = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DOTIDNumber As System.String 
				Get
					Dim data_ As System.String = entity.DOTIDNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DOTIDNumber = Nothing
					Else
						entity.DOTIDNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazmatID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.HazmatID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazmatID = Nothing
					Else
						entity.HazmatID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazmatClass As System.String 
				Get
					Dim data_ As System.String = entity.HazmatClass
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazmatClass = Nothing
					Else
						entity.HazmatClass = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazmatPackageGroup As System.String 
				Get
					Dim data_ As System.String = entity.HazmatPackageGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazmatPackageGroup = Nothing
					Else
						entity.HazmatPackageGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ClassRate As System.String 
				Get
					Dim data_ As System.String = entity.ClassRate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClassRate = Nothing
					Else
						entity.ClassRate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DOTDesc As System.String 
				Get
					Dim data_ As System.String = entity.DOTDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DOTDesc = Nothing
					Else
						entity.DOTDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazMatDesc As System.String 
				Get
					Dim data_ As System.String = entity.HazMatDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazMatDesc = Nothing
					Else
						entity.HazMatDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UNLine As System.String 
				Get
					Dim data_ As System.String = entity.UNLine
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UNLine = Nothing
					Else
						entity.UNLine = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsHazardous As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IsHazardous
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsHazardous = Nothing
					Else
						entity.IsHazardous = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property PalletID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PalletID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PalletID = Nothing
					Else
						entity.PalletID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadItemNote As System.String 
				Get
					Dim data_ As System.String = entity.LoadItemNote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadItemNote = Nothing
					Else
						entity.LoadItemNote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ld1 As System.String 
				Get
					Dim data_ As System.String = entity.Ld1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld1 = Nothing
					Else
						entity.Ld1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ld2 As System.String 
				Get
					Dim data_ As System.String = entity.Ld2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld2 = Nothing
					Else
						entity.Ld2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ld3 As System.String 
				Get
					Dim data_ As System.String = entity.Ld3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld3 = Nothing
					Else
						entity.Ld3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CreatedTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedTime = Nothing
					Else
						entity.CreatedTime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedBy As System.String 
				Get
					Dim data_ As System.String = entity.CreatedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedBy = Nothing
					Else
						entity.CreatedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifiedTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ModifiedTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifiedTime = Nothing
					Else
						entity.ModifiedTime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifiedBy As System.String 
				Get
					Dim data_ As System.String = entity.ModifiedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifiedBy = Nothing
					Else
						entity.ModifiedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InvItemNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InvItemNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvItemNumber = Nothing
					Else
						entity.InvItemNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadItemStatus As System.String 
				Get
					Dim data_ As System.String = entity.LoadItemStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadItemStatus = Nothing
					Else
						entity.LoadItemStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLoaditem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLoaditemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLoaditem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Loaditem 
		Inherits esLoaditem
		
	
		
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
	MustInherit Public Class esLoaditemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoaditemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadItemID As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.LoadItemID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SourceType As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.SourceType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SourceID As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.SourceID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ItemType As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.ItemType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemID As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.ItemID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ItemDescription As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.ItemDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QtyContainers As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.QtyContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TotalVolume As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.TotalVolume, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property VolumeUOM As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.VolumeUOM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWeight As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.TotalWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WeightUOM As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.WeightUOM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DOTIDNumber As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.DOTIDNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazmatID As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.HazmatID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property HazmatClass As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.HazmatClass, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazmatPackageGroup As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.HazmatPackageGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClassRate As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.ClassRate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DOTDesc As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.DOTDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazMatDesc As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.HazMatDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UNLine As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.UNLine, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IsHazardous As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.IsHazardous, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property PalletID As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.PalletID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadItemNote As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.LoadItemNote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld1 As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.Ld1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld2 As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.Ld2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld3 As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.Ld3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedTime As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.CreatedTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedTime As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.ModifiedTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedBy As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.ModifiedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InvItemNumber As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.InvItemNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadItemStatus As esQueryItem
			Get
				Return New esQueryItem(Me, LoaditemMetadata.ColumnNames.LoadItemStatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LoaditemCollection")> _
	Partial Public Class LoaditemCollection
		Inherits esLoaditemCollection
		Implements IEnumerable(Of Loaditem)
		
        Public Shared Widening Operator CType(ByVal coll As LoaditemCollection) As List(Of Loaditem)
            Dim list As List(Of Loaditem) = New List(Of Loaditem)
            Dim emp As Loaditem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoaditemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LoaditemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Loaditem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Loaditem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LoaditemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LoaditemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoaditemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Loaditem 
			Return CType(MyBase.AddNewEntity(), Loaditem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal loadItemID As System.Int32) As Loaditem
			Return CType(MyBase.FindByPrimaryKey(loadItemID), Loaditem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Loaditem) Implements IEnumerable(Of Loaditem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Loaditem)(Me)
        End Function
		
		Private _query As LoaditemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOADITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Loaditem ({LoadItemID.Value})")> _
	<Serializable> _
	Partial Public Class Loaditem 
		Inherits esLoaditem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LoaditemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLoaditemQuery

			If Me._query Is Nothing Then
				Me._query = New LoaditemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LoaditemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LoaditemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoaditemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LoaditemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LoaditemQuery
		inherits esLoaditemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LoaditemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LoaditemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.LoadItemID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoaditemMetadata.PropertyNames.LoadItemID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.LoadID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoaditemMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.SourceType, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.SourceType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.SourceID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoaditemMetadata.PropertyNames.SourceID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.ItemType, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.ItemType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.ItemID, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoaditemMetadata.PropertyNames.ItemID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.ItemDescription, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.ItemDescription
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.QtyContainers, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoaditemMetadata.PropertyNames.QtyContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.TotalVolume, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LoaditemMetadata.PropertyNames.TotalVolume
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.VolumeUOM, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.VolumeUOM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.TotalWeight, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LoaditemMetadata.PropertyNames.TotalWeight
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.WeightUOM, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.WeightUOM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.DOTIDNumber, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.DOTIDNumber
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.HazmatID, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoaditemMetadata.PropertyNames.HazmatID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.HazmatClass, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.HazmatClass
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.HazmatPackageGroup, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.HazmatPackageGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.ClassRate, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.ClassRate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.DOTDesc, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.DOTDesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.HazMatDesc, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.HazMatDesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.UNLine, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.UNLine
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.IsHazardous, 21, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LoaditemMetadata.PropertyNames.IsHazardous
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.PalletID, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoaditemMetadata.PropertyNames.PalletID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.LoadItemNote, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.LoadItemNote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.Ld1, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.Ld1
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.Ld2, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.Ld2
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.Ld3, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.Ld3
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.CreatedTime, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LoaditemMetadata.PropertyNames.CreatedTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.CreatedBy, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.ModifiedTime, 29, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LoaditemMetadata.PropertyNames.ModifiedTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.ModifiedBy, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.ModifiedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.InvItemNumber, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoaditemMetadata.PropertyNames.InvItemNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoaditemMetadata.ColumnNames.LoadItemStatus, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoaditemMetadata.PropertyNames.LoadItemStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LoaditemMetadata
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
			 Public Const LoadItemID As String = "LoadItemID"
			 Public Const LoadID As String = "LoadID"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceID As String = "SourceID"
			 Public Const ItemType As String = "ItemType"
			 Public Const ItemID As String = "ItemID"
			 Public Const ItemDescription As String = "ItemDescription"
			 Public Const Container As String = "Container"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const TotalVolume As String = "TotalVolume"
			 Public Const VolumeUOM As String = "VolumeUOM"
			 Public Const TotalWeight As String = "TotalWeight"
			 Public Const WeightUOM As String = "WeightUOM"
			 Public Const DOTIDNumber As String = "DOTIDNumber"
			 Public Const HazmatID As String = "HazmatID"
			 Public Const HazmatClass As String = "HazmatClass"
			 Public Const HazmatPackageGroup As String = "HazmatPackageGroup"
			 Public Const ClassRate As String = "ClassRate"
			 Public Const DOTDesc As String = "DOTDesc"
			 Public Const HazMatDesc As String = "HazMatDesc"
			 Public Const UNLine As String = "UNLine"
			 Public Const IsHazardous As String = "IsHazardous"
			 Public Const PalletID As String = "PalletID"
			 Public Const LoadItemNote As String = "LoadItemNote"
			 Public Const Ld1 As String = "LD1"
			 Public Const Ld2 As String = "LD2"
			 Public Const Ld3 As String = "LD3"
			 Public Const CreatedTime As String = "CreatedTime"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const ModifiedTime As String = "ModifiedTime"
			 Public Const ModifiedBy As String = "ModifiedBy"
			 Public Const InvItemNumber As String = "InvItemNumber"
			 Public Const LoadItemStatus As String = "LoadItemStatus"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadItemID As String = "LoadItemID"
			 Public Const LoadID As String = "LoadID"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceID As String = "SourceID"
			 Public Const ItemType As String = "ItemType"
			 Public Const ItemID As String = "ItemID"
			 Public Const ItemDescription As String = "ItemDescription"
			 Public Const Container As String = "Container"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const TotalVolume As String = "TotalVolume"
			 Public Const VolumeUOM As String = "VolumeUOM"
			 Public Const TotalWeight As String = "TotalWeight"
			 Public Const WeightUOM As String = "WeightUOM"
			 Public Const DOTIDNumber As String = "DOTIDNumber"
			 Public Const HazmatID As String = "HazmatID"
			 Public Const HazmatClass As String = "HazmatClass"
			 Public Const HazmatPackageGroup As String = "HazmatPackageGroup"
			 Public Const ClassRate As String = "ClassRate"
			 Public Const DOTDesc As String = "DOTDesc"
			 Public Const HazMatDesc As String = "HazMatDesc"
			 Public Const UNLine As String = "UNLine"
			 Public Const IsHazardous As String = "IsHazardous"
			 Public Const PalletID As String = "PalletID"
			 Public Const LoadItemNote As String = "LoadItemNote"
			 Public Const Ld1 As String = "Ld1"
			 Public Const Ld2 As String = "Ld2"
			 Public Const Ld3 As String = "Ld3"
			 Public Const CreatedTime As String = "CreatedTime"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const ModifiedTime As String = "ModifiedTime"
			 Public Const ModifiedBy As String = "ModifiedBy"
			 Public Const InvItemNumber As String = "InvItemNumber"
			 Public Const LoadItemStatus As String = "LoadItemStatus"
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
            SyncLock GetType(LoaditemMetadata)
			
				If LoaditemMetadata.mapDelegates Is Nothing Then
					LoaditemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LoaditemMetadata._meta Is Nothing Then
                    LoaditemMetadata._meta = New LoaditemMetadata()
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
				

				meta.AddTypeMap("LoadItemID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SourceType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SourceID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ItemType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ItemID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ItemDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QtyContainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TotalVolume", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("VolumeUOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalWeight", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("WeightUOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DOTIDNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HazmatID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("HazmatClass", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HazmatPackageGroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ClassRate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DOTDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HazMatDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("UNLine", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("IsHazardous", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("PalletID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadItemNote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CreatedTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ModifiedTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ModifiedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("InvItemNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadItemStatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LOADITEM"
				meta.Destination = "LOADITEM"
				
				meta.spInsert = "proc_LOADITEMInsert"
				meta.spUpdate = "proc_LOADITEMUpdate"
				meta.spDelete = "proc_LOADITEMDelete"
				meta.spLoadAll = "proc_LOADITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_LOADITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LoaditemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
