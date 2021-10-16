Imports System.Data.SqlClient

Public Class CalisanlarDal
    Inherits DataAccessLayer(Of Calisanlar)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of Calisanlar)
        cmd = New SqlCommand("cl_calisanlarList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim calisanlar As List(Of Calisanlar) = New List(Of Calisanlar)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim calisan As Calisanlar = New Calisanlar

                    calisan.Id = Convert.ToInt32(reader("CalisanID").ToString())
                    calisan.CalisanAd = reader("CalisanAd").ToString()
                    calisan.CalisanSoyad = reader("CalisanSoyad").ToString()
                    calisan.Cinsiyet = reader("Cinsiyet").ToString()
                    calisan.Telefon = reader("Telefon").ToString()
                    calisan.Eposta = reader("EPosta").ToString()
                    calisan.Pozisyon = reader("Pozisyon").ToString()
                    calisan.AdresID = Convert.ToInt32(reader("AdresID").ToString())
                    calisan.SubeID = Convert.ToInt32(reader("SubeID").ToString())
                    calisan.Fotograf = reader("Fotograf").ToString()
                    calisan.Sifre = reader("Sifre").ToString()

                    calisanlar.Add(calisan)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return calisanlar
    End Function

    Public Overrides Function Save(ByVal instance As Calisanlar) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("cl_calisanlarInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@CalisanAd", instance.CalisanAd)
            cmd.Parameters.AddWithValue("@CalisanSoyad", instance.CalisanSoyad)
            cmd.Parameters.AddWithValue("@Cinsiyet", instance.Cinsiyet)
            cmd.Parameters.AddWithValue("@Telefon", instance.Telefon)
            cmd.Parameters.AddWithValue("@EPosta", instance.Eposta)
            cmd.Parameters.AddWithValue("@Pozisyon", instance.Pozisyon)
            cmd.Parameters.AddWithValue("@AdresID", instance.AdresID)
            cmd.Parameters.AddWithValue("@SubeID", instance.SubeID)
            cmd.Parameters.AddWithValue("@Fotograf", instance.Fotograf)
            cmd.Parameters.AddWithValue("@Sifre", instance.Sifre)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As Calisanlar) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("cl_calisanlarUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instance.Id)
            cmd.Parameters.AddWithValue("@CalisanAd", instance.CalisanAd)
            cmd.Parameters.AddWithValue("@CalisanSoyad", instance.CalisanSoyad)
            cmd.Parameters.AddWithValue("@Cinsiyet", instance.Cinsiyet)
            cmd.Parameters.AddWithValue("@Telefon", instance.Telefon)
            cmd.Parameters.AddWithValue("@EPosta", instance.Eposta)
            cmd.Parameters.AddWithValue("@Pozisyon", instance.Pozisyon)
            cmd.Parameters.AddWithValue("@AdresID", instance.AdresID)
            cmd.Parameters.AddWithValue("@SubeID", instance.SubeID)
            cmd.Parameters.AddWithValue("@Fotograf", instance.Fotograf)
            cmd.Parameters.AddWithValue("@Sifre", instance.Sifre)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Delete(instanceId As Object) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("cl_calisanlarDelete", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instanceId)
            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function
End Class
