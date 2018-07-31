'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:11 PM
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
	MustInherit Public Class esViewRptTotalInventoryByProductCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptTotalInventoryByProductCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptTotalInventoryByProductQuery)
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
            Me.InitQuery(CType(query, esViewRptTotalInventoryByProductQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptTotalInventoryByProduct) As ViewRptTotalInventoryByProduct
			Return CType(MyBase.DetachEntity(entity), ViewRptTotalInventoryByProduct)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptTotalInventoryByProduct) As ViewRptTotalInventoryByProduct
			Return CType(MyBase.AttachEntity(entity), ViewRptTotalInventoryByProduct)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptTotalInventoryByProductCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptTotalInventoryByProduct
            Get
                Return TryCast(MyBase.Item(index), ViewRptTotalInventoryByProduct)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptTotalInventoryByProduct)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptTotalInventoryByProduct	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptTotalInventoryByProductQuery
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
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "FGContainersAvailable"
							Me.str.FGContainersAvailable = CType(value, string)
												
						Case "FGContainersAllocated"
							Me.str.FGContainersAllocated = CType(value, string)
												
						Case "FGUnits"
							Me.str.FGUnits = CType(value, string)
												
						Case "RMContainersFULL"
							Me.str.RMContainersFULL = CType(value, string)
												
						Case "RMContainersPARTIAL"
							Me.str.RMContainersPARTIAL = CType(value, string)
												
						Case "RMInventoryUnits"
							Me.str.RMInventoryUnits = CType(value, string)
												
						Case "RMInProcessUnits"
							Me.str.RMInProcessUnits = CType(value, string)
												
						Case "RMAvailableUnits"
							Me.str.RMAvailableUnits = CType(value, string)
												
						Case "POContainers"
							Me.str.POContainers = CType(value, string)
												
						Case "POUnits"
							Me.str.POUnits = CType(value, string)
												
						Case "Qtyrequested"
							Me.str.Qtyrequested = CType(value, string)
												
						Case "Totalqtycontainersavailable"
							Me.str.Totalqtycontainersavailable = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "FGContainersAvailable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FGContainersAvailable = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "FGContainersAllocated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FGContainersAllocated = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "FGUnits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FGUnits = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "RMContainersFULL"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RMContainersFULL = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "RMContainersPARTIAL"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RMContainersPARTIAL = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "RMInventoryUnits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RMInventoryUnits = CType(value, Nullable(Of System.Double))
							End If
						
						Case "RMInProcessUnits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RMInProcessUnits = CType(value, Nullable(Of System.Double))
							End If
						
						Case "RMAvailableUnits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RMAvailableUnits = CType(value, Nullable(Of System.Double))
							End If
						
						Case "POContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.POContainers = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "POUnits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.POUnits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtyrequested"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyrequested = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Totalqtycontainersavailable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Totalqtycontainersavailable = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptTotalInventoryByProduct.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptTotalInventoryByProductMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptTotalInventoryByProductMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptTotalInventoryByProductMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptTotalInventoryByProductMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptTotalInventoryByProductMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptTotalInventoryByProductMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.FGContainersAvailable
		' </summary>
		Public Overridable Property FGContainersAvailable As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGContainersAvailable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGContainersAvailable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.FGContainersAllocated
		' </summary>
		Public Overridable Property FGContainersAllocated As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGContainersAllocated)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGContainersAllocated, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.FGUnits
		' </summary>
		Public Overridable Property FGUnits As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGUnits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGUnits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.RMContainersFULL
		' </summary>
		Public Overridable Property RMContainersFULL As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMContainersFULL)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMContainersFULL, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.RMContainersPARTIAL
		' </summary>
		Public Overridable Property RMContainersPARTIAL As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMContainersPARTIAL)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMContainersPARTIAL, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.RMInventoryUnits
		' </summary>
		Public Overridable Property RMInventoryUnits As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMInventoryUnits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMInventoryUnits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.RMInProcessUnits
		' </summary>
		Public Overridable Property RMInProcessUnits As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMInProcessUnits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMInProcessUnits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.RMAvailableUnits
		' </summary>
		Public Overridable Property RMAvailableUnits As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMAvailableUnits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMAvailableUnits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.POContainers
		' </summary>
		Public Overridable Property POContainers As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptTotalInventoryByProductMetadata.ColumnNames.POContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptTotalInventoryByProductMetadata.ColumnNames.POContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.POUnits
		' </summary>
		Public Overridable Property POUnits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptTotalInventoryByProductMetadata.ColumnNames.POUnits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptTotalInventoryByProductMetadata.ColumnNames.POUnits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.QTYREQUESTED
		' </summary>
		Public Overridable Property Qtyrequested As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.Qtyrequested)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.Qtyrequested, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptTotalInventoryByProduct.TOTALQTYCONTAINERSAVAILABLE
		' </summary>
		Public Overridable Property Totalqtycontainersavailable As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.Totalqtycontainersavailable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptTotalInventoryByProductMetadata.ColumnNames.Totalqtycontainersavailable, value)
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
		
			Public Sub New(ByVal entity As esViewRptTotalInventoryByProduct)
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
		  	
			Public Property FGContainersAvailable As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FGContainersAvailable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FGContainersAvailable = Nothing
					Else
						entity.FGContainersAvailable = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FGContainersAllocated As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FGContainersAllocated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FGContainersAllocated = Nothing
					Else
						entity.FGContainersAllocated = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FGUnits As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FGUnits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FGUnits = Nothing
					Else
						entity.FGUnits = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMContainersFULL As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RMContainersFULL
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMContainersFULL = Nothing
					Else
						entity.RMContainersFULL = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMContainersPARTIAL As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RMContainersPARTIAL
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMContainersPARTIAL = Nothing
					Else
						entity.RMContainersPARTIAL = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMInventoryUnits As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RMInventoryUnits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMInventoryUnits = Nothing
					Else
						entity.RMInventoryUnits = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMInProcessUnits As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RMInProcessUnits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMInProcessUnits = Nothing
					Else
						entity.RMInProcessUnits = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMAvailableUnits As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RMAvailableUnits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMAvailableUnits = Nothing
					Else
						entity.RMAvailableUnits = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property POContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.POContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.POContainers = Nothing
					Else
						entity.POContainers = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property POUnits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.POUnits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.POUnits = Nothing
					Else
						entity.POUnits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyrequested As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyrequested
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyrequested = Nothing
					Else
						entity.Qtyrequested = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Totalqtycontainersavailable As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Totalqtycontainersavailable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalqtycontainersavailable = Nothing
					Else
						entity.Totalqtycontainersavailable = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptTotalInventoryByProduct
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptTotalInventoryByProductQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptTotalInventoryByProduct can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptTotalInventoryByProductQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptTotalInventoryByProductMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FGContainersAvailable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.FGContainersAvailable, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FGContainersAllocated As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.FGContainersAllocated, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FGUnits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.FGUnits, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RMContainersFULL As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.RMContainersFULL, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RMContainersPARTIAL As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.RMContainersPARTIAL, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RMInventoryUnits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.RMInventoryUnits, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RMInProcessUnits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.RMInProcessUnits, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RMAvailableUnits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.RMAvailableUnits, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property POContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.POContainers, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property POUnits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.POUnits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyrequested As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.Qtyrequested, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalqtycontainersavailable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptTotalInventoryByProductMetadata.ColumnNames.Totalqtycontainersavailable, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptTotalInventoryByProductCollection")> _
	Partial Public Class ViewRptTotalInventoryByProductCollection
		Inherits esViewRptTotalInventoryByProductCollection
		Implements IEnumerable(Of ViewRptTotalInventoryByProduct)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptTotalInventoryByProductCollection) As List(Of ViewRptTotalInventoryByProduct)
            Dim list As List(Of ViewRptTotalInventoryByProduct) = New List(Of ViewRptTotalInventoryByProduct)
            Dim emp As ViewRptTotalInventoryByProduct

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptTotalInventoryByProductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptTotalInventoryByProductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptTotalInventoryByProduct(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptTotalInventoryByProduct()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptTotalInventoryByProductQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptTotalInventoryByProductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptTotalInventoryByProductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptTotalInventoryByProduct 
			Return CType(MyBase.AddNewEntity(), ViewRptTotalInventoryByProduct)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptTotalInventoryByProduct) Implements IEnumerable(Of ViewRptTotalInventoryByProduct).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptTotalInventoryByProduct)(Me)
        End Function
		
		Private _query As ViewRptTotalInventoryByProductQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptTotalInventoryByProduct' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptTotalInventoryByProduct ()")> _
	<Serializable> _
	Partial Public Class ViewRptTotalInventoryByProduct 
		Inherits esViewRptTotalInventoryByProduct

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptTotalInventoryByProductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptTotalInventoryByProductQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptTotalInventoryByProductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptTotalInventoryByProductQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptTotalInventoryByProductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptTotalInventoryByProductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptTotalInventoryByProductQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptTotalInventoryByProductQuery
		inherits esViewRptTotalInventoryByProductQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptTotalInventoryByProductQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptTotalInventoryByProductMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.Units, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.Uom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGContainersAvailable, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.FGContainersAvailable
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGContainersAllocated, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.FGContainersAllocated
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.FGUnits, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.FGUnits
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMContainersFULL, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.RMContainersFULL
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMContainersPARTIAL, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.RMContainersPARTIAL
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMInventoryUnits, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.RMInventoryUnits
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMInProcessUnits, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.RMInProcessUnits
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.RMAvailableUnits, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.RMAvailableUnits
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.POContainers, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.POContainers
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.POUnits, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.POUnits
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.Qtyrequested, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.Qtyrequested
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptTotalInventoryByProductMetadata.ColumnNames.Totalqtycontainersavailable, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptTotalInventoryByProductMetadata.PropertyNames.Totalqtycontainersavailable
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptTotalInventoryByProductMetadata
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
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const FGContainersAvailable As String = "FGContainersAvailable"
			 Public Const FGContainersAllocated As String = "FGContainersAllocated"
			 Public Const FGUnits As String = "FGUnits"
			 Public Const RMContainersFULL As String = "RMContainersFULL"
			 Public Const RMContainersPARTIAL As String = "RMContainersPARTIAL"
			 Public Const RMInventoryUnits As String = "RMInventoryUnits"
			 Public Const RMInProcessUnits As String = "RMInProcessUnits"
			 Public Const RMAvailableUnits As String = "RMAvailableUnits"
			 Public Const POContainers As String = "POContainers"
			 Public Const POUnits As String = "POUnits"
			 Public Const Qtyrequested As String = "QTYREQUESTED"
			 Public Const Totalqtycontainersavailable As String = "TOTALQTYCONTAINERSAVAILABLE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const FGContainersAvailable As String = "FGContainersAvailable"
			 Public Const FGContainersAllocated As String = "FGContainersAllocated"
			 Public Const FGUnits As String = "FGUnits"
			 Public Const RMContainersFULL As String = "RMContainersFULL"
			 Public Const RMContainersPARTIAL As String = "RMContainersPARTIAL"
			 Public Const RMInventoryUnits As String = "RMInventoryUnits"
			 Public Const RMInProcessUnits As String = "RMInProcessUnits"
			 Public Const RMAvailableUnits As String = "RMAvailableUnits"
			 Public Const POContainers As String = "POContainers"
			 Public Const POUnits As String = "POUnits"
			 Public Const Qtyrequested As String = "Qtyrequested"
			 Public Const Totalqtycontainersavailable As String = "Totalqtycontainersavailable"
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
            SyncLock GetType(ViewRptTotalInventoryByProductMetadata)
			
				If ViewRptTotalInventoryByProductMetadata.mapDelegates Is Nothing Then
					ViewRptTotalInventoryByProductMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptTotalInventoryByProductMetadata._meta Is Nothing Then
                    ViewRptTotalInventoryByProductMetadata._meta = New ViewRptTotalInventoryByProductMetadata()
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
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FGContainersAvailable", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FGContainersAllocated", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FGUnits", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RMContainersFULL", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RMContainersPARTIAL", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RMInventoryUnits", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RMInProcessUnits", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RMAvailableUnits", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("POContainers", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("POUnits", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtyrequested", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Totalqtycontainersavailable", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRptTotalInventoryByProduct"
				meta.Destination = "viewRptTotalInventoryByProduct"
				
				meta.spInsert = "proc_viewRptTotalInventoryByProductInsert"
				meta.spUpdate = "proc_viewRptTotalInventoryByProductUpdate"
				meta.spDelete = "proc_viewRptTotalInventoryByProductDelete"
				meta.spLoadAll = "proc_viewRptTotalInventoryByProductLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptTotalInventoryByProductLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptTotalInventoryByProductMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
