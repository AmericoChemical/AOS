'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/25/2017 8:32:04 AM
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
	MustInherit Public Class esViewChangeRecordVendorCostsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewChangeRecordVendorCostsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewChangeRecordVendorCostsQuery)
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
            Me.InitQuery(CType(query, esViewChangeRecordVendorCostsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewChangeRecordVendorCosts) As ViewChangeRecordVendorCosts
			Return CType(MyBase.DetachEntity(entity), ViewChangeRecordVendorCosts)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewChangeRecordVendorCosts) As ViewChangeRecordVendorCosts
			Return CType(MyBase.AttachEntity(entity), ViewChangeRecordVendorCosts)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewChangeRecordVendorCostsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewChangeRecordVendorCosts
            Get
                Return TryCast(MyBase.Item(index), ViewChangeRecordVendorCosts)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewChangeRecordVendorCosts)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewChangeRecordVendorCosts	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewChangeRecordVendorCostsQuery
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
												
						Case "Changerecid"
							Me.str.Changerecid = CType(value, string)
												
						Case "Changetype"
							Me.str.Changetype = CType(value, string)
												
						Case "Whatchanged"
							Me.str.Whatchanged = CType(value, string)
												
						Case "Whochanged"
							Me.str.Whochanged = CType(value, string)
												
						Case "Whychanged"
							Me.str.Whychanged = CType(value, string)
												
						Case "Datatablename"
							Me.str.Datatablename = CType(value, string)
												
						Case "Datarecordid"
							Me.str.Datarecordid = CType(value, string)
												
						Case "Priorvalue1"
							Me.str.Priorvalue1 = CType(value, string)
												
						Case "Priorvalue1name"
							Me.str.Priorvalue1name = CType(value, string)
												
						Case "Priorvalue2"
							Me.str.Priorvalue2 = CType(value, string)
												
						Case "Priorvalue2name"
							Me.str.Priorvalue2name = CType(value, string)
												
						Case "Priorvalue3"
							Me.str.Priorvalue3 = CType(value, string)
												
						Case "Priorvalue3name"
							Me.str.Priorvalue3name = CType(value, string)
												
						Case "Newvalue1"
							Me.str.Newvalue1 = CType(value, string)
												
						Case "Newvalue2"
							Me.str.Newvalue2 = CType(value, string)
												
						Case "Newvalue3"
							Me.str.Newvalue3 = CType(value, string)
												
						Case "Recordstatus"
							Me.str.Recordstatus = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Whenchanged"
							Me.str.Whenchanged = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Changerecid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Changerecid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Datarecordid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Datarecordid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Whenchanged"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Whenchanged = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewChangeRecordVendorCosts.CHANGERECID
		' </summary>
		Public Overridable Property Changerecid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeRecordVendorCostsMetadata.ColumnNames.Changerecid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeRecordVendorCostsMetadata.ColumnNames.Changerecid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.CHANGETYPE
		' </summary>
		Public Overridable Property Changetype As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Changetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Changetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.WHATCHANGED
		' </summary>
		Public Overridable Property Whatchanged As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whatchanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whatchanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.WHOCHANGED
		' </summary>
		Public Overridable Property Whochanged As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whochanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whochanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.WHYCHANGED
		' </summary>
		Public Overridable Property Whychanged As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whychanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whychanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.DATATABLENAME
		' </summary>
		Public Overridable Property Datatablename As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Datatablename)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Datatablename, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.DATARECORDID
		' </summary>
		Public Overridable Property Datarecordid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeRecordVendorCostsMetadata.ColumnNames.Datarecordid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeRecordVendorCostsMetadata.ColumnNames.Datarecordid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.PRIORVALUE1
		' </summary>
		Public Overridable Property Priorvalue1 As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.PRIORVALUE1NAME
		' </summary>
		Public Overridable Property Priorvalue1name As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue1name)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue1name, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.PRIORVALUE2
		' </summary>
		Public Overridable Property Priorvalue2 As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.PRIORVALUE2NAME
		' </summary>
		Public Overridable Property Priorvalue2name As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue2name)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue2name, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.PRIORVALUE3
		' </summary>
		Public Overridable Property Priorvalue3 As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.PRIORVALUE3NAME
		' </summary>
		Public Overridable Property Priorvalue3name As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue3name)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue3name, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.NEWVALUE1
		' </summary>
		Public Overridable Property Newvalue1 As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.NEWVALUE2
		' </summary>
		Public Overridable Property Newvalue2 As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.NEWVALUE3
		' </summary>
		Public Overridable Property Newvalue3 As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.RECORDSTATUS
		' </summary>
		Public Overridable Property Recordstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Recordstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Recordstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeRecordVendorCostsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeRecordVendorCostsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeRecordVendorCostsMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeRecordVendorCostsMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeRecordVendorCostsMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeRecordVendorCosts.WHENCHANGED
		' </summary>
		Public Overridable Property Whenchanged As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whenchanged)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whenchanged, value)
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
		
			Public Sub New(ByVal entity As esViewChangeRecordVendorCosts)
				Me.entity = entity
			End Sub				
		
	
			Public Property Changerecid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Changerecid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changerecid = Nothing
					Else
						entity.Changerecid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changetype As System.String 
				Get
					Dim data_ As System.String = entity.Changetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changetype = Nothing
					Else
						entity.Changetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whatchanged As System.String 
				Get
					Dim data_ As System.String = entity.Whatchanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whatchanged = Nothing
					Else
						entity.Whatchanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whochanged As System.String 
				Get
					Dim data_ As System.String = entity.Whochanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whochanged = Nothing
					Else
						entity.Whochanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whychanged As System.String 
				Get
					Dim data_ As System.String = entity.Whychanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whychanged = Nothing
					Else
						entity.Whychanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datatablename As System.String 
				Get
					Dim data_ As System.String = entity.Datatablename
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datatablename = Nothing
					Else
						entity.Datatablename = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datarecordid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Datarecordid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datarecordid = Nothing
					Else
						entity.Datarecordid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue1 As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue1 = Nothing
					Else
						entity.Priorvalue1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue1name As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue1name
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue1name = Nothing
					Else
						entity.Priorvalue1name = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue2 As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue2 = Nothing
					Else
						entity.Priorvalue2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue2name As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue2name
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue2name = Nothing
					Else
						entity.Priorvalue2name = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue3 As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue3 = Nothing
					Else
						entity.Priorvalue3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue3name As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue3name
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue3name = Nothing
					Else
						entity.Priorvalue3name = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newvalue1 As System.String 
				Get
					Dim data_ As System.String = entity.Newvalue1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newvalue1 = Nothing
					Else
						entity.Newvalue1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newvalue2 As System.String 
				Get
					Dim data_ As System.String = entity.Newvalue2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newvalue2 = Nothing
					Else
						entity.Newvalue2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newvalue3 As System.String 
				Get
					Dim data_ As System.String = entity.Newvalue3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newvalue3 = Nothing
					Else
						entity.Newvalue3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recordstatus As System.String 
				Get
					Dim data_ As System.String = entity.Recordstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recordstatus = Nothing
					Else
						entity.Recordstatus = Convert.ToString(Value)
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
		  	
			Public Property Vendorname As System.String 
				Get
					Dim data_ As System.String = entity.Vendorname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorname = Nothing
					Else
						entity.Vendorname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whenchanged As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Whenchanged
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whenchanged = Nothing
					Else
						entity.Whenchanged = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewChangeRecordVendorCosts
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewChangeRecordVendorCostsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewChangeRecordVendorCosts can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewChangeRecordVendorCostsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewChangeRecordVendorCostsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Changerecid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Changerecid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Changetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Changetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Whatchanged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Whatchanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Whochanged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Whochanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Whychanged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Whychanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datatablename As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Datatablename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datarecordid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Datarecordid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue1name As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue1name, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue2name As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue2name, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue3name As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue3name, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Newvalue1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Newvalue2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Newvalue3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recordstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Recordstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Whenchanged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeRecordVendorCostsMetadata.ColumnNames.Whenchanged, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewChangeRecordVendorCostsCollection")> _
	Partial Public Class ViewChangeRecordVendorCostsCollection
		Inherits esViewChangeRecordVendorCostsCollection
		Implements IEnumerable(Of ViewChangeRecordVendorCosts)
		
        Public Shared Widening Operator CType(ByVal coll As ViewChangeRecordVendorCostsCollection) As List(Of ViewChangeRecordVendorCosts)
            Dim list As List(Of ViewChangeRecordVendorCosts) = New List(Of ViewChangeRecordVendorCosts)
            Dim emp As ViewChangeRecordVendorCosts

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewChangeRecordVendorCostsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewChangeRecordVendorCostsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewChangeRecordVendorCosts(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewChangeRecordVendorCosts()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewChangeRecordVendorCostsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewChangeRecordVendorCostsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewChangeRecordVendorCostsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewChangeRecordVendorCosts 
			Return CType(MyBase.AddNewEntity(), ViewChangeRecordVendorCosts)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewChangeRecordVendorCosts) Implements IEnumerable(Of ViewChangeRecordVendorCosts).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewChangeRecordVendorCosts)(Me)
        End Function
		
		Private _query As ViewChangeRecordVendorCostsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewChangeRecordVendorCosts' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewChangeRecordVendorCosts ()")> _
	<Serializable> _
	Partial Public Class ViewChangeRecordVendorCosts 
		Inherits esViewChangeRecordVendorCosts

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewChangeRecordVendorCostsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewChangeRecordVendorCostsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewChangeRecordVendorCostsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewChangeRecordVendorCostsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewChangeRecordVendorCostsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewChangeRecordVendorCostsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewChangeRecordVendorCostsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewChangeRecordVendorCostsQuery
		inherits esViewChangeRecordVendorCostsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewChangeRecordVendorCostsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewChangeRecordVendorCostsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Changerecid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Changerecid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Changetype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Changetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whatchanged, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Whatchanged
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whochanged, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Whochanged
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whychanged, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Whychanged
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Datatablename, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Datatablename
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Datarecordid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Datarecordid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue1, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Priorvalue1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue1name, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Priorvalue1name
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue2, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Priorvalue2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue2name, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Priorvalue2name
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue3, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Priorvalue3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Priorvalue3name, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Priorvalue3name
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue1, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Newvalue1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue2, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Newvalue2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Newvalue3, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Newvalue3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Recordstatus, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Recordstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Productid, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Productdesc, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Container, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Vendorid, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Vendorname, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeRecordVendorCostsMetadata.ColumnNames.Whenchanged, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewChangeRecordVendorCostsMetadata.PropertyNames.Whenchanged
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewChangeRecordVendorCostsMetadata
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
			 Public Const Changerecid As String = "CHANGERECID"
			 Public Const Changetype As String = "CHANGETYPE"
			 Public Const Whatchanged As String = "WHATCHANGED"
			 Public Const Whochanged As String = "WHOCHANGED"
			 Public Const Whychanged As String = "WHYCHANGED"
			 Public Const Datatablename As String = "DATATABLENAME"
			 Public Const Datarecordid As String = "DATARECORDID"
			 Public Const Priorvalue1 As String = "PRIORVALUE1"
			 Public Const Priorvalue1name As String = "PRIORVALUE1NAME"
			 Public Const Priorvalue2 As String = "PRIORVALUE2"
			 Public Const Priorvalue2name As String = "PRIORVALUE2NAME"
			 Public Const Priorvalue3 As String = "PRIORVALUE3"
			 Public Const Priorvalue3name As String = "PRIORVALUE3NAME"
			 Public Const Newvalue1 As String = "NEWVALUE1"
			 Public Const Newvalue2 As String = "NEWVALUE2"
			 Public Const Newvalue3 As String = "NEWVALUE3"
			 Public Const Recordstatus As String = "RECORDSTATUS"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Whenchanged As String = "WHENCHANGED"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Changerecid As String = "Changerecid"
			 Public Const Changetype As String = "Changetype"
			 Public Const Whatchanged As String = "Whatchanged"
			 Public Const Whochanged As String = "Whochanged"
			 Public Const Whychanged As String = "Whychanged"
			 Public Const Datatablename As String = "Datatablename"
			 Public Const Datarecordid As String = "Datarecordid"
			 Public Const Priorvalue1 As String = "Priorvalue1"
			 Public Const Priorvalue1name As String = "Priorvalue1name"
			 Public Const Priorvalue2 As String = "Priorvalue2"
			 Public Const Priorvalue2name As String = "Priorvalue2name"
			 Public Const Priorvalue3 As String = "Priorvalue3"
			 Public Const Priorvalue3name As String = "Priorvalue3name"
			 Public Const Newvalue1 As String = "Newvalue1"
			 Public Const Newvalue2 As String = "Newvalue2"
			 Public Const Newvalue3 As String = "Newvalue3"
			 Public Const Recordstatus As String = "Recordstatus"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Whenchanged As String = "Whenchanged"
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
            SyncLock GetType(ViewChangeRecordVendorCostsMetadata)
			
				If ViewChangeRecordVendorCostsMetadata.mapDelegates Is Nothing Then
					ViewChangeRecordVendorCostsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewChangeRecordVendorCostsMetadata._meta Is Nothing Then
                    ViewChangeRecordVendorCostsMetadata._meta = New ViewChangeRecordVendorCostsMetadata()
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
				

				meta.AddTypeMap("Changerecid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Changetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Whatchanged", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Whochanged", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Whychanged", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datatablename", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datarecordid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Priorvalue1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue1name", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue2name", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue3name", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Newvalue1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Newvalue2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Newvalue3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Recordstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Whenchanged", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewChangeRecordVendorCosts"
				meta.Destination = "viewChangeRecordVendorCosts"
				
				meta.spInsert = "proc_viewChangeRecordVendorCostsInsert"
				meta.spUpdate = "proc_viewChangeRecordVendorCostsUpdate"
				meta.spDelete = "proc_viewChangeRecordVendorCostsDelete"
				meta.spLoadAll = "proc_viewChangeRecordVendorCostsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewChangeRecordVendorCostsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewChangeRecordVendorCostsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
