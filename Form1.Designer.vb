<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPessoa = New System.Windows.Forms.Button()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.cpf = New System.Windows.Forms.TextBox()
        Me.cpfProfessor = New System.Windows.Forms.TextBox()
        Me.lblCpfProfessor = New System.Windows.Forms.Label()
        Me.professor = New System.Windows.Forms.TextBox()
        Me.lblNomeProfessor = New System.Windows.Forms.Label()
        Me.btnGravarProfessor = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.titulo = New System.Windows.Forms.TextBox()
        Me.lstDados = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnPessoa
        '
        Me.btnPessoa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPessoa.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPessoa.ForeColor = System.Drawing.Color.Red
        Me.btnPessoa.Location = New System.Drawing.Point(61, 104)
        Me.btnPessoa.Name = "btnPessoa"
        Me.btnPessoa.Size = New System.Drawing.Size(166, 45)
        Me.btnPessoa.TabIndex = 0
        Me.btnPessoa.Text = "Gravar"
        Me.btnPessoa.UseVisualStyleBackColor = False
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(49, 25)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(43, 15)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome:"
        '
        'nome
        '
        Me.nome.Location = New System.Drawing.Point(98, 17)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(132, 23)
        Me.nome.TabIndex = 2
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(61, 54)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(31, 15)
        Me.lblCpf.TabIndex = 3
        Me.lblCpf.Text = "CPF:"
        '
        'cpf
        '
        Me.cpf.Location = New System.Drawing.Point(98, 46)
        Me.cpf.Name = "cpf"
        Me.cpf.Size = New System.Drawing.Size(132, 23)
        Me.cpf.TabIndex = 4
        '
        'cpfProfessor
        '
        Me.cpfProfessor.Location = New System.Drawing.Point(330, 46)
        Me.cpfProfessor.Name = "cpfProfessor"
        Me.cpfProfessor.Size = New System.Drawing.Size(132, 23)
        Me.cpfProfessor.TabIndex = 9
        '
        'lblCpfProfessor
        '
        Me.lblCpfProfessor.AutoSize = True
        Me.lblCpfProfessor.Location = New System.Drawing.Point(293, 54)
        Me.lblCpfProfessor.Name = "lblCpfProfessor"
        Me.lblCpfProfessor.Size = New System.Drawing.Size(31, 15)
        Me.lblCpfProfessor.TabIndex = 8
        Me.lblCpfProfessor.Text = "CPF:"
        '
        'professor
        '
        Me.professor.Location = New System.Drawing.Point(330, 17)
        Me.professor.Name = "professor"
        Me.professor.Size = New System.Drawing.Size(132, 23)
        Me.professor.TabIndex = 7
        '
        'lblNomeProfessor
        '
        Me.lblNomeProfessor.AutoSize = True
        Me.lblNomeProfessor.Location = New System.Drawing.Point(281, 25)
        Me.lblNomeProfessor.Name = "lblNomeProfessor"
        Me.lblNomeProfessor.Size = New System.Drawing.Size(43, 15)
        Me.lblNomeProfessor.TabIndex = 6
        Me.lblNomeProfessor.Text = "Nome:"
        '
        'btnGravarProfessor
        '
        Me.btnGravarProfessor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGravarProfessor.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGravarProfessor.ForeColor = System.Drawing.Color.Red
        Me.btnGravarProfessor.Location = New System.Drawing.Point(296, 104)
        Me.btnGravarProfessor.Name = "btnGravarProfessor"
        Me.btnGravarProfessor.Size = New System.Drawing.Size(166, 45)
        Me.btnGravarProfessor.TabIndex = 5
        Me.btnGravarProfessor.Text = "Gravar"
        Me.btnGravarProfessor.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(284, 83)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(40, 15)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Título:"
        '
        'titulo
        '
        Me.titulo.Location = New System.Drawing.Point(330, 75)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(132, 23)
        Me.titulo.TabIndex = 11
        '
        'lstDados
        '
        Me.lstDados.FormattingEnabled = True
        Me.lstDados.ItemHeight = 15
        Me.lstDados.Location = New System.Drawing.Point(61, 173)
        Me.lstDados.Name = "lstDados"
        Me.lstDados.Size = New System.Drawing.Size(401, 94)
        Me.lstDados.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 301)
        Me.Controls.Add(Me.lstDados)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cpfProfessor)
        Me.Controls.Add(Me.lblCpfProfessor)
        Me.Controls.Add(Me.professor)
        Me.Controls.Add(Me.lblNomeProfessor)
        Me.Controls.Add(Me.btnGravarProfessor)
        Me.Controls.Add(Me.cpf)
        Me.Controls.Add(Me.lblCpf)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.btnPessoa)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPessoa As Button
    Friend WithEvents lblNome As Label
    Friend WithEvents nome As TextBox
    Friend WithEvents lblCpf As Label
    Friend WithEvents cpf As TextBox
    Friend WithEvents cpfProfessor As TextBox
    Friend WithEvents lblCpfProfessor As Label
    Friend WithEvents professor As TextBox
    Friend WithEvents lblNomeProfessor As Label
    Friend WithEvents btnGravarProfessor As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents titulo As TextBox
    Friend WithEvents lstDados As ListBox
End Class
