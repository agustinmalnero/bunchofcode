Public Class Sesion

    Private _gestion As VentanaGestion

    Public Sub New(ByRef gestion As VentanaGestion)
        InitializeComponent()
        _gestion = gestion
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If String.Equals(Me.txtUsername.Text, "admin") And String.Equals(Me.txtPassword.Text, "admin") Then
            _gestion.habilitar(True, Me.txtUsername.Text)
        End If

    End Sub
End Class
