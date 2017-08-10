'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/18/2016 2:45:23 PM
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
	MustInherit Public Class esSysparametersCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "SysparametersCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esSysparametersQuery)
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
            Me.InitQuery(CType(query, esSysparametersQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Sysparameters) As Sysparameters
			Return CType(MyBase.DetachEntity(entity), Sysparameters)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Sysparameters) As Sysparameters
			Return CType(MyBase.AttachEntity(entity), Sysparameters)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As SysparametersCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Sysparameters
            Get
                Return TryCast(MyBase.Item(index), Sysparameters)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Sysparameters)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esSysparameters	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esSysparametersQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal recordID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recordID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recordID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal recordID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recordID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recordID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal recordID As System.Int32) As Boolean
		
			Dim query As esSysparametersQuery = Me.GetDynamicQuery()
			query.Where(query.RecordID.Equal(recordID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal recordID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RecordID", recordID)
			
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
												
						Case "RecordID"
							Me.str.RecordID = CType(value, string)
												
						Case "CompanyName"
							Me.str.CompanyName = CType(value, string)
												
						Case "CompanyAddress"
							Me.str.CompanyAddress = CType(value, string)
												
						Case "CompanyCity"
							Me.str.CompanyCity = CType(value, string)
												
						Case "CompanyState"
							Me.str.CompanyState = CType(value, string)
												
						Case "CompanyZipcode"
							Me.str.CompanyZipcode = CType(value, string)
												
						Case "CompanyCountry"
							Me.str.CompanyCountry = CType(value, string)
												
						Case "CompanyPhone"
							Me.str.CompanyPhone = CType(value, string)
												
						Case "CompanyFAX"
							Me.str.CompanyFAX = CType(value, string)
												
						Case "Defaultsalestaxrate"
							Me.str.Defaultsalestaxrate = CType(value, string)
												
						Case "Stdlaborhourcost"
							Me.str.Stdlaborhourcost = CType(value, string)
												
						Case "FreezeWarning"
							Me.str.FreezeWarning = CType(value, string)
												
						Case "COAText"
							Me.str.COAText = CType(value, string)
												
						Case "Stdoverheadhourcost"
							Me.str.Stdoverheadhourcost = CType(value, string)
												
						Case "PRODORDERMaxIdleTime"
							Me.str.PRODORDERMaxIdleTime = CType(value, string)
												
						Case "MaxLoadWeight"
							Me.str.MaxLoadWeight = CType(value, string)
												
						Case "SecurityTimer"
							Me.str.SecurityTimer = CType(value, string)
												
						Case "Companyemaildomain"
							Me.str.Companyemaildomain = CType(value, string)
												
						Case "Companyemailserver"
							Me.str.Companyemailserver = CType(value, string)
												
						Case "WOEmailSender"
							Me.str.WOEmailSender = CType(value, string)
												
						Case "WOEmailReceiver"
							Me.str.WOEmailReceiver = CType(value, string)
												
						Case "AllowableWeightVariancePercentage"
							Me.str.AllowableWeightVariancePercentage = CType(value, string)
												
						Case "DefaultVendorTestPercentage"
							Me.str.DefaultVendorTestPercentage = CType(value, string)
												
						Case "Setprodordestcompdate"
							Me.str.Setprodordestcompdate = CType(value, string)
												
						Case "Additionaldefaultsendtoaddress"
							Me.str.Additionaldefaultsendtoaddress = CType(value, string)
												
						Case "MaxVolumeForNonRegDOT"
							Me.str.MaxVolumeForNonRegDOT = CType(value, string)
												
						Case "NonRegulatedDOTDesc"
							Me.str.NonRegulatedDOTDesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RecordID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecordID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Defaultsalestaxrate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Defaultsalestaxrate = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdlaborhourcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdlaborhourcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "FreezeWarning"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FreezeWarning = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdoverheadhourcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdoverheadhourcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PRODORDERMaxIdleTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PRODORDERMaxIdleTime = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "MaxLoadWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MaxLoadWeight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SecurityTimer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecurityTimer = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "AllowableWeightVariancePercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.AllowableWeightVariancePercentage = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "DefaultVendorTestPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DefaultVendorTestPercentage = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Setprodordestcompdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Setprodordestcompdate = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "MaxVolumeForNonRegDOT"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MaxVolumeForNonRegDOT = CType(value, Nullable(Of System.Decimal))
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
		' Maps to SYSPARAMETERS.RecordID
		' </summary>
		Public Overridable Property RecordID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SysparametersMetadata.ColumnNames.RecordID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SysparametersMetadata.ColumnNames.RecordID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.CompanyName
		' </summary>
		Public Overridable Property CompanyName As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.CompanyName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.CompanyName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.CompanyAddress
		' </summary>
		Public Overridable Property CompanyAddress As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.CompanyAddress)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.CompanyAddress, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.CompanyCity
		' </summary>
		Public Overridable Property CompanyCity As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.CompanyCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.CompanyCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.CompanyState
		' </summary>
		Public Overridable Property CompanyState As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.CompanyState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.CompanyState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.CompanyZipcode
		' </summary>
		Public Overridable Property CompanyZipcode As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.CompanyZipcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.CompanyZipcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.CompanyCountry
		' </summary>
		Public Overridable Property CompanyCountry As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.CompanyCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.CompanyCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.CompanyPhone
		' </summary>
		Public Overridable Property CompanyPhone As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.CompanyPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.CompanyPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.CompanyFAX
		' </summary>
		Public Overridable Property CompanyFAX As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.CompanyFAX)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.CompanyFAX, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.DEFAULTSALESTAXRATE
		' </summary>
		Public Overridable Property Defaultsalestaxrate As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(SysparametersMetadata.ColumnNames.Defaultsalestaxrate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(SysparametersMetadata.ColumnNames.Defaultsalestaxrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.STDLABORHOURCOST
		' </summary>
		Public Overridable Property Stdlaborhourcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(SysparametersMetadata.ColumnNames.Stdlaborhourcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(SysparametersMetadata.ColumnNames.Stdlaborhourcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.FreezeWarning
		' </summary>
		Public Overridable Property FreezeWarning As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SysparametersMetadata.ColumnNames.FreezeWarning)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SysparametersMetadata.ColumnNames.FreezeWarning, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.COAText
		' </summary>
		Public Overridable Property COAText As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.COAText)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.COAText, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.STDOVERHEADHOURCOST
		' </summary>
		Public Overridable Property Stdoverheadhourcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(SysparametersMetadata.ColumnNames.Stdoverheadhourcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(SysparametersMetadata.ColumnNames.Stdoverheadhourcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.PRODORDERMaxIdleTime
		' </summary>
		Public Overridable Property PRODORDERMaxIdleTime As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SysparametersMetadata.ColumnNames.PRODORDERMaxIdleTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SysparametersMetadata.ColumnNames.PRODORDERMaxIdleTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.MaxLoadWeight
		' </summary>
		Public Overridable Property MaxLoadWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SysparametersMetadata.ColumnNames.MaxLoadWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SysparametersMetadata.ColumnNames.MaxLoadWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.SecurityTimer
		' </summary>
		Public Overridable Property SecurityTimer As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SysparametersMetadata.ColumnNames.SecurityTimer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SysparametersMetadata.ColumnNames.SecurityTimer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.COMPANYEMAILDOMAIN
		' </summary>
		Public Overridable Property Companyemaildomain As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.Companyemaildomain)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.Companyemaildomain, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.COMPANYEMAILSERVER
		' </summary>
		Public Overridable Property Companyemailserver As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.Companyemailserver)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.Companyemailserver, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.WOEmailSender
		' </summary>
		Public Overridable Property WOEmailSender As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.WOEmailSender)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.WOEmailSender, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.WOEmailReceiver
		' </summary>
		Public Overridable Property WOEmailReceiver As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.WOEmailReceiver)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.WOEmailReceiver, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.AllowableWeightVariancePercentage
		' </summary>
		Public Overridable Property AllowableWeightVariancePercentage As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SysparametersMetadata.ColumnNames.AllowableWeightVariancePercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SysparametersMetadata.ColumnNames.AllowableWeightVariancePercentage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.DefaultVendorTestPercentage
		' </summary>
		Public Overridable Property DefaultVendorTestPercentage As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SysparametersMetadata.ColumnNames.DefaultVendorTestPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SysparametersMetadata.ColumnNames.DefaultVendorTestPercentage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.SETPRODORDESTCOMPDATE
		' </summary>
		Public Overridable Property Setprodordestcompdate As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(SysparametersMetadata.ColumnNames.Setprodordestcompdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(SysparametersMetadata.ColumnNames.Setprodordestcompdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.ADDITIONALDEFAULTSENDTOADDRESS
		' </summary>
		Public Overridable Property Additionaldefaultsendtoaddress As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.Additionaldefaultsendtoaddress)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.Additionaldefaultsendtoaddress, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.MaxVolumeForNonRegDOT
		' </summary>
		Public Overridable Property MaxVolumeForNonRegDOT As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(SysparametersMetadata.ColumnNames.MaxVolumeForNonRegDOT)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(SysparametersMetadata.ColumnNames.MaxVolumeForNonRegDOT, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SYSPARAMETERS.NonRegulatedDOTDesc
		' </summary>
		Public Overridable Property NonRegulatedDOTDesc As System.String
			Get
				Return MyBase.GetSystemString(SysparametersMetadata.ColumnNames.NonRegulatedDOTDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SysparametersMetadata.ColumnNames.NonRegulatedDOTDesc, value)
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
		
			Public Sub New(ByVal entity As esSysparameters)
				Me.entity = entity
			End Sub				
		
	
			Public Property RecordID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecordID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecordID = Nothing
					Else
						entity.RecordID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyName As System.String 
				Get
					Dim data_ As System.String = entity.CompanyName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyName = Nothing
					Else
						entity.CompanyName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyAddress As System.String 
				Get
					Dim data_ As System.String = entity.CompanyAddress
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyAddress = Nothing
					Else
						entity.CompanyAddress = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyCity As System.String 
				Get
					Dim data_ As System.String = entity.CompanyCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyCity = Nothing
					Else
						entity.CompanyCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyState As System.String 
				Get
					Dim data_ As System.String = entity.CompanyState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyState = Nothing
					Else
						entity.CompanyState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyZipcode As System.String 
				Get
					Dim data_ As System.String = entity.CompanyZipcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyZipcode = Nothing
					Else
						entity.CompanyZipcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyCountry As System.String 
				Get
					Dim data_ As System.String = entity.CompanyCountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyCountry = Nothing
					Else
						entity.CompanyCountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyPhone As System.String 
				Get
					Dim data_ As System.String = entity.CompanyPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyPhone = Nothing
					Else
						entity.CompanyPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyFAX As System.String 
				Get
					Dim data_ As System.String = entity.CompanyFAX
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyFAX = Nothing
					Else
						entity.CompanyFAX = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Defaultsalestaxrate As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Defaultsalestaxrate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Defaultsalestaxrate = Nothing
					Else
						entity.Defaultsalestaxrate = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdlaborhourcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdlaborhourcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdlaborhourcost = Nothing
					Else
						entity.Stdlaborhourcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreezeWarning As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FreezeWarning
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreezeWarning = Nothing
					Else
						entity.FreezeWarning = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property COAText As System.String 
				Get
					Dim data_ As System.String = entity.COAText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.COAText = Nothing
					Else
						entity.COAText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdoverheadhourcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdoverheadhourcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdoverheadhourcost = Nothing
					Else
						entity.Stdoverheadhourcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PRODORDERMaxIdleTime As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PRODORDERMaxIdleTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PRODORDERMaxIdleTime = Nothing
					Else
						entity.PRODORDERMaxIdleTime = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxLoadWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MaxLoadWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxLoadWeight = Nothing
					Else
						entity.MaxLoadWeight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecurityTimer As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SecurityTimer
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecurityTimer = Nothing
					Else
						entity.SecurityTimer = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Companyemaildomain As System.String 
				Get
					Dim data_ As System.String = entity.Companyemaildomain
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Companyemaildomain = Nothing
					Else
						entity.Companyemaildomain = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Companyemailserver As System.String 
				Get
					Dim data_ As System.String = entity.Companyemailserver
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Companyemailserver = Nothing
					Else
						entity.Companyemailserver = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WOEmailSender As System.String 
				Get
					Dim data_ As System.String = entity.WOEmailSender
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WOEmailSender = Nothing
					Else
						entity.WOEmailSender = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WOEmailReceiver As System.String 
				Get
					Dim data_ As System.String = entity.WOEmailReceiver
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WOEmailReceiver = Nothing
					Else
						entity.WOEmailReceiver = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AllowableWeightVariancePercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.AllowableWeightVariancePercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AllowableWeightVariancePercentage = Nothing
					Else
						entity.AllowableWeightVariancePercentage = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DefaultVendorTestPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.DefaultVendorTestPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DefaultVendorTestPercentage = Nothing
					Else
						entity.DefaultVendorTestPercentage = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Setprodordestcompdate As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Setprodordestcompdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Setprodordestcompdate = Nothing
					Else
						entity.Setprodordestcompdate = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Additionaldefaultsendtoaddress As System.String 
				Get
					Dim data_ As System.String = entity.Additionaldefaultsendtoaddress
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Additionaldefaultsendtoaddress = Nothing
					Else
						entity.Additionaldefaultsendtoaddress = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxVolumeForNonRegDOT As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MaxVolumeForNonRegDOT
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxVolumeForNonRegDOT = Nothing
					Else
						entity.MaxVolumeForNonRegDOT = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property NonRegulatedDOTDesc As System.String 
				Get
					Dim data_ As System.String = entity.NonRegulatedDOTDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NonRegulatedDOTDesc = Nothing
					Else
						entity.NonRegulatedDOTDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esSysparameters
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esSysparametersQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esSysparameters can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Sysparameters 
		Inherits esSysparameters
		
	
		
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
	MustInherit Public Class esSysparametersQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return SysparametersMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property RecordID As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.RecordID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyName As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.CompanyName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyAddress As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.CompanyAddress, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyCity As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.CompanyCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyState As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.CompanyState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyZipcode As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.CompanyZipcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyCountry As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.CompanyCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyPhone As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.CompanyPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyFAX As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.CompanyFAX, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Defaultsalestaxrate As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.Defaultsalestaxrate, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdlaborhourcost As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.Stdlaborhourcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FreezeWarning As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.FreezeWarning, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property COAText As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.COAText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdoverheadhourcost As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.Stdoverheadhourcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PRODORDERMaxIdleTime As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.PRODORDERMaxIdleTime, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MaxLoadWeight As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.MaxLoadWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SecurityTimer As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.SecurityTimer, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Companyemaildomain As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.Companyemaildomain, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Companyemailserver As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.Companyemailserver, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WOEmailSender As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.WOEmailSender, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WOEmailReceiver As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.WOEmailReceiver, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AllowableWeightVariancePercentage As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.AllowableWeightVariancePercentage, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DefaultVendorTestPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.DefaultVendorTestPercentage, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Setprodordestcompdate As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.Setprodordestcompdate, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Additionaldefaultsendtoaddress As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.Additionaldefaultsendtoaddress, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MaxVolumeForNonRegDOT As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.MaxVolumeForNonRegDOT, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property NonRegulatedDOTDesc As esQueryItem
			Get
				Return New esQueryItem(Me, SysparametersMetadata.ColumnNames.NonRegulatedDOTDesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("SysparametersCollection")> _
	Partial Public Class SysparametersCollection
		Inherits esSysparametersCollection
		Implements IEnumerable(Of Sysparameters)
		
        Public Shared Widening Operator CType(ByVal coll As SysparametersCollection) As List(Of Sysparameters)
            Dim list As List(Of Sysparameters) = New List(Of Sysparameters)
            Dim emp As Sysparameters

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return SysparametersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New SysparametersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Sysparameters(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Sysparameters()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As SysparametersQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New SysparametersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As SysparametersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Sysparameters 
			Return CType(MyBase.AddNewEntity(), Sysparameters)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal recordID As System.Int32) As Sysparameters
			Return CType(MyBase.FindByPrimaryKey(recordID), Sysparameters)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Sysparameters) Implements IEnumerable(Of Sysparameters).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Sysparameters)(Me)
        End Function
		
		Private _query As SysparametersQuery

	End Class
	


	' <summary>
	' Encapsulates the 'SYSPARAMETERS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Sysparameters ({RecordID.Value})")> _
	<Serializable> _
	Partial Public Class Sysparameters 
		Inherits esSysparameters

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return SysparametersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esSysparametersQuery

			If Me._query Is Nothing Then
				Me._query = New SysparametersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As SysparametersQuery
			Get

				If Me._query Is Nothing then
					Me._query = New SysparametersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As SysparametersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As SysparametersQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class SysparametersQuery
		inherits esSysparametersQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "SysparametersQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class SysparametersMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.RecordID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SysparametersMetadata.PropertyNames.RecordID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.CompanyName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.CompanyName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.CompanyAddress, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.CompanyAddress
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.CompanyCity, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.CompanyCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.CompanyState, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.CompanyState
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.CompanyZipcode, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.CompanyZipcode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.CompanyCountry, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.CompanyCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.CompanyPhone, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.CompanyPhone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.CompanyFAX, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.CompanyFAX
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.Defaultsalestaxrate, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = SysparametersMetadata.PropertyNames.Defaultsalestaxrate
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.Stdlaborhourcost, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = SysparametersMetadata.PropertyNames.Stdlaborhourcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.FreezeWarning, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SysparametersMetadata.PropertyNames.FreezeWarning
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.COAText, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.COAText
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.Stdoverheadhourcost, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = SysparametersMetadata.PropertyNames.Stdoverheadhourcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.PRODORDERMaxIdleTime, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SysparametersMetadata.PropertyNames.PRODORDERMaxIdleTime
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.MaxLoadWeight, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SysparametersMetadata.PropertyNames.MaxLoadWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.SecurityTimer, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SysparametersMetadata.PropertyNames.SecurityTimer
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.Companyemaildomain, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.Companyemaildomain
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.Companyemailserver, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.Companyemailserver
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.WOEmailSender, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.WOEmailSender
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.WOEmailReceiver, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.WOEmailReceiver
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.AllowableWeightVariancePercentage, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SysparametersMetadata.PropertyNames.AllowableWeightVariancePercentage
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.DefaultVendorTestPercentage, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SysparametersMetadata.PropertyNames.DefaultVendorTestPercentage
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.Setprodordestcompdate, 23, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = SysparametersMetadata.PropertyNames.Setprodordestcompdate
			c.HasDefault = True
			c.Default = "((1))"
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.Additionaldefaultsendtoaddress, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.Additionaldefaultsendtoaddress
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.MaxVolumeForNonRegDOT, 25, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = SysparametersMetadata.PropertyNames.MaxVolumeForNonRegDOT
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SysparametersMetadata.ColumnNames.NonRegulatedDOTDesc, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysparametersMetadata.PropertyNames.NonRegulatedDOTDesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As SysparametersMetadata
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
			 Public Const RecordID As String = "RecordID"
			 Public Const CompanyName As String = "CompanyName"
			 Public Const CompanyAddress As String = "CompanyAddress"
			 Public Const CompanyCity As String = "CompanyCity"
			 Public Const CompanyState As String = "CompanyState"
			 Public Const CompanyZipcode As String = "CompanyZipcode"
			 Public Const CompanyCountry As String = "CompanyCountry"
			 Public Const CompanyPhone As String = "CompanyPhone"
			 Public Const CompanyFAX As String = "CompanyFAX"
			 Public Const Defaultsalestaxrate As String = "DEFAULTSALESTAXRATE"
			 Public Const Stdlaborhourcost As String = "STDLABORHOURCOST"
			 Public Const FreezeWarning As String = "FreezeWarning"
			 Public Const COAText As String = "COAText"
			 Public Const Stdoverheadhourcost As String = "STDOVERHEADHOURCOST"
			 Public Const PRODORDERMaxIdleTime As String = "PRODORDERMaxIdleTime"
			 Public Const MaxLoadWeight As String = "MaxLoadWeight"
			 Public Const SecurityTimer As String = "SecurityTimer"
			 Public Const Companyemaildomain As String = "COMPANYEMAILDOMAIN"
			 Public Const Companyemailserver As String = "COMPANYEMAILSERVER"
			 Public Const WOEmailSender As String = "WOEmailSender"
			 Public Const WOEmailReceiver As String = "WOEmailReceiver"
			 Public Const AllowableWeightVariancePercentage As String = "AllowableWeightVariancePercentage"
			 Public Const DefaultVendorTestPercentage As String = "DefaultVendorTestPercentage"
			 Public Const Setprodordestcompdate As String = "SETPRODORDESTCOMPDATE"
			 Public Const Additionaldefaultsendtoaddress As String = "ADDITIONALDEFAULTSENDTOADDRESS"
			 Public Const MaxVolumeForNonRegDOT As String = "MaxVolumeForNonRegDOT"
			 Public Const NonRegulatedDOTDesc As String = "NonRegulatedDOTDesc"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const RecordID As String = "RecordID"
			 Public Const CompanyName As String = "CompanyName"
			 Public Const CompanyAddress As String = "CompanyAddress"
			 Public Const CompanyCity As String = "CompanyCity"
			 Public Const CompanyState As String = "CompanyState"
			 Public Const CompanyZipcode As String = "CompanyZipcode"
			 Public Const CompanyCountry As String = "CompanyCountry"
			 Public Const CompanyPhone As String = "CompanyPhone"
			 Public Const CompanyFAX As String = "CompanyFAX"
			 Public Const Defaultsalestaxrate As String = "Defaultsalestaxrate"
			 Public Const Stdlaborhourcost As String = "Stdlaborhourcost"
			 Public Const FreezeWarning As String = "FreezeWarning"
			 Public Const COAText As String = "COAText"
			 Public Const Stdoverheadhourcost As String = "Stdoverheadhourcost"
			 Public Const PRODORDERMaxIdleTime As String = "PRODORDERMaxIdleTime"
			 Public Const MaxLoadWeight As String = "MaxLoadWeight"
			 Public Const SecurityTimer As String = "SecurityTimer"
			 Public Const Companyemaildomain As String = "Companyemaildomain"
			 Public Const Companyemailserver As String = "Companyemailserver"
			 Public Const WOEmailSender As String = "WOEmailSender"
			 Public Const WOEmailReceiver As String = "WOEmailReceiver"
			 Public Const AllowableWeightVariancePercentage As String = "AllowableWeightVariancePercentage"
			 Public Const DefaultVendorTestPercentage As String = "DefaultVendorTestPercentage"
			 Public Const Setprodordestcompdate As String = "Setprodordestcompdate"
			 Public Const Additionaldefaultsendtoaddress As String = "Additionaldefaultsendtoaddress"
			 Public Const MaxVolumeForNonRegDOT As String = "MaxVolumeForNonRegDOT"
			 Public Const NonRegulatedDOTDesc As String = "NonRegulatedDOTDesc"
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
            SyncLock GetType(SysparametersMetadata)
			
				If SysparametersMetadata.mapDelegates Is Nothing Then
					SysparametersMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If SysparametersMetadata._meta Is Nothing Then
                    SysparametersMetadata._meta = New SysparametersMetadata()
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
				

				meta.AddTypeMap("RecordID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CompanyName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyAddress", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyZipcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyCountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyFAX", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Defaultsalestaxrate", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Stdlaborhourcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("FreezeWarning", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("COAText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdoverheadhourcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PRODORDERMaxIdleTime", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MaxLoadWeight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SecurityTimer", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Companyemaildomain", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Companyemailserver", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WOEmailSender", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WOEmailReceiver", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AllowableWeightVariancePercentage", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DefaultVendorTestPercentage", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Setprodordestcompdate", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Additionaldefaultsendtoaddress", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MaxVolumeForNonRegDOT", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("NonRegulatedDOTDesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "SYSPARAMETERS"
				meta.Destination = "SYSPARAMETERS"
				
				meta.spInsert = "proc_SYSPARAMETERSInsert"
				meta.spUpdate = "proc_SYSPARAMETERSUpdate"
				meta.spDelete = "proc_SYSPARAMETERSDelete"
				meta.spLoadAll = "proc_SYSPARAMETERSLoadAll"
				meta.spLoadByPrimaryKey = "proc_SYSPARAMETERSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As SysparametersMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
