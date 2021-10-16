Imports System.Data.SqlClient

Public Class MusterilerDal
    Inherits DataAccessLayer(Of Musteriler)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of Musteriler)
        cmd = New SqlCommand("ms_musterilerList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim musteriler As List(Of Musteriler) = New List(Of Musteriler)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim musteri As Musteriler = New Musteriler

                    musteri.Id = Convert.ToInt32(reader("MusteriID").ToString())
                    musteri.MusteriAdi = reader("MusteriAdi").ToString()
                    musteri.MusteriSoyadi = reader("MusteriSoyadi").ToString()
                    musteri.MusteriCinsiyet = reader("MusteriCinsiyet").ToString()
                    musteri.MusteriEPosta = reader("MusteriEPosta").ToString()
                    musteri.MusteriTelefon = reader("MusteriTelefon").ToString()                   

                    musteriler.Add(musteri)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return musteriler
    End Function

    Public Overrides Function Save(ByVal instance As Musteriler) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("ms_musterilerInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@MusteriAdi", instance.MusteriAdi)
            cmd.Parameters.AddWithValue("@MusteriSoyadi", instance.MusteriSoyadi)
            cmd.Parameters.AddWithValue("@MusteriCinsiyet", instance.MusteriCinsiyet)
            cmd.Parameters.AddWithValue("@MusteriEPosta", instance.MusteriEPosta)
            cmd.Parameters.AddWithValue("@MusteriTelefon", instance.MusteriTelefon)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As Musteriler) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("ms_musterilerUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instance.Id)
            cmd.Parameters.AddWithValue("@MusteriAdi", instance.MusteriAdi)
            cmd.Parameters.AddWithValue("@MusteriSoyadi", instance.MusteriSoyadi)
            cmd.Parameters.AddWithValue("@MusteriCinsiyet", instance.MusteriCinsiyet)
            cmd.Parameters.AddWithValue("@MusteriEPosta", instance.MusteriEPosta)
            cmd.Parameters.AddWithValue("@MusteriTelefon", instance.MusteriTelefon)

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

        cmd = New SqlCommand("ms_musterilerDelete", cnn)
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
