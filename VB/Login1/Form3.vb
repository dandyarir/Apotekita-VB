﻿Imports MySql.Data.MySqlClient
Public Class form_refIdObat

    Private Sub form_refIdObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()


        Dim cmd As New MySqlCommand
        cmd.CommandText = "SELECT id_obat,nama_obat from obat"
        cmd.Connection = koneksi


        Dim adapter As New MySqlDataAdapter(cmd)
        Dim tabel As New DataTable
        adapter.Fill(tabel)
        dg_ref.DataSource = tabel
        koneksi.Close()
    End Sub
End Class