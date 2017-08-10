'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:57 PM
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
	MustInherit Public Class esVendorCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "VendorCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esVendorQuery)
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
            Me.InitQuery(CType(query, esVendorQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Vendor) As Vendor
			Return CType(MyBase.DetachEntity(entity), Vendor)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Vendor) As Vendor
			Return CType(MyBase.AttachEntity(entity), Vendor)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As VendorCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Vendor
            Get
                Return TryCast(MyBase.Item(index), Vendor)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Vendor)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esVendor	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esVendorQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal vendorid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(vendorid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(vendorid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal vendorid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(vendorid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(vendorid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal vendorid As System.Int32) As Boolean
		
			Dim query As esVendorQuery = Me.GetDynamicQuery()
			query.Where(query.Vendorid.Equal(vendorid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal vendorid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("VENDORID", vendorid)
			
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
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Vendoraddress1"
							Me.str.Vendoraddress1 = CType(value, string)
												
						Case "Vendoraddress2"
							Me.str.Vendoraddress2 = CType(value, string)
												
						Case "Vendorcity"
							Me.str.Vendorcity = CType(value, string)
												
						Case "Vendorstate"
							Me.str.Vendorstate = CType(value, string)
												
						Case "Vendorzip"
							Me.str.Vendorzip = CType(value, string)
												
						Case "Vendorphone"
							Me.str.Vendorphone = CType(value, string)
												
						Case "Vendorfax"
							Me.str.Vendorfax = CType(value, string)
												
						Case "Vendorcontact"
							Me.str.Vendorcontact = CType(value, string)
												
						Case "Vendoremail"
							Me.str.Vendoremail = CType(value, string)
												
						Case "Vendorurl"
							Me.str.Vendorurl = CType(value, string)
												
						Case "Vendoracctnumber"
							Me.str.Vendoracctnumber = CType(value, string)
												
						Case "Terms"
							Me.str.Terms = CType(value, string)
												
						Case "Vendornotes"
							Me.str.Vendornotes = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to VENDOR.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VendorMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(VendorMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORADDRESS1
		' </summary>
		Public Overridable Property Vendoraddress1 As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendoraddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendoraddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORADDRESS2
		' </summary>
		Public Overridable Property Vendoraddress2 As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendoraddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendoraddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORCITY
		' </summary>
		Public Overridable Property Vendorcity As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendorcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendorcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORSTATE
		' </summary>
		Public Overridable Property Vendorstate As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendorstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendorstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORZIP
		' </summary>
		Public Overridable Property Vendorzip As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendorzip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendorzip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORPHONE
		' </summary>
		Public Overridable Property Vendorphone As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendorphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendorphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORFAX
		' </summary>
		Public Overridable Property Vendorfax As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendorfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendorfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORCONTACT
		' </summary>
		Public Overridable Property Vendorcontact As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendorcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendorcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDOREMAIL
		' </summary>
		Public Overridable Property Vendoremail As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendoremail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendoremail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORURL
		' </summary>
		Public Overridable Property Vendorurl As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendorurl)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendorurl, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORACCTNUMBER
		' </summary>
		Public Overridable Property Vendoracctnumber As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendoracctnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendoracctnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.TERMS
		' </summary>
		Public Overridable Property Terms As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Terms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Terms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.VENDORNOTES
		' </summary>
		Public Overridable Property Vendornotes As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Vendornotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Vendornotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VendorMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(VendorMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(VendorMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendorMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VendorMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(VendorMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDOR.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(VendorMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(VendorMetadata.ColumnNames.Isactive, value)
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
		
			Public Sub New(ByVal entity As esVendor)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Vendorname As System.String 
				Get
					Dim data_ As System.String = entity.Vendorname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorname = Nothing
					Else
						entity.Vendorname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoraddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Vendoraddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoraddress1 = Nothing
					Else
						entity.Vendoraddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoraddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Vendoraddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoraddress2 = Nothing
					Else
						entity.Vendoraddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorcity As System.String 
				Get
					Dim data_ As System.String = entity.Vendorcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorcity = Nothing
					Else
						entity.Vendorcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorstate As System.String 
				Get
					Dim data_ As System.String = entity.Vendorstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorstate = Nothing
					Else
						entity.Vendorstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorzip As System.String 
				Get
					Dim data_ As System.String = entity.Vendorzip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorzip = Nothing
					Else
						entity.Vendorzip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorphone As System.String 
				Get
					Dim data_ As System.String = entity.Vendorphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorphone = Nothing
					Else
						entity.Vendorphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorfax As System.String 
				Get
					Dim data_ As System.String = entity.Vendorfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorfax = Nothing
					Else
						entity.Vendorfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorcontact As System.String 
				Get
					Dim data_ As System.String = entity.Vendorcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorcontact = Nothing
					Else
						entity.Vendorcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoremail As System.String 
				Get
					Dim data_ As System.String = entity.Vendoremail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoremail = Nothing
					Else
						entity.Vendoremail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorurl As System.String 
				Get
					Dim data_ As System.String = entity.Vendorurl
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorurl = Nothing
					Else
						entity.Vendorurl = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoracctnumber As System.String 
				Get
					Dim data_ As System.String = entity.Vendoracctnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoracctnumber = Nothing
					Else
						entity.Vendoracctnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Terms As System.String 
				Get
					Dim data_ As System.String = entity.Terms
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Terms = Nothing
					Else
						entity.Terms = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendornotes As System.String 
				Get
					Dim data_ As System.String = entity.Vendornotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendornotes = Nothing
					Else
						entity.Vendornotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifyby As System.String 
				Get
					Dim data_ As System.String = entity.Modifyby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifyby = Nothing
					Else
						entity.Modifyby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifytime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifytime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifytime = Nothing
					Else
						entity.Modifytime = Convert.ToDateTime(Value)
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
		  

			Private entity As esVendor
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esVendorQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esVendor can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Vendor 
		Inherits esVendor
		
	
		
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
	MustInherit Public Class esVendorQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VendorMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoraddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendoraddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoraddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendoraddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorcity As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorstate As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorzip As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorzip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorphone As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorfax As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorcontact As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoremail As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendoremail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorurl As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendorurl, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoracctnumber As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendoracctnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Terms As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Terms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendornotes As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Vendornotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, VendorMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("VendorCollection")> _
	Partial Public Class VendorCollection
		Inherits esVendorCollection
		Implements IEnumerable(Of Vendor)
		
        Public Shared Widening Operator CType(ByVal coll As VendorCollection) As List(Of Vendor)
            Dim list As List(Of Vendor) = New List(Of Vendor)
            Dim emp As Vendor

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VendorMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New VendorQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Vendor(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Vendor()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As VendorQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New VendorQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As VendorQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Vendor 
			Return CType(MyBase.AddNewEntity(), Vendor)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal vendorid As System.Int32) As Vendor
			Return CType(MyBase.FindByPrimaryKey(vendorid), Vendor)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Vendor) Implements IEnumerable(Of Vendor).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Vendor)(Me)
        End Function
		
		Private _query As VendorQuery

	End Class
	


	' <summary>
	' Encapsulates the 'VENDOR' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Vendor ({Vendorid.Value})")> _
	<Serializable> _
	Partial Public Class Vendor 
		Inherits esVendor

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return VendorMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esVendorQuery

			If Me._query Is Nothing Then
				Me._query = New VendorQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As VendorQuery
			Get

				If Me._query Is Nothing then
					Me._query = New VendorQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As VendorQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As VendorQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class VendorQuery
		inherits esVendorQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "VendorQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class VendorMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendoraddress1, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendoraddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendoraddress2, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendoraddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorcity, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorstate, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorzip, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorzip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorphone, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorphone
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorfax, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorfax
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorcontact, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendoremail, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendoremail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendorurl, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendorurl
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendoracctnumber, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendoracctnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Terms, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Terms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Vendornotes, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Vendornotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Createdby, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Createdtime, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VendorMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Modifyby, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendorMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Modifytime, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VendorMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendorMetadata.ColumnNames.Isactive, 19, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = VendorMetadata.PropertyNames.Isactive
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As VendorMetadata
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
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Vendoraddress1 As String = "VENDORADDRESS1"
			 Public Const Vendoraddress2 As String = "VENDORADDRESS2"
			 Public Const Vendorcity As String = "VENDORCITY"
			 Public Const Vendorstate As String = "VENDORSTATE"
			 Public Const Vendorzip As String = "VENDORZIP"
			 Public Const Vendorphone As String = "VENDORPHONE"
			 Public Const Vendorfax As String = "VENDORFAX"
			 Public Const Vendorcontact As String = "VENDORCONTACT"
			 Public Const Vendoremail As String = "VENDOREMAIL"
			 Public Const Vendorurl As String = "VENDORURL"
			 Public Const Vendoracctnumber As String = "VENDORACCTNUMBER"
			 Public Const Terms As String = "TERMS"
			 Public Const Vendornotes As String = "VENDORNOTES"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Isactive As String = "ISACTIVE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Vendoraddress1 As String = "Vendoraddress1"
			 Public Const Vendoraddress2 As String = "Vendoraddress2"
			 Public Const Vendorcity As String = "Vendorcity"
			 Public Const Vendorstate As String = "Vendorstate"
			 Public Const Vendorzip As String = "Vendorzip"
			 Public Const Vendorphone As String = "Vendorphone"
			 Public Const Vendorfax As String = "Vendorfax"
			 Public Const Vendorcontact As String = "Vendorcontact"
			 Public Const Vendoremail As String = "Vendoremail"
			 Public Const Vendorurl As String = "Vendorurl"
			 Public Const Vendoracctnumber As String = "Vendoracctnumber"
			 Public Const Terms As String = "Terms"
			 Public Const Vendornotes As String = "Vendornotes"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
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
            SyncLock GetType(VendorMetadata)
			
				If VendorMetadata.mapDelegates Is Nothing Then
					VendorMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If VendorMetadata._meta Is Nothing Then
                    VendorMetadata._meta = New VendorMetadata()
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
				

				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoraddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoraddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorzip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoremail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorurl", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoracctnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Terms", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendornotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "VENDOR"
				meta.Destination = "VENDOR"
				
				meta.spInsert = "proc_VENDORInsert"
				meta.spUpdate = "proc_VENDORUpdate"
				meta.spDelete = "proc_VENDORDelete"
				meta.spLoadAll = "proc_VENDORLoadAll"
				meta.spLoadByPrimaryKey = "proc_VENDORLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As VendorMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
