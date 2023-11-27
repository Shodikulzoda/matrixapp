Imports System.ComponentModel

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For Each clear In TabPage2.Controls

            If TypeOf clear Is TextBox Then
                MsgBox("erorr")
            End If
        Next
        'матриса 2х2

        'If String.IsNullOrEmpty(a1.Text.Trim) Then
        '    MsgBox(a1, "не заполнено")
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'матриса 3х3
        Dim a11 As Double = CDbl(s1.Text)
        Dim a12 As Double = CDbl(s2.Text)
        Dim a13 As Double = CDbl(s3.Text)
        Dim a21 As Double = CDbl(s4.Text)
        Dim a22 As Double = CDbl(s5.Text)
        Dim a23 As Double = CDbl(s6.Text)
        Dim a31 As Double = CDbl(s7.Text)
        Dim a32 As Double = CDbl(s8.Text)
        Dim a33 As Double = CDbl(s9.Text)
        Dim jav2 As Double = (a11 * a22 * a33 + a21 * a32 * a13 + a12 * a23 * a31) - (a13 * a22 * a31 + a21 * a12 * a33 + a32 * a23 * a11)
        Label2.Text = jav2

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'матриса 4х4
        Dim a11 As Double = CDbl(d1.Text)
        Dim a12 As Double = CDbl(d2.Text)
        Dim a13 As Double = CDbl(d3.Text)
        Dim a14 As Double = CDbl(d4.Text)
        Dim a21 As Double = CDbl(d5.Text)
        Dim a22 As Double = CDbl(d6.Text)
        Dim a23 As Double = CDbl(d7.Text)
        Dim a24 As Double = CDbl(d8.Text)
        Dim a31 As Double = CDbl(d9.Text)
        Dim a32 As Double = CDbl(d10.Text)
        Dim a33 As Double = CDbl(d11.Text)
        Dim a34 As Double = CDbl(d12.Text)
        Dim a41 As Double = CDbl(d13.Text)
        Dim a42 As Double = CDbl(d14.Text)
        Dim a43 As Double = CDbl(d15.Text)
        Dim a44 As Double = CDbl(d16.Text)
        Dim jav4 As Double = (a11 * a22 * a33 * a44 + a12 * a23 * a34 * a41 + a13 * a24 * a31 * a42) - (a12 * a21 * a34 * a43 + a11 * a24 * a33 * a42 + a14 * a23 * a32 * a41)
        Label3.Text = jav4
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        'кнопкаи тоза кунии
        For Each clear In TabPage1.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If

        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'кнопкаи тоза кунии
        For Each clear As Object In TabPage2.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'кнопкаи тоза кунии
        For Each clear As Object In TabPage3.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
    End Sub



    Private Sub a1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub a2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub a3_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub a4_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a11 As Double = a1.Text
        Dim a12 As Double = a2.Text
        Dim a21 As Double = a3.Text
        Dim a22 As Double = a4.Text
        Dim jav = a11 * a22 - a12 * a21
        Label1.Text = jav
    End Sub




    'Private Sub Button6_keydown(sender As Object, e As EventArgs)
    '    For Each clear In TabPage1.Controls
    '        If TypeOf clear Is TextBox Then
    '            clear.text = ""
    '        End If

    '    Next
    'End Sub

    'Private Sub Button6_KeyDown(sender As Object, e As KeyEventArgs) Handles Button6.KeyDown
    '    For Each clear In TabPage1.Controls
    '        If TypeOf clear Is TextBox Then
    '            clear.text = ""
    '        End If

    '    Next
    'End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        For Each clear In TabPage1.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If

        Next
    End Sub




    'Private Sub a1_Validating(sender As Object, e As CancelEventArgs) Handles a1.Validating
    '    If String.IsNullOrEmpty(a1.Text.Trim) Then
    '        ErrorProvider1.SetError(a1, "не заполнено")

    '    End If
    'End Sub
End Class





