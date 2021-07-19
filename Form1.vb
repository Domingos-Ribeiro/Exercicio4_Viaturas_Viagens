Public Class Form1
    Private Sub btnBuscarRegistos_Click(sender As Object, e As EventArgs) Handles btnBuscarRegistos.Click
        Dim ligacao As New Conectar
        ligacao.SSQL = "Select * from Registos"
        dgvViagens.DataSource = ligacao.BuscarDados()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim ligacao As New Conectar
        ligacao.SSQL = "Insert into Registos (Viatura, Dias, Kilometros)
                values (" + "Fiat" + "','" + 1 + "','" + 300 + "')"



    End Sub
End Class
