Public Class frmRubros
    Dim conn As New conexionSQL
    Dim rnuevo As Boolean
    Dim indices As Integer()
    Dim bd As String = "rubros"
    Dim clista As New CargarLista
    Dim id_perfil As Integer


    Private Sub RubrosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RubrosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RubrosBindingSource.EndEdit()
        Me.RubrosTableAdapter.Update(Me.PlanillaDataSet.rubros)

    End Sub

    Private Sub frmRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn.bd = "planilla"
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.RubrosTableAdapter.Fill(Me.PlanillaDataSet.rubros)
        clista.DatosLista(Me.PlanillaDataSet.rubros, Me.CheckedListBox1, "id_rubro", "nombre")
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

    Private Sub guarda_rubros(ByVal id_perfil As Integer)
        Dim inst As String
        conn.ejecuta("delete rubros_perfil where id=" & id_perfil)
        For Each pos As Object In Me.CheckedListBox1.CheckedItems
            inst = "insert rubros_perfil values(" & id_perfil & "," & pos.codigo & ")"
            conn.ejecuta(inst)
        Next
    End Sub

    Private Sub TreeViewSQL1_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeViewSQL1.AfterLabelEdit
        If rnuevo Then
            Dim inst As String = "insert perfil_rubros(nombre) values('" & e.Label & "')"
            conn.ejecuta(inst)
            rnuevo = False
            Me.TreeViewSQL1.LabelEdit = False
        End If
    End Sub

    Private Sub TabControlPanel2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControlPanel2.GotFocus
      
        Me.TreeViewSQL1.llenar("planilla")

    End Sub
End Class