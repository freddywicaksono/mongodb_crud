Imports MongoDB.Driver
Imports MongoDB.Bson
Module MyMod
    Public dbClient = New MongoClient()
    Public db As IMongoDatabase
    Public docs As System.Collections.Generic.List(Of BsonDocument)
    Public oTable As MongoDB.Driver.IMongoCollection(Of MongoDB.Bson.BsonDocument)
    Public cn As New Connection

    Public oFakultas As New Fakultas
    Public fakultas_baru As Boolean

    Public Sub DBConnect()
        cn.DbName = "admin"
        cn.ConnectionString = "mongodb://localhost:27017/?readPreference=primary&ssl=false"
        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub
End Module
