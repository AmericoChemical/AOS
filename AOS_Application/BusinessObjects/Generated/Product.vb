'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/19/2017 12:41:17 PM
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
	MustInherit Public Class esProductCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ProductCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esProductQuery)
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
            Me.InitQuery(CType(query, esProductQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Product) As Product
			Return CType(MyBase.DetachEntity(entity), Product)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Product) As Product
			Return CType(MyBase.AttachEntity(entity), Product)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ProductCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Product
            Get
                Return TryCast(MyBase.Item(index), Product)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Product)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esProduct	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esProductQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal productid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(productid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(productid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal productid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(productid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(productid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal productid As System.Int32) As Boolean
		
			Dim query As esProductQuery = Me.GetDynamicQuery()
			query.Where(query.Productid.Equal(productid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal productid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PRODUCTID", productid)
			
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Stdweight"
							Me.str.Stdweight = CType(value, string)
												
						Case "Stdgallons"
							Me.str.Stdgallons = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Health"
							Me.str.Health = CType(value, string)
												
						Case "Fire"
							Me.str.Fire = CType(value, string)
												
						Case "Reactivity"
							Me.str.Reactivity = CType(value, string)
												
						Case "Personalprotection"
							Me.str.Personalprotection = CType(value, string)
												
						Case "Dotdesc"
							Me.str.Dotdesc = CType(value, string)
												
						Case "Hazmatdesc"
							Me.str.Hazmatdesc = CType(value, string)
												
						Case "Unline"
							Me.str.Unline = CType(value, string)
												
						Case "Placardrequired"
							Me.str.Placardrequired = CType(value, string)
												
						Case "Classrate"
							Me.str.Classrate = CType(value, string)
												
						Case "Hazmatid"
							Me.str.Hazmatid = CType(value, string)
												
						Case "Qtyonhand"
							Me.str.Qtyonhand = CType(value, string)
												
						Case "Qtyallocated"
							Me.str.Qtyallocated = CType(value, string)
												
						Case "Qtyonorder"
							Me.str.Qtyonorder = CType(value, string)
												
						Case "Qtyforsale"
							Me.str.Qtyforsale = CType(value, string)
												
						Case "Qtyminonhand"
							Me.str.Qtyminonhand = CType(value, string)
												
						Case "Reorderqty"
							Me.str.Reorderqty = CType(value, string)
												
						Case "Preferredvendorid"
							Me.str.Preferredvendorid = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Datecostlastchanged"
							Me.str.Datecostlastchanged = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Desc2"
							Me.str.Desc2 = CType(value, string)
												
						Case "Inventoryclass"
							Me.str.Inventoryclass = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Isliquid"
							Me.str.Isliquid = CType(value, string)
												
						Case "Rawmaterialgroup"
							Me.str.Rawmaterialgroup = CType(value, string)
												
						Case "Inventorygrouping"
							Me.str.Inventorygrouping = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Weightunits"
							Me.str.Weightunits = CType(value, string)
												
						Case "Volumeuom"
							Me.str.Volumeuom = CType(value, string)
												
						Case "Volumeunits"
							Me.str.Volumeunits = CType(value, string)
												
						Case "Inventorymethod"
							Me.str.Inventorymethod = CType(value, string)
												
						Case "Unnumber"
							Me.str.Unnumber = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Phrangelow"
							Me.str.Phrangelow = CType(value, string)
												
						Case "Phrangehigh"
							Me.str.Phrangehigh = CType(value, string)
												
						Case "Sgrangelow"
							Me.str.Sgrangelow = CType(value, string)
												
						Case "Sgrangehigh"
							Me.str.Sgrangehigh = CType(value, string)
												
						Case "Needstesting"
							Me.str.Needstesting = CType(value, string)
												
						Case "Shelflife"
							Me.str.Shelflife = CType(value, string)
												
						Case "Hazclassnumber"
							Me.str.Hazclassnumber = CType(value, string)
												
						Case "Packagegroup"
							Me.str.Packagegroup = CType(value, string)
												
						Case "Chemicalid"
							Me.str.Chemicalid = CType(value, string)
												
						Case "Idnumber"
							Me.str.Idnumber = CType(value, string)
												
						Case "State"
							Me.str.State = CType(value, string)
												
						Case "Isinhazox"
							Me.str.Isinhazox = CType(value, string)
												
						Case "Istoxic"
							Me.str.Istoxic = CType(value, string)
												
						Case "Productstatus"
							Me.str.Productstatus = CType(value, string)
												
						Case "Purchasingnotes"
							Me.str.Purchasingnotes = CType(value, string)
												
						Case "Receivingnotes"
							Me.str.Receivingnotes = CType(value, string)
												
						Case "Secondaryhazclassnumber"
							Me.str.Secondaryhazclassnumber = CType(value, string)
												
						Case "Volumestandardcost"
							Me.str.Volumestandardcost = CType(value, string)
												
						Case "Weightstandardcost"
							Me.str.Weightstandardcost = CType(value, string)
												
						Case "Labeltype"
							Me.str.Labeltype = CType(value, string)
												
						Case "Labeldefaultqty"
							Me.str.Labeldefaultqty = CType(value, string)
												
						Case "Chemicalcolor"
							Me.str.Chemicalcolor = CType(value, string)
												
						Case "Chemicalclarity"
							Me.str.Chemicalclarity = CType(value, string)
												
						Case "Rq"
							Me.str.Rq = CType(value, string)
												
						Case "Standardcostnotes"
							Me.str.Standardcostnotes = CType(value, string)
												
						Case "Bulkinventory"
							Me.str.Bulkinventory = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdweight = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdgallons"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdgallons = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Health"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Health = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Fire"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Reactivity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Reactivity = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Hazmatid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Hazmatid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyonhand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyonhand = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyallocated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyallocated = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyonorder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyonorder = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyforsale"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyforsale = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyminonhand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyminonhand = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Reorderqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Reorderqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Preferredvendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Preferredvendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Datecostlastchanged"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Datecostlastchanged = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Units = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Inventoryclass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isliquid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isliquid = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Inventorygrouping"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventorygrouping = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Weightunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumeunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Unnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Phrangelow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phrangelow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phrangehigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phrangehigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgrangelow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgrangelow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgrangehigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgrangehigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Needstesting"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Needstesting = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Chemicalid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isinhazox"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isinhazox = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Istoxic"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Istoxic = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Volumestandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumestandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightstandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightstandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Labeldefaultqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Labeldefaultqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rq"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Rq = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Bulkinventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Bulkinventory = CType(value, Nullable(Of System.Boolean))
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
		' Maps to PRODUCT.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.HEALTH
		' </summary>
		Public Overridable Property Health As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Health)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Health, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.FIRE
		' </summary>
		Public Overridable Property Fire As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Fire)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Fire, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.REACTIVITY
		' </summary>
		Public Overridable Property Reactivity As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Reactivity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Reactivity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PERSONALPROTECTION
		' </summary>
		Public Overridable Property Personalprotection As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Personalprotection)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Personalprotection, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PLACARDREQUIRED
		' </summary>
		Public Overridable Property Placardrequired As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Placardrequired)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Placardrequired, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.QTYONHAND
		' </summary>
		Public Overridable Property Qtyonhand As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Qtyonhand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Qtyonhand, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.QTYALLOCATED
		' </summary>
		Public Overridable Property Qtyallocated As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Qtyallocated)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Qtyallocated, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.QTYONORDER
		' </summary>
		Public Overridable Property Qtyonorder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Qtyonorder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Qtyonorder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.QTYFORSALE
		' </summary>
		Public Overridable Property Qtyforsale As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Qtyforsale)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Qtyforsale, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.QTYMINONHAND
		' </summary>
		Public Overridable Property Qtyminonhand As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Qtyminonhand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Qtyminonhand, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.REORDERQTY
		' </summary>
		Public Overridable Property Reorderqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Reorderqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Reorderqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PREFERREDVENDORID
		' </summary>
		Public Overridable Property Preferredvendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Preferredvendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Preferredvendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.DATECOSTLASTCHANGED
		' </summary>
		Public Overridable Property Datecostlastchanged As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductMetadata.ColumnNames.Datecostlastchanged)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductMetadata.ColumnNames.Datecostlastchanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.DESC2
		' </summary>
		Public Overridable Property Desc2 As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Desc2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Desc2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.INVENTORYCLASS
		' </summary>
		Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Inventoryclass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Inventoryclass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductMetadata.ColumnNames.Isactive, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.ISLIQUID
		' </summary>
		Public Overridable Property Isliquid As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductMetadata.ColumnNames.Isliquid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductMetadata.ColumnNames.Isliquid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.RAWMATERIALGROUP
		' </summary>
		Public Overridable Property Rawmaterialgroup As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Rawmaterialgroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Rawmaterialgroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.INVENTORYGROUPING
		' </summary>
		Public Overridable Property Inventorygrouping As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Inventorygrouping)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Inventorygrouping, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.WEIGHTUNITS
		' </summary>
		Public Overridable Property Weightunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Weightunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Weightunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.VOLUMEUNITS
		' </summary>
		Public Overridable Property Volumeunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Volumeunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Volumeunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.INVENTORYMETHOD
		' </summary>
		Public Overridable Property Inventorymethod As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Inventorymethod)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Inventorymethod, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.UNNUMBER
		' </summary>
		Public Overridable Property Unnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Unnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Unnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PHRANGELOW
		' </summary>
		Public Overridable Property Phrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Phrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Phrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PHRANGEHIGH
		' </summary>
		Public Overridable Property Phrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Phrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Phrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.SGRANGELOW
		' </summary>
		Public Overridable Property Sgrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Sgrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Sgrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.SGRANGEHIGH
		' </summary>
		Public Overridable Property Sgrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Sgrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Sgrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.NEEDSTESTING
		' </summary>
		Public Overridable Property Needstesting As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductMetadata.ColumnNames.Needstesting)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductMetadata.ColumnNames.Needstesting, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.SHELFLIFE
		' </summary>
		Public Overridable Property Shelflife As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Shelflife)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Shelflife, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.HAZCLASSNUMBER
		' </summary>
		Public Overridable Property Hazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Hazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Hazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PACKAGEGROUP
		' </summary>
		Public Overridable Property Packagegroup As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Packagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Packagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.IDNUMBER
		' </summary>
		Public Overridable Property Idnumber As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Idnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Idnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.STATE
		' </summary>
		Public Overridable Property State As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.State)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.State, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.ISINHAZOX
		' </summary>
		Public Overridable Property Isinhazox As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductMetadata.ColumnNames.Isinhazox)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductMetadata.ColumnNames.Isinhazox, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.ISTOXIC
		' </summary>
		Public Overridable Property Istoxic As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductMetadata.ColumnNames.Istoxic)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductMetadata.ColumnNames.Istoxic, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PRODUCTSTATUS
		' </summary>
		Public Overridable Property Productstatus As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Productstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Productstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.PURCHASINGNOTES
		' </summary>
		Public Overridable Property Purchasingnotes As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Purchasingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Purchasingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.RECEIVINGNOTES
		' </summary>
		Public Overridable Property Receivingnotes As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Receivingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Receivingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.SECONDARYHAZCLASSNUMBER
		' </summary>
		Public Overridable Property Secondaryhazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Secondaryhazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Secondaryhazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.VOLUMESTANDARDCOST
		' </summary>
		Public Overridable Property Volumestandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Volumestandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Volumestandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.WEIGHTSTANDARDCOST
		' </summary>
		Public Overridable Property Weightstandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProductMetadata.ColumnNames.Weightstandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProductMetadata.ColumnNames.Weightstandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.LABELTYPE
		' </summary>
		Public Overridable Property Labeltype As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Labeltype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Labeltype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.LABELDEFAULTQTY
		' </summary>
		Public Overridable Property Labeldefaultqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductMetadata.ColumnNames.Labeldefaultqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductMetadata.ColumnNames.Labeldefaultqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.CHEMICALCOLOR
		' </summary>
		Public Overridable Property Chemicalcolor As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Chemicalcolor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Chemicalcolor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.CHEMICALCLARITY
		' </summary>
		Public Overridable Property Chemicalclarity As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Chemicalclarity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Chemicalclarity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.RQ
		' </summary>
		Public Overridable Property Rq As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductMetadata.ColumnNames.Rq)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductMetadata.ColumnNames.Rq, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.STANDARDCOSTNOTES
		' </summary>
		Public Overridable Property Standardcostnotes As System.String
			Get
				Return MyBase.GetSystemString(ProductMetadata.ColumnNames.Standardcostnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductMetadata.ColumnNames.Standardcostnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCT.BULKINVENTORY
		' </summary>
		Public Overridable Property Bulkinventory As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProductMetadata.ColumnNames.Bulkinventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProductMetadata.ColumnNames.Bulkinventory, value)
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
		
			Public Sub New(ByVal entity As esProduct)
				Me.entity = entity
			End Sub				
		
	
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
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdweight
					
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
						entity.Stdweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdgallons As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdgallons
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdgallons = Nothing
					Else
						entity.Stdgallons = Convert.ToDecimal(Value)
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
		  	
			Public Property Health As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Health
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Health = Nothing
					Else
						entity.Health = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire = Nothing
					Else
						entity.Fire = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reactivity As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Reactivity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reactivity = Nothing
					Else
						entity.Reactivity = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Personalprotection As System.String 
				Get
					Dim data_ As System.String = entity.Personalprotection
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Personalprotection = Nothing
					Else
						entity.Personalprotection = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dotdesc As System.String 
				Get
					Dim data_ As System.String = entity.Dotdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dotdesc = Nothing
					Else
						entity.Dotdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazmatdesc As System.String 
				Get
					Dim data_ As System.String = entity.Hazmatdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatdesc = Nothing
					Else
						entity.Hazmatdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unline As System.String 
				Get
					Dim data_ As System.String = entity.Unline
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unline = Nothing
					Else
						entity.Unline = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Placardrequired As System.String 
				Get
					Dim data_ As System.String = entity.Placardrequired
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Placardrequired = Nothing
					Else
						entity.Placardrequired = Convert.ToString(Value)
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
		  	
			Public Property Hazmatid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Hazmatid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatid = Nothing
					Else
						entity.Hazmatid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyonhand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyonhand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyonhand = Nothing
					Else
						entity.Qtyonhand = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyallocated As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyallocated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyallocated = Nothing
					Else
						entity.Qtyallocated = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyonorder As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyonorder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyonorder = Nothing
					Else
						entity.Qtyonorder = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyforsale As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyforsale
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyforsale = Nothing
					Else
						entity.Qtyforsale = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyminonhand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyminonhand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyminonhand = Nothing
					Else
						entity.Qtyminonhand = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reorderqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Reorderqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reorderqty = Nothing
					Else
						entity.Reorderqty = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Preferredvendorid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Preferredvendorid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Preferredvendorid = Nothing
					Else
						entity.Preferredvendorid = Convert.ToInt32(Value)
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
		  	
			Public Property Datecostlastchanged As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Datecostlastchanged
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datecostlastchanged = Nothing
					Else
						entity.Datecostlastchanged = Convert.ToDateTime(Value)
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
		  	
			Public Property Desc2 As System.String 
				Get
					Dim data_ As System.String = entity.Desc2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Desc2 = Nothing
					Else
						entity.Desc2 = Convert.ToString(Value)
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
		  	
			Public Property Isliquid As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isliquid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isliquid = Nothing
					Else
						entity.Isliquid = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rawmaterialgroup As System.String 
				Get
					Dim data_ As System.String = entity.Rawmaterialgroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rawmaterialgroup = Nothing
					Else
						entity.Rawmaterialgroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventorygrouping As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Inventorygrouping
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventorygrouping = Nothing
					Else
						entity.Inventorygrouping = Convert.ToInt32(Value)
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
		  	
			Public Property Inventorymethod As System.String 
				Get
					Dim data_ As System.String = entity.Inventorymethod
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventorymethod = Nothing
					Else
						entity.Inventorymethod = Convert.ToString(Value)
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
		  	
			Public Property Phrangelow As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Phrangelow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phrangelow = Nothing
					Else
						entity.Phrangelow = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phrangehigh As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Phrangehigh
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phrangehigh = Nothing
					Else
						entity.Phrangehigh = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sgrangelow As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sgrangelow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sgrangelow = Nothing
					Else
						entity.Sgrangelow = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sgrangehigh As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sgrangehigh
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sgrangehigh = Nothing
					Else
						entity.Sgrangehigh = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Needstesting As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Needstesting
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Needstesting = Nothing
					Else
						entity.Needstesting = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shelflife As System.String 
				Get
					Dim data_ As System.String = entity.Shelflife
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shelflife = Nothing
					Else
						entity.Shelflife = Convert.ToString(Value)
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
		  	
			Public Property Chemicalid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Chemicalid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalid = Nothing
					Else
						entity.Chemicalid = Convert.ToInt32(Value)
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
		  	
			Public Property State As System.String 
				Get
					Dim data_ As System.String = entity.State
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.State = Nothing
					Else
						entity.State = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isinhazox As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isinhazox
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isinhazox = Nothing
					Else
						entity.Isinhazox = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Istoxic As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Istoxic
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Istoxic = Nothing
					Else
						entity.Istoxic = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productstatus As System.String 
				Get
					Dim data_ As System.String = entity.Productstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productstatus = Nothing
					Else
						entity.Productstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchasingnotes As System.String 
				Get
					Dim data_ As System.String = entity.Purchasingnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasingnotes = Nothing
					Else
						entity.Purchasingnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Receivingnotes As System.String 
				Get
					Dim data_ As System.String = entity.Receivingnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receivingnotes = Nothing
					Else
						entity.Receivingnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Secondaryhazclassnumber As System.String 
				Get
					Dim data_ As System.String = entity.Secondaryhazclassnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Secondaryhazclassnumber = Nothing
					Else
						entity.Secondaryhazclassnumber = Convert.ToString(Value)
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
		  	
			Public Property Labeltype As System.String 
				Get
					Dim data_ As System.String = entity.Labeltype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Labeltype = Nothing
					Else
						entity.Labeltype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Labeldefaultqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Labeldefaultqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Labeldefaultqty = Nothing
					Else
						entity.Labeldefaultqty = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalcolor As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalcolor = Nothing
					Else
						entity.Chemicalcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalclarity As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalclarity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalclarity = Nothing
					Else
						entity.Chemicalclarity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rq As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Rq
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rq = Nothing
					Else
						entity.Rq = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Standardcostnotes As System.String 
				Get
					Dim data_ As System.String = entity.Standardcostnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Standardcostnotes = Nothing
					Else
						entity.Standardcostnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bulkinventory As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Bulkinventory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bulkinventory = Nothing
					Else
						entity.Bulkinventory = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esProduct
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esProductQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esProduct can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Product 
		Inherits esProduct
		
	
		
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
	MustInherit Public Class esProductQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProductMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Stdweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Stdgallons, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Health As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Health, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Fire, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reactivity As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Reactivity, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Personalprotection As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Personalprotection, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardrequired As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Placardrequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyonhand As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Qtyonhand, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyallocated As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Qtyallocated, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyonorder As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Qtyonorder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyforsale As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Qtyforsale, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyminonhand As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Qtyminonhand, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reorderqty As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Reorderqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Preferredvendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Preferredvendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Datecostlastchanged As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Datecostlastchanged, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Units, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Desc2 As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Desc2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoryclass As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Isliquid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Isliquid, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Rawmaterialgroup As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Rawmaterialgroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventorygrouping As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Inventorygrouping, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightunits As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Weightunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeunits As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Volumeunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Inventorymethod As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Inventorymethod, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Unnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Phrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Phrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Sgrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Sgrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Needstesting As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Needstesting, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Shelflife As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Shelflife, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Hazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Packagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Packagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Idnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Idnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property State As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.State, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isinhazox As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Isinhazox, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Istoxic As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Istoxic, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Productstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Productstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Purchasingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Receivingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Receivingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Secondaryhazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Secondaryhazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumestandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Volumestandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightstandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Weightstandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Labeltype As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Labeltype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Labeldefaultqty As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Labeldefaultqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Chemicalcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalclarity As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Chemicalclarity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rq As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Rq, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Standardcostnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bulkinventory As esQueryItem
			Get
				Return New esQueryItem(Me, ProductMetadata.ColumnNames.Bulkinventory, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ProductCollection")> _
	Partial Public Class ProductCollection
		Inherits esProductCollection
		Implements IEnumerable(Of Product)
		
        Public Shared Widening Operator CType(ByVal coll As ProductCollection) As List(Of Product)
            Dim list As List(Of Product) = New List(Of Product)
            Dim emp As Product

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ProductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Product(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Product()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ProductQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ProductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Product 
			Return CType(MyBase.AddNewEntity(), Product)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal productid As System.Int32) As Product
			Return CType(MyBase.FindByPrimaryKey(productid), Product)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Product) Implements IEnumerable(Of Product).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Product)(Me)
        End Function
		
		Private _query As ProductQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PRODUCT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Product ({Productid.Value})")> _
	<Serializable> _
	Partial Public Class Product 
		Inherits esProduct

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ProductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esProductQuery

			If Me._query Is Nothing Then
				Me._query = New ProductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ProductQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ProductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ProductQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ProductQuery
		inherits esProductQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ProductQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ProductMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ProductMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Productid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Stdweight, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Stdgallons, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Stdgallons
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Container, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Health, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Health
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Fire, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Fire
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Reactivity, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Reactivity
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Personalprotection, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Personalprotection
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Dotdesc, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Hazmatdesc, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Unline, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Placardrequired, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Placardrequired
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Classrate, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Hazmatid, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Qtyonhand, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Qtyonhand
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Qtyallocated, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Qtyallocated
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Qtyonorder, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Qtyonorder
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Qtyforsale, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Qtyforsale
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Qtyminonhand, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Qtyminonhand
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Reorderqty, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Reorderqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Preferredvendorid, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Preferredvendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Unitcost, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Datecostlastchanged, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductMetadata.PropertyNames.Datecostlastchanged
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Units, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Units
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Uom, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Desc2, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Desc2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Inventoryclass, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Inventoryclass
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Isactive, 28, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductMetadata.PropertyNames.Isactive
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Custid, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Isliquid, 30, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductMetadata.PropertyNames.Isliquid
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Rawmaterialgroup, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Rawmaterialgroup
			c.CharacterMaxLength = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Inventorygrouping, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Inventorygrouping
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Weightuom, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Weightunits, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Weightunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Volumeuom, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Volumeunits, 36, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Volumeunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Inventorymethod, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Inventorymethod
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Unnumber, 38, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Unnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Createdby, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Createdtime, 40, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Modifyby, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Modifytime, 42, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Phrangelow, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Phrangelow
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Phrangehigh, 44, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Phrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Sgrangelow, 45, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Sgrangelow
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Sgrangehigh, 46, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Sgrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Needstesting, 47, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductMetadata.PropertyNames.Needstesting
			c.HasDefault = True
			c.Default = "((1))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Shelflife, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Shelflife
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Hazclassnumber, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Hazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Packagegroup, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Packagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Chemicalid, 51, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Chemicalid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Idnumber, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Idnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.State, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.State
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Isinhazox, 54, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductMetadata.PropertyNames.Isinhazox
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Istoxic, 55, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductMetadata.PropertyNames.Istoxic
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Productstatus, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Productstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Purchasingnotes, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Purchasingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Receivingnotes, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Receivingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Secondaryhazclassnumber, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Secondaryhazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Volumestandardcost, 60, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Volumestandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Weightstandardcost, 61, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProductMetadata.PropertyNames.Weightstandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Labeltype, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Labeltype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Labeldefaultqty, 63, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductMetadata.PropertyNames.Labeldefaultqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Chemicalcolor, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Chemicalcolor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Chemicalclarity, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Chemicalclarity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Rq, 66, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductMetadata.PropertyNames.Rq
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Standardcostnotes, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductMetadata.PropertyNames.Standardcostnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductMetadata.ColumnNames.Bulkinventory, 68, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProductMetadata.PropertyNames.Bulkinventory
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ProductMetadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Stdgallons As String = "STDGALLONS"
			 Public Const Container As String = "CONTAINER"
			 Public Const Health As String = "HEALTH"
			 Public Const Fire As String = "FIRE"
			 Public Const Reactivity As String = "REACTIVITY"
			 Public Const Personalprotection As String = "PERSONALPROTECTION"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Unline As String = "UNLINE"
			 Public Const Placardrequired As String = "PLACARDREQUIRED"
			 Public Const Classrate As String = "CLASSRATE"
			 Public Const Hazmatid As String = "HAZMATID"
			 Public Const Qtyonhand As String = "QTYONHAND"
			 Public Const Qtyallocated As String = "QTYALLOCATED"
			 Public Const Qtyonorder As String = "QTYONORDER"
			 Public Const Qtyforsale As String = "QTYFORSALE"
			 Public Const Qtyminonhand As String = "QTYMINONHAND"
			 Public Const Reorderqty As String = "REORDERQTY"
			 Public Const Preferredvendorid As String = "PREFERREDVENDORID"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Datecostlastchanged As String = "DATECOSTLASTCHANGED"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Desc2 As String = "DESC2"
			 Public Const Inventoryclass As String = "INVENTORYCLASS"
			 Public Const Isactive As String = "ISACTIVE"
			 Public Const Custid As String = "CUSTID"
			 Public Const Isliquid As String = "ISLIQUID"
			 Public Const Rawmaterialgroup As String = "RAWMATERIALGROUP"
			 Public Const Inventorygrouping As String = "INVENTORYGROUPING"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Weightunits As String = "WEIGHTUNITS"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Volumeunits As String = "VOLUMEUNITS"
			 Public Const Inventorymethod As String = "INVENTORYMETHOD"
			 Public Const Unnumber As String = "UNNUMBER"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Phrangelow As String = "PHRANGELOW"
			 Public Const Phrangehigh As String = "PHRANGEHIGH"
			 Public Const Sgrangelow As String = "SGRANGELOW"
			 Public Const Sgrangehigh As String = "SGRANGEHIGH"
			 Public Const Needstesting As String = "NEEDSTESTING"
			 Public Const Shelflife As String = "SHELFLIFE"
			 Public Const Hazclassnumber As String = "HAZCLASSNUMBER"
			 Public Const Packagegroup As String = "PACKAGEGROUP"
			 Public Const Chemicalid As String = "CHEMICALID"
			 Public Const Idnumber As String = "IDNUMBER"
			 Public Const State As String = "STATE"
			 Public Const Isinhazox As String = "ISINHAZOX"
			 Public Const Istoxic As String = "ISTOXIC"
			 Public Const Productstatus As String = "PRODUCTSTATUS"
			 Public Const Purchasingnotes As String = "PURCHASINGNOTES"
			 Public Const Receivingnotes As String = "RECEIVINGNOTES"
			 Public Const Secondaryhazclassnumber As String = "SECONDARYHAZCLASSNUMBER"
			 Public Const Volumestandardcost As String = "VOLUMESTANDARDCOST"
			 Public Const Weightstandardcost As String = "WEIGHTSTANDARDCOST"
			 Public Const Labeltype As String = "LABELTYPE"
			 Public Const Labeldefaultqty As String = "LABELDEFAULTQTY"
			 Public Const Chemicalcolor As String = "CHEMICALCOLOR"
			 Public Const Chemicalclarity As String = "CHEMICALCLARITY"
			 Public Const Rq As String = "RQ"
			 Public Const Standardcostnotes As String = "STANDARDCOSTNOTES"
			 Public Const Bulkinventory As String = "BULKINVENTORY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Stdgallons As String = "Stdgallons"
			 Public Const Container As String = "Container"
			 Public Const Health As String = "Health"
			 Public Const Fire As String = "Fire"
			 Public Const Reactivity As String = "Reactivity"
			 Public Const Personalprotection As String = "Personalprotection"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Unline As String = "Unline"
			 Public Const Placardrequired As String = "Placardrequired"
			 Public Const Classrate As String = "Classrate"
			 Public Const Hazmatid As String = "Hazmatid"
			 Public Const Qtyonhand As String = "Qtyonhand"
			 Public Const Qtyallocated As String = "Qtyallocated"
			 Public Const Qtyonorder As String = "Qtyonorder"
			 Public Const Qtyforsale As String = "Qtyforsale"
			 Public Const Qtyminonhand As String = "Qtyminonhand"
			 Public Const Reorderqty As String = "Reorderqty"
			 Public Const Preferredvendorid As String = "Preferredvendorid"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Datecostlastchanged As String = "Datecostlastchanged"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Desc2 As String = "Desc2"
			 Public Const Inventoryclass As String = "Inventoryclass"
			 Public Const Isactive As String = "Isactive"
			 Public Const Custid As String = "Custid"
			 Public Const Isliquid As String = "Isliquid"
			 Public Const Rawmaterialgroup As String = "Rawmaterialgroup"
			 Public Const Inventorygrouping As String = "Inventorygrouping"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Weightunits As String = "Weightunits"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Volumeunits As String = "Volumeunits"
			 Public Const Inventorymethod As String = "Inventorymethod"
			 Public Const Unnumber As String = "Unnumber"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Phrangelow As String = "Phrangelow"
			 Public Const Phrangehigh As String = "Phrangehigh"
			 Public Const Sgrangelow As String = "Sgrangelow"
			 Public Const Sgrangehigh As String = "Sgrangehigh"
			 Public Const Needstesting As String = "Needstesting"
			 Public Const Shelflife As String = "Shelflife"
			 Public Const Hazclassnumber As String = "Hazclassnumber"
			 Public Const Packagegroup As String = "Packagegroup"
			 Public Const Chemicalid As String = "Chemicalid"
			 Public Const Idnumber As String = "Idnumber"
			 Public Const State As String = "State"
			 Public Const Isinhazox As String = "Isinhazox"
			 Public Const Istoxic As String = "Istoxic"
			 Public Const Productstatus As String = "Productstatus"
			 Public Const Purchasingnotes As String = "Purchasingnotes"
			 Public Const Receivingnotes As String = "Receivingnotes"
			 Public Const Secondaryhazclassnumber As String = "Secondaryhazclassnumber"
			 Public Const Volumestandardcost As String = "Volumestandardcost"
			 Public Const Weightstandardcost As String = "Weightstandardcost"
			 Public Const Labeltype As String = "Labeltype"
			 Public Const Labeldefaultqty As String = "Labeldefaultqty"
			 Public Const Chemicalcolor As String = "Chemicalcolor"
			 Public Const Chemicalclarity As String = "Chemicalclarity"
			 Public Const Rq As String = "Rq"
			 Public Const Standardcostnotes As String = "Standardcostnotes"
			 Public Const Bulkinventory As String = "Bulkinventory"
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
            SyncLock GetType(ProductMetadata)
			
				If ProductMetadata.mapDelegates Is Nothing Then
					ProductMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ProductMetadata._meta Is Nothing Then
                    ProductMetadata._meta = New ProductMetadata()
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
				

				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdweight", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Stdgallons", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Health", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Reactivity", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Personalprotection", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Placardrequired", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Classrate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyonhand", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyallocated", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyonorder", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyforsale", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyminonhand", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Reorderqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Preferredvendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Datecostlastchanged", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Units", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Desc2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventoryclass", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Isliquid", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Rawmaterialgroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventorygrouping", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumeunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Inventorymethod", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Phrangelow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phrangehigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgrangelow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgrangehigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Needstesting", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Shelflife", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Packagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Idnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("State", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isinhazox", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Istoxic", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Productstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchasingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Receivingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Secondaryhazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumestandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightstandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Labeltype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Labeldefaultqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalcolor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalclarity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rq", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Standardcostnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Bulkinventory", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "PRODUCT"
				meta.Destination = "PRODUCT"
				
				meta.spInsert = "proc_PRODUCTInsert"
				meta.spUpdate = "proc_PRODUCTUpdate"
				meta.spDelete = "proc_PRODUCTDelete"
				meta.spLoadAll = "proc_PRODUCTLoadAll"
				meta.spLoadByPrimaryKey = "proc_PRODUCTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ProductMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
