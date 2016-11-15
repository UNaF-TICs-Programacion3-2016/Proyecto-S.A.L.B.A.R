Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Conexion
    Private Conn As New OracleConnection("Data Source = 190.5.166.219;User id = SALBAR;Password = salbar;")
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
                Return Consultando("select id_entidad_cab, nombre_ent from entidad_Cab where nivel = especie", "entidad_cab")

            Case = "CATEGORIAS"
                Return Consultando("select id_entidad_cab, nombre_ent from entidad_cab where nivel = categoria", "entidad_cab")

            Case = "SONIDOS"
                Return Consultando("select id_descripcion_sonido, tipo from descripcion_Sonido", "descripcion_sonido")

            Case = "PAISES"
                Return Consultando("select id_ubicacion, descripcion from ubicacion where nivel = pais", "ubicacion")

            Case = "REGIONES"
                Return Consultando("select id_ubicacion, descripcion from ubicacion where nivel = region", "ubicacion")

            Case = "CIUDADES"
                Return Consultando("select id_ubicacion, descripcion from ubicacion where nivel = ciudad", "ubicacion")
        End Select
    End Function
    ''' <summary>
    ''' Permite Obtener una lista de elementos que pertenece a un grupo. Recomendada para Filtros.
    ''' </summary>
    ''' <param name="Tipo">Se requiere un tipo de conjunto de elementos. Ej: Pais.</param>
    ''' <param name="Dato">Se requiere el nombre del conjunto elegido. EJ: Argentina.</param>
    ''' <returns></returns>
    Public Function Obtener_Lista(Tipo As String, Dato As String) As DataTable
        Select Case UCase(Tipo)
            Case = "ANIMAL"
                Return Consultando("Select * from entidad_cab, sonido where nombre_ent = " + UCase(Dato) + "and rela_sonido = id_sonido", "Animal+Sonido")

            Case = "CATEGORIA"
                Return Consultando("Select * from entidad_cab where nombre_ent = " + UCase(Dato) + "and rela_padre = id_entidad_cab", "Categoria+Animal")

            Case = "SONIDO"
                Return Consultando("Select * from descripcion, sonido where tipo = " + UCase(Dato) + "and rela_sonido = id_sonido", "Clasificacion+Sonido")

            Case = "PAIS"
                Return Consultando("Select * from ubicacion where descripcion = " + UCase(Dato) + "and rela_padre = id_ubicacion", "Pais+Region")

            Case = "REGION"
                Return Consultando("Select * from ubicacion where descripcion = " + UCase(Dato) + "and rela_padre = id_ubicacion", "Region+Ciudad")

            Case = "CIUDAD"
                Return Consultando("Select * from ubicacion, entidad_cab where description = " + UCase(Dato) + "and rela_ubicacion = id_ubicacion", "Ciudad+Animal")
        End Select
    End Function

    Public Function Obtener_Lista(Entidad As String, Filtro As String, Dato As String) As DataTable
        Dim Temp As String = "select * from entidad_cab where nombre_ent =" + UCase(Entidad)
        Select Case UCase(Filtro)
            Case = "SEXO"
                Return Consultando(Temp + "and sexo = " + UCase(Dato), "entidad_cab")

            Case = "CATEGORIA"
                Return Consultando(Temp + "and nivel = " + UCase(Dato), "entidad_cab")

        End Select
    End Function

    Public Function Obtener_a_Partir_de_ID(Tabla As String, ID As Integer) As DataRow
        Return Consultando("", "").Rows(0)
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



















    Public Function Insertar_en_mi_tabla(pais As String) As Boolean
        Dim conexcion As New OracleConnection("Data Source = localhost;User id = SnGa089;Password = weightlifting;")
        Dim adaptador As New OracleDataAdapter("SELECT * FROM PAIS_ORIGEN", conexcion)
        Dim DataSet As New DataSet
        Dim Insercion As New OracleCommand
        Dim Registro As DataRow

        Try
            adaptador.Fill(DataSet, "PAIS_ORIGEN")
            Registro = DataSet.Tables("PAIS_ORIGEN").NewRow

            Registro("ID_PAIS_ORIGEN") = 10
            Registro("NOMBRE") = UCase(pais)

            DataSet.Tables("PAIS_ORIGEN").Rows.Add(Registro)

            Insercion.CommandText = "INSERT INTO PAIS_ORIGEN VALUES(:id,:elnombre)"
            Insercion.Connection = conexcion

            Insercion.Parameters.Add(New OracleParameter(":id", OracleDbType.Int32, 0, "ID_PAIS_ORIGEN"))
            Insercion.Parameters.Add(New OracleParameter(":elnombre", OracleDbType.Varchar2, 0, "NOMBRE"))

            adaptador.InsertCommand = Insercion
            adaptador.Update(DataSet, "PAIS_ORIGEN")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function



    Public Function Insertar_un_Registro(animal As String, Nivel As String, Sexo As String) As Boolean
        Dim DS_Frecuencia As New DataSet
        Dim Adapter As New OracleDataAdapter("SELECT * FROM ENTIDAD_CAB WHERE ID_ENTIDAD_CAB = -1", Conn)
        Dim InsertCmd As New OracleCommand
        Dim Registro As DataRow
        Try
            Adapter.Fill(DS_Frecuencia, "ENTIDAD_CAB")
            Registro = DS_Frecuencia.Tables("ENTIDAD_CAB").NewRow

            Registro("ID_ENTIDAD_CAB") = -1
            Registro("NOMBRE_ENT") = UCase(animal)
            Registro("NIVEL") = UCase(Nivel)
            Registro("SEXO") = UCase(Sexo)
            DS_Frecuencia.Tables("ENTIDAD_CAB").Rows.Add(Registro)

            InsertCmd.CommandText = "INSERT INTO ENTIDAD_CAB(:id,:nombre,:elnivel,:susexo)"
            InsertCmd.Connection = Conn

            InsertCmd.Parameters.Add(New OracleParameter("id", OracleDbType.Int32, 0, "ID_NOMBRE_ENT"))
            InsertCmd.Parameters.Add(New OracleParameter("nombre", OracleDbType.NVarchar2, 0, "NOMBRE_ENT"))
            InsertCmd.Parameters.Add(New OracleParameter("elnivel", OracleDbType.NVarchar2, 0, "NIVEL"))
            InsertCmd.Parameters.Add(New OracleParameter("susexo", OracleDbType.NVarchar2, 0, "SEXO"))

            Adapter.InsertCommand = InsertCmd
            Adapter.Update(DS_Frecuencia, "ENTIDAD_CAB")

        Catch ex As Exception
            MsgBox(ex.Message)
            Insertar_un_Registro = False
            Exit Function
        End Try

        Insertar_un_Registro = True
    End Function
End Class