
'	Microsoft Visual Studio Ultimate 2012 
'	Version 11.0.61030.00 Update 4
'	Author: NKUCodingCat<admin@nkucodingcat.com>

Module Module1
    Function Mul(ByRef ____ As Integer, ByRef ___ As Integer, ByRef __ As Integer) As Integer
        __ = ____ * ___
        Return __
    End Function
    Function __(ByVal ______ As Integer, ByVal _______ As Integer)
        Dim ____() As Integer = {44, 13, -5, 5, 11, 78, 5, -5, 78, 0, -1, -6, 78, -1, 0, 2, -11, 78, 8, -1, -4, 78, 12, 9, 7, 5, 0, 0, 9, -4, -5}
        Mul(((______ >> 1) << 1), ______, _______)
        For Each __ In ____
            System.Console.Write(Chr(_______ - __))
        Next
    End Function
    Sub Main()
        __(107 And 159, Integer.MinValue)
    End Sub

End Module