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
	MustInherit Public Class esPoCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "PoCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esPoQuery)
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
            Me.InitQuery(CType(query, esPoQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Po) As Po
			Return CType(MyBase.DetachEntity(entity), Po)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Po) As Po
			Return CType(MyBase.AttachEntity(entity), Po)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As PoCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Po
            Get
                Return TryCast(MyBase.Item(index), Po)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Po)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esPo	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esPoQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal ponumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(ponumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(ponumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal ponumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(ponumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(ponumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal ponumber As System.Int32) As Boolean
		
			Dim query As esPoQuery = Me.GetDynamicQuery()
			query.Where(query.Ponumber.Equal(ponumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal ponumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PONUMBER", ponumber)
			
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
												
						Case "Ponumber"
							Me.str.Ponumber = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Podate"
							Me.str.Podate = CType(value, string)
												
						Case "Potype"
							Me.str.Potype = CType(value, string)
												
						Case "Poterms"
							Me.str.Poterms = CType(value, string)
												
						Case "Postatus"
							Me.str.Postatus = CType(value, string)
												
						Case "Changeableponumber"
							Me.str.Changeableponumber = CType(value, string)
												
						Case "Shipname"
							Me.str.Shipname = CType(value, string)
												
						Case "Shipaddress1"
							Me.str.Shipaddress1 = CType(value, string)
												
						Case "Shipaddress2"
							Me.str.Shipaddress2 = CType(value, string)
												
						Case "Shipcity"
							Me.str.Shipcity = CType(value, string)
												
						Case "Shipstate"
							Me.str.Shipstate = CType(value, string)
												
						Case "Shipzip"
							Me.str.Shipzip = CType(value, string)
												
						Case "Shipcontact"
							Me.str.Shipcontact = CType(value, string)
												
						Case "Shipphone"
							Me.str.Shipphone = CType(value, string)
												
						Case "Posubtotal"
							Me.str.Posubtotal = CType(value, string)
												
						Case "Posalestax"
							Me.str.Posalestax = CType(value, string)
												
						Case "Pofreightin"
							Me.str.Pofreightin = CType(value, string)
												
						Case "Pototal"
							Me.str.Pototal = CType(value, string)
												
						Case "Instructions"
							Me.str.Instructions = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Ponumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Ponumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Podate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Podate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Posubtotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Posubtotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Posalestax"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Posalestax = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Pofreightin"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Pofreightin = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Pototal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Pototal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to PO.PONUMBER
		' </summary>
		Public Overridable Property Ponumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PoMetadata.ColumnNames.Ponumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PoMetadata.ColumnNames.Ponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PoMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PoMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.PODATE
		' </summary>
		Public Overridable Property Podate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PoMetadata.ColumnNames.Podate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PoMetadata.ColumnNames.Podate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.POTYPE
		' </summary>
		Public Overridable Property Potype As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Potype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Potype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.POTERMS
		' </summary>
		Public Overridable Property Poterms As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Poterms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Poterms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.POSTATUS
		' </summary>
		Public Overridable Property Postatus As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Postatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Postatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.CHANGEABLEPONUMBER
		' </summary>
		Public Overridable Property Changeableponumber As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Changeableponumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Changeableponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.SHIPNAME
		' </summary>
		Public Overridable Property Shipname As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Shipname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Shipname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.SHIPADDRESS1
		' </summary>
		Public Overridable Property Shipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Shipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Shipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.SHIPADDRESS2
		' </summary>
		Public Overridable Property Shipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Shipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Shipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.SHIPSTATE
		' </summary>
		Public Overridable Property Shipstate As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Shipstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Shipstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.SHIPZIP
		' </summary>
		Public Overridable Property Shipzip As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Shipzip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Shipzip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.SHIPCONTACT
		' </summary>
		Public Overridable Property Shipcontact As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Shipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Shipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.SHIPPHONE
		' </summary>
		Public Overridable Property Shipphone As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Shipphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Shipphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.POSUBTOTAL
		' </summary>
		Public Overridable Property Posubtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoMetadata.ColumnNames.Posubtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoMetadata.ColumnNames.Posubtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.POSALESTAX
		' </summary>
		Public Overridable Property Posalestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoMetadata.ColumnNames.Posalestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoMetadata.ColumnNames.Posalestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.POFREIGHTIN
		' </summary>
		Public Overridable Property Pofreightin As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoMetadata.ColumnNames.Pofreightin)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoMetadata.ColumnNames.Pofreightin, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.POTOTAL
		' </summary>
		Public Overridable Property Pototal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PoMetadata.ColumnNames.Pototal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PoMetadata.ColumnNames.Pototal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.INSTRUCTIONS
		' </summary>
		Public Overridable Property Instructions As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Instructions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Instructions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PoMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PoMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PoMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PoMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(PoMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PoMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PO.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PoMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PoMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esPo)
				Me.entity = entity
			End Sub				
		
	
			Public Property Ponumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Ponumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ponumber = Nothing
					Else
						entity.Ponumber = Convert.ToInt32(Value)
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
		  	
			Public Property Podate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Podate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Podate = Nothing
					Else
						entity.Podate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Potype As System.String 
				Get
					Dim data_ As System.String = entity.Potype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Potype = Nothing
					Else
						entity.Potype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Poterms As System.String 
				Get
					Dim data_ As System.String = entity.Poterms
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Poterms = Nothing
					Else
						entity.Poterms = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Postatus As System.String 
				Get
					Dim data_ As System.String = entity.Postatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Postatus = Nothing
					Else
						entity.Postatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changeableponumber As System.String 
				Get
					Dim data_ As System.String = entity.Changeableponumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changeableponumber = Nothing
					Else
						entity.Changeableponumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipname As System.String 
				Get
					Dim data_ As System.String = entity.Shipname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipname = Nothing
					Else
						entity.Shipname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Shipaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipaddress1 = Nothing
					Else
						entity.Shipaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Shipaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipaddress2 = Nothing
					Else
						entity.Shipaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipcity As System.String 
				Get
					Dim data_ As System.String = entity.Shipcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcity = Nothing
					Else
						entity.Shipcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipstate As System.String 
				Get
					Dim data_ As System.String = entity.Shipstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipstate = Nothing
					Else
						entity.Shipstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipzip As System.String 
				Get
					Dim data_ As System.String = entity.Shipzip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipzip = Nothing
					Else
						entity.Shipzip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipcontact As System.String 
				Get
					Dim data_ As System.String = entity.Shipcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcontact = Nothing
					Else
						entity.Shipcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipphone As System.String 
				Get
					Dim data_ As System.String = entity.Shipphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipphone = Nothing
					Else
						entity.Shipphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Posubtotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Posubtotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Posubtotal = Nothing
					Else
						entity.Posubtotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Posalestax As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Posalestax
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Posalestax = Nothing
					Else
						entity.Posalestax = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pofreightin As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Pofreightin
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pofreightin = Nothing
					Else
						entity.Pofreightin = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pototal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Pototal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pototal = Nothing
					Else
						entity.Pototal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Instructions As System.String 
				Get
					Dim data_ As System.String = entity.Instructions
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Instructions = Nothing
					Else
						entity.Instructions = Convert.ToString(Value)
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
		  

			Private entity As esPo
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esPoQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esPo can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Po 
		Inherits esPo
		
	
		
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
	MustInherit Public Class esPoQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PoMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Ponumber As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Ponumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Podate As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Podate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Potype As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Potype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Poterms As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Poterms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Postatus As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Postatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changeableponumber As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Changeableponumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipname As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Shipname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Shipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Shipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstate As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Shipstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipzip As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Shipzip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Shipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipphone As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Shipphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Posubtotal As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Posubtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Posalestax As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Posalestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pofreightin As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Pofreightin, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pototal As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Pototal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Instructions As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Instructions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, PoMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("PoCollection")> _
	Partial Public Class PoCollection
		Inherits esPoCollection
		Implements IEnumerable(Of Po)
		
        Public Shared Widening Operator CType(ByVal coll As PoCollection) As List(Of Po)
            Dim list As List(Of Po) = New List(Of Po)
            Dim emp As Po

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New PoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Po(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Po()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As PoQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New PoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Po 
			Return CType(MyBase.AddNewEntity(), Po)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal ponumber As System.Int32) As Po
			Return CType(MyBase.FindByPrimaryKey(ponumber), Po)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Po) Implements IEnumerable(Of Po).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Po)(Me)
        End Function
		
		Private _query As PoQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PO' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Po ({Ponumber.Value})")> _
	<Serializable> _
	Partial Public Class Po 
		Inherits esPo

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return PoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esPoQuery

			If Me._query Is Nothing Then
				Me._query = New PoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As PoQuery
			Get

				If Me._query Is Nothing then
					Me._query = New PoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As PoQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class PoQuery
		inherits esPoQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "PoQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class PoMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(PoMetadata.ColumnNames.Ponumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PoMetadata.PropertyNames.Ponumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Vendorid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PoMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Podate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PoMetadata.PropertyNames.Podate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Potype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Potype
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Poterms, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Poterms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Postatus, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Postatus
			c.CharacterMaxLength = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Changeableponumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Changeableponumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Shipname, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Shipname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Shipaddress1, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Shipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Shipaddress2, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Shipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Shipcity, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Shipstate, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Shipstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Shipzip, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Shipzip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Shipcontact, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Shipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Shipphone, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Shipphone
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Posubtotal, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoMetadata.PropertyNames.Posubtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Posalestax, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoMetadata.PropertyNames.Posalestax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Pofreightin, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoMetadata.PropertyNames.Pofreightin
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Pototal, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PoMetadata.PropertyNames.Pototal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Instructions, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Instructions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Custid, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PoMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Createdby, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Createdtime, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PoMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Modifyby, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = PoMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PoMetadata.ColumnNames.Modifytime, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PoMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As PoMetadata
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
			 Public Const Ponumber As String = "PONUMBER"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Podate As String = "PODATE"
			 Public Const Potype As String = "POTYPE"
			 Public Const Poterms As String = "POTERMS"
			 Public Const Postatus As String = "POSTATUS"
			 Public Const Changeableponumber As String = "CHANGEABLEPONUMBER"
			 Public Const Shipname As String = "SHIPNAME"
			 Public Const Shipaddress1 As String = "SHIPADDRESS1"
			 Public Const Shipaddress2 As String = "SHIPADDRESS2"
			 Public Const Shipcity As String = "SHIPCITY"
			 Public Const Shipstate As String = "SHIPSTATE"
			 Public Const Shipzip As String = "SHIPZIP"
			 Public Const Shipcontact As String = "SHIPCONTACT"
			 Public Const Shipphone As String = "SHIPPHONE"
			 Public Const Posubtotal As String = "POSUBTOTAL"
			 Public Const Posalestax As String = "POSALESTAX"
			 Public Const Pofreightin As String = "POFREIGHTIN"
			 Public Const Pototal As String = "POTOTAL"
			 Public Const Instructions As String = "INSTRUCTIONS"
			 Public Const Custid As String = "CUSTID"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Ponumber As String = "Ponumber"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Podate As String = "Podate"
			 Public Const Potype As String = "Potype"
			 Public Const Poterms As String = "Poterms"
			 Public Const Postatus As String = "Postatus"
			 Public Const Changeableponumber As String = "Changeableponumber"
			 Public Const Shipname As String = "Shipname"
			 Public Const Shipaddress1 As String = "Shipaddress1"
			 Public Const Shipaddress2 As String = "Shipaddress2"
			 Public Const Shipcity As String = "Shipcity"
			 Public Const Shipstate As String = "Shipstate"
			 Public Const Shipzip As String = "Shipzip"
			 Public Const Shipcontact As String = "Shipcontact"
			 Public Const Shipphone As String = "Shipphone"
			 Public Const Posubtotal As String = "Posubtotal"
			 Public Const Posalestax As String = "Posalestax"
			 Public Const Pofreightin As String = "Pofreightin"
			 Public Const Pototal As String = "Pototal"
			 Public Const Instructions As String = "Instructions"
			 Public Const Custid As String = "Custid"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
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
            SyncLock GetType(PoMetadata)
			
				If PoMetadata.mapDelegates Is Nothing Then
					PoMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If PoMetadata._meta Is Nothing Then
                    PoMetadata._meta = New PoMetadata()
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
				

				meta.AddTypeMap("Ponumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Podate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Potype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Poterms", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Postatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Changeableponumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipzip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Posubtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Posalestax", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Pofreightin", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Pototal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Instructions", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "PO"
				meta.Destination = "PO"
				
				meta.spInsert = "proc_POInsert"
				meta.spUpdate = "proc_POUpdate"
				meta.spDelete = "proc_PODelete"
				meta.spLoadAll = "proc_POLoadAll"
				meta.spLoadByPrimaryKey = "proc_POLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As PoMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
