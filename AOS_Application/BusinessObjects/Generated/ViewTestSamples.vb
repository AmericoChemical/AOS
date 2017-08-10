'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/3/2015 9:58:46 AM
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
	MustInherit Public Class esViewTestSamplesCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewTestSamplesCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewTestSamplesQuery)
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
            Me.InitQuery(CType(query, esViewTestSamplesQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewTestSamples) As ViewTestSamples
			Return CType(MyBase.DetachEntity(entity), ViewTestSamples)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewTestSamples) As ViewTestSamples
			Return CType(MyBase.AttachEntity(entity), ViewTestSamples)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewTestSamplesCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewTestSamples
            Get
                Return TryCast(MyBase.Item(index), ViewTestSamples)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewTestSamples)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewTestSamples	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewTestSamplesQuery
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
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Testsamplekey"
							Me.str.Testsamplekey = CType(value, string)
												
						Case "Testtime"
							Me.str.Testtime = CType(value, string)
												
						Case "Testedby"
							Me.str.Testedby = CType(value, string)
												
						Case "Temperature"
							Me.str.Temperature = CType(value, string)
												
						Case "Phresult"
							Me.str.Phresult = CType(value, string)
												
						Case "Phrangelow"
							Me.str.Phrangelow = CType(value, string)
												
						Case "Phrangehigh"
							Me.str.Phrangehigh = CType(value, string)
												
						Case "Phaccepted"
							Me.str.Phaccepted = CType(value, string)
												
						Case "Sgresult"
							Me.str.Sgresult = CType(value, string)
												
						Case "Sgrangelow"
							Me.str.Sgrangelow = CType(value, string)
												
						Case "Sgrangehigh"
							Me.str.Sgrangehigh = CType(value, string)
												
						Case "Sgaccepted"
							Me.str.Sgaccepted = CType(value, string)
												
						Case "Color"
							Me.str.Color = CType(value, string)
												
						Case "Clarity"
							Me.str.Clarity = CType(value, string)
												
						Case "Odor"
							Me.str.Odor = CType(value, string)
												
						Case "Appearance"
							Me.str.Appearance = CType(value, string)
												
						Case "Freeflowing"
							Me.str.Freeflowing = CType(value, string)
												
						Case "Passedtime"
							Me.str.Passedtime = CType(value, string)
												
						Case "Passedby"
							Me.str.Passedby = CType(value, string)
												
						Case "Passedtest"
							Me.str.Passedtest = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Testsamplekey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Testsamplekey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Testtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Testtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Temperature"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Temperature = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phresult"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phresult = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phrangelow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phrangelow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phrangehigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phrangehigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phaccepted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Phaccepted = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Sgresult"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgresult = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgrangelow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgrangelow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgrangehigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgrangehigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgaccepted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Sgaccepted = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Freeflowing"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Freeflowing = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Passedtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Passedtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Passedtest"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Passedtest = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewTestSamples.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewTestSamplesMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewTestSamplesMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewTestSamplesMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewTestSamplesMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.TESTSAMPLEKEY
		' </summary>
		Public Overridable Property Testsamplekey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewTestSamplesMetadata.ColumnNames.Testsamplekey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewTestSamplesMetadata.ColumnNames.Testsamplekey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.TESTTIME
		' </summary>
		Public Overridable Property Testtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewTestSamplesMetadata.ColumnNames.Testtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewTestSamplesMetadata.ColumnNames.Testtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.TESTEDBY
		' </summary>
		Public Overridable Property Testedby As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Testedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Testedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.TEMPERATURE
		' </summary>
		Public Overridable Property Temperature As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Temperature)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Temperature, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PHRESULT
		' </summary>
		Public Overridable Property Phresult As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Phresult)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Phresult, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PHRANGELOW
		' </summary>
		Public Overridable Property Phrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Phrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Phrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PHRANGEHIGH
		' </summary>
		Public Overridable Property Phrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Phrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Phrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PHACCEPTED
		' </summary>
		Public Overridable Property Phaccepted As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewTestSamplesMetadata.ColumnNames.Phaccepted)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewTestSamplesMetadata.ColumnNames.Phaccepted, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.SGRESULT
		' </summary>
		Public Overridable Property Sgresult As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Sgresult)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Sgresult, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.SGRANGELOW
		' </summary>
		Public Overridable Property Sgrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Sgrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Sgrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.SGRANGEHIGH
		' </summary>
		Public Overridable Property Sgrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Sgrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewTestSamplesMetadata.ColumnNames.Sgrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.SGACCEPTED
		' </summary>
		Public Overridable Property Sgaccepted As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewTestSamplesMetadata.ColumnNames.Sgaccepted)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewTestSamplesMetadata.ColumnNames.Sgaccepted, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.COLOR
		' </summary>
		Public Overridable Property Color As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Color)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Color, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.CLARITY
		' </summary>
		Public Overridable Property Clarity As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Clarity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Clarity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.ODOR
		' </summary>
		Public Overridable Property Odor As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Odor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Odor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.APPEARANCE
		' </summary>
		Public Overridable Property Appearance As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Appearance)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Appearance, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.FREEFLOWING
		' </summary>
		Public Overridable Property Freeflowing As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewTestSamplesMetadata.ColumnNames.Freeflowing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewTestSamplesMetadata.ColumnNames.Freeflowing, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PASSEDTIME
		' </summary>
		Public Overridable Property Passedtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewTestSamplesMetadata.ColumnNames.Passedtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewTestSamplesMetadata.ColumnNames.Passedtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PASSEDBY
		' </summary>
		Public Overridable Property Passedby As System.String
			Get
				Return MyBase.GetSystemString(ViewTestSamplesMetadata.ColumnNames.Passedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewTestSamplesMetadata.ColumnNames.Passedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewTestSamples.PASSEDTEST
		' </summary>
		Public Overridable Property Passedtest As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewTestSamplesMetadata.ColumnNames.Passedtest)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewTestSamplesMetadata.ColumnNames.Passedtest, value)
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
		
			Public Sub New(ByVal entity As esViewTestSamples)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnumber = Nothing
					Else
						entity.Invitemnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Lotnumber As System.String 
				Get
					Dim data_ As System.String = entity.Lotnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lotnumber = Nothing
					Else
						entity.Lotnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Itemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemstatus = Nothing
					Else
						entity.Itemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Testsamplekey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Testsamplekey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Testsamplekey = Nothing
					Else
						entity.Testsamplekey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Testtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Testtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Testtime = Nothing
					Else
						entity.Testtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Testedby As System.String 
				Get
					Dim data_ As System.String = entity.Testedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Testedby = Nothing
					Else
						entity.Testedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Temperature As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Temperature
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Temperature = Nothing
					Else
						entity.Temperature = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phresult As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Phresult
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phresult = Nothing
					Else
						entity.Phresult = Convert.ToDecimal(Value)
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
		  	
			Public Property Phaccepted As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Phaccepted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phaccepted = Nothing
					Else
						entity.Phaccepted = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sgresult As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sgresult
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sgresult = Nothing
					Else
						entity.Sgresult = Convert.ToDecimal(Value)
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
		  	
			Public Property Sgaccepted As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Sgaccepted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sgaccepted = Nothing
					Else
						entity.Sgaccepted = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Color As System.String 
				Get
					Dim data_ As System.String = entity.Color
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Color = Nothing
					Else
						entity.Color = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Clarity As System.String 
				Get
					Dim data_ As System.String = entity.Clarity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Clarity = Nothing
					Else
						entity.Clarity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Odor As System.String 
				Get
					Dim data_ As System.String = entity.Odor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Odor = Nothing
					Else
						entity.Odor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appearance As System.String 
				Get
					Dim data_ As System.String = entity.Appearance
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appearance = Nothing
					Else
						entity.Appearance = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freeflowing As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Freeflowing
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freeflowing = Nothing
					Else
						entity.Freeflowing = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Passedtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Passedtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Passedtime = Nothing
					Else
						entity.Passedtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Passedby As System.String 
				Get
					Dim data_ As System.String = entity.Passedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Passedby = Nothing
					Else
						entity.Passedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Passedtest As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Passedtest
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Passedtest = Nothing
					Else
						entity.Passedtest = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewTestSamples
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewTestSamplesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewTestSamples can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewTestSamplesQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewTestSamplesMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Testsamplekey As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Testsamplekey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Testtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Testtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Testedby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Testedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Temperature As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Temperature, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phresult As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Phresult, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Phrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Phrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phaccepted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Phaccepted, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Sgresult As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Sgresult, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Sgrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Sgrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgaccepted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Sgaccepted, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Color As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Color, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Clarity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Clarity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Odor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Odor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Appearance As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Appearance, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freeflowing As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Freeflowing, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Passedtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Passedtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Passedby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Passedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Passedtest As esQueryItem
			Get
				Return New esQueryItem(Me, ViewTestSamplesMetadata.ColumnNames.Passedtest, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewTestSamplesCollection")> _
	Partial Public Class ViewTestSamplesCollection
		Inherits esViewTestSamplesCollection
		Implements IEnumerable(Of ViewTestSamples)
		
        Public Shared Widening Operator CType(ByVal coll As ViewTestSamplesCollection) As List(Of ViewTestSamples)
            Dim list As List(Of ViewTestSamples) = New List(Of ViewTestSamples)
            Dim emp As ViewTestSamples

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewTestSamplesMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewTestSamplesQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewTestSamples(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewTestSamples()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewTestSamplesQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewTestSamplesQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewTestSamplesQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewTestSamples 
			Return CType(MyBase.AddNewEntity(), ViewTestSamples)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewTestSamples) Implements IEnumerable(Of ViewTestSamples).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewTestSamples)(Me)
        End Function
		
		Private _query As ViewTestSamplesQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewTestSamples' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewTestSamples ()")> _
	<Serializable> _
	Partial Public Class ViewTestSamples 
		Inherits esViewTestSamples

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewTestSamplesMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewTestSamplesQuery

			If Me._query Is Nothing Then
				Me._query = New ViewTestSamplesQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewTestSamplesQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewTestSamplesQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewTestSamplesQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewTestSamplesQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewTestSamplesQuery
		inherits esViewTestSamplesQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewTestSamplesQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewTestSamplesMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Lotnumber, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Itemstatus, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Testsamplekey, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Testsamplekey
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Testtime, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Testtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Testedby, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Testedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Temperature, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Temperature
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Phresult, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Phresult
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Phrangelow, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Phrangelow
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Phrangehigh, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Phrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Phaccepted, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Phaccepted
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Sgresult, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Sgresult
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Sgrangelow, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Sgrangelow
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Sgrangehigh, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Sgrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Sgaccepted, 17, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Sgaccepted
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Color, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Color
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Clarity, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Clarity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Odor, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Odor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Appearance, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Appearance
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Freeflowing, 22, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Freeflowing
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Passedtime, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Passedtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Passedby, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Passedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewTestSamplesMetadata.ColumnNames.Passedtest, 25, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewTestSamplesMetadata.PropertyNames.Passedtest
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewTestSamplesMetadata
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
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Testsamplekey As String = "TESTSAMPLEKEY"
			 Public Const Testtime As String = "TESTTIME"
			 Public Const Testedby As String = "TESTEDBY"
			 Public Const Temperature As String = "TEMPERATURE"
			 Public Const Phresult As String = "PHRESULT"
			 Public Const Phrangelow As String = "PHRANGELOW"
			 Public Const Phrangehigh As String = "PHRANGEHIGH"
			 Public Const Phaccepted As String = "PHACCEPTED"
			 Public Const Sgresult As String = "SGRESULT"
			 Public Const Sgrangelow As String = "SGRANGELOW"
			 Public Const Sgrangehigh As String = "SGRANGEHIGH"
			 Public Const Sgaccepted As String = "SGACCEPTED"
			 Public Const Color As String = "COLOR"
			 Public Const Clarity As String = "CLARITY"
			 Public Const Odor As String = "ODOR"
			 Public Const Appearance As String = "APPEARANCE"
			 Public Const Freeflowing As String = "FREEFLOWING"
			 Public Const Passedtime As String = "PASSEDTIME"
			 Public Const Passedby As String = "PASSEDBY"
			 Public Const Passedtest As String = "PASSEDTEST"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Testsamplekey As String = "Testsamplekey"
			 Public Const Testtime As String = "Testtime"
			 Public Const Testedby As String = "Testedby"
			 Public Const Temperature As String = "Temperature"
			 Public Const Phresult As String = "Phresult"
			 Public Const Phrangelow As String = "Phrangelow"
			 Public Const Phrangehigh As String = "Phrangehigh"
			 Public Const Phaccepted As String = "Phaccepted"
			 Public Const Sgresult As String = "Sgresult"
			 Public Const Sgrangelow As String = "Sgrangelow"
			 Public Const Sgrangehigh As String = "Sgrangehigh"
			 Public Const Sgaccepted As String = "Sgaccepted"
			 Public Const Color As String = "Color"
			 Public Const Clarity As String = "Clarity"
			 Public Const Odor As String = "Odor"
			 Public Const Appearance As String = "Appearance"
			 Public Const Freeflowing As String = "Freeflowing"
			 Public Const Passedtime As String = "Passedtime"
			 Public Const Passedby As String = "Passedby"
			 Public Const Passedtest As String = "Passedtest"
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
            SyncLock GetType(ViewTestSamplesMetadata)
			
				If ViewTestSamplesMetadata.mapDelegates Is Nothing Then
					ViewTestSamplesMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewTestSamplesMetadata._meta Is Nothing Then
                    ViewTestSamplesMetadata._meta = New ViewTestSamplesMetadata()
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
				

				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Testsamplekey", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Testtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Testedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Temperature", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phresult", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phrangelow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phrangehigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phaccepted", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Sgresult", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgrangelow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgrangehigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgaccepted", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Color", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Clarity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Odor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Appearance", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freeflowing", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Passedtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Passedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Passedtest", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "viewTestSamples"
				meta.Destination = "viewTestSamples"
				
				meta.spInsert = "proc_viewTestSamplesInsert"
				meta.spUpdate = "proc_viewTestSamplesUpdate"
				meta.spDelete = "proc_viewTestSamplesDelete"
				meta.spLoadAll = "proc_viewTestSamplesLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewTestSamplesLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewTestSamplesMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
