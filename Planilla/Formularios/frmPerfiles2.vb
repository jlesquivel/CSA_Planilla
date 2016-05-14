Public Class frmPerfiles2
    Dim conn As New conexionSQL
    Dim clista As New CargarLista
    Dim rnuevo As Boolean
    Dim id_perfil As Integer

    Private Sub frmPerfiles2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn.bd = "planilla"
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.RubrosTableAdapter.Connection.ConnectionString = conn.strConn
        Me.Tabla_valoresTableAdapter.Connection.ConnectionString = conn.strConn

        Dim cant As Integer = Me.RubrosTableAdapter.Fill(Me.PlanillaDataSet.rubros)

        Me.Tabla_valoresTableAdapter.Fill(Me.PlanillaDataSet.tabla_valores)
        clista.DatosLista(Me.PlanillaDataSet.rubros, Me.CheckedListBox1, "id_rubro", "nombre")

    End Sub

    Private Sub TabControlPanel2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControlPanel2.GotFocus
        Me.TreeViewSQL1.llenar("planilla")
        Me.TreeViewSQL1.TopNode.Expand()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.TreeViewSQL1.LabelEdit = True
        Dim nuevo_nodo As TreeNode = Me.TreeViewSQL1.Nodes.Item(0).Nodes.Add("")
        nuevo_nodo.ImageIndex = 1
        Me.TreeViewSQL1.Nodes.Item(0).Expand()
        nuevo_nodo.Checked = True
        nuevo_nodo.BeginEdit()
        rnuevo = True
    End Sub

    Private Sub TreeViewSQL1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewSQL1.AfterSelect

        If e.Node.FullPath.Split("\").Length = 2 Then
            Dim cmd As String
            Dim tabla As ArrayList
            cmd = "select * from perfil_rubros where nombre= '" & e.Node.Text & "'"
            tabla = conn.llena(cmd)
            id_perfil = tabla(0)(0)

            Dim ds As New DataSet
            conn.llena(ds, "tabla1", "select * from rubros_perfil where id = " & id_perfil)
            Dim dvLista As DataView = ds.Tables("tabla1").DefaultView
            clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)

            'Me.Lbl_perfil.Text = e.Node.Text
        
        End If
    End Sub

    Private Sub TreeViewSQL1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeViewSQL1.BeforeSelect
        If Me.CheckedListBox1.CheckedItems.Count > 0 Then
            Me.guarda_rubros(id_perfil)
        End If
    End Sub

    Private Sub TreeViewSQL1_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeViewSQL1.AfterLabelEdit
        If rnuevo Then
            Dim inst As String = "insert perfil_rubros(nombre) values('" & e.Label & "')"
            conn.ejecuta(inst)
            rnuevo = False
            Me.TreeViewSQL1.LabelEdit = False
        End If
    End Sub

    Private Sub guarda_rubros(ByVal id_perfil As Integer)
        Dim inst As String
        conn.ejecuta("delete rubros_perfil where id=" & id_perfil)
        For Each pos As Object In Me.CheckedListBox1.CheckedItems
            inst = "insert rubros_perfil values(" & id_perfil & "," & pos.codigo & ")"
            conn.ejecuta(inst)
        Next
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RubrosBindingSource.EndEdit()
        Me.Tabla_valoresBindingSource.EndEdit()

        Me.RubrosTableAdapter.Update(Me.PlanillaDataSet.rubros)
        Me.Tabla_valoresTableAdapter.Update(Me.PlanillaDataSet.tabla_valores)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.TreeViewSQL1.LabelEdit = True
        Dim nodo As TreeNode = Me.TreeViewSQL1.SelectedNode

        Me.TreeViewSQL1.SelectedNode = Me.TreeViewSQL1.TopNode

        Dim conn As New conexionSQL("planilla")
        conn.ejecuta("delete from perfil_rubros where nombre = '" & nodo.Text & "'")

        nodo.Remove()

    End Sub

End Class