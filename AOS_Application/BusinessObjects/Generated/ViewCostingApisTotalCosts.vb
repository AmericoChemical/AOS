'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/30/2016 7:21:48 PM
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
	MustInherit Public Class esViewCostingApisTotalCostsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCostingApisTotalCostsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCostingApisTotalCostsQuery)
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
            Me.InitQuery(CType(query, esViewCostingApisTotalCostsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCostingApisTotalCosts) As ViewCostingApisTotalCosts
			Return CType(MyBase.DetachEntity(entity), ViewCostingApisTotalCosts)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCostingApisTotalCosts) As ViewCostingApisTotalCosts
			Return CType(MyBase.AttachEntity(entity), ViewCostingApisTotalCosts)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCostingApisTotalCostsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCostingApisTotalCosts
            Get
                Return TryCast(MyBase.Item(index), ViewCostingApisTotalCosts)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCostingApisTotalCosts)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCostingApisTotalCosts	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCostingApisTotalCostsQuery
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
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Qtycontainers"
							Me.str.Qtycontainers = CType(value, string)
												
						Case "Volume"
							Me.str.Volume = CType(value, string)
												
						Case "Weight"
							Me.str.Weight = CType(value, string)
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
												
						Case "Stdlaborhours"
							Me.str.Stdlaborhours = CType(value, string)
												
						Case "TotMAT"
							Me.str.TotMAT = CType(value, string)
												
						Case "TotKIT"
							Me.str.TotKIT = CType(value, string)
												
						Case "Stdvolunits"
							Me.str.Stdvolunits = CType(value, string)
												
						Case "Stdvoluom"
							Me.str.Stdvoluom = CType(value, string)
												
						Case "Stdvolunitcost"
							Me.str.Stdvolunitcost = CType(value, string)
												
						Case "Stdwgtunits"
							Me.str.Stdwgtunits = CType(value, string)
												
						Case "Stdwgtuom"
							Me.str.Stdwgtuom = CType(value, string)
												
						Case "Stdwgtunitcost"
							Me.str.Stdwgtunitcost = CType(value, string)
												
						Case "TotLBR"
							Me.str.TotLBR = CType(value, string)
												
						Case "TotCost"
							Me.str.TotCost = CType(value, string)
												
						Case "ApisUnitCost"
							Me.str.ApisUnitCost = CType(value, string)
												
						Case "ApisVolUnitCost"
							Me.str.ApisVolUnitCost = CType(value, string)
												
						Case "CurrentStdCost"
							Me.str.CurrentStdCost = CType(value, string)
												
						Case "Variance"
							Me.str.Variance = CType(value, string)
					
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
						
						Case "Volume"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volume = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weight = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Kitid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Kitid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdlaborhours"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Stdlaborhours = CType(value, Nullable(Of System.Double))
							End If
						
						Case "TotMAT"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotMAT = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "TotKIT"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotKIT = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdvolunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdvolunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdvolunitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdvolunitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdwgtunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdwgtunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdwgtunitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdwgtunitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "TotLBR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotLBR = CType(value, Nullable(Of System.Double))
							End If
						
						Case "TotCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotCost = CType(value, Nullable(Of System.Double))
							End If
						
						Case "ApisUnitCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ApisUnitCost = CType(value, Nullable(Of System.Double))
							End If
						
						Case "ApisVolUnitCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ApisVolUnitCost = CType(value, Nullable(Of System.Double))
							End If
						
						Case "CurrentStdCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.CurrentStdCost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Variance"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Variance = CType(value, Nullable(Of System.Double))
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
		' Maps to viewCostingApisTotalCosts.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCostingApisTotalCostsMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCostingApisTotalCostsMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCostingApisTotalCostsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCostingApisTotalCostsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCostingApisTotalCostsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostingApisTotalCostsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCostingApisTotalCostsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostingApisTotalCostsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCostingApisTotalCostsMetadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCostingApisTotalCostsMetadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.VOLUME
		' </summary>
		Public Overridable Property Volume As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Volume)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Volume, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.WEIGHT
		' </summary>
		Public Overridable Property Weight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Weight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Weight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCostingApisTotalCostsMetadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCostingApisTotalCostsMetadata.ColumnNames.Kitid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.STDLABORHOURS
		' </summary>
		Public Overridable Property Stdlaborhours As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdlaborhours)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdlaborhours, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.TotMAT
		' </summary>
		Public Overridable Property TotMAT As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.TotMAT)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.TotMAT, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.TotKIT
		' </summary>
		Public Overridable Property TotKIT As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.TotKIT)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.TotKIT, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.STDVOLUNITS
		' </summary>
		Public Overridable Property Stdvolunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvolunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvolunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.STDVOLUOM
		' </summary>
		Public Overridable Property Stdvoluom As System.String
			Get
				Return MyBase.GetSystemString(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvoluom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvoluom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.STDVOLUNITCOST
		' </summary>
		Public Overridable Property Stdvolunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvolunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvolunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.STDWGTUNITS
		' </summary>
		Public Overridable Property Stdwgtunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.STDWGTUOM
		' </summary>
		Public Overridable Property Stdwgtuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.STDWGTUNITCOST
		' </summary>
		Public Overridable Property Stdwgtunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.TotLBR
		' </summary>
		Public Overridable Property TotLBR As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.TotLBR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.TotLBR, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.TotCost
		' </summary>
		Public Overridable Property TotCost As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.TotCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.TotCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.ApisUnitCost
		' </summary>
		Public Overridable Property ApisUnitCost As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.ApisUnitCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.ApisUnitCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.ApisVolUnitCost
		' </summary>
		Public Overridable Property ApisVolUnitCost As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.ApisVolUnitCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.ApisVolUnitCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.CurrentStdCost
		' </summary>
		Public Overridable Property CurrentStdCost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.CurrentStdCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisTotalCostsMetadata.ColumnNames.CurrentStdCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisTotalCosts.Variance
		' </summary>
		Public Overridable Property Variance As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.Variance)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCostingApisTotalCostsMetadata.ColumnNames.Variance, value)
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
		
			Public Sub New(ByVal entity As esViewCostingApisTotalCosts)
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
		  	
			Public Property Volume As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volume
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volume = Nothing
					Else
						entity.Volume = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weight = Nothing
					Else
						entity.Weight = Convert.ToDecimal(Value)
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
		  	
			Public Property TotMAT As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotMAT
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotMAT = Nothing
					Else
						entity.TotMAT = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotKIT As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotKIT
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotKIT = Nothing
					Else
						entity.TotKIT = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdvolunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdvolunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdvolunits = Nothing
					Else
						entity.Stdvolunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdvoluom As System.String 
				Get
					Dim data_ As System.String = entity.Stdvoluom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdvoluom = Nothing
					Else
						entity.Stdvoluom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdvolunitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdvolunitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdvolunitcost = Nothing
					Else
						entity.Stdvolunitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdwgtunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdwgtunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdwgtunits = Nothing
					Else
						entity.Stdwgtunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdwgtuom As System.String 
				Get
					Dim data_ As System.String = entity.Stdwgtuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdwgtuom = Nothing
					Else
						entity.Stdwgtuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdwgtunitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdwgtunitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdwgtunitcost = Nothing
					Else
						entity.Stdwgtunitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotLBR As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TotLBR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotLBR = Nothing
					Else
						entity.TotLBR = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TotCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotCost = Nothing
					Else
						entity.TotCost = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ApisUnitCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ApisUnitCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ApisUnitCost = Nothing
					Else
						entity.ApisUnitCost = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ApisVolUnitCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ApisVolUnitCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ApisVolUnitCost = Nothing
					Else
						entity.ApisVolUnitCost = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property CurrentStdCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.CurrentStdCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CurrentStdCost = Nothing
					Else
						entity.CurrentStdCost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Variance As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Variance
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Variance = Nothing
					Else
						entity.Variance = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCostingApisTotalCosts
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCostingApisTotalCostsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCostingApisTotalCosts can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCostingApisTotalCostsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCostingApisTotalCostsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Volume As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Volume, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Weight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Kitid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdlaborhours As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Stdlaborhours, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotMAT As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.TotMAT, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotKIT As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.TotKIT, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdvolunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvolunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdvoluom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvoluom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdvolunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvolunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdwgtunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdwgtuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdwgtunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotLBR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.TotLBR, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotCost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.TotCost, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ApisUnitCost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.ApisUnitCost, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ApisVolUnitCost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.ApisVolUnitCost, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CurrentStdCost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.CurrentStdCost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Variance As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisTotalCostsMetadata.ColumnNames.Variance, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCostingApisTotalCostsCollection")> _
	Partial Public Class ViewCostingApisTotalCostsCollection
		Inherits esViewCostingApisTotalCostsCollection
		Implements IEnumerable(Of ViewCostingApisTotalCosts)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCostingApisTotalCostsCollection) As List(Of ViewCostingApisTotalCosts)
            Dim list As List(Of ViewCostingApisTotalCosts) = New List(Of ViewCostingApisTotalCosts)
            Dim emp As ViewCostingApisTotalCosts

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCostingApisTotalCostsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCostingApisTotalCostsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCostingApisTotalCosts(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCostingApisTotalCosts()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCostingApisTotalCostsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCostingApisTotalCostsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCostingApisTotalCostsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCostingApisTotalCosts 
			Return CType(MyBase.AddNewEntity(), ViewCostingApisTotalCosts)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCostingApisTotalCosts) Implements IEnumerable(Of ViewCostingApisTotalCosts).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCostingApisTotalCosts)(Me)
        End Function
		
		Private _query As ViewCostingApisTotalCostsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCostingApisTotalCosts' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCostingApisTotalCosts ()")> _
	<Serializable> _
	Partial Public Class ViewCostingApisTotalCosts 
		Inherits esViewCostingApisTotalCosts

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCostingApisTotalCostsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCostingApisTotalCostsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCostingApisTotalCostsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCostingApisTotalCostsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCostingApisTotalCostsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCostingApisTotalCostsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCostingApisTotalCostsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCostingApisTotalCostsQuery
		inherits esViewCostingApisTotalCostsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCostingApisTotalCostsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCostingApisTotalCostsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Apisnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Qtycontainers, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Volume, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Volume
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Weight, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Weight
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Kitid, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Kitid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdlaborhours, 8, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Stdlaborhours
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.TotMAT, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.TotMAT
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.TotKIT, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.TotKIT
			c.NumericPrecision = 18
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvolunits, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Stdvolunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvoluom, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Stdvoluom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdvolunitcost, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Stdvolunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtunits, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Stdwgtunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtuom, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Stdwgtuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Stdwgtunitcost, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Stdwgtunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.TotLBR, 17, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.TotLBR
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.TotCost, 18, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.TotCost
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.ApisUnitCost, 19, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.ApisUnitCost
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.ApisVolUnitCost, 20, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.ApisVolUnitCost
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.CurrentStdCost, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.CurrentStdCost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisTotalCostsMetadata.ColumnNames.Variance, 22, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCostingApisTotalCostsMetadata.PropertyNames.Variance
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCostingApisTotalCostsMetadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Qtycontainers As String = "QTYCONTAINERS"
			 Public Const Volume As String = "VOLUME"
			 Public Const Weight As String = "WEIGHT"
			 Public Const Kitid As String = "KITID"
			 Public Const Stdlaborhours As String = "STDLABORHOURS"
			 Public Const TotMAT As String = "TotMAT"
			 Public Const TotKIT As String = "TotKIT"
			 Public Const Stdvolunits As String = "STDVOLUNITS"
			 Public Const Stdvoluom As String = "STDVOLUOM"
			 Public Const Stdvolunitcost As String = "STDVOLUNITCOST"
			 Public Const Stdwgtunits As String = "STDWGTUNITS"
			 Public Const Stdwgtuom As String = "STDWGTUOM"
			 Public Const Stdwgtunitcost As String = "STDWGTUNITCOST"
			 Public Const TotLBR As String = "TotLBR"
			 Public Const TotCost As String = "TotCost"
			 Public Const ApisUnitCost As String = "ApisUnitCost"
			 Public Const ApisVolUnitCost As String = "ApisVolUnitCost"
			 Public Const CurrentStdCost As String = "CurrentStdCost"
			 Public Const Variance As String = "Variance"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Qtycontainers As String = "Qtycontainers"
			 Public Const Volume As String = "Volume"
			 Public Const Weight As String = "Weight"
			 Public Const Kitid As String = "Kitid"
			 Public Const Stdlaborhours As String = "Stdlaborhours"
			 Public Const TotMAT As String = "TotMAT"
			 Public Const TotKIT As String = "TotKIT"
			 Public Const Stdvolunits As String = "Stdvolunits"
			 Public Const Stdvoluom As String = "Stdvoluom"
			 Public Const Stdvolunitcost As String = "Stdvolunitcost"
			 Public Const Stdwgtunits As String = "Stdwgtunits"
			 Public Const Stdwgtuom As String = "Stdwgtuom"
			 Public Const Stdwgtunitcost As String = "Stdwgtunitcost"
			 Public Const TotLBR As String = "TotLBR"
			 Public Const TotCost As String = "TotCost"
			 Public Const ApisUnitCost As String = "ApisUnitCost"
			 Public Const ApisVolUnitCost As String = "ApisVolUnitCost"
			 Public Const CurrentStdCost As String = "CurrentStdCost"
			 Public Const Variance As String = "Variance"
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
            SyncLock GetType(ViewCostingApisTotalCostsMetadata)
			
				If ViewCostingApisTotalCostsMetadata.mapDelegates Is Nothing Then
					ViewCostingApisTotalCostsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCostingApisTotalCostsMetadata._meta Is Nothing Then
                    ViewCostingApisTotalCostsMetadata._meta = New ViewCostingApisTotalCostsMetadata()
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
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtycontainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Volume", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weight", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Kitid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdlaborhours", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotMAT", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("TotKIT", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Stdvolunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Stdvoluom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdvolunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Stdwgtunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Stdwgtuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdwgtunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("TotLBR", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotCost", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ApisUnitCost", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ApisVolUnitCost", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CurrentStdCost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Variance", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "viewCostingApisTotalCosts"
				meta.Destination = "viewCostingApisTotalCosts"
				
				meta.spInsert = "proc_viewCostingApisTotalCostsInsert"
				meta.spUpdate = "proc_viewCostingApisTotalCostsUpdate"
				meta.spDelete = "proc_viewCostingApisTotalCostsDelete"
				meta.spLoadAll = "proc_viewCostingApisTotalCostsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCostingApisTotalCostsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCostingApisTotalCostsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
