Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim a, b, c, mayor, medio, menor As Integer
        a = txtIngreso1.Text
        b = txtIngreso2.Text
        c = txtIngreso3.Text
        If a > b And a > c Then
            mayor = a
            If b > c Then
                medio = b
                menor = c
            Else
                medio = c
                menor = b
            End If
        End If
        If b > a And b > c Then
            mayor = b
            If a > c Then
                medio = a
                menor = c
            Else
                medio = c
                menor = a
            End If
        End If
        If c > a And c > b Then
            mayor = c
            If a > b Then
                medio = a
                menor = b
            Else
                medio = b
                menor = a
            End If
        End If
        lblMostrar1.Text = mayor
        lblMostrar2.Text = medio
        lblMostrar3.Text = menor

    End Sub
End Class
