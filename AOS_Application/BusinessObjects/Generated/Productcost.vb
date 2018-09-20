'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/27/2018 8:38:35 AM
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
	MustInherit Public Class esProductcostCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ProductcostCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esProductcostQuery)
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
            Me.InitQuery(CType(query, esProductcostQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Productcost) As Productcost
			Return CType(MyBase.DetachEntity(entity), Productcost)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Productcost) As Productcost
			Return CType(MyBase.AttachEntity(entity), Productcost)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ProductcostCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Productcost
            Get
                Return TryCast(MyBase.Item(index), Productcost)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Productcost)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esProductcost	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esProductcostQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal costrecid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(costrecid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(costrecid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal costrecid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(costrecid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(costrecid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal costrecid As System.Int32) As Boolean
		
			Dim query As esProductcostQuery = Me.GetDynamicQuery()
			query.Where(query.Costrecid.Equal(costrecid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal costrecid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("COSTRECID", costrecid)
			
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
												
						Case "Costrecid"
							Me.str.Costrecid = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Effectivedate"
							Me.str.Effectivedate = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Notes"
							Me.str.Notes = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Vendoritemkey"
							Me.str.Vendoritemkey = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Weightunits"
							Me.str.Weightunits = CType(value, string)
												
						Case "Weightstandardcost"
							Me.str.Weightstandardcost = CType(value, string)
												
						Case "Volumeuom"
							Me.str.Volumeuom = CType(value, string)
												
						Case "Volumeunits"
							Me.str.Volumeunits = CType(value, string)
												
						Case "Volumestandardcost"
							Me.str.Volumestandardcost = CType(value, string)
												
						Case "Costmethod"
							Me.str.Costmethod = CType(value, string)
												
						Case "Restrictedtocustomerid"
							Me.str.Restrictedtocustomerid = CType(value, string)
												
						Case "Costtype"
							Me.str.Costtype = CType(value, string)
												
						Case "Isdefaultcostrecord"
							Me.str.Isdefaultcostrecord = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Costrecid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Costrecid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Units = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Effectivedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Effectivedate = CType(value, Nullable(Of System.DateTime))
							End If
						
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
						
						Case "Weightunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightstandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightstandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumeunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumestandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumestandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Restrictedtocustomerid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Restrictedtocustomerid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isdefaultcostrecord"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isdefaultcostrecord = CType(value, Nullable(Of System.Boolean))
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
		' Maps to PRODUCTCOST.COSTRECID
		' </summary>
		Public Overridable Property Costrecid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductcostMetadata.ColumnNames.Costrecid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductcostMetadata.ColumnNames.Costrecid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductcostMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductcostMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductcostMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductcostMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductcostMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductcostMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.EFFECTIVEDATE
		' </summary>
		Public Overridable Property Effectivedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductcostMetadata.ColumnNames.Effectivedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductcostMetadata.ColumnNames.Effectivedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductcostMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductcostMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.NOTES
		' </summary>
		Public Overridable Property Notes As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Notes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Notes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductcostMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductcostMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductcostMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductcostMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.VENDORITEMKEY
		' </summary>
		Public Overridable Property Vendoritemkey As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Vendoritemkey)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Vendoritemkey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductcostMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductcostMetadata.ColumnNames.Isactive, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.WEIGHTUNITS
		' </summary>
		Public Overridable Property Weightunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductcostMetadata.ColumnNames.Weightunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductcostMetadata.ColumnNames.Weightunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.WEIGHTSTANDARDCOST
		' </summary>
		Public Overridable Property Weightstandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductcostMetadata.ColumnNames.Weightstandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductcostMetadata.ColumnNames.Weightstandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.VOLUMEUNITS
		' </summary>
		Public Overridable Property Volumeunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductcostMetadata.ColumnNames.Volumeunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductcostMetadata.ColumnNames.Volumeunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.VOLUMESTANDARDCOST
		' </summary>
		Public Overridable Property Volumestandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductcostMetadata.ColumnNames.Volumestandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductcostMetadata.ColumnNames.Volumestandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.COSTMETHOD
		' </summary>
		Public Overridable Property Costmethod As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Costmethod)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Costmethod, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.RESTRICTEDTOCUSTOMERID
		' </summary>
		Public Overridable Property Restrictedtocustomerid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductcostMetadata.ColumnNames.Restrictedtocustomerid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductcostMetadata.ColumnNames.Restrictedtocustomerid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.COSTTYPE
		' </summary>
		Public Overridable Property Costtype As System.String
			Get
				Return MyBase.GetSystemString(ProductcostMetadata.ColumnNames.Costtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductcostMetadata.ColumnNames.Costtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTCOST.ISDEFAULTCOSTRECORD
		' </summary>
		Public Overridable Property Isdefaultcostrecord As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductcostMetadata.ColumnNames.Isdefaultcostrecord)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductcostMetadata.ColumnNames.Isdefaultcostrecord, value)
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
		
			Public Sub New(ByVal entity As esProductcost)
				Me.entity = entity
			End Sub				
		
	
			Public Property Costrecid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Costrecid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Costrecid = Nothing
					Else
						entity.Costrecid = Convert.ToInt32(Value)
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
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Units
					
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
						entity.Units = Convert.ToDecimal(Value)
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
		  	
			Public Property Effectivedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Effectivedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Effectivedate = Nothing
					Else
						entity.Effectivedate = Convert.ToDateTime(Value)
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
		  	
			Public Property Notes As System.String 
				Get
					Dim data_ As System.String = entity.Notes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Notes = Nothing
					Else
						entity.Notes = Convert.ToString(Value)
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
		  	
			Public Property Vendoritemkey As System.String 
				Get
					Dim data_ As System.String = entity.Vendoritemkey
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoritemkey = Nothing
					Else
						entity.Vendoritemkey = Convert.ToString(Value)
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
		  	
			Public Property Weightstandardcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightstandardcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightstandardcost = Nothing
					Else
						entity.Weightstandardcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeuom As System.String 
				Get
					Dim data_ As System.String = entity.Volumeuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeuom = Nothing
					Else
						entity.Volumeuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeunits = Nothing
					Else
						entity.Volumeunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumestandardcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumestandardcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumestandardcost = Nothing
					Else
						entity.Volumestandardcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Costmethod As System.String 
				Get
					Dim data_ As System.String = entity.Costmethod
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Costmethod = Nothing
					Else
						entity.Costmethod = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Restrictedtocustomerid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Restrictedtocustomerid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Restrictedtocustomerid = Nothing
					Else
						entity.Restrictedtocustomerid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Costtype As System.String 
				Get
					Dim data_ As System.String = entity.Costtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Costtype = Nothing
					Else
						entity.Costtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isdefaultcostrecord As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isdefaultcostrecord
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isdefaultcostrecord = Nothing
					Else
						entity.Isdefaultcostrecord = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esProductcost
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esProductcostQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esProductcost can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Productcost 
		Inherits esProductcost
		
	
		
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
	MustInherit Public Class esProductcostQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProductcostMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Costrecid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Costrecid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Units, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Effectivedate As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Effectivedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Notes As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Notes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoritemkey As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Vendoritemkey, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightunits As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Weightunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightstandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Weightstandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeunits As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Volumeunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumestandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Volumestandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Costmethod As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Costmethod, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Restrictedtocustomerid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Restrictedtocustomerid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Costtype As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Costtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isdefaultcostrecord As esQueryItem
			Get
				Return New esQueryItem(Me, ProductcostMetadata.ColumnNames.Isdefaultcostrecord, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ProductcostCollection")> _
	Partial Public Class ProductcostCollection
		Inherits esProductcostCollection
		Implements IEnumerable(Of Productcost)
		
        Public Shared Widening Operator CType(ByVal coll As ProductcostCollection) As List(Of Productcost)
            Dim list As List(Of Productcost) = New List(Of Productcost)
            Dim emp As Productcost

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProductcostMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ProductcostQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Productcost(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Productcost()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ProductcostQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ProductcostQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProductcostQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Productcost 
			Return CType(MyBase.AddNewEntity(), Productcost)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal costrecid As System.Int32) As Productcost
			Return CType(MyBase.FindByPrimaryKey(costrecid), Productcost)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Productcost) Implements IEnumerable(Of Productcost).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Productcost)(Me)
        End Function
		
		Private _query As ProductcostQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PRODUCTCOST' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Productcost ({Costrecid.Value})")> _
	<Serializable> _
	Partial Public Class Productcost 
		Inherits esProductcost

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ProductcostMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esProductcostQuery

			If Me._query Is Nothing Then
				Me._query = New ProductcostQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ProductcostQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ProductcostQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProductcostQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ProductcostQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ProductcostQuery
		inherits esProductcostQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ProductcostQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ProductcostMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Costrecid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Costrecid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Uom, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Units, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Units
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Unitcost, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Effectivedate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Effectivedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Vendorid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Notes, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Notes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Createdby, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Createdtime, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Modifyby, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Modifytime, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Vendoritemkey, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Vendoritemkey
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Isactive, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Isactive
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Weightuom, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Weightunits, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Weightunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Weightstandardcost, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Weightstandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Volumeuom, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Volumeunits, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Volumeunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Volumestandardcost, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Volumestandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Costmethod, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Costmethod
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Restrictedtocustomerid, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Restrictedtocustomerid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Costtype, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Costtype
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductcostMetadata.ColumnNames.Isdefaultcostrecord, 23, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductcostMetadata.PropertyNames.Isdefaultcostrecord
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ProductcostMetadata
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
			 Public Const Costrecid As String = "COSTRECID"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Uom As String = "UOM"
			 Public Const Units As String = "UNITS"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Effectivedate As String = "EFFECTIVEDATE"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Notes As String = "NOTES"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Vendoritemkey As String = "VENDORITEMKEY"
			 Public Const Isactive As String = "ISACTIVE"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Weightunits As String = "WEIGHTUNITS"
			 Public Const Weightstandardcost As String = "WEIGHTSTANDARDCOST"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Volumeunits As String = "VOLUMEUNITS"
			 Public Const Volumestandardcost As String = "VOLUMESTANDARDCOST"
			 Public Const Costmethod As String = "COSTMETHOD"
			 Public Const Restrictedtocustomerid As String = "RESTRICTEDTOCUSTOMERID"
			 Public Const Costtype As String = "COSTTYPE"
			 Public Const Isdefaultcostrecord As String = "ISDEFAULTCOSTRECORD"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Costrecid As String = "Costrecid"
			 Public Const Productid As String = "Productid"
			 Public Const Uom As String = "Uom"
			 Public Const Units As String = "Units"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Effectivedate As String = "Effectivedate"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Notes As String = "Notes"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Vendoritemkey As String = "Vendoritemkey"
			 Public Const Isactive As String = "Isactive"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Weightunits As String = "Weightunits"
			 Public Const Weightstandardcost As String = "Weightstandardcost"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Volumeunits As String = "Volumeunits"
			 Public Const Volumestandardcost As String = "Volumestandardcost"
			 Public Const Costmethod As String = "Costmethod"
			 Public Const Restrictedtocustomerid As String = "Restrictedtocustomerid"
			 Public Const Costtype As String = "Costtype"
			 Public Const Isdefaultcostrecord As String = "Isdefaultcostrecord"
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
            SyncLock GetType(ProductcostMetadata)
			
				If ProductcostMetadata.mapDelegates Is Nothing Then
					ProductcostMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ProductcostMetadata._meta Is Nothing Then
                    ProductcostMetadata._meta = New ProductcostMetadata()
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
				

				meta.AddTypeMap("Costrecid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Effectivedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Vendoritemkey", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightstandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumeunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumestandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Costmethod", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Restrictedtocustomerid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Costtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isdefaultcostrecord", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "PRODUCTCOST"
				meta.Destination = "PRODUCTCOST"
				
				meta.spInsert = "proc_PRODUCTCOSTInsert"
				meta.spUpdate = "proc_PRODUCTCOSTUpdate"
				meta.spDelete = "proc_PRODUCTCOSTDelete"
				meta.spLoadAll = "proc_PRODUCTCOSTLoadAll"
				meta.spLoadByPrimaryKey = "proc_PRODUCTCOSTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ProductcostMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
