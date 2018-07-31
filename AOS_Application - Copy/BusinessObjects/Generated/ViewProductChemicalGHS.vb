'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/19/2016 1:46:38 PM
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
	MustInherit Public Class esViewProductChemicalGHSCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProductChemicalGHSCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProductChemicalGHSQuery)
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
            Me.InitQuery(CType(query, esViewProductChemicalGHSQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProductChemicalGHS) As ViewProductChemicalGHS
			Return CType(MyBase.DetachEntity(entity), ViewProductChemicalGHS)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProductChemicalGHS) As ViewProductChemicalGHS
			Return CType(MyBase.AttachEntity(entity), ViewProductChemicalGHS)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProductChemicalGHSCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProductChemicalGHS
            Get
                Return TryCast(MyBase.Item(index), ViewProductChemicalGHS)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProductChemicalGHS)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProductChemicalGHS	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProductChemicalGHSQuery
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
												
						Case "Chemicalname"
							Me.str.Chemicalname = CType(value, string)
												
						Case "Stdweight"
							Me.str.Stdweight = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
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
												
						Case "Placardrequired"
							Me.str.Placardrequired = CType(value, string)
												
						Case "Classrate"
							Me.str.Classrate = CType(value, string)
												
						Case "Hazmatid"
							Me.str.Hazmatid = CType(value, string)
												
						Case "Unnumber"
							Me.str.Unnumber = CType(value, string)
												
						Case "Hazclassnumber"
							Me.str.Hazclassnumber = CType(value, string)
												
						Case "Packagegroup"
							Me.str.Packagegroup = CType(value, string)
												
						Case "Chemicalid"
							Me.str.Chemicalid = CType(value, string)
												
						Case "Idnumber"
							Me.str.Idnumber = CType(value, string)
												
						Case "Istoxic"
							Me.str.Istoxic = CType(value, string)
												
						Case "Pictogram1"
							Me.str.Pictogram1 = CType(value, string)
												
						Case "Pictogram2"
							Me.str.Pictogram2 = CType(value, string)
												
						Case "Pictogram3"
							Me.str.Pictogram3 = CType(value, string)
												
						Case "Pictogram4"
							Me.str.Pictogram4 = CType(value, string)
												
						Case "Pictogram5"
							Me.str.Pictogram5 = CType(value, string)
												
						Case "Dangerword"
							Me.str.Dangerword = CType(value, string)
												
						Case "Ghsclassification"
							Me.str.Ghsclassification = CType(value, string)
												
						Case "Hazardstatements"
							Me.str.Hazardstatements = CType(value, string)
												
						Case "Safetyprecautions"
							Me.str.Safetyprecautions = CType(value, string)
												
						Case "Firstaidmeasures"
							Me.str.Firstaidmeasures = CType(value, string)
												
						Case "Storage"
							Me.str.Storage = CType(value, string)
												
						Case "Disposal"
							Me.str.Disposal = CType(value, string)
												
						Case "Acutetoxicitydermal"
							Me.str.Acutetoxicitydermal = CType(value, string)
												
						Case "Acutetoxicityinhalationgas"
							Me.str.Acutetoxicityinhalationgas = CType(value, string)
												
						Case "Acutetoxicityinhalationvapor"
							Me.str.Acutetoxicityinhalationvapor = CType(value, string)
												
						Case "Acutetoxicityinhalationdustmist"
							Me.str.Acutetoxicityinhalationdustmist = CType(value, string)
												
						Case "Acutetoxicityoral"
							Me.str.Acutetoxicityoral = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Firesupplemental"
							Me.str.Firesupplemental = CType(value, string)
												
						Case "Accidentsupplemental"
							Me.str.Accidentsupplemental = CType(value, string)
												
						Case "Rq"
							Me.str.Rq = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdweight = CType(value, Nullable(Of System.Int32))
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
						
						Case "Chemicalid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Istoxic"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Istoxic = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Pictogram1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pictogram1 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Pictogram2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pictogram2 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Pictogram3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pictogram3 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Pictogram4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pictogram4 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Pictogram5"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pictogram5 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rq"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Rq = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewProductChemicalGHS.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.CHEMICALNAME
		' </summary>
		Public Overridable Property Chemicalname As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Chemicalname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Chemicalname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.HEALTH
		' </summary>
		Public Overridable Property Health As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Health)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Health, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.FIRE
		' </summary>
		Public Overridable Property Fire As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Fire)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Fire, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.REACTIVITY
		' </summary>
		Public Overridable Property Reactivity As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Reactivity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Reactivity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PERSONALPROTECTION
		' </summary>
		Public Overridable Property Personalprotection As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Personalprotection)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Personalprotection, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PLACARDREQUIRED
		' </summary>
		Public Overridable Property Placardrequired As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Placardrequired)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Placardrequired, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.UNNUMBER
		' </summary>
		Public Overridable Property Unnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Unnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Unnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.HAZCLASSNUMBER
		' </summary>
		Public Overridable Property Hazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Hazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Hazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PACKAGEGROUP
		' </summary>
		Public Overridable Property Packagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Packagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Packagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.IDNUMBER
		' </summary>
		Public Overridable Property Idnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Idnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Idnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.ISTOXIC
		' </summary>
		Public Overridable Property Istoxic As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductChemicalGHSMetadata.ColumnNames.Istoxic)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductChemicalGHSMetadata.ColumnNames.Istoxic, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PICTOGRAM1
		' </summary>
		Public Overridable Property Pictogram1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PICTOGRAM2
		' </summary>
		Public Overridable Property Pictogram2 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PICTOGRAM3
		' </summary>
		Public Overridable Property Pictogram3 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PICTOGRAM4
		' </summary>
		Public Overridable Property Pictogram4 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PICTOGRAM5
		' </summary>
		Public Overridable Property Pictogram5 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram5)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram5, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.DANGERWORD
		' </summary>
		Public Overridable Property Dangerword As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Dangerword)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Dangerword, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.GHSCLASSIFICATION
		' </summary>
		Public Overridable Property Ghsclassification As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Ghsclassification)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Ghsclassification, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.HAZARDSTATEMENTS
		' </summary>
		Public Overridable Property Hazardstatements As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Hazardstatements)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Hazardstatements, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.SAFETYPRECAUTIONS
		' </summary>
		Public Overridable Property Safetyprecautions As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Safetyprecautions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Safetyprecautions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.FIRSTAIDMEASURES
		' </summary>
		Public Overridable Property Firstaidmeasures As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Firstaidmeasures)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Firstaidmeasures, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.STORAGE
		' </summary>
		Public Overridable Property Storage As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Storage)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Storage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.DISPOSAL
		' </summary>
		Public Overridable Property Disposal As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Disposal)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Disposal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.ACUTETOXICITYDERMAL
		' </summary>
		Public Overridable Property Acutetoxicitydermal As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicitydermal)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicitydermal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.ACUTETOXICITYINHALATIONGAS
		' </summary>
		Public Overridable Property Acutetoxicityinhalationgas As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationgas)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationgas, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.ACUTETOXICITYINHALATIONVAPOR
		' </summary>
		Public Overridable Property Acutetoxicityinhalationvapor As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationvapor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationvapor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.ACUTETOXICITYINHALATIONDUSTMIST
		' </summary>
		Public Overridable Property Acutetoxicityinhalationdustmist As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationdustmist)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationdustmist, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.ACUTETOXICITYORAL
		' </summary>
		Public Overridable Property Acutetoxicityoral As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityoral)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityoral, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.FIRESUPPLEMENTAL
		' </summary>
		Public Overridable Property Firesupplemental As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Firesupplemental)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Firesupplemental, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.ACCIDENTSUPPLEMENTAL
		' </summary>
		Public Overridable Property Accidentsupplemental As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Accidentsupplemental)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Accidentsupplemental, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.RQ
		' </summary>
		Public Overridable Property Rq As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductChemicalGHSMetadata.ColumnNames.Rq)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductChemicalGHSMetadata.ColumnNames.Rq, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHS.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSMetadata.ColumnNames.Productdesc, value)
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
		
			Public Sub New(ByVal entity As esViewProductChemicalGHS)
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
		  	
			Public Property Stdweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Stdweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdweight = Nothing
					Else
						entity.Stdweight = Convert.ToInt32(Value)
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
		  	
			Public Property Placardrequired As System.String 
				Get
					Dim data_ As System.String = entity.Placardrequired
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Placardrequired = Nothing
					Else
						entity.Placardrequired = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Classrate As System.String 
				Get
					Dim data_ As System.String = entity.Classrate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Classrate = Nothing
					Else
						entity.Classrate = Convert.ToString(Value)
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
		  	
			Public Property Pictogram1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pictogram1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pictogram1 = Nothing
					Else
						entity.Pictogram1 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pictogram2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pictogram2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pictogram2 = Nothing
					Else
						entity.Pictogram2 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pictogram3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pictogram3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pictogram3 = Nothing
					Else
						entity.Pictogram3 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pictogram4 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pictogram4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pictogram4 = Nothing
					Else
						entity.Pictogram4 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pictogram5 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pictogram5
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pictogram5 = Nothing
					Else
						entity.Pictogram5 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dangerword As System.String 
				Get
					Dim data_ As System.String = entity.Dangerword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dangerword = Nothing
					Else
						entity.Dangerword = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ghsclassification As System.String 
				Get
					Dim data_ As System.String = entity.Ghsclassification
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ghsclassification = Nothing
					Else
						entity.Ghsclassification = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazardstatements As System.String 
				Get
					Dim data_ As System.String = entity.Hazardstatements
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazardstatements = Nothing
					Else
						entity.Hazardstatements = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Safetyprecautions As System.String 
				Get
					Dim data_ As System.String = entity.Safetyprecautions
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Safetyprecautions = Nothing
					Else
						entity.Safetyprecautions = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Firstaidmeasures As System.String 
				Get
					Dim data_ As System.String = entity.Firstaidmeasures
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Firstaidmeasures = Nothing
					Else
						entity.Firstaidmeasures = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Storage As System.String 
				Get
					Dim data_ As System.String = entity.Storage
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Storage = Nothing
					Else
						entity.Storage = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Disposal As System.String 
				Get
					Dim data_ As System.String = entity.Disposal
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Disposal = Nothing
					Else
						entity.Disposal = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Acutetoxicitydermal As System.String 
				Get
					Dim data_ As System.String = entity.Acutetoxicitydermal
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Acutetoxicitydermal = Nothing
					Else
						entity.Acutetoxicitydermal = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Acutetoxicityinhalationgas As System.String 
				Get
					Dim data_ As System.String = entity.Acutetoxicityinhalationgas
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Acutetoxicityinhalationgas = Nothing
					Else
						entity.Acutetoxicityinhalationgas = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Acutetoxicityinhalationvapor As System.String 
				Get
					Dim data_ As System.String = entity.Acutetoxicityinhalationvapor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Acutetoxicityinhalationvapor = Nothing
					Else
						entity.Acutetoxicityinhalationvapor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Acutetoxicityinhalationdustmist As System.String 
				Get
					Dim data_ As System.String = entity.Acutetoxicityinhalationdustmist
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Acutetoxicityinhalationdustmist = Nothing
					Else
						entity.Acutetoxicityinhalationdustmist = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Acutetoxicityoral As System.String 
				Get
					Dim data_ As System.String = entity.Acutetoxicityoral
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Acutetoxicityoral = Nothing
					Else
						entity.Acutetoxicityoral = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Firesupplemental As System.String 
				Get
					Dim data_ As System.String = entity.Firesupplemental
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Firesupplemental = Nothing
					Else
						entity.Firesupplemental = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Accidentsupplemental As System.String 
				Get
					Dim data_ As System.String = entity.Accidentsupplemental
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Accidentsupplemental = Nothing
					Else
						entity.Accidentsupplemental = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rq As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Rq
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rq = Nothing
					Else
						entity.Rq = Convert.ToBoolean(Value)
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
		  

			Private entity As esViewProductChemicalGHS
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProductChemicalGHSQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProductChemicalGHS can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProductChemicalGHSQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductChemicalGHSMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Chemicalname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Health As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Health, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Fire, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reactivity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Reactivity, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Personalprotection As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Personalprotection, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardrequired As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Placardrequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Unnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Hazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Packagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Packagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Idnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Idnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Istoxic As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Istoxic, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Pictogram1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Pictogram2, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Pictogram3, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Pictogram4, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram5 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Pictogram5, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Dangerword As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Dangerword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ghsclassification As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Ghsclassification, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazardstatements As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Hazardstatements, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Safetyprecautions As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Safetyprecautions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Firstaidmeasures As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Firstaidmeasures, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Storage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Storage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Disposal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Disposal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicitydermal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicitydermal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationgas As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationgas, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationvapor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationvapor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationdustmist As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationdustmist, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityoral As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityoral, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Firesupplemental As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Firesupplemental, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Accidentsupplemental As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Accidentsupplemental, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rq As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Rq, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProductChemicalGHSCollection")> _
	Partial Public Class ViewProductChemicalGHSCollection
		Inherits esViewProductChemicalGHSCollection
		Implements IEnumerable(Of ViewProductChemicalGHS)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProductChemicalGHSCollection) As List(Of ViewProductChemicalGHS)
            Dim list As List(Of ViewProductChemicalGHS) = New List(Of ViewProductChemicalGHS)
            Dim emp As ViewProductChemicalGHS

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductChemicalGHSMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProductChemicalGHSQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProductChemicalGHS(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProductChemicalGHS()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProductChemicalGHSQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProductChemicalGHSQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductChemicalGHSQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProductChemicalGHS 
			Return CType(MyBase.AddNewEntity(), ViewProductChemicalGHS)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProductChemicalGHS) Implements IEnumerable(Of ViewProductChemicalGHS).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProductChemicalGHS)(Me)
        End Function
		
		Private _query As ViewProductChemicalGHSQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewProductChemicalGHS' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProductChemicalGHS ()")> _
	<Serializable> _
	Partial Public Class ViewProductChemicalGHS 
		Inherits esViewProductChemicalGHS

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProductChemicalGHSMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProductChemicalGHSQuery

			If Me._query Is Nothing Then
				Me._query = New ViewProductChemicalGHSQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProductChemicalGHSQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProductChemicalGHSQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductChemicalGHSQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProductChemicalGHSQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProductChemicalGHSQuery
		inherits esViewProductChemicalGHSQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProductChemicalGHSQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProductChemicalGHSMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Chemicalname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Chemicalname
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Stdweight, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Health, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Health
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Fire, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Fire
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Reactivity, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Reactivity
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Personalprotection, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Personalprotection
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Dotdesc, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Hazmatdesc, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Unline, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Placardrequired, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Placardrequired
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Classrate, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Hazmatid, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Unnumber, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Unnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Hazclassnumber, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Hazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Packagegroup, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Packagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Chemicalid, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Chemicalid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Idnumber, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Idnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Istoxic, 19, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Istoxic
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram1, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Pictogram1
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram2, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Pictogram2
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram3, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Pictogram3
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram4, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Pictogram4
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Pictogram5, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Pictogram5
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Dangerword, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Dangerword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Ghsclassification, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Ghsclassification
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Hazardstatements, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Hazardstatements
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Safetyprecautions, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Safetyprecautions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Firstaidmeasures, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Firstaidmeasures
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Storage, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Storage
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Disposal, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Disposal
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicitydermal, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Acutetoxicitydermal
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationgas, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Acutetoxicityinhalationgas
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationvapor, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Acutetoxicityinhalationvapor
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityinhalationdustmist, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Acutetoxicityinhalationdustmist
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Acutetoxicityoral, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Acutetoxicityoral
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Invitemnumber, 37, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Lotnumber, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Firesupplemental, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Firesupplemental
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Accidentsupplemental, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Accidentsupplemental
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Rq, 41, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Rq
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSMetadata.ColumnNames.Productdesc, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProductChemicalGHSMetadata
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
			 Public Const Chemicalname As String = "CHEMICALNAME"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Container As String = "CONTAINER"
			 Public Const Health As String = "HEALTH"
			 Public Const Fire As String = "FIRE"
			 Public Const Reactivity As String = "REACTIVITY"
			 Public Const Personalprotection As String = "PERSONALPROTECTION"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Unline As String = "UNLINE"
			 Public Const Placardrequired As String = "PLACARDREQUIRED"
			 Public Const Classrate As String = "CLASSRATE"
			 Public Const Hazmatid As String = "HAZMATID"
			 Public Const Unnumber As String = "UNNUMBER"
			 Public Const Hazclassnumber As String = "HAZCLASSNUMBER"
			 Public Const Packagegroup As String = "PACKAGEGROUP"
			 Public Const Chemicalid As String = "CHEMICALID"
			 Public Const Idnumber As String = "IDNUMBER"
			 Public Const Istoxic As String = "ISTOXIC"
			 Public Const Pictogram1 As String = "PICTOGRAM1"
			 Public Const Pictogram2 As String = "PICTOGRAM2"
			 Public Const Pictogram3 As String = "PICTOGRAM3"
			 Public Const Pictogram4 As String = "PICTOGRAM4"
			 Public Const Pictogram5 As String = "PICTOGRAM5"
			 Public Const Dangerword As String = "DANGERWORD"
			 Public Const Ghsclassification As String = "GHSCLASSIFICATION"
			 Public Const Hazardstatements As String = "HAZARDSTATEMENTS"
			 Public Const Safetyprecautions As String = "SAFETYPRECAUTIONS"
			 Public Const Firstaidmeasures As String = "FIRSTAIDMEASURES"
			 Public Const Storage As String = "STORAGE"
			 Public Const Disposal As String = "DISPOSAL"
			 Public Const Acutetoxicitydermal As String = "ACUTETOXICITYDERMAL"
			 Public Const Acutetoxicityinhalationgas As String = "ACUTETOXICITYINHALATIONGAS"
			 Public Const Acutetoxicityinhalationvapor As String = "ACUTETOXICITYINHALATIONVAPOR"
			 Public Const Acutetoxicityinhalationdustmist As String = "ACUTETOXICITYINHALATIONDUSTMIST"
			 Public Const Acutetoxicityoral As String = "ACUTETOXICITYORAL"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Firesupplemental As String = "FIRESUPPLEMENTAL"
			 Public Const Accidentsupplemental As String = "ACCIDENTSUPPLEMENTAL"
			 Public Const Rq As String = "RQ"
			 Public Const Productdesc As String = "PRODUCTDESC"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Chemicalname As String = "Chemicalname"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Container As String = "Container"
			 Public Const Health As String = "Health"
			 Public Const Fire As String = "Fire"
			 Public Const Reactivity As String = "Reactivity"
			 Public Const Personalprotection As String = "Personalprotection"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Unline As String = "Unline"
			 Public Const Placardrequired As String = "Placardrequired"
			 Public Const Classrate As String = "Classrate"
			 Public Const Hazmatid As String = "Hazmatid"
			 Public Const Unnumber As String = "Unnumber"
			 Public Const Hazclassnumber As String = "Hazclassnumber"
			 Public Const Packagegroup As String = "Packagegroup"
			 Public Const Chemicalid As String = "Chemicalid"
			 Public Const Idnumber As String = "Idnumber"
			 Public Const Istoxic As String = "Istoxic"
			 Public Const Pictogram1 As String = "Pictogram1"
			 Public Const Pictogram2 As String = "Pictogram2"
			 Public Const Pictogram3 As String = "Pictogram3"
			 Public Const Pictogram4 As String = "Pictogram4"
			 Public Const Pictogram5 As String = "Pictogram5"
			 Public Const Dangerword As String = "Dangerword"
			 Public Const Ghsclassification As String = "Ghsclassification"
			 Public Const Hazardstatements As String = "Hazardstatements"
			 Public Const Safetyprecautions As String = "Safetyprecautions"
			 Public Const Firstaidmeasures As String = "Firstaidmeasures"
			 Public Const Storage As String = "Storage"
			 Public Const Disposal As String = "Disposal"
			 Public Const Acutetoxicitydermal As String = "Acutetoxicitydermal"
			 Public Const Acutetoxicityinhalationgas As String = "Acutetoxicityinhalationgas"
			 Public Const Acutetoxicityinhalationvapor As String = "Acutetoxicityinhalationvapor"
			 Public Const Acutetoxicityinhalationdustmist As String = "Acutetoxicityinhalationdustmist"
			 Public Const Acutetoxicityoral As String = "Acutetoxicityoral"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Firesupplemental As String = "Firesupplemental"
			 Public Const Accidentsupplemental As String = "Accidentsupplemental"
			 Public Const Rq As String = "Rq"
			 Public Const Productdesc As String = "Productdesc"
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
            SyncLock GetType(ViewProductChemicalGHSMetadata)
			
				If ViewProductChemicalGHSMetadata.mapDelegates Is Nothing Then
					ViewProductChemicalGHSMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProductChemicalGHSMetadata._meta Is Nothing Then
                    ViewProductChemicalGHSMetadata._meta = New ViewProductChemicalGHSMetadata()
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
				meta.AddTypeMap("Chemicalname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Health", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Reactivity", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Personalprotection", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Placardrequired", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Classrate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Hazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Packagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Idnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Istoxic", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Pictogram1", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pictogram2", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pictogram3", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pictogram4", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pictogram5", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Dangerword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ghsclassification", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazardstatements", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Safetyprecautions", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Firstaidmeasures", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Storage", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Disposal", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Acutetoxicitydermal", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Acutetoxicityinhalationgas", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Acutetoxicityinhalationvapor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Acutetoxicityinhalationdustmist", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Acutetoxicityoral", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Firesupplemental", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Accidentsupplemental", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rq", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewProductChemicalGHS"
				meta.Destination = "viewProductChemicalGHS"
				
				meta.spInsert = "proc_viewProductChemicalGHSInsert"
				meta.spUpdate = "proc_viewProductChemicalGHSUpdate"
				meta.spDelete = "proc_viewProductChemicalGHSDelete"
				meta.spLoadAll = "proc_viewProductChemicalGHSLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProductChemicalGHSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProductChemicalGHSMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
