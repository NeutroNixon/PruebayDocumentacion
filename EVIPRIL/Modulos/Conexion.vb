Imports System.Data.SqlClient

Module Conexion
    Public sele As New Integer
    Public cnn As New SqlConnection(My.Settings.ConexionTemporal)
End Module
