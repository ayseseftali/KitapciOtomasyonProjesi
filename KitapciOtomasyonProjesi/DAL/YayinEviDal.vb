Imports System.Data.SqlClient

Public Class YayinEviDal
    Inherits DataAccessLayer(Of YayinEvi)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of YayinEvi)
        cmd = New SqlCommand("ye_yayinEvleriList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim yayinEvleri As List(Of YayinEvi) = New List(Of YayinEvi)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim yayinEvi As YayinEvi = New YayinEvi

                    yayinEvi.Id = Convert.ToInt32(reader("YayinEviID").ToString())
                    yayinEvi.YayinEviAdi = reader("YayinEviAdi").ToString()
                    yayinEvi.AdresID = Convert.ToInt32(reader("AdresID").ToString())


                    yayinEvleri.Add(yayinEvi)

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return yayinEvleri
    End Function

    Public Overrides Function Save(ByVal instance As YayinEvi) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("ye_yayinEvleriInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@YayinEviAdi", instance.YayinEviAdi)
            cmd.Parameters.AddWithValue("@AdresID", instance.AdresID)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As YayinEvi) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("ye_yayinEvleriUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instance.Id)
            cmd.Parameters.AddWithValue("@YayinEviAdi", instance.YayinEviAdi)
            cmd.Parameters.AddWithValue("@AdresID", instance.AdresID)

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

        cmd = New SqlCommand("ye_yayinEvleriDelete", cnn)
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
