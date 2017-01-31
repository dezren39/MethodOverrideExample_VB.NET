# MethodOverrideExample_VB.NET
I made this small project to demonstrate the keywords 'Override' and 'Overridable' for my peers.

Public Class HowManyTires
    Class Auto
            Overridable Function Tires() As Decimal 'Allows derived classes to Override Tires()
                     Tires = 4 'Hard coding is bad, this is an example. Please forgive me.
            End Function
    End Class


    Class Moto
            Inherits Auto 'This means that the Moto Class inherits and becomes derived of Auto
            Overrides Function Tires() As Decimal 'Replace Auto's Tires() method with Moto's
                     Tires  = 2 'Hard code still bad,  a couple less though.
            End Function
    End Class


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim Automobile As Auto = New Auto 'Make a new instance of the class Auto
            Dim Motorcycle As New Moto 'Make a new instance of the derived class Moto

            lblAuto.Text = "An automobile has this many tires: " + Automobile.Tires().ToString 
            lblMoto.Text = "A motorcycle has this many tires: " + Motorcycle.Tires().ToString

            'Both text labels above receive their values from the same method call. One

            'instance generates from Auto as 4, the other generates from Moto as 2. 

            'This was achieved through allowing the base class's function to be Overridable 

            'and Override'ing the base function.
    End Sub

End Class
