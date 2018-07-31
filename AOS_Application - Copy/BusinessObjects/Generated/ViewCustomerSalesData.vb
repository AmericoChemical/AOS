'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/27/2014 7:47:43 AM
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
	MustInherit Public Class esViewCustomerSalesDataCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerSalesDataCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerSalesDataQuery)
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
            Me.InitQuery(CType(query, esViewCustomerSalesDataQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerSalesData) As ViewCustomerSalesData
			Return CType(MyBase.DetachEntity(entity), ViewCustomerSalesData)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerSalesData) As ViewCustomerSalesData
			Return CType(MyBase.AttachEntity(entity), ViewCustomerSalesData)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerSalesDataCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerSalesData
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerSalesData)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerSalesData)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerSalesData	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerSalesDataQuery
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
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "SalesID1"
							Me.str.SalesID1 = CType(value, string)
												
						Case "SName1"
							Me.str.SName1 = CType(value, string)
												
						Case "SalesID2"
							Me.str.SalesID2 = CType(value, string)
												
						Case "SName2"
							Me.str.SName2 = CType(value, string)
												
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
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SalesID1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalesID1 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SalesID2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalesID2 = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCustomerSalesData.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerSalesDataMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerSalesDataMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerSalesDataMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerSalesDataMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.SalesID1
		' </summary>
		Public Overridable Property SalesID1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerSalesDataMetadata.ColumnNames.SalesID1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerSalesDataMetadata.ColumnNames.SalesID1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.SName1
		' </summary>
		Public Overridable Property SName1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerSalesDataMetadata.ColumnNames.SName1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerSalesDataMetadata.ColumnNames.SName1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.SalesID2
		' </summary>
		Public Overridable Property SalesID2 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerSalesDataMetadata.ColumnNames.SalesID2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerSalesDataMetadata.ColumnNames.SalesID2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.SName2
		' </summary>
		Public Overridable Property SName2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerSalesDataMetadata.ColumnNames.SName2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerSalesDataMetadata.ColumnNames.SName2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.YEAR
		' </summary>
		Public Overridable Property Year As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerSalesDataMetadata.ColumnNames.Year)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerSalesDataMetadata.ColumnNames.Year, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.JAN
		' </summary>
		Public Overridable Property Jan As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Jan)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Jan, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.FEB
		' </summary>
		Public Overridable Property Feb As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Feb)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Feb, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.MAR
		' </summary>
		Public Overridable Property Mar As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Mar)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Mar, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.QTR1
		' </summary>
		Public Overridable Property Qtr1 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Qtr1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Qtr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.APR
		' </summary>
		Public Overridable Property Apr As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Apr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Apr, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.MAY
		' </summary>
		Public Overridable Property May As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.May)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.May, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.JUN
		' </summary>
		Public Overridable Property Jun As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Jun)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Jun, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.QTR2
		' </summary>
		Public Overridable Property Qtr2 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Qtr2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Qtr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.JUL
		' </summary>
		Public Overridable Property Jul As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Jul)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Jul, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.AUG
		' </summary>
		Public Overridable Property Aug As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Aug)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Aug, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.SEP
		' </summary>
		Public Overridable Property Sep As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Sep)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Sep, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.QTR3
		' </summary>
		Public Overridable Property Qtr3 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Qtr3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Qtr3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.OCT
		' </summary>
		Public Overridable Property Oct As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Oct)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Oct, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.NOV
		' </summary>
		Public Overridable Property Nov As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Nov)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Nov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.DEC
		' </summary>
		Public Overridable Property Dec As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Dec)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Dec, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.QTR4
		' </summary>
		Public Overridable Property Qtr4 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Qtr4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Qtr4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerSalesData.YTD
		' </summary>
		Public Overridable Property Ytd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Ytd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerSalesDataMetadata.ColumnNames.Ytd, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerSalesData)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property SalesID1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalesID1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalesID1 = Nothing
					Else
						entity.SalesID1 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SName1 As System.String 
				Get
					Dim data_ As System.String = entity.SName1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SName1 = Nothing
					Else
						entity.SName1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SalesID2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalesID2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalesID2 = Nothing
					Else
						entity.SalesID2 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SName2 As System.String 
				Get
					Dim data_ As System.String = entity.SName2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SName2 = Nothing
					Else
						entity.SName2 = Convert.ToString(Value)
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
		  

			Private entity As esViewCustomerSalesData
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerSalesDataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerSalesData can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerSalesDataQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerSalesDataMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SalesID1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.SalesID1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SName1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.SName1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SalesID2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.SalesID2, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SName2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.SName2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Year As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Year, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Jan As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Jan, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Feb As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Feb, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Mar As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Mar, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Qtr1, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Apr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Apr, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property May As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.May, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Jun As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Jun, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Qtr2, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Jul As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Jul, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Aug As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Aug, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sep As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Sep, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Qtr3, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Oct As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Oct, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Nov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Nov, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Dec As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Dec, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Qtr4, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerSalesDataMetadata.ColumnNames.Ytd, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerSalesDataCollection")> _
	Partial Public Class ViewCustomerSalesDataCollection
		Inherits esViewCustomerSalesDataCollection
		Implements IEnumerable(Of ViewCustomerSalesData)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerSalesDataCollection) As List(Of ViewCustomerSalesData)
            Dim list As List(Of ViewCustomerSalesData) = New List(Of ViewCustomerSalesData)
            Dim emp As ViewCustomerSalesData

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerSalesDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerSalesDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerSalesData(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerSalesData()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerSalesDataQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerSalesDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerSalesDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerSalesData 
			Return CType(MyBase.AddNewEntity(), ViewCustomerSalesData)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerSalesData) Implements IEnumerable(Of ViewCustomerSalesData).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerSalesData)(Me)
        End Function
		
		Private _query As ViewCustomerSalesDataQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerSalesData' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerSalesData ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerSalesData 
		Inherits esViewCustomerSalesData

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerSalesDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerSalesDataQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerSalesDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerSalesDataQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerSalesDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerSalesDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerSalesDataQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerSalesDataQuery
		inherits esViewCustomerSalesDataQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerSalesDataQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerSalesDataMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Custid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Custname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.SalesID1, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.SalesID1
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.SName1, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.SName1
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.SalesID2, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.SalesID2
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.SName2, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.SName2
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Year, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Year
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Jan, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Jan
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Feb, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Feb
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Mar, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Mar
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Qtr1, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Qtr1
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Apr, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Apr
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.May, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.May
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Jun, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Jun
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Qtr2, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Qtr2
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Jul, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Jul
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Aug, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Aug
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Sep, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Sep
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Qtr3, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Qtr3
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Oct, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Oct
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Nov, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Nov
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Dec, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Dec
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Qtr4, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Qtr4
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerSalesDataMetadata.ColumnNames.Ytd, 23, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerSalesDataMetadata.PropertyNames.Ytd
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerSalesDataMetadata
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
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const SalesID1 As String = "SalesID1"
			 Public Const SName1 As String = "SName1"
			 Public Const SalesID2 As String = "SalesID2"
			 Public Const SName2 As String = "SName2"
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
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const SalesID1 As String = "SalesID1"
			 Public Const SName1 As String = "SName1"
			 Public Const SalesID2 As String = "SalesID2"
			 Public Const SName2 As String = "SName2"
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
            SyncLock GetType(ViewCustomerSalesDataMetadata)
			
				If ViewCustomerSalesDataMetadata.mapDelegates Is Nothing Then
					ViewCustomerSalesDataMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerSalesDataMetadata._meta Is Nothing Then
                    ViewCustomerSalesDataMetadata._meta = New ViewCustomerSalesDataMetadata()
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
				

				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SalesID1", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SName1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SalesID2", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SName2", new esTypeMap("varchar", "System.String"))
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
				
				
				 
				meta.Source = "viewCustomerSalesData"
				meta.Destination = "viewCustomerSalesData"
				
				meta.spInsert = "proc_viewCustomerSalesDataInsert"
				meta.spUpdate = "proc_viewCustomerSalesDataUpdate"
				meta.spDelete = "proc_viewCustomerSalesDataDelete"
				meta.spLoadAll = "proc_viewCustomerSalesDataLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerSalesDataLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerSalesDataMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
