Imports System.Data.SqlClient

Public Class conectDb
    Public Shared con As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet


    Public Function conect() As Boolean
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DBPengirimanBarang.mdb;"
            con.Open()
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function


    Public Shared Function openConnection() As Boolean
        con = New OleDb.OleDbConnection
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DBPengirimanBarang.mdb;"
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox("Connection Failed !", MsgBoxStyle.Critical)
            Return False
        End Try

    End Function

    Public Shared Sub closeConnection()
        If con Is Nothing AndAlso con.State = ConnectionState.Open Then
            con.Close()
            con = Nothing
        End If
    End Sub

End Class
