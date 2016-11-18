Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Conexion
    Private Conn As New OracleConnection("Data Source = localhost;User id = SALBAR;Password = salbar;")
    Private Sentencia As String = "select id_sonido, nombre_ent, tipo_son, fecha, hora, nombre_esta, descripcion, frecuencia 
                                    from sonido,DESCRIPCION_SON, ESTACION_DEL_ANIO, ENTIDAD_CAB, detalle_son, fechahora, ubicacion, sonid_ubic 
                                    where sonido.RELA_DESCRIPCION_SON = DESCRIPCION_SON.ID_DESC_SON
                                    and rela_esta_det = ESTACION_DEL_ANIO.ID_ESTA_DET
                                    and rela_enti_son = ENTIDAD_CAB.ID_ENTIDAD_CAB
                                    and sonido.RELA_FHORA = fechahora.ID_FECHAHORA
                                    and rela_sonido = id_sonido
                                    and rela_soni = id_sonido and rela_ubic = id_ubicacion "

    ''' <summary>
    ''' Permite obtener todos los registros de una determinada tabla.
    ''' </summary>
    ''' <param name="tabla">Se requiere el nombre de la tabla a consultar.</param>
    ''' <returns></returns>
    Public Function Obtener_Tabla(Tabla As String) As DataTable
        Return Consultando("select * from " + UCase(Tabla), UCase(Tabla))
    End Function
    ''' <summary>
    ''' Permite obtener una lista determinada de registros a partir de un conjunto especifico. Recomendada para cargar Combobox's.
    ''' </summary>
    ''' <param name="Conjunto">Se requiere el conjunto de elementos a extraer.</param>
    ''' <returns></returns>
    Public Function Obtener_Lista(Conjunto As String) As DataTable
        Select Case UCase(Conjunto)
            Case = "ANIMAL"
                Return Consultando("select id_entidad_cab, nombre_ent from entidad_cab where nivel = 'especie'", "entidad_cab")

            Case = "CATEGORIA"
                Return Consultando("select id_entidad_cab, nombre_ent from entidad_cab where nivel = 'categoria'", "entidad_cab")

            Case = "SONIDO"
                Return Consultando("select * from descripcion_Son", "descripcion_son")
        End Select
    End Function

    ''' <summary>
    ''' Permite Obtener todos los registros relacionados a un elemento que pertenece a un conjunto. Recomendada para Filtros.
    ''' </summary>
    ''' <param name="Conjunto">Se requiere un tipo de conjunto de elementos. Ej: Pais.</param>
    ''' <param name="Elemento">Se requiere el nombre de un elemento a extraer. EJ: Argentina.</param>
    ''' <returns></returns>
    ''' 
    Public Function Obtener_Lista(Conjunto As String, Elemento As String) As DataTable
        Select Case UCase(Conjunto)
            Case = "ANIMAL"
                Return Consultando(Sentencia + "and nombre_ent = '" + UCase(Elemento) + "'", "Sonido")

            Case = "CATEGORIA"
                Select Case UCase(Elemento)
                    Case "MAMIFERO"
                        Return Consultando("select id_entidad_cab, nombre_ent from entidad_Cab where rela_padre_ent = 1", "entidad_cab")

                    Case "REPTIL"
                        Return Consultando("select id_entidad_cab, nombre_ent from entidad_Cab where rela_padre_ent = 2", "entidad_cab")

                    Case "ANFIBIO"
                        Return Consultando("select id_entidad_cab, nombre_ent from entidad_Cab where rela_padre_ent = 3", "entidad_cab")

                    Case "AVE"
                        Return Consultando("select id_entidad_cab, nombre_ent from entidad_Cab where rela_padre_ent = 4", "entidad_cab")
                End Select

            Case = "SONIDO"
                Return Consultando(Sentencia + "and tipo_son = '" + UCase(Elemento) + "'", "Clasificacion+Sonido")
        End Select
    End Function

    ''' <summary>
    ''' Permite Filtrar todos los registros relacionados a un elemento que pertenece a un conjunto y obtener registros especificos.
    ''' </summary>
    ''' <param name="Conjunto">Se requiere el conjunto el cual se obtendran los sonidos registrados en el.</param>
    ''' <param name="Elemento">Se requiere el nombre del elemento del cual se capturaran los registros relacionados a el.</param>
    ''' <param name="Filtro">Se rquiere un filtro para filtrar los registros encontrados. </param>
    ''' <returns></returns>
    Public Function Obtener_Lista(Conjunto As String, Elemento As String, Filtro As String) As DataTable
        Select Case UCase(Conjunto)
            Case "ANIMAL"
                Return Consultando(Sentencia + "and nombre_ent = '" + UCase(Elemento) + "' And sexo = '" + UCase(Filtro) + "'", "sonido")

            Case "CATEGORIA"
                MsgBox("Actualmente no existen filtros para los elementos de este conjunto")
                Exit Function
            Case "SONIDO"
                MsgBox("Actualmente no existen filtros para los elementos de este conjunto")
                Exit Function
        End Select
    End Function

    ''' <summary>
    ''' Permite obtener una lista de todos los paises registrados en la base de datos.
    ''' </summary>
    ''' <returns></returns>
    Public Function Obtener_Ubicacion() As DataTable
        Return Consultando("select id_ubicacion, descripcion, descripcion_ubi from ubicacion, nivel_ubic 
                            where rela_nivel = ID_nivel_ubi and rela_nivel = 1", "ubicacion")
    End Function

    ''' <summary>
    ''' Permite obtener todos los datos relacionados a una ID".
    ''' </summary>
    ''' <param name="ID">Se requiere una ID obtenida en el constructor sin parametros de "Obtener_Ubicacion".</param>
    ''' <returns></returns>
    Public Function Obtener_Ubicacion(ID As Integer) As DataTable
        Return Consultando("Select ID_UBICACION, DESCRIPCION FROM UBICACION, NIVEL_UBIC " _
                           + "WHERE RELA_NIVEL = ID_NIVEL_UBI And RELA_PADRE = " + Str(ID), "UBICACION")
    End Function

    Private Function Consultando(Consulta As String, Tabla As String) As DataTable
        Dim DS_Frecuencia As New DataSet
        Dim Adapter As New OracleDataAdapter(UCase(Consulta), Conn)
        Try
            Adapter.Fill(DS_Frecuencia, UCase(Tabla))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return DS_Frecuencia.Tables(UCase(Tabla))
    End Function

    Public Function Agregar_Registro(Animal As String, Clasificacion As String, Sexo As String, Sonido_Tipo As String,
                    M_Frecuencia() As Integer, Pais As String, Region As String, Ciudad As String, Fecha_de_Captura As DateTime, Estacion_del_año As String) As Boolean
        Dim adaptador As New OracleDataAdapter("SELECT * FROM ENTIDAD_CAB", Conn)
        Dim DS_Frecuencia As New DataSet
        Dim Insercion As New OracleCommand
        Dim Registro As DataRow
        Dim Trans As OracleTransaction

        Try
            adaptador.Fill(DS_Frecuencia, "ENTIDAD_CAB")
            Registro = DS_Frecuencia.Tables("ENTIDAD_CAB").NewRow

            Registro("ID_ENTIDAD_CAB") = -1
            Registro("NOMBRE_ENT") = UCase(Animal)
            Select Case UCase(Clasificacion)
                Case "MAMIFERO"
                    Registro("RELA_PADRE_ENT") = 1

                Case "REPTIL"
                    Registro("RELA_PADRE_ENT") = 2

                Case "ANFIBIO"
                    Registro("RELA_PADRE_ENT") = 3

                Case "AVE"
                    Registro("RELA_PADRE_ENT") = 4
            End Select

            Registro("NIVEL") = "ESPECIE"
            Registro("SEXO") = UCase(Sexo)

            DS_Frecuencia.Tables("ENTIDAD_CAB").Rows.Add(Registro)

            Insercion.CommandText = "INSERT INTO ENTIDAD_CAB VALUES(:id,:nombre,:padre,:elnivel,:secso)"
            Insercion.Connection = Conn

            Insercion.Parameters.Add(New OracleParameter(":id", OracleDbType.Int64, 0, "ID_ENTIDAD_CAB"))
            Insercion.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 20, "NOMBRE_ENT"))
            Insercion.Parameters.Add(New OracleParameter(":padre", OracleDbType.Int32, 0, "RELA_PADRE_ENT"))
            Insercion.Parameters.Add(New OracleParameter(":elnivel", OracleDbType.Varchar2, 20, "NIVEL"))
            Insercion.Parameters.Add(New OracleParameter(":secso", OracleDbType.Varchar2, 20, "SEXO"))

            adaptador.InsertCommand = Insercion
            adaptador.Update(DS_Frecuencia, "ENTIDAD_CAB")



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function
End Class