'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/21/2017 8:41:41 AM
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
	MustInherit Public Class esViewCommissionDetailCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCommissionDetailCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCommissionDetailQuery)
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
            Me.InitQuery(CType(query, esViewCommissionDetailQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCommissionDetail) As ViewCommissionDetail
			Return CType(MyBase.DetachEntity(entity), ViewCommissionDetail)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCommissionDetail) As ViewCommissionDetail
			Return CType(MyBase.AttachEntity(entity), ViewCommissionDetail)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCommissionDetailCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCommissionDetail
            Get
                Return TryCast(MyBase.Item(index), ViewCommissionDetail)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCommissionDetail)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCommissionDetail	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCommissionDetailQuery
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
												
						Case "Commissionid"
							Me.str.Commissionid = CType(value, string)
												
						Case "Commissiondate"
							Me.str.Commissiondate = CType(value, string)
												
						Case "Salespersonfullname"
							Me.str.Salespersonfullname = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Commissionamount"
							Me.str.Commissionamount = CType(value, string)
												
						Case "Commissionstatus"
							Me.str.Commissionstatus = CType(value, string)
												
						Case "Commissiondesc"
							Me.str.Commissiondesc = CType(value, string)
												
						Case "Commissionnote"
							Me.str.Commissionnote = CType(value, string)
												
						Case "Commissioncategory"
							Me.str.Commissioncategory = CType(value, string)
												
						Case "Datecommissionpaid"
							Me.str.Datecommissionpaid = CType(value, string)
												
						Case "Commissionpmtid"
							Me.str.Commissionpmtid = CType(value, string)
												
						Case "Salespersonid"
							Me.str.Salespersonid = CType(value, string)
												
						Case "CommissionRate"
							Me.str.CommissionRate = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "CustAssignID"
							Me.str.CustAssignID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Commissionid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Commissionid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Commissiondate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Commissiondate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Commissionamount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Commissionamount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Datecommissionpaid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Datecommissionpaid = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Commissionpmtid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Commissionpmtid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Salespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Salespersonid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CommissionRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CommissionRate = CType(value, Nullable(Of System.Double))
							End If
						
						Case "CustAssignID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustAssignID = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCommissionDetail.COMMISSIONID
		' </summary>
		Public Overridable Property Commissionid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Commissionid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Commissionid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.COMMISSIONDATE
		' </summary>
		Public Overridable Property Commissiondate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCommissionDetailMetadata.ColumnNames.Commissiondate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCommissionDetailMetadata.ColumnNames.Commissiondate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.SALESPERSONFULLNAME
		' </summary>
		Public Overridable Property Salespersonfullname As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionDetailMetadata.ColumnNames.Salespersonfullname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionDetailMetadata.ColumnNames.Salespersonfullname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionDetailMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionDetailMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.COMMISSIONAMOUNT
		' </summary>
		Public Overridable Property Commissionamount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionDetailMetadata.ColumnNames.Commissionamount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionDetailMetadata.ColumnNames.Commissionamount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.COMMISSIONSTATUS
		' </summary>
		Public Overridable Property Commissionstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionDetailMetadata.ColumnNames.Commissionstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionDetailMetadata.ColumnNames.Commissionstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.COMMISSIONDESC
		' </summary>
		Public Overridable Property Commissiondesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionDetailMetadata.ColumnNames.Commissiondesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionDetailMetadata.ColumnNames.Commissiondesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.COMMISSIONNOTE
		' </summary>
		Public Overridable Property Commissionnote As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionDetailMetadata.ColumnNames.Commissionnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionDetailMetadata.ColumnNames.Commissionnote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.COMMISSIONCATEGORY
		' </summary>
		Public Overridable Property Commissioncategory As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionDetailMetadata.ColumnNames.Commissioncategory)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionDetailMetadata.ColumnNames.Commissioncategory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.DATECOMMISSIONPAID
		' </summary>
		Public Overridable Property Datecommissionpaid As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCommissionDetailMetadata.ColumnNames.Datecommissionpaid)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCommissionDetailMetadata.ColumnNames.Datecommissionpaid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.COMMISSIONPMTID
		' </summary>
		Public Overridable Property Commissionpmtid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Commissionpmtid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Commissionpmtid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.SALESPERSONID
		' </summary>
		Public Overridable Property Salespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Salespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.Salespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.CommissionRate
		' </summary>
		Public Overridable Property CommissionRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionDetailMetadata.ColumnNames.CommissionRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionDetailMetadata.ColumnNames.CommissionRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionDetailMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionDetailMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetail.CustAssignID
		' </summary>
		Public Overridable Property CustAssignID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.CustAssignID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionDetailMetadata.ColumnNames.CustAssignID, value)
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
		
			Public Sub New(ByVal entity As esViewCommissionDetail)
				Me.entity = entity
			End Sub				
		
	
			Public Property Commissionid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Commissionid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionid = Nothing
					Else
						entity.Commissionid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissiondate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Commissiondate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissiondate = Nothing
					Else
						entity.Commissiondate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonfullname As System.String 
				Get
					Dim data_ As System.String = entity.Salespersonfullname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonfullname = Nothing
					Else
						entity.Salespersonfullname = Convert.ToString(Value)
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
		  	
			Public Property Invoicenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicenumber = Nothing
					Else
						entity.Invoicenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionamount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Commissionamount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionamount = Nothing
					Else
						entity.Commissionamount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionstatus As System.String 
				Get
					Dim data_ As System.String = entity.Commissionstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionstatus = Nothing
					Else
						entity.Commissionstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissiondesc As System.String 
				Get
					Dim data_ As System.String = entity.Commissiondesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissiondesc = Nothing
					Else
						entity.Commissiondesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionnote As System.String 
				Get
					Dim data_ As System.String = entity.Commissionnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionnote = Nothing
					Else
						entity.Commissionnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissioncategory As System.String 
				Get
					Dim data_ As System.String = entity.Commissioncategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissioncategory = Nothing
					Else
						entity.Commissioncategory = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datecommissionpaid As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Datecommissionpaid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datecommissionpaid = Nothing
					Else
						entity.Datecommissionpaid = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionpmtid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Commissionpmtid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionpmtid = Nothing
					Else
						entity.Commissionpmtid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Salespersonid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonid = Nothing
					Else
						entity.Salespersonid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CommissionRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionRate = Nothing
					Else
						entity.CommissionRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Customerpo As System.String 
				Get
					Dim data_ As System.String = entity.Customerpo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerpo = Nothing
					Else
						entity.Customerpo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustAssignID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CustAssignID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustAssignID = Nothing
					Else
						entity.CustAssignID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCommissionDetail
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCommissionDetailQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCommissionDetail can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCommissionDetailQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionDetailMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Commissionid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Commissionid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissiondate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Commissiondate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonfullname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Salespersonfullname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionamount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Commissionamount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Commissionstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Commissiondesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Commissiondesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionnote As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Commissionnote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Commissioncategory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Commissioncategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datecommissionpaid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Datecommissionpaid, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionpmtid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Commissionpmtid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Salespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.CommissionRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustAssignID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailMetadata.ColumnNames.CustAssignID, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCommissionDetailCollection")> _
	Partial Public Class ViewCommissionDetailCollection
		Inherits esViewCommissionDetailCollection
		Implements IEnumerable(Of ViewCommissionDetail)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCommissionDetailCollection) As List(Of ViewCommissionDetail)
            Dim list As List(Of ViewCommissionDetail) = New List(Of ViewCommissionDetail)
            Dim emp As ViewCommissionDetail

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionDetailMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionDetailQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCommissionDetail(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCommissionDetail()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCommissionDetailQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCommissionDetailQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionDetailQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCommissionDetail 
			Return CType(MyBase.AddNewEntity(), ViewCommissionDetail)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCommissionDetail) Implements IEnumerable(Of ViewCommissionDetail).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCommissionDetail)(Me)
        End Function
		
		Private _query As ViewCommissionDetailQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCommissionDetail' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCommissionDetail ()")> _
	<Serializable> _
	Partial Public Class ViewCommissionDetail 
		Inherits esViewCommissionDetail

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCommissionDetailMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCommissionDetailQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionDetailQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCommissionDetailQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCommissionDetailQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionDetailQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCommissionDetailQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCommissionDetailQuery
		inherits esViewCommissionDetailQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCommissionDetailQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCommissionDetailMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Commissionid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Commissionid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Commissiondate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Commissiondate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Salespersonfullname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Salespersonfullname
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Custid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Custname, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Invoicenumber, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Commissionamount, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Commissionamount
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Commissionstatus, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Commissionstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Commissiondesc, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Commissiondesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Commissionnote, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Commissionnote
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Commissioncategory, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Commissioncategory
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Datecommissionpaid, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Datecommissionpaid
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Commissionpmtid, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Commissionpmtid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Salespersonid, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Salespersonid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.CommissionRate, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.CommissionRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.Customerpo, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailMetadata.ColumnNames.CustAssignID, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionDetailMetadata.PropertyNames.CustAssignID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCommissionDetailMetadata
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
			 Public Const Commissionid As String = "COMMISSIONID"
			 Public Const Commissiondate As String = "COMMISSIONDATE"
			 Public Const Salespersonfullname As String = "SALESPERSONFULLNAME"
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Commissionamount As String = "COMMISSIONAMOUNT"
			 Public Const Commissionstatus As String = "COMMISSIONSTATUS"
			 Public Const Commissiondesc As String = "COMMISSIONDESC"
			 Public Const Commissionnote As String = "COMMISSIONNOTE"
			 Public Const Commissioncategory As String = "COMMISSIONCATEGORY"
			 Public Const Datecommissionpaid As String = "DATECOMMISSIONPAID"
			 Public Const Commissionpmtid As String = "COMMISSIONPMTID"
			 Public Const Salespersonid As String = "SALESPERSONID"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const CustAssignID As String = "CustAssignID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Commissionid As String = "Commissionid"
			 Public Const Commissiondate As String = "Commissiondate"
			 Public Const Salespersonfullname As String = "Salespersonfullname"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Commissionamount As String = "Commissionamount"
			 Public Const Commissionstatus As String = "Commissionstatus"
			 Public Const Commissiondesc As String = "Commissiondesc"
			 Public Const Commissionnote As String = "Commissionnote"
			 Public Const Commissioncategory As String = "Commissioncategory"
			 Public Const Datecommissionpaid As String = "Datecommissionpaid"
			 Public Const Commissionpmtid As String = "Commissionpmtid"
			 Public Const Salespersonid As String = "Salespersonid"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const CustAssignID As String = "CustAssignID"
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
            SyncLock GetType(ViewCommissionDetailMetadata)
			
				If ViewCommissionDetailMetadata.mapDelegates Is Nothing Then
					ViewCommissionDetailMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCommissionDetailMetadata._meta Is Nothing Then
                    ViewCommissionDetailMetadata._meta = New ViewCommissionDetailMetadata()
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
				

				meta.AddTypeMap("Commissionid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissiondate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Salespersonfullname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissionamount", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Commissionstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Commissiondesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Commissionnote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Commissioncategory", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datecommissionpaid", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Commissionpmtid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CommissionRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CustAssignID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCommissionDetail"
				meta.Destination = "viewCommissionDetail"
				
				meta.spInsert = "proc_viewCommissionDetailInsert"
				meta.spUpdate = "proc_viewCommissionDetailUpdate"
				meta.spDelete = "proc_viewCommissionDetailDelete"
				meta.spLoadAll = "proc_viewCommissionDetailLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCommissionDetailLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCommissionDetailMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
