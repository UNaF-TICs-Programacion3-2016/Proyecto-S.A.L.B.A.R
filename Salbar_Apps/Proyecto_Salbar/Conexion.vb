Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Conexion
    Private Conn As New OracleConnection("Data Source = 192.168.2.111;User id = SALBAR;Password = salbar;")
    Private Principio As String = "select id_sonido, tipo_son, nombre_esta, fecha, hora, rela_sonido 
                              from entidad_cab, sonido, descripcion_son, estacion_del_anio, fechahora, detalle_son 
                              where nombre_ent = "

    Private Final As String = " and id_entidad_cab = rela_enti_son
                                  and id_desc_son = rela_descripcion_son
                                  and id_esta_det = rela_esta_det
                                  and id_fechahora = rela_fhora
                                  id_sonido = rela_sonido"

    ''' <summary>
    ''' Permite obtener todos los registros de una determinada tabla.
    ''' </summary>
    ''' <param name="tabla">Se requiere el nombre de la tabla a consultar.</param>
    ''' <returns></returns>
    Public Function Obtener_Tabla(Tabla As String) As DataTable
        Return Consultando("select * from " + UCase(Tabla), UCase(Tabla))
    End Function
    ''' <summary>
    ''' Permite obtener una lista determinada de registro a partir del un dato espesifico. Recomendada para cargar Combobox's.
    ''' </summary>
    ''' <param name="Dato">Se requiere un dato para extraer.</param>
    ''' <returns></returns>
    Public Function Obtener_Lista(Dato As String) As DataTable
        Select Case UCase(Dato)
            Case = "ANIMALES"
                Return Consultando("select id_entidad_cab, nombre_ent from entidad_cab where nivel = 'especie'", "entidad_cab")

            Case = "CATEGORIAS"
                Return Consultando("select id_entidad_cab, nombre_ent from entidad_cab where nivel = 'categoria'", "entidad_cab")

            Case = "SONIDOS"
                Return Consultando("select * from descripcion_Son", "descripcion_son")
        End Select
    End Function

    ''' <summary>
    ''' Permite Obtener una lista de elementos que pertenece a un grupo. Recomendada para Filtros.
    ''' </summary>
    ''' <param name="Tipo">Se requiere un tipo de conjunto de elementos. Ej: Pais.</param>
    ''' <param name="Dato">Se requiere el nombre del conjunto elegido. EJ: Argentina.</param>
    ''' <returns></returns>
    ''' 
    Public Function Obtener_Lista(Tipo As String, Dato As Integer) As DataTable
        Select Case UCase(Tipo)
            Case = "ANIMAL"
                Return Consultando("select id_sonido, nombre_ent, tipo_son, fecha, hora, nombre_esta, descripcion, frecuencia 
                                    from sonido,DESCRIPCION_SON, ESTACION_DEL_ANIO, ENTIDAD_CAB, detalle_son, fechahora, ubicacion, sonid_ubic 
                                    where sonido.RELA_DESCRIPCION_SON = DESCRIPCION_SON.ID_DESC_SON
                                    and rela_esta_det = ESTACION_DEL_ANIO.ID_ESTA_DET
                                    and rela_enti_son = ENTIDAD_CAB.ID_ENTIDAD_CAB
                                    and sonido.RELA_FHORA = fechahora.ID_FECHAHORA
                                    and rela_sonido = id_sonido
                                    and rela_soni = id_sonido and rela_ubic = id_ubicacion
                                    and id_entidad_cab = " + UCase(Dato), "Sonido")


                'Return Consultando("Select * from entidad_cab, sonido where nombre_ent = " + UCase(Dato) + "And rela_sonido = id_sonido", "sonido")

            Case = "CATEGORIA"
                Select Case UCase(Dato)
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
                Return Consultando(Principio + UCase(Dato) + Final, "Clasificacion+Sonido")
        End Select
    End Function

    Public Function Obtener_Lista(Animal As String, Filtro As String, Dato As String) As DataTable
        Select Case UCase(Filtro)
            Case = "SEXO"
                Return Consultando(Principio + UCase(Animal) + "And sexo = " + UCase(Dato) + Final, "sonido")
            Case = "NIVEL"
                Return Consultando(Principio + UCase(Animal) + "And nivel = " + UCase(Dato) + Final, "sonido")
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

    Public Function Agregar_Registro_Online(Animal As String, Clasificacion As String, Sexo As String, Sonido_Tipo As String,
                    M_Frecuencia() As Integer, Pais As String, Region As String, Ciudad As String, Fecha_de_Captura As DateTime, Estacion_del_año As String) As Boolean
        Dim CMD As New OracleCommand()
        Dim TXN As OracleTransaction
        Dim NewID As Long

        Try
            Conn.Open()
            TXN = Conn.BeginTransaction(IsolationLevel.ReadCommitted)
            CMD.Connection = Conn
            CMD.Transaction = TXN
            With CMD
                .CommandType = CommandType.StoredProcedure
                .CommandText = "INSERT_REGISTRO"
                .Parameters.Clear()

                '.Parameters.Add(New OracleParameter(""))
            End With
        Catch ex As Exception

        End Try

    End Function
End Class