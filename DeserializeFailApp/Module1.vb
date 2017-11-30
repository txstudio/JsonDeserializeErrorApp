Imports Newtonsoft.Json

Module Module1

    Sub Main()
        Dim _Json As String
        Dim _User As User

        _Json = <s>{"No":1,"Name":"txstudio"}</s>
        _User = JsonConvert.DeserializeObject(_Json)

        Console.WriteLine()
        Console.WriteLine("No   : {0}", _User.No)
        Console.WriteLine("Name : {0}", _User.Name)
        Console.WriteLine()

        Console.WriteLine("press any key to exit")
        Console.ReadKey()
    End Sub


    Public Class User
        Public Property No As Integer
        Public Property Name As String
    End Class

End Module
