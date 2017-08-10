'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/24/2015 3:42:44 PM
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
	MustInherit Public Class esViewProductionOrderMaterialTransactionsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProductionOrderMaterialTransactionsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProductionOrderMaterialTransactionsQuery)
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
            Me.InitQuery(CType(query, esViewProductionOrderMaterialTransactionsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProductionOrderMaterialTransactions) As ViewProductionOrderMaterialTransactions
			Return CType(MyBase.DetachEntity(entity), ViewProductionOrderMaterialTransactions)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProductionOrderMaterialTransactions) As ViewProductionOrderMaterialTransactions
			Return CType(MyBase.AttachEntity(entity), ViewProductionOrderMaterialTransactions)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProductionOrderMaterialTransactionsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProductionOrderMaterialTransactions
            Get
                Return TryCast(MyBase.Item(index), ViewProductionOrderMaterialTransactions)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProductionOrderMaterialTransactions)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProductionOrderMaterialTransactions	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProductionOrderMaterialTransactionsQuery
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
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Prodorderdate"
							Me.str.Prodorderdate = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Productqty"
							Me.str.Productqty = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Completiontime"
							Me.str.Completiontime = CType(value, string)
												
						Case "Iscomplete"
							Me.str.Iscomplete = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Unitsused"
							Me.str.Unitsused = CType(value, string)
												
						Case "Rmid"
							Me.str.Rmid = CType(value, string)
												
						Case "RMDesc"
							Me.str.RMDesc = CType(value, string)
												
						Case "RMContainer"
							Me.str.RMContainer = CType(value, string)
												
						Case "RMLotNum"
							Me.str.RMLotNum = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Prodorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Completiontime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Completiontime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Iscomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Iscomplete = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitsused"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitsused = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Rmid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rmid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewProductionOrderMaterialTransactions.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.PRODORDERDATE
		' </summary>
		Public Overridable Property Prodorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Prodorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Prodorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.PRODUCTQTY
		' </summary>
		Public Overridable Property Productqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.COMPLETIONTIME
		' </summary>
		Public Overridable Property Completiontime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Completiontime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Completiontime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.ISCOMPLETE
		' </summary>
		Public Overridable Property Iscomplete As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Iscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Iscomplete, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.UNITSUSED
		' </summary>
		Public Overridable Property Unitsused As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Unitsused)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Unitsused, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.RMID
		' </summary>
		Public Overridable Property Rmid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Rmid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Rmid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.RMDesc
		' </summary>
		Public Overridable Property RMDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.RMContainer
		' </summary>
		Public Overridable Property RMContainer As System.String
			Get
				Return MyBase.GetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMContainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMContainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductionOrderMaterialTransactions.RMLotNum
		' </summary>
		Public Overridable Property RMLotNum As System.String
			Get
				Return MyBase.GetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMLotNum)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMLotNum, value)
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
		
			Public Sub New(ByVal entity As esViewProductionOrderMaterialTransactions)
				Me.entity = entity
			End Sub				
		
	
			Public Property Prodordernum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodordernum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodordernum = Nothing
					Else
						entity.Prodordernum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Prodorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodorderdate = Nothing
					Else
						entity.Prodorderdate = Convert.ToDateTime(Value)
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
		  	
			Public Property Productqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productqty = Nothing
					Else
						entity.Productqty = Convert.ToInt32(Value)
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
		  	
			Public Property Custname As System.String 
				Get
					Dim data_ As System.String = entity.Custname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custname = Nothing
					Else
						entity.Custname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lotnumber As System.String 
				Get
					Dim data_ As System.String = entity.Lotnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lotnumber = Nothing
					Else
						entity.Lotnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Completiontime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Completiontime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Completiontime = Nothing
					Else
						entity.Completiontime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Iscomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Iscomplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Iscomplete = Nothing
					Else
						entity.Iscomplete = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber
					
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
						entity.Invitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitsused As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitsused
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsused = Nothing
					Else
						entity.Unitsused = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rmid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rmid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rmid = Nothing
					Else
						entity.Rmid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMDesc As System.String 
				Get
					Dim data_ As System.String = entity.RMDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMDesc = Nothing
					Else
						entity.RMDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMContainer As System.String 
				Get
					Dim data_ As System.String = entity.RMContainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMContainer = Nothing
					Else
						entity.RMContainer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMLotNum As System.String 
				Get
					Dim data_ As System.String = entity.RMLotNum
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMLotNum = Nothing
					Else
						entity.RMLotNum = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewProductionOrderMaterialTransactions
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProductionOrderMaterialTransactionsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProductionOrderMaterialTransactions can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProductionOrderMaterialTransactionsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductionOrderMaterialTransactionsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Prodorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Completiontime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Completiontime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Iscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Iscomplete, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsused As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Unitsused, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Rmid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Rmid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RMDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RMContainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMContainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RMLotNum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMLotNum, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProductionOrderMaterialTransactionsCollection")> _
	Partial Public Class ViewProductionOrderMaterialTransactionsCollection
		Inherits esViewProductionOrderMaterialTransactionsCollection
		Implements IEnumerable(Of ViewProductionOrderMaterialTransactions)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProductionOrderMaterialTransactionsCollection) As List(Of ViewProductionOrderMaterialTransactions)
            Dim list As List(Of ViewProductionOrderMaterialTransactions) = New List(Of ViewProductionOrderMaterialTransactions)
            Dim emp As ViewProductionOrderMaterialTransactions

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductionOrderMaterialTransactionsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProductionOrderMaterialTransactionsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProductionOrderMaterialTransactions(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProductionOrderMaterialTransactions()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProductionOrderMaterialTransactionsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProductionOrderMaterialTransactionsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductionOrderMaterialTransactionsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProductionOrderMaterialTransactions 
			Return CType(MyBase.AddNewEntity(), ViewProductionOrderMaterialTransactions)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProductionOrderMaterialTransactions) Implements IEnumerable(Of ViewProductionOrderMaterialTransactions).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProductionOrderMaterialTransactions)(Me)
        End Function
		
		Private _query As ViewProductionOrderMaterialTransactionsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewProductionOrderMaterialTransactions' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProductionOrderMaterialTransactions ()")> _
	<Serializable> _
	Partial Public Class ViewProductionOrderMaterialTransactions 
		Inherits esViewProductionOrderMaterialTransactions

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProductionOrderMaterialTransactionsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProductionOrderMaterialTransactionsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewProductionOrderMaterialTransactionsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProductionOrderMaterialTransactionsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProductionOrderMaterialTransactionsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductionOrderMaterialTransactionsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProductionOrderMaterialTransactionsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProductionOrderMaterialTransactionsQuery
		inherits esViewProductionOrderMaterialTransactionsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProductionOrderMaterialTransactionsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProductionOrderMaterialTransactionsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Prodordernum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Prodorderdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Prodorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productdesc, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Container, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Productqty, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Productqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Custid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Custname, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Lotnumber, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Workordernumber, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Completiontime, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Completiontime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Iscomplete, 11, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Iscomplete
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Materialid, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Invitemnumber, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Unitsused, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Unitsused
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.Rmid, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.Rmid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMDesc, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.RMDesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMContainer, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.RMContainer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductionOrderMaterialTransactionsMetadata.ColumnNames.RMLotNum, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductionOrderMaterialTransactionsMetadata.PropertyNames.RMLotNum
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProductionOrderMaterialTransactionsMetadata
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
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Prodorderdate As String = "PRODORDERDATE"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Productqty As String = "PRODUCTQTY"
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Completiontime As String = "COMPLETIONTIME"
			 Public Const Iscomplete As String = "ISCOMPLETE"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Unitsused As String = "UNITSUSED"
			 Public Const Rmid As String = "RMID"
			 Public Const RMDesc As String = "RMDesc"
			 Public Const RMContainer As String = "RMContainer"
			 Public Const RMLotNum As String = "RMLotNum"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Prodorderdate As String = "Prodorderdate"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Productqty As String = "Productqty"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Completiontime As String = "Completiontime"
			 Public Const Iscomplete As String = "Iscomplete"
			 Public Const Materialid As String = "Materialid"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Unitsused As String = "Unitsused"
			 Public Const Rmid As String = "Rmid"
			 Public Const RMDesc As String = "RMDesc"
			 Public Const RMContainer As String = "RMContainer"
			 Public Const RMLotNum As String = "RMLotNum"
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
            SyncLock GetType(ViewProductionOrderMaterialTransactionsMetadata)
			
				If ViewProductionOrderMaterialTransactionsMetadata.mapDelegates Is Nothing Then
					ViewProductionOrderMaterialTransactionsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProductionOrderMaterialTransactionsMetadata._meta Is Nothing Then
                    ViewProductionOrderMaterialTransactionsMetadata._meta = New ViewProductionOrderMaterialTransactionsMetadata()
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
				

				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Completiontime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Iscomplete", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitsused", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Rmid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RMDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RMContainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RMLotNum", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewProductionOrderMaterialTransactions"
				meta.Destination = "viewProductionOrderMaterialTransactions"
				
				meta.spInsert = "proc_viewProductionOrderMaterialTransactionsInsert"
				meta.spUpdate = "proc_viewProductionOrderMaterialTransactionsUpdate"
				meta.spDelete = "proc_viewProductionOrderMaterialTransactionsDelete"
				meta.spLoadAll = "proc_viewProductionOrderMaterialTransactionsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProductionOrderMaterialTransactionsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProductionOrderMaterialTransactionsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
