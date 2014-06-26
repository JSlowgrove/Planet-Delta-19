Module Module1
    Sub Main()
        Dim choice As String
        masteredchaosdisplay() 'displays mastered chaos logo
        Console.ReadKey()
        Do
            mainmenudisplay() 'displays main menu
            choice = Console.ReadLine() 'takes choice then direct it acordinaly, if choice does not fit a route it just clears screen and asks again
            If choice = "1" Then
                Story()
            ElseIf choice = "2" Then
                battlemode()
            ElseIf choice = "3" Then
                credits()
            ElseIf choice = "4" Then
                End
            Else
            End If
        Loop 'unending loop, game only ends when chosen 
    End Sub
    Sub masteredchaosdisplay()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("                         ")
        Console.ForegroundColor = ConsoleColor.White
        Console.BackgroundColor = ConsoleColor.Red
        Console.Write("M")
        Console.ForegroundColor = ConsoleColor.Black
        Console.WriteLine("astered ")
        Console.ForegroundColor = ConsoleColor.White
        Console.BackgroundColor = ConsoleColor.Black
        Console.Write("                       ")
        Console.BackgroundColor = ConsoleColor.Red
        Console.WriteLine("C  H  A  O  S")
        Console.BackgroundColor = ConsoleColor.Black
    End Sub 'writes the Mastered chaos logo to the screen
    Sub mainmenudisplay()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("    INFERNUM")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("A text based RPG.")
        Console.WriteLine()
        Console.WriteLine("Please choose the drop zone:")
        Console.Write("1) ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("War Zone")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" (Story mode)")
        Console.Write("2) ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("Battle Zone")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" (Battle mode)")
        Console.Write("3) ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("Memorial Zone")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" (Game credits)")
        Console.Write("4) ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("Evacuation Zone")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" (End game)")
        Console.WriteLine()
    End Sub 'writes the main menu display to a blank screen
    Sub Story()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("War Zone")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" (Story mode)")
        Console.WriteLine()
        Console.ReadKey()
    End Sub
    Sub battlemode()
        Dim choice As String
        Do ' loops until choice is 9 then returns to main
            battlemodedisplay() ' displays battle zone menu
            Console.WriteLine()
            choice = Console.ReadLine()
            If choice = "1" Then 'all choice results currently only temporary <29/3/2012>
                Console.WriteLine()
                Console.WriteLine("Enemy type 1 killed")
                Console.ReadKey()
            ElseIf choice = "2" Then
                Console.WriteLine()
                Console.WriteLine("Enemy type 2 killed")
                Console.ReadKey()
            ElseIf choice = "3" Then
                Console.WriteLine()
                Console.WriteLine("Enemy type 3 killed")
                Console.ReadKey()
            ElseIf choice = "4" Then
                Console.WriteLine()
                Console.WriteLine("Enemy type 4 killed")
                Console.ReadKey()
            ElseIf choice = "5" Then
                Console.WriteLine()
                Console.WriteLine("Enemy type 5 killed")
                Console.ReadKey()
            ElseIf choice = "6" Then
                Console.WriteLine()
                Console.WriteLine("Enemy type 6 killed")
                Console.ReadKey()
            ElseIf choice = "7" Then
                Console.WriteLine()
                Console.WriteLine("Enemy type 7 killed")
                Console.ReadKey()
            ElseIf choice = "8" Then
                Console.WriteLine()
                Console.WriteLine("Enemy Lord Nex killed")
                Console.ReadKey()
            Else
            End If
        Loop Until choice = "9"
    End Sub
    Sub battlemodedisplay()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("Battle Zone")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" (Battle mode)")
        Console.WriteLine()
        Console.WriteLine("Please choose your action!")
        Console.Write("1) Fight ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Grunt")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("2) Fight ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Hench")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("3) Fight ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Rogue")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("4) Fight ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Assassin")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("5) Fight ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Warrior")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("6) Fight ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Array Leader")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("7) Fight ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Port Leader")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("8) Fight ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Lord Nex")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("9)")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write(" Leave")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine()
    End Sub 'writes the battle zone display to a blank screen
    Sub credits()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("Memorial Zone")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" (Game credits)")
        Console.WriteLine()
        masteredchaosdisplay()
        Console.WriteLine()
        Console.WriteLine("All charcters and events are created by Jamie Slowgrove.")
        Console.WriteLine("All characters and events are all fictitious.")
        Console.WriteLine("Any resemblance to real events or people are purely coincidental.")
        Console.WriteLine("All character and place names are created from the Latin language.")
        Console.ReadKey()
    End Sub 'writes the credits display to a blank screen

End Module
