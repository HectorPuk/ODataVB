Imports WindowsApplication1.ServiceReference1
Imports System.Data.Services.Client
Imports System
Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim northwindUri As Uri = New Uri("http://192.168.1.26:50000/b1s/v1/")

        Dim context As SAPB1.ServiceLayer = New SAPB1.ServiceLayer(northwindUri)

        AddHandler context.SendingRequest, AddressOf OnSendingRequest

        'AddHandler context2.SendingRequest, AddressOf OnSendingRequest2

        'Dim factura As SAPB1.Document
        Dim j As Integer = 1

        Try

            j = context.Orders.Count()
            j = context.Invoices.Count()
            j = context.DeliveryNotes.Count()
            j = context.PurchaseInvoices.Count()

        Catch ex As Exception

            Dim i As Integer = 1

        End Try

        Dim t As Integer = 1

        'Asi se supone que deberia agregar una factura.

        'context.AddToInvoices(factura)

        'Asi se supone que deberia obtener una order.

        'context.Orders.Where(factura, True)

    End Sub
    Private Shared Sub OnSendingRequest(ByVal sender As Object, ByVal e As SendingRequestEventArgs)
        ' Add an Authorization header that contains an OAuth WRAP access token to the request.
        e.RequestHeaders.Add("Authorization", "Basic eyJDb21wYW55REIiOiAiQVJfU1RBUlBPU19WS19TV0VFVCIsICJVc2VyTmFtZSI6ICJtYW5hZ2VyIn06dmFsa2ltaWEzMw==")
    End Sub
    Private Shared Sub OnSendingRequest2(ByVal sender As Object, ByVal e As SendingRequestEventArgs)
        ' Add an Authorization header that contains an OAuth WRAP access token to the request.
        e.RequestHeaders.Add("Authorization", "Basic eyJDb21wYW55REIiOiAiQVJfU1RBUlBPU19WS19TV0VFVCIsICJVc2VyTmFtZSI6ICJtYW5hZ2VyIn06dmFsa2ltaWEzMw==")
    End Sub
End Class
