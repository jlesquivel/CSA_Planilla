Imports Microsoft.Office.Interop

Public Class cWord
    Dim wdApp As New Word.Application
    Dim wdDoc As New Word.Document
    Dim wdArch As String = ""

    Sub New()

    End Sub

    Sub New(pArch As String)
        wdArch = pArch
        wdApp = CreateObject("Word.Application")
        wdDoc = wdApp.Documents.Open(FileName:=wdArch)
        wdApp.Visible = True
    End Sub

    Sub SustituyeValores(wdPara As ArrayList)
        If wdPara.Count > 0 Then
            For Each wdValor As Object In wdPara
                With wdDoc.Bookmarks
                    If .Exists(wdValor(0)) Then
                        .Item(wdValor(0)).Range.Text = IIf(String.IsNullOrEmpty(wdValor(1)), "", wdValor(1))
                    End If
                End With
            Next
        End If
    End Sub

    Sub SustituyeRTF(MARCA As String, RTF As String)
        If wdDoc.Bookmarks.Exists(MARCA) Then
            gotoAbsolutLine(13)
            wdDoc.Application.Selection.InsertFile(RTF)
        End If
    End Sub

    Sub guarda(ByVal arch As String)
        Dim escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        Dim fileName As String = String.Format("{0:yyyyMMdd_HHmm}", DateTime.Now) & " = " & arch
        Dim nombreArch As String = fileName & ".docx"
        Dim documentFile As String = String.Format("{0}\{1}", escritorio, nombreArch)
        wdDoc.SaveAs(documentFile)
    End Sub

    Private Sub gotoStartOfDocument()
        wdDoc.Application.Selection.HomeKey(Word.WdUnits.wdStory, Nothing)

    End Sub

    Private Sub gotoEndOfDocument()
        wdDoc.Application.Selection.EndKey(Word.WdUnits.wdStory, Nothing)
    End Sub

    Private Sub gotoAbsolutLine(lineNum As Integer)
        Dim selec As Object = wdDoc.Application.Selection
        Dim dummy As Object = System.Reflection.Missing.Value
        Dim what As Object = Word.WdGoToItem.wdGoToLine
        Dim which As Object = Word.WdGoToDirection.wdGoToFirst
        Dim count As Integer = lineNum
        wdDoc.Application.Selection.GoTo(what, which, count, dummy)
    End Sub





#Region " IDisposable Support "

    Protected Overrides Sub Finalize()

        wdDoc = Nothing
        wdApp = Nothing
        MyBase.Finalize()
    End Sub
#End Region

End Class
