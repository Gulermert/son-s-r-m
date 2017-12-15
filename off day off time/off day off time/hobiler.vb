Imports off_day_off_time

Public Class Hobiler
    public Sayi1 as Integer
    Sub New (ByVal sayi As Integer)

        ' This call is required by the designer.
        sayi1=sayi
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles kategori_cb.SelectionChangeCommitted
        Select Case kategori_cb.SelectedItem
            Case "SANAT"
                ilgialani_cb.Items.Clear()
                ilgialani_cb.Items.Add("Müzik")
                ilgialani_cb.Items.Add("Edebiyat")
                ilgialani_cb.Items.Add("Sinema")
                ilgialani_cb.Items.Add("Tiyatro")
            Case "SAĞLIK"
                ilgialani_cb.Items.Clear()
                ilgialani_cb.Items.Add("Spor")
                ilgialani_cb.Items.Add("Beslenme")
            Case "BİLİM"
                ilgialani_cb.Items.Clear()
                ilgialani_cb.Items.Add("Teknoloji")
                ilgialani_cb.Items.Add("Pozitif Bilimler")
            Case "YAŞAM"
                ilgialani_cb.Items.Clear()
                ilgialani_cb.Items.Add("Gezi")
                ilgialani_cb.Items.Add("Doğa")

        End Select

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ilgialani_cb.SelectionChangeCommitted

        Select Case ilgialani_cb.SelectedItem
            Case "Müzik"
                Try
                  
                    muzikgb.Visible = True
                    muzikaletii_l.Visible = False
                    muzikaleti_cb.Visible = False
                    edebiyat_gb.Visible = False
                    sinema_gb.Visible = False
                    tiyatro_gb.Visible = False
                    spor_gb.Visible = False
                    beslenme_gb.Visible = False
                    teknoloji_gb.Visible = False
                    pozitifbilim_gb.Visible = False
                    gezi_gb.Visible = False
                    doga_gb.Visible = False

                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case "Edebiyat"
                Try

                    edebiyat_gb.Visible = True
                    kitap_lb.Visible = False
                    kitap_clb.Visible = False
                    yazar_lb.Visible = False
                    yazar_tb.Visible = False
                    muzikgb.Visible = False

                    sinema_gb.Visible = False
                    tiyatro_gb.Visible = False
                    spor_gb.Visible = False
                    beslenme_gb.Visible = False
                    teknoloji_gb.Visible = False
                    pozitifbilim_gb.Visible = False
                    gezi_gb.Visible = False
                    doga_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case "Sinema"
                Try
                    sinema_gb.Visible = True
                    muzikgb.Visible = False
                    edebiyat_gb.Visible = False

                    tiyatro_gb.Visible = False
                    spor_gb.Visible = False
                    beslenme_gb.Visible = False
                    teknoloji_gb.Visible = False
                    pozitifbilim_gb.Visible = False
                    gezi_gb.Visible = False
                    doga_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try

            Case "Tiyatro"
                Try
                    tiyatro_gb.Visible = True
                    muzikgb.Visible = False
                    edebiyat_gb.Visible = False
                    sinema_gb.Visible = False

                    spor_gb.Visible = False
                    beslenme_gb.Visible = False
                    teknoloji_gb.Visible = False
                    pozitifbilim_gb.Visible = False
                    gezi_gb.Visible = False
                    doga_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case "Spor"
                Try
                    spor_gb.Visible = True
                    yapılanspor_clb.Visible = False
                    spor_lb.Visible = False
                    muzikgb.Visible = False
                    edebiyat_gb.Visible = False
                    sinema_gb.Visible = False
                    tiyatro_gb.Visible = False

                    beslenme_gb.Visible = False
                    teknoloji_gb.Visible = False
                    pozitifbilim_gb.Visible = False
                    gezi_gb.Visible = False
                    doga_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case "Beslenme"
                Try
                    beslenme_gb.Visible = True
                    muzikgb.Visible = False
                    edebiyat_gb.Visible = False
                    sinema_gb.Visible = False
                    tiyatro_gb.Visible = False
                    spor_gb.Visible = False

                    teknoloji_gb.Visible = False
                    pozitifbilim_gb.Visible = False
                    gezi_gb.Visible = False
                    doga_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case "Teknoloji"
                Try
                    teknoloji_gb.Visible = True
                    muzikgb.Visible = False
                    edebiyat_gb.Visible = False
                    sinema_gb.Visible = False
                    tiyatro_gb.Visible = False
                    spor_gb.Visible = False
                    beslenme_gb.Visible = False

                    pozitifbilim_gb.Visible = False
                    gezi_gb.Visible = False
                    doga_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case "Pozitif Bilimler"
                Try
                    pozitifbilim_gb.Visible = True
                    muzikgb.Visible = False
                    edebiyat_gb.Visible = False
                    sinema_gb.Visible = False
                    tiyatro_gb.Visible = False
                    spor_gb.Visible = False
                    beslenme_gb.Visible = False
                    teknoloji_gb.Visible = False

                    gezi_gb.Visible = False
                    doga_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case "Gezi"
                Try
                    yurtdısı_gb.Visible = False
                    yurtiçi_gb.Visible = False
                    gezi_gb.Visible = True
                    muzikgb.Visible = False
                    edebiyat_gb.Visible = False
                    sinema_gb.Visible = False
                    tiyatro_gb.Visible = False
                    spor_gb.Visible = False
                    beslenme_gb.Visible = False
                    teknoloji_gb.Visible = False
                    pozitifbilim_gb.Visible = False

                    doga_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case "Doğa"
                Try
                    doga_gb.Visible = True
                    muzikgb.Visible = False
                    edebiyat_gb.Visible = False
                    sinema_gb.Visible = False
                    tiyatro_gb.Visible = False
                    spor_gb.Visible = False
                    beslenme_gb.Visible = False
                    teknoloji_gb.Visible = False
                    pozitifbilim_gb.Visible = False
                    gezi_gb.Visible = False
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
        End Select


    End Sub

    Private Sub hobiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bilgiler.Timer1.Stop()
        If Sayi1=1 Then
            devamb.Visible=False
        End If
        muzikgb.Visible = False
        edebiyat_gb.Visible = False
        sinema_gb.Visible = False
        tiyatro_gb.Visible = False
        spor_gb.Visible = False
        beslenme_gb.Visible = False
        teknoloji_gb.Visible = False
        pozitifbilim_gb.Visible = False
        gezi_gb.Visible = False
        doga_gb.Visible = False
    End Sub
    Private Sub hobib_Click(sender As Object, e As EventArgs) Handles hobib.Click

        ilgialani_cb.Items.Clear()
        kategori_cb.Text = ""
        ilgialani_cb.Text = ""
        muzikgb.Visible = False
        edebiyat_gb.Visible = False
        sinema_gb.Visible = False
        tiyatro_gb.Visible = False
        spor_gb.Visible = False
        beslenme_gb.Visible = False
        teknoloji_gb.Visible = False
        pozitifbilim_gb.Visible = False
        gezi_gb.Visible = False
        doga_gb.Visible = False
        For i As Integer = 0 To muzikturleri_cl.Items.Count-1
            If muzikturleri_cl.GetItemChecked(i)
            muzikturleri_cl.SetItemChecked(i,False)
                End If
        Next i
        muzikevet_rb.Checked=False
        muzikhayir_rb.Checked=False
        muzikaleti_cb.Text=$""
        For i As Integer = 0 To kitap_clb.Items.Count-1
            If kitap_clb.GetItemChecked(i)
                kitap_clb.SetItemChecked(i,False)
            End If
        Next i
        Ekitapevet_rb.Checked=False
        Ekitaphayir_rb.Checked=False
        Eyazarevet_rb.Checked=False
        Eyazarhayir_rb.Checked=False
        yazar_tb.Clear()
        For i As Integer = 0 To film_clb.Items.Count-1
            If film_clb.GetItemChecked(i)
                film_clb.SetItemChecked(i,False)
            End If
        Next i
        oyuncu_tb.Clear()
        For i As Integer = 0 To CheckedListBox1.Items.Count-1
            If CheckedListBox1.GetItemChecked(i)
                CheckedListBox1.SetItemChecked(i,False)
            End If
        Next i
        CheckBox1.Checked=False
        CheckBox2.Checked=False
        CheckBox3.Checked=False
        RadioButton7.Checked=False
        RadioButton8.Checked=False
        For i As Integer = 0 To yapılanspor_clb.Items.Count-1
            If yapılanspor_clb.GetItemChecked(i)
                yapılanspor_clb.SetItemChecked(i,False)
            End If  
        Next i
        For i As Integer = 0 To izlenilenspor_clb.Items.Count-1
            If izlenilenspor_clb.GetItemChecked(i)
                izlenilenspor_clb.SetItemChecked(i,False)
            End If
        Next i
        sporcu_tb.Clear()
        boy_tb.Clear()
        kilo_tb.Clear()
        su_tb.Clear()
        For i As Integer = 0 To teknoloji_clb.Items.Count-1
            If teknoloji_clb.GetItemChecked(i) Then
                teknoloji_clb.SetItemChecked(i,False)
            End If
        Next i
        For i As Integer = 0 To pozitifb_clb.Items.Count-1
            If pozitifb_clb.GetItemChecked(i)
                pozitifb_clb.SetItemChecked(i,False)
            End If
        Next i
        For i As Integer = 0 To sehir_clb.Items.Count-1
            If sehir_clb.GetItemChecked(i)
                sehir_clb.SetItemChecked(i,False)
            End If
        Next i
        For i As Integer = 0 To ulke_clb.Items.Count-1
            If ulke_clb.GetItemChecked(i)
                ulke_clb.SetItemChecked(i,False)
            End If
        Next i
        For i As Integer = 0 To doga_clb.Items.Count-1
            If doga_clb.GetItemChecked(i)
                doga_clb.SetItemChecked(i,False)
            End If
        Next i

    End Sub
    Private Sub oyuncu_tb_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub sporcu_tb_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub boy_tb_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub kilo_tb_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub su_tb_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub yazar_tb_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub kaydetb_Click(sender As Object, e As EventArgs) Handles kaydetb.Click
        Select Case ilgialani_cb.SelectedItem
            Case "Müzik"
               Try
                    Dim kelime As String
                    If sayi1=0 Then
                     kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                        ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yeniMüzik As Muzik=New Muzik(kelime)
                    Dim boyut as Integer
                    boyut = muzikturleri_cl.CheckedItems.Count
                    ReDim Preserve yeniMüzik.MuzikTurleri(boyut)
                    For i As Integer = 0 To boyut - 1
                        yeniMüzik.MuzikTurleri(i) = muzikturleri_cl.CheckedItems(i)
                    Next i
                    If muzikevet_rb.Checked Then
                      yeniMüzik.Enstruman=$"Evet"
                        yeniMüzik.CalEnstruman=muzikaleti_cb.Text
                    ElseIf muzikhayir_rb.Checked
                        yeniMüzik.Enstruman=$"Hayır"
                       yeniMüzik.Enstruman=""
                    End If
                    
                    yeniMüzik.kaydet()
                     For i As Integer = 0 To muzikturleri_cl.Items.Count-1
                       If muzikturleri_cl.GetItemChecked(i)
                           muzikturleri_cl.SetItemChecked(i,False)
                       End If
                     Next i
                    muzikevet_rb.Checked=False
                    muzikhayir_rb.Checked=False
                    muzikaleti_cb.Text=$""
                    Catch ex As Exception
                    MsgBox(ex.Message)
                    End Try
            Case "Edebiyat"
                Try
                    Dim kelime As String
                    If sayi1=0 Then
                        kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                    ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yeniEdebiyat as Edebiyat=New Edebiyat(kelime)
                    If Ekitapevet_rb.Checked Then
                            yeniEdebiyat.Okuma=$"Evet"
                    ElseIf Ekitaphayir_rb.Checked
                             yeniEdebiyat.Okuma=$"Hayır"
                    End If
                    Dim boyut As Integer
                    boyut=kitap_clb.CheckedItems.Count
                    ReDim Preserve yeniEdebiyat.Kitapturu(boyut)
                    For i As Integer = 0 To boyut-1
                        yeniEdebiyat.Kitapturu(i)=kitap_clb.CheckedItems(i)
                    Next i
                    If Eyazarevet_rb.Checked Then
                        yeniEdebiyat.Yazarvarmi=$"Evet"
                        yeniEdebiyat.Yazaradi=yazar_tb.Text
                        ElseIf  Eyazarhayir_rb.Checked Then
                        yeniEdebiyat.Yazarvarmi=$"Hayır"
                        yeniEdebiyat.Yazaradi=""
                    End If
                    yeniEdebiyat.kaydet()
                    For i As Integer = 0 To kitap_clb.Items.Count-1
                        If kitap_clb.GetItemChecked(i)
                            kitap_clb.SetItemChecked(i,False)
                        End If
                    Next i
                    Ekitapevet_rb.Checked=False
                    Ekitaphayir_rb.Checked=False
                    Eyazarevet_rb.Checked=False
                    Eyazarhayir_rb.Checked=False
                    yazar_tb.Clear()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "Sinema"
                Try
                        Dim kelime As String
                        If sayi1=0 Then
                            kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                        ElseIf Sayi1=1 Then
                            kelime=Kullanicibulma.Getir(giris.tablo1)
                        End If
                    Dim yenisinema as Sinema=New Sinema(kelime)
                    Dim boyut As Integer
                    boyut=film_clb.CheckedItems.Count
                    ReDim Preserve yenisinema.Filmturu(boyut)
                        For i As Integer = 0 To boyut-1
                            yenisinema.Filmturu(i)=film_clb.CheckedItems(i)
                        Next i
                    yenisinema.Oyuncu=oyuncu_tb.Text
                    yenisinema.kaydet()
                        For i As Integer = 0 To film_clb.Items.Count-1
                            If film_clb.GetItemChecked(i)
                                film_clb.SetItemChecked(i,False)
                            End If
                        Next i
                        oyuncu_tb.Clear()
                    Catch ex As Exception
                    MsgBox(ex.Message)
                    End Try
            Case "Tiyatro"
                Try
                    Dim kelime As String
                    If sayi1=0 Then
                        kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                    ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yenitiyatro as Tiyatro=New Tiyatro(kelime)
                    Dim boyut as Integer
                    boyut=CheckedListBox1.CheckedItems.Count
                    ReDim Preserve yenitiyatro.Tiyatroturu(boyut)
                    For i As Integer = 0 To boyut-1
                        yenitiyatro.Tiyatroturu(i)=CheckedListBox1.CheckedItems(i)
                    Next i
                    If CheckBox1.Checked Then
                        yenitiyatro.Tiyatrocesit=$"Devlet Tiyatroları"                  
                    End If
                    If CheckBox2.Checked Then
                        yenitiyatro.Tiyatrocesit=$"Şehir Tiyatroları"
                    End If
                    If CheckBox3.Checked Then
                        yenitiyatro.Tiyatrocesit=$"Özel Tiyatrolar"
                    End If
                    yenitiyatro.kaydet()
                    For i As Integer = 0 To CheckedListBox1.Items.Count-1
                        If CheckedListBox1.GetItemChecked(i)
                            CheckedListBox1.SetItemChecked(i,False)
                        End If
                    Next i
                    CheckBox1.Checked=False
                  CheckBox2.Checked=False
                    CheckBox3.Checked=False
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "Spor"
                Try
                    Dim kelime As String
                    If sayi1=0 Then
                        kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                    ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yenispor As Spor=New Spor(kelime)
                    If RadioButton7.Checked Then
                        yenispor.Sporonay=$"Evet"
                        ElseIf RadioButton8.Checked Then
                        yenispor.Sporonay=$"Hayır"
                    End If
                    Dim boyut as Integer
                    boyut=yapılanspor_clb.CheckedItems.Count
                    ReDim Preserve yenispor.Sporturu(boyut)
                    For i As Integer = 0 To boyut-1
                        yenispor.Sporturu(i)=yapılanspor_clb.CheckedItems(i)
                    Next i
                    Dim boyut2 As Integer
                    boyut2=izlenilenspor_clb.CheckedItems.Count
                    ReDim Preserve yenispor.Izlemespor(boyut2)
                    For i As Integer = 0 To boyut2-1
                        yenispor.Izlemespor(i)=izlenilenspor_clb.CheckedItems(i)
                    Next i
                    yenispor.Favorisporcu=sporcu_tb.Text
                    yenispor.kaydet()
                    RadioButton7.Checked=False
                    RadioButton8.Checked=False
                    For i As Integer = 0 To yapılanspor_clb.Items.Count-1
                        If yapılanspor_clb.GetItemChecked(i)
                            yapılanspor_clb.SetItemChecked(i,False)
                        End If  
                    Next i
                    For i As Integer = 0 To izlenilenspor_clb.Items.Count-1
                        If izlenilenspor_clb.GetItemChecked(i)
                            izlenilenspor_clb.SetItemChecked(i,False)
                        End If
                    Next i
                    sporcu_tb.Clear()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "Beslenme"
                Try
                    Dim kelime As String
                    If sayi1=0 Then
                        kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                    ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yenibeslenme as Beslenme=New Beslenme(kelime)
                    yenibeslenme.Boy=Convert.ToDouble(boy_tb.Text)*(1/100)   
                    yenibeslenme.Kilo=Convert.ToInt32( kilo_tb.Text) 
                    yenibeslenme.Su=Convert.ToInt32(su_tb.Text)  
                    yenibeslenme.Vucutindeks=CDbl(yenibeslenme.Kilo/Math.Pow(yenibeslenme.Boy,2))
                    if yenibeslenme.Vucutindeks<=18.5 Then
                        yenibeslenme.Vucutindeksdegeri=$"Düşük Kilolu"
                        ElseIf yenibeslenme.Vucutindeks>=18.6 And yenibeslenme.Vucutindeks<=24.9 Then
                        yenibeslenme.Vucutindeksdegeri=$"Normal Kilolu"
                        ElseIf yenibeslenme.Vucutindeks>=25.0 And yenibeslenme.Vucutindeks<=29.9 Then
                        yenibeslenme.Vucutindeksdegeri=$"Fazla Kilolu"
                        ElseIf yenibeslenme.Vucutindeks>=30.0 And yenibeslenme.Vucutindeks<=40.0 Then
                        yenibeslenme.Vucutindeksdegeri=$"Obez"
                        ElseIf yenibeslenme.Vucutindeks>=40.1 Then
                        yenibeslenme.Vucutindeksdegeri=$"Aşırı Obez"
                    End If
                   yenibeslenme.kaydet()
                    boy_tb.Clear()
                    kilo_tb.Clear()
                    su_tb.Clear()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "Teknoloji"
                Try
                    Dim kelime As String
                    If sayi1=0 Then
                        kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                    ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yeniteknoloji As Teknoloji=New Teknoloji(kelime)
                    Dim boyut As Integer
                    boyut=teknoloji_clb.CheckedItems.Count
                    ReDim Preserve yeniteknoloji.Teknolojiturleri(boyut)
                    For i As Integer = 0 To boyut-1
                        yeniteknoloji.Teknolojiturleri(i)=teknoloji_clb.CheckedItems(i)
                    Next i
                    yeniteknoloji.kaydet()
                    For i As Integer = 0 To teknoloji_clb.Items.Count-1
                        If teknoloji_clb.GetItemChecked(i) Then
                            teknoloji_clb.SetItemChecked(i,False)
                        End If
                    Next i

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "Pozitif Bilimler"
                Try
                    Dim kelime As String
                    If sayi1=0 Then
                        kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                    ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yenipozitif as Pozitifbilimler=New Pozitifbilimler(kelime)
                    Dim boyut As Integer
                    boyut=pozitifb_clb.CheckedItems.Count
                    ReDim Preserve yenipozitif.Pozitifturler(boyut)
                    For i As Integer = 0 To boyut-1
                        yenipozitif.Pozitifturler(i)=pozitifb_clb.CheckedItems(i)
                    Next i
                    yenipozitif.kaydet()
                    For i As Integer = 0 To pozitifb_clb.Items.Count-1
                        If pozitifb_clb.GetItemChecked(i)
                            pozitifb_clb.SetItemChecked(i,False)
                        End If
                    Next i
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "Gezi"
                Try
                    Dim kelime As String
                    If sayi1=0 Then
                        kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                    ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yenigezi as Gezi=New Gezi(kelime)
                    if RadioButton9.Checked Then
                        yenigezi.Seyehatyeri=$"Yurtdışı"
                        Dim boyut As Integer
                        boyut=ulke_clb.CheckedItems.Count
                        ReDim Preserve yenigezi.yurtdisi(boyut)
                        For i As Integer = 0 To boyut-1
                            yenigezi.yurtdisi(i)=ulke_clb.CheckedItems(i)    
                        Next i

                        ElseIf RadioButton10.Checked Then
                        yenigezi.Seyehatyeri=$"Yurtiçi"
                        Dim boyut As Integer
                        boyut= sehir_clb.CheckedItems.Count
                        ReDim Preserve yenigezi.yurtici(boyut)
                            For i As Integer = 0 To boyut-1
                                yenigezi.yurtici(i)=sehir_clb.CheckedItems(i)
                            Next i
                        yenigezi.kaydet()
                            For i As Integer = 0 To sehir_clb.Items.Count-1
                            If sehir_clb.GetItemChecked(i)
                                sehir_clb.SetItemChecked(i,False)
                            End If
                            Next i
                            For i As Integer = 0 To ulke_clb.Items.Count-1
                            If ulke_clb.GetItemChecked(i)
                                ulke_clb.SetItemChecked(i,False)
                            End If
                            Next i
                    End If
                    
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "Doğa"
                Try
                    Dim kelime As String
                    If sayi1=0 Then
                        kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                    ElseIf Sayi1=1 Then
                        kelime=Kullanicibulma.Getir(giris.tablo1)
                    End If
                    Dim yenidoga As Doga=New Doga(kelime)
                    Dim boyut As Integer
                    boyut=doga_clb.CheckedItems.Count
                    ReDim Preserve yenidoga.Dogaturleri(boyut)
                    For i As Integer = 0 To boyut-1
                        yenidoga.Dogaturleri(i)=doga_clb.CheckedItems(i)
                    Next i
                   yenidoga.Kaydet()
                    For i As Integer = 0 To doga_clb.Items.Count-1
                        If doga_clb.GetItemChecked(i)
                            doga_clb.SetItemChecked(i,False)
                        End If
                    Next i
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        End Select
    End Sub

    Private Sub devamb_Click(sender As Object, e As EventArgs) Handles devamb.Click
      Dim gAktivite as gaktivite=New gaktivite(0)
        gAktivite.Show()
        Me.Hide()
    End Sub

    Private Sub muzikevet_rb_CheckedChanged_1(sender As Object, e As EventArgs) Handles muzikevet_rb.CheckedChanged
        muzikaletii_l.Visible = True
        muzikaleti_cb.Visible = True
    End Sub

    Private Sub muzikhayir_rb_CheckedChanged_1(sender As Object, e As EventArgs) Handles muzikhayir_rb.CheckedChanged
        muzikaletii_l.Visible = False
        muzikaleti_cb.Visible = False
    End Sub

    Private Sub Ekitapevet_rb_CheckedChanged_1(sender As Object, e As EventArgs) Handles Ekitapevet_rb.CheckedChanged
        kitap_lb.Visible = True
        kitap_clb.Visible = True
    End Sub

    Private Sub Ekitaphayir_rb_CheckedChanged(sender As Object, e As EventArgs) Handles Ekitaphayir_rb.CheckedChanged
        kitap_lb.Visible = False
        kitap_clb.Visible = False
    End Sub

    Private Sub Eyazarevet_rb_CheckedChanged(sender As Object, e As EventArgs) Handles Eyazarevet_rb.CheckedChanged
        yazar_tb.Visible=True
        yazar_lb.Visible=True
    End Sub

    Private Sub Eyazarhayir_rb_CheckedChanged(sender As Object, e As EventArgs) Handles Eyazarhayir_rb.CheckedChanged
        yazar_tb.Visible=False
        yazar_lb.Visible=False
    End Sub

    Private Sub RadioButton7_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        yapılanspor_clb.Visible = True
        spor_lb.Visible = True
    End Sub

    Private Sub RadioButton8_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        yapılanspor_clb.Visible = False
        spor_lb.Visible = False
    End Sub

    Private Sub RadioButton9_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        yurtdısı_gb.Visible = True
        yurtiçi_gb.Visible=False
    End Sub

    Private Sub RadioButton10_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged  
      yurtiçi_gb.Visible=True
        yurtdısı_gb.Visible = false
    End Sub

End Class