Imports MongoDB.Driver

Public Class Connection

    Private _connected As Boolean = False
    Private _dbname As String
    Private _constring As String


    ''' <summary>
    ''' DB Name
    ''' </summary>
    Public Property DbName()
        Get
            Return _dbname
        End Get
        Set(ByVal value)
            _dbname = value
        End Set
    End Property

    ''' <summary>
    ''' Connectio String
    ''' </summary>
    Public Property ConnectionString()
        Get
            Return _constring
        End Get
        Set(ByVal value)
            _constring = value
        End Set
    End Property

    ''' <summary>
    ''' Proses menyambungkan koneksi (SQL Server Express with Integrated Security = True without Username or Password)
    ''' </summary>
    Public Sub Connect()
        Try
            'dbClient = "mongodb://" & _host & ":" & _port & "/?readPreference=primary&appname=MongoDB%20Compass&ssl=false"
            dbClient = New MongoClient(_constring)
            db = dbClient.GetDatabase(_dbname)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            _connected = False
        Finally
            _connected = True

        End Try
    End Sub

    ''' <summary>
    ''' Proses memutuskan koneksi
    ''' </summary>
    Public Sub Disconnect()
        dbClient = vbNull
        _connected = False
    End Sub


End Class