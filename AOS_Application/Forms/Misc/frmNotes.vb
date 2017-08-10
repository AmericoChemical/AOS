Imports AOS.BusinessObjects

Public Class frmNotes
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vLinkType As String
    Public vLinkKey As String

    Dim oNotes As NoteCollection

    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Notes for " & vLinkType & " " & vLinkKey.ToString
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        getNotes(vLinkType, vLinkKey)
    End Sub

    Private Sub getNotes(vLinkType As String, vLinkKey As Integer)
        oNotes = New NoteCollection
        oNotes.Query.Where(oNotes.Query.LinkType.Equal(vLinkType), oNotes.Query.LinkKey.Equal(vLinkKey), oNotes.Query.IsDeleted.Equal(0))
        oNotes.Query.Load()
        bsNotes.DataSource = oNotes
    End Sub

    Private Sub btnReturn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReturn.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnAddNewNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewNote.ItemClick
        addNote(vLinkType, vLinkKey)
    End Sub

    Private Sub addNote(vLinkType As String, vLinkKey As Integer)
        Dim frm As New frmAddEditNote
        frm.vEditType = "ADD"
        frm.vLinkType = vLinkType
        frm.vLinkKey = vLinkKey
        frm.ShowDialog()
        getNotes(vLinkType, vLinkKey)
    End Sub

    Private Sub btnEditNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditNote.ItemClick
        If bsNotes.Count <= 0 Then
            Exit Sub
        End If
        editNote(bsNotes.Current.NoteKey)
    End Sub

    Private Sub editNote(vKey As Integer)
        Dim frm As New frmAddEditNote
        frm.vEditType = "EDIT"
        frm.vID = vKey
        frm.vLinkType = vLinkType
        frm.vLinkKey = vLinkKey
        frm.ShowDialog()
        getNotes(vLinkType, vLinkKey)
    End Sub

    Private Sub deleteNote(vKey)
        Dim oNote As New Note
        If oNote.LoadByPrimaryKey(vKey) Then
            oNote.IsDeleted = 1
            oNote.Save()
        End If
        getNotes(vLinkType, vLinkKey)
    End Sub

    Private Sub btnDeleteNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteNote.ItemClick
        If bsNotes.Count <= 0 Then
            Exit Sub
        End If
        deleteNote(bsNotes.Current.NoteKey)
    End Sub
End Class