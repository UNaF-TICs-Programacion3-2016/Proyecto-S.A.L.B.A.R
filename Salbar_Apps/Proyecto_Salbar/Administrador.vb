Public Class Administrador
    Public oFrecuencia As New Frecuencia
    Public oConexion As New Conexion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = oConexion.Obtener_Lista("animal", "perro", "masculino")

        'temp = oConexion.Agregar_Registro("OVEJA", "MAMIFERO", "MASCULINO", "APARIAMIENTO", matriz, "ARGENTINA", "FORMOSA", "FORMOSA", fecha, "VERANO")
        'MsgBox(temp)
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
        Dim Tabla_De_la_BD As New DataTable

        Objeto.FileName = "C:/Damas Gratis - El Humito de mi Fasito.wav"

        Datos_de_Objeto = oFrecuencia.Obtener_Datos_WAV(Objeto)

        Matriz_Bruta = oFrecuencia.Obtener_Matriz_de_Frecuencia(Objeto)

        Matriz_Refinada = oFrecuencia.Obtener_Matriz_Promedio(Matriz_Bruta, 10000)
        Matriz_BD = oFrecuencia.Obtener_Matriz_Promedio(Matriz_Bruta, 7000) 'supongamos que viene de la base de datos

        Matriz_Comparacion = oFrecuencia.Comparar_Frecuencias(Matriz_Refinada, Matriz_Refinada)

        Resultado_final = oFrecuencia.Promediar_y_Refinar_Resultado(Matriz_Comparacion)

        'Tabla_De_la_BD = oConexion.Consultar_en_la_BD("perro")

    End Sub
End Class