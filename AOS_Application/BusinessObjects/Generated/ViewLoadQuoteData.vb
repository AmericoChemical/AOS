'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2019 4:54:12 PM
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
	MustInherit Public Class esViewLoadQuoteDataCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadQuoteDataCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadQuoteDataQuery)
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
            Me.InitQuery(CType(query, esViewLoadQuoteDataQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadQuoteData) As ViewLoadQuoteData
			Return CType(MyBase.DetachEntity(entity), ViewLoadQuoteData)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadQuoteData) As ViewLoadQuoteData
			Return CType(MyBase.AttachEntity(entity), ViewLoadQuoteData)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadQuoteDataCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadQuoteData
            Get
                Return TryCast(MyBase.Item(index), ViewLoadQuoteData)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadQuoteData)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadQuoteData	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadQuoteDataQuery
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
												
						Case "LoadQuoteID"
							Me.str.LoadQuoteID = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "CarrierID"
							Me.str.CarrierID = CType(value, string)
												
						Case "LogisticsProviderID"
							Me.str.LogisticsProviderID = CType(value, string)
												
						Case "QuoteAmount"
							Me.str.QuoteAmount = CType(value, string)
												
						Case "QuoteDate"
							Me.str.QuoteDate = CType(value, string)
												
						Case "CarrierQuoteNumber"
							Me.str.CarrierQuoteNumber = CType(value, string)
												
						Case "CarrierName"
							Me.str.CarrierName = CType(value, string)
												
						Case "CarrierAddress"
							Me.str.CarrierAddress = CType(value, string)
												
						Case "CarrierAddress2"
							Me.str.CarrierAddress2 = CType(value, string)
												
						Case "CarrierCity"
							Me.str.CarrierCity = CType(value, string)
												
						Case "CarrierState"
							Me.str.CarrierState = CType(value, string)
												
						Case "CarrierZipcode"
							Me.str.CarrierZipcode = CType(value, string)
												
						Case "CarrierPhone"
							Me.str.CarrierPhone = CType(value, string)
												
						Case "CarrierFax"
							Me.str.CarrierFax = CType(value, string)
												
						Case "CarrierContactName"
							Me.str.CarrierContactName = CType(value, string)
												
						Case "CarrierContactEmail"
							Me.str.CarrierContactEmail = CType(value, string)
												
						Case "Logisticsname"
							Me.str.Logisticsname = CType(value, string)
												
						Case "Logisticsaddr1"
							Me.str.Logisticsaddr1 = CType(value, string)
												
						Case "Logisticsaddr2"
							Me.str.Logisticsaddr2 = CType(value, string)
												
						Case "Logisticscity"
							Me.str.Logisticscity = CType(value, string)
												
						Case "Logisticsstate"
							Me.str.Logisticsstate = CType(value, string)
												
						Case "Logisticszip"
							Me.str.Logisticszip = CType(value, string)
												
						Case "Logisticsphone"
							Me.str.Logisticsphone = CType(value, string)
												
						Case "Logisticsfax"
							Me.str.Logisticsfax = CType(value, string)
												
						Case "Logisticscontact"
							Me.str.Logisticscontact = CType(value, string)
												
						Case "Logisticsermail"
							Me.str.Logisticsermail = CType(value, string)
												
						Case "EmptyCost"
							Me.str.EmptyCost = CType(value, string)
												
						Case "EquipmentCost"
							Me.str.EquipmentCost = CType(value, string)
												
						Case "FreezeProtect"
							Me.str.FreezeProtect = CType(value, string)
												
						Case "FreezeProtectDesc"
							Me.str.FreezeProtectDesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadQuoteID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadQuoteID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LogisticsProviderID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LogisticsProviderID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QuoteAmount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.QuoteAmount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "QuoteDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.QuoteDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "EmptyCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.EmptyCost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "EquipmentCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.EquipmentCost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "FreezeProtect"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FreezeProtect = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewLoadQuoteData.LoadQuoteID
		' </summary>
		Public Overridable Property LoadQuoteID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadQuoteDataMetadata.ColumnNames.LoadQuoteID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadQuoteDataMetadata.ColumnNames.LoadQuoteID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadQuoteDataMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadQuoteDataMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadQuoteDataMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadQuoteDataMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LogisticsProviderID
		' </summary>
		Public Overridable Property LogisticsProviderID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadQuoteDataMetadata.ColumnNames.LogisticsProviderID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadQuoteDataMetadata.ColumnNames.LogisticsProviderID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.QuoteAmount
		' </summary>
		Public Overridable Property QuoteAmount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadQuoteDataMetadata.ColumnNames.QuoteAmount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadQuoteDataMetadata.ColumnNames.QuoteAmount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.QuoteDate
		' </summary>
		Public Overridable Property QuoteDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadQuoteDataMetadata.ColumnNames.QuoteDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadQuoteDataMetadata.ColumnNames.QuoteDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierQuoteNumber
		' </summary>
		Public Overridable Property CarrierQuoteNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierQuoteNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierQuoteNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierAddress
		' </summary>
		Public Overridable Property CarrierAddress As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierAddress)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierAddress, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierAddress2
		' </summary>
		Public Overridable Property CarrierAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierCity
		' </summary>
		Public Overridable Property CarrierCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierState
		' </summary>
		Public Overridable Property CarrierState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierZipcode
		' </summary>
		Public Overridable Property CarrierZipcode As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierZipcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierZipcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierPhone
		' </summary>
		Public Overridable Property CarrierPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierFax
		' </summary>
		Public Overridable Property CarrierFax As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierFax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierFax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierContactName
		' </summary>
		Public Overridable Property CarrierContactName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierContactName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierContactName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.CarrierContactEmail
		' </summary>
		Public Overridable Property CarrierContactEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierContactEmail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.CarrierContactEmail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSADDR1
		' </summary>
		Public Overridable Property Logisticsaddr1 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsaddr1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsaddr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSADDR2
		' </summary>
		Public Overridable Property Logisticsaddr2 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsaddr2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsaddr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSCITY
		' </summary>
		Public Overridable Property Logisticscity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticscity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticscity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSSTATE
		' </summary>
		Public Overridable Property Logisticsstate As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSZIP
		' </summary>
		Public Overridable Property Logisticszip As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticszip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticszip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSPHONE
		' </summary>
		Public Overridable Property Logisticsphone As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSFAX
		' </summary>
		Public Overridable Property Logisticsfax As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSCONTACT
		' </summary>
		Public Overridable Property Logisticscontact As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticscontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticscontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.LOGISTICSERMAIL
		' </summary>
		Public Overridable Property Logisticsermail As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsermail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsermail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.EmptyCost
		' </summary>
		Public Overridable Property EmptyCost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadQuoteDataMetadata.ColumnNames.EmptyCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadQuoteDataMetadata.ColumnNames.EmptyCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.EquipmentCost
		' </summary>
		Public Overridable Property EquipmentCost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadQuoteDataMetadata.ColumnNames.EquipmentCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadQuoteDataMetadata.ColumnNames.EquipmentCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.FreezeProtect
		' </summary>
		Public Overridable Property FreezeProtect As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadQuoteDataMetadata.ColumnNames.FreezeProtect)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadQuoteDataMetadata.ColumnNames.FreezeProtect, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuoteData.FreezeProtectDesc
		' </summary>
		Public Overridable Property FreezeProtectDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.FreezeProtectDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuoteDataMetadata.ColumnNames.FreezeProtectDesc, value)
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
		
			Public Sub New(ByVal entity As esViewLoadQuoteData)
				Me.entity = entity
			End Sub				
		
	
			Public Property LoadQuoteID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadQuoteID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadQuoteID = Nothing
					Else
						entity.LoadQuoteID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadID = Nothing
					Else
						entity.LoadID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CarrierID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierID = Nothing
					Else
						entity.CarrierID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LogisticsProviderID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LogisticsProviderID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogisticsProviderID = Nothing
					Else
						entity.LogisticsProviderID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property QuoteAmount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.QuoteAmount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuoteAmount = Nothing
					Else
						entity.QuoteAmount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property QuoteDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.QuoteDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuoteDate = Nothing
					Else
						entity.QuoteDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierQuoteNumber As System.String 
				Get
					Dim data_ As System.String = entity.CarrierQuoteNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierQuoteNumber = Nothing
					Else
						entity.CarrierQuoteNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierName As System.String 
				Get
					Dim data_ As System.String = entity.CarrierName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierName = Nothing
					Else
						entity.CarrierName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierAddress As System.String 
				Get
					Dim data_ As System.String = entity.CarrierAddress
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierAddress = Nothing
					Else
						entity.CarrierAddress = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierAddress2 As System.String 
				Get
					Dim data_ As System.String = entity.CarrierAddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierAddress2 = Nothing
					Else
						entity.CarrierAddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierCity As System.String 
				Get
					Dim data_ As System.String = entity.CarrierCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierCity = Nothing
					Else
						entity.CarrierCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierState As System.String 
				Get
					Dim data_ As System.String = entity.CarrierState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierState = Nothing
					Else
						entity.CarrierState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierZipcode As System.String 
				Get
					Dim data_ As System.String = entity.CarrierZipcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierZipcode = Nothing
					Else
						entity.CarrierZipcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierPhone As System.String 
				Get
					Dim data_ As System.String = entity.CarrierPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierPhone = Nothing
					Else
						entity.CarrierPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierFax As System.String 
				Get
					Dim data_ As System.String = entity.CarrierFax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierFax = Nothing
					Else
						entity.CarrierFax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierContactName As System.String 
				Get
					Dim data_ As System.String = entity.CarrierContactName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierContactName = Nothing
					Else
						entity.CarrierContactName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierContactEmail As System.String 
				Get
					Dim data_ As System.String = entity.CarrierContactEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierContactEmail = Nothing
					Else
						entity.CarrierContactEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsname As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsname = Nothing
					Else
						entity.Logisticsname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsaddr1 As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsaddr1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsaddr1 = Nothing
					Else
						entity.Logisticsaddr1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsaddr2 As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsaddr2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsaddr2 = Nothing
					Else
						entity.Logisticsaddr2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticscity As System.String 
				Get
					Dim data_ As System.String = entity.Logisticscity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticscity = Nothing
					Else
						entity.Logisticscity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsstate As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsstate = Nothing
					Else
						entity.Logisticsstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticszip As System.String 
				Get
					Dim data_ As System.String = entity.Logisticszip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticszip = Nothing
					Else
						entity.Logisticszip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsphone As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsphone = Nothing
					Else
						entity.Logisticsphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsfax As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsfax = Nothing
					Else
						entity.Logisticsfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticscontact As System.String 
				Get
					Dim data_ As System.String = entity.Logisticscontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticscontact = Nothing
					Else
						entity.Logisticscontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsermail As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsermail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsermail = Nothing
					Else
						entity.Logisticsermail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmptyCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.EmptyCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmptyCost = Nothing
					Else
						entity.EmptyCost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property EquipmentCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.EquipmentCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EquipmentCost = Nothing
					Else
						entity.EquipmentCost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreezeProtect As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FreezeProtect
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreezeProtect = Nothing
					Else
						entity.FreezeProtect = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreezeProtectDesc As System.String 
				Get
					Dim data_ As System.String = entity.FreezeProtectDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreezeProtectDesc = Nothing
					Else
						entity.FreezeProtectDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadQuoteData
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadQuoteDataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadQuoteData can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadQuoteDataQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadQuoteDataMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadQuoteID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.LoadQuoteID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsProviderID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.LogisticsProviderID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteAmount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.QuoteAmount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.QuoteDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierQuoteNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierQuoteNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierAddress As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierAddress, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierZipcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierZipcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierFax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierFax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierContactName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierContactName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierContactEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.CarrierContactEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticsaddr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticsaddr2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticscity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticsstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticszip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticszip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticsphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsfax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticsfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticscontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsermail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.Logisticsermail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmptyCost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.EmptyCost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property EquipmentCost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.EquipmentCost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FreezeProtect As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.FreezeProtect, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property FreezeProtectDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuoteDataMetadata.ColumnNames.FreezeProtectDesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadQuoteDataCollection")> _
	Partial Public Class ViewLoadQuoteDataCollection
		Inherits esViewLoadQuoteDataCollection
		Implements IEnumerable(Of ViewLoadQuoteData)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadQuoteDataCollection) As List(Of ViewLoadQuoteData)
            Dim list As List(Of ViewLoadQuoteData) = New List(Of ViewLoadQuoteData)
            Dim emp As ViewLoadQuoteData

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadQuoteDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadQuoteDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadQuoteData(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadQuoteData()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadQuoteDataQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadQuoteDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadQuoteDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadQuoteData 
			Return CType(MyBase.AddNewEntity(), ViewLoadQuoteData)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadQuoteData) Implements IEnumerable(Of ViewLoadQuoteData).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadQuoteData)(Me)
        End Function
		
		Private _query As ViewLoadQuoteDataQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadQuoteData' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadQuoteData ()")> _
	<Serializable> _
	Partial Public Class ViewLoadQuoteData 
		Inherits esViewLoadQuoteData

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadQuoteDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadQuoteDataQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadQuoteDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadQuoteDataQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadQuoteDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadQuoteDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadQuoteDataQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadQuoteDataQuery
		inherits esViewLoadQuoteDataQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadQuoteDataQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadQuoteDataMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.LoadQuoteID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.LoadQuoteID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.LoadID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.LogisticsProviderID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.LogisticsProviderID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.QuoteAmount, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.QuoteAmount
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.QuoteDate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.QuoteDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierQuoteNumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierQuoteNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierName, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierAddress, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierAddress
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierAddress2, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierCity, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierState, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierState
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierZipcode, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierZipcode
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierPhone, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierPhone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierFax, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierFax
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierContactName, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierContactName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.CarrierContactEmail, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.CarrierContactEmail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsname, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsaddr1, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticsaddr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsaddr2, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticsaddr2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticscity, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticscity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsstate, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticsstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticszip, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticszip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsphone, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticsphone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsfax, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticsfax
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticscontact, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticscontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.Logisticsermail, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.Logisticsermail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.EmptyCost, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.EmptyCost
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.EquipmentCost, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.EquipmentCost
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.FreezeProtect, 29, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.FreezeProtect
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuoteDataMetadata.ColumnNames.FreezeProtectDesc, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuoteDataMetadata.PropertyNames.FreezeProtectDesc
			c.CharacterMaxLength = 9
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadQuoteDataMetadata
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
			 Public Const LoadQuoteID As String = "LoadQuoteID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const QuoteAmount As String = "QuoteAmount"
			 Public Const QuoteDate As String = "QuoteDate"
			 Public Const CarrierQuoteNumber As String = "CarrierQuoteNumber"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const CarrierAddress As String = "CarrierAddress"
			 Public Const CarrierAddress2 As String = "CarrierAddress2"
			 Public Const CarrierCity As String = "CarrierCity"
			 Public Const CarrierState As String = "CarrierState"
			 Public Const CarrierZipcode As String = "CarrierZipcode"
			 Public Const CarrierPhone As String = "CarrierPhone"
			 Public Const CarrierFax As String = "CarrierFax"
			 Public Const CarrierContactName As String = "CarrierContactName"
			 Public Const CarrierContactEmail As String = "CarrierContactEmail"
			 Public Const Logisticsname As String = "LOGISTICSNAME"
			 Public Const Logisticsaddr1 As String = "LOGISTICSADDR1"
			 Public Const Logisticsaddr2 As String = "LOGISTICSADDR2"
			 Public Const Logisticscity As String = "LOGISTICSCITY"
			 Public Const Logisticsstate As String = "LOGISTICSSTATE"
			 Public Const Logisticszip As String = "LOGISTICSZIP"
			 Public Const Logisticsphone As String = "LOGISTICSPHONE"
			 Public Const Logisticsfax As String = "LOGISTICSFAX"
			 Public Const Logisticscontact As String = "LOGISTICSCONTACT"
			 Public Const Logisticsermail As String = "LOGISTICSERMAIL"
			 Public Const EmptyCost As String = "EmptyCost"
			 Public Const EquipmentCost As String = "EquipmentCost"
			 Public Const FreezeProtect As String = "FreezeProtect"
			 Public Const FreezeProtectDesc As String = "FreezeProtectDesc"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadQuoteID As String = "LoadQuoteID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const QuoteAmount As String = "QuoteAmount"
			 Public Const QuoteDate As String = "QuoteDate"
			 Public Const CarrierQuoteNumber As String = "CarrierQuoteNumber"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const CarrierAddress As String = "CarrierAddress"
			 Public Const CarrierAddress2 As String = "CarrierAddress2"
			 Public Const CarrierCity As String = "CarrierCity"
			 Public Const CarrierState As String = "CarrierState"
			 Public Const CarrierZipcode As String = "CarrierZipcode"
			 Public Const CarrierPhone As String = "CarrierPhone"
			 Public Const CarrierFax As String = "CarrierFax"
			 Public Const CarrierContactName As String = "CarrierContactName"
			 Public Const CarrierContactEmail As String = "CarrierContactEmail"
			 Public Const Logisticsname As String = "Logisticsname"
			 Public Const Logisticsaddr1 As String = "Logisticsaddr1"
			 Public Const Logisticsaddr2 As String = "Logisticsaddr2"
			 Public Const Logisticscity As String = "Logisticscity"
			 Public Const Logisticsstate As String = "Logisticsstate"
			 Public Const Logisticszip As String = "Logisticszip"
			 Public Const Logisticsphone As String = "Logisticsphone"
			 Public Const Logisticsfax As String = "Logisticsfax"
			 Public Const Logisticscontact As String = "Logisticscontact"
			 Public Const Logisticsermail As String = "Logisticsermail"
			 Public Const EmptyCost As String = "EmptyCost"
			 Public Const EquipmentCost As String = "EquipmentCost"
			 Public Const FreezeProtect As String = "FreezeProtect"
			 Public Const FreezeProtectDesc As String = "FreezeProtectDesc"
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
            SyncLock GetType(ViewLoadQuoteDataMetadata)
			
				If ViewLoadQuoteDataMetadata.mapDelegates Is Nothing Then
					ViewLoadQuoteDataMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadQuoteDataMetadata._meta Is Nothing Then
                    ViewLoadQuoteDataMetadata._meta = New ViewLoadQuoteDataMetadata()
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
				

				meta.AddTypeMap("LoadQuoteID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LogisticsProviderID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QuoteAmount", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("QuoteDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CarrierQuoteNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierAddress", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierZipcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierFax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierContactName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierContactEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsaddr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsaddr2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticszip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsermail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmptyCost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("EquipmentCost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("FreezeProtect", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("FreezeProtectDesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewLoadQuoteData"
				meta.Destination = "viewLoadQuoteData"
				
				meta.spInsert = "proc_viewLoadQuoteDataInsert"
				meta.spUpdate = "proc_viewLoadQuoteDataUpdate"
				meta.spDelete = "proc_viewLoadQuoteDataDelete"
				meta.spLoadAll = "proc_viewLoadQuoteDataLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadQuoteDataLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadQuoteDataMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
