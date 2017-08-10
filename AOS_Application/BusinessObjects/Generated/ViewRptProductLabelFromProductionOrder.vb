'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:11 PM
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
	MustInherit Public Class esViewRptProductLabelFromProductionOrderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptProductLabelFromProductionOrderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptProductLabelFromProductionOrderQuery)
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
            Me.InitQuery(CType(query, esViewRptProductLabelFromProductionOrderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptProductLabelFromProductionOrder) As ViewRptProductLabelFromProductionOrder
			Return CType(MyBase.DetachEntity(entity), ViewRptProductLabelFromProductionOrder)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptProductLabelFromProductionOrder) As ViewRptProductLabelFromProductionOrder
			Return CType(MyBase.AttachEntity(entity), ViewRptProductLabelFromProductionOrder)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptProductLabelFromProductionOrderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptProductLabelFromProductionOrder
            Get
                Return TryCast(MyBase.Item(index), ViewRptProductLabelFromProductionOrder)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptProductLabelFromProductionOrder)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptProductLabelFromProductionOrder	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptProductLabelFromProductionOrderQuery
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
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Stdweight"
							Me.str.Stdweight = CType(value, string)
												
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
												
						Case "SymbolDesc"
							Me.str.SymbolDesc = CType(value, string)
												
						Case "Precautions"
							Me.str.Precautions = CType(value, string)
												
						Case "Warning"
							Me.str.Warning = CType(value, string)
												
						Case "Resnumber"
							Me.str.Resnumber = CType(value, string)
												
						Case "Handling"
							Me.str.Handling = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Prodorderdate"
							Me.str.Prodorderdate = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
					
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
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Prodorderdate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewRptProductLabelFromProductionOrder.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.HEALTH
		' </summary>
		Public Overridable Property Health As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Health)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Health, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.FIRE
		' </summary>
		Public Overridable Property Fire As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Fire)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Fire, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.REACTIVITY
		' </summary>
		Public Overridable Property Reactivity As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Reactivity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Reactivity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.PERSONALPROTECTION
		' </summary>
		Public Overridable Property Personalprotection As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Personalprotection)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Personalprotection, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.SymbolDesc
		' </summary>
		Public Overridable Property SymbolDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.SymbolDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.SymbolDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.Precautions
		' </summary>
		Public Overridable Property Precautions As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Precautions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Precautions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.Warning
		' </summary>
		Public Overridable Property Warning As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Warning)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Warning, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.RESNUMBER
		' </summary>
		Public Overridable Property Resnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Resnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Resnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.Handling
		' </summary>
		Public Overridable Property Handling As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Handling)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Handling, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.PRODORDERDATE
		' </summary>
		Public Overridable Property Prodorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Prodorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Prodorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductLabelFromProductionOrder.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Lotnumber, value)
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
		
			Public Sub New(ByVal entity As esViewRptProductLabelFromProductionOrder)
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
		  	
			Public Property SymbolDesc As System.String 
				Get
					Dim data_ As System.String = entity.SymbolDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SymbolDesc = Nothing
					Else
						entity.SymbolDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Precautions As System.String 
				Get
					Dim data_ As System.String = entity.Precautions
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Precautions = Nothing
					Else
						entity.Precautions = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warning As System.String 
				Get
					Dim data_ As System.String = entity.Warning
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warning = Nothing
					Else
						entity.Warning = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resnumber As System.String 
				Get
					Dim data_ As System.String = entity.Resnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resnumber = Nothing
					Else
						entity.Resnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Handling As System.String 
				Get
					Dim data_ As System.String = entity.Handling
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Handling = Nothing
					Else
						entity.Handling = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodordernum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodordernum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodordernum = Nothing
					Else
						entity.Prodordernum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Prodorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodorderdate = Nothing
					Else
						entity.Prodorderdate = Convert.ToDateTime(Value)
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
		  

			Private entity As esViewRptProductLabelFromProductionOrder
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptProductLabelFromProductionOrderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptProductLabelFromProductionOrder can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptProductLabelFromProductionOrderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptProductLabelFromProductionOrderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Health As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Health, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Fire, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reactivity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Reactivity, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Personalprotection As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Personalprotection, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SymbolDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.SymbolDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Precautions As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Precautions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warning As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Warning, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Resnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Handling As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Handling, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Prodorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptProductLabelFromProductionOrderCollection")> _
	Partial Public Class ViewRptProductLabelFromProductionOrderCollection
		Inherits esViewRptProductLabelFromProductionOrderCollection
		Implements IEnumerable(Of ViewRptProductLabelFromProductionOrder)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptProductLabelFromProductionOrderCollection) As List(Of ViewRptProductLabelFromProductionOrder)
            Dim list As List(Of ViewRptProductLabelFromProductionOrder) = New List(Of ViewRptProductLabelFromProductionOrder)
            Dim emp As ViewRptProductLabelFromProductionOrder

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptProductLabelFromProductionOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptProductLabelFromProductionOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptProductLabelFromProductionOrder(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptProductLabelFromProductionOrder()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptProductLabelFromProductionOrderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptProductLabelFromProductionOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptProductLabelFromProductionOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptProductLabelFromProductionOrder 
			Return CType(MyBase.AddNewEntity(), ViewRptProductLabelFromProductionOrder)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptProductLabelFromProductionOrder) Implements IEnumerable(Of ViewRptProductLabelFromProductionOrder).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptProductLabelFromProductionOrder)(Me)
        End Function
		
		Private _query As ViewRptProductLabelFromProductionOrderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptProductLabelFromProductionOrder' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptProductLabelFromProductionOrder ()")> _
	<Serializable> _
	Partial Public Class ViewRptProductLabelFromProductionOrder 
		Inherits esViewRptProductLabelFromProductionOrder

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptProductLabelFromProductionOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptProductLabelFromProductionOrderQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptProductLabelFromProductionOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptProductLabelFromProductionOrderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptProductLabelFromProductionOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptProductLabelFromProductionOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptProductLabelFromProductionOrderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptProductLabelFromProductionOrderQuery
		inherits esViewRptProductLabelFromProductionOrderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptProductLabelFromProductionOrderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptProductLabelFromProductionOrderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Stdweight, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Health, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Health
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Fire, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Fire
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Reactivity, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Reactivity
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Personalprotection, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Personalprotection
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Dotdesc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Hazmatdesc, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Unline, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Hazmatid, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.SymbolDesc, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.SymbolDesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Precautions, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Precautions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Warning, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Warning
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Resnumber, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Resnumber
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Handling, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Handling
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Prodordernum, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Prodorderdate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Prodorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductLabelFromProductionOrderMetadata.ColumnNames.Lotnumber, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductLabelFromProductionOrderMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptProductLabelFromProductionOrderMetadata
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
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Health As String = "HEALTH"
			 Public Const Fire As String = "FIRE"
			 Public Const Reactivity As String = "REACTIVITY"
			 Public Const Personalprotection As String = "PERSONALPROTECTION"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Unline As String = "UNLINE"
			 Public Const Hazmatid As String = "HAZMATID"
			 Public Const SymbolDesc As String = "SymbolDesc"
			 Public Const Precautions As String = "Precautions"
			 Public Const Warning As String = "Warning"
			 Public Const Resnumber As String = "RESNUMBER"
			 Public Const Handling As String = "Handling"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Prodorderdate As String = "PRODORDERDATE"
			 Public Const Lotnumber As String = "LOTNUMBER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Health As String = "Health"
			 Public Const Fire As String = "Fire"
			 Public Const Reactivity As String = "Reactivity"
			 Public Const Personalprotection As String = "Personalprotection"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Unline As String = "Unline"
			 Public Const Hazmatid As String = "Hazmatid"
			 Public Const SymbolDesc As String = "SymbolDesc"
			 Public Const Precautions As String = "Precautions"
			 Public Const Warning As String = "Warning"
			 Public Const Resnumber As String = "Resnumber"
			 Public Const Handling As String = "Handling"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Prodorderdate As String = "Prodorderdate"
			 Public Const Lotnumber As String = "Lotnumber"
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
            SyncLock GetType(ViewRptProductLabelFromProductionOrderMetadata)
			
				If ViewRptProductLabelFromProductionOrderMetadata.mapDelegates Is Nothing Then
					ViewRptProductLabelFromProductionOrderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptProductLabelFromProductionOrderMetadata._meta Is Nothing Then
                    ViewRptProductLabelFromProductionOrderMetadata._meta = New ViewRptProductLabelFromProductionOrderMetadata()
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
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Health", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Reactivity", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Personalprotection", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SymbolDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Precautions", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warning", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Handling", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptProductLabelFromProductionOrder"
				meta.Destination = "viewRptProductLabelFromProductionOrder"
				
				meta.spInsert = "proc_viewRptProductLabelFromProductionOrderInsert"
				meta.spUpdate = "proc_viewRptProductLabelFromProductionOrderUpdate"
				meta.spDelete = "proc_viewRptProductLabelFromProductionOrderDelete"
				meta.spLoadAll = "proc_viewRptProductLabelFromProductionOrderLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptProductLabelFromProductionOrderLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptProductLabelFromProductionOrderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
