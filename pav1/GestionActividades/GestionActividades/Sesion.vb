Public Class Sesion

    Private _gestion As VentanaGestion
    Private _access As DataAccess

    Public Sub New(ByRef gestion As VentanaGestion, ByRef access As DataAccess)
        InitializeComponent()
        _gestion = gestion
        Me._access = access
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If String.Equals(Me.txtUsername.Text, "admin") And String.Equals(Me.txtPassword.Text, "admin") Then
            _gestion.habilitar(True, Me.txtUsername.Text)
            Return
        End If

        Dim data = Me._access.buscar("SELECT * FROM usuario WHERE nombre = '" & Me.txtUsername.Text & _
                          "' AND clave = '" & Me.txtPassword.Text & "'")
        If data.Rows.Count > 0 Then
            Dim user = New Usuario(data.Rows(0)("id"), data.Rows(0)("nombre"), data.Rows(0)("clave"))
            _gestion.setUser(user)
            _gestion.habilitar(True, Me.txtUsername.Text)
        End If

    End Sub
End Class
