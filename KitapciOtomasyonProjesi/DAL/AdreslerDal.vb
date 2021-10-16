Imports System.Data.SqlClient

Public Class AdreslerDal
    Inherits DataAccessLayer(Of Adresler)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of Adresler)
        cmd = New SqlCommand("ad_adreslerList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim adresler As List(Of Adresler) = New List(Of Adresler)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim adres As Adresler = New Adresler

                    adres.Id = Convert.ToInt32(reader("AdresID").ToString())
                    adres.Cadde = reader("Cadde").ToString()
                    adres.Sokak = reader("Sokak").ToString()
                    adres.Mahalle = reader("Mahalle").ToString()
                    adres.BinaNo = Convert.ToInt32(reader("BinaNo").ToString())
                    adres.Kat = Convert.ToInt32(reader("Kat").ToString())
                    adres.DaireNo = Convert.ToInt32(reader("DaireNo").ToString())
                    adres.Ilce = reader("Ilce").ToString()
                    adres.Il = reader("Il").ToString()
                    adres.PostaKodu = reader("PostaKodu").ToString()

                    adresler.Add(adres)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return adresler
    End Function

    Public Overrides Function Save(ByVal instance As Adresler) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("ad_adreslerInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@Cadde", instance.Cadde)
            cmd.Parameters.AddWithValue("@Sokak", instance.Sokak)
            cmd.Parameters.AddWithValue("@Mahalle", instance.Mahalle)
            cmd.Parameters.AddWithValue("@BinaNo", instance.BinaNo)
            cmd.Parameters.AddWithValue("@Kat", instance.Kat)
            cmd.Parameters.AddWithValue("@DaireNo", instance.DaireNo)
            cmd.Parameters.AddWithValue("@Ilce", instance.Ilce)
            cmd.Parameters.AddWithValue("@Il", instance.Il)
            cmd.Parameters.AddWithValue("@PostaKodu", instance.PostaKodu)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As Adresler) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("ad_adreslerUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instance.Id)
            cmd.Parameters.AddWithValue("@Cadde", instance.Cadde)
            cmd.Parameters.AddWithValue("@Sokak", instance.Sokak)
            cmd.Parameters.AddWithValue("@Mahalle", instance.Mahalle)
            cmd.Parameters.AddWithValue("@BinaNo", instance.BinaNo)
            cmd.Parameters.AddWithValue("@Kat", instance.Kat)
            cmd.Parameters.AddWithValue("@DaireNo", instance.DaireNo)
            cmd.Parameters.AddWithValue("@Ilce", instance.Ilce)
            cmd.Parameters.AddWithValue("@Il", instance.Il)
            cmd.Parameters.AddWithValue("@PostaKodu", instance.PostaKodu)

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

        cmd = New SqlCommand("ad_adreslerDelete", cnn)
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
