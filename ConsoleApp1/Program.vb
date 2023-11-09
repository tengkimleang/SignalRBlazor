Imports System
Imports System.Numerics

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim work As String
        work = changeToWords("101000.50")
        Console.WriteLine(work)
    End Sub
#Region "Comment"
    'Public Shared Function changeToWords(ByVal numb As [String]) As [String]
    '    Dim val As [String] = "", wholeNo As [String] = numb, points As [String] = "", andStr As [String] = "", pointStr As [String] = ""
    '    Dim endStr As [String] = ""
    '    Try
    '        Dim decimalPlace As Integer = numb.IndexOf(".")
    '        If decimalPlace > 0 Then
    '            wholeNo = numb.Substring(0, decimalPlace)
    '            points = numb.Substring(decimalPlace + 1)
    '            If Convert.ToInt32(points) > 0 Then
    '                andStr = "point"
    '                ' just to separate whole numbers from points
    '                pointStr = translateCents(points)
    '            End If
    '        End If
    '        val = [String].Format("{0} {1}{2} {3}", translateWholeNumber(wholeNo, Convert.ToDouble(wholeNo).ToString().Length).Trim(), andStr, pointStr, endStr)
    '    Catch
    '    End Try
    '    Return val
    'End Function
    'Private Shared Function translateWholeNumber(ByVal number As [String], ByVal test As [String]) As [String]
    '    Dim word As String = ""
    '    Try
    '        Dim beginsZero As Boolean = False
    '        'tests for 0XX
    '        Dim isDone As Boolean = False
    '        'test if already translated
    '        Dim dblAmt As Double = (Convert.ToDouble(number))
    '        'if ((dblAmt > 0) && number.StartsWith("0"))
    '        If dblAmt > 0 Then
    '            'test for zero or digit zero in a nuemric
    '            beginsZero = number.StartsWith("0")
    '            Dim numDigits As Integer
    '            If beginsZero Then
    '                numDigits = Right(number, number.Length - 1).Length
    '            Else
    '                numDigits = number.Length
    '            End If
    '            'Dim numDigits As Integer = number.Length
    '            Dim pos As Integer = 0
    '            'store digit grouping
    '            Dim place As [String] = ""
    '            'digit grouping name:hundres,thousand,etc...
    '            Select Case numDigits
    '                Case 1
    '                    'ones' range
    '                    word = ones(number)
    '                    isDone = True
    '                    Exit Select
    '                Case 2
    '                    'tens' range
    '                    word = tens(number)
    '                    isDone = True
    '                    Exit Select
    '                Case 3
    '                    'hundreds' range
    '                    pos = (numDigits Mod 3) + 1
    '                    place = " Hundred "
    '                    Exit Select
    '            'thousands' range
    '                Case 4, 5, 6
    '                    pos = (numDigits Mod 4) + 1
    '                    place = " Thousand "
    '                    Exit Select
    '            'millions' range
    '                Case 7, 8, 9
    '                    pos = (numDigits Mod 7) + 1
    '                    place = " Million "
    '                    Exit Select
    '                Case 10
    '                    'Billions's range
    '                    pos = (numDigits Mod 10) + 1
    '                    place = " Billion "
    '                    Exit Select
    '                Case Else
    '                    'add extra case options for anything above Billion...
    '                    isDone = True
    '                    Exit Select
    '            End Select
    '            If Not isDone Then
    '                'if transalation is not done, continue...(Recursion comes in now!!)
    '                word = translateWholeNumber(number.Substring(0, pos), test) + place + translateWholeNumber(number.Substring(pos), test)
    '                'check for trailing zeros
    '                If beginsZero And Convert.ToDouble(number).ToString().Length = 3 Then
    '                    word = " and " & word.Trim()
    '                End If
    '            End If
    '            'ignore digit grouping names
    '            If word.Trim().Equals(place.Trim()) Then
    '                word = ""
    '            End If
    '        End If
    '    Catch


    '    End Try
    '    Return word.Trim()
    'End Function
    'Private Shared Function tens(ByVal digit As [String]) As [String]
    '    Dim digt As Integer = Convert.ToInt32(digit)
    '    Dim name As [String] = Nothing
    '    Select Case digt
    '        Case 10
    '            name = "Ten"
    '            Exit Select
    '        Case 11
    '            name = "Eleven"
    '            Exit Select
    '        Case 12
    '            name = "Twelve"
    '            Exit Select
    '        Case 13
    '            name = "Thirteen"
    '            Exit Select
    '        Case 14
    '            name = "Fourteen"
    '            Exit Select
    '        Case 15
    '            name = "Fifteen"
    '            Exit Select
    '        Case 16
    '            name = "Sixteen"
    '            Exit Select
    '        Case 17
    '            name = "Seventeen"
    '            Exit Select
    '        Case 18
    '            name = "Eighteen"
    '            Exit Select
    '        Case 19
    '            name = "Nineteen"
    '            Exit Select
    '        Case 20
    '            name = "Twenty"
    '            Exit Select
    '        Case 30
    '            name = "Thirty"
    '            Exit Select
    '        Case 40
    '            name = "Fourty"
    '            Exit Select
    '        Case 50
    '            name = "Fifty"
    '            Exit Select
    '        Case 60
    '            name = "Sixty"
    '            Exit Select
    '        Case 70
    '            name = "Seventy"
    '            Exit Select
    '        Case 80
    '            name = "Eighty"
    '            Exit Select
    '        Case 90
    '            name = "Ninety"
    '            Exit Select
    '        Case Else
    '            If digt > 0 Then
    '                name = (tens(digit.Substring(0, 1) & "0") & " ") + ones(digit.Substring(1))
    '            End If
    '            Exit Select
    '    End Select
    '    Return name
    'End Function
    'Private Shared Function ones(ByVal digit As [String]) As [String]
    '    Dim digt As Integer = Convert.ToInt32(digit)
    '    Dim name As [String] = ""
    '    Select Case digt
    '        Case 1
    '            name = "One"
    '            Exit Select
    '        Case 2
    '            name = "Two"
    '            Exit Select
    '        Case 3
    '            name = "Three"
    '            Exit Select
    '        Case 4
    '            name = "Four"
    '            Exit Select
    '        Case 5
    '            name = "Five"
    '            Exit Select
    '        Case 6
    '            name = "Six"
    '            Exit Select
    '        Case 7
    '            name = "Seven"
    '            Exit Select
    '        Case 8
    '            name = "Eight"
    '            Exit Select
    '        Case 9
    '            name = "Nine"
    '            Exit Select
    '    End Select
    '    Return name
    'End Function
    'Private Shared Function translateCents(ByVal cents As [String]) As [String]
    '    Dim cts As [String] = "", digit As [String] = "", engOne As [String] = ""
    '    For i As Integer = 0 To cents.Length - 1
    '        digit = cents(i).ToString()
    '        If digit.Equals("0") Then
    '            engOne = "Zero"
    '        Else
    '            engOne = ones(digit)
    '        End If
    '        cts += " " & engOne
    '    Next
    '    Return cts
    'End Function
#End Region
    Public Function changeToWords(ByVal MyNumber)

        Dim Dollars, Cents, Temp

        Dim DecimalPlace, Count

        Dim Place(9) As String

        Place(2) = " Thousand "

        Place(3) = " Million "

        Place(4) = " Billion "

        Place(5) = " Trillion "

        ' String representation of amount.

        MyNumber = Trim(Str(MyNumber))

        ' Position of decimal place 0 if none.

        DecimalPlace = InStr(MyNumber, ".")

        ' Convert cents and set MyNumber to dollar amount.

        If DecimalPlace > 0 Then

            Cents = GetTens(Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2))

            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))

        End If

        Count = 1

        Do While MyNumber <> ""

            Temp = GetHundreds(Right(MyNumber, 3))

            If Temp <> "" Then Dollars = Temp & Place(Count) & Dollars

            If Len(MyNumber) > 3 Then

                MyNumber = Left(MyNumber, Len(MyNumber) - 3)

            Else

                MyNumber = ""

            End If

            Count = Count + 1

        Loop

        Select Case Dollars

            Case ""

                Dollars = "No"'Baht

            Case "One"

                Dollars = "One" 'Baht

            Case Else

                Dollars = Dollars & "" 'Bahts

        End Select

        Select Case Cents

            Case ""

                Cents = " and No Cents "

            Case "One"

                Cents = " and One Cent "

            Case Else

                Cents = " and " & Cents & " Cents "

        End Select

        changeToWords = Dollars & Cents

    End Function
    ' Converts a number from 100-999 into text
    Public Function GetHundreds(ByVal MyNumber)

        Dim Result As String

        If Val(MyNumber) = 0 Then Exit Function

        MyNumber = Right("000" & MyNumber, 3)

        ' Convert the hundreds place.

        If Mid(MyNumber, 1, 1) <> "0" Then

            Result = GetDigit(Mid(MyNumber, 1, 1)) & " Hundred "

        End If

        ' Convert the tens and ones place.

        If Mid(MyNumber, 2, 1) <> "0" Then

            Result = Result & GetTens(Mid(MyNumber, 2))

        Else

            Result = Result & GetDigit(Mid(MyNumber, 3))

        End If

        GetHundreds = Result

    End Function
    ' Converts a number from 10 to 99 into text.
    Public Function GetTens(TensText)

        Dim Result As String

        Result = "" ' Null out the temporary function value.

        If Val(Left(TensText, 1)) = 1 Then ' If value between 10-19...

            Select Case Val(TensText)

                Case 10 : Result = "Ten"

                Case 11 : Result = "Eleven"

                Case 12 : Result = "Twelve"

                Case 13 : Result = "Thirteen"

                Case 14 : Result = "Fourteen"

                Case 15 : Result = "Fifteen"

                Case 16 : Result = "Sixteen"

                Case 17 : Result = "Seventeen"

                Case 18 : Result = "Eighteen"

                Case 19 : Result = "Nineteen"

                Case Else

            End Select

        Else ' If value between 20-99...

            Select Case Val(Left(TensText, 1))

                Case 2 : Result = "Twenty "

                Case 3 : Result = "Thirty "

                Case 4 : Result = "Forty "

                Case 5 : Result = "Fifty "

                Case 6 : Result = "Sixty "

                Case 7 : Result = "Seventy "

                Case 8 : Result = "Eighty "

                Case 9 : Result = "Ninety "

                Case Else

            End Select

            Result = Result & GetDigit(Right(TensText, 1)) ' Retrieve ones place.

        End If

        GetTens = Result

    End Function
    ' Converts a number from 1 to 9 into text.
    Public Function GetDigit(Digit)

        Select Case Val(Digit)

            Case 1 : GetDigit = "One"

            Case 2 : GetDigit = "Two"

            Case 3 : GetDigit = "Three"

            Case 4 : GetDigit = "Four"

            Case 5 : GetDigit = "Five"

            Case 6 : GetDigit = "Six"

            Case 7 : GetDigit = "Seven"

            Case 8 : GetDigit = "Eight"

            Case 9 : GetDigit = "Nine"

            Case Else : GetDigit = ""

        End Select

    End Function
End Module
