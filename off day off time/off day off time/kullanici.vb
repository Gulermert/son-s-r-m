Imports System.Data.SqlClient

 Public  Class kullanici
  Private _ad As String
    Public Property ad As String
        Get
            Return _ad
        End Get
        Set(ByVal value As String)
            _ad = value
        End Set
    End Property
    Private _soyad As String
    Public Property soyad As String
        Get
            Return _soyad
        End Get
        Set(ByVal value As String)
            _soyad = value
        End Set
    End Property
    Private _dogumTarihi As DateTime
    Public Property DogumTarihi As DateTime
        Get
            Return _dogumTarihi
        End Get
        Set(ByVal value As DateTime)
            _dogumTarihi = value
        End Set
    End Property
    Private _yas As String
    Private _telefon As String
    Public Property telefon As String
        Get
            Return _telefon
        End Get
        Set(ByVal value As String)
            _telefon = value
        End Set
    End Property
    Private _sehir As String
    Public Property sehir As String
        Get
            Return _sehir
        End Get
        Set(ByVal value As String)
            _sehir = value
        End Set
    End Property
    Private _semt As String
    Public Property semt As String
        Get
            Return _semt
        End Get
        Set(ByVal value As String)
            _semt = value
        End Set
    End Property
    Private _posta_kodu As String
    Public Property posta_kodu As String
        Get
            Return _posta_kodu
        End Get
        Set(ByVal value As String)
            _posta_kodu = value
        End Set
    End Property
    Private _e_mail As String
    Public Property e_mail As String
        Get
            Return _e_mail
        End Get
        Set(ByVal value As String)
            _e_mail = value
        End Set
    End Property
    Private _sifre As String
    Public Property sifre As String
        Get
            Return _sifre
        End Get
        Set(ByVal value As String)
            _sifre = value
        End Set
    End Property
    Private _sifre_tekrar As String
    Public Property sifre_tekrar As String
        Get
            Return _sifre_tekrar
        End Get
        Set(ByVal value As String)
            _sifre_tekrar = value
        End Set
    End Property
    Private _meslek As String
    Public Property meslek As String
        Get
            Return _meslek
        End Get
        Set(ByVal value As String)
            _meslek = value
        End Set
    End Property
    Private _resim_yolu As String
    Public Property resim_yolu As String
        Get
            Return _resim_yolu
        End Get
        Set(ByVal value As String)
            _resim_yolu = value
        End Set
    End Property
    Public Overridable Sub Kaydet()
        Try
            _yas= (Year(DateTime.Now) - Year(_dogumTarihi)).ToString()
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO kullanici(isim,soyisim,dogum_tarihi,yas,telefon,sehir,semt,posta_kodu,e_mail,sifre,sifre_tekrar,meslek,resim_yolu) values(@ad,@soyad,@dogum_tarihi,@yas,@telefon,@sehir,@semt,@posta_kodu,@e_mail,@sifre,@sifre_tekrar,@meslek,@resim)"
            cmd.Parameters.AddWithValue("@ad", _ad)
            cmd.Parameters.AddWithValue("@soyad", _soyad)
            cmd.Parameters.AddWithValue("@dogum_tarihi", _dogumTarihi)
            cmd.Parameters.AddWithValue("@yas", _yas)
            cmd.Parameters.AddWithValue("@telefon", _telefon)
            cmd.Parameters.AddWithValue("@sehir", _sehir)
            cmd.Parameters.AddWithValue("@semt", _semt)
            cmd.Parameters.AddWithValue("@posta_kodu", _posta_kodu)
            cmd.Parameters.AddWithValue("@e_mail", _e_mail)
            cmd.Parameters.AddWithValue("@sifre", _sifre)
            cmd.Parameters.AddWithValue("@sifre_tekrar", _sifre_tekrar)
            cmd.Parameters.AddWithValue("@meslek", _meslek)
            cmd.Parameters.AddWithValue("@resim", _resim_yolu)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

Public Class Hobi
    Inherits kullanici
    Protected KullaniciId As Integer
    Protected HobiAlanAdi As String
    Protected HobiId As Integer
End Class

Public Class Muzik
    Inherits Hobi
    Public MuzikTurleri() As String
    Public Enstruman As String
    Public CalEnstruman As String
    Public Sub New(byval kelime as string)
        Try
            HobiAlanAdi = $"SANAT"
            Randomize()
            Dim ratgele As Random = New Random() 
            HobiId = ratgele.Next(0, 25)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim",kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    public Overrides sub kaydet()
        Try
            Dim metin As String = ""
            For i As Integer = 0 To MuzikTurleri.Length - 1
                metin += String.Concat(MuzikTurleri(i) + ",")
            Next i
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Muzik(Hobi_id,Kullanici_id,Hobi_alan_adi,Muzik_turleri,Enstruman,calinan_enstruman) values(@Hobi_id,@Kullanici_id,@Hobi_alan_adi,@Muzik_turleri,@Enstruman,@calinan_enstruman)"
            cmd.Parameters.AddWithValue("@Hobi_id", HobiId)
            cmd.Parameters.AddWithValue("@Kullanici_id", KullaniciId)
            cmd.Parameters.AddWithValue("@Hobi_alan_adi", HobiAlanAdi)
            cmd.Parameters.AddWithValue("@Muzik_turleri", metin)
            cmd.Parameters.AddWithValue("@Enstruman", Enstruman)
            cmd.Parameters.AddWithValue("@calinan_enstruman", CalEnstruman)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End sub
End Class

Public Class Edebiyat
    Inherits Hobi
    public Okuma As String
    public Kitapturu() as String
    public Yazarvarmi as String
    Public Yazaradi as String
    Public Sub New (ByVal kelime As String)
        Try
            HobiAlanAdi = $"SANAT"
            Randomize()
            Dim ratgele As Random = New Random()
            HobiId = ratgele.Next(26, 50)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim", kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    public Overrides sub kaydet()
        Try
        Dim metin As String = ""
        For i As Integer = 0 To Kitapturu.Length - 1
            metin += String.Concat(Kitapturu(i) + ",")
        Next i
      Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
      Dim cmd As SqlCommand = New SqlCommand()
      cmd.Parameters.Clear()
      cmd.Connection = con
      cmd.CommandText = "INSERT INTO Edebiyat(Hobi_id,Kullanici_id,Hobi_alan_adi,Okuma_durumu,Kitap_turleri,Yazar_takip,Yazar_adi) values(@Hobiid,@kullaniciid,@hobialanadi,@okumadurumu,@kitapturleri,@yazartakip,@yazaradi)"
        cmd.Parameters.AddWithValue("@Hobiid",HobiId)
        cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
        cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
        cmd.Parameters.AddWithValue("@okumadurumu",Okuma)
        cmd.Parameters.AddWithValue("@kitapturleri",metin)
        cmd.Parameters.AddWithValue("@yazartakip",Yazarvarmi)
        cmd.Parameters.AddWithValue("@yazaradi",Yazaradi)
      If con.State = ConnectionState.Closed Then
          con.Open()
      End If
      cmd.ExecuteNonQuery()
      con.Close()
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End sub
End Class

Public Class Sinema 
    Inherits Hobi
    Public Filmturu() As String
    public Oyuncu As String 
    public sub New(ByVal kelime As String)
        Try
            HobiAlanAdi = $"SANAT"
            Randomize()
            Dim ratgele As Random = New Random()
            HobiId = ratgele.Next(51,75)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim", kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End sub
    Public Overrides Sub kaydet()
        Try
        Dim metin as String=""
        For i As Integer = 0 To Filmturu.Length-1
            metin+=String.Concat(Filmturu(i)+",")
        Next i
        Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Sinema(Hobi_id,Kullanici_id,Hobi_alan_adi,Film_turleri,Sevilen_oyuncu)values(@Hobiid,@kullaniciid,@hobialanadi,@filmturleri,@sevilenoyuncu)"
            cmd.Parameters.AddWithValue("@Hobiid",HobiId)
            cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
            cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
            cmd.Parameters.AddWithValue("@filmturleri",metin)
            cmd.Parameters.AddWithValue("@sevilenoyuncu",Oyuncu)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

Public Class Tiyatro
    Inherits Hobi
    public Tiyatroturu() as String
    public Tiyatrocesit as String
    Public Sub  New (ByVal kelime As String)
        Try
             HobiAlanAdi = $"SANAT"
             Randomize()
             Dim ratgele As Random = New Random()
             HobiId = ratgele.Next(76,100)
                 Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
              Dim cmd As SqlCommand = New SqlCommand()
              Dim dr As SqlDataReader
             cmd.Parameters.Clear()
             cmd.Connection = con
             cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
             cmd.Parameters.AddWithValue("@isim", kelime)
             If con.State = ConnectionState.Closed Then
             con.Open()
                End If
             dr = cmd.ExecuteReader()
             While (dr.Read())
                 KullaniciId = dr.GetInt32(0)
                 ad = dr.GetString(1)
                 soyad = dr.GetString(2)
            End While
             dr.Close()
            con.Close()
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub
    Public Overrides sub kaydet()
        Try
        Dim metin as String=""
        For i As Integer = 0 To Tiyatroturu.Length-1
            metin+=String.Concat(Tiyatroturu(i)+",")
        Next i
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Tiyatro(Hobi_id,Kullanici_id,Hobi_alan_adi,Tiyatro_turleri,Tiyatro_cesitleri)values(@Hobiid,@kullaniciid,@hobialanadi,@tiyatroturleri,@tiyatrocesitleri)"
            cmd.Parameters.AddWithValue("@Hobiid",HobiId)
            cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
            cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
            cmd.Parameters.AddWithValue("@tiyatroturleri",metin)
            cmd.Parameters.AddWithValue("@tiyatrocesitleri",Tiyatrocesit)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End sub
End Class

Public Class Spor
    Inherits Hobi
    Public Sporonay As String
    public Sporturu() as String
    public Izlemespor() as String
    public Favorisporcu as String
    public Sub New (ByVal kelime As String)
        Try
            HobiAlanAdi = $"SAĞLIK"
            Randomize()
            Dim ratgele As Random = New Random()
            HobiId = ratgele.Next(101,125)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim", kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub kaydet()
        Try
        Dim metin1 as String=""
        Dim metin2 as String=""
        For i As Integer = 0 To Sporturu.Length-1
            metin1+=String.Concat(Sporturu(i)+",")
        Next i
        For i As Integer = 0 To Izlemespor.Length-1
            metin2+=String.Concat(Izlemespor(i)+",")
        Next i
        Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Spor(Hobi_id,Kullanici_id,Hobi_alan_adi,Spor_onay,Spor__turleri,Sevilen_spor,Favori_sporcu) values(@Hobiid,@kullaniciid,@hobialanadi,@sporonay,@sporturleri,@sevilensporlar,@favorisporcu)"
            cmd.Parameters.AddWithValue("@Hobiid",HobiId)
            cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
            cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
            cmd.Parameters.AddWithValue("@sporonay",Sporonay)
            cmd.Parameters.AddWithValue("@sporturleri",metin1)
            cmd.Parameters.AddWithValue("@sevilensporlar",metin2)
            cmd.Parameters.AddWithValue("@favorisporcu",Favorisporcu)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
            catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub
End Class

Public Class Beslenme
    Inherits Hobi
    Public Boy as Double
    public Kilo as Integer
    Public Su As Integer
    public Vucutindeks As Double
    public Vucutindeksdegeri as String
    Public Sub New (ByVal kelime As String)
        Try
            HobiAlanAdi = $"SAĞLIK"
            Randomize()
            Dim ratgele As Random = New Random()
            HobiId = ratgele.Next(126,150)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim", kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Overrides Sub kaydet()
        Try
        Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Beslenme(Hobi_id,Kullanici_id,Hobi_alan_adi,Boy,Kilo,su,vucutkitleindeksi,vucutkitleindeksi_degeri) values(@Hobiid,@kullaniciid,@hobialanadi,@boy,@kilo,@su,@vucutkitleindeksi,@vucutkitleindeksi_degeri)"
        cmd.Parameters.AddWithValue("@Hobiid",HobiId)
        cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
        cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
        cmd.Parameters.AddWithValue("@boy",Boy)
        cmd.Parameters.AddWithValue("@kilo",Kilo)
        cmd.Parameters.AddWithValue("@su",Su)
        cmd.Parameters.AddWithValue("@vucutkitleindeksi",Vucutindeks)
        cmd.Parameters.AddWithValue("@vucutkitleindeksi_degeri",Vucutindeksdegeri.ToString())
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.ExecuteNonQuery()
        con.Close()
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub
End Class

Public Class Teknoloji
    Inherits Hobi
     Public Teknolojiturleri() As String
    Public Sub New (ByVal kelime As String)
        Try
            HobiAlanAdi = $"BİLİM"
            Randomize()
            Dim ratgele As Random = New Random()
            HobiId = ratgele.Next(151,175)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim", kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides sub kaydet()
        Try
             Dim metin as String=""
             For i As Integer = 0 To Teknolojiturleri.Length-1
             metin+=String.Concat(Teknolojiturleri(i)+",")
             Next i
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Teknoloji(Hobi_id,Kullanici_id,Hobi_alan_adi,Teknoloji_alan_turleri)values(@hobiid,@kullaniciid,@hobialanadi,@teknolojialanturleri)"
            cmd.Parameters.AddWithValue("@Hobiid",HobiId)
            cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
            cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
            cmd.Parameters.AddWithValue("@teknolojialanturleri",metin)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End sub
End Class

Public Class Pozitifbilimler 
    Inherits Hobi
    public Pozitifturler() as String
    Public Sub New (ByVal kelime As  String)
        Try
            HobiAlanAdi = $"BİLİM"
            Randomize()
            Dim ratgele As Random = New Random()
            HobiId = ratgele.Next(176,200)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim", kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public  Overrides sub kaydet()
        Try
        Dim metin as String=""
        For i As Integer = 0 To Pozitifturler.Length-1
            metin+=String.Concat(Pozitifturler(i)+",")
        Next
        Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Pozitifbilimler(Hobi_id,Kullanici_id,Hobi_alan_adi,Pozitif_alan_turleri) values(@hobiid,@kullaniciid,@hobialanadi,@pozitifalanturleri)"
        cmd.Parameters.AddWithValue("@Hobiid",HobiId)
        cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
        cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
        cmd.Parameters.AddWithValue("@pozitifalanturleri",metin)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.ExecuteNonQuery()
        con.Close()
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End sub
End Class

Public Class Gezi
    Inherits Hobi
    public Seyehatyeri as String
    public Yurtdisi() as String
    Public Yurtici() As String
    Public Sub New (ByVal kelime As String)
        Try
            HobiAlanAdi = $"YAŞAM"
            Randomize()
            Dim ratgele As Random = New Random()
            HobiId = ratgele.Next(201,225)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim", kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   Public Overrides sub kaydet()
        Try
        Dim metin1 as String=""
       For i As Integer = 0 To Yurtdisi.Length-1
            metin1+=String.Concat(Yurtdisi(i)+",")
       Next i
        Dim metin2 As String=""
       For i As Integer = 0 To Yurtici.Length-1
            metin2+=String.Concat(Yurtici(i)+",")
       Next i
       Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
       Dim cmd As SqlCommand = New SqlCommand()
       cmd.Parameters.Clear()
       cmd.Connection = con
       cmd.CommandText = "INSERT INTO Gezi(Hobi_id,Kullanici_id,Hobi_alan_adi,Seyehat_yeri,Yurtdisi_gezi_yerleri,Yurtici_gezi_yerleri) values(@hobiid,@kullaniciid,@hobialanadi,@seyehatyeri,@yurtdisigeziyerleri,@yurticigeziyerleri)"
       cmd.Parameters.AddWithValue("@Hobiid",HobiId)
       cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
       cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
        cmd.Parameters.AddWithValue("@seyehatyeri",Seyehatyeri)
        cmd.Parameters.AddWithValue("@yurtdisigeziyerleri",metin1)
        cmd.Parameters.AddWithValue("@yurticigeziyerleri",metin2)
       If con.State = ConnectionState.Closed Then
           con.Open()
       End If
       cmd.ExecuteNonQuery()
       con.Close()
       Catch ex As Exception
       MsgBox(ex.Message)
        end Try
   End sub
End Class

Public Class Doga
    Inherits Hobi
    public Dogaturleri() as String
    Public Sub New (ByVal kelime As String)
        Try
            HobiAlanAdi = $"YAŞAM"
            Randomize()
            Dim ratgele As Random = New Random()
            HobiId = ratgele.Next(226,250)
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "SELECT kullanici_id,isim,soyisim FROM kullanici where isim=@isim"
            cmd.Parameters.AddWithValue("@isim", kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                KullaniciId = dr.GetInt32(0)
                ad = dr.GetString(1)
                soyad = dr.GetString(2)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Kaydet()
        Try
        Dim metin as String=""
        For i As Integer = 0 To Dogaturleri.Length-1
            metin+=String.Concat(Dogaturleri(i)+",")
        Next i
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Doga(Hobi_id,Kullanici_id,Hobi_alan_adi,Faliyet_alanlari) values(@hobiid,@kullaniciid,@hobialanadi,@dogaturleri)"
            cmd.Parameters.AddWithValue("@Hobiid",HobiId)
            cmd.Parameters.AddWithValue("@kullaniciid",KullaniciId)
            cmd.Parameters.AddWithValue("@hobialanadi",HobiAlanAdi)
            cmd.Parameters.AddWithValue("@dogaturleri",metin)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub
End Class