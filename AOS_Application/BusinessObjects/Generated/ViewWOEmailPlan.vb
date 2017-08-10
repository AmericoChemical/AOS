'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/1/2016 2:14:10 PM
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
	MustInherit Public Class esViewWOEmailPlanCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWOEmailPlanCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWOEmailPlanQuery)
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
            Me.InitQuery(CType(query, esViewWOEmailPlanQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWOEmailPlan) As ViewWOEmailPlan
			Return CType(MyBase.DetachEntity(entity), ViewWOEmailPlan)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWOEmailPlan) As ViewWOEmailPlan
			Return CType(MyBase.AttachEntity(entity), ViewWOEmailPlan)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWOEmailPlanCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWOEmailPlan
            Get
                Return TryCast(MyBase.Item(index), ViewWOEmailPlan)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWOEmailPlan)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWOEmailPlan	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWOEmailPlanQuery
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
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Totalproductqty"
							Me.str.Totalproductqty = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Totalfulfillmentqty"
							Me.str.Totalfulfillmentqty = CType(value, string)
												
						Case "Rlblsourcertype"
							Me.str.Rlblsourcertype = CType(value, string)
												
						Case "Rlblproductid"
							Me.str.Rlblproductid = CType(value, string)
												
						Case "Rlblproductdesc"
							Me.str.Rlblproductdesc = CType(value, string)
												
						Case "Rlblcontainer"
							Me.str.Rlblcontainer = CType(value, string)
												
						Case "Rlblqty"
							Me.str.Rlblqty = CType(value, string)
												
						Case "Fulfillmenttypeid"
							Me.str.Fulfillmenttypeid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Totalproductqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Totalproductqty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Totalfulfillmentqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Totalfulfillmentqty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Rlblproductid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rlblproductid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rlblqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rlblqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Fulfillmenttypeid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fulfillmenttypeid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewWOEmailPlan.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.TOTALPRODUCTQTY
		' </summary>
		Public Overridable Property Totalproductqty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWOEmailPlanMetadata.ColumnNames.Totalproductqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWOEmailPlanMetadata.ColumnNames.Totalproductqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.TOTALFULFILLMENTQTY
		' </summary>
		Public Overridable Property Totalfulfillmentqty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWOEmailPlanMetadata.ColumnNames.Totalfulfillmentqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWOEmailPlanMetadata.ColumnNames.Totalfulfillmentqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.RLBLSOURCERTYPE
		' </summary>
		Public Overridable Property Rlblsourcertype As System.String
			Get
				Return MyBase.GetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Rlblsourcertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Rlblsourcertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.RLBLPRODUCTID
		' </summary>
		Public Overridable Property Rlblproductid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Rlblproductid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Rlblproductid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.RLBLPRODUCTDESC
		' </summary>
		Public Overridable Property Rlblproductdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Rlblproductdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Rlblproductdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.RLBLCONTAINER
		' </summary>
		Public Overridable Property Rlblcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Rlblcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWOEmailPlanMetadata.ColumnNames.Rlblcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.RLBLQTY
		' </summary>
		Public Overridable Property Rlblqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Rlblqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Rlblqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailPlan.FULFILLMENTTYPEID
		' </summary>
		Public Overridable Property Fulfillmenttypeid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Fulfillmenttypeid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailPlanMetadata.ColumnNames.Fulfillmenttypeid, value)
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
		
			Public Sub New(ByVal entity As esViewWOEmailPlan)
				Me.entity = entity
			End Sub				
		
	
			Public Property Workordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordernumber = Nothing
					Else
						entity.Workordernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemtype As System.String 
				Get
					Dim data_ As System.String = entity.Itemtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemtype = Nothing
					Else
						entity.Itemtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Itemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemid = Nothing
					Else
						entity.Itemid = Convert.ToInt32(Value)
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
		  	
			Public Property Itemdescription As System.String 
				Get
					Dim data_ As System.String = entity.Itemdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemdescription = Nothing
					Else
						entity.Itemdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Totalproductqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Totalproductqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalproductqty = Nothing
					Else
						entity.Totalproductqty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcetype As System.String 
				Get
					Dim data_ As System.String = entity.Sourcetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcetype = Nothing
					Else
						entity.Sourcetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcedocument As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedocument
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedocument = Nothing
					Else
						entity.Sourcedocument = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Totalfulfillmentqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Totalfulfillmentqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalfulfillmentqty = Nothing
					Else
						entity.Totalfulfillmentqty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblsourcertype As System.String 
				Get
					Dim data_ As System.String = entity.Rlblsourcertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblsourcertype = Nothing
					Else
						entity.Rlblsourcertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblproductid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rlblproductid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblproductid = Nothing
					Else
						entity.Rlblproductid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblproductdesc As System.String 
				Get
					Dim data_ As System.String = entity.Rlblproductdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblproductdesc = Nothing
					Else
						entity.Rlblproductdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Rlblcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblcontainer = Nothing
					Else
						entity.Rlblcontainer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rlblqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblqty = Nothing
					Else
						entity.Rlblqty = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fulfillmenttypeid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fulfillmenttypeid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulfillmenttypeid = Nothing
					Else
						entity.Fulfillmenttypeid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWOEmailPlan
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWOEmailPlanQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWOEmailPlan can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWOEmailPlanQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWOEmailPlanMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Totalproductqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Totalproductqty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalfulfillmentqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Totalfulfillmentqty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblsourcertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Rlblsourcertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblproductid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Rlblproductid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblproductdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Rlblproductdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Rlblcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Rlblqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fulfillmenttypeid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailPlanMetadata.ColumnNames.Fulfillmenttypeid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWOEmailPlanCollection")> _
	Partial Public Class ViewWOEmailPlanCollection
		Inherits esViewWOEmailPlanCollection
		Implements IEnumerable(Of ViewWOEmailPlan)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWOEmailPlanCollection) As List(Of ViewWOEmailPlan)
            Dim list As List(Of ViewWOEmailPlan) = New List(Of ViewWOEmailPlan)
            Dim emp As ViewWOEmailPlan

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWOEmailPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWOEmailPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWOEmailPlan(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWOEmailPlan()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWOEmailPlanQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWOEmailPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWOEmailPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWOEmailPlan 
			Return CType(MyBase.AddNewEntity(), ViewWOEmailPlan)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWOEmailPlan) Implements IEnumerable(Of ViewWOEmailPlan).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWOEmailPlan)(Me)
        End Function
		
		Private _query As ViewWOEmailPlanQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWOEmailPlan' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWOEmailPlan ()")> _
	<Serializable> _
	Partial Public Class ViewWOEmailPlan 
		Inherits esViewWOEmailPlan

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWOEmailPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWOEmailPlanQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWOEmailPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWOEmailPlanQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWOEmailPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWOEmailPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWOEmailPlanQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWOEmailPlanQuery
		inherits esViewWOEmailPlanQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWOEmailPlanQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWOEmailPlanMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Itemtype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Itemid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Itemdescription, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Totalproductqty, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Totalproductqty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Sourcetype, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Sourcedocument, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Totalfulfillmentqty, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Totalfulfillmentqty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Rlblsourcertype, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Rlblsourcertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Rlblproductid, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Rlblproductid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Rlblproductdesc, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Rlblproductdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Rlblcontainer, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Rlblcontainer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Rlblqty, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Rlblqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailPlanMetadata.ColumnNames.Fulfillmenttypeid, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailPlanMetadata.PropertyNames.Fulfillmenttypeid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWOEmailPlanMetadata
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
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Container As String = "CONTAINER"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Totalproductqty As String = "TOTALPRODUCTQTY"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Totalfulfillmentqty As String = "TOTALFULFILLMENTQTY"
			 Public Const Rlblsourcertype As String = "RLBLSOURCERTYPE"
			 Public Const Rlblproductid As String = "RLBLPRODUCTID"
			 Public Const Rlblproductdesc As String = "RLBLPRODUCTDESC"
			 Public Const Rlblcontainer As String = "RLBLCONTAINER"
			 Public Const Rlblqty As String = "RLBLQTY"
			 Public Const Fulfillmenttypeid As String = "FULFILLMENTTYPEID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Itemid As String = "Itemid"
			 Public Const Container As String = "Container"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Totalproductqty As String = "Totalproductqty"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Totalfulfillmentqty As String = "Totalfulfillmentqty"
			 Public Const Rlblsourcertype As String = "Rlblsourcertype"
			 Public Const Rlblproductid As String = "Rlblproductid"
			 Public Const Rlblproductdesc As String = "Rlblproductdesc"
			 Public Const Rlblcontainer As String = "Rlblcontainer"
			 Public Const Rlblqty As String = "Rlblqty"
			 Public Const Fulfillmenttypeid As String = "Fulfillmenttypeid"
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
            SyncLock GetType(ViewWOEmailPlanMetadata)
			
				If ViewWOEmailPlanMetadata.mapDelegates Is Nothing Then
					ViewWOEmailPlanMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWOEmailPlanMetadata._meta Is Nothing Then
                    ViewWOEmailPlanMetadata._meta = New ViewWOEmailPlanMetadata()
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
				

				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Totalproductqty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Totalfulfillmentqty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Rlblsourcertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rlblproductid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rlblproductdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rlblcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rlblqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fulfillmenttypeid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewWOEmailPlan"
				meta.Destination = "viewWOEmailPlan"
				
				meta.spInsert = "proc_viewWOEmailPlanInsert"
				meta.spUpdate = "proc_viewWOEmailPlanUpdate"
				meta.spDelete = "proc_viewWOEmailPlanDelete"
				meta.spLoadAll = "proc_viewWOEmailPlanLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWOEmailPlanLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWOEmailPlanMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
