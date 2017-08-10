'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:56 PM
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
	MustInherit Public Class esLbifhdCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LbifhdCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLbifhdQuery)
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
            Me.InitQuery(CType(query, esLbifhdQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Lbifhd) As Lbifhd
			Return CType(MyBase.DetachEntity(entity), Lbifhd)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Lbifhd) As Lbifhd
			Return CType(MyBase.AttachEntity(entity), Lbifhd)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LbifhdCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Lbifhd
            Get
                Return TryCast(MyBase.Item(index), Lbifhd)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Lbifhd)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLbifhd	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLbifhdQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey() As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic() As Boolean
		
			Dim query As esLbifhdQuery = Me.GetDynamicQuery()
			query.Where()
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure() As Boolean
		
			Dim parms As esParameters = New esParameters()

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
												
						Case "Lbid"
							Me.str.Lbid = CType(value, string)
												
						Case "Lbrqdt"
							Me.str.Lbrqdt = CType(value, string)
												
						Case "Lbrqtm"
							Me.str.Lbrqtm = CType(value, string)
												
						Case "Lbstck"
							Me.str.Lbstck = CType(value, string)
												
						Case "Lbprtr"
							Me.str.Lbprtr = CType(value, string)
												
						Case "Lbseq"
							Me.str.Lbseq = CType(value, string)
												
						Case "Lbsqst"
							Me.str.Lbsqst = CType(value, string)
												
						Case "Lbsqsp"
							Me.str.Lbsqsp = CType(value, string)
												
						Case "Lbsqen"
							Me.str.Lbsqen = CType(value, string)
												
						Case "Lbquan"
							Me.str.Lbquan = CType(value, string)
												
						Case "Lbtemp"
							Me.str.Lbtemp = CType(value, string)
												
						Case "Lblang"
							Me.str.Lblang = CType(value, string)
												
						Case "Lbstat"
							Me.str.Lbstat = CType(value, string)
												
						Case "Lberrm"
							Me.str.Lberrm = CType(value, string)
												
						Case "Lbreck"
							Me.str.Lbreck = CType(value, string)
												
						Case "Lbstdt"
							Me.str.Lbstdt = CType(value, string)
												
						Case "Lbsttm"
							Me.str.Lbsttm = CType(value, string)
												
						Case "Lbcopy"
							Me.str.Lbcopy = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Lbid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbid = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbrqdt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbrqdt = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbrqtm"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbrqtm = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbsqst"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbsqst = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbsqsp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbsqsp = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbsqen"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbsqen = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbquan"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbquan = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbreck"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbreck = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbstdt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbstdt = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbsttm"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbsttm = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lbcopy"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Lbcopy = CType(value, Nullable(Of System.Decimal))
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
		' Maps to LBIFHD.LBID
		' </summary>
		Public Overridable Property Lbid As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBRQDT
		' </summary>
		Public Overridable Property Lbrqdt As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbrqdt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbrqdt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBRQTM
		' </summary>
		Public Overridable Property Lbrqtm As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbrqtm)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbrqtm, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBSTCK
		' </summary>
		Public Overridable Property Lbstck As System.String
			Get
				Return MyBase.GetSystemString(LbifhdMetadata.ColumnNames.Lbstck)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifhdMetadata.ColumnNames.Lbstck, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBPRTR
		' </summary>
		Public Overridable Property Lbprtr As System.String
			Get
				Return MyBase.GetSystemString(LbifhdMetadata.ColumnNames.Lbprtr)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifhdMetadata.ColumnNames.Lbprtr, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBSEQ
		' </summary>
		Public Overridable Property Lbseq As System.String
			Get
				Return MyBase.GetSystemString(LbifhdMetadata.ColumnNames.Lbseq)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifhdMetadata.ColumnNames.Lbseq, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBSQST
		' </summary>
		Public Overridable Property Lbsqst As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbsqst)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbsqst, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBSQSP
		' </summary>
		Public Overridable Property Lbsqsp As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbsqsp)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbsqsp, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBSQEN
		' </summary>
		Public Overridable Property Lbsqen As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbsqen)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbsqen, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBQUAN
		' </summary>
		Public Overridable Property Lbquan As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbquan)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbquan, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBTEMP
		' </summary>
		Public Overridable Property Lbtemp As System.String
			Get
				Return MyBase.GetSystemString(LbifhdMetadata.ColumnNames.Lbtemp)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifhdMetadata.ColumnNames.Lbtemp, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBLANG
		' </summary>
		Public Overridable Property Lblang As System.String
			Get
				Return MyBase.GetSystemString(LbifhdMetadata.ColumnNames.Lblang)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifhdMetadata.ColumnNames.Lblang, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBSTAT
		' </summary>
		Public Overridable Property Lbstat As System.String
			Get
				Return MyBase.GetSystemString(LbifhdMetadata.ColumnNames.Lbstat)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifhdMetadata.ColumnNames.Lbstat, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBERRM
		' </summary>
		Public Overridable Property Lberrm As System.String
			Get
				Return MyBase.GetSystemString(LbifhdMetadata.ColumnNames.Lberrm)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LbifhdMetadata.ColumnNames.Lberrm, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBRECK
		' </summary>
		Public Overridable Property Lbreck As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbreck)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbreck, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBSTDT
		' </summary>
		Public Overridable Property Lbstdt As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbstdt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbstdt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBSTTM
		' </summary>
		Public Overridable Property Lbsttm As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbsttm)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbsttm, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LBIFHD.LBCOPY
		' </summary>
		Public Overridable Property Lbcopy As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LbifhdMetadata.ColumnNames.Lbcopy)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LbifhdMetadata.ColumnNames.Lbcopy, value)
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
		
			Public Sub New(ByVal entity As esLbifhd)
				Me.entity = entity
			End Sub				
		
	
			Public Property Lbid As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbid = Nothing
					Else
						entity.Lbid = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbrqdt As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbrqdt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbrqdt = Nothing
					Else
						entity.Lbrqdt = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbrqtm As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbrqtm
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbrqtm = Nothing
					Else
						entity.Lbrqtm = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbstck As System.String 
				Get
					Dim data_ As System.String = entity.Lbstck
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbstck = Nothing
					Else
						entity.Lbstck = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbprtr As System.String 
				Get
					Dim data_ As System.String = entity.Lbprtr
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbprtr = Nothing
					Else
						entity.Lbprtr = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbseq As System.String 
				Get
					Dim data_ As System.String = entity.Lbseq
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbseq = Nothing
					Else
						entity.Lbseq = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbsqst As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbsqst
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbsqst = Nothing
					Else
						entity.Lbsqst = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbsqsp As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbsqsp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbsqsp = Nothing
					Else
						entity.Lbsqsp = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbsqen As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbsqen
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbsqen = Nothing
					Else
						entity.Lbsqen = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbquan As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbquan
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbquan = Nothing
					Else
						entity.Lbquan = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbtemp As System.String 
				Get
					Dim data_ As System.String = entity.Lbtemp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbtemp = Nothing
					Else
						entity.Lbtemp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lblang As System.String 
				Get
					Dim data_ As System.String = entity.Lblang
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lblang = Nothing
					Else
						entity.Lblang = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbstat As System.String 
				Get
					Dim data_ As System.String = entity.Lbstat
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbstat = Nothing
					Else
						entity.Lbstat = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lberrm As System.String 
				Get
					Dim data_ As System.String = entity.Lberrm
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lberrm = Nothing
					Else
						entity.Lberrm = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbreck As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbreck
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbreck = Nothing
					Else
						entity.Lbreck = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbstdt As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbstdt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbstdt = Nothing
					Else
						entity.Lbstdt = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbsttm As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbsttm
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbsttm = Nothing
					Else
						entity.Lbsttm = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lbcopy As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Lbcopy
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lbcopy = Nothing
					Else
						entity.Lbcopy = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLbifhd
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLbifhdQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLbifhd can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Lbifhd 
		Inherits esLbifhd
		
	
		
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
	MustInherit Public Class esLbifhdQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LbifhdMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Lbid As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbid, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbrqdt As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbrqdt, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbrqtm As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbrqtm, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbstck As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbstck, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lbprtr As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbprtr, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lbseq As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbseq, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lbsqst As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbsqst, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbsqsp As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbsqsp, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbsqen As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbsqen, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbquan As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbquan, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbtemp As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbtemp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lblang As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lblang, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lbstat As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbstat, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lberrm As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lberrm, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lbreck As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbreck, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbstdt As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbstdt, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbsttm As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbsttm, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Lbcopy As esQueryItem
			Get
				Return New esQueryItem(Me, LbifhdMetadata.ColumnNames.Lbcopy, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LbifhdCollection")> _
	Partial Public Class LbifhdCollection
		Inherits esLbifhdCollection
		Implements IEnumerable(Of Lbifhd)
		
        Public Shared Widening Operator CType(ByVal coll As LbifhdCollection) As List(Of Lbifhd)
            Dim list As List(Of Lbifhd) = New List(Of Lbifhd)
            Dim emp As Lbifhd

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LbifhdMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LbifhdQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Lbifhd(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Lbifhd()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LbifhdQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LbifhdQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LbifhdQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Lbifhd 
			Return CType(MyBase.AddNewEntity(), Lbifhd)
		End Function

		Public Overloads Function FindByPrimaryKey() As Lbifhd
			Return CType(MyBase.FindByPrimaryKey(), Lbifhd)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Lbifhd) Implements IEnumerable(Of Lbifhd).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Lbifhd)(Me)
        End Function
		
		Private _query As LbifhdQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LBIFHD' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Lbifhd ()")> _
	<Serializable> _
	Partial Public Class Lbifhd 
		Inherits esLbifhd

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LbifhdMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLbifhdQuery

			If Me._query Is Nothing Then
				Me._query = New LbifhdQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LbifhdQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LbifhdQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LbifhdQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LbifhdQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LbifhdQuery
		inherits esLbifhdQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LbifhdQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LbifhdMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbid, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbid
			c.NumericPrecision = 11
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbrqdt, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbrqdt
			c.NumericPrecision = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbrqtm, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbrqtm
			c.NumericPrecision = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbstck, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbstck
			c.CharacterMaxLength = 25
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbprtr, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbprtr
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbseq, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbseq
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbsqst, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbsqst
			c.NumericPrecision = 5
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbsqsp, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbsqsp
			c.NumericPrecision = 5
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbsqen, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbsqen
			c.NumericPrecision = 5
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbquan, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbquan
			c.NumericPrecision = 5
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbtemp, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbtemp
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lblang, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lblang
			c.CharacterMaxLength = 5
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbstat, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbstat
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lberrm, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lberrm
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbreck, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbreck
			c.NumericPrecision = 11
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbstdt, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbstdt
			c.NumericPrecision = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbsttm, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbsttm
			c.NumericPrecision = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LbifhdMetadata.ColumnNames.Lbcopy, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LbifhdMetadata.PropertyNames.Lbcopy
			c.NumericPrecision = 6
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LbifhdMetadata
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
			 Public Const Lbid As String = "LBID"
			 Public Const Lbrqdt As String = "LBRQDT"
			 Public Const Lbrqtm As String = "LBRQTM"
			 Public Const Lbstck As String = "LBSTCK"
			 Public Const Lbprtr As String = "LBPRTR"
			 Public Const Lbseq As String = "LBSEQ"
			 Public Const Lbsqst As String = "LBSQST"
			 Public Const Lbsqsp As String = "LBSQSP"
			 Public Const Lbsqen As String = "LBSQEN"
			 Public Const Lbquan As String = "LBQUAN"
			 Public Const Lbtemp As String = "LBTEMP"
			 Public Const Lblang As String = "LBLANG"
			 Public Const Lbstat As String = "LBSTAT"
			 Public Const Lberrm As String = "LBERRM"
			 Public Const Lbreck As String = "LBRECK"
			 Public Const Lbstdt As String = "LBSTDT"
			 Public Const Lbsttm As String = "LBSTTM"
			 Public Const Lbcopy As String = "LBCOPY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Lbid As String = "Lbid"
			 Public Const Lbrqdt As String = "Lbrqdt"
			 Public Const Lbrqtm As String = "Lbrqtm"
			 Public Const Lbstck As String = "Lbstck"
			 Public Const Lbprtr As String = "Lbprtr"
			 Public Const Lbseq As String = "Lbseq"
			 Public Const Lbsqst As String = "Lbsqst"
			 Public Const Lbsqsp As String = "Lbsqsp"
			 Public Const Lbsqen As String = "Lbsqen"
			 Public Const Lbquan As String = "Lbquan"
			 Public Const Lbtemp As String = "Lbtemp"
			 Public Const Lblang As String = "Lblang"
			 Public Const Lbstat As String = "Lbstat"
			 Public Const Lberrm As String = "Lberrm"
			 Public Const Lbreck As String = "Lbreck"
			 Public Const Lbstdt As String = "Lbstdt"
			 Public Const Lbsttm As String = "Lbsttm"
			 Public Const Lbcopy As String = "Lbcopy"
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
            SyncLock GetType(LbifhdMetadata)
			
				If LbifhdMetadata.mapDelegates Is Nothing Then
					LbifhdMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LbifhdMetadata._meta Is Nothing Then
                    LbifhdMetadata._meta = New LbifhdMetadata()
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
				

				meta.AddTypeMap("Lbid", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbrqdt", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbrqtm", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbstck", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lbprtr", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lbseq", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lbsqst", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbsqsp", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbsqen", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbquan", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbtemp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lblang", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lbstat", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lberrm", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lbreck", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbstdt", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbsttm", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Lbcopy", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "LBIFHD"
				meta.Destination = "LBIFHD"
				
				meta.spInsert = "proc_LBIFHDInsert"
				meta.spUpdate = "proc_LBIFHDUpdate"
				meta.spDelete = "proc_LBIFHDDelete"
				meta.spLoadAll = "proc_LBIFHDLoadAll"
				meta.spLoadByPrimaryKey = "proc_LBIFHDLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LbifhdMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
