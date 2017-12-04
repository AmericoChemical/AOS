'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/1/2017 3:00:53 PM
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
	MustInherit Public Class esChemicalCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ChemicalCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esChemicalQuery)
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
            Me.InitQuery(CType(query, esChemicalQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Chemical) As Chemical
			Return CType(MyBase.DetachEntity(entity), Chemical)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Chemical) As Chemical
			Return CType(MyBase.AttachEntity(entity), Chemical)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ChemicalCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Chemical
            Get
                Return TryCast(MyBase.Item(index), Chemical)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Chemical)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esChemical	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esChemicalQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal chemicalid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(chemicalid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(chemicalid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal chemicalid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(chemicalid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(chemicalid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal chemicalid As System.Int32) As Boolean
		
			Dim query As esChemicalQuery = Me.GetDynamicQuery()
			query.Where(query.Chemicalid.Equal(chemicalid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal chemicalid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("CHEMICALID", chemicalid)
			
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
												
						Case "Chemicalid"
							Me.str.Chemicalid = CType(value, string)
												
						Case "Chemicalname"
							Me.str.Chemicalname = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Modifiedtime"
							Me.str.Modifiedtime = CType(value, string)
												
						Case "Modifiedby"
							Me.str.Modifiedby = CType(value, string)
												
						Case "Chemicalstatus"
							Me.str.Chemicalstatus = CType(value, string)
												
						Case "Containerlabeltype"
							Me.str.Containerlabeltype = CType(value, string)
												
						Case "Sdsfilepath"
							Me.str.Sdsfilepath = CType(value, string)
												
						Case "PHLOW"
							Me.str.PHLOW = CType(value, string)
												
						Case "PHHIGH"
							Me.str.PHHIGH = CType(value, string)
												
						Case "SgLow"
							Me.str.SgLow = CType(value, string)
												
						Case "SgHigh"
							Me.str.SgHigh = CType(value, string)
												
						Case "Density"
							Me.str.Density = CType(value, string)
												
						Case "Chemicalcolor"
							Me.str.Chemicalcolor = CType(value, string)
												
						Case "Chemicalclarity"
							Me.str.Chemicalclarity = CType(value, string)
												
						Case "Chemicalstate"
							Me.str.Chemicalstate = CType(value, string)
												
						Case "Chemicalodor"
							Me.str.Chemicalodor = CType(value, string)
												
						Case "Datetoreview"
							Me.str.Datetoreview = CType(value, string)
												
						Case "Dateapproved"
							Me.str.Dateapproved = CType(value, string)
												
						Case "Dateinvoiced"
							Me.str.Dateinvoiced = CType(value, string)
												
						Case "Health"
							Me.str.Health = CType(value, string)
												
						Case "Fire"
							Me.str.Fire = CType(value, string)
												
						Case "Reactivity"
							Me.str.Reactivity = CType(value, string)
												
						Case "Personalprotection"
							Me.str.Personalprotection = CType(value, string)
												
						Case "Dotdesc"
							Me.str.Dotdesc = CType(value, string)
												
						Case "Hazmatdesc"
							Me.str.Hazmatdesc = CType(value, string)
												
						Case "Unline"
							Me.str.Unline = CType(value, string)
												
						Case "Hazmatid"
							Me.str.Hazmatid = CType(value, string)
												
						Case "Unnumber"
							Me.str.Unnumber = CType(value, string)
												
						Case "Hazclassnumber"
							Me.str.Hazclassnumber = CType(value, string)
												
						Case "Packagegroup"
							Me.str.Packagegroup = CType(value, string)
												
						Case "Idnumber"
							Me.str.Idnumber = CType(value, string)
												
						Case "Istoxic"
							Me.str.Istoxic = CType(value, string)
												
						Case "Sampleonly"
							Me.str.Sampleonly = CType(value, string)
												
						Case "Usenonregdot"
							Me.str.Usenonregdot = CType(value, string)
												
						Case "Isautolabel"
							Me.str.Isautolabel = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Chemicalid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifiedtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifiedtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "PHLOW"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PHLOW = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "PHHIGH"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PHHIGH = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "SgLow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.SgLow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "SgHigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.SgHigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Density"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Density = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Datetoreview"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Datetoreview = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Dateapproved"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateapproved = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Dateinvoiced"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateinvoiced = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Health"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Health = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Fire"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Reactivity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Reactivity = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Hazmatid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Hazmatid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Unnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Istoxic"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Istoxic = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Sampleonly"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Sampleonly = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Usenonregdot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Usenonregdot = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Isautolabel"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isautolabel = CType(value, Nullable(Of System.Boolean))
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
		' Maps to CHEMICAL.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalMetadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalMetadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CHEMICALNAME
		' </summary>
		Public Overridable Property Chemicalname As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Chemicalname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Chemicalname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ChemicalMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ChemicalMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.MODIFIEDTIME
		' </summary>
		Public Overridable Property Modifiedtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ChemicalMetadata.ColumnNames.Modifiedtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ChemicalMetadata.ColumnNames.Modifiedtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.MODIFIEDBY
		' </summary>
		Public Overridable Property Modifiedby As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Modifiedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Modifiedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CHEMICALSTATUS
		' </summary>
		Public Overridable Property Chemicalstatus As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Chemicalstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Chemicalstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CONTAINERLABELTYPE
		' </summary>
		Public Overridable Property Containerlabeltype As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Containerlabeltype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Containerlabeltype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.SDSFILEPATH
		' </summary>
		Public Overridable Property Sdsfilepath As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Sdsfilepath)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Sdsfilepath, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.pH_LOW
		' </summary>
		Public Overridable Property PHLOW As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ChemicalMetadata.ColumnNames.PHLOW)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ChemicalMetadata.ColumnNames.PHLOW, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.pH_HIGH
		' </summary>
		Public Overridable Property PHHIGH As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ChemicalMetadata.ColumnNames.PHHIGH)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ChemicalMetadata.ColumnNames.PHHIGH, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.SG_LOW
		' </summary>
		Public Overridable Property SgLow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ChemicalMetadata.ColumnNames.SgLow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ChemicalMetadata.ColumnNames.SgLow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.SG_HIGH
		' </summary>
		Public Overridable Property SgHigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ChemicalMetadata.ColumnNames.SgHigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ChemicalMetadata.ColumnNames.SgHigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.DENSITY
		' </summary>
		Public Overridable Property Density As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ChemicalMetadata.ColumnNames.Density)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ChemicalMetadata.ColumnNames.Density, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CHEMICALCOLOR
		' </summary>
		Public Overridable Property Chemicalcolor As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Chemicalcolor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Chemicalcolor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CHEMICALCLARITY
		' </summary>
		Public Overridable Property Chemicalclarity As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Chemicalclarity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Chemicalclarity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CHEMICALSTATE
		' </summary>
		Public Overridable Property Chemicalstate As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Chemicalstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Chemicalstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.CHEMICALODOR
		' </summary>
		Public Overridable Property Chemicalodor As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Chemicalodor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Chemicalodor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.DATETOREVIEW
		' </summary>
		Public Overridable Property Datetoreview As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ChemicalMetadata.ColumnNames.Datetoreview)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ChemicalMetadata.ColumnNames.Datetoreview, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.DATEAPPROVED
		' </summary>
		Public Overridable Property Dateapproved As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ChemicalMetadata.ColumnNames.Dateapproved)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ChemicalMetadata.ColumnNames.Dateapproved, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.DATEINVOICED
		' </summary>
		Public Overridable Property Dateinvoiced As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ChemicalMetadata.ColumnNames.Dateinvoiced)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ChemicalMetadata.ColumnNames.Dateinvoiced, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.HEALTH
		' </summary>
		Public Overridable Property Health As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalMetadata.ColumnNames.Health)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalMetadata.ColumnNames.Health, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.FIRE
		' </summary>
		Public Overridable Property Fire As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalMetadata.ColumnNames.Fire)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalMetadata.ColumnNames.Fire, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.REACTIVITY
		' </summary>
		Public Overridable Property Reactivity As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalMetadata.ColumnNames.Reactivity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalMetadata.ColumnNames.Reactivity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.PERSONALPROTECTION
		' </summary>
		Public Overridable Property Personalprotection As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Personalprotection)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Personalprotection, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalMetadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalMetadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.UNNUMBER
		' </summary>
		Public Overridable Property Unnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalMetadata.ColumnNames.Unnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalMetadata.ColumnNames.Unnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.HAZCLASSNUMBER
		' </summary>
		Public Overridable Property Hazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Hazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Hazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.PACKAGEGROUP
		' </summary>
		Public Overridable Property Packagegroup As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Packagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Packagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.IDNUMBER
		' </summary>
		Public Overridable Property Idnumber As System.String
			Get
				Return MyBase.GetSystemString(ChemicalMetadata.ColumnNames.Idnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalMetadata.ColumnNames.Idnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.ISTOXIC
		' </summary>
		Public Overridable Property Istoxic As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ChemicalMetadata.ColumnNames.Istoxic)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ChemicalMetadata.ColumnNames.Istoxic, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.SAMPLEONLY
		' </summary>
		Public Overridable Property Sampleonly As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ChemicalMetadata.ColumnNames.Sampleonly)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ChemicalMetadata.ColumnNames.Sampleonly, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.USENONREGDOT
		' </summary>
		Public Overridable Property Usenonregdot As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ChemicalMetadata.ColumnNames.Usenonregdot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ChemicalMetadata.ColumnNames.Usenonregdot, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICAL.ISAUTOLABEL
		' </summary>
		Public Overridable Property Isautolabel As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ChemicalMetadata.ColumnNames.Isautolabel)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ChemicalMetadata.ColumnNames.Isautolabel, value)
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
		
			Public Sub New(ByVal entity As esChemical)
				Me.entity = entity
			End Sub				
		
	
			Public Property Chemicalid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Chemicalid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalid = Nothing
					Else
						entity.Chemicalid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalname As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalname = Nothing
					Else
						entity.Chemicalname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifiedtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifiedtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifiedtime = Nothing
					Else
						entity.Modifiedtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifiedby As System.String 
				Get
					Dim data_ As System.String = entity.Modifiedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifiedby = Nothing
					Else
						entity.Modifiedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalstatus As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalstatus = Nothing
					Else
						entity.Chemicalstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Containerlabeltype As System.String 
				Get
					Dim data_ As System.String = entity.Containerlabeltype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Containerlabeltype = Nothing
					Else
						entity.Containerlabeltype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sdsfilepath As System.String 
				Get
					Dim data_ As System.String = entity.Sdsfilepath
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sdsfilepath = Nothing
					Else
						entity.Sdsfilepath = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PHLOW As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PHLOW
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PHLOW = Nothing
					Else
						entity.PHLOW = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PHHIGH As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PHHIGH
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PHHIGH = Nothing
					Else
						entity.PHHIGH = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property SgLow As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.SgLow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SgLow = Nothing
					Else
						entity.SgLow = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property SgHigh As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.SgHigh
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SgHigh = Nothing
					Else
						entity.SgHigh = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Density As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Density
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Density = Nothing
					Else
						entity.Density = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalcolor As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalcolor = Nothing
					Else
						entity.Chemicalcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalclarity As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalclarity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalclarity = Nothing
					Else
						entity.Chemicalclarity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalstate As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalstate = Nothing
					Else
						entity.Chemicalstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalodor As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalodor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalodor = Nothing
					Else
						entity.Chemicalodor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datetoreview As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Datetoreview
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datetoreview = Nothing
					Else
						entity.Datetoreview = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateapproved As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateapproved
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateapproved = Nothing
					Else
						entity.Dateapproved = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateinvoiced As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateinvoiced
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateinvoiced = Nothing
					Else
						entity.Dateinvoiced = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Health As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Health
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Health = Nothing
					Else
						entity.Health = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire = Nothing
					Else
						entity.Fire = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reactivity As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Reactivity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reactivity = Nothing
					Else
						entity.Reactivity = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Personalprotection As System.String 
				Get
					Dim data_ As System.String = entity.Personalprotection
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Personalprotection = Nothing
					Else
						entity.Personalprotection = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dotdesc As System.String 
				Get
					Dim data_ As System.String = entity.Dotdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dotdesc = Nothing
					Else
						entity.Dotdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazmatdesc As System.String 
				Get
					Dim data_ As System.String = entity.Hazmatdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatdesc = Nothing
					Else
						entity.Hazmatdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unline As System.String 
				Get
					Dim data_ As System.String = entity.Unline
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unline = Nothing
					Else
						entity.Unline = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazmatid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Hazmatid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatid = Nothing
					Else
						entity.Hazmatid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Unnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unnumber = Nothing
					Else
						entity.Unnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazclassnumber As System.String 
				Get
					Dim data_ As System.String = entity.Hazclassnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazclassnumber = Nothing
					Else
						entity.Hazclassnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Packagegroup As System.String 
				Get
					Dim data_ As System.String = entity.Packagegroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Packagegroup = Nothing
					Else
						entity.Packagegroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Idnumber As System.String 
				Get
					Dim data_ As System.String = entity.Idnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Idnumber = Nothing
					Else
						entity.Idnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Istoxic As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Istoxic
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Istoxic = Nothing
					Else
						entity.Istoxic = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sampleonly As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Sampleonly
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sampleonly = Nothing
					Else
						entity.Sampleonly = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Usenonregdot As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Usenonregdot
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Usenonregdot = Nothing
					Else
						entity.Usenonregdot = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isautolabel As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isautolabel
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isautolabel = Nothing
					Else
						entity.Isautolabel = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esChemical
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esChemicalQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esChemical can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Chemical 
		Inherits esChemical
		
	
		
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
	MustInherit Public Class esChemicalQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ChemicalMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalname As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Chemicalname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedtime As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Modifiedtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedby As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Modifiedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Chemicalstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Containerlabeltype As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Containerlabeltype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sdsfilepath As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Sdsfilepath, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PHLOW As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.PHLOW, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PHHIGH As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.PHHIGH, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SgLow As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.SgLow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SgHigh As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.SgHigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Density As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Density, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Chemicalcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalclarity As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Chemicalclarity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalstate As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Chemicalstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalodor As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Chemicalodor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datetoreview As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Datetoreview, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateapproved As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Dateapproved, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateinvoiced As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Dateinvoiced, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Health As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Health, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Fire, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reactivity As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Reactivity, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Personalprotection As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Personalprotection, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Unnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Hazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Packagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Packagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Idnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Idnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Istoxic As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Istoxic, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Sampleonly As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Sampleonly, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Usenonregdot As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Usenonregdot, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Isautolabel As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalMetadata.ColumnNames.Isautolabel, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ChemicalCollection")> _
	Partial Public Class ChemicalCollection
		Inherits esChemicalCollection
		Implements IEnumerable(Of Chemical)
		
        Public Shared Widening Operator CType(ByVal coll As ChemicalCollection) As List(Of Chemical)
            Dim list As List(Of Chemical) = New List(Of Chemical)
            Dim emp As Chemical

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ChemicalMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ChemicalQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Chemical(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Chemical()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ChemicalQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ChemicalQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ChemicalQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Chemical 
			Return CType(MyBase.AddNewEntity(), Chemical)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal chemicalid As System.Int32) As Chemical
			Return CType(MyBase.FindByPrimaryKey(chemicalid), Chemical)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Chemical) Implements IEnumerable(Of Chemical).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Chemical)(Me)
        End Function
		
		Private _query As ChemicalQuery

	End Class
	


	' <summary>
	' Encapsulates the 'CHEMICAL' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Chemical ({Chemicalid.Value})")> _
	<Serializable> _
	Partial Public Class Chemical 
		Inherits esChemical

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ChemicalMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esChemicalQuery

			If Me._query Is Nothing Then
				Me._query = New ChemicalQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ChemicalQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ChemicalQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ChemicalQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ChemicalQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ChemicalQuery
		inherits esChemicalQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ChemicalQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ChemicalMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Chemicalid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Chemicalid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Chemicalname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Chemicalname
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Createdtime, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Createdby, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Modifiedtime, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Modifiedtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Modifiedby, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Modifiedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Chemicalstatus, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Chemicalstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Containerlabeltype, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Containerlabeltype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Sdsfilepath, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Sdsfilepath
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.PHLOW, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ChemicalMetadata.PropertyNames.PHLOW
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.PHHIGH, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ChemicalMetadata.PropertyNames.PHHIGH
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.SgLow, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ChemicalMetadata.PropertyNames.SgLow
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.SgHigh, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ChemicalMetadata.PropertyNames.SgHigh
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Density, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Density
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Chemicalcolor, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Chemicalcolor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Chemicalclarity, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Chemicalclarity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Chemicalstate, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Chemicalstate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Chemicalodor, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Chemicalodor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Datetoreview, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Datetoreview
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Dateapproved, 19, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Dateapproved
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Dateinvoiced, 20, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Dateinvoiced
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Health, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Health
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Fire, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Fire
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Reactivity, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Reactivity
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Personalprotection, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Personalprotection
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Dotdesc, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Hazmatdesc, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Unline, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Hazmatid, 28, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Unnumber, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Unnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Hazclassnumber, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Hazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Packagegroup, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Packagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Idnumber, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Idnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Istoxic, 33, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Istoxic
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Sampleonly, 34, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Sampleonly
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Usenonregdot, 35, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Usenonregdot
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalMetadata.ColumnNames.Isautolabel, 36, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ChemicalMetadata.PropertyNames.Isautolabel
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ChemicalMetadata
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
			 Public Const Chemicalid As String = "CHEMICALID"
			 Public Const Chemicalname As String = "CHEMICALNAME"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Modifiedtime As String = "MODIFIEDTIME"
			 Public Const Modifiedby As String = "MODIFIEDBY"
			 Public Const Chemicalstatus As String = "CHEMICALSTATUS"
			 Public Const Containerlabeltype As String = "CONTAINERLABELTYPE"
			 Public Const Sdsfilepath As String = "SDSFILEPATH"
			 Public Const PHLOW As String = "pH_LOW"
			 Public Const PHHIGH As String = "pH_HIGH"
			 Public Const SgLow As String = "SG_LOW"
			 Public Const SgHigh As String = "SG_HIGH"
			 Public Const Density As String = "DENSITY"
			 Public Const Chemicalcolor As String = "CHEMICALCOLOR"
			 Public Const Chemicalclarity As String = "CHEMICALCLARITY"
			 Public Const Chemicalstate As String = "CHEMICALSTATE"
			 Public Const Chemicalodor As String = "CHEMICALODOR"
			 Public Const Datetoreview As String = "DATETOREVIEW"
			 Public Const Dateapproved As String = "DATEAPPROVED"
			 Public Const Dateinvoiced As String = "DATEINVOICED"
			 Public Const Health As String = "HEALTH"
			 Public Const Fire As String = "FIRE"
			 Public Const Reactivity As String = "REACTIVITY"
			 Public Const Personalprotection As String = "PERSONALPROTECTION"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Unline As String = "UNLINE"
			 Public Const Hazmatid As String = "HAZMATID"
			 Public Const Unnumber As String = "UNNUMBER"
			 Public Const Hazclassnumber As String = "HAZCLASSNUMBER"
			 Public Const Packagegroup As String = "PACKAGEGROUP"
			 Public Const Idnumber As String = "IDNUMBER"
			 Public Const Istoxic As String = "ISTOXIC"
			 Public Const Sampleonly As String = "SAMPLEONLY"
			 Public Const Usenonregdot As String = "USENONREGDOT"
			 Public Const Isautolabel As String = "ISAUTOLABEL"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Chemicalid As String = "Chemicalid"
			 Public Const Chemicalname As String = "Chemicalname"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Createdby As String = "Createdby"
			 Public Const Modifiedtime As String = "Modifiedtime"
			 Public Const Modifiedby As String = "Modifiedby"
			 Public Const Chemicalstatus As String = "Chemicalstatus"
			 Public Const Containerlabeltype As String = "Containerlabeltype"
			 Public Const Sdsfilepath As String = "Sdsfilepath"
			 Public Const PHLOW As String = "PHLOW"
			 Public Const PHHIGH As String = "PHHIGH"
			 Public Const SgLow As String = "SgLow"
			 Public Const SgHigh As String = "SgHigh"
			 Public Const Density As String = "Density"
			 Public Const Chemicalcolor As String = "Chemicalcolor"
			 Public Const Chemicalclarity As String = "Chemicalclarity"
			 Public Const Chemicalstate As String = "Chemicalstate"
			 Public Const Chemicalodor As String = "Chemicalodor"
			 Public Const Datetoreview As String = "Datetoreview"
			 Public Const Dateapproved As String = "Dateapproved"
			 Public Const Dateinvoiced As String = "Dateinvoiced"
			 Public Const Health As String = "Health"
			 Public Const Fire As String = "Fire"
			 Public Const Reactivity As String = "Reactivity"
			 Public Const Personalprotection As String = "Personalprotection"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Unline As String = "Unline"
			 Public Const Hazmatid As String = "Hazmatid"
			 Public Const Unnumber As String = "Unnumber"
			 Public Const Hazclassnumber As String = "Hazclassnumber"
			 Public Const Packagegroup As String = "Packagegroup"
			 Public Const Idnumber As String = "Idnumber"
			 Public Const Istoxic As String = "Istoxic"
			 Public Const Sampleonly As String = "Sampleonly"
			 Public Const Usenonregdot As String = "Usenonregdot"
			 Public Const Isautolabel As String = "Isautolabel"
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
            SyncLock GetType(ChemicalMetadata)
			
				If ChemicalMetadata.mapDelegates Is Nothing Then
					ChemicalMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ChemicalMetadata._meta Is Nothing Then
                    ChemicalMetadata._meta = New ChemicalMetadata()
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
				

				meta.AddTypeMap("Chemicalid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifiedtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifiedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Containerlabeltype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sdsfilepath", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PHLOW", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PHHIGH", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("SgLow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("SgHigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Density", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Chemicalcolor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalclarity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalodor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datetoreview", new esTypeMap("date", "System.DateTime"))
				meta.AddTypeMap("Dateapproved", new esTypeMap("date", "System.DateTime"))
				meta.AddTypeMap("Dateinvoiced", new esTypeMap("date", "System.DateTime"))
				meta.AddTypeMap("Health", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Reactivity", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Personalprotection", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Hazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Packagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Idnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Istoxic", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Sampleonly", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Usenonregdot", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Isautolabel", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "CHEMICAL"
				meta.Destination = "CHEMICAL"
				
				meta.spInsert = "proc_CHEMICALInsert"
				meta.spUpdate = "proc_CHEMICALUpdate"
				meta.spDelete = "proc_CHEMICALDelete"
				meta.spLoadAll = "proc_CHEMICALLoadAll"
				meta.spLoadByPrimaryKey = "proc_CHEMICALLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ChemicalMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
