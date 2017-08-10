'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.1.0209.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/13/2012 2:56:44 PM
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
 
Namespace BusinessObjects


	<Serializable> _
	MustInherit Public Class esTestresultsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "TestresultsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esTestresultsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntityCollection).Connection
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
            Me.InitQuery(CType(query, esTestresultsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Testresults) As Testresults
			Return CType(MyBase.DetachEntity(entity), Testresults)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Testresults) As Testresults
			Return CType(MyBase.AttachEntity(entity), Testresults)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As TestresultsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Testresults
            Get
                Return TryCast(MyBase.Item(index), Testresults)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Testresults)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esTestresults	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esTestresultsQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal testkey As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(testkey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(testkey)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal testkey As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(testkey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(testkey)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal testkey As System.Int32) As Boolean
		
			Dim query As esTestresultsQuery = Me.GetDynamicQuery()
			query.Where(query.Testkey.Equal(testkey))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal testkey As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("TESTKEY", testkey)
			
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
												
						Case "Testkey"
							Me.str.Testkey = CType(value, string)
												
						Case "Batchkey"
							Me.str.Batchkey = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Testtime"
							Me.str.Testtime = CType(value, string)
												
						Case "Testedby"
							Me.str.Testedby = CType(value, string)
												
						Case "Temperature"
							Me.str.Temperature = CType(value, string)
												
						Case "Ph"
							Me.str.Ph = CType(value, string)
												
						Case "Phrangelow"
							Me.str.Phrangelow = CType(value, string)
												
						Case "Phrangehigh"
							Me.str.Phrangehigh = CType(value, string)
												
						Case "Phaccepted"
							Me.str.Phaccepted = CType(value, string)
												
						Case "Sg"
							Me.str.Sg = CType(value, string)
												
						Case "Sgrangelow"
							Me.str.Sgrangelow = CType(value, string)
												
						Case "Sgrangehigh"
							Me.str.Sgrangehigh = CType(value, string)
												
						Case "Sgaccepted"
							Me.str.Sgaccepted = CType(value, string)
												
						Case "Appearance"
							Me.str.Appearance = CType(value, string)
												
						Case "Shelflife"
							Me.str.Shelflife = CType(value, string)
												
						Case "Freeflowing"
							Me.str.Freeflowing = CType(value, string)
												
						Case "Passed"
							Me.str.Passed = CType(value, string)
												
						Case "Passedby"
							Me.str.Passedby = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Testkey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Testkey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Batchkey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Batchkey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Testtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Testtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Temperature"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Temperature = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ph"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ph = CType(value, Nullable(Of System.Decimal))
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
						
						Case "Sg"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sg = CType(value, Nullable(Of System.Decimal))
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
						
						Case "Passed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Passed = CType(value, Nullable(Of System.DateTime))
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
		' Maps to TESTRESULTS.TESTKEY
		' </summary>
		Public Overridable Property Testkey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TestresultsMetadata.ColumnNames.Testkey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(TestresultsMetadata.ColumnNames.Testkey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.BATCHKEY
		' </summary>
		Public Overridable Property Batchkey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TestresultsMetadata.ColumnNames.Batchkey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(TestresultsMetadata.ColumnNames.Batchkey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TestresultsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(TestresultsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.TESTTIME
		' </summary>
		Public Overridable Property Testtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(TestresultsMetadata.ColumnNames.Testtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(TestresultsMetadata.ColumnNames.Testtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.TESTEDBY
		' </summary>
		Public Overridable Property Testedby As System.String
			Get
				Return MyBase.GetSystemString(TestresultsMetadata.ColumnNames.Testedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(TestresultsMetadata.ColumnNames.Testedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.TEMPERATURE
		' </summary>
		Public Overridable Property Temperature As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TestresultsMetadata.ColumnNames.Temperature)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(TestresultsMetadata.ColumnNames.Temperature, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.PH
		' </summary>
		Public Overridable Property Ph As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TestresultsMetadata.ColumnNames.Ph)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(TestresultsMetadata.ColumnNames.Ph, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.PHRANGELOW
		' </summary>
		Public Overridable Property Phrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TestresultsMetadata.ColumnNames.Phrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(TestresultsMetadata.ColumnNames.Phrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.PHRANGEHIGH
		' </summary>
		Public Overridable Property Phrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TestresultsMetadata.ColumnNames.Phrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(TestresultsMetadata.ColumnNames.Phrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.PHACCEPTED
		' </summary>
		Public Overridable Property Phaccepted As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(TestresultsMetadata.ColumnNames.Phaccepted)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(TestresultsMetadata.ColumnNames.Phaccepted, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.SG
		' </summary>
		Public Overridable Property Sg As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TestresultsMetadata.ColumnNames.Sg)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(TestresultsMetadata.ColumnNames.Sg, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.SGRANGELOW
		' </summary>
		Public Overridable Property Sgrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TestresultsMetadata.ColumnNames.Sgrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(TestresultsMetadata.ColumnNames.Sgrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.SGRANGEHIGH
		' </summary>
		Public Overridable Property Sgrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TestresultsMetadata.ColumnNames.Sgrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(TestresultsMetadata.ColumnNames.Sgrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.SGACCEPTED
		' </summary>
		Public Overridable Property Sgaccepted As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(TestresultsMetadata.ColumnNames.Sgaccepted)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(TestresultsMetadata.ColumnNames.Sgaccepted, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.APPEARANCE
		' </summary>
		Public Overridable Property Appearance As System.String
			Get
				Return MyBase.GetSystemString(TestresultsMetadata.ColumnNames.Appearance)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(TestresultsMetadata.ColumnNames.Appearance, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.SHELFLIFE
		' </summary>
		Public Overridable Property Shelflife As System.String
			Get
				Return MyBase.GetSystemString(TestresultsMetadata.ColumnNames.Shelflife)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(TestresultsMetadata.ColumnNames.Shelflife, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.FREEFLOWING
		' </summary>
		Public Overridable Property Freeflowing As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(TestresultsMetadata.ColumnNames.Freeflowing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(TestresultsMetadata.ColumnNames.Freeflowing, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.PASSED
		' </summary>
		Public Overridable Property Passed As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(TestresultsMetadata.ColumnNames.Passed)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(TestresultsMetadata.ColumnNames.Passed, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to TESTRESULTS.PASSEDBY
		' </summary>
		Public Overridable Property Passedby As System.String
			Get
				Return MyBase.GetSystemString(TestresultsMetadata.ColumnNames.Passedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(TestresultsMetadata.ColumnNames.Passedby, value)
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
		
			Public Sub New(ByVal entity As esTestresults)
				Me.entity = entity
			End Sub				
		
	
			Public Property Testkey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Testkey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Testkey = Nothing
					Else
						entity.Testkey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Batchkey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Batchkey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Batchkey = Nothing
					Else
						entity.Batchkey = Convert.ToInt32(Value)
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
		  	
			Public Property Ph As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ph
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ph = Nothing
					Else
						entity.Ph = Convert.ToDecimal(Value)
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
		  	
			Public Property Sg As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sg
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sg = Nothing
					Else
						entity.Sg = Convert.ToDecimal(Value)
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
		  	
			Public Property Passed As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Passed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Passed = Nothing
					Else
						entity.Passed = Convert.ToDateTime(Value)
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
		  

			Private entity As esTestresults
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esTestresultsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esTestresults can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Testresults 
		Inherits esTestresults
		
	
		
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
	MustInherit Public Class esTestresultsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TestresultsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Testkey As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Testkey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Batchkey As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Batchkey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Testtime As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Testtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Testedby As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Testedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Temperature As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Temperature, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ph As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Ph, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Phrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Phrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phaccepted As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Phaccepted, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Sg As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Sg, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Sgrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Sgrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgaccepted As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Sgaccepted, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Appearance As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Appearance, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shelflife As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Shelflife, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freeflowing As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Freeflowing, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Passed As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Passed, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Passedby As esQueryItem
			Get
				Return New esQueryItem(Me, TestresultsMetadata.ColumnNames.Passedby, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("TestresultsCollection")> _
	Partial Public Class TestresultsCollection
		Inherits esTestresultsCollection
		Implements IEnumerable(Of Testresults)
		
        Public Shared Widening Operator CType(ByVal coll As TestresultsCollection) As List(Of Testresults)
            Dim list As List(Of Testresults) = New List(Of Testresults)
            Dim emp As Testresults

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TestresultsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New TestresultsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Testresults(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Testresults()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As TestresultsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New TestresultsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As TestresultsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Testresults 
			Return CType(MyBase.AddNewEntity(), Testresults)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal testkey As System.Int32) As Testresults
			Return CType(MyBase.FindByPrimaryKey(testkey), Testresults)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Testresults) Implements IEnumerable(Of Testresults).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Testresults)(Me)
        End Function
		
		Private _query As TestresultsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'TESTRESULTS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Testresults ({Testkey.Value})")> _
	<Serializable> _
	Partial Public Class Testresults 
		Inherits esTestresults

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return TestresultsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esTestresultsQuery

			If Me._query Is Nothing Then
				Me._query = New TestresultsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As TestresultsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New TestresultsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As TestresultsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As TestresultsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class TestresultsQuery
		inherits esTestresultsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
				

	End Class




	<Serializable> _
	Partial Public Class TestresultsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Testkey, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Testkey
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Batchkey, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Batchkey
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Testtime, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Testtime
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Testedby, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Testedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Temperature, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Temperature
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Ph, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Ph
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Phrangelow, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Phrangelow
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Phrangehigh, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Phrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Phaccepted, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Phaccepted
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Sg, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Sg
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Sgrangelow, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Sgrangelow
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Sgrangehigh, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Sgrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Sgaccepted, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Sgaccepted
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Appearance, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Appearance
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Shelflife, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Shelflife
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Freeflowing, 16, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Freeflowing
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Passed, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Passed
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(TestresultsMetadata.ColumnNames.Passedby, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = TestresultsMetadata.PropertyNames.Passedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As TestresultsMetadata
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
			 Public Const Testkey As String = "TESTKEY"
			 Public Const Batchkey As String = "BATCHKEY"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Testtime As String = "TESTTIME"
			 Public Const Testedby As String = "TESTEDBY"
			 Public Const Temperature As String = "TEMPERATURE"
			 Public Const Ph As String = "PH"
			 Public Const Phrangelow As String = "PHRANGELOW"
			 Public Const Phrangehigh As String = "PHRANGEHIGH"
			 Public Const Phaccepted As String = "PHACCEPTED"
			 Public Const Sg As String = "SG"
			 Public Const Sgrangelow As String = "SGRANGELOW"
			 Public Const Sgrangehigh As String = "SGRANGEHIGH"
			 Public Const Sgaccepted As String = "SGACCEPTED"
			 Public Const Appearance As String = "APPEARANCE"
			 Public Const Shelflife As String = "SHELFLIFE"
			 Public Const Freeflowing As String = "FREEFLOWING"
			 Public Const Passed As String = "PASSED"
			 Public Const Passedby As String = "PASSEDBY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Testkey As String = "Testkey"
			 Public Const Batchkey As String = "Batchkey"
			 Public Const Productid As String = "Productid"
			 Public Const Testtime As String = "Testtime"
			 Public Const Testedby As String = "Testedby"
			 Public Const Temperature As String = "Temperature"
			 Public Const Ph As String = "Ph"
			 Public Const Phrangelow As String = "Phrangelow"
			 Public Const Phrangehigh As String = "Phrangehigh"
			 Public Const Phaccepted As String = "Phaccepted"
			 Public Const Sg As String = "Sg"
			 Public Const Sgrangelow As String = "Sgrangelow"
			 Public Const Sgrangehigh As String = "Sgrangehigh"
			 Public Const Sgaccepted As String = "Sgaccepted"
			 Public Const Appearance As String = "Appearance"
			 Public Const Shelflife As String = "Shelflife"
			 Public Const Freeflowing As String = "Freeflowing"
			 Public Const Passed As String = "Passed"
			 Public Const Passedby As String = "Passedby"
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
            SyncLock GetType(TestresultsMetadata)
			
				If TestresultsMetadata.mapDelegates Is Nothing Then
					TestresultsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If TestresultsMetadata._meta Is Nothing Then
                    TestresultsMetadata._meta = New TestresultsMetadata()
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
				

				meta.AddTypeMap("TESTKEY", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BATCHKEY", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PRODUCTID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TESTTIME", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("TESTEDBY", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TEMPERATURE", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PH", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PHRANGELOW", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PHRANGEHIGH", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PHACCEPTED", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SG", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("SGRANGELOW", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("SGRANGEHIGH", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("SGACCEPTED", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("APPEARANCE", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SHELFLIFE", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FREEFLOWING", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("PASSED", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PASSEDBY", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "TESTRESULTS"
				meta.Destination = "TESTRESULTS"
				
				meta.spInsert = "proc_TESTRESULTSInsert"
				meta.spUpdate = "proc_TESTRESULTSUpdate"
				meta.spDelete = "proc_TESTRESULTSDelete"
				meta.spLoadAll = "proc_TESTRESULTSLoadAll"
				meta.spLoadByPrimaryKey = "proc_TESTRESULTSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As TestresultsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
