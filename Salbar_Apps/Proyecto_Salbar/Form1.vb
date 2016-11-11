Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("probando la sincronizacion con el repositorio")
        MsgBox("pueba exitosa")
    End Sub

    '' Suponiendo que ya tenemos la matriz donde se aloja todos los valores para cada milisegundo
    Public Sub Probando_clase_Frecuencia()
        Dim Objeto As New OpenFileDialog
        Dim Datos_de_Objeto As New Frecuencia.Datos_WAV
        Dim Matriz_Bruta As ArrayList
        Dim Matriz_Refinada() As Integer
        Dim Matriz_BD() As Integer
        Dim Matriz_Comparacion() As Integer
        Dim Resultado_final As Integer

        Objeto.FileName = "C:/Damas Gratis - El Humito de mi Fasito.wav"

        Datos_de_Objeto = Frecuencia.Obtener_Datos_WAV(Objeto)

        Matriz_Bruta = Frecuencia.Obtener_Matriz_de_Frecuencia(Objeto)

        Matriz_Refinada = Frecuencia.Obtener_Matriz_Promedio(Matriz_Bruta, 10000)
        Matriz_BD = Frecuencia.Obtener_Matriz_Promedio(Matriz_Bruta, 7000) 'supongamos que viene de la base de datos

        Matriz_Comparacion = Frecuencia.Comparar_Frecuencias(Matriz_Refinada, Matriz_Refinada)

        Resultado_final = Frecuencia.Promediar_y_Refinar_Resultado(Matriz_Comparacion)

    End Sub
End Class