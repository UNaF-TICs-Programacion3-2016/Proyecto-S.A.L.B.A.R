Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Conexion
    Private Conn As New OracleConnection("Data Source = 190.5.166.219;User id = SALBAR;Password = salbar;")

    Public Function Consultar_en_la_BD() As DataTable
        Return Consultando("select * from entidad_cab", "entidad_cab")
    End Function
    Public Function Consultar_en_la_BD(Dato As String) As DataTable
        Select Case UCase(Dato)
            Case = "ANIMALES"
                Return Consultando("select id_entidad_cab, nombre_ent from entidad_Cab where nivel = especie", "entidad_cab")

            Case = "CATEGORIAS"
                Return Consultando("select id_entidad_cab, nombre_ent from entidad_cab where nivel = categoria", "entidad_cab")

            Case = "SONIDOS"
                Return Consultando("select * from descripcion_Sonido", "descripcion_sonido")

            Case = "PAISES"
                Return Consultando("select ", "")

            Case Else
                Return Consultando("Select * from entidad_cab where nombre_ent = " + UCase(Dato), "entidad_cab")
        End Select
    End Function

    Public Function Consultar_en_la_BD(Entidad As String, Filtro As String) As DataTable 'categotia, especie genero, lugar fecha y hora
        Select Case UCase(Filtro)
            Case = ""
        End Select
        'Return Consultando("SELECT * FROM ENTIDAD_CAB WHERE ")
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