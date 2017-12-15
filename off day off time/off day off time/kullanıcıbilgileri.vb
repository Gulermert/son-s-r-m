Imports System.Data.SqlClient
Imports System.Threading
Public Class kullanıcıbilgileri
 Public resim_yolu As String
    Private Sub kullanıcıbilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       Try
        TextBox1.Enabled=False
        TextBox4.Enabled=False
        TextBox7.Enabled=False
           Dim baglanti as SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
           Dim dt as DataTable = New DataTable()
           Dim da As SqlDataAdapter = New SqlDataAdapter("select * from iller ORDER BY il_no ASC ", baglanti)
           da.Fill(dt)
           ComboBox1.ValueMember = "il_no"
           ComboBox1.DisplayMember = "isim"
           ComboBox1.DataSource = dt
            baglanti.Close()
        Dim tablom as Hashtable=New Hashtable()
        tablom=Kullanicibulma.Kullanicidondur(giris.tablo1)
        TextBox1.Text=tablom("kullanici_id").ToString()
        TextBox2.Text=tablom("İsim").ToString()
        TextBox3.Text=tablom("Soyisim").ToString()
        DateTimePicker1.Value= Convert.ToDateTime(tablom("Dogum_tarihi"))
        TextBox4.Text=tablom("yas").ToString()
        TextBox5.Text=tablom("telefon").ToString()
        ComboBox1.Text=tablom("sehir").ToString()
        ComboBox2.Text=tablom("semt").ToString()
        TextBox6.Text=tablom("sifre").ToString()
        ComboBox3.Text=tablom("meslek").ToString()
        TextBox7.Text=tablom("Aktivite").ToString()
        PictureBox1.ImageLocation=tablom("resim_yolu").ToString()
           
        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        try
        dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand()
            Dim da as SqlDataReader
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = "UPDATE kullanici SET isim=@isim,soyisim=@soyisim,dogum_tarihi=@dogum,yas=@yas,telefon=@telefon,sehir=@sehir,semt=@semt,@sifre=@sifre,sifre_tekrar=@sifre_tekrar,meslek=@meslek,resim_yolu=@resim where kullanici_id=@kullanan"
        cmd.Parameters.AddWithValue("@isim",TextBox2.Text)
        cmd.Parameters.AddWithValue("@soyisim",TextBox3.Text)
            cmd.Parameters.AddWithValue("@dogum",DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@yas",Year(DateTime.Now)-Year(DateTimePicker1.Value))
            cmd.Parameters.AddWithValue("@telefon",TextBox5.Text)
            cmd.Parameters.AddWithValue("@sehir",ComboBox1.Text)
            cmd.Parameters.AddWithValue("@semt",ComboBox2.Text)
            cmd.Parameters.AddWithValue("@sifre",TextBox6.Text)
            cmd.Parameters.AddWithValue("@sifre_tekrar",TextBox6.Text)
            cmd.Parameters.AddWithValue("@meslek",ComboBox3.Text)
            cmd.Parameters.AddWithValue("@resim",PictureBox1.ImageLocation)
            cmd.Parameters.AddWithValue("@kullanan",TextBox1.Text)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
            cmd.Parameters.Clear()
            cmd.CommandText="select kullanici_id,isim,soyisim,dogum_tarihi,yas,telefon,sehir,semt,sifre,sifre_tekrar,meslek,aktivite,resim_yolu from kullanici where kullanici_id=@kullanan"
            cmd.Parameters.AddWithValue("@kullanan",TextBox1.Text)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            da =cmd.ExecuteReader()
            While da.Read()
                TextBox1.Text=da.GetInt32(0).ToString()
                TextBox2.Text=da.GetString(1)
                TextBox3.Text=da.GetString(2)
                DateTimePicker1.Value=da.GetDateTime(3)
                TextBox4.Text=da.GetString(4)
                TextBox5.Text=da.GetString(5)
                ComboBox1.Text=da.GetString(6)
                ComboBox2.Text=da.GetString(7)
                TextBox6.Text=da.GetString(8)
                ComboBox3.Text=da.GetString(10)
                TextBox7.Text=da.GetString(11)
                PictureBox1.ImageLocation=da.GetString(12)
            End While
            da.Close()
            con.Close()
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim baglanti as SqlConnection=New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
        If ComboBox1.SelectedIndex <>-1 Then
            Dim table  As DataTable=New DataTable()
            Dim da As SqlDataAdapter =New SqlDataAdapter("select * from ilceler where il_no = " + ComboBox1.SelectedValue.ToString(), baglanti)
            da.Fill(table)
            ComboBox2.ValueMember=$"ilce_no"
            ComboBox2.DisplayMember=$"isim"
            ComboBox2.DataSource=table   
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim file As OpenFileDialog = New OpenFileDialog()
        file.Title = $"Resim Açma Penceresi"
        file.DefaultExt = $"jpg"
        file.InitialDirectory = $"C:\Desktop"
        file.Multiselect = False
        file.Filter = $"Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*"
        file.ShowDialog()
        resim_yolu = file.FileName
        PictureBox1.ImageLocation = resim_yolu
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        try
            dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM kullanici where kullanici_id=@kullanan"
            cmd.Parameters.AddWithValue("@kullanan",TextBox1.Text)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show($"Mevcut kullanıcı silindi,kullanıcı değiştirin veya kullanıcı ekleyin",$"KULLANICI SİLİNDİ")

            Dim yenigiris as giris=New giris()
            giris.sayi=0
            yenigiris.Show()
            Me.Hide()
            
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hobidonus As Hobiler=New Hobiler(1)
        hobidonus.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim yeniaktivite as gaktivite=New gaktivite(1)
        yeniaktivite.Show()
        Me.hide()
    End Sub
End Class