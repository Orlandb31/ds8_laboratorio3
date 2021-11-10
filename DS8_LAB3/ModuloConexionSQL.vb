Imports System.Data.SqlClient
Imports System.Xml
Module ModuloConexionSQL


    Public SQLConect As SqlConnection
    Public accion As String
    Public idEmpleado As Integer

    Sub Conexion()
        Dim cadena_conexion As String
        Dim serverDb As String = "", nameDB As String = "", user As String = "", pass As String = ""
        lecturaXml(serverDb, nameDB, user, pass)
        cadena_conexion = "data source = " & serverDb & "; initial catalog = " & nameDB & " ; user id = " & user & " ; password = " & pass
        '' MsgBox(cadena_conexion)
        SQLConect = New SqlConnection(cadena_conexion)
    End Sub

    Sub lecturaXml(ByRef serverDb As String, ByRef nameDB As String, ByRef user As String, ByRef pass As String)
        Dim mxml As New XmlTextReader("../../Archivos/config.xml")
        mxml.Read()
        While Not mxml.EOF
            mxml.Read()
            If Not mxml.IsStartElement Then
                Exit While
            End If
            Dim mPadre As Object = mxml.GetAttribute("Conexion")
            mxml.Read()
            serverDb = decodeBase64(mxml.ReadElementString("datasource"))
            nameDB = decodeBase64(mxml.ReadElementString("initialcatalog"))
            user = decodeBase64(mxml.ReadElementString("user"))
            pass = decodeBase64(mxml.ReadElementString("password"))

            ' MsgBox(serverDb + " " + nameDB + " " + user + " " + pass)

        End While
        mxml.Close()
    End Sub

    Public Function decodeBase64(ByVal messageEncrypt As String) As String
        'Convert.FromBase64String(messageEncrypt)
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(messageEncrypt))
    End Function
End Module

