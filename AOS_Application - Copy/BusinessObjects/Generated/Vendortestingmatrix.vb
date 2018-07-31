'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/17/2014 4:55:41 PM
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
	MustInherit Public Class esVendortestingmatrixCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "VendortestingmatrixCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esVendortestingmatrixQuery)
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
            Me.InitQuery(CType(query, esVendortestingmatrixQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Vendortestingmatrix) As Vendortestingmatrix
			Return CType(MyBase.DetachEntity(entity), Vendortestingmatrix)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Vendortestingmatrix) As Vendortestingmatrix
			Return CType(MyBase.AttachEntity(entity), Vendortestingmatrix)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As VendortestingmatrixCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Vendortestingmatrix
            Get
                Return TryCast(MyBase.Item(index), Vendortestingmatrix)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Vendortestingmatrix)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esVendortestingmatrix	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esVendortestingmatrixQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal vendortestingmatrixid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(vendortestingmatrixid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(vendortestingmatrixid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal vendortestingmatrixid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(vendortestingmatrixid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(vendortestingmatrixid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal vendortestingmatrixid As System.Int32) As Boolean
		
			Dim query As esVendortestingmatrixQuery = Me.GetDynamicQuery()
			query.Where(query.Vendortestingmatrixid.Equal(vendortestingmatrixid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal vendortestingmatrixid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("VENDORTESTINGMATRIXID", vendortestingmatrixid)
			
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
												
						Case "Vendortestingmatrixid"
							Me.str.Vendortestingmatrixid = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Chemicalcategory"
							Me.str.Chemicalcategory = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Retainpercentage"
							Me.str.Retainpercentage = CType(value, string)
												
						Case "Testpercentage"
							Me.str.Testpercentage = CType(value, string)
												
						Case "Ph"
							Me.str.Ph = CType(value, string)
												
						Case "Sg"
							Me.str.Sg = CType(value, string)
												
						Case "Color"
							Me.str.Color = CType(value, string)
												
						Case "Appearance"
							Me.str.Appearance = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Vendortestingmatrixid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendortestingmatrixid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Retainpercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Retainpercentage = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Testpercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Testpercentage = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Ph"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Ph = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Sg"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Sg = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Color"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Color = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Appearance"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Appearance = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to VENDORTESTINGMATRIX.VENDORTESTINGMATRIXID
		' </summary>
		Public Overridable Property Vendortestingmatrixid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Vendortestingmatrixid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Vendortestingmatrixid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.CHEMICALCATEGORY
		' </summary>
		Public Overridable Property Chemicalcategory As System.String
			Get
				Return MyBase.GetSystemString(VendortestingmatrixMetadata.ColumnNames.Chemicalcategory)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendortestingmatrixMetadata.ColumnNames.Chemicalcategory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.RETAINPERCENTAGE
		' </summary>
		Public Overridable Property Retainpercentage As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Retainpercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Retainpercentage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.TESTPERCENTAGE
		' </summary>
		Public Overridable Property Testpercentage As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Testpercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(VendortestingmatrixMetadata.ColumnNames.Testpercentage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.PH
		' </summary>
		Public Overridable Property Ph As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Ph)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Ph, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.SG
		' </summary>
		Public Overridable Property Sg As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Sg)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Sg, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.COLOR
		' </summary>
		Public Overridable Property Color As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Color)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Color, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.APPEARANCE
		' </summary>
		Public Overridable Property Appearance As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Appearance)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Appearance, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(VendortestingmatrixMetadata.ColumnNames.Isactive, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(VendortestingmatrixMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendortestingmatrixMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VendortestingmatrixMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(VendortestingmatrixMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(VendortestingmatrixMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(VendortestingmatrixMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to VENDORTESTINGMATRIX.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VendortestingmatrixMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(VendortestingmatrixMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esVendortestingmatrix)
				Me.entity = entity
			End Sub				
		
	
			Public Property Vendortestingmatrixid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendortestingmatrixid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendortestingmatrixid = Nothing
					Else
						entity.Vendortestingmatrixid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendorid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorid = Nothing
					Else
						entity.Vendorid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalcategory As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalcategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalcategory = Nothing
					Else
						entity.Chemicalcategory = Convert.ToString(Value)
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
		  	
			Public Property Retainpercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Retainpercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Retainpercentage = Nothing
					Else
						entity.Retainpercentage = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Testpercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Testpercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Testpercentage = Nothing
					Else
						entity.Testpercentage = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ph As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Ph
					
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
						entity.Ph = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sg As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Sg
					
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
						entity.Sg = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Color As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Color
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Color = Nothing
					Else
						entity.Color = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appearance As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Appearance
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appearance = Nothing
					Else
						entity.Appearance = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isactive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isactive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isactive = Nothing
					Else
						entity.Isactive = Convert.ToBoolean(Value)
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
		  	
			Public Property Modifyby As System.String 
				Get
					Dim data_ As System.String = entity.Modifyby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifyby = Nothing
					Else
						entity.Modifyby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifytime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifytime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifytime = Nothing
					Else
						entity.Modifytime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVendortestingmatrix
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esVendortestingmatrixQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esVendortestingmatrix can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Vendortestingmatrix 
		Inherits esVendortestingmatrix
		
	
		
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
	MustInherit Public Class esVendortestingmatrixQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VendortestingmatrixMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Vendortestingmatrixid As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Vendortestingmatrixid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalcategory As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Chemicalcategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Retainpercentage As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Retainpercentage, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Testpercentage As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Testpercentage, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Ph As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Ph, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Sg As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Sg, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Color As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Color, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Appearance As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Appearance, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, VendortestingmatrixMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("VendortestingmatrixCollection")> _
	Partial Public Class VendortestingmatrixCollection
		Inherits esVendortestingmatrixCollection
		Implements IEnumerable(Of Vendortestingmatrix)
		
        Public Shared Widening Operator CType(ByVal coll As VendortestingmatrixCollection) As List(Of Vendortestingmatrix)
            Dim list As List(Of Vendortestingmatrix) = New List(Of Vendortestingmatrix)
            Dim emp As Vendortestingmatrix

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VendortestingmatrixMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New VendortestingmatrixQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Vendortestingmatrix(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Vendortestingmatrix()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As VendortestingmatrixQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New VendortestingmatrixQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As VendortestingmatrixQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Vendortestingmatrix 
			Return CType(MyBase.AddNewEntity(), Vendortestingmatrix)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal vendortestingmatrixid As System.Int32) As Vendortestingmatrix
			Return CType(MyBase.FindByPrimaryKey(vendortestingmatrixid), Vendortestingmatrix)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Vendortestingmatrix) Implements IEnumerable(Of Vendortestingmatrix).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Vendortestingmatrix)(Me)
        End Function
		
		Private _query As VendortestingmatrixQuery

	End Class
	


	' <summary>
	' Encapsulates the 'VENDORTESTINGMATRIX' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Vendortestingmatrix ({Vendortestingmatrixid.Value})")> _
	<Serializable> _
	Partial Public Class Vendortestingmatrix 
		Inherits esVendortestingmatrix

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return VendortestingmatrixMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esVendortestingmatrixQuery

			If Me._query Is Nothing Then
				Me._query = New VendortestingmatrixQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As VendortestingmatrixQuery
			Get

				If Me._query Is Nothing then
					Me._query = New VendortestingmatrixQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As VendortestingmatrixQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As VendortestingmatrixQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class VendortestingmatrixQuery
		inherits esVendortestingmatrixQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "VendortestingmatrixQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class VendortestingmatrixMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Vendortestingmatrixid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Vendortestingmatrixid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Vendorid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Chemicalcategory, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Chemicalcategory
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Productid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Retainpercentage, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Retainpercentage
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Testpercentage, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Testpercentage
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Ph, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Ph
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Sg, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Sg
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Color, 8, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Color
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Appearance, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Appearance
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Isactive, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Isactive
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Createdby, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Createdtime, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Modifyby, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(VendortestingmatrixMetadata.ColumnNames.Modifytime, 14, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VendortestingmatrixMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As VendortestingmatrixMetadata
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
			 Public Const Vendortestingmatrixid As String = "VENDORTESTINGMATRIXID"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Chemicalcategory As String = "CHEMICALCATEGORY"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Retainpercentage As String = "RETAINPERCENTAGE"
			 Public Const Testpercentage As String = "TESTPERCENTAGE"
			 Public Const Ph As String = "PH"
			 Public Const Sg As String = "SG"
			 Public Const Color As String = "COLOR"
			 Public Const Appearance As String = "APPEARANCE"
			 Public Const Isactive As String = "ISACTIVE"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Vendortestingmatrixid As String = "Vendortestingmatrixid"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Chemicalcategory As String = "Chemicalcategory"
			 Public Const Productid As String = "Productid"
			 Public Const Retainpercentage As String = "Retainpercentage"
			 Public Const Testpercentage As String = "Testpercentage"
			 Public Const Ph As String = "Ph"
			 Public Const Sg As String = "Sg"
			 Public Const Color As String = "Color"
			 Public Const Appearance As String = "Appearance"
			 Public Const Isactive As String = "Isactive"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
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
            SyncLock GetType(VendortestingmatrixMetadata)
			
				If VendortestingmatrixMetadata.mapDelegates Is Nothing Then
					VendortestingmatrixMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If VendortestingmatrixMetadata._meta Is Nothing Then
                    VendortestingmatrixMetadata._meta = New VendortestingmatrixMetadata()
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
				

				meta.AddTypeMap("Vendortestingmatrixid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalcategory", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Retainpercentage", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Testpercentage", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Ph", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Sg", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Color", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Appearance", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "VENDORTESTINGMATRIX"
				meta.Destination = "VENDORTESTINGMATRIX"
				
				meta.spInsert = "proc_VENDORTESTINGMATRIXInsert"
				meta.spUpdate = "proc_VENDORTESTINGMATRIXUpdate"
				meta.spDelete = "proc_VENDORTESTINGMATRIXDelete"
				meta.spLoadAll = "proc_VENDORTESTINGMATRIXLoadAll"
				meta.spLoadByPrimaryKey = "proc_VENDORTESTINGMATRIXLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As VendortestingmatrixMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
