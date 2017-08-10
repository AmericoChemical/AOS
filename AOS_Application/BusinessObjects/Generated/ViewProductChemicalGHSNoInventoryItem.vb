'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/12/2015 7:39:09 AM
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
	MustInherit Public Class esViewProductChemicalGHSNoInventoryItemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProductChemicalGHSNoInventoryItemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProductChemicalGHSNoInventoryItemQuery)
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
            Me.InitQuery(CType(query, esViewProductChemicalGHSNoInventoryItemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProductChemicalGHSNoInventoryItem) As ViewProductChemicalGHSNoInventoryItem
			Return CType(MyBase.DetachEntity(entity), ViewProductChemicalGHSNoInventoryItem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProductChemicalGHSNoInventoryItem) As ViewProductChemicalGHSNoInventoryItem
			Return CType(MyBase.AttachEntity(entity), ViewProductChemicalGHSNoInventoryItem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProductChemicalGHSNoInventoryItemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProductChemicalGHSNoInventoryItem
            Get
                Return TryCast(MyBase.Item(index), ViewProductChemicalGHSNoInventoryItem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProductChemicalGHSNoInventoryItem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProductChemicalGHSNoInventoryItem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProductChemicalGHSNoInventoryItemQuery
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
												
						Case "Stdgallons"
							Me.str.Stdgallons = CType(value, string)
												
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
												
						Case "Qtyonhand"
							Me.str.Qtyonhand = CType(value, string)
												
						Case "Qtyallocated"
							Me.str.Qtyallocated = CType(value, string)
												
						Case "Qtyonorder"
							Me.str.Qtyonorder = CType(value, string)
												
						Case "Qtyforsale"
							Me.str.Qtyforsale = CType(value, string)
												
						Case "Qtyminonhand"
							Me.str.Qtyminonhand = CType(value, string)
												
						Case "Reorderqty"
							Me.str.Reorderqty = CType(value, string)
												
						Case "Preferredvendorid"
							Me.str.Preferredvendorid = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Datecostlastchanged"
							Me.str.Datecostlastchanged = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Desc2"
							Me.str.Desc2 = CType(value, string)
												
						Case "Inventoryclass"
							Me.str.Inventoryclass = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Isliquid"
							Me.str.Isliquid = CType(value, string)
												
						Case "Rawmaterialgroup"
							Me.str.Rawmaterialgroup = CType(value, string)
												
						Case "Inventorygrouping"
							Me.str.Inventorygrouping = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Weightunits"
							Me.str.Weightunits = CType(value, string)
												
						Case "Volumeuom"
							Me.str.Volumeuom = CType(value, string)
												
						Case "Volumeunits"
							Me.str.Volumeunits = CType(value, string)
												
						Case "Inventorymethod"
							Me.str.Inventorymethod = CType(value, string)
												
						Case "Unnumber"
							Me.str.Unnumber = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Phrangelow"
							Me.str.Phrangelow = CType(value, string)
												
						Case "Phrangehigh"
							Me.str.Phrangehigh = CType(value, string)
												
						Case "Sgrangelow"
							Me.str.Sgrangelow = CType(value, string)
												
						Case "Sgrangehigh"
							Me.str.Sgrangehigh = CType(value, string)
												
						Case "Needstesting"
							Me.str.Needstesting = CType(value, string)
												
						Case "Shelflife"
							Me.str.Shelflife = CType(value, string)
												
						Case "Hazclassnumber"
							Me.str.Hazclassnumber = CType(value, string)
												
						Case "Packagegroup"
							Me.str.Packagegroup = CType(value, string)
												
						Case "Chemicalid"
							Me.str.Chemicalid = CType(value, string)
												
						Case "Idnumber"
							Me.str.Idnumber = CType(value, string)
												
						Case "State"
							Me.str.State = CType(value, string)
												
						Case "Isinhazox"
							Me.str.Isinhazox = CType(value, string)
												
						Case "Istoxic"
							Me.str.Istoxic = CType(value, string)
												
						Case "Productstatus"
							Me.str.Productstatus = CType(value, string)
												
						Case "Purchasingnotes"
							Me.str.Purchasingnotes = CType(value, string)
												
						Case "Receivingnotes"
							Me.str.Receivingnotes = CType(value, string)
												
						Case "Secondaryhazclassnumber"
							Me.str.Secondaryhazclassnumber = CType(value, string)
												
						Case "Volumestandardcost"
							Me.str.Volumestandardcost = CType(value, string)
												
						Case "Weightstandardcost"
							Me.str.Weightstandardcost = CType(value, string)
												
						Case "Labeltype"
							Me.str.Labeltype = CType(value, string)
												
						Case "Labeldefaultqty"
							Me.str.Labeldefaultqty = CType(value, string)
												
						Case "Chemicalcolor"
							Me.str.Chemicalcolor = CType(value, string)
												
						Case "Chemicalclarity"
							Me.str.Chemicalclarity = CType(value, string)
												
						Case "Expr1"
							Me.str.Expr1 = CType(value, string)
												
						Case "Expr2"
							Me.str.Expr2 = CType(value, string)
												
						Case "Expr3"
							Me.str.Expr3 = CType(value, string)
												
						Case "TareWeight"
							Me.str.TareWeight = CType(value, string)
												
						Case "ContainerGrouping"
							Me.str.ContainerGrouping = CType(value, string)
												
						Case "Expr4"
							Me.str.Expr4 = CType(value, string)
												
						Case "Chemicalname"
							Me.str.Chemicalname = CType(value, string)
												
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
												
						Case "Expr5"
							Me.str.Expr5 = CType(value, string)
												
						Case "Expr6"
							Me.str.Expr6 = CType(value, string)
												
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
												
						Case "Expr7"
							Me.str.Expr7 = CType(value, string)
												
						Case "Expr8"
							Me.str.Expr8 = CType(value, string)
												
						Case "Modifiedtime"
							Me.str.Modifiedtime = CType(value, string)
												
						Case "Modifiedby"
							Me.str.Modifiedby = CType(value, string)
												
						Case "Expr9"
							Me.str.Expr9 = CType(value, string)
												
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
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdgallons"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdgallons = CType(value, Nullable(Of System.Int32))
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
						
						Case "Qtyonhand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyonhand = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyallocated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyallocated = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyonorder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyonorder = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyforsale"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyforsale = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyminonhand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyminonhand = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Reorderqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Reorderqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Preferredvendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Preferredvendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Datecostlastchanged"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Datecostlastchanged = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Inventoryclass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isliquid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isliquid = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Inventorygrouping"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventorygrouping = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Weightunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumeunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Unnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Phrangelow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phrangelow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phrangehigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phrangehigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgrangelow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgrangelow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgrangehigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgrangehigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Needstesting"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Needstesting = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Chemicalid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isinhazox"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isinhazox = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Istoxic"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Istoxic = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Volumestandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumestandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightstandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightstandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Labeldefaultqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Labeldefaultqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Expr3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Expr3 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TareWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TareWeight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Expr4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Expr4 = CType(value, Nullable(Of System.Int32))
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
						
						Case "Expr7"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expr7 = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifiedtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifiedtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Expr9"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Expr9 = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewProductChemicalGHSNoInventoryItem.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.HEALTH
		' </summary>
		Public Overridable Property Health As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Health)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Health, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.FIRE
		' </summary>
		Public Overridable Property Fire As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Fire)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Fire, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.REACTIVITY
		' </summary>
		Public Overridable Property Reactivity As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Reactivity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Reactivity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PERSONALPROTECTION
		' </summary>
		Public Overridable Property Personalprotection As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Personalprotection)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Personalprotection, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PLACARDREQUIRED
		' </summary>
		Public Overridable Property Placardrequired As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Placardrequired)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Placardrequired, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.QTYONHAND
		' </summary>
		Public Overridable Property Qtyonhand As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyonhand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyonhand, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.QTYALLOCATED
		' </summary>
		Public Overridable Property Qtyallocated As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyallocated)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyallocated, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.QTYONORDER
		' </summary>
		Public Overridable Property Qtyonorder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyonorder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyonorder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.QTYFORSALE
		' </summary>
		Public Overridable Property Qtyforsale As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyforsale)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyforsale, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.QTYMINONHAND
		' </summary>
		Public Overridable Property Qtyminonhand As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyminonhand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyminonhand, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.REORDERQTY
		' </summary>
		Public Overridable Property Reorderqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Reorderqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Reorderqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PREFERREDVENDORID
		' </summary>
		Public Overridable Property Preferredvendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Preferredvendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Preferredvendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DATECOSTLASTCHANGED
		' </summary>
		Public Overridable Property Datecostlastchanged As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Datecostlastchanged)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Datecostlastchanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DESC2
		' </summary>
		Public Overridable Property Desc2 As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Desc2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Desc2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.INVENTORYCLASS
		' </summary>
		Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventoryclass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventoryclass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isactive, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ISLIQUID
		' </summary>
		Public Overridable Property Isliquid As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isliquid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isliquid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.RAWMATERIALGROUP
		' </summary>
		Public Overridable Property Rawmaterialgroup As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Rawmaterialgroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Rawmaterialgroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.INVENTORYGROUPING
		' </summary>
		Public Overridable Property Inventorygrouping As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventorygrouping)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventorygrouping, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.WEIGHTUNITS
		' </summary>
		Public Overridable Property Weightunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.VOLUMEUNITS
		' </summary>
		Public Overridable Property Volumeunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumeunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumeunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.INVENTORYMETHOD
		' </summary>
		Public Overridable Property Inventorymethod As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventorymethod)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventorymethod, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.UNNUMBER
		' </summary>
		Public Overridable Property Unnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PHRANGELOW
		' </summary>
		Public Overridable Property Phrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Phrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Phrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PHRANGEHIGH
		' </summary>
		Public Overridable Property Phrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Phrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Phrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.SGRANGELOW
		' </summary>
		Public Overridable Property Sgrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sgrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sgrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.SGRANGEHIGH
		' </summary>
		Public Overridable Property Sgrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sgrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sgrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.NEEDSTESTING
		' </summary>
		Public Overridable Property Needstesting As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Needstesting)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Needstesting, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.SHELFLIFE
		' </summary>
		Public Overridable Property Shelflife As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Shelflife)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Shelflife, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.HAZCLASSNUMBER
		' </summary>
		Public Overridable Property Hazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PACKAGEGROUP
		' </summary>
		Public Overridable Property Packagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Packagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Packagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.IDNUMBER
		' </summary>
		Public Overridable Property Idnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Idnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Idnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.STATE
		' </summary>
		Public Overridable Property State As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.State)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.State, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ISINHAZOX
		' </summary>
		Public Overridable Property Isinhazox As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isinhazox)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isinhazox, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ISTOXIC
		' </summary>
		Public Overridable Property Istoxic As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Istoxic)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Istoxic, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PRODUCTSTATUS
		' </summary>
		Public Overridable Property Productstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PURCHASINGNOTES
		' </summary>
		Public Overridable Property Purchasingnotes As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Purchasingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Purchasingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.RECEIVINGNOTES
		' </summary>
		Public Overridable Property Receivingnotes As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Receivingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Receivingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.SECONDARYHAZCLASSNUMBER
		' </summary>
		Public Overridable Property Secondaryhazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Secondaryhazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Secondaryhazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.VOLUMESTANDARDCOST
		' </summary>
		Public Overridable Property Volumestandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumestandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumestandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.WEIGHTSTANDARDCOST
		' </summary>
		Public Overridable Property Weightstandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightstandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightstandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.LABELTYPE
		' </summary>
		Public Overridable Property Labeltype As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Labeltype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Labeltype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.LABELDEFAULTQTY
		' </summary>
		Public Overridable Property Labeldefaultqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Labeldefaultqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Labeldefaultqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CHEMICALCOLOR
		' </summary>
		Public Overridable Property Chemicalcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalcolor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalcolor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CHEMICALCLARITY
		' </summary>
		Public Overridable Property Chemicalclarity As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalclarity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalclarity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr1
		' </summary>
		Public Overridable Property Expr1 As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr2
		' </summary>
		Public Overridable Property Expr2 As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr3
		' </summary>
		Public Overridable Property Expr3 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.TareWeight
		' </summary>
		Public Overridable Property TareWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.TareWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.TareWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ContainerGrouping
		' </summary>
		Public Overridable Property ContainerGrouping As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.ContainerGrouping)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.ContainerGrouping, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr4
		' </summary>
		Public Overridable Property Expr4 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CHEMICALNAME
		' </summary>
		Public Overridable Property Chemicalname As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CHEMICALSTATUS
		' </summary>
		Public Overridable Property Chemicalstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CONTAINERLABELTYPE
		' </summary>
		Public Overridable Property Containerlabeltype As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Containerlabeltype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Containerlabeltype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.SDSFILEPATH
		' </summary>
		Public Overridable Property Sdsfilepath As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sdsfilepath)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sdsfilepath, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.pH_LOW
		' </summary>
		Public Overridable Property PHLOW As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.PHLOW)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.PHLOW, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.pH_HIGH
		' </summary>
		Public Overridable Property PHHIGH As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.PHHIGH)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.PHHIGH, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.SG_LOW
		' </summary>
		Public Overridable Property SgLow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.SgLow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.SgLow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.SG_HIGH
		' </summary>
		Public Overridable Property SgHigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.SgHigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.SgHigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DENSITY
		' </summary>
		Public Overridable Property Density As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Density)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Density, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr5
		' </summary>
		Public Overridable Property Expr5 As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr5)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr5, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr6
		' </summary>
		Public Overridable Property Expr6 As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr6)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr6, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CHEMICALSTATE
		' </summary>
		Public Overridable Property Chemicalstate As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.CHEMICALODOR
		' </summary>
		Public Overridable Property Chemicalodor As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalodor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalodor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DATETOREVIEW
		' </summary>
		Public Overridable Property Datetoreview As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Datetoreview)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Datetoreview, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DATEAPPROVED
		' </summary>
		Public Overridable Property Dateapproved As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dateapproved)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dateapproved, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DATEINVOICED
		' </summary>
		Public Overridable Property Dateinvoiced As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dateinvoiced)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dateinvoiced, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr7
		' </summary>
		Public Overridable Property Expr7 As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr7)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr7, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr8
		' </summary>
		Public Overridable Property Expr8 As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr8)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr8, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.MODIFIEDTIME
		' </summary>
		Public Overridable Property Modifiedtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifiedtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifiedtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.MODIFIEDBY
		' </summary>
		Public Overridable Property Modifiedby As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifiedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifiedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.Expr9
		' </summary>
		Public Overridable Property Expr9 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr9)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr9, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PICTOGRAM1
		' </summary>
		Public Overridable Property Pictogram1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PICTOGRAM2
		' </summary>
		Public Overridable Property Pictogram2 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PICTOGRAM3
		' </summary>
		Public Overridable Property Pictogram3 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PICTOGRAM4
		' </summary>
		Public Overridable Property Pictogram4 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.PICTOGRAM5
		' </summary>
		Public Overridable Property Pictogram5 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram5)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram5, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DANGERWORD
		' </summary>
		Public Overridable Property Dangerword As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dangerword)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dangerword, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.GHSCLASSIFICATION
		' </summary>
		Public Overridable Property Ghsclassification As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Ghsclassification)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Ghsclassification, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.HAZARDSTATEMENTS
		' </summary>
		Public Overridable Property Hazardstatements As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazardstatements)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazardstatements, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.SAFETYPRECAUTIONS
		' </summary>
		Public Overridable Property Safetyprecautions As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Safetyprecautions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Safetyprecautions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.FIRSTAIDMEASURES
		' </summary>
		Public Overridable Property Firstaidmeasures As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Firstaidmeasures)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Firstaidmeasures, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.STORAGE
		' </summary>
		Public Overridable Property Storage As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Storage)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Storage, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.DISPOSAL
		' </summary>
		Public Overridable Property Disposal As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Disposal)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Disposal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ACUTETOXICITYDERMAL
		' </summary>
		Public Overridable Property Acutetoxicitydermal As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicitydermal)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicitydermal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ACUTETOXICITYINHALATIONGAS
		' </summary>
		Public Overridable Property Acutetoxicityinhalationgas As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationgas)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationgas, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ACUTETOXICITYINHALATIONVAPOR
		' </summary>
		Public Overridable Property Acutetoxicityinhalationvapor As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationvapor)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationvapor, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ACUTETOXICITYINHALATIONDUSTMIST
		' </summary>
		Public Overridable Property Acutetoxicityinhalationdustmist As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationdustmist)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationdustmist, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ACUTETOXICITYORAL
		' </summary>
		Public Overridable Property Acutetoxicityoral As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityoral)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityoral, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.FIRESUPPLEMENTAL
		' </summary>
		Public Overridable Property Firesupplemental As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Firesupplemental)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Firesupplemental, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductChemicalGHSNoInventoryItem.ACCIDENTSUPPLEMENTAL
		' </summary>
		Public Overridable Property Accidentsupplemental As System.String
			Get
				Return MyBase.GetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Accidentsupplemental)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Accidentsupplemental, value)
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
		
			Public Sub New(ByVal entity As esViewProductChemicalGHSNoInventoryItem)
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
		  	
			Public Property Stdgallons As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Stdgallons
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdgallons = Nothing
					Else
						entity.Stdgallons = Convert.ToInt32(Value)
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
		  	
			Public Property Qtyonhand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyonhand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyonhand = Nothing
					Else
						entity.Qtyonhand = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyallocated As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyallocated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyallocated = Nothing
					Else
						entity.Qtyallocated = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyonorder As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyonorder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyonorder = Nothing
					Else
						entity.Qtyonorder = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyforsale As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyforsale
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyforsale = Nothing
					Else
						entity.Qtyforsale = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyminonhand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyminonhand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyminonhand = Nothing
					Else
						entity.Qtyminonhand = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reorderqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Reorderqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reorderqty = Nothing
					Else
						entity.Reorderqty = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Preferredvendorid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Preferredvendorid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Preferredvendorid = Nothing
					Else
						entity.Preferredvendorid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitcost = Nothing
					Else
						entity.Unitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datecostlastchanged As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Datecostlastchanged
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datecostlastchanged = Nothing
					Else
						entity.Datecostlastchanged = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Units
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Units = Nothing
					Else
						entity.Units = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Desc2 As System.String 
				Get
					Dim data_ As System.String = entity.Desc2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Desc2 = Nothing
					Else
						entity.Desc2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventoryclass As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Inventoryclass
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventoryclass = Nothing
					Else
						entity.Inventoryclass = Convert.ToInt32(Value)
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
		  	
			Public Property Custid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Custid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custid = Nothing
					Else
						entity.Custid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isliquid As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isliquid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isliquid = Nothing
					Else
						entity.Isliquid = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rawmaterialgroup As System.String 
				Get
					Dim data_ As System.String = entity.Rawmaterialgroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rawmaterialgroup = Nothing
					Else
						entity.Rawmaterialgroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventorygrouping As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Inventorygrouping
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventorygrouping = Nothing
					Else
						entity.Inventorygrouping = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightuom As System.String 
				Get
					Dim data_ As System.String = entity.Weightuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightuom = Nothing
					Else
						entity.Weightuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightunits = Nothing
					Else
						entity.Weightunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeuom As System.String 
				Get
					Dim data_ As System.String = entity.Volumeuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeuom = Nothing
					Else
						entity.Volumeuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeunits = Nothing
					Else
						entity.Volumeunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventorymethod As System.String 
				Get
					Dim data_ As System.String = entity.Inventorymethod
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventorymethod = Nothing
					Else
						entity.Inventorymethod = Convert.ToString(Value)
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
		  	
			Public Property Needstesting As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Needstesting
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Needstesting = Nothing
					Else
						entity.Needstesting = Convert.ToBoolean(Value)
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
		  	
			Public Property State As System.String 
				Get
					Dim data_ As System.String = entity.State
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.State = Nothing
					Else
						entity.State = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isinhazox As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isinhazox
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isinhazox = Nothing
					Else
						entity.Isinhazox = Convert.ToBoolean(Value)
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
		  	
			Public Property Productstatus As System.String 
				Get
					Dim data_ As System.String = entity.Productstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productstatus = Nothing
					Else
						entity.Productstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchasingnotes As System.String 
				Get
					Dim data_ As System.String = entity.Purchasingnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasingnotes = Nothing
					Else
						entity.Purchasingnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Receivingnotes As System.String 
				Get
					Dim data_ As System.String = entity.Receivingnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receivingnotes = Nothing
					Else
						entity.Receivingnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Secondaryhazclassnumber As System.String 
				Get
					Dim data_ As System.String = entity.Secondaryhazclassnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Secondaryhazclassnumber = Nothing
					Else
						entity.Secondaryhazclassnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumestandardcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumestandardcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumestandardcost = Nothing
					Else
						entity.Volumestandardcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightstandardcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightstandardcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightstandardcost = Nothing
					Else
						entity.Weightstandardcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Labeltype As System.String 
				Get
					Dim data_ As System.String = entity.Labeltype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Labeltype = Nothing
					Else
						entity.Labeltype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Labeldefaultqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Labeldefaultqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Labeldefaultqty = Nothing
					Else
						entity.Labeldefaultqty = Convert.ToInt32(Value)
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
		  	
			Public Property Expr1 As System.String 
				Get
					Dim data_ As System.String = entity.Expr1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr1 = Nothing
					Else
						entity.Expr1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr2 As System.String 
				Get
					Dim data_ As System.String = entity.Expr2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr2 = Nothing
					Else
						entity.Expr2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Expr3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr3 = Nothing
					Else
						entity.Expr3 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property TareWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TareWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TareWeight = Nothing
					Else
						entity.TareWeight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContainerGrouping As System.String 
				Get
					Dim data_ As System.String = entity.ContainerGrouping
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContainerGrouping = Nothing
					Else
						entity.ContainerGrouping = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr4 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Expr4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr4 = Nothing
					Else
						entity.Expr4 = Convert.ToInt32(Value)
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
		  	
			Public Property Expr5 As System.String 
				Get
					Dim data_ As System.String = entity.Expr5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr5 = Nothing
					Else
						entity.Expr5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr6 As System.String 
				Get
					Dim data_ As System.String = entity.Expr6
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr6 = Nothing
					Else
						entity.Expr6 = Convert.ToString(Value)
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
		  	
			Public Property Expr7 As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expr7
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr7 = Nothing
					Else
						entity.Expr7 = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr8 As System.String 
				Get
					Dim data_ As System.String = entity.Expr8
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr8 = Nothing
					Else
						entity.Expr8 = Convert.ToString(Value)
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
		  	
			Public Property Expr9 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Expr9
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr9 = Nothing
					Else
						entity.Expr9 = Convert.ToInt32(Value)
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
		  

			Private entity As esViewProductChemicalGHSNoInventoryItem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProductChemicalGHSNoInventoryItemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProductChemicalGHSNoInventoryItem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProductChemicalGHSNoInventoryItemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductChemicalGHSNoInventoryItemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Stdgallons, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Health As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Health, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Fire, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reactivity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Reactivity, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Personalprotection As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Personalprotection, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardrequired As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Placardrequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyonhand As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyonhand, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyallocated As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyallocated, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyonorder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyonorder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyforsale As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyforsale, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyminonhand As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyminonhand, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reorderqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Reorderqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Preferredvendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Preferredvendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Datecostlastchanged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Datecostlastchanged, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Desc2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Desc2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoryclass As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Isliquid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isliquid, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Rawmaterialgroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Rawmaterialgroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventorygrouping As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventorygrouping, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumeunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Inventorymethod As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventorymethod, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Phrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Phrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sgrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sgrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Needstesting As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Needstesting, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Shelflife As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Shelflife, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Packagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Packagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Idnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Idnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property State As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.State, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isinhazox As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isinhazox, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Istoxic As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Istoxic, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Productstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Purchasingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Receivingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Receivingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Secondaryhazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Secondaryhazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumestandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumestandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightstandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightstandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Labeltype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Labeltype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Labeldefaultqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Labeldefaultqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalclarity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalclarity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expr3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr3, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TareWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.TareWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ContainerGrouping As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.ContainerGrouping, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expr4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr4, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Containerlabeltype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Containerlabeltype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sdsfilepath As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sdsfilepath, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PHLOW As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.PHLOW, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PHHIGH As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.PHHIGH, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SgLow As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.SgLow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SgHigh As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.SgHigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Density As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Density, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Expr5 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr5, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expr6 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr6, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalodor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalodor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datetoreview As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Datetoreview, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateapproved As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dateapproved, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateinvoiced As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dateinvoiced, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Expr7 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr7, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Expr8 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr8, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifiedtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifiedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expr9 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr9, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram2, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram3, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram4, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogram5 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram5, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Dangerword As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dangerword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ghsclassification As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Ghsclassification, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazardstatements As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazardstatements, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Safetyprecautions As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Safetyprecautions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Firstaidmeasures As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Firstaidmeasures, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Storage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Storage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Disposal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Disposal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicitydermal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicitydermal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationgas As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationgas, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationvapor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationvapor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityinhalationdustmist As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationdustmist, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Acutetoxicityoral As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityoral, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Firesupplemental As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Firesupplemental, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Accidentsupplemental As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Accidentsupplemental, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProductChemicalGHSNoInventoryItemCollection")> _
	Partial Public Class ViewProductChemicalGHSNoInventoryItemCollection
		Inherits esViewProductChemicalGHSNoInventoryItemCollection
		Implements IEnumerable(Of ViewProductChemicalGHSNoInventoryItem)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProductChemicalGHSNoInventoryItemCollection) As List(Of ViewProductChemicalGHSNoInventoryItem)
            Dim list As List(Of ViewProductChemicalGHSNoInventoryItem) = New List(Of ViewProductChemicalGHSNoInventoryItem)
            Dim emp As ViewProductChemicalGHSNoInventoryItem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductChemicalGHSNoInventoryItemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProductChemicalGHSNoInventoryItemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProductChemicalGHSNoInventoryItem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProductChemicalGHSNoInventoryItem()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProductChemicalGHSNoInventoryItemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProductChemicalGHSNoInventoryItemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductChemicalGHSNoInventoryItemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProductChemicalGHSNoInventoryItem 
			Return CType(MyBase.AddNewEntity(), ViewProductChemicalGHSNoInventoryItem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProductChemicalGHSNoInventoryItem) Implements IEnumerable(Of ViewProductChemicalGHSNoInventoryItem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProductChemicalGHSNoInventoryItem)(Me)
        End Function
		
		Private _query As ViewProductChemicalGHSNoInventoryItemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewProductChemicalGHSNoInventoryItem' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProductChemicalGHSNoInventoryItem ()")> _
	<Serializable> _
	Partial Public Class ViewProductChemicalGHSNoInventoryItem 
		Inherits esViewProductChemicalGHSNoInventoryItem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProductChemicalGHSNoInventoryItemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProductChemicalGHSNoInventoryItemQuery

			If Me._query Is Nothing Then
				Me._query = New ViewProductChemicalGHSNoInventoryItemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProductChemicalGHSNoInventoryItemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProductChemicalGHSNoInventoryItemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductChemicalGHSNoInventoryItemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProductChemicalGHSNoInventoryItemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProductChemicalGHSNoInventoryItemQuery
		inherits esViewProductChemicalGHSNoInventoryItemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProductChemicalGHSNoInventoryItemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProductChemicalGHSNoInventoryItemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Stdweight, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Stdgallons, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Stdgallons
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Container, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Health, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Health
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Fire, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Fire
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Reactivity, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Reactivity
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Personalprotection, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Personalprotection
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dotdesc, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazmatdesc, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unline, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Placardrequired, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Placardrequired
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Classrate, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazmatid, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyonhand, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Qtyonhand
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyallocated, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Qtyallocated
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyonorder, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Qtyonorder
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyforsale, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Qtyforsale
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Qtyminonhand, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Qtyminonhand
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Reorderqty, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Reorderqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Preferredvendorid, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Preferredvendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unitcost, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Datecostlastchanged, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Datecostlastchanged
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Units, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Uom, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Desc2, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Desc2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventoryclass, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Inventoryclass
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isactive, 28, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Isactive
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Custid, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isliquid, 30, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Isliquid
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Rawmaterialgroup, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Rawmaterialgroup
			c.CharacterMaxLength = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventorygrouping, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Inventorygrouping
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightuom, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightunits, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Weightunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumeuom, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumeunits, 36, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Volumeunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Inventorymethod, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Inventorymethod
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Unnumber, 38, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Unnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Createdby, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Createdtime, 40, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifyby, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifytime, 42, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Phrangelow, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Phrangelow
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Phrangehigh, 44, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Phrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sgrangelow, 45, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Sgrangelow
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sgrangehigh, 46, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Sgrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Needstesting, 47, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Needstesting
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Shelflife, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Shelflife
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazclassnumber, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Hazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Packagegroup, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Packagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalid, 51, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Chemicalid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Idnumber, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Idnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.State, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.State
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Isinhazox, 54, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Isinhazox
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Istoxic, 55, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Istoxic
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Productstatus, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Productstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Purchasingnotes, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Purchasingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Receivingnotes, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Receivingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Secondaryhazclassnumber, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Secondaryhazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Volumestandardcost, 60, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Volumestandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Weightstandardcost, 61, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Weightstandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Labeltype, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Labeltype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Labeldefaultqty, 63, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Labeldefaultqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalcolor, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Chemicalcolor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalclarity, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Chemicalclarity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr1, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr2, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr3, 68, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr3
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.TareWeight, 69, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.TareWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.ContainerGrouping, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.ContainerGrouping
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr4, 71, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr4
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalname, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Chemicalname
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalstatus, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Chemicalstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Containerlabeltype, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Containerlabeltype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Sdsfilepath, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Sdsfilepath
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.PHLOW, 76, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.PHLOW
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.PHHIGH, 77, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.PHHIGH
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.SgLow, 78, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.SgLow
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.SgHigh, 79, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.SgHigh
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Density, 80, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Density
			c.NumericPrecision = 18
			c.NumericScale = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr5, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr5
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr6, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr6
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalstate, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Chemicalstate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Chemicalodor, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Chemicalodor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Datetoreview, 85, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Datetoreview
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dateapproved, 86, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Dateapproved
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dateinvoiced, 87, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Dateinvoiced
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr7, 88, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr7
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr8, 89, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr8
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifiedtime, 90, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Modifiedtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Modifiedby, 91, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Modifiedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Expr9, 92, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Expr9
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram1, 93, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Pictogram1
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram2, 94, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Pictogram2
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram3, 95, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Pictogram3
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram4, 96, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Pictogram4
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Pictogram5, 97, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Pictogram5
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Dangerword, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Dangerword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Ghsclassification, 99, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Ghsclassification
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Hazardstatements, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Hazardstatements
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Safetyprecautions, 101, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Safetyprecautions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Firstaidmeasures, 102, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Firstaidmeasures
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Storage, 103, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Storage
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Disposal, 104, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Disposal
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicitydermal, 105, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Acutetoxicitydermal
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationgas, 106, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Acutetoxicityinhalationgas
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationvapor, 107, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Acutetoxicityinhalationvapor
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityinhalationdustmist, 108, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Acutetoxicityinhalationdustmist
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Acutetoxicityoral, 109, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Acutetoxicityoral
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Firesupplemental, 110, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Firesupplemental
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductChemicalGHSNoInventoryItemMetadata.ColumnNames.Accidentsupplemental, 111, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductChemicalGHSNoInventoryItemMetadata.PropertyNames.Accidentsupplemental
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProductChemicalGHSNoInventoryItemMetadata
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
			 Public Const Stdgallons As String = "STDGALLONS"
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
			 Public Const Qtyonhand As String = "QTYONHAND"
			 Public Const Qtyallocated As String = "QTYALLOCATED"
			 Public Const Qtyonorder As String = "QTYONORDER"
			 Public Const Qtyforsale As String = "QTYFORSALE"
			 Public Const Qtyminonhand As String = "QTYMINONHAND"
			 Public Const Reorderqty As String = "REORDERQTY"
			 Public Const Preferredvendorid As String = "PREFERREDVENDORID"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Datecostlastchanged As String = "DATECOSTLASTCHANGED"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Desc2 As String = "DESC2"
			 Public Const Inventoryclass As String = "INVENTORYCLASS"
			 Public Const Isactive As String = "ISACTIVE"
			 Public Const Custid As String = "CUSTID"
			 Public Const Isliquid As String = "ISLIQUID"
			 Public Const Rawmaterialgroup As String = "RAWMATERIALGROUP"
			 Public Const Inventorygrouping As String = "INVENTORYGROUPING"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Weightunits As String = "WEIGHTUNITS"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Volumeunits As String = "VOLUMEUNITS"
			 Public Const Inventorymethod As String = "INVENTORYMETHOD"
			 Public Const Unnumber As String = "UNNUMBER"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Phrangelow As String = "PHRANGELOW"
			 Public Const Phrangehigh As String = "PHRANGEHIGH"
			 Public Const Sgrangelow As String = "SGRANGELOW"
			 Public Const Sgrangehigh As String = "SGRANGEHIGH"
			 Public Const Needstesting As String = "NEEDSTESTING"
			 Public Const Shelflife As String = "SHELFLIFE"
			 Public Const Hazclassnumber As String = "HAZCLASSNUMBER"
			 Public Const Packagegroup As String = "PACKAGEGROUP"
			 Public Const Chemicalid As String = "CHEMICALID"
			 Public Const Idnumber As String = "IDNUMBER"
			 Public Const State As String = "STATE"
			 Public Const Isinhazox As String = "ISINHAZOX"
			 Public Const Istoxic As String = "ISTOXIC"
			 Public Const Productstatus As String = "PRODUCTSTATUS"
			 Public Const Purchasingnotes As String = "PURCHASINGNOTES"
			 Public Const Receivingnotes As String = "RECEIVINGNOTES"
			 Public Const Secondaryhazclassnumber As String = "SECONDARYHAZCLASSNUMBER"
			 Public Const Volumestandardcost As String = "VOLUMESTANDARDCOST"
			 Public Const Weightstandardcost As String = "WEIGHTSTANDARDCOST"
			 Public Const Labeltype As String = "LABELTYPE"
			 Public Const Labeldefaultqty As String = "LABELDEFAULTQTY"
			 Public Const Chemicalcolor As String = "CHEMICALCOLOR"
			 Public Const Chemicalclarity As String = "CHEMICALCLARITY"
			 Public Const Expr1 As String = "Expr1"
			 Public Const Expr2 As String = "Expr2"
			 Public Const Expr3 As String = "Expr3"
			 Public Const TareWeight As String = "TareWeight"
			 Public Const ContainerGrouping As String = "ContainerGrouping"
			 Public Const Expr4 As String = "Expr4"
			 Public Const Chemicalname As String = "CHEMICALNAME"
			 Public Const Chemicalstatus As String = "CHEMICALSTATUS"
			 Public Const Containerlabeltype As String = "CONTAINERLABELTYPE"
			 Public Const Sdsfilepath As String = "SDSFILEPATH"
			 Public Const PHLOW As String = "pH_LOW"
			 Public Const PHHIGH As String = "pH_HIGH"
			 Public Const SgLow As String = "SG_LOW"
			 Public Const SgHigh As String = "SG_HIGH"
			 Public Const Density As String = "DENSITY"
			 Public Const Expr5 As String = "Expr5"
			 Public Const Expr6 As String = "Expr6"
			 Public Const Chemicalstate As String = "CHEMICALSTATE"
			 Public Const Chemicalodor As String = "CHEMICALODOR"
			 Public Const Datetoreview As String = "DATETOREVIEW"
			 Public Const Dateapproved As String = "DATEAPPROVED"
			 Public Const Dateinvoiced As String = "DATEINVOICED"
			 Public Const Expr7 As String = "Expr7"
			 Public Const Expr8 As String = "Expr8"
			 Public Const Modifiedtime As String = "MODIFIEDTIME"
			 Public Const Modifiedby As String = "MODIFIEDBY"
			 Public Const Expr9 As String = "Expr9"
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
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Stdgallons As String = "Stdgallons"
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
			 Public Const Qtyonhand As String = "Qtyonhand"
			 Public Const Qtyallocated As String = "Qtyallocated"
			 Public Const Qtyonorder As String = "Qtyonorder"
			 Public Const Qtyforsale As String = "Qtyforsale"
			 Public Const Qtyminonhand As String = "Qtyminonhand"
			 Public Const Reorderqty As String = "Reorderqty"
			 Public Const Preferredvendorid As String = "Preferredvendorid"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Datecostlastchanged As String = "Datecostlastchanged"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Desc2 As String = "Desc2"
			 Public Const Inventoryclass As String = "Inventoryclass"
			 Public Const Isactive As String = "Isactive"
			 Public Const Custid As String = "Custid"
			 Public Const Isliquid As String = "Isliquid"
			 Public Const Rawmaterialgroup As String = "Rawmaterialgroup"
			 Public Const Inventorygrouping As String = "Inventorygrouping"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Weightunits As String = "Weightunits"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Volumeunits As String = "Volumeunits"
			 Public Const Inventorymethod As String = "Inventorymethod"
			 Public Const Unnumber As String = "Unnumber"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Phrangelow As String = "Phrangelow"
			 Public Const Phrangehigh As String = "Phrangehigh"
			 Public Const Sgrangelow As String = "Sgrangelow"
			 Public Const Sgrangehigh As String = "Sgrangehigh"
			 Public Const Needstesting As String = "Needstesting"
			 Public Const Shelflife As String = "Shelflife"
			 Public Const Hazclassnumber As String = "Hazclassnumber"
			 Public Const Packagegroup As String = "Packagegroup"
			 Public Const Chemicalid As String = "Chemicalid"
			 Public Const Idnumber As String = "Idnumber"
			 Public Const State As String = "State"
			 Public Const Isinhazox As String = "Isinhazox"
			 Public Const Istoxic As String = "Istoxic"
			 Public Const Productstatus As String = "Productstatus"
			 Public Const Purchasingnotes As String = "Purchasingnotes"
			 Public Const Receivingnotes As String = "Receivingnotes"
			 Public Const Secondaryhazclassnumber As String = "Secondaryhazclassnumber"
			 Public Const Volumestandardcost As String = "Volumestandardcost"
			 Public Const Weightstandardcost As String = "Weightstandardcost"
			 Public Const Labeltype As String = "Labeltype"
			 Public Const Labeldefaultqty As String = "Labeldefaultqty"
			 Public Const Chemicalcolor As String = "Chemicalcolor"
			 Public Const Chemicalclarity As String = "Chemicalclarity"
			 Public Const Expr1 As String = "Expr1"
			 Public Const Expr2 As String = "Expr2"
			 Public Const Expr3 As String = "Expr3"
			 Public Const TareWeight As String = "TareWeight"
			 Public Const ContainerGrouping As String = "ContainerGrouping"
			 Public Const Expr4 As String = "Expr4"
			 Public Const Chemicalname As String = "Chemicalname"
			 Public Const Chemicalstatus As String = "Chemicalstatus"
			 Public Const Containerlabeltype As String = "Containerlabeltype"
			 Public Const Sdsfilepath As String = "Sdsfilepath"
			 Public Const PHLOW As String = "PHLOW"
			 Public Const PHHIGH As String = "PHHIGH"
			 Public Const SgLow As String = "SgLow"
			 Public Const SgHigh As String = "SgHigh"
			 Public Const Density As String = "Density"
			 Public Const Expr5 As String = "Expr5"
			 Public Const Expr6 As String = "Expr6"
			 Public Const Chemicalstate As String = "Chemicalstate"
			 Public Const Chemicalodor As String = "Chemicalodor"
			 Public Const Datetoreview As String = "Datetoreview"
			 Public Const Dateapproved As String = "Dateapproved"
			 Public Const Dateinvoiced As String = "Dateinvoiced"
			 Public Const Expr7 As String = "Expr7"
			 Public Const Expr8 As String = "Expr8"
			 Public Const Modifiedtime As String = "Modifiedtime"
			 Public Const Modifiedby As String = "Modifiedby"
			 Public Const Expr9 As String = "Expr9"
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
            SyncLock GetType(ViewProductChemicalGHSNoInventoryItemMetadata)
			
				If ViewProductChemicalGHSNoInventoryItemMetadata.mapDelegates Is Nothing Then
					ViewProductChemicalGHSNoInventoryItemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProductChemicalGHSNoInventoryItemMetadata._meta Is Nothing Then
                    ViewProductChemicalGHSNoInventoryItemMetadata._meta = New ViewProductChemicalGHSNoInventoryItemMetadata()
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
				meta.AddTypeMap("Stdgallons", new esTypeMap("int", "System.Int32"))
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
				meta.AddTypeMap("Qtyonhand", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyallocated", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyonorder", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyforsale", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyminonhand", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Reorderqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Preferredvendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Datecostlastchanged", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Desc2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventoryclass", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Isliquid", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Rawmaterialgroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventorygrouping", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumeunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Inventorymethod", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Phrangelow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phrangehigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgrangelow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgrangehigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Needstesting", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Shelflife", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Packagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Idnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("State", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isinhazox", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Istoxic", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Productstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchasingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Receivingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Secondaryhazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumestandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightstandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Labeltype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Labeldefaultqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalcolor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalclarity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expr2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expr3", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TareWeight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ContainerGrouping", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expr4", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Containerlabeltype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sdsfilepath", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PHLOW", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PHHIGH", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("SgLow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("SgHigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Density", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Expr5", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expr6", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalodor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datetoreview", new esTypeMap("date", "System.DateTime"))
				meta.AddTypeMap("Dateapproved", new esTypeMap("date", "System.DateTime"))
				meta.AddTypeMap("Dateinvoiced", new esTypeMap("date", "System.DateTime"))
				meta.AddTypeMap("Expr7", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Expr8", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifiedtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifiedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expr9", new esTypeMap("int", "System.Int32"))
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
				
				
				 
				meta.Source = "viewProductChemicalGHSNoInventoryItem"
				meta.Destination = "viewProductChemicalGHSNoInventoryItem"
				
				meta.spInsert = "proc_viewProductChemicalGHSNoInventoryItemInsert"
				meta.spUpdate = "proc_viewProductChemicalGHSNoInventoryItemUpdate"
				meta.spDelete = "proc_viewProductChemicalGHSNoInventoryItemDelete"
				meta.spLoadAll = "proc_viewProductChemicalGHSNoInventoryItemLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProductChemicalGHSNoInventoryItemLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProductChemicalGHSNoInventoryItemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
