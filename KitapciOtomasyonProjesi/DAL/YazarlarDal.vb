Imports System.Data.SqlClient

Public Class YazarlarDal
    Inherits DataAccessLayer(Of Yazarlar)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of Yazarlar)
        cmd = New SqlCommand("yz_yazarlarList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim yazarlar As List(Of Yazarlar) = New List(Of Yazarlar)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim yazar As Yazarlar = New Yazarlar

                    yazar.Id = Convert.ToInt32(reader("YazarID").ToString())
                    yazar.YazarAdi = reader("YazarAdi").ToString()
                    yazar.YazarSoyadi = reader("YazarSoyadi").ToString()


                    yazarlar.Add(yazar)

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return yazarlar
    End Function

    Public Overrides Function Save(ByVal instance As Yazarlar) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("yz_yazarlarInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@YazarAdi", instance.YazarAdi)
            cmd.Parameters.AddWithValue("@YazarSoyadi", instance.YazarSoyadi)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As Yazarlar) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("yz_yazarlarUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instance.Id)
            cmd.Parameters.AddWithValue("@YazarAdi", instance.YazarAdi)
            cmd.Parameters.AddWithValue("@YazarSoyadi", instance.YazarSoyadi)

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

        cmd = New SqlCommand("yz_yazarlarDelete", cnn)
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
