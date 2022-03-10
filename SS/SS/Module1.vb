Module Module1
    Public Function CalSS(ByVal preco As Decimal)
        Dim SS As Decimal = preco * 0.11
        Return SS
    End Function

    Public Function CalIRS(ByVal preco As Decimal)
        Dim IRS As Decimal = preco * 0.145
        Return IRS
    End Function

End Module
