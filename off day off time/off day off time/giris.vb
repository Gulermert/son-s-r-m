Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class Giris
   Public Shared sayi as Integer
    public Shared tablo1 as Hashtable = New Hashtable()
    public Shared liste as ArrayList=New ArrayList()
    Public  Shared kullanan as Integer
    Private Sub giris_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If sayi=0 Then
                tablo1.Clear()
                liste.Clear()
                kullanan=0
            End If
            Dim kullaniciAdet as Integer
            Dim i as Integer = 0
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "select count (*)from kullanici"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                kullaniciAdet = dr.GetInt32(0)
            End While
            dr.Close()
            con.Close()
            dim resimler(KullaniciAdet) as String
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim da As SqlDataAdapter = New SqlDataAdapter("select resim_yolu from kullanici", con)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds, "kullanici")
            While (i <= ds.Tables(0).Rows.Count - 1)

                resimler(i) = ds.Tables(0).Rows(i)("resim_yolu").ToString()
                i = i + 1
            End While
            con.Close()
            Dim fotograflar(kullaniciAdet) As PictureBox
            For j As Integer = 0 To kullaniciAdet - 1
                fotograflar(j) = New PictureBox()
                fotograflar(j).Name = "picturebox" + (j + 1).ToString()
                fotograflar(j).ImageLocation = resimler(j).ToString()
                fotograflar(j).Visible = True
                fotograflar(j).Location = New Point(j * 250, 28 + j)
                fotograflar(j).Size = New Size(200, 200)
                fotograflar(j).SizeMode = PictureBoxSizeMode.StretchImage
                fotograflar(j).BackColor = Color.Transparent
                fotograflar(j).BorderStyle = BorderStyle.FixedSingle
                AddHandler fotograflar(j).Click, AddressOf Bilgial
                Me.Controls.Add(fotograflar(j))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bilgial(sender As Object, e As EventArgs)
        Try
            Dim resimYolu As String
            resimYolu = CType(sender, PictureBox).ImageLocation
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            Dim dr As SqlDataReader
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "select kullanici_id,isim,soyisim,dogum_tarihi,yas,telefon,sehir,semt,sifre,sifre_tekrar,meslek,aktivite,resim_yolu from kullanici where resim_yolu=@resim"
            cmd.Parameters.AddWithValue("@resim", resimYolu)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With tablo1
                    kullanan=dr.GetInt32(0)
                    .Add("kullanici_id", dr.GetInt32(0))
                    .Add("İsim", dr.GetString(1))
                    .Add("Soyisim", dr.GetString(2))
                    .Add("Dogum_tarihi", dr.GetDateTime(3))
                    .Add("yas", dr.GetString(4))
                    .Add("telefon", dr.GetString(5))
                    .Add("sehir", dr.GetString(6))
                    .Add("semt", dr.GetString(7))
                    .Add("sifre", dr.GetString(8))
                    .Add("sifre_tekrar", dr.GetString(9))
                    .Add("meslek", dr.GetString(10))
                    If   dr.IsDBNull(dr.GetOrdinal("aktivite")) Then
                        .Add("Aktivite","GİRİLMEMİŞ")
                        else
                        .Add("Aktivite",dr.GetString(11))
                    End If
                    .Add("resim_yolu",dr.GetString(12))
                End With
         Exit While
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from beslenme,kullanici where beslenme.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1",kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("BESLENME")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from doga,kullanici where doga.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1",kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("DOGA")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from edebiyat,kullanici where Edebiyat.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1",kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("EDEBİYAT")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from gezi,kullanici where gezi.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1",kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("GEZİ")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from Muzik,kullanici where Muzik.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1", kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("MÜZİK")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from Pozitifbilimler,kullanici where Pozitifbilimler.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1", kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("POZİTİFBİLİMLER")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from Sinema,kullanici where Sinema.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1", kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("SİNEMA")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from Spor,kullanici where Spor.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1", kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("SPOR")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from Teknoloji,kullanici where Teknoloji.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1", kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("TEKNOLOJİ")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) from Tiyatro,kullanici where Tiyatro.Kullanici_id=@kullanan and kullanici.kullanici_id=@kullanan1"
            cmd.Parameters.AddWithValue("@kullanan", kullanan)
            cmd.Parameters.AddWithValue("@kullanan1", kullanan)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                liste.Add("TİYATRO")
                liste.Add(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            dim menu1 as menu=New menu()
            menu1.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim yenibilgi As Bilgiler =New Bilgiler()
        yenibilgi.Show()
        Me.Hide()
    End Sub
End Class