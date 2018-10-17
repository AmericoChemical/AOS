'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/17/2018 10:57:21 AM
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
	MustInherit Public Class esViewRelabelCosts1Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRelabelCosts1Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRelabelCosts1Query)
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
            Me.InitQuery(CType(query, esViewRelabelCosts1Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRelabelCosts1) As ViewRelabelCosts1
			Return CType(MyBase.DetachEntity(entity), ViewRelabelCosts1)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRelabelCosts1) As ViewRelabelCosts1
			Return CType(MyBase.AttachEntity(entity), ViewRelabelCosts1)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRelabelCosts1Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRelabelCosts1
            Get
                Return TryCast(MyBase.Item(index), ViewRelabelCosts1)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRelabelCosts1)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRelabelCosts1	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRelabelCosts1Query
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Volumeunits"
							Me.str.Volumeunits = CType(value, string)
												
						Case "Volumestandardcost"
							Me.str.Volumestandardcost = CType(value, string)
												
						Case "Weightunits"
							Me.str.Weightunits = CType(value, string)
												
						Case "Weightstandardcost"
							Me.str.Weightstandardcost = CType(value, string)
												
						Case "Origprodid"
							Me.str.Origprodid = CType(value, string)
												
						Case "Origproddesc"
							Me.str.Origproddesc = CType(value, string)
												
						Case "Origcontainer"
							Me.str.Origcontainer = CType(value, string)
												
						Case "Origvolcost"
							Me.str.Origvolcost = CType(value, string)
												
						Case "Origwgtcost"
							Me.str.Origwgtcost = CType(value, string)
												
						Case "Origvolunits"
							Me.str.Origvolunits = CType(value, string)
												
						Case "Origwgtunits"
							Me.str.Origwgtunits = CType(value, string)
												
						Case "Stdlaborhrs"
							Me.str.Stdlaborhrs = CType(value, string)
												
						Case "Laborcost"
							Me.str.Laborcost = CType(value, string)
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
												
						Case "Kitcost"
							Me.str.Kitcost = CType(value, string)
												
						Case "Origvolumeuom"
							Me.str.Origvolumeuom = CType(value, string)
												
						Case "Origweightuom"
							Me.str.Origweightuom = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Volumeunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumestandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumestandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightstandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightstandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Origprodid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Origprodid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Origvolcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Origvolcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Origwgtcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Origwgtcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Origvolunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Origvolunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Origwgtunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Origwgtunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdlaborhrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdlaborhrs = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Laborcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Laborcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Kitid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Kitid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Kitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Kitcost = CType(value, Nullable(Of System.Double))
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
		' Maps to viewRelabelCosts1.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelCosts1Metadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelCosts1Metadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.VOLUMEUNITS
		' </summary>
		Public Overridable Property Volumeunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Volumeunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Volumeunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.VOLUMESTANDARDCOST
		' </summary>
		Public Overridable Property Volumestandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Volumestandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Volumestandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.WEIGHTUNITS
		' </summary>
		Public Overridable Property Weightunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Weightunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Weightunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.WEIGHTSTANDARDCOST
		' </summary>
		Public Overridable Property Weightstandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Weightstandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Weightstandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGPRODID
		' </summary>
		Public Overridable Property Origprodid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelCosts1Metadata.ColumnNames.Origprodid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelCosts1Metadata.ColumnNames.Origprodid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGPRODDESC
		' </summary>
		Public Overridable Property Origproddesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Origproddesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Origproddesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGCONTAINER
		' </summary>
		Public Overridable Property Origcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Origcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Origcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGVOLCOST
		' </summary>
		Public Overridable Property Origvolcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Origvolcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Origvolcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGWGTCOST
		' </summary>
		Public Overridable Property Origwgtcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Origwgtcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Origwgtcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGVOLUNITS
		' </summary>
		Public Overridable Property Origvolunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Origvolunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Origvolunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGWGTUNITS
		' </summary>
		Public Overridable Property Origwgtunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Origwgtunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Origwgtunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.STDLABORHRS
		' </summary>
		Public Overridable Property Stdlaborhrs As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Stdlaborhrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Stdlaborhrs, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.LABORCOST
		' </summary>
		Public Overridable Property Laborcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Laborcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabelCosts1Metadata.ColumnNames.Laborcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelCosts1Metadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelCosts1Metadata.ColumnNames.Kitid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.KITCOST
		' </summary>
		Public Overridable Property Kitcost As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRelabelCosts1Metadata.ColumnNames.Kitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRelabelCosts1Metadata.ColumnNames.Kitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGVOLUMEUOM
		' </summary>
		Public Overridable Property Origvolumeuom As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Origvolumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Origvolumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelCosts1.ORIGWEIGHTUOM
		' </summary>
		Public Overridable Property Origweightuom As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Origweightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelCosts1Metadata.ColumnNames.Origweightuom, value)
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
		
			Public Sub New(ByVal entity As esViewRelabelCosts1)
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
		  	
			Public Property Origprodid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Origprodid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origprodid = Nothing
					Else
						entity.Origprodid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origproddesc As System.String 
				Get
					Dim data_ As System.String = entity.Origproddesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origproddesc = Nothing
					Else
						entity.Origproddesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Origcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origcontainer = Nothing
					Else
						entity.Origcontainer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origvolcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Origvolcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origvolcost = Nothing
					Else
						entity.Origvolcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origwgtcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Origwgtcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origwgtcost = Nothing
					Else
						entity.Origwgtcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origvolunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Origvolunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origvolunits = Nothing
					Else
						entity.Origvolunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origwgtunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Origwgtunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origwgtunits = Nothing
					Else
						entity.Origwgtunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdlaborhrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdlaborhrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdlaborhrs = Nothing
					Else
						entity.Stdlaborhrs = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Laborcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Laborcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Laborcost = Nothing
					Else
						entity.Laborcost = Convert.ToDecimal(Value)
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
		  	
			Public Property Kitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Kitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitcost = Nothing
					Else
						entity.Kitcost = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origvolumeuom As System.String 
				Get
					Dim data_ As System.String = entity.Origvolumeuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origvolumeuom = Nothing
					Else
						entity.Origvolumeuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origweightuom As System.String 
				Get
					Dim data_ As System.String = entity.Origweightuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origweightuom = Nothing
					Else
						entity.Origweightuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRelabelCosts1
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRelabelCosts1Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRelabelCosts1 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRelabelCosts1Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRelabelCosts1Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Volumeunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumestandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Volumestandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Weightunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightstandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Weightstandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Origprodid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origprodid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Origproddesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origproddesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Origcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Origvolcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origvolcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Origwgtcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origwgtcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Origvolunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origvolunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Origwgtunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origwgtunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdlaborhrs As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Stdlaborhrs, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Laborcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Laborcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Kitid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Kitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Kitcost, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Origvolumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origvolumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Origweightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelCosts1Metadata.ColumnNames.Origweightuom, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRelabelCosts1Collection")> _
	Partial Public Class ViewRelabelCosts1Collection
		Inherits esViewRelabelCosts1Collection
		Implements IEnumerable(Of ViewRelabelCosts1)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRelabelCosts1Collection) As List(Of ViewRelabelCosts1)
            Dim list As List(Of ViewRelabelCosts1) = New List(Of ViewRelabelCosts1)
            Dim emp As ViewRelabelCosts1

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRelabelCosts1Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRelabelCosts1Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRelabelCosts1(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRelabelCosts1()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRelabelCosts1Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRelabelCosts1Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRelabelCosts1Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRelabelCosts1 
			Return CType(MyBase.AddNewEntity(), ViewRelabelCosts1)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRelabelCosts1) Implements IEnumerable(Of ViewRelabelCosts1).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRelabelCosts1)(Me)
        End Function
		
		Private _query As ViewRelabelCosts1Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewRelabelCosts1' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRelabelCosts1 ()")> _
	<Serializable> _
	Partial Public Class ViewRelabelCosts1 
		Inherits esViewRelabelCosts1

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRelabelCosts1Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRelabelCosts1Query

			If Me._query Is Nothing Then
				Me._query = New ViewRelabelCosts1Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRelabelCosts1Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRelabelCosts1Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRelabelCosts1Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRelabelCosts1Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRelabelCosts1Query
		inherits esViewRelabelCosts1Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRelabelCosts1Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRelabelCosts1Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Volumeunits, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Volumeunits
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Volumestandardcost, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Volumestandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Weightunits, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Weightunits
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Weightstandardcost, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Weightstandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origprodid, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origprodid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origproddesc, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origproddesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origcontainer, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origcontainer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origvolcost, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origvolcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origwgtcost, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origwgtcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origvolunits, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origvolunits
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origwgtunits, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origwgtunits
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Stdlaborhrs, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Stdlaborhrs
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Laborcost, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Laborcost
			c.NumericPrecision = 37
			c.NumericScale = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Kitid, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Kitid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Kitcost, 17, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Kitcost
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origvolumeuom, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origvolumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelCosts1Metadata.ColumnNames.Origweightuom, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelCosts1Metadata.PropertyNames.Origweightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRelabelCosts1Metadata
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
			 Public Const Container As String = "CONTAINER"
			 Public Const Volumeunits As String = "VOLUMEUNITS"
			 Public Const Volumestandardcost As String = "VOLUMESTANDARDCOST"
			 Public Const Weightunits As String = "WEIGHTUNITS"
			 Public Const Weightstandardcost As String = "WEIGHTSTANDARDCOST"
			 Public Const Origprodid As String = "ORIGPRODID"
			 Public Const Origproddesc As String = "ORIGPRODDESC"
			 Public Const Origcontainer As String = "ORIGCONTAINER"
			 Public Const Origvolcost As String = "ORIGVOLCOST"
			 Public Const Origwgtcost As String = "ORIGWGTCOST"
			 Public Const Origvolunits As String = "ORIGVOLUNITS"
			 Public Const Origwgtunits As String = "ORIGWGTUNITS"
			 Public Const Stdlaborhrs As String = "STDLABORHRS"
			 Public Const Laborcost As String = "LABORCOST"
			 Public Const Kitid As String = "KITID"
			 Public Const Kitcost As String = "KITCOST"
			 Public Const Origvolumeuom As String = "ORIGVOLUMEUOM"
			 Public Const Origweightuom As String = "ORIGWEIGHTUOM"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Volumeunits As String = "Volumeunits"
			 Public Const Volumestandardcost As String = "Volumestandardcost"
			 Public Const Weightunits As String = "Weightunits"
			 Public Const Weightstandardcost As String = "Weightstandardcost"
			 Public Const Origprodid As String = "Origprodid"
			 Public Const Origproddesc As String = "Origproddesc"
			 Public Const Origcontainer As String = "Origcontainer"
			 Public Const Origvolcost As String = "Origvolcost"
			 Public Const Origwgtcost As String = "Origwgtcost"
			 Public Const Origvolunits As String = "Origvolunits"
			 Public Const Origwgtunits As String = "Origwgtunits"
			 Public Const Stdlaborhrs As String = "Stdlaborhrs"
			 Public Const Laborcost As String = "Laborcost"
			 Public Const Kitid As String = "Kitid"
			 Public Const Kitcost As String = "Kitcost"
			 Public Const Origvolumeuom As String = "Origvolumeuom"
			 Public Const Origweightuom As String = "Origweightuom"
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
            SyncLock GetType(ViewRelabelCosts1Metadata)
			
				If ViewRelabelCosts1Metadata.mapDelegates Is Nothing Then
					ViewRelabelCosts1Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRelabelCosts1Metadata._meta Is Nothing Then
                    ViewRelabelCosts1Metadata._meta = New ViewRelabelCosts1Metadata()
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
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumeunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumestandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightstandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Origprodid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Origproddesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Origcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Origvolcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Origwgtcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Origvolunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Origwgtunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Stdlaborhrs", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Laborcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Kitid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Kitcost", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Origvolumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Origweightuom", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRelabelCosts1"
				meta.Destination = "viewRelabelCosts1"
				
				meta.spInsert = "proc_viewRelabelCosts1Insert"
				meta.spUpdate = "proc_viewRelabelCosts1Update"
				meta.spDelete = "proc_viewRelabelCosts1Delete"
				meta.spLoadAll = "proc_viewRelabelCosts1LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRelabelCosts1LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRelabelCosts1Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
