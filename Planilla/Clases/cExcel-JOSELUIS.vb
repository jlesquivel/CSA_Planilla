Imports System.IO
Imports Microsoft.Office.Interop
Public Class cExcel


    Dim wdApp As Object
    Dim wdArch As String = ""
    Dim objLibroExcel As Excel.Workbook
    Dim objHojaExcel As Excel.Worksheet

    Sub New(pArch As String)
        Dim pdest As String = pArch.Replace(".xls", "1.xls")
        FileCopy(pArch, pdest)

        wdArch = pdest
        wdApp = New Excel.Application
        wdApp.visible = False
        If File.Exists(wdArch) Then
            objLibroExcel = wdApp.Workbooks.Open(pArch)
        End If


    End Sub


    Sub AlmacenarValor(Datos As ArrayList)

        objHojaExcel = objLibroExcel.Worksheets("Planilla")
        Dim pos As Integer = 3
        For Each elemento As Object In Datos

            objHojaExcel.Range("B" & pos.ToString).Value = elemento(2).ToString.Replace("-", "")
            objHojaExcel.Range("C" & pos.ToString).Value = elemento(0) & " " & elemento(1)
            objHojaExcel.Range("D" & pos.ToString).Value = elemento(3)
            objHojaExcel.Rows(pos + 1).Insert
            pos += 1
        Next

    End Sub


    Function guarda(ByVal arch As String, pPlanilla As String) As String
        Dim escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        Dim fileName As String = ChangeExtension(arch, "") & pPlanilla & "  #" & String.Format("{0:yyyyMMdd_HHmm}", DateTime.Now)
        Dim nombreArch As String = fileName & ".xls"
        Dim documentFile As String = String.Format("{0}\{1}", escritorio, nombreArch)
        objLibroExcel.SaveAs(documentFile)

        objLibroExcel.Close()

        CerrarProcesoExcel()
        If System.IO.File.Exists(documentFile) Then
            Return (documentFile)
        Else Return ""
        End If
    End Function

    Private Sub CerrarProcesoExcel()
        Dim p As Process
        For Each p In Process.GetProcesses()
            If Not p Is Nothing Then
                If p.ProcessName.ToString = "EXCEL" Then
                    Try
                        p.Kill() 'Cierra el proceso   
                        Exit For 'Sale del for al encontrar Aplicación
                    Catch msg As Exception
                        ''Call Globales.ControldeErrores(msg, 1, Me.Text)
                        Exit Sub
                    End Try
                End If
            End If
        Next
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
    Public Function ChangeExtension(ByVal sFileName As String, ByVal sNewExt As String) As String

        Dim sExt, final As String
        sExt = Path.GetExtension(sFileName)

        If Len(sExt) = 0 Then
            Return ""
        End If

        If Left(sNewExt, 1) <> "." Then sNewExt = "." & sNewExt
        final = Replace(sFileName, sExt, sNewExt)

        Return final
    End Function

#Region " IDisposable Support "

    Protected Overrides Sub Finalize()

        objLibroExcel = Nothing
        wdApp = Nothing
        MyBase.Finalize()
    End Sub
#End Region
End Class
