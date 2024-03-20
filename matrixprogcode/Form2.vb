Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'зарби матрисаи 2х2
        'zarbi yakum 2x2 
        Dim a11 As Double = CDbl(z1.Text)
        Dim a12 As Double = CDbl(z2.Text)
        Dim a21 As Double = CDbl(z3.Text)
        Dim a22 As Double = CDbl(z4.Text)
        'zarbshavandai 2um 2x2
        Dim a31 As Double = CDbl(b1.Text)
        Dim a32 As Double = CDbl(b2.Text)
        Dim a41 As Double = CDbl(b3.Text)
        Dim a42 As Double = CDbl(b4.Text)
        'hal
        Dim s1 As Double = a11 * a31 + a12 * a41
        Dim s2 As Double = a11 * a32 + a12 * a42
        Dim s3 As Double = a21 * a31 + a22 * a41
        Dim s4 As Double = a21 * a32 + a22 * a42
        'print
        Label1.Text = s1
        Label3.Text = s2
        Label2.Text = s3
        Label4.Text = s4

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'зарби матрисаи 3х3
        'rakamhoi zarbi 1um
        Dim a11 As Double = CDbl(a1.Text)
        Dim a12 As Double = CDbl(a2.Text)
        Dim a13 As Double = CDbl(a3.Text)
        Dim a21 As Double = CDbl(a4.Text)
        Dim a22 As Double = CDbl(a5.Text)
        Dim a23 As Double = CDbl(a6.Text)
        Dim a31 As Double = CDbl(a7.Text)
        Dim a32 As Double = CDbl(a8.Text)
        Dim a33 As Double = CDbl(a9.Text)
        'rakamhoi zarbi 2um
        Dim a41 As Double = CDbl(e1.Text)
        Dim a42 As Double = CDbl(e2.Text)
        Dim a43 As Double = CDbl(e3.Text)
        Dim a51 As Double = CDbl(e4.Text)
        Dim a52 As Double = CDbl(e5.Text)
        Dim a53 As Double = CDbl(e6.Text)
        Dim a61 As Double = CDbl(e7.Text)
        Dim a62 As Double = CDbl(e8.Text)
        Dim a63 As Double = CDbl(e9.Text)
        'halho
        Dim jav1 As Double = a11 * a41 + a12 * a51 + a13 * a61
        Dim jav2 As Double = a11 * a42 + a12 * a52 + a13 * a62
        Dim jav3 As Double = a11 * a43 + a12 * a53 + a13 * a63
        Dim jav4 As Double = a21 * a41 + a22 * a51 + a23 * a61
        Dim jav5 As Double = a21 * a42 + a22 * a52 + a23 * a62
        Dim jav6 As Double = a21 * a43 + a22 * a53 + a23 * a63
        Dim jav7 As Double = a31 * a41 + a32 * a51 + a33 * a61
        Dim jav8 As Double = a31 * a42 + a32 * a52 + a33 * a62
        Dim jav9 As Double = a31 * a43 + a32 * a53 + a33 * a63
        'javobho
        L1.Text = jav1
        L2.Text = jav2
        L3.Text = jav3
        L4.Text = jav4
        L5.Text = jav5
        L6.Text = jav6
        L7.Text = jav7
        L8.Text = jav8
        L9.Text = jav9

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Чаъми матрисаи 2х2
        'zarbshavandaho
        Dim b1 As Double = CDbl(zb1.Text)
        Dim b2 As Double = CDbl(zb2.Text)
        'rakamhoi 1um
        Dim a11 As Double = CDbl(t1.Text)
        Dim a12 As Double = CDbl(t2.Text)
        Dim a21 As Double = CDbl(t3.Text)
        Dim a22 As Double = CDbl(t4.Text)
        'rakamho 2um
        Dim a31 As Double = CDbl(w1.Text)
        Dim a32 As Double = CDbl(w2.Text)
        Dim a41 As Double = CDbl(w3.Text)
        Dim a42 As Double = CDbl(w4.Text)
        'formulaho
        Dim j1 As Double = (b1 * a11) + (b2 * a31)
        Dim j2 As Double = (b1 * a12) + (b2 * a32)
        Dim j3 As Double = (b1 * a21) + (b2 * a41)
        Dim j4 As Double = (b1 * a22) + (b2 * a42)
        v1.Text = j1
        v2.Text = j2
        v3.Text = j3
        v4.Text = j4
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'кнопкаи тоза кунии
        For Each clear As Object In TabPage12.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'кнопкаи тоза кунии
        For Each clear As Object In TabPage2.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'кнопкаи тоза кунии
        For Each clear As Object In TabPage3.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        'кнопкаи тоза кунии
        For Each clear In TabPage4.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim b1 As Double = CDbl(ss1.Text)
        Dim b2 As Double = CDbl(ss2.Text)
        'matrisai 1um
        Dim a11 As Double = CDbl(u1.Text)
        Dim a12 As Double = CDbl(u2.Text)
        Dim a13 As Double = CDbl(u3.Text)
        Dim a21 As Double = CDbl(u4.Text)
        Dim a22 As Double = CDbl(u5.Text)
        Dim a23 As Double = CDbl(u6.Text)
        Dim a31 As Double = CDbl(u7.Text)
        Dim a32 As Double = CDbl(u8.Text)
        Dim a33 As Double = CDbl(u9.Text)
        'matrisai 2um
        Dim a41 As Double = CDbl(i1.Text)
        Dim a42 As Double = CDbl(i2.Text)
        Dim a43 As Double = CDbl(i3.Text)
        Dim a51 As Double = CDbl(i4.Text)
        Dim a52 As Double = CDbl(i5.Text)
        Dim a53 As Double = CDbl(i6.Text)
        Dim a61 As Double = CDbl(i7.Text)
        Dim a62 As Double = CDbl(i8.Text)
        Dim a63 As Double = CDbl(i9.Text)
        Dim j1 As Double = (b1 * a11) + (b2 * a41)
        Dim j2 As Double = (b1 * a12) + (b2 * a42)
        Dim j3 As Double = (b1 * a13) + (b2 * a43)
        Dim j4 As Double = (b1 * a21) + (b2 * a51)
        Dim j5 As Double = (b1 * a22) + (b2 * a52)
        Dim j6 As Double = (b1 * a23) + (b2 * a53)
        Dim j7 As Double = (b1 * a31) + (b2 * a61)
        Dim j8 As Double = (b1 * a32) + (b2 * a62)
        Dim j9 As Double = (b1 * a33) + (b2 * a63)
        p1.Text = j1
        p2.Text = j2
        p3.Text = j3
        p4.Text = j4
        p5.Text = j5
        p6.Text = j6
        p7.Text = j7
        p8.Text = j8
        p9.Text = j9
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'zarb
        Dim b1 As Double = CDbl(ff1.Text)
        Dim b2 As Double = CDbl(ff2.Text)
        'matrisai 1um
        Dim a11 As Double = CDbl(x1.Text)
        Dim a12 As Double = CDbl(x2.Text)
        Dim a13 As Double = CDbl(x3.Text)
        Dim a21 As Double = CDbl(x4.Text)
        Dim a22 As Double = CDbl(x5.Text)
        Dim a23 As Double = CDbl(x6.Text)
        Dim a31 As Double = CDbl(x7.Text)
        Dim a32 As Double = CDbl(x8.Text)
        Dim a33 As Double = CDbl(x9.Text)
        'matrisai 2um
        Dim a41 As Double = CDbl(c1.Text)
        Dim a42 As Double = CDbl(c2.Text)
        Dim a43 As Double = CDbl(c3.Text)
        Dim a51 As Double = CDbl(c4.Text)
        Dim a52 As Double = CDbl(c5.Text)
        Dim a53 As Double = CDbl(c6.Text)
        Dim a61 As Double = CDbl(c7.Text)
        Dim a62 As Double = CDbl(c8.Text)
        Dim a63 As Double = CDbl(c9.Text)
        'javobho
        Dim j1 As Double = (b1 * a11) - (b2 * a41)
        Dim j2 As Double = (b1 * a12) - (b2 * a42)
        Dim j3 As Double = (b1 * a13) - (b2 * a43)
        Dim j4 As Double = (b1 * a21) - (b2 * a51)
        Dim j5 As Double = (b1 * a22) - (b2 * a52)
        Dim j6 As Double = (b1 * a23) - (b2 * a53)
        Dim j7 As Double = (b1 * a31) - (b2 * a61)
        Dim j8 As Double = (b1 * a32) - (b2 * a62)
        Dim j9 As Double = (b1 * a33) - (b2 * a63)
        jj1.Text = j1
        jj2.Text = j2
        jj3.Text = j3
        jj4.Text = j4
        jj5.Text = j5
        jj6.Text = j6
        jj7.Text = j7
        jj8.Text = j8
        jj9.Text = j9

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'кнопкаи тоза кунии
        For Each clear As Object In TabPage1.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'кнопкаи тоза кунии
        For Each clear As Object In TabPage5.Controls
            If TypeOf clear Is TextBox Then
                clear.text = ""
            End If
        Next
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click

        'zarbshavandaho
        Dim b1 As Double = CDbl(ad1.Text)
        Dim b2 As Double = CDbl(ad2.Text)
        'rakamhoi 1um
        Dim a11 As Double = CDbl(r1.Text)
        Dim a12 As Double = CDbl(r2.Text)
        Dim a21 As Double = CDbl(r3.Text)
        Dim a22 As Double = CDbl(r4.Text)
        'rakamho 2um
        Dim a31 As Double = CDbl(g1.Text)
        Dim a32 As Double = CDbl(g2.Text)
        Dim a41 As Double = CDbl(g3.Text)
        Dim a42 As Double = CDbl(g4.Text)
        'formulaho
        Dim j1 = (b1 * a11) - (b2 * a31)
        Dim j2 = (b1 * a12) - (b2 * a32)
        Dim j3 = (b1 * a21) - (b2 * a41)
        Dim j4 = (b1 * a22) - (b2 * a42)
        f1.Text = j1
        f2.Text = j2
        f3.Text = j3
        f4.Text = j4
    End Sub
End Class
