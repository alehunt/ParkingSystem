Imports System.Data.SqlClient
Imports System.Configuration

''TODO: Cambiar el manejo de exceptions
Public Class Database
    Shared mCon As SqlConnection

    Friend Shared StrConnection As String = ConfigurationManager.ConnectionStrings("ParkingDatabase").ConnectionString

    Friend Shared Function ExecuteDataset(ByVal pCommandText As String) As DataSet
        Dim mDs As New DataSet
        Try
            mCon = New SqlConnection(StrConnection)
            Dim mDa As New SqlDataAdapter(pCommandText, mCon)
            mCon.Open()
            mDa.Fill(mDs)
            Return mDs
        Catch ex As SqlException
            Dim mStr As String = ""
            For Each mErr As SqlError In ex.Errors
                mStr &= mErr.Message & ControlChars.CrLf
            Next
            MsgBox("Ocurrió un error en el acceso a la base de datos" & ControlChars.CrLf & _
            "MENSAJE: " & ex.Message & ControlChars.CrLf & _
            "ERRORES DEL SERVIDOR SQL: " & mStr)
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message & "  METODO: ExecuteDataset, CLASE: ADOSQLServer")
            Return Nothing
        Finally
            mCon.Close()
            mCon.Dispose()
        End Try

    End Function

    Friend Shared Function ExecuteReader(ByVal pCommandText As String) As SqlDataReader
        Dim mDr As SqlDataReader = Nothing
        Try
            mCon = New SqlConnection(StrConnection)
            Dim mCom As New SqlCommand(pCommandText, mCon)
            mCon.Open()
            mDr = mCom.ExecuteReader(CommandBehavior.CloseConnection)
            Return mDr

        Catch ex As SqlException
            Dim mStr As String = ""
            For Each mErr As SqlError In ex.Errors
                mStr &= mErr.Message & ControlChars.CrLf
            Next
            MsgBox("Ocurrió un error en el acceso a la base de datos" & ControlChars.CrLf & _
            "MENSAJE: " & ex.Message & ControlChars.CrLf & _
            "ERRORES DEL SERVIDOR SQL: " & mStr)
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message & "  METODO: ExecuteReader, CLASE: ADOSQLServer")
            Return Nothing
        Finally
            mDr.Close()
            mCon.Close()
            mCon.Dispose()
        End Try
    End Function

    Friend Shared Function ExecuteNonQuery(ByVal pCommandText As String) As Integer
        Try
            mCon = New SqlConnection(StrConnection)
            Dim mCom As New SqlCommand(pCommandText, mCon)
            mCon.Open()
            Return mCom.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message & "  METODO: ExecuteNonQuery, CLASE: ADOSQLServer")
            Return Nothing
        Finally
            mCon.Close()
            mCon.Dispose()
        End Try
    End Function

    Friend Shared Function ObtenerId(ByVal pTabla As String) As Integer
        Try
            mCon = New SqlConnection(StrConnection)
            Dim mCom As New SqlCommand("SELECT ISNULL(MAX(" & pTabla & "_Id),0) FROM " & pTabla, mCon)
            mCon.Open()
            Return mCom.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message & "  METODO: ObtenerId, CLASE: ADOSQLServer")
            Return Nothing
        Finally
            mCon.Close()
            mCon.Dispose()
        End Try
    End Function

End Class

