Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPessoa.Click
        Dim pessoa As New Pessoa()
        pessoa.pNome = nome.Text
        pessoa.pCpf = cpf.Text

        lstDados.Items.Add(pessoa.pCpf + " - " + pessoa.pNome)

    End Sub

    Private Sub btnGravarProfessor_Click(sender As Object, e As EventArgs) Handles btnGravarProfessor.Click
        Dim prof As New Professor(professor.Text, cpfProfessor.Text, titulo.Text)
        lstDados.Items.Add(prof.pCpf + " - " + prof.pNome + " - " + prof.pTitulo)
    End Sub
End Class
