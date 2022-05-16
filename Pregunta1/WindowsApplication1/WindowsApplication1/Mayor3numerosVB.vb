Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If a = b And a = c Then GoTo abc_iguales

        If a = b Then
            If a > c Then
                GoTo ab_mayor
            Else
                GoTo c_mayor
            End If
        End If

        If b = c Then
            If a > b Then
                GoTo a_mayor
            Else
                GoTo bc_mayor
            End If
        End If

        If a = c Then
            If a > b Then
                GoTo ac_mayor
            Else
                GoTo b_mayor
            End If
        End If

        If a > b Then
            If a > c Then
                GoTo a_mayor
            Else
                GoTo c_mayor
            End If
        Else
            If b > c Then
                GoTo b_mayor
            Else
                GoTo c_mayor
            End If
        End If

a_mayor:
        TextBox4.Text = "a es mayor"
        GoTo final

b_mayor:
        TextBox4.Text = "b es mayor"
        GoTo final

c_mayor:
        TextBox4.Text = "c es mayor"
        GoTo final

ab_mayor:
        TextBox4.Text = "a y b son los mayores"
        GoTo final

bc_mayor:
        TextBox4.Text = "b y c son los mayores"
        GoTo final

ac_mayor:
        TextBox4.Text = "a y c son los mayores"
        GoTo final

abc_iguales:
        TextBox4.Text = "No hay mayores, todos son iguales"
        GoTo final

final:

    End Sub

End Class
