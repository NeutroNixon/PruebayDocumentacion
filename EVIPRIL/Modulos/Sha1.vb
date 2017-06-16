
Imports System.Data.SqlClient
Module Functions
    Public Function SHA1(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Public Function CalcularEdad(ByVal fecha As Date) As Integer
        Dim edad As Integer = Today.Year - fecha.Year

        If (fecha > Today.AddYears(-edad)) Then edad -= 1

        Return edad
    End Function

    Public Function Mandar_a_ProbarConexion() As Boolean
        Try
            If ValidarConexion(My.Settings.ToString) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Dim _st As New System.Diagnostics.StackTrace()
            Dim _miFuncion As String = _st.GetFrame(0).GetMethod().Name
            Return False
        End Try
    End Function

    Public Function ValidarConexion(ByVal CadenaConexion As String) As Boolean
        Dim _CNNSeg As New SqlConnection(CadenaConexion)
        Using _CNNSeg
            _CNNSeg.Open()
        End Using
        Return True
    End Function
End Module

