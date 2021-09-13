Imports System.Console
Imports System.RegEx

Module PasswordChecker
    Sub Main(args As String())

        'DIMENSIONS'
        '----------'

        Dim password As String
        Dim charactercount As Integer
        Dim CapitalCheck As Boolean
        Dim SymbolCheck As Boolean
        Dim NumberCheck As Boolean
        Dim passwordconfirmation As String
        Dim failed As Boolean

        '--------------------------'
        'PASSWORD CHECKER MAIN CODE'
        '--------------------------'

        failed = False
        WriteLine("Please enter the password you wish to check.")
        password = ReadLine()
        WriteLine("Done! Now enable the checks you want to enable.")
        WriteLine("Simply enter 'y' (case sensitive) to enable the check, or anything else to disable it. Try it here!")
        WriteLine("Example check")

        If ReadLine() = "y" Then
            WriteLine("You enabled the sample check!")
            WriteLine("This is just a sample so won't do anything, but hopefully that shows you how to enable checks.")
        Else
            WriteLine("You disabled the sample check!")
            WriteLine("This is just a sample so won't do anything, but hopefully that shows you how to enable checks.")
        End If

        WriteLine("OK! Now lets choose some checks!")

        WriteLine("Character Count: How many characters the password should be")
        WriteLine("***IMPORTANT: ENTER THE NUMBER ONLY THAT MATCHES THE MINIMUM NUMBER OF CHARACTERS YOU WANT***")
        WriteLine("If you do not want a minimum character count, enter 0.")
        charactercount = ReadLine()
        WriteLine("Successfully set the minimum character count as " & charactercount & " .")

        WriteLine("Capital Check: Does the password require a capital letter?")

        If ReadLine() = "y" Then
            CapitalCheck = True
            WriteLine("Successfully enabled the Capital Check")

        Else
            CapitalCheck = False
            WriteLine("Skipped the Capital Check.")
        End If

        WriteLine("Symbol Check: Should the password contain a symbol or special character?")
        If ReadLine() = "y" Then
            SymbolCheck = True
            WriteLine("Successfully enabled the Symbol Check.")

        Else
            SymbolCheck = False
            WriteLine("Skipped the Symbol Check.")
        End If

        WriteLine("Number Check: Should the password contain a number?")
        If ReadLine() = "y" Then
            NumberCheck = True
            WriteLine("Successfully enabled the number check")

        Else
            NumberCheck = False
            WriteLine("Skipped the Number Check.")
        End If

        WriteLine("All checks chosen. Now commencing password check.")

        If Len(password) > charactercount Then

            WriteLine("Successfully passed character count check.")

        Else
            WriteLine("Failed character count check")
            failed = True
        End If

        If CapitalCheck = True Then
            If Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then
                WriteLine("Successfully passed capital check")

            Else
                WriteLine("Failed capital check")
                failed = True
            End If
        End If

        If SymbolCheck = True Then
            'Placeholder for Symbol Check Script
            WriteLine("Skipped Symbol Check - Symbol Check has not been implemented yet")
        End If

        If NumberCheck = True Then
            If Text.RegularExpressions.Regex.IsMatch(password, "\d") Then
                WriteLine("Successfully passed number check")

            Else

                WriteLine("Failed number check")
                failed = True

            End If
        End If

        If failed = False Then
            WriteLine("The password has passed all enabled checks.")
            WriteLine("Please enter password again to confirm.")
            passwordconfirmation = ReadLine()
            If passwordconfirmation = password Then
                WriteLine("Both passwords match and pass all enabled checks. Congratulations!")
                End

            Else
                WriteLine("Passwords do not match.")
                End
            End If
        Else
            WriteLine("Your password failed one or more checks.")
            End
        End If


    End Sub
End Module
