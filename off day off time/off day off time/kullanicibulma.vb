
Imports System.Data.SqlClient
Imports  System.IO
Module Kullanicibulma
   
  Function Getir(ByVal tablom As Hashtable) As String
        Try
            Dim degerSayisi As Integer
            degerSayisi=tablom.Values.Count
            Dim array1(degerSayisi) As String
            For i As Integer = 0 To degerSayisi-1 
                array1(i)=Convert.ToString( tablom.Values(i)) 
            Next i
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText ="SELECT isim FROM kullanici"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
             While( dr.Read())
                Dim bulunan As String=""
                 For i As Integer = 0 To degerSayisi-1
                     If dr.GetString(0)=array1(i) Then
                        bulunan=array1(i)
                        Return bulunan
                     End If
                 Next i
             End While
  dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

   End Function
    'unutma bir parametre daha vereceksin mert
    Function Hobigetir(ByVal listem As ArrayList) As Hashtable
        Dim donen as Hashtable =New Hashtable()
        Dim uzunluk as Integer
        uzunluk=listem.Count
        For i As Integer = 0 To uzunluk-1 step 2
           If listem(i)="BESLENME" And listem(i+1)=1 Then
                Try       
               Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
               Dim cmd As SqlCommand = New SqlCommand()
               Dim dr As SqlDataReader
               cmd.Parameters.Clear()
               cmd.Connection = con
               cmd.CommandText ="select Hobi_id,Hobi_alan_adi,Boy,Kilo,su,vucutkitleindeksi,vucutkitleindeksi_degeri from beslenme,kullanici where Beslenme.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
               If con.State = ConnectionState.Closed Then
                   con.Open()
               End If
               dr = cmd.ExecuteReader()
                While(dr.Read())
                    If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                        donen.Add("Hobi_id","GİRİLMEMİŞ")
                    else
                        donen.Add("Hobi_id",dr.GetInt32(0))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                        donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                    else
                        donen.Add("Hobi_alan_adi",dr.GetString(1))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("Boy")) Then
                        donen.Add("Boy","GİRİLMEMİŞ")
                    else
                        donen.Add("Boy",dr.GetDouble(2))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("Kilo")) Then
                        donen.Add("Kilo","GİRİLMEMİŞ")
                    else
                        donen.Add("Kilo",dr.GetInt32(3))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("su")) Then
                        donen.Add("su","GİRİLMEMİŞ")
                    else
                        donen.Add("su",dr.GetInt32(4))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("vucutkitleindeksi")) Then
                        donen.Add("vucutkitleindeksi","GİRİLMEMİŞ")
                    else
                        donen.Add("vucutkitleindeksi",dr.GetDouble(5))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("vucutkitleindeks_degeri")) Then
                        donen.Add("vucutkitleindeks_degeri","GİRİLMEMİŞ")
                    else
                        donen.Add("vucutkitleindeks_degeri",dr.GetString(6))
                    End If 
                End While
                dr.Close()
                    con.Close()
      Catch ex As Exception
      MsgBox(ex.Message)
      End Try                    
                ElseIf  listem(i)="DOGA" And listem(i+1)=1 Then
                Try       
                  Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                  Dim cmd As SqlCommand = New SqlCommand()
                  Dim dr As SqlDataReader
                  cmd.Parameters.Clear()
                  cmd.Connection = con
                  cmd.CommandText ="select Hobi_id,Hobi_alan_adi,Faliyet_alanlari from doga,kullanici where doga.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                  cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                  cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                  If con.State = ConnectionState.Closed Then
                      con.Open()
                  End If
                  dr = cmd.ExecuteReader()
                    While(dr.Read())
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                             donen.Add("Hobi_id","GİRİLMEMİŞ")
                        else
                          donen.Add("Hobi_id",dr.GetInt32(0))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                            donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_alan_adi",dr.GetString(1))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Faliyet_alanlari")) Then
                            donen.Add("Faliyet_alanlari","GİRİLMEMİŞ")
                        else
                            donen.Add("Faliyet_alanlari",dr.GetString(2))
                        End If
                    End While
                   dr.Close()
                    con.Close()
              Catch ex As Exception
                  MsgBox(ex.Message)
              End Try  
                ElseIf listem(i)="EDEBİYAT" And listem(i+1)=1 Then
                Try
                 dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                    Dim cmd As SqlCommand = New SqlCommand()
                    Dim dr As SqlDataReader
                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.CommandText ="select Hobi_id,Hobi_alan_adi,Okuma_durumu,kitap_turleri,yazar_takip,yazar_adi from Edebiyat,kullanici where Edebiyat.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                    cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                    cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    dr = cmd.ExecuteReader()
                While(dr.Read())
                    If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                        donen.Add("Hobi_id","GİRİLMEMİŞ")
                    else
                        donen.Add("Hobi_id",dr.GetInt32(0))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                        donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                    else
                        donen.Add("Hobi_alan_adi",dr.GetString(1))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("Okuma_durumu")) Then
                        donen.Add("Okuma_durumu","GİRİLMEMİŞ")
                    else
                        donen.Add("Okuma_durumu",dr.GetString(2))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("Kitap_turleri")) Then
                        donen.Add("Kitap_turleri","GİRİLMEMİŞ")
                    else
                        donen.Add("Kitap_turleri",dr.GetString(3))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("Yazar_takip")) Then
                        donen.Add("Yazar_takip","GİRİLMEMİŞ")
                    else
                        donen.Add("Yazar_takip",dr.GetString(4))
                    End If
                    If   dr.IsDBNull(dr.GetOrdinal("Yazar_adi")) Then
                        donen.Add("Yazar_adi","GİRİLMEMİŞ")
                    else
                        donen.Add("Yazar_adi",dr.GetString(5))
                    End If
                End While
                    dr.Close()
                    con.Close()
                    Catch ex As Exception
                  MsgBox(ex.Message)
              End Try  
                ElseIf listem(i)="GEZİ" And listem(i+1)=1 Then
                Try
                    dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                    Dim cmd As SqlCommand = New SqlCommand()
                    Dim dr As SqlDataReader
                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.CommandText ="select Hobi_id,Hobi_alan_adi,Seyehat_yeri,Yurtdisi_gezi_yerleri,Yurtici_gezi_yerleri from gezi, kullanici where gezi.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1" 
                    cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                    cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    dr = cmd.ExecuteReader()
                    While(dr.Read())
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                            donen.Add("Hobi_id","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_id",dr.GetInt32(0))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                            donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_alan_adi",dr.GetString(1))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Seyehat_yeri")) Then
                            donen.Add("Seyehat_yeri","GİRİLMEMİŞ")
                        else
                            donen.Add("Seyehat_yeri",dr.GetString(2))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Yurtdisi_gezi_yerleri")) Then
                            donen.Add("Yurtdisi_gezi_yerleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Yurtdisi_gezi_yerleri",dr.GetString(3))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Yurtici_gezi_yerleri")) Then
                            donen.Add("Yurtici_gezi_yerleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Yurtici_gezi_yerleri",dr.GetString(4))
                        End If
                    End While
                    dr.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ElseIf listem(i)="MÜZİK" And listem(i+1)=1 Then
                Try
                    dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                    Dim cmd As SqlCommand = New SqlCommand()
                    Dim dr As SqlDataReader
                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.CommandText ="select hobi_id,hobi_alan_adi,Muzik_turleri,Enstruman,calinan_enstruman from muzik,kullanici where muzik.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                    cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                    cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    dr = cmd.ExecuteReader()
                    While(dr.Read())
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                            donen.Add("Hobi_id","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_id",dr.GetInt32(0))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                            donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_alan_adi",dr.GetString(1))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Muzik_turleri")) Then
                            donen.Add("Muzik_turleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Muzik_turleri",dr.GetString(2))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Enstruman")) Then
                            donen.Add("Enstruman","GİRİLMEMİŞ")
                        else
                            donen.Add("Enstruman",dr.GetString(3))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("calinan_enstruman")) Then
                            donen.Add("calinan_enstruman","GİRİLMEMİŞ")
                        else
                            donen.Add("calinan_enstruman",dr.GetString(4))
                        End If
                    End While
                    dr.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ElseIf listem(i)="POZİTİFBİLİMLER" And listem(i+1)=1 Then
                Try
                    dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                    Dim cmd As SqlCommand = New SqlCommand()
                    Dim dr As SqlDataReader
                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.CommandText ="select Hobi_id,Hobi_alan_adi,pozitif_alan_turleri from Pozitifbilimler,kullanici where Pozitifbilimler.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                    cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                    cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    dr = cmd.ExecuteReader()
                    While(dr.Read())
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                            donen.Add("Hobi_id","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_id",dr.GetInt32(0))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                            donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_alan_adi",dr.GetString(1))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Pozitif_alan_turleri")) Then
                            donen.Add("Pozitif_alan_turleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Pozitif_alan_turleri",dr.GetString(2))
                        End If
                    End While
                    dr.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ElseIf listem(i)="SİNEMA" And listem(i+1)=1 Then
                Try
                    dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                    Dim cmd As SqlCommand = New SqlCommand()
                    Dim dr As SqlDataReader
                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.CommandText ="select Hobi_id,Hobi_alan_adi,Film_turleri,Sevilen_oyuncu from sinema,kullanici where sinema.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                    cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                    cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    dr = cmd.ExecuteReader()
                    While(dr.Read())
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                            donen.Add("Hobi_id","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_id",dr.GetInt32(0))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                            donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_alan_adi",dr.GetString(1))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Film_turleri")) Then
                            donen.Add("Film_turleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Film_turleri",dr.GetString(2))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Sevilen_oyuncu")) Then
                            donen.Add("Sevilen_oyuncu","GİRİLMEMİŞ")
                        else
                            donen.Add("Sevilen_oyuncu",dr.GetString(3))
                        End If
                    End While
                    dr.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ElseIf listem(i)="SPOR" And listem(i+1)=1 Then
                Try
                    dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                    Dim cmd As SqlCommand = New SqlCommand()
                    Dim dr As SqlDataReader
                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.CommandText ="select Hobi_id,Hobi_alan_adi,Spor_onay,Spor__turleri,Sevilen_spor,Favori_sporcu from spor, kullanici where spor.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                    cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                    cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    dr = cmd.ExecuteReader()
                    While(dr.Read())
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                            donen.Add("Hobi_id","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_id",dr.GetInt32(0))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                            donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_alan_adi",dr.GetString(1))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Spor_onay")) Then
                            donen.Add("Spor_onay","GİRİLMEMİŞ")
                        else
                            donen.Add("Spor_onay",dr.GetString(2))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Spor__turleri")) Then
                            donen.Add("Spor__turleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Spor__turleri",dr.GetString(3))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Sevilen_spor")) Then
                            donen.Add("Sevilen_spor","GİRİLMEMİŞ")
                        else
                            donen.Add("Sevilen_spor",dr.GetString(4))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Favori_sporcu")) Then
                            donen.Add("Favori_sporcu","GİRİLMEMİŞ")
                        else
                            donen.Add("Favori_sporcu",dr.GetString(5))
                        End If
                    End While
                    dr.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ElseIf listem(i)="TEKNOLOJİ" And listem(i+1)=1 Then
                Try
                    dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                    Dim cmd As SqlCommand = New SqlCommand()
                    Dim dr As SqlDataReader
                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.CommandText =" select Hobi_id,Hobi_alan_adi,Teknoloji_alan_turleri from Teknoloji,kullanici where teknoloji.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                    cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                    cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    dr = cmd.ExecuteReader()
                    While(dr.Read())
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                            donen.Add("Hobi_id","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_id",dr.GetInt32(0))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                            donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_alan_adi",dr.GetString(1))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Teknoloji_alan_turleri")) Then
                            donen.Add("Teknoloji_alan_turleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Teknoloji_alan_turleri",dr.GetString(2))
                        End If
                    End While
                   dr.Close()
                    con.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ElseIf  listem(i)="TİYATRO" And listem(i+1)=1 Then
                Try
                dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
                    Dim cmd As SqlCommand = New SqlCommand()
                    Dim dr As SqlDataReader
                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.CommandText ="select Hobi_id,Hobi_alan_adi,Tiyatro_turleri,Tiyatro_cesitleri from Tiyatro,kullanici where tiyatro.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
                    cmd.Parameters.AddWithValue("@kullanan",giris.kullanan)
                    cmd.Parameters.AddWithValue("@kullanan1",giris.kullanan)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    dr = cmd.ExecuteReader()
                    While(dr.Read())
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_id")) Then
                            donen.Add("Hobi_id","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_id",dr.GetInt32(0))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Hobi_alan_adi")) Then
                            donen.Add("Hobi_alan_adi","GİRİLMEMİŞ")
                        else
                            donen.Add("Hobi_alan_adi",dr.GetString(1))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Tiyatro_turleri")) Then
                            donen.Add("Tiyatro_turleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Tiyatro_turleri",dr.GetString(2))
                        End If
                        If   dr.IsDBNull(dr.GetOrdinal("Tiyatro_cesitleri")) Then
                            donen.Add("Tiyatro_cesitleri","GİRİLMEMİŞ")
                        else
                            donen.Add("Tiyatro_cesitleri",dr.GetString(3))
                        End If
                    End While
                    dr.Close()
                    con.Close()
                    Catch ex As Exception
                    MsgBox(ex.Message)
                    End Try
          End If
            Return donen
        Next i
        
    End Function

  Function Butonyap(ByVal liste2 As ArrayList) As ArrayList
        Try
            Dim array1 as ArrayList=New ArrayList()
            Dim uzunluk As Integer
            uzunluk=liste2.count
            For i As Integer = 0 To uzunluk-1 step 2
                if liste2(i)="BESLENME" And liste2(i+1)=1 Then
                    array1.Add("BESLENME")
                    ElseIf liste2(i)="DOGA" And liste2(i+1)=1
                    array1.Add("DOGA")
                    ElseIf liste2(i)="EDEBİYAT" And liste2(i+1)=1
                    array1.Add("EDEBİYAT")
                    ElseIf liste2(i)="GEZİ" And liste2(i+1)=1
                    array1.Add("GEZİ")
                    ElseIf liste2(i)="MÜZİK" And liste2(i+1)=1
                    array1.Add("MÜZİK")
                    ElseIf liste2(i)="POZİTİFBİLİMLER" And liste2(i+1)=1
                    array1.Add("POZİTİFBİLİMLER")
                    ElseIf liste2(i)="SİNEMA" And liste2(i+1)=1
                    array1.Add("SİNEMA")
                    ElseIf liste2(i)="SPOR" And liste2(i+1)=1
                    array1.Add("SPOR")
                     ElseIf liste2(i)="TEKNOLOJİ" And liste2(i+1)=1
                    array1.Add("TEKNOLOJİ")
                    ElseIf liste2(i)="TİYATRO" And liste2(i+1)=1
                    array1.Add("TİYATRO")
                End If
            Next i
            Return array1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
  End Function

    Function Kullanicidondur(byval kullan As Hashtable) As Hashtable
        Return kullan
    End Function
End Module
