Imports System.Data.SqlClient

Public Class KitaplarDal
    Inherits DataAccessLayer(Of Kitaplar)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of Kitaplar)
        cmd = New SqlCommand("kp_kitaplarList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim kitaplar As List(Of Kitaplar) = New List(Of Kitaplar)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim kitap As Kitaplar = New Kitaplar

                    kitap.Id = Convert.ToInt32(reader("KitapID").ToString())
                    kitap.KitapAdi = reader("KitapAdi").ToString()
                    kitap.YayinTarihi = Convert.ToDateTime(reader("YayinTarihi").ToString())
                    kitap.SayfaSayisi = Convert.ToInt32(reader("SayfaSayisi").ToString())
                    kitap.YayinEviID = Convert.ToInt32(reader("YayinEviID").ToString())
                    kitap.SatisFiyati = Convert.ToDecimal(reader("SatisFiyati").ToString())

                    kitaplar.Add(kitap)

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return kitaplar
    End Function

    Public Overrides Function Save(ByVal instance As Kitaplar) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("kp_kitaplarInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@KitapAdi", instance.KitapAdi)
            cmd.Parameters.AddWithValue("@YayinTarihi", instance.YayinTarihi)
            cmd.Parameters.AddWithValue("@SayfaSayisi", instance.SayfaSayisi)
            cmd.Parameters.AddWithValue("@YayinEviID", instance.YayinEviID)
            cmd.Parameters.AddWithValue("@SatisFiyati", instance.SatisFiyati)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As Kitaplar) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("kp_kitaplarUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instance.Id)
            cmd.Parameters.AddWithValue("@KitapAdi", instance.KitapAdi)
            cmd.Parameters.AddWithValue("@YayinTarihi", instance.YayinTarihi)
            cmd.Parameters.AddWithValue("@SayfaSayisi", instance.SayfaSayisi)
            cmd.Parameters.AddWithValue("@YayinEviID", instance.YayinEviID)
            cmd.Parameters.AddWithValue("@SatisFiyati", instance.SatisFiyati)

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

        cmd = New SqlCommand("kp_kitaplarDelete", cnn)
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
