Imports WindowsApplication1.Pisco2

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim northwindUri As Uri = New Uri("http://192.168.1.26:50000/b1s/v1/")

        Dim Kiko As Pisco2.SAPB1.ServiceLayer = New Pisco2.SAPB1.ServiceLayer(northwindUri)

        Kiko.Format.UseJson()

        Dim context As SAPB1.BusinessPartner = New SAPB1.BusinessPartner


        'v4lk1m14()


        context.CardCode = 22
        context.CardName = "Jose Ingenieria S.A."



    End Sub
End Class
