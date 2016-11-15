Imports System.Xml
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Text.Encoding
Public Class Geolocalizacion
    Private IPPublic As String
    Public Property IP() As String
        Get
            Return IPPublic
        End Get
        Set
            IPPublic = Value
        End Set
    End Property

    Private _longitud As String
    Public Property longitud() As String
        Get
            Return _longitud
        End Get
        Set(ByVal value As String)
            _longitud = value
        End Set
    End Property

    Private _latitud As String
    Public Property latitud() As String
        Get
            Return _latitud
        End Get
        Set(ByVal value As String)
            _latitud = value
        End Set
    End Property

    Private _Pais As String
    Public Property Pais() As String
        Get
            Return _Pais
        End Get
        Set(ByVal value As String)
            _Pais = value
        End Set
    End Property

    Private _Region As String
    Public Property Region() As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            _Region = value
        End Set
    End Property

    Private _Ciudad As String
    Public Property Ciudad() As String
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property

    Private _IPEncontrada As Boolean
    Public Property IPEncontrada() As Boolean
        Get
            Return _IPEncontrada
        End Get
        Set(ByVal value As Boolean)
            _IPEncontrada = value
        End Set
    End Property

    Public Sub myIp()
        Try
            Dim IPPublic = ""
            Dim IPPUBLICA As String
            Dim ip As New WebClient
            Dim doc As New XmlDocument()

            '==================OBTENCION DE LA IPPUBLICA===========
            IPPUBLICA = ip.DownloadString("http://checkip.dyndns.org/").Replace("<html><head><title>Current IP Check</title>" _
                                                                              + "</head><body>Current IP Address: ", "").Replace("</body></html>", "")
            '================OBTENCION DE LA UBICACION CON LA API===========
            doc.Load("http://freegeoip.net/xml/" + IPPUBLICA)

            '================EXTRAE DEL DOCUMENTO XML LA INFO DE LA IP=========== 
            Dim nodeLatitud As XmlNodeList = doc.GetElementsByTagName("Latitude")
            Dim nodeLongitud As XmlNodeList = doc.GetElementsByTagName("Longitude")
            Dim nodePais As XmlNodeList = doc.GetElementsByTagName("CountryName")
            Dim nodeRegion As XmlNodeList = doc.GetElementsByTagName("RegionName")
            Dim nodeCiudad As XmlNodeList = doc.GetElementsByTagName("City")

            '========ASIGNACION A LOS ATIBUTOS==========
            _latitud = nodeLatitud(0).InnerText
            _longitud = nodeLongitud(0).InnerText
            _Pais = nodePais(0).InnerText
            _Region = nodeRegion(0).InnerText
            _Ciudad = nodeCiudad(0).InnerText
            _IPEncontrada = True
        Catch ex As Exception
            _IPEncontrada = False
        End Try

    End Sub

End Class
