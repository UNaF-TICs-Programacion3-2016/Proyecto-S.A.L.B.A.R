Imports System.IO

Public MustInherit Class Frecuencia
    ''La idea de esta clase es no heredarla ni instanciarla,
    ''sino solo llamarla por sus funciones compartidas, como por ejemplo la clase "Math".

    ''' <summary>
    ''' Estructura para almanecar todos los datos de un archivo WAV.
    ''' </summary>
    Public Structure Datos_WAV
        Public CHUNKID As Byte()
        Public STRCHUNKID As String
        Public CHUNKSIZE As Int32
        Public FORMAT As Byte()
        Public STRFORMAT As String
        Public SUBCHUNK1ID As Byte()
        Public STRSUBCHUNK1ID As String
        Public SUBCHUNK1SIZE As Int32
        Public AUDIOFORMAT As Int16
        Public NUMCHANNELS As Int16
        Public SAMPLERATE As Int32
        Public BYTERATE As Int32
        Public BLOCKALIGN As Int16
        Public BITPERSAMPLE As Int16
        Public SUBCHUNK2ID As Byte()
        Public STRSUBCHUNK2ID As String
        Public SUBCHUNK2SIZE As Int32
    End Structure
    ''' <summary>
    ''' Permite obetener una matriz de Frecuencia en bruto a partir de un archivo de formato WAV.
    ''' </summary>
    ''' <param name="Archivo">Se requiere un OpenFileDialog con el directorio del Archivo.</param>
    ''' <returns></returns>
    Public Shared Function Obtener_Matriz_de_Frecuencia(Archivo As OpenFileDialog)
        Dim Temp As New ArrayList

        Try
            Dim MIFILESTREAM As FileStream = New FileStream(Archivo.FileName, FileMode.Open, FileAccess.Read)
            Dim LECTOR As BinaryReader = New BinaryReader(MIFILESTREAM)

            Dim SUBCHUNK2ID As Byte() = LECTOR.ReadBytes(4)
            Dim STRSUBCHUNK2ID As String = System.Text.Encoding.ASCII.GetString(SUBCHUNK2ID)
            Dim SUBCHUNK2SIZE As Int32 = LECTOR.ReadInt32()

            For I = 0 To (SUBCHUNK2SIZE - 1) / 2 'MUESTRAS PARA CADA CANAL(DERECHO E IZQUIERDO)
                Temp.Add(LECTOR.ReadInt16) 'DATOS EN INT16
            Next

            If STRSUBCHUNK2ID <> "data" Then ' EN UN FORMATO APROPIADO ESTE CAMPO DEBE DECIR = data
                MsgBox("FORMATO INCORRECTO")
                Return Temp
                Exit Function
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Temp
            Exit Function
        End Try

        Return Temp
    End Function

    ''' <summary>
    ''' Permite promediar una matriz de una Frecuencia en bruto, devolviendo una matriz reducida.
    ''' </summary>
    ''' <param name="Frecuencia_en_Bruto">Se requiere una Matriz de Frecuencia en Bruto obtenida de la funcion "Obtener_Matriz_de_Frencuencia".</param>
    '''<param name="Limite">Se requiere la reprensacion numerica de elementos que forman 1 segundo de audio para poder utilizarla como limite.</param>
    ''' <returns></returns>
    Public Shared Function Obtener_Matriz_Promedio(Frecuencia_en_Bruto As ArrayList, Limite As Integer)
        Dim Limite_Actual As Integer = Limite
        Dim Temp(Frecuencia_en_Bruto.Count / Limite) As Integer
        Dim i, j As Integer

        For i = 0 To Frecuencia_en_Bruto.Count
            If i <> Limite_Actual Then
                Temp(j) += Int(Frecuencia_en_Bruto(i))
            Else
                Temp(j) = Temp(j) / Limite
                j += 1
                If i <> Frecuencia_en_Bruto.Count Then
                    Limite_Actual += Limite
                    Temp(j) = Int(Frecuencia_en_Bruto(i))
                End If
            End If
        Next

        Return Temp
    End Function

    ''' <summary>
    ''' Permite comparar dos Frecuencias, devolviendo una Matriz donde sus elementos son numericos. Mientras mas distante del 0, mas diferentes son las secciones comparadas entre las frecuencias.
    ''' </summary>
    ''' <param name="Frecuencia_BD">Se requiere de una Matriz Frecuencia provenida de la base de datos.</param>
    ''' <param name="Frecuencia_A_Comparar">Se requiere la matriz de la frencuencia Promedio que se desea comparar.</param>
    ''' <returns></returns>
    Public Shared Function Comparar_Frecuencias(Frecuencia_BD() As Integer, Frecuencia_A_Comparar() As Integer)
        If Frecuencia_BD.Length > Frecuencia_A_Comparar.Length Then
            Return Comparando(Frecuencia_BD, Frecuencia_A_Comparar)
        Else
            Return Comparando(Frecuencia_A_Comparar, Frecuencia_BD)
        End If
    End Function

    ''' <summary>
    ''' Permite Resumir la matriz resultante de una comparacion a un unico numero. Mientras mas distante del 0, mas diferentes son las frecuencias.
    ''' </summary>
    ''' <param name="Matriz_Comparacion_de_Frecuencias">Se requiere una Matriz proveniente de la funcion "Comparar_Frecuencias".</param>
    ''' <returns></returns>
    Public Shared Function Promediar_y_Refinar_Resultado(Matriz_Comparacion_de_Frecuencias() As Integer)
        Dim Temp As Integer

        For Each Elemento As Integer In Matriz_Comparacion_de_Frecuencias
            Temp += Elemento
        Next
        Temp = Temp / Matriz_Comparacion_de_Frecuencias.Length
        Return Temp
    End Function

    ''' <summary>
    ''' Devuelte todos los datos relacionados a un Archivo .WAV, para ello se requiere un Objeto de la estructura "Datos_WAV".
    ''' </summary>
    ''' <param name="Archivo">Se requiere un OpenFileDialog con el directorio del Archivo.</param>
    ''' <returns></returns>
    Public Shared Function Obtener_Datos_WAV(Archivo As OpenFileDialog)
        Dim Temp As New Datos_WAV
        Dim MIFILESTREAM As FileStream = New FileStream(Archivo.FileName, FileMode.Open, FileAccess.Read)
        Dim LECTOR As BinaryReader = New BinaryReader(MIFILESTREAM)

        Temp.CHUNKID = LECTOR.ReadBytes(4)
        Temp.STRCHUNKID = System.Text.Encoding.ASCII.GetString(Temp.CHUNKID)
        Temp.CHUNKSIZE = LECTOR.ReadInt32() + 8
        Temp.FORMAT = LECTOR.ReadBytes(4)
        Temp.STRFORMAT = System.Text.Encoding.ASCII.GetString(Temp.FORMAT)
        Temp.SUBCHUNK1ID = LECTOR.ReadBytes(4)
        Temp.STRSUBCHUNK1ID = System.Text.Encoding.ASCII.GetString(Temp.SUBCHUNK1ID)
        Temp.SUBCHUNK1SIZE = LECTOR.ReadInt32()
        Temp.AUDIOFORMAT = LECTOR.ReadInt16()
        Temp.NUMCHANNELS = LECTOR.ReadInt16()
        Temp.SAMPLERATE = LECTOR.ReadInt32()
        Temp.BYTERATE = LECTOR.ReadInt32()
        Temp.BLOCKALIGN = LECTOR.ReadInt16()
        Temp.BITPERSAMPLE = LECTOR.ReadInt16()
        Temp.SUBCHUNK2ID = LECTOR.ReadBytes(4)
        Temp.STRSUBCHUNK2ID = System.Text.Encoding.ASCII.GetString(Temp.SUBCHUNK2ID)
        Temp.SUBCHUNK2SIZE = LECTOR.ReadInt32()

        Return Temp
    End Function


    Private Shared Function Comparando(M_Mayor() As Integer, M_Menor() As Integer)
        Dim Temp(M_Menor.Length) As Integer
        Dim i, j As Integer

        For i = 0 To M_Menor.Length
            Temp(i) = M_Mayor(i) - M_Menor(i)
        Next

        Return Temp
    End Function
End Class