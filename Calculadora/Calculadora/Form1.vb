Public Class Form1
    Private result As Double = 0
    Private Number As Double = 0
    Private oper As String = String.Empty
    Private limpa As Boolean = True
    Private dec As Boolean = False
    Private stNum As String = "1"
    Private blnOper As Boolean = False


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1ClickMethodo(sender As Object, e As EventArgs) Handles Button1.Click
        Dim button1 As Button = CType(sender, Button)
        If button1.Name = "Button1" Then
            TextBox1.Text = TextBox1.Text + "7"

        End If



    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Button3ClickMethodo(sender As Object, e As EventArgs) Handles Button3.Click
        Dim button3 As Button = CType(sender, Button)
        If button3.Name = "Button3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If

    End Sub

    Private Sub Button2ClickMethodo(sender As Object, e As EventArgs) Handles Button2.Click
        Dim button2 As Button = CType(sender, Button)
        If button2.Name = "Button2" Then
            TextBox1.Text = TextBox1.Text + "8"

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If stNum = "1" And blnOper = True Then
            result = Convert.ToDouble(TextBox1.Text)
        ElseIf stNum = "2" And blnOper = True Then
            result = Convert.ToDouble(TextBox1.Text)
            result = result / Number
            TextBox1.Text = Number
            Number = 0


        End If
        oper = "/"
        limpa = True
        dec = False

        blnOper = False

    End Sub

    Private Sub Button4ClickMethodo(sender As Object, e As EventArgs) Handles Button4.Click
        Dim button4 As Button = CType(sender, Button)
        If button4.Name = "Button4" Then
            TextBox1.Text = TextBox1.Text + "4"

        End If
    End Sub

    Private Sub Button5ClickMethodo(sender As Object, e As EventArgs) Handles Button5.Click
        Dim button5 As Button = CType(sender, Button)
        If button5.Name = "Button5" Then
            TextBox1.Text = TextBox1.Text + "5"

        End If
    End Sub

    Private Sub Button8ClickMethodo(sender As Object, e As EventArgs) Handles Button8.Click
        Dim button8 As Button = CType(sender, Button)
        If button8.Name = "Button8" Then
            TextBox1.Text = TextBox1.Text + "6"

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If oper = "+" And Number = 0 Then
            result = result + Convert.ToDouble(TextBox1.Text)
        ElseIf oper = "-" And Number = 0 Then
            result = result - Convert.ToDouble(TextBox1.Text)
        ElseIf oper = "*" And Number = 0 Then
            result = result * Convert.ToDouble(TextBox1.Text)
        ElseIf oper = "/" And Number = 0 Then
            result = result / Convert.ToDouble(TextBox1.Text)
        End If
        TextBox1.Text = result
        limpa = True
        blnOper = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Button13ClickMethodo(sender As Object, e As EventArgs) Handles Button13.Click
        Dim button13 As Button = CType(sender, Button)
        If button13.Name = "Button13" Then
            TextBox1.Text = TextBox1.Text + "3"

        End If
    End Sub

    Private Sub Button12ClickMethodo(sender As Object, e As EventArgs) Handles Button12.Click
        Dim button12 As Button = CType(sender, Button)
        If button12.Name = "Button12" Then
            TextBox1.Text = TextBox1.Text + "2"

        End If
    End Sub

    Private Sub Button11ClickMethodo(sender As Object, e As EventArgs) Handles Button11.Click
        Dim button11 As Button = CType(sender, Button)

        If button11.Name = "Button11" Then
            TextBox1.Text = TextBox1.Text + "1"

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button15ClickMethodo(sender As Object, e As EventArgs) Handles Button15.Click
        If Button15.Name = "Button15" Then
            TextBox1.Text = TextBox1.Text + "0"

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Number = 0
        result = 0
        oper = String.Empty

        TextBox1.Text = "0"
        limpa = True
    End Sub
End Class
