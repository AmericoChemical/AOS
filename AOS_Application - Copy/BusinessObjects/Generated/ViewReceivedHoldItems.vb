'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/1/2016 4:05:55 PM
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
	MustInherit Public Class esViewReceivedHoldItemsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewReceivedHoldItemsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewReceivedHoldItemsQuery)
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
            Me.InitQuery(CType(query, esViewReceivedHoldItemsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewReceivedHoldItems) As ViewReceivedHoldItems
			Return CType(MyBase.DetachEntity(entity), ViewReceivedHoldItems)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewReceivedHoldItems) As ViewReceivedHoldItems
			Return CType(MyBase.AttachEntity(entity), ViewReceivedHoldItems)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewReceivedHoldItemsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewReceivedHoldItems
            Get
                Return TryCast(MyBase.Item(index), ViewReceivedHoldItems)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewReceivedHoldItems)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewReceivedHoldItems	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewReceivedHoldItemsQuery
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
												
						Case "Recvholdid"
							Me.str.Recvholdid = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Prioritemstatus"
							Me.str.Prioritemstatus = CType(value, string)
												
						Case "Reasoncode"
							Me.str.Reasoncode = CType(value, string)
												
						Case "Reasontext"
							Me.str.Reasontext = CType(value, string)
												
						Case "Resolutioncode"
							Me.str.Resolutioncode = CType(value, string)
												
						Case "Resolutiontext"
							Me.str.Resolutiontext = CType(value, string)
												
						Case "Holdtime"
							Me.str.Holdtime = CType(value, string)
												
						Case "Holdrelease"
							Me.str.Holdrelease = CType(value, string)
												
						Case "Whoreleased"
							Me.str.Whoreleased = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Stdweight"
							Me.str.Stdweight = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Allocateddocument"
							Me.str.Allocateddocument = CType(value, string)
												
						Case "Allocateddate"
							Me.str.Allocateddate = CType(value, string)
												
						Case "Allocatedtype"
							Me.str.Allocatedtype = CType(value, string)
												
						Case "Inventoryclass"
							Me.str.Inventoryclass = CType(value, string)
												
						Case "Testsamplekey"
							Me.str.Testsamplekey = CType(value, string)
												
						Case "Vendorweight"
							Me.str.Vendorweight = CType(value, string)
												
						Case "Rcvdweight"
							Me.str.Rcvdweight = CType(value, string)
												
						Case "Eventid"
							Me.str.Eventid = CType(value, string)
												
						Case "Receiveddate"
							Me.str.Receiveddate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Recvholdid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recvholdid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Holdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Holdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Holdrelease"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Holdrelease = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Allocateddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Allocateddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Inventoryclass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Testsamplekey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Testsamplekey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rcvdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rcvdweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Eventid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Eventid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Receiveddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Receiveddate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewReceivedHoldItems.RECVHOLDID
		' </summary>
		Public Overridable Property Recvholdid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Recvholdid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Recvholdid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.PRIORITEMSTATUS
		' </summary>
		Public Overridable Property Prioritemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Prioritemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Prioritemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.REASONCODE
		' </summary>
		Public Overridable Property Reasoncode As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Reasoncode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Reasoncode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.REASONTEXT
		' </summary>
		Public Overridable Property Reasontext As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Reasontext)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Reasontext, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.RESOLUTIONCODE
		' </summary>
		Public Overridable Property Resolutioncode As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Resolutioncode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Resolutioncode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.RESOLUTIONTEXT
		' </summary>
		Public Overridable Property Resolutiontext As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Resolutiontext)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Resolutiontext, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.HOLDTIME
		' </summary>
		Public Overridable Property Holdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewReceivedHoldItemsMetadata.ColumnNames.Holdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewReceivedHoldItemsMetadata.ColumnNames.Holdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.HOLDRELEASE
		' </summary>
		Public Overridable Property Holdrelease As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewReceivedHoldItemsMetadata.ColumnNames.Holdrelease)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewReceivedHoldItemsMetadata.ColumnNames.Holdrelease, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.WHORELEASED
		' </summary>
		Public Overridable Property Whoreleased As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Whoreleased)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Whoreleased, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.ALLOCATEDDOCUMENT
		' </summary>
		Public Overridable Property Allocateddocument As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Allocateddocument)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Allocateddocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.ALLOCATEDDATE
		' </summary>
		Public Overridable Property Allocateddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewReceivedHoldItemsMetadata.ColumnNames.Allocateddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewReceivedHoldItemsMetadata.ColumnNames.Allocateddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.ALLOCATEDTYPE
		' </summary>
		Public Overridable Property Allocatedtype As System.String
			Get
				Return MyBase.GetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Allocatedtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewReceivedHoldItemsMetadata.ColumnNames.Allocatedtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.INVENTORYCLASS
		' </summary>
		Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Inventoryclass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Inventoryclass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.TESTSAMPLEKEY
		' </summary>
		Public Overridable Property Testsamplekey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Testsamplekey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Testsamplekey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.VENDORWEIGHT
		' </summary>
		Public Overridable Property Vendorweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Vendorweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Vendorweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.RCVDWEIGHT
		' </summary>
		Public Overridable Property Rcvdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Rcvdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Rcvdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.EVENTID
		' </summary>
		Public Overridable Property Eventid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Eventid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewReceivedHoldItemsMetadata.ColumnNames.Eventid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewReceivedHoldItems.RECEIVEDDATE
		' </summary>
		Public Overridable Property Receiveddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewReceivedHoldItemsMetadata.ColumnNames.Receiveddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewReceivedHoldItemsMetadata.ColumnNames.Receiveddate, value)
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
		
			Public Sub New(ByVal entity As esViewReceivedHoldItems)
				Me.entity = entity
			End Sub				
		
	
			Public Property Recvholdid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recvholdid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recvholdid = Nothing
					Else
						entity.Recvholdid = Convert.ToInt32(Value)
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
		  	
			Public Property Prioritemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Prioritemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prioritemstatus = Nothing
					Else
						entity.Prioritemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reasoncode As System.String 
				Get
					Dim data_ As System.String = entity.Reasoncode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reasoncode = Nothing
					Else
						entity.Reasoncode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reasontext As System.String 
				Get
					Dim data_ As System.String = entity.Reasontext
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reasontext = Nothing
					Else
						entity.Reasontext = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resolutioncode As System.String 
				Get
					Dim data_ As System.String = entity.Resolutioncode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resolutioncode = Nothing
					Else
						entity.Resolutioncode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resolutiontext As System.String 
				Get
					Dim data_ As System.String = entity.Resolutiontext
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resolutiontext = Nothing
					Else
						entity.Resolutiontext = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Holdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Holdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Holdtime = Nothing
					Else
						entity.Holdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Holdrelease As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Holdrelease
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Holdrelease = Nothing
					Else
						entity.Holdrelease = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whoreleased As System.String 
				Get
					Dim data_ As System.String = entity.Whoreleased
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whoreleased = Nothing
					Else
						entity.Whoreleased = Convert.ToString(Value)
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
		  	
			Public Property Stdweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Stdweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdweight = Nothing
					Else
						entity.Stdweight = Convert.ToInt32(Value)
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
		  	
			Public Property Allocateddocument As System.String 
				Get
					Dim data_ As System.String = entity.Allocateddocument
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocateddocument = Nothing
					Else
						entity.Allocateddocument = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Allocateddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Allocateddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocateddate = Nothing
					Else
						entity.Allocateddate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Allocatedtype As System.String 
				Get
					Dim data_ As System.String = entity.Allocatedtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocatedtype = Nothing
					Else
						entity.Allocatedtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventoryclass As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Inventoryclass
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventoryclass = Nothing
					Else
						entity.Inventoryclass = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Testsamplekey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Testsamplekey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Testsamplekey = Nothing
					Else
						entity.Testsamplekey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendorweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorweight = Nothing
					Else
						entity.Vendorweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rcvdweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rcvdweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rcvdweight = Nothing
					Else
						entity.Rcvdweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Eventid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Eventid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Eventid = Nothing
					Else
						entity.Eventid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Receiveddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Receiveddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receiveddate = Nothing
					Else
						entity.Receiveddate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewReceivedHoldItems
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewReceivedHoldItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewReceivedHoldItems can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewReceivedHoldItemsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewReceivedHoldItemsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Recvholdid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Recvholdid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prioritemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Prioritemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Reasoncode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Reasoncode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Reasontext As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Reasontext, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resolutioncode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Resolutioncode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resolutiontext As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Resolutiontext, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Holdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Holdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Holdrelease As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Holdrelease, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Whoreleased As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Whoreleased, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Allocateddocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Allocateddocument, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Allocateddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Allocateddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Allocatedtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Allocatedtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoryclass As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Testsamplekey As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Testsamplekey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Vendorweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rcvdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Rcvdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Eventid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Eventid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Receiveddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewReceivedHoldItemsMetadata.ColumnNames.Receiveddate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewReceivedHoldItemsCollection")> _
	Partial Public Class ViewReceivedHoldItemsCollection
		Inherits esViewReceivedHoldItemsCollection
		Implements IEnumerable(Of ViewReceivedHoldItems)
		
        Public Shared Widening Operator CType(ByVal coll As ViewReceivedHoldItemsCollection) As List(Of ViewReceivedHoldItems)
            Dim list As List(Of ViewReceivedHoldItems) = New List(Of ViewReceivedHoldItems)
            Dim emp As ViewReceivedHoldItems

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewReceivedHoldItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewReceivedHoldItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewReceivedHoldItems(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewReceivedHoldItems()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewReceivedHoldItemsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewReceivedHoldItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewReceivedHoldItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewReceivedHoldItems 
			Return CType(MyBase.AddNewEntity(), ViewReceivedHoldItems)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewReceivedHoldItems) Implements IEnumerable(Of ViewReceivedHoldItems).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewReceivedHoldItems)(Me)
        End Function
		
		Private _query As ViewReceivedHoldItemsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewReceivedHoldItems' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewReceivedHoldItems ()")> _
	<Serializable> _
	Partial Public Class ViewReceivedHoldItems 
		Inherits esViewReceivedHoldItems

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewReceivedHoldItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewReceivedHoldItemsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewReceivedHoldItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewReceivedHoldItemsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewReceivedHoldItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewReceivedHoldItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewReceivedHoldItemsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewReceivedHoldItemsQuery
		inherits esViewReceivedHoldItemsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewReceivedHoldItemsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewReceivedHoldItemsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Recvholdid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Recvholdid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Invitemnumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Prioritemstatus, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Prioritemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Reasoncode, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Reasoncode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Reasontext, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Reasontext
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Resolutioncode, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Resolutioncode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Resolutiontext, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Resolutiontext
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Holdtime, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Holdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Holdrelease, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Holdrelease
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Whoreleased, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Whoreleased
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Productid, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Productdesc, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Stdweight, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Container, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Lotnumber, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Itemstatus, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Allocateddocument, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Allocateddocument
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Allocateddate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Allocateddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Allocatedtype, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Allocatedtype
			c.CharacterMaxLength = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Inventoryclass, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Inventoryclass
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Testsamplekey, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Testsamplekey
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Vendorweight, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Vendorweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Rcvdweight, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Rcvdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Eventid, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Eventid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewReceivedHoldItemsMetadata.ColumnNames.Receiveddate, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewReceivedHoldItemsMetadata.PropertyNames.Receiveddate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewReceivedHoldItemsMetadata
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
			 Public Const Recvholdid As String = "RECVHOLDID"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Prioritemstatus As String = "PRIORITEMSTATUS"
			 Public Const Reasoncode As String = "REASONCODE"
			 Public Const Reasontext As String = "REASONTEXT"
			 Public Const Resolutioncode As String = "RESOLUTIONCODE"
			 Public Const Resolutiontext As String = "RESOLUTIONTEXT"
			 Public Const Holdtime As String = "HOLDTIME"
			 Public Const Holdrelease As String = "HOLDRELEASE"
			 Public Const Whoreleased As String = "WHORELEASED"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Container As String = "CONTAINER"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Allocateddocument As String = "ALLOCATEDDOCUMENT"
			 Public Const Allocateddate As String = "ALLOCATEDDATE"
			 Public Const Allocatedtype As String = "ALLOCATEDTYPE"
			 Public Const Inventoryclass As String = "INVENTORYCLASS"
			 Public Const Testsamplekey As String = "TESTSAMPLEKEY"
			 Public Const Vendorweight As String = "VENDORWEIGHT"
			 Public Const Rcvdweight As String = "RCVDWEIGHT"
			 Public Const Eventid As String = "EVENTID"
			 Public Const Receiveddate As String = "RECEIVEDDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Recvholdid As String = "Recvholdid"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Prioritemstatus As String = "Prioritemstatus"
			 Public Const Reasoncode As String = "Reasoncode"
			 Public Const Reasontext As String = "Reasontext"
			 Public Const Resolutioncode As String = "Resolutioncode"
			 Public Const Resolutiontext As String = "Resolutiontext"
			 Public Const Holdtime As String = "Holdtime"
			 Public Const Holdrelease As String = "Holdrelease"
			 Public Const Whoreleased As String = "Whoreleased"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Container As String = "Container"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Allocateddocument As String = "Allocateddocument"
			 Public Const Allocateddate As String = "Allocateddate"
			 Public Const Allocatedtype As String = "Allocatedtype"
			 Public Const Inventoryclass As String = "Inventoryclass"
			 Public Const Testsamplekey As String = "Testsamplekey"
			 Public Const Vendorweight As String = "Vendorweight"
			 Public Const Rcvdweight As String = "Rcvdweight"
			 Public Const Eventid As String = "Eventid"
			 Public Const Receiveddate As String = "Receiveddate"
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
            SyncLock GetType(ViewReceivedHoldItemsMetadata)
			
				If ViewReceivedHoldItemsMetadata.mapDelegates Is Nothing Then
					ViewReceivedHoldItemsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewReceivedHoldItemsMetadata._meta Is Nothing Then
                    ViewReceivedHoldItemsMetadata._meta = New ViewReceivedHoldItemsMetadata()
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
				

				meta.AddTypeMap("Recvholdid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prioritemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Reasoncode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Reasontext", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resolutioncode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resolutiontext", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Holdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Holdrelease", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Whoreleased", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Allocateddocument", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Allocateddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Allocatedtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventoryclass", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Testsamplekey", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rcvdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Eventid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Receiveddate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewReceivedHoldItems"
				meta.Destination = "viewReceivedHoldItems"
				
				meta.spInsert = "proc_viewReceivedHoldItemsInsert"
				meta.spUpdate = "proc_viewReceivedHoldItemsUpdate"
				meta.spDelete = "proc_viewReceivedHoldItemsDelete"
				meta.spLoadAll = "proc_viewReceivedHoldItemsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewReceivedHoldItemsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewReceivedHoldItemsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
