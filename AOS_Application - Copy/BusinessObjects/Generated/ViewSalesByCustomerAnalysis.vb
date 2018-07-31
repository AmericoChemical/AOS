'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/29/2017 4:23:21 PM
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
	MustInherit Public Class esViewSalesByCustomerAnalysisCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewSalesByCustomerAnalysisCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewSalesByCustomerAnalysisQuery)
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
            Me.InitQuery(CType(query, esViewSalesByCustomerAnalysisQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewSalesByCustomerAnalysis) As ViewSalesByCustomerAnalysis
			Return CType(MyBase.DetachEntity(entity), ViewSalesByCustomerAnalysis)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewSalesByCustomerAnalysis) As ViewSalesByCustomerAnalysis
			Return CType(MyBase.AttachEntity(entity), ViewSalesByCustomerAnalysis)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewSalesByCustomerAnalysisCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewSalesByCustomerAnalysis
            Get
                Return TryCast(MyBase.Item(index), ViewSalesByCustomerAnalysis)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewSalesByCustomerAnalysis)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewSalesByCustomerAnalysis	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewSalesByCustomerAnalysisQuery
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
												
						Case "SalesID1"
							Me.str.SalesID1 = CType(value, string)
												
						Case "SalesName"
							Me.str.SalesName = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "ServiceRep"
							Me.str.ServiceRep = CType(value, string)
												
						Case "Year"
							Me.str.Year = CType(value, string)
												
						Case "PrevYear"
							Me.str.PrevYear = CType(value, string)
												
						Case "Jan"
							Me.str.Jan = CType(value, string)
												
						Case "PrevJan"
							Me.str.PrevJan = CType(value, string)
												
						Case "Feb"
							Me.str.Feb = CType(value, string)
												
						Case "PrevFeb"
							Me.str.PrevFeb = CType(value, string)
												
						Case "Mar"
							Me.str.Mar = CType(value, string)
												
						Case "PrevMar"
							Me.str.PrevMar = CType(value, string)
												
						Case "Qtr1"
							Me.str.Qtr1 = CType(value, string)
												
						Case "PrevQtr1"
							Me.str.PrevQtr1 = CType(value, string)
												
						Case "Apr"
							Me.str.Apr = CType(value, string)
												
						Case "PrevApr"
							Me.str.PrevApr = CType(value, string)
												
						Case "May"
							Me.str.May = CType(value, string)
												
						Case "PrevMay"
							Me.str.PrevMay = CType(value, string)
												
						Case "Jun"
							Me.str.Jun = CType(value, string)
												
						Case "PrevJun"
							Me.str.PrevJun = CType(value, string)
												
						Case "Qtr2"
							Me.str.Qtr2 = CType(value, string)
												
						Case "PrevQtr2"
							Me.str.PrevQtr2 = CType(value, string)
												
						Case "Jul"
							Me.str.Jul = CType(value, string)
												
						Case "PrevJul"
							Me.str.PrevJul = CType(value, string)
												
						Case "Aug"
							Me.str.Aug = CType(value, string)
												
						Case "PrevAug"
							Me.str.PrevAug = CType(value, string)
												
						Case "Sep"
							Me.str.Sep = CType(value, string)
												
						Case "PrevSep"
							Me.str.PrevSep = CType(value, string)
												
						Case "Qtr3"
							Me.str.Qtr3 = CType(value, string)
												
						Case "PrevQtr3"
							Me.str.PrevQtr3 = CType(value, string)
												
						Case "Oct"
							Me.str.Oct = CType(value, string)
												
						Case "PrevOct"
							Me.str.PrevOct = CType(value, string)
												
						Case "Nov"
							Me.str.Nov = CType(value, string)
												
						Case "PrevNov"
							Me.str.PrevNov = CType(value, string)
												
						Case "Dec"
							Me.str.Dec = CType(value, string)
												
						Case "PrevDec"
							Me.str.PrevDec = CType(value, string)
												
						Case "Qtr4"
							Me.str.Qtr4 = CType(value, string)
												
						Case "PrevQtr4"
							Me.str.PrevQtr4 = CType(value, string)
												
						Case "Ytd"
							Me.str.Ytd = CType(value, string)
												
						Case "PrevTotal"
							Me.str.PrevTotal = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "SalesID1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalesID1 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Year"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Year = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "PrevYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PrevYear = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Jan"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Jan = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevJan"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevJan = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Feb"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Feb = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevFeb"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevFeb = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Mar"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Mar = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevMar"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevMar = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr1 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevQtr1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevQtr1 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Apr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Apr = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevApr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevApr = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "May"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.May = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevMay"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevMay = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Jun"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Jun = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevJun"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevJun = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr2 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevQtr2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevQtr2 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Jul"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Jul = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevJul"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevJul = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Aug"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Aug = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevAug"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevAug = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sep"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sep = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevSep"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevSep = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr3 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevQtr3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevQtr3 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Oct"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Oct = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevOct"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevOct = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Nov"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Nov = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevNov"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevNov = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Dec"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Dec = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevDec"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevDec = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr4 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevQtr4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevQtr4 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ytd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PrevTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PrevTotal = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewSalesByCustomerAnalysis.SalesID1
		' </summary>
		Public Overridable Property SalesID1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewSalesByCustomerAnalysisMetadata.ColumnNames.SalesID1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewSalesByCustomerAnalysisMetadata.ColumnNames.SalesID1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.SalesName
		' </summary>
		Public Overridable Property SalesName As System.String
			Get
				Return MyBase.GetSystemString(ViewSalesByCustomerAnalysisMetadata.ColumnNames.SalesName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewSalesByCustomerAnalysisMetadata.ColumnNames.SalesName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.ServiceRep
		' </summary>
		Public Overridable Property ServiceRep As System.String
			Get
				Return MyBase.GetSystemString(ViewSalesByCustomerAnalysisMetadata.ColumnNames.ServiceRep)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewSalesByCustomerAnalysisMetadata.ColumnNames.ServiceRep, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.YEAR
		' </summary>
		Public Overridable Property Year As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Year)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Year, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_YEAR
		' </summary>
		Public Overridable Property PrevYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevYear, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.JAN
		' </summary>
		Public Overridable Property Jan As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jan)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jan, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_JAN
		' </summary>
		Public Overridable Property PrevJan As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJan)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJan, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.FEB
		' </summary>
		Public Overridable Property Feb As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Feb)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Feb, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_FEB
		' </summary>
		Public Overridable Property PrevFeb As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevFeb)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevFeb, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.MAR
		' </summary>
		Public Overridable Property Mar As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Mar)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Mar, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_MAR
		' </summary>
		Public Overridable Property PrevMar As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevMar)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevMar, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.QTR1
		' </summary>
		Public Overridable Property Qtr1 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_QTR1
		' </summary>
		Public Overridable Property PrevQtr1 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.APR
		' </summary>
		Public Overridable Property Apr As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Apr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Apr, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_APR
		' </summary>
		Public Overridable Property PrevApr As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevApr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevApr, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.MAY
		' </summary>
		Public Overridable Property May As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.May)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.May, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_MAY
		' </summary>
		Public Overridable Property PrevMay As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevMay)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevMay, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.JUN
		' </summary>
		Public Overridable Property Jun As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jun)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jun, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_JUN
		' </summary>
		Public Overridable Property PrevJun As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJun)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJun, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.QTR2
		' </summary>
		Public Overridable Property Qtr2 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_QTR2
		' </summary>
		Public Overridable Property PrevQtr2 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.JUL
		' </summary>
		Public Overridable Property Jul As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jul)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jul, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_JUL
		' </summary>
		Public Overridable Property PrevJul As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJul)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJul, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.AUG
		' </summary>
		Public Overridable Property Aug As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Aug)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Aug, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_AUG
		' </summary>
		Public Overridable Property PrevAug As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevAug)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevAug, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.SEP
		' </summary>
		Public Overridable Property Sep As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Sep)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Sep, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_SEP
		' </summary>
		Public Overridable Property PrevSep As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevSep)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevSep, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.QTR3
		' </summary>
		Public Overridable Property Qtr3 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_QTR3
		' </summary>
		Public Overridable Property PrevQtr3 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.OCT
		' </summary>
		Public Overridable Property Oct As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Oct)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Oct, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_OCT
		' </summary>
		Public Overridable Property PrevOct As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevOct)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevOct, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.NOV
		' </summary>
		Public Overridable Property Nov As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Nov)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Nov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_NOV
		' </summary>
		Public Overridable Property PrevNov As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevNov)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevNov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.DEC
		' </summary>
		Public Overridable Property Dec As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Dec)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Dec, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_DEC
		' </summary>
		Public Overridable Property PrevDec As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevDec)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevDec, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.QTR4
		' </summary>
		Public Overridable Property Qtr4 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_QTR4
		' </summary>
		Public Overridable Property PrevQtr4 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.YTD
		' </summary>
		Public Overridable Property Ytd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Ytd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Ytd, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesByCustomerAnalysis.PREV_TOTAL
		' </summary>
		Public Overridable Property PrevTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevTotal, value)
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
		
			Public Sub New(ByVal entity As esViewSalesByCustomerAnalysis)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property ServiceRep As System.String 
				Get
					Dim data_ As System.String = entity.ServiceRep
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ServiceRep = Nothing
					Else
						entity.ServiceRep = Convert.ToString(Value)
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
		  	
			Public Property PrevYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PrevYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevYear = Nothing
					Else
						entity.PrevYear = Convert.ToInt32(Value)
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
		  	
			Public Property PrevJan As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevJan
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevJan = Nothing
					Else
						entity.PrevJan = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevFeb As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevFeb
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevFeb = Nothing
					Else
						entity.PrevFeb = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevMar As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevMar
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevMar = Nothing
					Else
						entity.PrevMar = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevQtr1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevQtr1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevQtr1 = Nothing
					Else
						entity.PrevQtr1 = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevApr As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevApr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevApr = Nothing
					Else
						entity.PrevApr = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevMay As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevMay
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevMay = Nothing
					Else
						entity.PrevMay = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevJun As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevJun
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevJun = Nothing
					Else
						entity.PrevJun = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevQtr2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevQtr2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevQtr2 = Nothing
					Else
						entity.PrevQtr2 = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevJul As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevJul
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevJul = Nothing
					Else
						entity.PrevJul = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevAug As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevAug
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevAug = Nothing
					Else
						entity.PrevAug = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevSep As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevSep
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevSep = Nothing
					Else
						entity.PrevSep = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevQtr3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevQtr3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevQtr3 = Nothing
					Else
						entity.PrevQtr3 = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevOct As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevOct
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevOct = Nothing
					Else
						entity.PrevOct = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevNov As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevNov
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevNov = Nothing
					Else
						entity.PrevNov = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevDec As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevDec
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevDec = Nothing
					Else
						entity.PrevDec = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevQtr4 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevQtr4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevQtr4 = Nothing
					Else
						entity.PrevQtr4 = Convert.ToDecimal(Value)
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
		  	
			Public Property PrevTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PrevTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrevTotal = Nothing
					Else
						entity.PrevTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewSalesByCustomerAnalysis
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewSalesByCustomerAnalysisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewSalesByCustomerAnalysis can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewSalesByCustomerAnalysisQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewSalesByCustomerAnalysisMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property SalesID1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.SalesID1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SalesName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.SalesName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ServiceRep As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.ServiceRep, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Year As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Year, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PrevYear As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Jan As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jan, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevJan As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJan, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Feb As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Feb, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevFeb As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevFeb, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Mar As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Mar, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevMar As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevMar, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr1, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevQtr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr1, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Apr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Apr, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevApr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevApr, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property May As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.May, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevMay As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevMay, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Jun As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jun, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevJun As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJun, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr2, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevQtr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr2, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Jul As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jul, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevJul As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJul, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Aug As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Aug, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevAug As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevAug, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sep As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Sep, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevSep As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevSep, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr3, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevQtr3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr3, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Oct As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Oct, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevOct As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevOct, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Nov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Nov, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevNov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevNov, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Dec As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Dec, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevDec As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevDec, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr4, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevQtr4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr4, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.Ytd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PrevTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevTotal, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewSalesByCustomerAnalysisCollection")> _
	Partial Public Class ViewSalesByCustomerAnalysisCollection
		Inherits esViewSalesByCustomerAnalysisCollection
		Implements IEnumerable(Of ViewSalesByCustomerAnalysis)
		
        Public Shared Widening Operator CType(ByVal coll As ViewSalesByCustomerAnalysisCollection) As List(Of ViewSalesByCustomerAnalysis)
            Dim list As List(Of ViewSalesByCustomerAnalysis) = New List(Of ViewSalesByCustomerAnalysis)
            Dim emp As ViewSalesByCustomerAnalysis

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewSalesByCustomerAnalysisMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewSalesByCustomerAnalysisQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewSalesByCustomerAnalysis(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewSalesByCustomerAnalysis()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewSalesByCustomerAnalysisQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewSalesByCustomerAnalysisQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewSalesByCustomerAnalysisQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewSalesByCustomerAnalysis 
			Return CType(MyBase.AddNewEntity(), ViewSalesByCustomerAnalysis)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewSalesByCustomerAnalysis) Implements IEnumerable(Of ViewSalesByCustomerAnalysis).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewSalesByCustomerAnalysis)(Me)
        End Function
		
		Private _query As ViewSalesByCustomerAnalysisQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewSalesByCustomerAnalysis' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewSalesByCustomerAnalysis ()")> _
	<Serializable> _
	Partial Public Class ViewSalesByCustomerAnalysis 
		Inherits esViewSalesByCustomerAnalysis

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewSalesByCustomerAnalysisMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewSalesByCustomerAnalysisQuery

			If Me._query Is Nothing Then
				Me._query = New ViewSalesByCustomerAnalysisQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewSalesByCustomerAnalysisQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewSalesByCustomerAnalysisQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewSalesByCustomerAnalysisQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewSalesByCustomerAnalysisQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewSalesByCustomerAnalysisQuery
		inherits esViewSalesByCustomerAnalysisQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewSalesByCustomerAnalysisQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewSalesByCustomerAnalysisMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.SalesID1, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.SalesID1
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.SalesName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.SalesName
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Custid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Custname, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.ServiceRep, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.ServiceRep
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Year, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Year
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevYear, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevYear
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jan, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Jan
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJan, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevJan
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Feb, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Feb
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevFeb, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevFeb
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Mar, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Mar
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevMar, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevMar
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr1, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Qtr1
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr1, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevQtr1
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Apr, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Apr
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevApr, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevApr
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.May, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.May
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevMay, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevMay
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jun, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Jun
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJun, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevJun
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr2, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Qtr2
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr2, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevQtr2
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Jul, 23, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Jul
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevJul, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevJul
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Aug, 25, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Aug
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevAug, 26, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevAug
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Sep, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Sep
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevSep, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevSep
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr3, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Qtr3
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr3, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevQtr3
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Oct, 31, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Oct
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevOct, 32, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevOct
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Nov, 33, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Nov
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevNov, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevNov
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Dec, 35, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Dec
			c.NumericPrecision = 38
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevDec, 36, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevDec
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Qtr4, 37, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Qtr4
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevQtr4, 38, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevQtr4
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.Ytd, 39, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.Ytd
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesByCustomerAnalysisMetadata.ColumnNames.PrevTotal, 40, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesByCustomerAnalysisMetadata.PropertyNames.PrevTotal
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewSalesByCustomerAnalysisMetadata
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
			 Public Const SalesID1 As String = "SalesID1"
			 Public Const SalesName As String = "SalesName"
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const ServiceRep As String = "ServiceRep"
			 Public Const Year As String = "YEAR"
			 Public Const PrevYear As String = "PREV_YEAR"
			 Public Const Jan As String = "JAN"
			 Public Const PrevJan As String = "PREV_JAN"
			 Public Const Feb As String = "FEB"
			 Public Const PrevFeb As String = "PREV_FEB"
			 Public Const Mar As String = "MAR"
			 Public Const PrevMar As String = "PREV_MAR"
			 Public Const Qtr1 As String = "QTR1"
			 Public Const PrevQtr1 As String = "PREV_QTR1"
			 Public Const Apr As String = "APR"
			 Public Const PrevApr As String = "PREV_APR"
			 Public Const May As String = "MAY"
			 Public Const PrevMay As String = "PREV_MAY"
			 Public Const Jun As String = "JUN"
			 Public Const PrevJun As String = "PREV_JUN"
			 Public Const Qtr2 As String = "QTR2"
			 Public Const PrevQtr2 As String = "PREV_QTR2"
			 Public Const Jul As String = "JUL"
			 Public Const PrevJul As String = "PREV_JUL"
			 Public Const Aug As String = "AUG"
			 Public Const PrevAug As String = "PREV_AUG"
			 Public Const Sep As String = "SEP"
			 Public Const PrevSep As String = "PREV_SEP"
			 Public Const Qtr3 As String = "QTR3"
			 Public Const PrevQtr3 As String = "PREV_QTR3"
			 Public Const Oct As String = "OCT"
			 Public Const PrevOct As String = "PREV_OCT"
			 Public Const Nov As String = "NOV"
			 Public Const PrevNov As String = "PREV_NOV"
			 Public Const Dec As String = "DEC"
			 Public Const PrevDec As String = "PREV_DEC"
			 Public Const Qtr4 As String = "QTR4"
			 Public Const PrevQtr4 As String = "PREV_QTR4"
			 Public Const Ytd As String = "YTD"
			 Public Const PrevTotal As String = "PREV_TOTAL"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const SalesID1 As String = "SalesID1"
			 Public Const SalesName As String = "SalesName"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const ServiceRep As String = "ServiceRep"
			 Public Const Year As String = "Year"
			 Public Const PrevYear As String = "PrevYear"
			 Public Const Jan As String = "Jan"
			 Public Const PrevJan As String = "PrevJan"
			 Public Const Feb As String = "Feb"
			 Public Const PrevFeb As String = "PrevFeb"
			 Public Const Mar As String = "Mar"
			 Public Const PrevMar As String = "PrevMar"
			 Public Const Qtr1 As String = "Qtr1"
			 Public Const PrevQtr1 As String = "PrevQtr1"
			 Public Const Apr As String = "Apr"
			 Public Const PrevApr As String = "PrevApr"
			 Public Const May As String = "May"
			 Public Const PrevMay As String = "PrevMay"
			 Public Const Jun As String = "Jun"
			 Public Const PrevJun As String = "PrevJun"
			 Public Const Qtr2 As String = "Qtr2"
			 Public Const PrevQtr2 As String = "PrevQtr2"
			 Public Const Jul As String = "Jul"
			 Public Const PrevJul As String = "PrevJul"
			 Public Const Aug As String = "Aug"
			 Public Const PrevAug As String = "PrevAug"
			 Public Const Sep As String = "Sep"
			 Public Const PrevSep As String = "PrevSep"
			 Public Const Qtr3 As String = "Qtr3"
			 Public Const PrevQtr3 As String = "PrevQtr3"
			 Public Const Oct As String = "Oct"
			 Public Const PrevOct As String = "PrevOct"
			 Public Const Nov As String = "Nov"
			 Public Const PrevNov As String = "PrevNov"
			 Public Const Dec As String = "Dec"
			 Public Const PrevDec As String = "PrevDec"
			 Public Const Qtr4 As String = "Qtr4"
			 Public Const PrevQtr4 As String = "PrevQtr4"
			 Public Const Ytd As String = "Ytd"
			 Public Const PrevTotal As String = "PrevTotal"
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
            SyncLock GetType(ViewSalesByCustomerAnalysisMetadata)
			
				If ViewSalesByCustomerAnalysisMetadata.mapDelegates Is Nothing Then
					ViewSalesByCustomerAnalysisMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewSalesByCustomerAnalysisMetadata._meta Is Nothing Then
                    ViewSalesByCustomerAnalysisMetadata._meta = New ViewSalesByCustomerAnalysisMetadata()
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
				

				meta.AddTypeMap("SalesID1", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SalesName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ServiceRep", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Year", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PrevYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Jan", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevJan", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Feb", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevFeb", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Mar", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevMar", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr1", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevQtr1", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Apr", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevApr", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("May", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevMay", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Jun", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevJun", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr2", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevQtr2", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Jul", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevJul", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Aug", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevAug", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sep", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevSep", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr3", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevQtr3", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Oct", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevOct", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Nov", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevNov", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Dec", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevDec", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr4", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevQtr4", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ytd", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PrevTotal", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewSalesByCustomerAnalysis"
				meta.Destination = "viewSalesByCustomerAnalysis"
				
				meta.spInsert = "proc_viewSalesByCustomerAnalysisInsert"
				meta.spUpdate = "proc_viewSalesByCustomerAnalysisUpdate"
				meta.spDelete = "proc_viewSalesByCustomerAnalysisDelete"
				meta.spLoadAll = "proc_viewSalesByCustomerAnalysisLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewSalesByCustomerAnalysisLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewSalesByCustomerAnalysisMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
