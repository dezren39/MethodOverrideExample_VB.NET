Public Class HowManyTires
    Class Auto
        Overridable Function Tires() As Decimal
            Tires = 4 'Hard coding is bad, this is an example.
        End Function
    End Class
    Class Moto
        Inherits Auto
        Overrides Function Tires() As Decimal
            Tires = 2 'Still bad, maybe a couple less.
        End Function
    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Automobile As Auto = New Auto
        Dim Motorcycle As New Moto

        lblAuto.Text = "An automobile has this many tires: " + Automobile.Tires().ToString
        lblMoto.Text = "A motorcycle has this many tires: " + Motorcycle.Tires().ToString
    End Sub
End Class
