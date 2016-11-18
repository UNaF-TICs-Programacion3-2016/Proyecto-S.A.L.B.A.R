Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Conexion
    Private Conn As New OracleConnection("Data Source = 192.168.2.111;User id = SALBAR;Password = salbar;")
    Private Sentencia As String = "select id_sonido, nombre_ent, tipo_son, nombre_esta, descripcion, frecuencia 
                                    from sonido,DESCRIPCION_SON, ESTACION_DEL_ANIO, ENTIDAD_CAB, detalle_son, ubicacion, sonid_ubic 
                                    where sonido.RELA_DESCRIPCION_SON = DESCRIPCION_SON.ID_DESC_SON
                                    and rela_esta_det = ESTACION_DEL_ANIO.ID_ESTA_DET
                                    and rela_enti_son = ENTIDAD_CAB.ID_ENTIDAD_CAB
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
                Return Consultando("select id_entidad_cab, nombre_ent, sexo from entidad_cab where nivel = 'especie'", "entidad_cab")

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
                Select Case UCase(Elemento)

                    Case "MACHO"
                        Return Consultando("select id_entidad_cab, nombre_ent from entidad_cab where nivel = 'especie' and sexo = 'macho'", "entidad_cab")

                    Case "HEMBRA"
                        Return Consultando("select id_entidad_cab, nombre_ent from entidad_cab where nivel = 'especie' and sexo = 'hembra'", "entidad_cab")

                    Case Else
                        Return Consultando(Sentencia + "and nombre_ent = '" + UCase(Elemento) + "'", "Sonido")

                End Select

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

    Public Function Insertar_Animal(Nombre As String, Categoria As String, Sexo As String) As Boolean
        If Animal_registrado(Nombre, Categoria, Sexo) = True Then
            Insertar_Animal = False
            Exit Function
        End If
        Dim CMD As New OracleCommand
        Dim Transaccion As OracleTransaction
        Dim Ultimo_ID As Long
        Try
            Conn.Open()

            Transaccion = Conn.BeginTransaction(IsolationLevel.ReadCommitted)
            CMD.Connection = Conn
            CMD.Transaction = Transaccion

            With CMD
                .CommandType = CommandType.StoredProcedure
                .CommandText = "INSERTAR_ANIMAL"
                .Parameters.Clear()

                .Parameters.Add(New OracleParameter("NOMBRE_ANIMAL", OracleDbType.NVarchar2) With {.Value = UCase(Nombre)})
                .Parameters.Add(New OracleParameter("CATEGORIA", OracleDbType.NVarchar2) With {.Value = UCase(Categoria)})
                .Parameters.Add(New OracleParameter("SEXO", OracleDbType.NVarchar2) With {.Value = Sexo})
                .Parameters.Add(New OracleParameter("LAST_ID", OracleDbType.Int32, ParameterDirection.Output))

                .ExecuteNonQuery()

                MsgBox(.Parameters("LAST_ID").Value)
                Ultimo_ID = Long.Parse(.Parameters("LAST_ID").Value.ToString)
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Animal_registrado(animal As String, categoria As String, sexo As String) As Boolean
        Dim Temp As DataTable

        Temp = Obtener_Lista("Animal", UCase(animal), UCase(sexo))

        If Temp.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class