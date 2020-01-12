Public Class FLogin 

    Private Sub batal_Click(sender As Object, e As EventArgs) Handles batal.Click
        Dim pesan = MsgBox("Anda Yakin Mau Keluar ??", vbQuestion + vbYesNo, "Question")
        If pesan = vbYes Then
            End
        End If
    End Sub
End Class