Imports Microsoft.Office.Interop
Imports System.Diagnostics.Process

Imports System.IO

Public Class cWord
    Public wdApp As New Word.Application
    Public wdDoc As New Word.Document
    Public wdArch As String = ""
    Dim ProcID As Object


    Sub New()

    End Sub

    Sub New(pArch As String)
        wdArch = pArch
        wdApp = CreateObject("Word.Application")
        wdDoc = wdApp.Documents.Open(FileName:=wdArch)
        wdApp.Visible = False

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
        cerrar()
    End Sub
    Sub guarda(ByVal arch As String, dir As String)
        Dim escritorio As String = ""
        If dir = "" Then
            escritorio = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        Else
            escritorio = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\" & dir
            crea_directorio(escritorio)
        End If
        Dim fileName As String = String.Format("{0:yyyyMMdd_HHmm}", DateTime.Now) & " = " & arch
        Dim nombreArch As String = fileName & ".docx"
        Dim documentFile As String = String.Format("{0}\{1}", escritorio, nombreArch)
        wdDoc.SaveAs(documentFile)
        cerrar()
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

    Sub cerrar()

        wdDoc.Close()
        wdApp.Quit()
        wdDoc = Nothing
        wdApp = Nothing
        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("winword")

        For Each p As Process In pProcess
            p.Kill()
        Next
    End Sub

    Sub crea_directorio(Path As String)

        If Not Directory.Exists(Path) Then
            Directory.CreateDirectory(Path)
        End If
    End Sub

    '#Region " IDisposable Support "

    '    Protected Overrides Sub Finalize()

    '        wdDoc = Nothing
    '        wdApp.Quit()
    '        wdDoc = Nothing
    '        MyBase.Finalize()
    '    End Sub
    '#End Region

End Class
