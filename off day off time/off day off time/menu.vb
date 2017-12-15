Public Class menu
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Dim hobi As ArrayList=New ArrayList()
        Dim butonsayisi as Integer
        hobi=Kullanicibulma.Butonyap(giris.liste)
        butonsayisi=hobi.Count
        If butonsayisi=1 Then
        Dim butonlar(butonsayisi) As Button
        For j As Integer = 0 To butonsayisi - 1
            butonlar(j)=New Button()
            butonlar(j).name =hobi(j).ToString()
            butonlar(j).Text=hobi(j).ToString()
            butonlar(j).Visible = True
            butonlar(j).Location = New Point(250+j *150, 50 + j)
            butonlar(j).Size = New Size(100,100)
            butonlar(j).BackColor = Color.Transparent
            AddHandler butonlar(j).Click, AddressOf formyap
            Me.Controls.Add(butonlar(j))
        Next
            ElseIf butonsayisi=2 Then
                Dim butonlar(butonsayisi) As Button
                For j As Integer = 0 To butonsayisi - 1
                    butonlar(j)=New Button()
                    butonlar(j).name =hobi(j).ToString()
                    butonlar(j).Text=hobi(j).ToString()
                    butonlar(j).Visible = True
                    butonlar(j).Location = New Point(150+j *150, 50 + j)
                    butonlar(j).Size = New Size(100,100)
                    butonlar(j).BackColor = Color.Transparent
                    AddHandler butonlar(j).Click, AddressOf formyap
                    Me.Controls.Add(butonlar(j))
                Next
            ElseIf butonsayisi=3 Then
                Dim butonlar(butonsayisi) As Button
            For j As Integer = 0 To butonsayisi - 1
                butonlar(j) = New Button()
                butonlar(j).name = hobi(j).ToString()
                butonlar(j).Text = hobi(j).ToString()
                butonlar(j).Visible = True
                butonlar(j).Location = New Point(90 + j * 150, 50 + j)
                butonlar(j).Size = New Size(100, 100)
                butonlar(j).BackColor = Color.Transparent
                AddHandler butonlar(j).Click, AddressOf formyap
                Me.Controls.Add(butonlar(j))
            Next
        ElseIf butonsayisi=4 Then
            Dim butonlar(butonsayisi) As Button
            For j As Integer = 0 To butonsayisi - 1
                butonlar(j) = New Button()
                butonlar(j).name = hobi(j).ToString()
                butonlar(j).Text = hobi(j).ToString()
                butonlar(j).Visible = True
                butonlar(j).Location = New Point(50 + j * 150, 50 + j)
                butonlar(j).Size = New Size(100, 100)
                butonlar(j).BackColor = Color.Transparent
                AddHandler butonlar(j).Click, AddressOf formyap
                Me.Controls.Add(butonlar(j))
            Next
        ElseIf butonsayisi>=4 Then
            Dim butonlar(butonsayisi) As Button
            For j As Integer = 0 To butonsayisi - 1
                butonlar(j) = New Button()
                butonlar(j).name = hobi(j).ToString()
                butonlar(j).Text = hobi(j).ToString()
                butonlar(j).Visible = True
                butonlar(j).Location = New Point(20 + j * 150, 50 + j)
                butonlar(j).Size = New Size(100, 100)
                butonlar(j).BackColor = Color.Transparent
                AddHandler butonlar(j).Click, AddressOf formyap
                Me.Controls.Add(butonlar(j))
            Next
        End If
    End Sub
    'burası değişebilir
    'burda herşeyi tek tek eklemen lazım kod ile ama zor bir durum
    Private Sub formyap(sender As Object, e As EventArgs)
        Dim hobiadi As String
        hobiadi = CType(sender,Button).Name
       
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kullanıcıBilgiler as kullanıcıbilgileri=New kullanıcıbilgileri()
        kullanıcıBilgiler.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim yenigiris As giris=New giris()
        giris.sayi=0
        yenigiris.Show()
        Me.Hide()
    End Sub
End Class