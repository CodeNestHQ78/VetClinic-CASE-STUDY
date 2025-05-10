
Imports MySql.Data.MySqlClient
Module Module1
    'Method Para fafall si connection open, connection string and connection close
    Public con As New MySqlConnection
    'Method to handle sql commands for our project
    Public cmd As New MySqlCommand
    'Method Responsible for getting records kapag ginamit mo si select command
    Public adapter As New MySqlDataAdapter
    'Method para palabasin ko sya sa mga controls
    Public data As New DataSet
    'Method para palabasin sa datagidview
    Public Table As New DataTable


    Sub openCon()

        con.ConnectionString = "server=localhost;username=root;password=;database=db_clinic"
        con.Open()


    End Sub


End Module
