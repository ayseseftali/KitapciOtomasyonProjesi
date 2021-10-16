Imports System.Data.SqlClient

Public Class SatisDal
    Inherits DataAccessLayer(Of Satis)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of Satis)
        cmd = New SqlCommand("st_satisList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim satislar As List(Of Satis) = New List(Of Satis)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim satis As Satis = New Satis

                    satis.Id = Convert.ToInt32(reader("SatisID").ToString())
                    satis.KitapID = Convert.ToInt32(reader("KitapID").ToString())
                    satis.MusteriID = Convert.ToInt32(reader("MusteriID").ToString())
                    satis.SatisID = Convert.ToInt32(reader("SatisID").ToString())
                    satis.SatisSayisi = Convert.ToInt32(reader("SatisSayisi").ToString())
                    satis.SatisTarihi = Convert.ToDateTime(reader("SatisTarihi").ToString())
                    satis.SubeID = Convert.ToInt32(reader("SubeID").ToString())
                    satis.ToplamTutar = Convert.ToDecimal(reader("ToplamTutar").ToString())
                    
                    satislar.Add(satis)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return satislar
    End Function

    Public Overrides Function Save(ByVal instance As Satis) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("st_satisInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            'cmd.Parameters.AddWithValue("@SatisID", instance.Id)
            cmd.Parameters.AddWithValue("@SubeID", instance.SubeID)
            cmd.Parameters.AddWithValue("@KitapID", instance.KitapID)
            cmd.Parameters.AddWithValue("@MusteriID", instance.MusteriID)
            cmd.Parameters.AddWithValue("@SatisSayisi", instance.SatisSayisi)
            cmd.Parameters.AddWithValue("@SatisTarihi", instance.SatisTarihi)
            cmd.Parameters.AddWithValue("@ToplamTutar", instance.ToplamTutar)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As Satis) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("st_satisUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@SatisID", instance.Id)
            cmd.Parameters.AddWithValue("@SubeID", instance.SubeID)
            cmd.Parameters.AddWithValue("@KitapID", instance.KitapID)
            cmd.Parameters.AddWithValue("@MusteriID", instance.MusteriID)
            cmd.Parameters.AddWithValue("@SatisID", instance.SatisID)
            cmd.Parameters.AddWithValue("@SatisSayisi", instance.SatisSayisi)
            cmd.Parameters.AddWithValue("@SatisTarihi", instance.SatisTarihi)
            cmd.Parameters.AddWithValue("@ToplamTutar", instance.ToplamTutar)

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

        cmd = New SqlCommand("st_satisDelete", cnn)
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
