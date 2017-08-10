'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/4/2015 2:40:05 PM
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
	MustInherit Public Class esApisCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ApisCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esApisQuery)
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
            Me.InitQuery(CType(query, esApisQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Apis) As Apis
			Return CType(MyBase.DetachEntity(entity), Apis)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Apis) As Apis
			Return CType(MyBase.AttachEntity(entity), Apis)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ApisCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Apis
            Get
                Return TryCast(MyBase.Item(index), Apis)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Apis)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esApis	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esApisQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal apisnum As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apisnum)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apisnum)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal apisnum As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apisnum)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apisnum)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal apisnum As System.Int32) As Boolean
		
			Dim query As esApisQuery = Me.GetDynamicQuery()
			query.Where(query.Apisnum.Equal(apisnum))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal apisnum As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APISNUM", apisnum)
			
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
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Apisdesc"
							Me.str.Apisdesc = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Qtycontainers"
							Me.str.Qtycontainers = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Apisnote"
							Me.str.Apisnote = CType(value, string)
												
						Case "Stdlaborhours"
							Me.str.Stdlaborhours = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
												
						Case "Revision"
							Me.str.Revision = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Useaggregatelotno"
							Me.str.Useaggregatelotno = CType(value, string)
												
						Case "Apisstatus"
							Me.str.Apisstatus = CType(value, string)
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtycontainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtycontainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdlaborhours"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Stdlaborhours = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Useaggregatelotno"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Useaggregatelotno = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Kitid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Kitid = CType(value, Nullable(Of System.Int32))
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
		' Maps to APIS.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.APISDESC
		' </summary>
		Public Overridable Property Apisdesc As System.String
			Get
				Return MyBase.GetSystemString(ApisMetadata.ColumnNames.Apisdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisMetadata.ColumnNames.Apisdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ApisMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisMetadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisMetadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.APISNOTE
		' </summary>
		Public Overridable Property Apisnote As System.String
			Get
				Return MyBase.GetSystemString(ApisMetadata.ColumnNames.Apisnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisMetadata.ColumnNames.Apisnote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.STDLABORHOURS
		' </summary>
		Public Overridable Property Stdlaborhours As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ApisMetadata.ColumnNames.Stdlaborhours)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ApisMetadata.ColumnNames.Stdlaborhours, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ApisMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ApisMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ApisMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ApisMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ApisMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ApisMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ApisMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ApisMetadata.ColumnNames.Isactive, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.REVISION
		' </summary>
		Public Overridable Property Revision As System.String
			Get
				Return MyBase.GetSystemString(ApisMetadata.ColumnNames.Revision)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisMetadata.ColumnNames.Revision, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ApisMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ApisMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ApisMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.USEAGGREGATELOTNO
		' </summary>
		Public Overridable Property Useaggregatelotno As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ApisMetadata.ColumnNames.Useaggregatelotno)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ApisMetadata.ColumnNames.Useaggregatelotno, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.APISSTATUS
		' </summary>
		Public Overridable Property Apisstatus As System.String
			Get
				Return MyBase.GetSystemString(ApisMetadata.ColumnNames.Apisstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisMetadata.ColumnNames.Apisstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APIS.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisMetadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisMetadata.ColumnNames.Kitid, value)
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
		
			Public Sub New(ByVal entity As esApis)
				Me.entity = entity
			End Sub				
		
	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisdesc As System.String 
				Get
					Dim data_ As System.String = entity.Apisdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisdesc = Nothing
					Else
						entity.Apisdesc = Convert.ToString(Value)
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
		  	
			Public Property Qtycontainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtycontainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtycontainers = Nothing
					Else
						entity.Qtycontainers = Convert.ToInt32(Value)
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
		  	
			Public Property Apisnote As System.String 
				Get
					Dim data_ As System.String = entity.Apisnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnote = Nothing
					Else
						entity.Apisnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdlaborhours As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Stdlaborhours
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdlaborhours = Nothing
					Else
						entity.Stdlaborhours = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitcost = Nothing
					Else
						entity.Unitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Units
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Units = Nothing
					Else
						entity.Units = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
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
		  	
			Public Property Revision As System.String 
				Get
					Dim data_ As System.String = entity.Revision
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Revision = Nothing
					Else
						entity.Revision = Convert.ToString(Value)
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
		  	
			Public Property Useaggregatelotno As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Useaggregatelotno
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Useaggregatelotno = Nothing
					Else
						entity.Useaggregatelotno = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisstatus As System.String 
				Get
					Dim data_ As System.String = entity.Apisstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisstatus = Nothing
					Else
						entity.Apisstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Kitid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Kitid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitid = Nothing
					Else
						entity.Kitid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esApis
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esApisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esApis can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Apis 
		Inherits esApis
		
	
		
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
	MustInherit Public Class esApisQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApisMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Apisdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnote As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Apisnote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdlaborhours As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Stdlaborhours, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Revision As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Revision, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Useaggregatelotno As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Useaggregatelotno, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Apisstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Apisstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, ApisMetadata.ColumnNames.Kitid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ApisCollection")> _
	Partial Public Class ApisCollection
		Inherits esApisCollection
		Implements IEnumerable(Of Apis)
		
        Public Shared Widening Operator CType(ByVal coll As ApisCollection) As List(Of Apis)
            Dim list As List(Of Apis) = New List(Of Apis)
            Dim emp As Apis

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApisMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ApisQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Apis(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Apis()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ApisQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ApisQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApisQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Apis 
			Return CType(MyBase.AddNewEntity(), Apis)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal apisnum As System.Int32) As Apis
			Return CType(MyBase.FindByPrimaryKey(apisnum), Apis)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Apis) Implements IEnumerable(Of Apis).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Apis)(Me)
        End Function
		
		Private _query As ApisQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APIS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Apis ({Apisnum.Value})")> _
	<Serializable> _
	Partial Public Class Apis 
		Inherits esApis

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ApisMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esApisQuery

			If Me._query Is Nothing Then
				Me._query = New ApisQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ApisQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ApisQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApisQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ApisQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ApisQuery
		inherits esApisQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ApisQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ApisMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ApisMetadata.ColumnNames.Apisnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisMetadata.PropertyNames.Apisnum
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Apisdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisMetadata.PropertyNames.Apisdesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Qtycontainers, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisMetadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Custid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Apisnote, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisMetadata.PropertyNames.Apisnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Stdlaborhours, 7, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ApisMetadata.PropertyNames.Stdlaborhours
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Unitcost, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ApisMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Units, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Uom, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Createdtime, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ApisMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Createdby, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Isactive, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ApisMetadata.PropertyNames.Isactive
			c.HasDefault = True
			c.Default = "((1))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Revision, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisMetadata.PropertyNames.Revision
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Modifyby, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Modifytime, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ApisMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Useaggregatelotno, 17, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ApisMetadata.PropertyNames.Useaggregatelotno
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Apisstatus, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisMetadata.PropertyNames.Apisstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisMetadata.ColumnNames.Kitid, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisMetadata.PropertyNames.Kitid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ApisMetadata
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
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Apisdesc As String = "APISDESC"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Container As String = "CONTAINER"
			 Public Const Qtycontainers As String = "QTYCONTAINERS"
			 Public Const Custid As String = "CUSTID"
			 Public Const Apisnote As String = "APISNOTE"
			 Public Const Stdlaborhours As String = "STDLABORHOURS"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Isactive As String = "ISACTIVE"
			 Public Const Revision As String = "REVISION"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Useaggregatelotno As String = "USEAGGREGATELOTNO"
			 Public Const Apisstatus As String = "APISSTATUS"
			 Public Const Kitid As String = "KITID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Apisdesc As String = "Apisdesc"
			 Public Const Productid As String = "Productid"
			 Public Const Container As String = "Container"
			 Public Const Qtycontainers As String = "Qtycontainers"
			 Public Const Custid As String = "Custid"
			 Public Const Apisnote As String = "Apisnote"
			 Public Const Stdlaborhours As String = "Stdlaborhours"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Createdby As String = "Createdby"
			 Public Const Isactive As String = "Isactive"
			 Public Const Revision As String = "Revision"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Useaggregatelotno As String = "Useaggregatelotno"
			 Public Const Apisstatus As String = "Apisstatus"
			 Public Const Kitid As String = "Kitid"
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
            SyncLock GetType(ApisMetadata)
			
				If ApisMetadata.mapDelegates Is Nothing Then
					ApisMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ApisMetadata._meta Is Nothing Then
                    ApisMetadata._meta = New ApisMetadata()
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
				

				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtycontainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdlaborhours", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Revision", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Useaggregatelotno", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Apisstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Kitid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "APIS"
				meta.Destination = "APIS"
				
				meta.spInsert = "proc_APISInsert"
				meta.spUpdate = "proc_APISUpdate"
				meta.spDelete = "proc_APISDelete"
				meta.spLoadAll = "proc_APISLoadAll"
				meta.spLoadByPrimaryKey = "proc_APISLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ApisMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
