Imports System.Data.SqlClient

Public Class gaktivite
    public sayi1 as Integer
    Sub New (ByVal sayi As Integer)

        ' This call is required by the designer.
        sayi1=sayi
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
     Const Gün As Double = 24.0
    Private _this As Object
  Shared _kesinsonuc As Double=0D

    Public Function Hesapla(ByVal toplam As Integer) As Double
        Dim ksaat As Double = 0
        ksaat = gün - toplam
        ksaat = (ksaat * 1 / 3)
        ksaat = Math.Round(Convert.ToDouble(ksaat), 0)
        Return ksaat
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uyuma As Double
        Dim isOkul As Double
        Dim kzaman As Double
        Dim Sonuc As Double
        Try
            utxt.TextMaskFormat = MaskFormat.IncludeLiterals
            uyuma = Convert.ToDouble(utxt.Text.Replace(":", ","))
            itxt.TextMaskFormat = MaskFormat.IncludeLiterals
            isOkul = Convert.ToDouble(itxt.Text.Replace(":", ","))
            ktxt.TextMaskFormat = MaskFormat.IncludeLiterals
            kzaman = Convert.ToDouble(ktxt.Text.Replace(":", ","))
            sonuc = uyuma + isOkul + kzaman
            sonuc = hesapla(sonuc)
            If utxt.TextLength <= 0 Then
                ErrorProvider1.SetError(utxt, $"Uyuma süresi girmeniz gerekmektedir.")
            Else
                ErrorProvider1.SetError(utxt, vbNullString)
            End If

            If itxt.TextLength <= 0 Then
                ErrorProvider1.SetError(itxt, $"İşe veya okulunuza ayrılan sürenizi girmeniz gerekmektedir.")
            Else
                ErrorProvider1.SetError(itxt, vbNullString)
            End If

            If ktxt.TextLength <= 0 Then
                ErrorProvider1.SetError(ktxt, $"Kişisel işlerinize ayırdığınız zamanı girmeniz gerekmetedir.")
            Else
                ErrorProvider1.SetError(ktxt, vbNullString)
            End If
            _kesinsonuc=Sonuc
            MessageBox.Show($"Aktiviteleriniz için ayrılan zaman:" & sonuc)
            Dim gkalan As Double
            gkalan = gün - (sonuc + uyuma + isOkul + kzaman)
            Dim g As Graphics = CreateGraphics()
            Dim rect As Rectangle = New Rectangle(300, 50, 200, 200)
            uyuma = ((uyuma / 24) * 360)
            isOkul = ((isOkul / 24) * 360)
            kzaman = ((kzaman / 24) * 360)
            sonuc = ((sonuc / 24) * 360)
            gkalan = ((gkalan / 24) * 360)
            g.FillPie(Brushes.Green, rect, 0, uyuma)
            g.FillPie(Brushes.Red, rect, uyuma, isOkul)
            g.FillPie(Brushes.Blue, rect, isOkul + uyuma, kzaman)
            g.FillPie(Brushes.Orange, rect, isOkul + uyuma + kzaman, sonuc)
            g.FillPie(Brushes.Yellow, rect, isOkul + uyuma + kzaman + sonuc, gkalan)
            g.Dispose()
            GroupBox1.Visible = True
            For Each control As Control In Me.Controls
                If TypeOf control Is MaskedTextBox
                    control.Text=""
                End If
                Next
 Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim kelime As String
            If sayi1=0 Then
      kelime =kullanicibulma.Getir(Bilgiler.Tablo)
                ElseIf sayi1=1 Then
                kelime=Kullanicibulma.Getir(giris.tablo1)
            End If
            Dim con As SqlConnection = New SqlConnection("Data Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Parameters.Clear()
            cmd.Connection = con
            cmd.CommandText="UPDATE kullanici SET aktivite=@zaman WHERE isim=@kullanici"
            cmd.Parameters.AddWithValue("@zaman",Convert.ToString(_kesinsonuc))
            cmd.Parameters.AddWithValue("@kullanici",kelime)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            con.Close()
            Dim yenigiris As giris=New giris()
            giris.sayi=0
            yenigiris.Show()
            Me.Hide()
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try

    End Sub
    Private Sub gaktivite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bilgiler.Timer1.Stop()
    End Sub
End Class