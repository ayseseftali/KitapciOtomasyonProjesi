Imports System.Data.SqlClient

Public Class KategorilerDal
    Inherits DataAccessLayer(Of Kategoriler)

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Public Overrides Function List() As List(Of Kategoriler)
        cmd = New SqlCommand("kt_kategorilerList", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim kategoriler As List(Of Kategoriler) = New List(Of Kategoriler)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim kategori As Kategoriler = New Kategoriler

                    kategori.Id = Convert.ToInt32(reader("KategoriID").ToString())
                    kategori.KategoriAdi = reader("KategoriAdi").ToString()

                    kategoriler.Add(kategori)

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return kategoriler
    End Function

    Public Overrides Function Save(ByVal instance As Kategoriler) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("kt_kategorilerInsert", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@KategoriAdi", instance.KategoriAdi)

            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Return result
    End Function

    Public Overrides Function Update(ByVal instance As Kategoriler) As Integer
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("kt_kategorilerUpdate", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim result As Integer = 0

        Try
            cmd.Parameters.AddWithValue("@id", instance.Id)
            cmd.Parameters.AddWithValue("@KategoriAdi", instance.KategoriAdi)

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

        cmd = New SqlCommand("kt_kategorilerDelete", cnn)
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
