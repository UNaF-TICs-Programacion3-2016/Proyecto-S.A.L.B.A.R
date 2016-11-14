Imports System.Xml
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Text.Encoding
Public Class Geolocalizacion
    Const fic As String = "D:\googlemap.html"
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



    Public Function myIp() As String
        Dim IPPublic = ""
        Dim IPPUBLICA As String
        Dim ip As New WebClient
        IPPUBLICA = ip.DownloadString("http://checkip.dyndns.org/").Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address: ", "").Replace("</body></html>", "")

        Dim doc As New XmlDocument()
        doc.Load("http://freegeoip.net/xml/" + IPPUBLICA)
        Dim nodeLatitud As XmlNodeList = doc.GetElementsByTagName("Latitude")
        Dim nodeLongitud As XmlNodeList = doc.GetElementsByTagName("Longitude")
        _latitud = nodeLatitud(0).InnerText
        _longitud = nodeLongitud(0).InnerText
        Return _latitud + "," + _longitud
    End Function
End Class
