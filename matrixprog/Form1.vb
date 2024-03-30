Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

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
        Dim a11 As Double = s1.Text
        Dim a12 As Double = s2.Text
        Dim a13 As Double = s3.Text
        Dim a21 As Double = s4.Text
        Dim a22 As Double = s5.Text
        Dim a23 As Double = s6.Text
        Dim a31 As Double = s7.Text
        Dim a32 As Double = s8.Text
        Dim a33 As Double = s9.Text
        Dim jav2 = a11 * a22 * a33 + a21 * a32 * a13 + a12 * a23 * a31 - (a13 * a22 * a31 + a21 * a12 * a33 + a32 * a23 * a11)
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
        Dim jav4 As Double = (a11 * ((a22 * a33 * a44 + a32 * a43 * a24 + a23 * a34 * a42) - (a24 * a33 * a42 + a23 * a32 * a44 + a34 * a43 * a22))) - (a21 * ((a12 * a33 * a44 + a32 * a43 * a14 + a13 * a34 * a42) - (a14 * a33 * a42 + a13 * a32 * a44 + a43 * a34 * a12))) + (a31 * ((a12 * a23 * a44 + a22 * a14 * a43 + a13 * a24 * a42) - (a14 * a23 * a42 + a22 * a13 * a44 + a43 * a24 * a12))) - (a41 * ((a12 * a23 * a34 + a22 * a33 * a14 + a13 * a24 * a32) - (a14 * a23 * a32 + a13 * a22 * a34 + a24 * a33 * a12)))
        Label3.Text = jav4


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
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
        For Each clear In TabPage2.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
        Label2.Text = "0"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'кнопкаи тоза кунии
        For Each clear As Object In TabPage3.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
        Label3.Text = "0"
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
        Label1.Text = "0"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim m As Integer = TextBox1.Text
        Dim a11 As Double = TextBox2.Text
        Dim a12 As Double = TextBox3.Text
        Dim a21 As Double = TextBox4.Text
        Dim a22 As Double = TextBox5.Text
        If Not (m = 11 Or m = 12 Or m = 21 Or m = 22) Then
            MsgBox("Чунин минор вуҷуд надорад")
        ElseIf m = 11 Then
            Label12.Text = a22
        ElseIf m = 12 Then
            Label12.Text = a21
        ElseIf m = 21 Then
            Label12.Text = a12
        ElseIf m = 22 Then
            Label12.Text = a11
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        For Each clear In TabPage4.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
        Label12.Text = "0"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim m As Integer = m1.Text
        Dim a11 As Integer = t1.Text
        Dim a12 As Integer = t2.Text
        Dim a13 As Integer = t3.Text
        Dim a21 As Integer = t4.Text
        Dim a22 As Integer = t5.Text
        Dim a23 As Integer = t6.Text
        Dim a31 As Integer = t7.Text
        Dim a32 As Integer = t8.Text
        Dim a33 As Integer = t9.Text
        If Not (m = 11 Or m = 12 Or m = 13 Or m = 21 Or m = 22 Or m = 23 Or m = 31 Or m = 32 Or m = 33) Then
            MsgBox("Чунин минор вуҷуд надорад")
        ElseIf m = 11 Then
            j2.Text = a22 * a33 - a23 * a32
        ElseIf m = 12 Then
            j2.Text = a21 * a33 - a23 * a31
        ElseIf m = 13 Then
            j2.Text = a21 * a32 - a22 * a31
        ElseIf m = 21 Then
            j2.Text = a12 * a33 - a13 * a32
        ElseIf m = 22 Then
            j2.Text = a11 * a33 - a13 * a31
        ElseIf m = 23 Then
            j2.Text = a11 * a32 - a12 * a31
        ElseIf m = 31 Then
            j2.Text = a12 * a23 - a13 * a22
        ElseIf m = 32 Then
            j2.Text = a11 * a23 - a13 * a21
        ElseIf m = 33 Then
            j2.Text = a11 * a22 - a12 * a21
        End If


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        For Each clear In TabPage5.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
        j2.Text = "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim m As Integer = CInt(m3.Text)
        Dim a11 As Integer = CInt(k1.Text)
        Dim a12 As Integer = CInt(k2.Text)
        Dim a21 As Integer = CInt(k3.Text)
        Dim a22 As Integer = CInt(k4.Text)
        Dim hal As Integer = m Mod 10
        Dim hal2 As Integer = m \ 10
        Dim j As Integer = hal + hal2
        j3.Text = (-1) ^ j * (a11 * a22 - a12 * a21)

    End Sub



    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim m As Integer = CInt(m4.Text)
        Dim a11 As Integer = CInt(n1.Text)
        Dim a12 As Integer = CInt(n2.Text)
        Dim a13 As Integer = CInt(n3.Text)
        Dim a21 As Integer = CInt(n4.Text)
        Dim a22 As Integer = CInt(n5.Text)
        Dim a23 As Integer = CInt(n6.Text)
        Dim a31 As Integer = CInt(n7.Text)
        Dim a32 As Integer = CInt(n8.Text)
        Dim a33 As Integer = CInt(n9.Text)
        Dim hal As Integer = m Mod 10
        Dim hal1 As Integer = m / 10
        If Not (m = 11 Or m = 12 Or m = 13 Or m = 21 Or m = 22 Or m = 23 Or m = 31 Or m = 32 Or m = 33) Then
            MsgBox("Чунин минор вуҷуд надорад")
        ElseIf m = 11 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a22 * a33 - a23 * a32)
        ElseIf m = 12 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a21 * a33 - a23 * a31)
        ElseIf m = 13 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a21 * a32 - a22 * a31)
        ElseIf m = 21 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a12 * a33 - a13 * a32)
        ElseIf m = 22 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a11 * a33 - a13 * a31)
        ElseIf m = 23 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a11 * a32 - a12 * a31)
        ElseIf m = 31 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a12 * a23 - a13 * a22)
        ElseIf m = 32 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a11 * a23 - a13 * a21)
        ElseIf m = 33 Then
            j4.Text = (-1) ^ (hal1 + hal) * (a11 * a22 - a12 * a21)
        End If









    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        For Each clear In TabPage7.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
        j4.Text = "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        For Each clear In TabPage6.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
        j3.Text = "0"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Hide()
        Form3.Show()
    End Sub


End Class





