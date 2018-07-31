'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/12/2015 7:35:36 AM
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
	MustInherit Public Class esGhsmanualspecsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "GhsmanualspecsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esGhsmanualspecsQuery)
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
            Me.InitQuery(CType(query, esGhsmanualspecsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Ghsmanualspecs) As Ghsmanualspecs
			Return CType(MyBase.DetachEntity(entity), Ghsmanualspecs)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Ghsmanualspecs) As Ghsmanualspecs
			Return CType(MyBase.AttachEntity(entity), Ghsmanualspecs)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As GhsmanualspecsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Ghsmanualspecs
            Get
                Return TryCast(MyBase.Item(index), Ghsmanualspecs)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Ghsmanualspecs)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esGhsmanualspecs	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esGhsmanualspecsQuery
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
		
			Dim query As esGhsmanualspecsQuery = Me.GetDynamicQuery()
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
												
						Case "Firesupplemental"
							Me.str.Firesupplemental = CType(value, string)
												
						Case "Accidentsupplemental"
							Me.str.Accidentsupplemental = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Chemicalid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid = CType(value, Nullable(Of System.Int32))
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
		' Maps to GHSMANUALSPECS.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.PICTOGRAM1
		' </summary>
		Public Overridable Property Pictogram1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.PICTOGRAM2
		' </summary>
		Public Overridable Property Pictogram2 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.PICTOGRAM3
		' </summary>
		Public Overridable Property Pictogram3 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.PICTOGRAM4
		' </summary>
		Public Overridable Property Pictogram4 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.PICTOGRAM5
		' </summary>
		Public Overridable Property Pictogram5 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram5)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(GhsmanualspecsMetadata.ColumnNames.Pictogram5, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.DANGERWORD
		' </summary>
		Public Overridable Property Dangerword As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Dangerword)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Dangerword, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.GHSCLASSIFICATION
		' </summary>
		Public Overridable Property Ghsclassification As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Ghsclassification)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Ghsclassification, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.HAZARDSTATEMENTS
		' </summary>
		Public Overridable Property Hazardstatements As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Hazardstatements)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Hazardstatements, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.SAFETYPRECAUTIONS
		' </summary>
		Public Overridable Property Safetyprecautions As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Safetyprecautions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Safetyprecautions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.FIRSTAIDMEASURES
		' </summary>
		Public Overridable Property Firstaidmeasures As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Firstaidmeasures)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Firstaidmeasures, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.STORAGE
		' </summary>
		Public Overridable Property Storage As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Storage)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Storage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.DISPOSAL
		' </summary>
		Public Overridable Property Disposal As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Disposal)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Disposal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.ACUTETOXICITYDERMAL
		' </summary>
		Public Overridable Property Acutetoxicitydermal As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicitydermal)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicitydermal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.ACUTETOXICITYINHALATIONGAS
		' </summary>
		Public Overridable Property Acutetoxicityinhalationgas As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationgas)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationgas, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.ACUTETOXICITYINHALATIONVAPOR
		' </summary>
		Public Overridable Property Acutetoxicityinhalationvapor As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationvapor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationvapor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.ACUTETOXICITYINHALATIONDUSTMIST
		' </summary>
		Public Overridable Property Acutetoxicityinhalationdustmist As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationdustmist)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationdustmist, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.ACUTETOXICITYORAL
		' </summary>
		Public Overridable Property Acutetoxicityoral As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityoral)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityoral, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.FIRESUPPLEMENTAL
		' </summary>
		Public Overridable Property Firesupplemental As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Firesupplemental)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Firesupplemental, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to GHSMANUALSPECS.ACCIDENTSUPPLEMENTAL
		' </summary>
		Public Overridable Property Accidentsupplemental As System.String
			Get
				Return MyBase.GetSystemString(GhsmanualspecsMetadata.ColumnNames.Accidentsupplemental)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(GhsmanualspecsMetadata.ColumnNames.Accidentsupplemental, value)
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
		
			Public Sub New(ByVal entity As esGhsmanualspecs)
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
		  

			Private entity As esGhsmanualspecs
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esGhsmanualspecsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esGhsmanualspecs can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Ghsmanualspecs 
		Inherits esGhsmanualspecs
		
	
		
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
	MustInherit Public Class esGhsmanualspecsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GhsmanualspecsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram1 As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Pictogram1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram2 As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Pictogram2, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram3 As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Pictogram3, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram4 As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Pictogram4, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram5 As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Pictogram5, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Dangerword As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Dangerword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ghsclassification As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Ghsclassification, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazardstatements As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Hazardstatements, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Safetyprecautions As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Safetyprecautions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Firstaidmeasures As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Firstaidmeasures, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Storage As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Storage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Disposal As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Disposal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicitydermal As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Acutetoxicitydermal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationgas As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationgas, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationvapor As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationvapor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationdustmist As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationdustmist, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityoral As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Acutetoxicityoral, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Firesupplemental As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Firesupplemental, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Accidentsupplemental As esQueryItem
			Get
				Return New esQueryItem(Me, GhsmanualspecsMetadata.ColumnNames.Accidentsupplemental, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("GhsmanualspecsCollection")> _
	Partial Public Class GhsmanualspecsCollection
		Inherits esGhsmanualspecsCollection
		Implements IEnumerable(Of Ghsmanualspecs)
		
        Public Shared Widening Operator CType(ByVal coll As GhsmanualspecsCollection) As List(Of Ghsmanualspecs)
            Dim list As List(Of Ghsmanualspecs) = New List(Of Ghsmanualspecs)
            Dim emp As Ghsmanualspecs

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GhsmanualspecsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New GhsmanualspecsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Ghsmanualspecs(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Ghsmanualspecs()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As GhsmanualspecsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New GhsmanualspecsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As GhsmanualspecsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Ghsmanualspecs 
			Return CType(MyBase.AddNewEntity(), Ghsmanualspecs)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal chemicalid As System.Int32) As Ghsmanualspecs
			Return CType(MyBase.FindByPrimaryKey(chemicalid), Ghsmanualspecs)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Ghsmanualspecs) Implements IEnumerable(Of Ghsmanualspecs).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Ghsmanualspecs)(Me)
        End Function
		
		Private _query As GhsmanualspecsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'GHSMANUALSPECS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Ghsmanualspecs ({Chemicalid.Value})")> _
	<Serializable> _
	Partial Public Class Ghsmanualspecs 
		Inherits esGhsmanualspecs

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return GhsmanualspecsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esGhsmanualspecsQuery

			If Me._query Is Nothing Then
				Me._query = New GhsmanualspecsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As GhsmanualspecsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New GhsmanualspecsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As GhsmanualspecsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As GhsmanualspecsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class GhsmanualspecsQuery
		inherits esGhsmanualspecsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "GhsmanualspecsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class GhsmanualspecsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Chemicalid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Chemicalid
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Pictogram1, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Pictogram1
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Pictogram2, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Pictogram2
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Pictogram3, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Pictogram3
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Pictogram4, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Pictogram4
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Pictogram5, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Pictogram5
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Dangerword, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Dangerword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Ghsclassification, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Ghsclassification
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Hazardstatements, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Hazardstatements
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Safetyprecautions, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Safetyprecautions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Firstaidmeasures, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Firstaidmeasures
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Storage, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Storage
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Disposal, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Disposal
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Acutetoxicitydermal, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Acutetoxicitydermal
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationgas, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Acutetoxicityinhalationgas
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationvapor, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Acutetoxicityinhalationvapor
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityinhalationdustmist, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Acutetoxicityinhalationdustmist
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Acutetoxicityoral, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Acutetoxicityoral
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Firesupplemental, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Firesupplemental
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(GhsmanualspecsMetadata.ColumnNames.Accidentsupplemental, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = GhsmanualspecsMetadata.PropertyNames.Accidentsupplemental
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As GhsmanualspecsMetadata
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
			 Public Const Firesupplemental As String = "FIRESUPPLEMENTAL"
			 Public Const Accidentsupplemental As String = "ACCIDENTSUPPLEMENTAL"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Chemicalid As String = "Chemicalid"
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
			 Public Const Firesupplemental As String = "Firesupplemental"
			 Public Const Accidentsupplemental As String = "Accidentsupplemental"
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
            SyncLock GetType(GhsmanualspecsMetadata)
			
				If GhsmanualspecsMetadata.mapDelegates Is Nothing Then
					GhsmanualspecsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If GhsmanualspecsMetadata._meta Is Nothing Then
                    GhsmanualspecsMetadata._meta = New GhsmanualspecsMetadata()
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
				meta.AddTypeMap("Firesupplemental", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Accidentsupplemental", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "GHSMANUALSPECS"
				meta.Destination = "GHSMANUALSPECS"
				
				meta.spInsert = "proc_GHSMANUALSPECSInsert"
				meta.spUpdate = "proc_GHSMANUALSPECSUpdate"
				meta.spDelete = "proc_GHSMANUALSPECSDelete"
				meta.spLoadAll = "proc_GHSMANUALSPECSLoadAll"
				meta.spLoadByPrimaryKey = "proc_GHSMANUALSPECSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As GhsmanualspecsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
