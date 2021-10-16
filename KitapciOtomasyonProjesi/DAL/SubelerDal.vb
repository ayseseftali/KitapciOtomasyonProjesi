Imports System.Data.SqlClient

Public Class SubelerDal
    Inherits DataAccessLayer(Of Subeler)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of Subeler)
        cmd = New SqlCommand("sb_subelerList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim subeler As List(Of Subeler) = New List(Of Subeler)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim sube As Subeler = New Subeler

                    sube.Id = Convert.ToInt32(reader("SubeID").ToString())
                    sube.SubeAdi = reader("SubeAdi").ToString()
                    sube.AdresID = Convert.ToInt32(reader("AdresID").ToString())


                    subeler.Add(sube)

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return subeler
    End Function

    Public Overrides Function Save(ByVal instance As Subeler) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("sb_subelerInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@SubeAdi", instance.SubeAdi)
            cmd.Parameters.AddWithValue("@AdresID", instance.AdresID)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As Subeler) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("sb_subelerUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instance.Id)
            cmd.Parameters.AddWithValue("@SubeAdi", instance.SubeAdi)
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

        cmd = New SqlCommand("sb_subelerDelete", cnn)
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
