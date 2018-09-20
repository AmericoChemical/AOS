'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/16/2018 12:25:41 PM
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
	MustInherit Public Class esViewGetYTDSalesForJeffCustomersCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewGetYTDSalesForJeffCustomersCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewGetYTDSalesForJeffCustomersQuery)
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
            Me.InitQuery(CType(query, esViewGetYTDSalesForJeffCustomersQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewGetYTDSalesForJeffCustomers) As ViewGetYTDSalesForJeffCustomers
			Return CType(MyBase.DetachEntity(entity), ViewGetYTDSalesForJeffCustomers)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewGetYTDSalesForJeffCustomers) As ViewGetYTDSalesForJeffCustomers
			Return CType(MyBase.AttachEntity(entity), ViewGetYTDSalesForJeffCustomers)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewGetYTDSalesForJeffCustomersCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewGetYTDSalesForJeffCustomers
            Get
                Return TryCast(MyBase.Item(index), ViewGetYTDSalesForJeffCustomers)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewGetYTDSalesForJeffCustomers)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewGetYTDSalesForJeffCustomers	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewGetYTDSalesForJeffCustomersQuery
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
												
						Case "SalesName"
							Me.str.SalesName = CType(value, string)
												
						Case "Id"
							Me.str.Id = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Year"
							Me.str.Year = CType(value, string)
												
						Case "Jan"
							Me.str.Jan = CType(value, string)
												
						Case "Feb"
							Me.str.Feb = CType(value, string)
												
						Case "Mar"
							Me.str.Mar = CType(value, string)
												
						Case "Qtr1"
							Me.str.Qtr1 = CType(value, string)
												
						Case "Apr"
							Me.str.Apr = CType(value, string)
												
						Case "May"
							Me.str.May = CType(value, string)
												
						Case "Jun"
							Me.str.Jun = CType(value, string)
												
						Case "Qtr2"
							Me.str.Qtr2 = CType(value, string)
												
						Case "Jul"
							Me.str.Jul = CType(value, string)
												
						Case "Aug"
							Me.str.Aug = CType(value, string)
												
						Case "Sep"
							Me.str.Sep = CType(value, string)
												
						Case "Qtr3"
							Me.str.Qtr3 = CType(value, string)
												
						Case "Oct"
							Me.str.Oct = CType(value, string)
												
						Case "Nov"
							Me.str.Nov = CType(value, string)
												
						Case "Dec"
							Me.str.Dec = CType(value, string)
												
						Case "Qtr4"
							Me.str.Qtr4 = CType(value, string)
												
						Case "Ytd"
							Me.str.Ytd = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Year"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Year = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Jan"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Jan = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Feb"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Feb = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Mar"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Mar = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr1 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Apr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Apr = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "May"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.May = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Jun"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Jun = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr2 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Jul"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Jul = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Aug"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Aug = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sep"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sep = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr3 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Oct"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Oct = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Nov"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Nov = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Dec"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Dec = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr4 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ytd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewGetYTDSalesForJeffCustomers.SalesName
		' </summary>
		Public Overridable Property SalesName As System.String
			Get
				Return MyBase.GetSystemString(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.SalesName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.SalesName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.ID
		' </summary>
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Id, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.YEAR
		' </summary>
		Public Overridable Property Year As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Year)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Year, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.JAN
		' </summary>
		Public Overridable Property Jan As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jan)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jan, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.FEB
		' </summary>
		Public Overridable Property Feb As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Feb)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Feb, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.MAR
		' </summary>
		Public Overridable Property Mar As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Mar)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Mar, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.QTR1
		' </summary>
		Public Overridable Property Qtr1 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.APR
		' </summary>
		Public Overridable Property Apr As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Apr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Apr, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.MAY
		' </summary>
		Public Overridable Property May As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.May)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.May, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.JUN
		' </summary>
		Public Overridable Property Jun As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jun)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jun, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.QTR2
		' </summary>
		Public Overridable Property Qtr2 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.JUL
		' </summary>
		Public Overridable Property Jul As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jul)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jul, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.AUG
		' </summary>
		Public Overridable Property Aug As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Aug)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Aug, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.SEP
		' </summary>
		Public Overridable Property Sep As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Sep)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Sep, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.QTR3
		' </summary>
		Public Overridable Property Qtr3 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.OCT
		' </summary>
		Public Overridable Property Oct As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Oct)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Oct, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.NOV
		' </summary>
		Public Overridable Property Nov As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Nov)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Nov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.DEC
		' </summary>
		Public Overridable Property Dec As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Dec)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Dec, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.QTR4
		' </summary>
		Public Overridable Property Qtr4 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewGetYTDSalesForJeffCustomers.YTD
		' </summary>
		Public Overridable Property Ytd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Ytd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Ytd, value)
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
		
			Public Sub New(ByVal entity As esViewGetYTDSalesForJeffCustomers)
				Me.entity = entity
			End Sub				
		
	
			Public Property SalesName As System.String 
				Get
					Dim data_ As System.String = entity.SalesName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalesName = Nothing
					Else
						entity.SalesName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Id
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Id = Nothing
					Else
						entity.Id = Convert.ToInt32(Value)
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
		  	
			Public Property Year As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Year
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Year = Nothing
					Else
						entity.Year = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Jan As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Jan
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Jan = Nothing
					Else
						entity.Jan = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Feb As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Feb
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Feb = Nothing
					Else
						entity.Feb = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mar As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Mar
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mar = Nothing
					Else
						entity.Mar = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtr1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr1 = Nothing
					Else
						entity.Qtr1 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apr As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Apr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apr = Nothing
					Else
						entity.Apr = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property May As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.May
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.May = Nothing
					Else
						entity.May = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Jun As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Jun
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Jun = Nothing
					Else
						entity.Jun = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtr2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr2 = Nothing
					Else
						entity.Qtr2 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Jul As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Jul
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Jul = Nothing
					Else
						entity.Jul = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Aug As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Aug
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aug = Nothing
					Else
						entity.Aug = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sep As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sep
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sep = Nothing
					Else
						entity.Sep = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtr3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr3 = Nothing
					Else
						entity.Qtr3 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Oct As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Oct
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Oct = Nothing
					Else
						entity.Oct = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Nov As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Nov
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Nov = Nothing
					Else
						entity.Nov = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dec As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Dec
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dec = Nothing
					Else
						entity.Dec = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr4 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtr4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr4 = Nothing
					Else
						entity.Qtr4 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ytd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ytd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ytd = Nothing
					Else
						entity.Ytd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewGetYTDSalesForJeffCustomers
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewGetYTDSalesForJeffCustomersQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewGetYTDSalesForJeffCustomers can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewGetYTDSalesForJeffCustomersQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewGetYTDSalesForJeffCustomersMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property SalesName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.SalesName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Year As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Year, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Jan As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jan, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Feb As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Feb, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Mar As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Mar, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr1, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Apr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Apr, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property May As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.May, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Jun As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jun, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr2, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Jul As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jul, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Aug As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Aug, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sep As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Sep, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr3, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Oct As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Oct, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Nov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Nov, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Dec As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Dec, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr4, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Ytd, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewGetYTDSalesForJeffCustomersCollection")> _
	Partial Public Class ViewGetYTDSalesForJeffCustomersCollection
		Inherits esViewGetYTDSalesForJeffCustomersCollection
		Implements IEnumerable(Of ViewGetYTDSalesForJeffCustomers)
		
        Public Shared Widening Operator CType(ByVal coll As ViewGetYTDSalesForJeffCustomersCollection) As List(Of ViewGetYTDSalesForJeffCustomers)
            Dim list As List(Of ViewGetYTDSalesForJeffCustomers) = New List(Of ViewGetYTDSalesForJeffCustomers)
            Dim emp As ViewGetYTDSalesForJeffCustomers

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewGetYTDSalesForJeffCustomersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewGetYTDSalesForJeffCustomersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewGetYTDSalesForJeffCustomers(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewGetYTDSalesForJeffCustomers()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewGetYTDSalesForJeffCustomersQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewGetYTDSalesForJeffCustomersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewGetYTDSalesForJeffCustomersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewGetYTDSalesForJeffCustomers 
			Return CType(MyBase.AddNewEntity(), ViewGetYTDSalesForJeffCustomers)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewGetYTDSalesForJeffCustomers) Implements IEnumerable(Of ViewGetYTDSalesForJeffCustomers).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewGetYTDSalesForJeffCustomers)(Me)
        End Function
		
		Private _query As ViewGetYTDSalesForJeffCustomersQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewGetYTDSalesForJeffCustomers' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewGetYTDSalesForJeffCustomers ()")> _
	<Serializable> _
	Partial Public Class ViewGetYTDSalesForJeffCustomers 
		Inherits esViewGetYTDSalesForJeffCustomers

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewGetYTDSalesForJeffCustomersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewGetYTDSalesForJeffCustomersQuery

			If Me._query Is Nothing Then
				Me._query = New ViewGetYTDSalesForJeffCustomersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewGetYTDSalesForJeffCustomersQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewGetYTDSalesForJeffCustomersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewGetYTDSalesForJeffCustomersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewGetYTDSalesForJeffCustomersQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewGetYTDSalesForJeffCustomersQuery
		inherits esViewGetYTDSalesForJeffCustomersQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewGetYTDSalesForJeffCustomersQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewGetYTDSalesForJeffCustomersMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.SalesName, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.SalesName
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Id, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Custname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Year, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Year
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jan, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Jan
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Feb, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Feb
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Mar, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Mar
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr1, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Qtr1
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Apr, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Apr
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.May, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.May
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jun, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Jun
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr2, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Qtr2
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Jul, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Jul
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Aug, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Aug
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Sep, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Sep
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr3, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Qtr3
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Oct, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Oct
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Nov, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Nov
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Dec, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Dec
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Qtr4, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Qtr4
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewGetYTDSalesForJeffCustomersMetadata.ColumnNames.Ytd, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewGetYTDSalesForJeffCustomersMetadata.PropertyNames.Ytd
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewGetYTDSalesForJeffCustomersMetadata
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
			 Public Const SalesName As String = "SalesName"
			 Public Const Id As String = "ID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Year As String = "YEAR"
			 Public Const Jan As String = "JAN"
			 Public Const Feb As String = "FEB"
			 Public Const Mar As String = "MAR"
			 Public Const Qtr1 As String = "QTR1"
			 Public Const Apr As String = "APR"
			 Public Const May As String = "MAY"
			 Public Const Jun As String = "JUN"
			 Public Const Qtr2 As String = "QTR2"
			 Public Const Jul As String = "JUL"
			 Public Const Aug As String = "AUG"
			 Public Const Sep As String = "SEP"
			 Public Const Qtr3 As String = "QTR3"
			 Public Const Oct As String = "OCT"
			 Public Const Nov As String = "NOV"
			 Public Const Dec As String = "DEC"
			 Public Const Qtr4 As String = "QTR4"
			 Public Const Ytd As String = "YTD"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const SalesName As String = "SalesName"
			 Public Const Id As String = "Id"
			 Public Const Custname As String = "Custname"
			 Public Const Year As String = "Year"
			 Public Const Jan As String = "Jan"
			 Public Const Feb As String = "Feb"
			 Public Const Mar As String = "Mar"
			 Public Const Qtr1 As String = "Qtr1"
			 Public Const Apr As String = "Apr"
			 Public Const May As String = "May"
			 Public Const Jun As String = "Jun"
			 Public Const Qtr2 As String = "Qtr2"
			 Public Const Jul As String = "Jul"
			 Public Const Aug As String = "Aug"
			 Public Const Sep As String = "Sep"
			 Public Const Qtr3 As String = "Qtr3"
			 Public Const Oct As String = "Oct"
			 Public Const Nov As String = "Nov"
			 Public Const Dec As String = "Dec"
			 Public Const Qtr4 As String = "Qtr4"
			 Public Const Ytd As String = "Ytd"
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
            SyncLock GetType(ViewGetYTDSalesForJeffCustomersMetadata)
			
				If ViewGetYTDSalesForJeffCustomersMetadata.mapDelegates Is Nothing Then
					ViewGetYTDSalesForJeffCustomersMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewGetYTDSalesForJeffCustomersMetadata._meta Is Nothing Then
                    ViewGetYTDSalesForJeffCustomersMetadata._meta = New ViewGetYTDSalesForJeffCustomersMetadata()
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
				

				meta.AddTypeMap("SalesName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Year", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Jan", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Feb", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Mar", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr1", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Apr", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("May", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Jun", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr2", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Jul", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Aug", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sep", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr3", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Oct", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Nov", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Dec", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr4", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ytd", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewGetYTDSalesForJeffCustomers"
				meta.Destination = "viewGetYTDSalesForJeffCustomers"
				
				meta.spInsert = "proc_viewGetYTDSalesForJeffCustomersInsert"
				meta.spUpdate = "proc_viewGetYTDSalesForJeffCustomersUpdate"
				meta.spDelete = "proc_viewGetYTDSalesForJeffCustomersDelete"
				meta.spLoadAll = "proc_viewGetYTDSalesForJeffCustomersLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewGetYTDSalesForJeffCustomersLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewGetYTDSalesForJeffCustomersMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
