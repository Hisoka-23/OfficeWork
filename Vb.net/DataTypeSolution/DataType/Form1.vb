Public Class Form1

    Private Sub BtnPhone16Properities_Click(sender As Object, e As EventArgs) Handles BtnPhone16Properities.Click

        Dim StrBrand As String
        Dim StrModel As String
        Dim IntBattery As Integer
        Dim DoubleScreenSize As Double
        Dim DecPrice As Decimal
        Dim BoolAvailability As Boolean

        StrBrand = "Apple"
        StrModel = "IPhone 16"
        IntBattery = 4500
        DoubleScreenSize = 6.7
        DecPrice = 799.99
        BoolAvailability = True

        MessageBox.Show(StrBrand & Environment.NewLine & StrModel & Environment.NewLine &
                        IntBattery & Environment.NewLine & DoubleScreenSize & Environment.NewLine &
                        DecPrice & Environment.NewLine & BoolAvailability)

    End Sub

End Class
