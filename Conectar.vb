﻿Imports System.Data.SqlClient

Public Class Conectar
    Private StringConection As String =
        "Data Source = DOMINGOS\SQLEXPRESS;" +
        "Initial Catalog = Viagens;" +
        "user id= sa;" +
        "password=123.Abc.@;"

    'Para aceder a outra instancia é só trocar o nome da Base de Dados
    'Se for um utlizador diferente é só alterar o user id e respetiva password

    Public SSQL As String = "select * from Registos;"



    Public Function BuscarDados() As DataTable
        Dim conexao As SqlConnection = New SqlConnection(StringConection)
        conexao.Open()
        Dim comando As SqlCommand = New SqlCommand(SSQL, conexao)
        Dim adpt As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        adpt.fill(dt)
        conexao.Close()
        Return dt

    End Function
End Class
