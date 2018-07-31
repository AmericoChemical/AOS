'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/13/2015 10:26:11 PM
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
    Public MustInherit Class esInvitemCollection
        Inherits esEntityCollection

        Public Sub New()

        End Sub

        Protected Overrides Function GetCollectionName() As String
            Return "InvitemCollection"
        End Function

#Region "Query Logic"

        Protected Sub InitQuery(ByVal query As esInvitemQuery)
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
            Me.InitQuery(CType(query, esInvitemQuery))
        End Sub

#End Region

        Public Overloads Function DetachEntity(ByVal entity As Invitem) As Invitem
            Return CType(MyBase.DetachEntity(entity), Invitem)
        End Function

        Public Overloads Function AttachEntity(ByVal entity As Invitem) As Invitem
            Return CType(MyBase.AttachEntity(entity), Invitem)
        End Function

        Public Overloads Sub Combine(ByVal collection As InvitemCollection)
            MyBase.Combine(collection)
        End Sub

        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Invitem
            Get
                Return TryCast(MyBase.Item(index), Invitem)
            End Get
        End Property

        Public Overrides Function GetEntityType() As Type
            Return GetType(Invitem)
        End Function

    End Class



    <Serializable()> _
    Public MustInherit Class esInvitem
        Inherits esEntity

        Protected Overridable Function GetDynamicQuery() As esInvitemQuery
            Return Nothing
        End Function

        Public Sub New()
        End Sub

        Public Sub New(ByVal row As DataRow)
            MyBase.New(row)
        End Sub

#Region "LoadByPrimaryKey"
        Public Overridable Function LoadByPrimaryKey(ByVal invitemnumber As System.Int32) As Boolean

            If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic(invitemnumber)
            Else
                Return LoadByPrimaryKeyStoredProcedure(invitemnumber)
            End If

        End Function

        Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal invitemnumber As System.Int32) As Boolean

            If sqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic(invitemnumber)
            Else
                Return LoadByPrimaryKeyStoredProcedure(invitemnumber)
            End If

        End Function

        Private Function LoadByPrimaryKeyDynamic(ByVal invitemnumber As System.Int32) As Boolean

            Dim query As esInvitemQuery = Me.GetDynamicQuery()
            query.Where(query.Invitemnumber.Equal(invitemnumber))
            Return query.Load()

        End Function

        Private Function LoadByPrimaryKeyStoredProcedure(ByVal invitemnumber As System.Int32) As Boolean

            Dim parms As esParameters = New esParameters()
            parms.Add("INVITEMNUMBER", invitemnumber)

            Return Me.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)

        End Function
#End Region


#Region "Properties"

        Public Overrides Sub SetProperties(values As IDictionary)

            Dim propertyName As String
            For Each propertyName In values.Keys
                Me.SetProperty(propertyName, values(propertyName))
            Next

        End Sub

        Public Overrides Sub SetProperty(name As String, value As Object)

            If Me.Row Is Nothing Then
                Me.AddNew()
            End If

            Dim col As esColumnMetadata = Me.Meta.Columns.FindByPropertyName(name)
            If Not col Is Nothing Then

                If value Is Nothing OrElse value.GetType().ToString() = "System.String" Then

                    ' Use the strongly typed property
                    Select Case name

                        Case "Invitemnumber"
                            Me.str.Invitemnumber = CType(value, String)

                        Case "Productid"
                            Me.str.Productid = CType(value, String)

                        Case "Productdesc"
                            Me.str.Productdesc = CType(value, String)

                        Case "Container"
                            Me.str.Container = CType(value, String)

                        Case "Unitcost"
                            Me.str.Unitcost = CType(value, String)

                        Case "Uom"
                            Me.str.Uom = CType(value, String)

                        Case "Unitsremaining"
                            Me.str.Unitsremaining = CType(value, String)

                        Case "Lotnumber"
                            Me.str.Lotnumber = CType(value, String)

                        Case "Note"
                            Me.str.Note = CType(value, String)

                        Case "Itemstatus"
                            Me.str.Itemstatus = CType(value, String)

                        Case "Receivernumber"
                            Me.str.Receivernumber = CType(value, String)

                        Case "Receiveddate"
                            Me.str.Receiveddate = CType(value, String)

                        Case "Allocateddocument"
                            Me.str.Allocateddocument = CType(value, String)

                        Case "Allocateddate"
                            Me.str.Allocateddate = CType(value, String)

                        Case "Workordernumber"
                            Me.str.Workordernumber = CType(value, String)

                        Case "Shipmentnumber"
                            Me.str.Shipmentnumber = CType(value, String)

                        Case "Shippeddate"
                            Me.str.Shippeddate = CType(value, String)

                        Case "Warehousenumber"
                            Me.str.Warehousenumber = CType(value, String)

                        Case "Warehouselocation"
                            Me.str.Warehouselocation = CType(value, String)

                        Case "Inventoryclass"
                            Me.str.Inventoryclass = CType(value, String)

                        Case "Testsamplekey"
                            Me.str.Testsamplekey = CType(value, String)

                        Case "Actualcostunits"
                            Me.str.Actualcostunits = CType(value, String)

                        Case "Actualcostuom"
                            Me.str.Actualcostuom = CType(value, String)

                        Case "Actualunitcost"
                            Me.str.Actualunitcost = CType(value, String)

                        Case "Sourcedocument"
                            Me.str.Sourcedocument = CType(value, String)

                        Case "Sourcetype"
                            Me.str.Sourcetype = CType(value, String)

                        Case "Vendorweight"
                            Me.str.Vendorweight = CType(value, String)

                        Case "Unitsremainingvolume"
                            Me.str.Unitsremainingvolume = CType(value, String)

                        Case "Unitsremainingweight"
                            Me.str.Unitsremainingweight = CType(value, String)

                        Case "Ph"
                            Me.str.Ph = CType(value, String)

                        Case "Sg"
                            Me.str.Sg = CType(value, String)

                        Case "Color"
                            Me.str.Color = CType(value, String)

                        Case "Rcvdweight"
                            Me.str.Rcvdweight = CType(value, String)

                        Case "Allocatedtype"
                            Me.str.Allocatedtype = CType(value, String)

                    End Select

                Else

                    Select Case name

                        Case "Invitemnumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Productid"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Productid = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Unitcost"

                            If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
                                Me.Unitcost = CType(value, Nullable(Of System.Decimal))
                            End If

                        Case "Unitsremaining"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.Unitsremaining = CType(value, Nullable(Of System.Double))
                            End If

                        Case "Receivernumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Receivernumber = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Receiveddate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.Receiveddate = CType(value, Nullable(Of System.DateTime))
                            End If

                        Case "Allocateddate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.Allocateddate = CType(value, Nullable(Of System.DateTime))
                            End If

                        Case "Workordernumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Workordernumber = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Shipmentnumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Shipmentnumber = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Shippeddate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.Shippeddate = CType(value, Nullable(Of System.DateTime))
                            End If

                        Case "Warehousenumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Warehousenumber = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Inventoryclass"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Testsamplekey"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Testsamplekey = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Actualcostunits"

                            If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
                                Me.Actualcostunits = CType(value, Nullable(Of System.Decimal))
                            End If

                        Case "Actualunitcost"

                            If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
                                Me.Actualunitcost = CType(value, Nullable(Of System.Decimal))
                            End If

                        Case "Sourcedocument"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Vendorweight"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Vendorweight = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Unitsremainingvolume"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Unitsremainingvolume = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Unitsremainingweight"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Unitsremainingweight = CType(value, Nullable(Of System.Int32))
                            End If

                        Case "Ph"

                            If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
                                Me.Ph = CType(value, Nullable(Of System.Decimal))
                            End If

                        Case "Sg"

                            If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
                                Me.Sg = CType(value, Nullable(Of System.Decimal))
                            End If

                        Case "Rcvdweight"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Rcvdweight = CType(value, Nullable(Of System.Int32))
                            End If


                        Case Else

                    End Select
                End If

            ElseIf Me.Row.Table.Columns.Contains(name) Then
                Me.Row(name) = value
            Else
                Throw New Exception("SetProperty Error: '" + name + "' not found")
            End If

        End Sub


        ' <summary>
        ' Maps to INVITEM.INVITEMNUMBER
        ' </summary>
        Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Invitemnumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Invitemnumber, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.PRODUCTID
        ' </summary>
        Public Overridable Property Productid As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Productid)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Productid, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.PRODUCTDESC
        ' </summary>
        Public Overridable Property Productdesc As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Productdesc)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Productdesc, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.CONTAINER
        ' </summary>
        Public Overridable Property Container As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Container)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Container, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.UNITCOST
        ' </summary>
        Public Overridable Property Unitcost As Nullable(Of System.Decimal)
            Get
                Return MyBase.GetSystemDecimal(InvitemMetadata.ColumnNames.Unitcost)
            End Get

            Set(ByVal value As Nullable(Of System.Decimal))
                MyBase.SetSystemDecimal(InvitemMetadata.ColumnNames.Unitcost, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.UOM
        ' </summary>
        Public Overridable Property Uom As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Uom)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Uom, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.UNITSREMAINING
        ' </summary>
        Public Overridable Property Unitsremaining As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(InvitemMetadata.ColumnNames.Unitsremaining)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                MyBase.SetSystemDouble(InvitemMetadata.ColumnNames.Unitsremaining, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.LOTNUMBER
        ' </summary>
        Public Overridable Property Lotnumber As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Lotnumber)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Lotnumber, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.NOTE
        ' </summary>
        Public Overridable Property Note As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Note)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Note, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.ITEMSTATUS
        ' </summary>
        Public Overridable Property Itemstatus As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Itemstatus)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Itemstatus, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.RECEIVERNUMBER
        ' </summary>
        Public Overridable Property Receivernumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Receivernumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Receivernumber, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.RECEIVEDDATE
        ' </summary>
        Public Overridable Property Receiveddate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(InvitemMetadata.ColumnNames.Receiveddate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                MyBase.SetSystemDateTime(InvitemMetadata.ColumnNames.Receiveddate, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.ALLOCATEDDOCUMENT
        ' </summary>
        Public Overridable Property Allocateddocument As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Allocateddocument)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Allocateddocument, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.ALLOCATEDDATE
        ' </summary>
        Public Overridable Property Allocateddate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(InvitemMetadata.ColumnNames.Allocateddate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                MyBase.SetSystemDateTime(InvitemMetadata.ColumnNames.Allocateddate, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.WORKORDERNUMBER
        ' </summary>
        Public Overridable Property Workordernumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Workordernumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Workordernumber, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.SHIPMENTNUMBER
        ' </summary>
        Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Shipmentnumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Shipmentnumber, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.SHIPPEDDATE
        ' </summary>
        Public Overridable Property Shippeddate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(InvitemMetadata.ColumnNames.Shippeddate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                MyBase.SetSystemDateTime(InvitemMetadata.ColumnNames.Shippeddate, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.WAREHOUSENUMBER
        ' </summary>
        Public Overridable Property Warehousenumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Warehousenumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Warehousenumber, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.WAREHOUSELOCATION
        ' </summary>
        Public Overridable Property Warehouselocation As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Warehouselocation)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Warehouselocation, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.INVENTORYCLASS
        ' </summary>
        Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Inventoryclass)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Inventoryclass, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.TESTSAMPLEKEY
        ' </summary>
        Public Overridable Property Testsamplekey As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Testsamplekey)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Testsamplekey, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.ACTUALCOSTUNITS
        ' </summary>
        Public Overridable Property Actualcostunits As Nullable(Of System.Decimal)
            Get
                Return MyBase.GetSystemDecimal(InvitemMetadata.ColumnNames.Actualcostunits)
            End Get

            Set(ByVal value As Nullable(Of System.Decimal))
                MyBase.SetSystemDecimal(InvitemMetadata.ColumnNames.Actualcostunits, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.ACTUALCOSTUOM
        ' </summary>
        Public Overridable Property Actualcostuom As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Actualcostuom)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Actualcostuom, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.ACTUALUNITCOST
        ' </summary>
        Public Overridable Property Actualunitcost As Nullable(Of System.Decimal)
            Get
                Return MyBase.GetSystemDecimal(InvitemMetadata.ColumnNames.Actualunitcost)
            End Get

            Set(ByVal value As Nullable(Of System.Decimal))
                MyBase.SetSystemDecimal(InvitemMetadata.ColumnNames.Actualunitcost, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.SOURCEDOCUMENT
        ' </summary>
        Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Sourcedocument)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Sourcedocument, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.SOURCETYPE
        ' </summary>
        Public Overridable Property Sourcetype As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Sourcetype)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Sourcetype, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.VENDORWEIGHT
        ' </summary>
        Public Overridable Property Vendorweight As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Vendorweight)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Vendorweight, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.UNITSREMAININGVOLUME
        ' </summary>
        Public Overridable Property Unitsremainingvolume As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Unitsremainingvolume)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Unitsremainingvolume, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.UNITSREMAININGWEIGHT
        ' </summary>
        Public Overridable Property Unitsremainingweight As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Unitsremainingweight)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Unitsremainingweight, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.PH
        ' </summary>
        Public Overridable Property Ph As Nullable(Of System.Decimal)
            Get
                Return MyBase.GetSystemDecimal(InvitemMetadata.ColumnNames.Ph)
            End Get

            Set(ByVal value As Nullable(Of System.Decimal))
                MyBase.SetSystemDecimal(InvitemMetadata.ColumnNames.Ph, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.SG
        ' </summary>
        Public Overridable Property Sg As Nullable(Of System.Decimal)
            Get
                Return MyBase.GetSystemDecimal(InvitemMetadata.ColumnNames.Sg)
            End Get

            Set(ByVal value As Nullable(Of System.Decimal))
                MyBase.SetSystemDecimal(InvitemMetadata.ColumnNames.Sg, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.COLOR
        ' </summary>
        Public Overridable Property Color As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Color)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Color, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.RCVDWEIGHT
        ' </summary>
        Public Overridable Property Rcvdweight As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(InvitemMetadata.ColumnNames.Rcvdweight)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                MyBase.SetSystemInt32(InvitemMetadata.ColumnNames.Rcvdweight, value)
            End Set
        End Property

        ' <summary>
        ' Maps to INVITEM.ALLOCATEDTYPE
        ' </summary>
        Public Overridable Property Allocatedtype As System.String
            Get
                Return MyBase.GetSystemString(InvitemMetadata.ColumnNames.Allocatedtype)
            End Get

            Set(ByVal value As System.String)
                MyBase.SetSystemString(InvitemMetadata.ColumnNames.Allocatedtype, value)
            End Set
        End Property

#End Region

#Region "String Properties"


        <BrowsableAttribute(False)> _
        Public ReadOnly Property str As esStrings
            Get
                If _esstrings Is Nothing Then
                    _esstrings = New esStrings(Me)
                End If
                Return _esstrings
            End Get
        End Property


        <Serializable> _
        Public NotInheritable Class esStrings

            Public Sub New(ByVal entity As esInvitem)
                Me.entity = entity
            End Sub


            Public Property Invitemnumber As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Invitemnumber = Nothing
                    Else
                        entity.Invitemnumber = Convert.ToInt32(Value)
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

                Set(ByVal Value As System.String)
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

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
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

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Container = Nothing
                    Else
                        entity.Container = Convert.ToString(Value)
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

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Unitcost = Nothing
                    Else
                        entity.Unitcost = Convert.ToDecimal(Value)
                    End If
                End Set
            End Property

            Public Property Uom As System.String
                Get
                    Dim data_ As System.String = entity.Uom

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Uom = Nothing
                    Else
                        entity.Uom = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Unitsremaining As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.Unitsremaining

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Unitsremaining = Nothing
                    Else
                        entity.Unitsremaining = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property Lotnumber As System.String
                Get
                    Dim data_ As System.String = entity.Lotnumber

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Lotnumber = Nothing
                    Else
                        entity.Lotnumber = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Note As System.String
                Get
                    Dim data_ As System.String = entity.Note

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Note = Nothing
                    Else
                        entity.Note = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Itemstatus As System.String
                Get
                    Dim data_ As System.String = entity.Itemstatus

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Itemstatus = Nothing
                    Else
                        entity.Itemstatus = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Receivernumber As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Receivernumber

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Receivernumber = Nothing
                    Else
                        entity.Receivernumber = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Receiveddate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.Receiveddate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Receiveddate = Nothing
                    Else
                        entity.Receiveddate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property Allocateddocument As System.String
                Get
                    Dim data_ As System.String = entity.Allocateddocument

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Allocateddocument = Nothing
                    Else
                        entity.Allocateddocument = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Allocateddate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.Allocateddate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Allocateddate = Nothing
                    Else
                        entity.Allocateddate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property Workordernumber As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Workordernumber

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Workordernumber = Nothing
                    Else
                        entity.Workordernumber = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Shipmentnumber As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Shipmentnumber

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Shipmentnumber = Nothing
                    Else
                        entity.Shipmentnumber = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Shippeddate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.Shippeddate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Shippeddate = Nothing
                    Else
                        entity.Shippeddate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property Warehousenumber As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Warehousenumber

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Warehousenumber = Nothing
                    Else
                        entity.Warehousenumber = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Warehouselocation As System.String
                Get
                    Dim data_ As System.String = entity.Warehouselocation

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Warehouselocation = Nothing
                    Else
                        entity.Warehouselocation = Convert.ToString(Value)
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

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Inventoryclass = Nothing
                    Else
                        entity.Inventoryclass = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Testsamplekey As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Testsamplekey

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Testsamplekey = Nothing
                    Else
                        entity.Testsamplekey = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Actualcostunits As System.String
                Get
                    Dim data_ As Nullable(Of System.Decimal) = entity.Actualcostunits

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Actualcostunits = Nothing
                    Else
                        entity.Actualcostunits = Convert.ToDecimal(Value)
                    End If
                End Set
            End Property

            Public Property Actualcostuom As System.String
                Get
                    Dim data_ As System.String = entity.Actualcostuom

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Actualcostuom = Nothing
                    Else
                        entity.Actualcostuom = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Actualunitcost As System.String
                Get
                    Dim data_ As Nullable(Of System.Decimal) = entity.Actualunitcost

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Actualunitcost = Nothing
                    Else
                        entity.Actualunitcost = Convert.ToDecimal(Value)
                    End If
                End Set
            End Property

            Public Property Sourcedocument As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Sourcedocument

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Sourcedocument = Nothing
                    Else
                        entity.Sourcedocument = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Sourcetype As System.String
                Get
                    Dim data_ As System.String = entity.Sourcetype

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Sourcetype = Nothing
                    Else
                        entity.Sourcetype = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Vendorweight As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Vendorweight

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Vendorweight = Nothing
                    Else
                        entity.Vendorweight = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Unitsremainingvolume As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Unitsremainingvolume

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Unitsremainingvolume = Nothing
                    Else
                        entity.Unitsremainingvolume = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Unitsremainingweight As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Unitsremainingweight

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Unitsremainingweight = Nothing
                    Else
                        entity.Unitsremainingweight = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Ph As System.String
                Get
                    Dim data_ As Nullable(Of System.Decimal) = entity.Ph

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Ph = Nothing
                    Else
                        entity.Ph = Convert.ToDecimal(Value)
                    End If
                End Set
            End Property

            Public Property Sg As System.String
                Get
                    Dim data_ As Nullable(Of System.Decimal) = entity.Sg

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Sg = Nothing
                    Else
                        entity.Sg = Convert.ToDecimal(Value)
                    End If
                End Set
            End Property

            Public Property Color As System.String
                Get
                    Dim data_ As System.String = entity.Color

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Color = Nothing
                    Else
                        entity.Color = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Rcvdweight As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Rcvdweight

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Rcvdweight = Nothing
                    Else
                        entity.Rcvdweight = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Allocatedtype As System.String
                Get
                    Dim data_ As System.String = entity.Allocatedtype

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Allocatedtype = Nothing
                    Else
                        entity.Allocatedtype = Convert.ToString(Value)
                    End If
                End Set
            End Property


            Private entity As esInvitem
        End Class
#End Region

#Region "Query Logic"

        Protected Sub InitQuery(ByVal query As esInvitemQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded
            query.es2.Connection = CType(Me, IEntity).Connection
        End Sub

        <System.Diagnostics.DebuggerNonUserCode> _
        Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
            Dim dataFound As Boolean = Me.PopulateEntity(table)

            If Me.RowCount > 1 Then
                Throw New Exception("esInvitem can only hold one record of data")
            End If

            Return dataFound
        End Function

#End Region


        <NonSerialized()> _
        Private _esstrings As esStrings
    End Class



    Partial Public Class Invitem
        Inherits esInvitem



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
    Public MustInherit Class esInvitemQuery
        Inherits esDynamicQuery

        Protected Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return InvitemMetadata.Meta()
            End Get
        End Property


        Public ReadOnly Property Invitemnumber As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Productid As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Productid, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Productdesc As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Productdesc, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Container As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Container, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Unitcost As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
            End Get
        End Property

        Public ReadOnly Property Uom As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Uom, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Unitsremaining As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Unitsremaining, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property Lotnumber As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Lotnumber, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Note As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Note, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Itemstatus As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Itemstatus, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Receivernumber As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Receivernumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Receiveddate As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Receiveddate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property Allocateddocument As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Allocateddocument, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Allocateddate As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Allocateddate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property Workordernumber As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Shipmentnumber As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Shippeddate As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Shippeddate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property Warehousenumber As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Warehousenumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Warehouselocation As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Warehouselocation, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Inventoryclass As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Testsamplekey As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Testsamplekey, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Actualcostunits As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Actualcostunits, esSystemType.Decimal)
            End Get
        End Property

        Public ReadOnly Property Actualcostuom As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Actualcostuom, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Actualunitcost As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Actualunitcost, esSystemType.Decimal)
            End Get
        End Property

        Public ReadOnly Property Sourcedocument As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Sourcetype As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Sourcetype, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Vendorweight As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Vendorweight, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Unitsremainingvolume As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Unitsremainingvolume, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Unitsremainingweight As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Unitsremainingweight, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Ph As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Ph, esSystemType.Decimal)
            End Get
        End Property

        Public ReadOnly Property Sg As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Sg, esSystemType.Decimal)
            End Get
        End Property

        Public ReadOnly Property Color As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Color, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Rcvdweight As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Rcvdweight, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Allocatedtype As esQueryItem
            Get
                Return New esQueryItem(Me, InvitemMetadata.ColumnNames.Allocatedtype, esSystemType.String)
            End Get
        End Property

    End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
    <Serializable> _
    <XmlType("InvitemCollection")> _
       Partial Public Class InvitemCollection
        Inherits esInvitemCollection
        Implements IEnumerable(Of Invitem)

        Public Shared Widening Operator CType(ByVal coll As InvitemCollection) As List(Of Invitem)
            Dim list As List(Of Invitem) = New List(Of Invitem)
            Dim emp As Invitem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator

#Region "Housekeeping methods"
        Protected Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return InvitemMetadata.Meta()
            End Get
        End Property



        Protected Overrides Function GetDynamicQuery() As esDynamicQuery

            If Me._query Is Nothing Then
                Me._query = New InvitemQuery()
                Me.InitQuery(_query)
            End If

            Return Me._query
        End Function

        Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
            Return New Invitem(row)
        End Function

        Protected Overrides Function CreateEntity() As esEntity
            Return New Invitem()
        End Function


#End Region

        Public ReadOnly Property Query As InvitemQuery
            Get
                If Me._query Is Nothing Then
                    Me._query = New InvitemQuery()
                    Me.InitQuery(_query)
                End If

                Return Me._query
            End Get
        End Property

        Public Sub QueryReset()
            Me._query = Nothing
        End Sub

        Public Shadows Function Load(ByVal query As InvitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
        End Function

        Public Function AddNew() As Invitem
            Return CType(MyBase.AddNewEntity(), Invitem)
        End Function

        Public Overloads Function FindByPrimaryKey(ByVal invitemnumber As System.Int32) As Invitem
            Return CType(MyBase.FindByPrimaryKey(invitemnumber), Invitem)
        End Function

        Function GetEnumerator() As IEnumerator(Of Invitem) Implements IEnumerable(Of Invitem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Invitem)(Me)
        End Function

        Private _query As InvitemQuery

    End Class



    ' <summary>
    ' Encapsulates the 'INVITEM' table
    ' </summary>

    <System.Diagnostics.DebuggerDisplay("Invitem ({Invitemnumber.Value})")> _
    <Serializable> _
       Partial Public Class Invitem
        Inherits esInvitem

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal row As DataRow)
            MyBase.New(row)
        End Sub

#Region "Housekeeping methods"
        Protected Overrides ReadOnly Property Meta As IMetadata
            Get
                Return InvitemMetadata.Meta()
            End Get
        End Property



        Protected Overrides Function GetDynamicQuery() As esInvitemQuery

            If Me._query Is Nothing Then
                Me._query = New InvitemQuery()
                Me.InitQuery(_query)
            End If

            Return Me._query
        End Function
#End Region




        <BrowsableAttribute(False)> _
        Public ReadOnly Property Query As InvitemQuery
            Get

                If Me._query Is Nothing Then
                    Me._query = New InvitemQuery()
                    Me.InitQuery(_query)
                End If

                Return Me._query
            End Get
        End Property

        Public Sub QueryReset()
            Me._query = Nothing
        End Sub

        Public Shadows Function Load(ByVal query As InvitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
        End Function

        Private _query As InvitemQuery

    End Class





    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
    <Serializable> _
       Partial Public Class InvitemQuery
        Inherits esInvitemQuery

        Public Sub New(ByVal joinAlias As String)
            Me.es.JoinAlias = joinAlias
        End Sub

        Protected Overrides Function GetQueryName() As String
            Return "InvitemQuery"
        End Function



    End Class



    <Serializable> _
    Partial Public Class InvitemMetadata
        Inherits esMetadata
        Implements IMetadata

#Region "Protected Constructor"
        Protected Sub New()
            _columns = New esColumnMetadataCollection()
            Dim c As esColumnMetadata

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Invitemnumber
            c.IsInPrimaryKey = True
            c.IsAutoIncrement = True
            c.NumericPrecision = 10
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Productid
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Productdesc
            c.CharacterMaxLength = 200
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Container
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Unitcost, 4, GetType(System.Decimal), esSystemType.Decimal)
            c.PropertyName = InvitemMetadata.PropertyNames.Unitcost
            c.NumericPrecision = 19
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Uom, 5, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Uom
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Unitsremaining, 6, GetType(System.Double), esSystemType.Double)
            c.PropertyName = InvitemMetadata.PropertyNames.Unitsremaining
            c.NumericPrecision = 15
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Lotnumber, 7, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Lotnumber
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Note, 8, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Note
            c.CharacterMaxLength = 2147483647
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Itemstatus, 9, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Itemstatus
            c.CharacterMaxLength = 50
            c.HasDefault = True
            c.Default = "('AVAILABLE')"
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Receivernumber, 10, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Receivernumber
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Receiveddate, 11, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = InvitemMetadata.PropertyNames.Receiveddate
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Allocateddocument, 12, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Allocateddocument
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Allocateddate, 13, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = InvitemMetadata.PropertyNames.Allocateddate
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Workordernumber, 14, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Workordernumber
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Shipmentnumber, 15, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Shipmentnumber
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Shippeddate, 16, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = InvitemMetadata.PropertyNames.Shippeddate
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Warehousenumber, 17, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Warehousenumber
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Warehouselocation, 18, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Warehouselocation
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Inventoryclass, 19, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Inventoryclass
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Testsamplekey, 20, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Testsamplekey
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Actualcostunits, 21, GetType(System.Decimal), esSystemType.Decimal)
            c.PropertyName = InvitemMetadata.PropertyNames.Actualcostunits
            c.NumericPrecision = 18
            c.NumericScale = 2
            c.HasDefault = True
            c.Default = "((0))"
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Actualcostuom, 22, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Actualcostuom
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Actualunitcost, 23, GetType(System.Decimal), esSystemType.Decimal)
            c.PropertyName = InvitemMetadata.PropertyNames.Actualunitcost
            c.NumericPrecision = 18
            c.NumericScale = 4
            c.HasDefault = True
            c.Default = "((0))"
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Sourcedocument, 24, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Sourcedocument
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Sourcetype, 25, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Sourcetype
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Vendorweight, 26, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Vendorweight
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Unitsremainingvolume, 27, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Unitsremainingvolume
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Unitsremainingweight, 28, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Unitsremainingweight
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Ph, 29, GetType(System.Decimal), esSystemType.Decimal)
            c.PropertyName = InvitemMetadata.PropertyNames.Ph
            c.NumericPrecision = 18
            c.NumericScale = 2
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Sg, 30, GetType(System.Decimal), esSystemType.Decimal)
            c.PropertyName = InvitemMetadata.PropertyNames.Sg
            c.NumericPrecision = 18
            c.NumericScale = 3
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Color, 31, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Color
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Rcvdweight, 32, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = InvitemMetadata.PropertyNames.Rcvdweight
            c.NumericPrecision = 10
            c.IsNullable = True
            _columns.Add(c)

            c = New esColumnMetadata(InvitemMetadata.ColumnNames.Allocatedtype, 33, GetType(System.String), esSystemType.String)
            c.PropertyName = InvitemMetadata.PropertyNames.Allocatedtype
            c.CharacterMaxLength = 50
            c.IsNullable = True
            _columns.Add(c)

        End Sub
#End Region

        Public Shared Function Meta() As InvitemMetadata
            Return _meta
        End Function

        Public ReadOnly Property DataID() As System.Guid Implements IMetadata.DataID
            Get
                Return MyBase._dataID
            End Get
        End Property

        Public ReadOnly Property MultiProviderMode() As Boolean Implements IMetadata.MultiProviderMode
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property Columns() As esColumnMetadataCollection Implements IMetadata.Columns
            Get
                Return MyBase._columns
            End Get
        End Property


#Region "ColumnNames"
        Public Class ColumnNames
            Public Const Invitemnumber As String = "INVITEMNUMBER"
            Public Const Productid As String = "PRODUCTID"
            Public Const Productdesc As String = "PRODUCTDESC"
            Public Const Container As String = "CONTAINER"
            Public Const Unitcost As String = "UNITCOST"
            Public Const Uom As String = "UOM"
            Public Const Unitsremaining As String = "UNITSREMAINING"
            Public Const Lotnumber As String = "LOTNUMBER"
            Public Const Note As String = "NOTE"
            Public Const Itemstatus As String = "ITEMSTATUS"
            Public Const Receivernumber As String = "RECEIVERNUMBER"
            Public Const Receiveddate As String = "RECEIVEDDATE"
            Public Const Allocateddocument As String = "ALLOCATEDDOCUMENT"
            Public Const Allocateddate As String = "ALLOCATEDDATE"
            Public Const Workordernumber As String = "WORKORDERNUMBER"
            Public Const Shipmentnumber As String = "SHIPMENTNUMBER"
            Public Const Shippeddate As String = "SHIPPEDDATE"
            Public Const Warehousenumber As String = "WAREHOUSENUMBER"
            Public Const Warehouselocation As String = "WAREHOUSELOCATION"
            Public Const Inventoryclass As String = "INVENTORYCLASS"
            Public Const Testsamplekey As String = "TESTSAMPLEKEY"
            Public Const Actualcostunits As String = "ACTUALCOSTUNITS"
            Public Const Actualcostuom As String = "ACTUALCOSTUOM"
            Public Const Actualunitcost As String = "ACTUALUNITCOST"
            Public Const Sourcedocument As String = "SOURCEDOCUMENT"
            Public Const Sourcetype As String = "SOURCETYPE"
            Public Const Vendorweight As String = "VENDORWEIGHT"
            Public Const Unitsremainingvolume As String = "UNITSREMAININGVOLUME"
            Public Const Unitsremainingweight As String = "UNITSREMAININGWEIGHT"
            Public Const Ph As String = "PH"
            Public Const Sg As String = "SG"
            Public Const Color As String = "COLOR"
            Public Const Rcvdweight As String = "RCVDWEIGHT"
            Public Const Allocatedtype As String = "ALLOCATEDTYPE"
        End Class
#End Region

#Region "PropertyNames"
        Public Class PropertyNames
            Public Const Invitemnumber As String = "Invitemnumber"
            Public Const Productid As String = "Productid"
            Public Const Productdesc As String = "Productdesc"
            Public Const Container As String = "Container"
            Public Const Unitcost As String = "Unitcost"
            Public Const Uom As String = "Uom"
            Public Const Unitsremaining As String = "Unitsremaining"
            Public Const Lotnumber As String = "Lotnumber"
            Public Const Note As String = "Note"
            Public Const Itemstatus As String = "Itemstatus"
            Public Const Receivernumber As String = "Receivernumber"
            Public Const Receiveddate As String = "Receiveddate"
            Public Const Allocateddocument As String = "Allocateddocument"
            Public Const Allocateddate As String = "Allocateddate"
            Public Const Workordernumber As String = "Workordernumber"
            Public Const Shipmentnumber As String = "Shipmentnumber"
            Public Const Shippeddate As String = "Shippeddate"
            Public Const Warehousenumber As String = "Warehousenumber"
            Public Const Warehouselocation As String = "Warehouselocation"
            Public Const Inventoryclass As String = "Inventoryclass"
            Public Const Testsamplekey As String = "Testsamplekey"
            Public Const Actualcostunits As String = "Actualcostunits"
            Public Const Actualcostuom As String = "Actualcostuom"
            Public Const Actualunitcost As String = "Actualunitcost"
            Public Const Sourcedocument As String = "Sourcedocument"
            Public Const Sourcetype As String = "Sourcetype"
            Public Const Vendorweight As String = "Vendorweight"
            Public Const Unitsremainingvolume As String = "Unitsremainingvolume"
            Public Const Unitsremainingweight As String = "Unitsremainingweight"
            Public Const Ph As String = "Ph"
            Public Const Sg As String = "Sg"
            Public Const Color As String = "Color"
            Public Const Rcvdweight As String = "Rcvdweight"
            Public Const Allocatedtype As String = "Allocatedtype"
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
            SyncLock GetType(InvitemMetadata)

                If InvitemMetadata.mapDelegates Is Nothing Then
                    InvitemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
                End If

                If InvitemMetadata._meta Is Nothing Then
                    InvitemMetadata._meta = New InvitemMetadata()
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


                meta.AddTypeMap("Invitemnumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Productid", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Productdesc", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Container", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Unitcost", New esTypeMap("money", "System.Decimal"))
                meta.AddTypeMap("Uom", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Unitsremaining", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("Lotnumber", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Note", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Itemstatus", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Receivernumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Receiveddate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("Allocateddocument", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Allocateddate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("Workordernumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Shipmentnumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Shippeddate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("Warehousenumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Warehouselocation", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Inventoryclass", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Testsamplekey", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Actualcostunits", New esTypeMap("decimal", "System.Decimal"))
                meta.AddTypeMap("Actualcostuom", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Actualunitcost", New esTypeMap("decimal", "System.Decimal"))
                meta.AddTypeMap("Sourcedocument", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Sourcetype", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Vendorweight", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Unitsremainingvolume", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Unitsremainingweight", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Ph", New esTypeMap("decimal", "System.Decimal"))
                meta.AddTypeMap("Sg", New esTypeMap("decimal", "System.Decimal"))
                meta.AddTypeMap("Color", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("Rcvdweight", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Allocatedtype", New esTypeMap("varchar", "System.String"))



                meta.Source = "INVITEM"
                meta.Destination = "INVITEM"

                meta.spInsert = "proc_INVITEMInsert"
                meta.spUpdate = "proc_INVITEMUpdate"
                meta.spDelete = "proc_INVITEMDelete"
                meta.spLoadAll = "proc_INVITEMLoadAll"
                meta.spLoadByPrimaryKey = "proc_INVITEMLoadByPrimaryKey"

                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function

#End Region

        Private Shared _meta As InvitemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
        Private Shared _esDefault As Integer = RegisterDelegateesDefault()

    End Class

End Namespace
