﻿Module Module1
    Dim charname, backstory, mainchoice As String
    Dim health, completion, leaderhealth, leaderdamage, warriorhealth, warriordamage, assasinhealth, assasindamage, grunthealth, gruntdamage, henchhealth, henchdamage, rougehealth, rougedamage, healthpack As Integer
    Sub Main()
        completion = 0
        GoTo mainmenu 'startup

mainmenu:
        Console.Clear()
        Console.WriteLine("Hello and welcome to Jamie's RPG")
        Console.WriteLine("Please choose what you wish to do: (Story/Battle Mode/Controls/Credits/End Game)")
        mainchoice = Console.ReadLine
        mainchoice = UCase(mainchoice)
        Select Case mainchoice
            Case "STORY"
                GoTo story
            Case "BATTLE MODE"
                GoTo battlemode
            Case "CREDITS"
                Console.Clear()
                Console.WriteLine("----------CREDITS----------")
                Console.WriteLine("Story by Jamie Slowgrove")
                Console.WriteLine("Navigation by Jamie Slowgrove")
                Console.WriteLine("Battle Mode by Jamie Slowgrove")
                Console.WriteLine("The text image of a knight was made by Jack Taylor")
                Console.WriteLine("                     |         ")
                Console.WriteLine("                     |         ")
                Console.WriteLine("                  O  +        ")
                Console.WriteLine("                  ^ /         ")
                Console.WriteLine("              ___/|        ")
                Console.WriteLine("              |0| |           ")
                Console.WriteLine("               V  ^           ")
                Console.WriteLine("                 / \          ")
                Console.WriteLine("               _/   \_        ")
                Console.ReadKey()
                GoTo mainmenu
            Case "CONTROLS"
                Console.Clear()
                Console.WriteLine("----------CONTROLS----------")
                Console.WriteLine("In Order for you to play this game all that you need to do is:")
                Console.WriteLine("1) Read the question asked. (e.g Please choose what you wish to do")
                Console.WriteLine("2) After the question there will a set of words in brackets, these are the words that need to be typed in. (e.g (Shoot/melee))")
                Console.WriteLine("3) Type in your choise, it does not matter if it is in capitals or not.")
                Console.WriteLine("4) Press enter and your choice will take you to the next area.")
                Console.WriteLine("                     |         ")
                Console.WriteLine("                     |         ")
                Console.WriteLine("                  O  +        ")
                Console.WriteLine("                  ^ /         ")
                Console.WriteLine("              ___/|        ")
                Console.WriteLine("              |0| |           ")
                Console.WriteLine("               V  ^           ")
                Console.WriteLine("                 / \          ")
                Console.WriteLine("               _/   \_        ")
                Console.ReadKey()
                GoTo mainmenu
            Case "END GAME"
                End
            Case Else
                GoTo mainmenu
        End Select'main menu

story:
        Console.Clear()
        Console.WriteLine("Please state your character's name:")
        charname = Console.ReadLine
        Console.WriteLine()
        Console.WriteLine("Greetings " & charname & " do you wish to know the history of this terrible war? (yes/no)")
        backstory = Console.ReadLine
        backstory = UCase(backstory)
        Select Case backstory
            Case "YES"
                Console.WriteLine()
                Console.WriteLine("Welcome to the world of Frozon, this world is on the outskirts of the Quasar Nebular and is completely covered in a sheet of ice. Our human colony has been living here for well over 300 years in peace, mining oil and other precious material that is plenty on this planet. However 3 years ago a small mining company unearthed a huge underground cavern buried deep underground, hidden in this cavern was an army of sentient beings known as the Dvar-lou that had been deep in hibernation, as the planets top scientists investigated these creatures the heat from the scientist awoke the creatures from there slumber. The Dvar-lou feasted in the flesh of the people trapped there and surfaced in a quest to devour our entire colony, a fierce battle has since been going on against these creatures in an attempt to survive. We cannot evacuate the colony or call for assistance from the rest of the military as these creature have completely over run both the space port and the communications array and every day we grow weaker and they grow stronger. As one of the few surviving troopers left, it is your job to take back these crucial targets in order to save the entire colony. Good Luck!")
                GoTo startchoice
            Case "NO"
                Console.WriteLine()
                Console.WriteLine("Very well")
                GoTo startchoice
            Case Else
                Console.WriteLine()
                Console.WriteLine("I'll take that as a no then")
                GoTo startchoice
        End Select 'name choice and background history

startchoice:
        Dim firsttarget As String
        Console.WriteLine()
        Console.WriteLine(charname & ", please choose your first target. (the array/the port)")
        firsttarget = Console.ReadLine
        firsttarget = UCase(firsttarget)
        Select Case firsttarget
            Case "THE ARRAY"
                Console.WriteLine("Good decision, I agree that the array should be the priority, we will transport you there immediately")
                GoTo Array
            Case "THE PORT"
                Console.WriteLine("Good decision, I agree that the port should be the priority, we will transport you there immediately")
                GoTo port
            Case Else
                Console.WriteLine("Choose your target trooper!")
                GoTo startchoice
        End Select 'array or port choice

Array:
        Dim coridorone As String
        Console.Clear()
        Console.WriteLine("We have arrived just outside the array " & charname & ", you will need to fight your way to the top of the tower in order to bring communications back online")
        Console.WriteLine()
        Console.WriteLine("You walk towards the array and go through the first door, There is right or left corridor to take, which do you choose? (right/left)")
        coridorone = Console.ReadLine
        coridorone = UCase(coridorone)
        Select Case coridorone
            Case "RIGHT"
                GoTo coridoroneright
            Case "LEFT"
                GoTo coridoroneleft
            Case Else
                Console.WriteLine("As you could not decide which to take you decided to throw your knife to decide which way to go, however it bounced back and killed you!")
                Console.ReadKey()
                GoTo Array
        End Select 'ARRAY right or left choice 1

coridoroneright:
        Console.Clear()
        Console.WriteLine("When you go to the right you are attacked by a Dvar-lou Grunt, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        Dim battlechoice As String
        Dim damage As Integer
        health = 300
        grunthealth = 30
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    gruntdamage = Int(Rnd() * 10)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the grunt and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > grunthealth
                            Console.WriteLine("You kill the Grunt")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo kill1
                        Case Else
                            grunthealth = grunthealth - damage
                            Console.WriteLine("The Grunt now has " & grunthealth & " health left")
                            health = health - gruntdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp1
                                Case Else
                                    Console.WriteLine("The Grunt lashes back and does " & gruntdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until grunthealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo kill1
            Case "SHOOT"
                Do
                    Randomize()
                    gruntdamage = Int(Rnd() * 10)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the grunt doing " & damage & " damage")
                    Select Case damage
                        Case Is > grunthealth
                            Console.WriteLine("You kill the Grunt")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo kill1
                        Case Else
                            grunthealth = grunthealth - damage
                            Console.WriteLine("The Grunt now has " & grunthealth & " health left")
                            health = health - gruntdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp1
                                Case Else
                                    Console.WriteLine("The Grunt lashes back and does " & gruntdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until grunthealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo kill1
            Case Else
                Console.WriteLine("As you did nothing the Grunt Grabs you by the neck and swallows you whole!")
                Console.ReadKey()
                GoTo ckp1
        End Select 'ARRAY right corridoor, grunt attack

ckp1:
        health = 200
        Console.Clear()
        Dim choice As String
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo coridoroneright
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp1
        End Select 'ARRAY check point to right corridoor, grunt attack

kill1:
        Console.Clear()
        Console.WriteLine("On the other side of the door is a large room, in the corner of this room there is a Dvar-Lou Rouge, attacking some civilians. Do you fight the Rouge and save the civilians, or do you use them as a distraction to sneak past? (fight/sneak)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "FIGHT"
                Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
                healthpack = 50
                rougehealth = 60
                battlechoice = Console.ReadLine
                battlechoice = UCase(battlechoice)
                Select Case battlechoice
                    Case "MELEE"
                        Do
                            Randomize()
                            rougedamage = Int(Rnd() * 50)
                            Randomize()
                            damage = Int(Rnd() * 50)
                            Console.WriteLine("You run at the Rouge and stab it doing " & damage & " damage")
                            Select Case damage
                                Case Is > rougehealth
                                    Console.WriteLine("You kill the Rouge")
                                    Console.WriteLine("You are awarded with a Health pack for your bravery")
                                    health = health + 50
                                    Console.WriteLine("Your health is now at " & health)
                                    Console.WriteLine("Now that the civilians are safe you walk through the next door")
                                    Console.ReadKey()
                                    GoTo kill2
                                Case Else
                                    rougehealth = rougehealth - damage
                                    Console.WriteLine("The Rouge now has " & rougehealth & " health left")
                                    health = health - rougedamage
                                    Select Case health
                                        Case Is <= 0
                                            Console.WriteLine("You die!")
                                            Console.ReadKey()
                                            GoTo ckp3
                                        Case Else
                                            Console.WriteLine("The Rouge lashes back and does " & rougedamage & " damage, you now have " & health & " left")
                                    End Select
                            End Select
                        Loop Until rougehealth <= 0
                        Console.WriteLine("You are awarded with a Health pack for your bravery")
                        health = health + 50
                        Console.WriteLine("Your health is now at " & health)
                        Console.WriteLine("Now that the civilians are safe you walk through the next door")
                        Console.ReadKey()
                        GoTo kill2
                    Case "SHOOT"
                        Do
                            Randomize()
                            rougedamage = Int(Rnd() * 50)
                            Randomize()
                            damage = Int(Rnd() * 50)
                            Console.WriteLine("You shoot at the Rouge doing " & damage & " damage")
                            Select Case damage
                                Case Is > rougehealth
                                    Console.WriteLine("You kill the Rouge")
                                    Console.WriteLine("You are awarded with a Health pack for your bravery")
                                    health = health + 50
                                    Console.WriteLine("Your health is now at " & health)
                                    Console.WriteLine("Now that the civilians are safe you walk through the next door")
                                    Console.ReadKey()
                                    GoTo kill2
                                Case Else
                                    rougehealth = rougehealth - damage
                                    Console.WriteLine("The Rouge now has " & rougehealth & " health left")
                                    health = health - rougedamage
                                    Select Case health
                                        Case Is <= 0
                                            Console.WriteLine("You die!")
                                            Console.ReadKey()
                                            GoTo ckp3
                                        Case Else
                                            Console.WriteLine("The Rouge lashes back and does " & rougedamage & " damage, you now have " & health & " left")
                                    End Select
                            End Select
                        Loop Until rougehealth <= 0
                        Console.WriteLine("You are awarded with a Health pack for your bravery")
                        health = health + 50
                        Console.WriteLine("Your health is now at " & health)
                        Console.WriteLine("Now that the civilians are safe you walk through the next door")
                        Console.ReadKey()
                        GoTo kill2
                    Case Else
                        Console.WriteLine("As you did nothing the Rouge kills the civilians and uses one of the civilian's dead bodies to beat you to death!")
                        Console.ReadKey()
                        GoTo ckp3
                End Select
            Case "SNEAK"
                Console.WriteLine("You decide to sacrifice the civilians for the good of the cause and use there screaming to drown out your footsteps, to sneak through the next door.")
                Console.ReadKey()
                GoTo kill2
            Case Else
                Console.WriteLine("As you did nothing the Rouge kills the civilian's, spots you and uses one of the civilians dead bodies to beat you to death!")
                Console.ReadKey()
                GoTo ckp3
        End Select 'ARRAY rouge sneek or fight (from corridor right or corridor left choice)

coridoroneleft:
        Console.Clear()
        Console.WriteLine("When you go to the left you are attacked by a Dvar-lou Hench, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        health = 300
        henchhealth = 40
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    henchdamage = Int(Rnd() * 15)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the Hench and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > henchhealth
                            Console.WriteLine("You kill the Hench")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo kill1
                        Case Else
                            henchhealth = henchhealth - damage
                            Console.WriteLine("The Hench now has " & henchhealth & " health left")
                            health = health - henchdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp2
                                Case Else
                                    Console.WriteLine("The Hench lashes back and does " & henchdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until henchhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo kill1
            Case "SHOOT"
                Do
                    Randomize()
                    henchdamage = Int(Rnd() * 15)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the Hench doing " & damage & " damage")
                    Select Case damage
                        Case Is > henchhealth
                            Console.WriteLine("You kill the Hench")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo kill1
                        Case Else
                            henchhealth = henchhealth - damage
                            Console.WriteLine("The Hench now has " & henchhealth & " health left")
                            health = health - henchdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp2
                                Case Else
                                    Console.WriteLine("The Hench lashes back and does " & henchdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until henchhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo kill1
            Case Else
                Console.WriteLine("As you did nothing the Hench Grabs you by the head and tears your face off!")
                Console.ReadKey()
                GoTo ckp2
        End Select 'ARRAY left corridoor, hench attack

ckp2:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo coridoroneleft
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp2
        End Select 'ARRAY check point to left corridoor, hench attack

kill2:
        Console.Clear()
        Console.WriteLine("On the other side of the door there are two sets of stairs, which do you choose? (right/left)")
        coridorone = Console.ReadLine
        coridorone = UCase(coridorone)
        Select Case coridorone
            Case "RIGHT"
                GoTo starisright
            Case "LEFT"
                GoTo starisleft
            Case Else
                Console.WriteLine("As you could not decide which to take you decided to throw your knife to decide which way to go, however it bounced back and killed you!")
                Console.ReadKey()
                GoTo ckp7
        End Select  'ARRAY right or left choice 2

starisright:
        Console.Clear()
        Console.WriteLine("When you go to the right you are attacked by a Dvar-lou Warrior, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        warriorhealth = 70
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    warriordamage = Int(Rnd() * 60)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the warrior and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > warriorhealth
                            Console.WriteLine("You kill the warrior")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo kill3
                        Case Else
                            warriorhealth = warriorhealth - damage
                            Console.WriteLine("The warrior now has " & warriorhealth & " health left")
                            health = health - warriordamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp4
                                Case Else
                                    Console.WriteLine("The warrior lashes back and does " & warriordamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until warriorhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo kill3
            Case "SHOOT"
                Do
                    Randomize()
                    warriordamage = Int(Rnd() * 60)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the warrior doing " & damage & " damage")
                    Select Case damage
                        Case Is > warriorhealth
                            Console.WriteLine("You kill the warrior")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo kill3
                        Case Else
                            warriorhealth = warriorhealth - damage
                            Console.WriteLine("The warrior now has " & warriorhealth & " health left")
                            health = health - warriordamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp4
                                Case Else
                                    Console.WriteLine("The warrior lashes back and does " & warriordamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until warriorhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo kill3
            Case Else
                Console.WriteLine("As you did nothing the warrior grabs you and rips your limbs off!")
                Console.ReadKey()
                GoTo ckp4
        End Select 'ARRAY right stairs, warrior attack

ckp4:
        health = 200
        Console.Clear()
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo starisright
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp4
        End Select 'ARRAY check point to right stairs, warrior attack

kill3:
        Console.Clear()
        Console.WriteLine("Ahead of you is a lock door, in order for you to proceed you need to hack to code.")
        Dim numbrqan, codechoice As Integer
        Randomize()
        numbrqan = Int(Rnd() * 21)
        Console.WriteLine("Hack the code by working out the access number which is between 0 and 20. Code is:")
        Select Case numbrqan
            Case Is > 10
                Console.WriteLine(">10")
            Case Else
                Console.WriteLine("<10")
        End Select
        Do
            codechoice = Console.ReadLine
            Select Case codechoice
                Case Is > numbrqan
                    Console.WriteLine("INCORRECT CODE, Code is <")
                Case Is < numbrqan
                    Console.WriteLine("INCORRECT CODE, Code is >")
            End Select
        Loop Until codechoice = numbrqan
        Console.WriteLine("CODE ACCEPTED")
        Console.WriteLine("The door has unlocked and you walk through it.")
        Console.ReadKey()
        GoTo kill4 'ARRAY Code hack (from stairs right or stairs left choice)

starisleft:
        Console.Clear()
        Console.WriteLine("When you go to the left you are attacked by a Dvar-lou assassin, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        assasinhealth = 80
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    assasindamage = Int(Rnd() * 70)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the assassin and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > assasinhealth
                            Console.WriteLine("You kill the assassin")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo kill3
                        Case Else
                            assasinhealth = assasinhealth - damage
                            Console.WriteLine("The assassin now has " & assasinhealth & " health left")
                            health = health - assasindamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp6
                                Case Else
                                    Console.WriteLine("The assassin lashes back and does " & assasindamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until assasinhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo kill3
            Case "SHOOT"
                Do
                    Randomize()
                    assasindamage = Int(Rnd() * 70)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the assassin doing " & damage & " damage")
                    Select Case damage
                        Case Is > assasinhealth
                            Console.WriteLine("You kill the assassin")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo kill3
                        Case Else
                            assasinhealth = assasinhealth - damage
                            Console.WriteLine("The assassin now has " & assasinhealth & " health left")
                            health = health - assasindamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp6
                                Case Else
                                    Console.WriteLine("The assassin lashes back and does " & assasindamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until assasinhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo kill3
            Case Else
                Console.WriteLine("As you did nothing the assassin grabs you by the neck and pulls out your windpipe!")
                Console.ReadKey()
                GoTo ckp6
        End Select 'ARRAY left stairs, assasin attack

ckp5:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo kill4
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp5
        End Select 'ARRAY check point to leader battle

ckp3:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo kill1
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp3
        End Select 'ARRAY check point to rouge sneek or attack

kill4:
        Console.Clear()
        Console.WriteLine("When you go through the doors you realise that you have reached the top of the array, you head towards the controls when suddenly the Dvar-lou leader of the array jumps down from on top of the mast")
        leaderhealth = 120
        Do
            Randomize()
            leaderdamage = Int(Rnd() * 70)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 80)
                    Console.WriteLine("You run at the leader and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill the leader")
                            Console.ReadKey()
                            GoTo endarray
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("The leader now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp5
                                Case Else
                                    Console.WriteLine("The leader lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Select Case damage
                        Case Is = 30
                            damage = damage + 50
                            Console.WriteLine("You shoot at the leader and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at the leader doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill the leader")
                            Console.ReadKey()
                            GoTo endarray
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("The leader now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp5
                                Case Else
                                    Console.WriteLine("The leader lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing the leader picks you up and throws you of the top of the array!")
                    Console.ReadKey()
                    GoTo ckp5
            End Select
        Loop Until leaderhealth <= 0 'ARRAY leader battle

endarray:
        Console.Clear()
        completion = completion + 1
        Console.WriteLine("Congratulation on defeating the leader of the array, now we can contact the rest of the colonies for help!")
        Select Case completion
            Case Is = 1
                Console.WriteLine()
                Console.WriteLine("All we need you to do now is take back the port, we will transport you there immediately " & charname)
                Console.ReadKey()
                GoTo port
            Case Is = 2
                Console.ReadKey()
                GoTo endlevel
            Case Else
                Console.ReadKey()
                GoTo endarray
        End Select 'ARRAY end

ckp6:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo starisleft
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp6
        End Select 'ARRAY check point to left stairs, assasin attack

ckp7:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo kill2
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp7
        End Select 'ARRAY check point to right or left choice 2

port:
        Dim pathone As String
        Console.Clear()
        Console.WriteLine("We have arrived just outside the port " & charname & ", you will need to fight your way to the main control room to allow our ships to evacuate")
        Console.WriteLine()
        Console.WriteLine("You walk towards the port entrance and go through the first door, There is right or left path to take, which do you choose? (right/left)")
        pathone = Console.ReadLine
        pathone = UCase(pathone)
        Select Case pathone
            Case "RIGHT"
                GoTo pathoneright
            Case "LEFT"
                GoTo pathoneleft
            Case Else
                Console.WriteLine("As you could not decide which to take you decided to throw your knife to decide which way to go, however it bounced back and killed you!")
                Console.ReadKey()
                GoTo port
        End Select 'PORT right or left choice 1

pathoneleft:
        Console.Clear()
        Console.WriteLine("When you go to the left you are attacked by a Dvar-lou Grunt, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        health = 300
        grunthealth = 30
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    gruntdamage = Int(Rnd() * 10)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the grunt and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > grunthealth
                            Console.WriteLine("You kill the Grunt")
                            Console.WriteLine("You see the control building at the end of the path and go in it")
                            Console.ReadKey()
                            GoTo killA
                        Case Else
                            grunthealth = grunthealth - damage
                            Console.WriteLine("The Grunt now has " & grunthealth & " health left")
                            health = health - gruntdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpA
                                Case Else
                                    Console.WriteLine("The Grunt lashes back and does " & gruntdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until grunthealth <= 0
                Console.WriteLine("You see the control building at the end of the path and go in it")
                Console.ReadKey()
                GoTo killA
            Case "SHOOT"
                Do
                    Randomize()
                    gruntdamage = Int(Rnd() * 10)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the grunt doing " & damage & " damage")
                    Select Case damage
                        Case Is > grunthealth
                            Console.WriteLine("You kill the Grunt")
                            Console.WriteLine("You see the control building at the end of the path and go in it")
                            Console.ReadKey()
                            GoTo killA
                        Case Else
                            grunthealth = grunthealth - damage
                            Console.WriteLine("The Grunt now has " & grunthealth & " health left")
                            health = health - gruntdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpA
                                Case Else
                                    Console.WriteLine("The Grunt lashes back and does " & gruntdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until grunthealth <= 0
                Console.WriteLine("You see the control building at the end of the path and go through it")
                Console.ReadKey()
                GoTo killA
            Case Else
                Console.WriteLine("As you did nothing the Grunt Grabs you by the neck and swallows you whole!")
                Console.ReadKey()
                GoTo ckpA
        End Select 'PORT left path, grunt attack

ckpA:
        health = 200
        Console.Clear()
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo pathoneleft
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckpA
        End Select 'PORT check point to left path, grunt attack

killA:
        Console.Clear()
        Console.WriteLine("Inside the control building there are 3 doors, beside you are the entrances from both paths and ahead of you is a locked door. In order for you to proceed you need to hack to code.")
        Randomize()
        numbrqan = Int(Rnd() * 21)
        Console.WriteLine("Hack the code by working out the access number which is between 0 and 20. Code is:")
        Select Case numbrqan
            Case Is > 10
                Console.WriteLine(">10")
            Case Else
                Console.WriteLine("<10")
        End Select
        Do
            codechoice = Console.ReadLine
            Select Case codechoice
                Case Is > numbrqan
                    Console.WriteLine("INCORRECT CODE, Code is <")
                Case Is < numbrqan
                    Console.WriteLine("INCORRECT CODE, Code is >")
            End Select
        Loop Until codechoice = numbrqan
        Console.WriteLine("CODE ACCEPTED")
        Console.WriteLine("The door has unlocked and you walk through it.")
        Console.ReadKey()
        GoTo killB 'PORT code hack (from path right or path left choice)

pathoneright:
        Console.Clear()
        Console.WriteLine("When you go to the right you are attacked by a Dvar-lou Hench, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        health = 300
        henchhealth = 40
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    henchdamage = Int(Rnd() * 15)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the Hench and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > henchhealth
                            Console.WriteLine("You kill the Hench")
                            Console.WriteLine("You see the control building at the end of the path and go in it")
                            Console.ReadKey()
                            GoTo killA
                        Case Else
                            henchhealth = henchhealth - damage
                            Console.WriteLine("The Hench now has " & henchhealth & " health left")
                            health = health - henchdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpB
                                Case Else
                                    Console.WriteLine("The Hench lashes back and does " & henchdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until henchhealth <= 0
                Console.WriteLine("You see the control building at the end of the path and go in it")
                Console.ReadKey()
                GoTo killA
            Case "SHOOT"
                Do
                    Randomize()
                    henchdamage = Int(Rnd() * 15)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the Hench doing " & damage & " damage")
                    Select Case damage
                        Case Is > henchhealth
                            Console.WriteLine("You kill the Hench")
                            Console.WriteLine("You see a building at the end of the path and go in it")
                            Console.ReadKey()
                            GoTo killA
                        Case Else
                            henchhealth = henchhealth - damage
                            Console.WriteLine("The Hench now has " & henchhealth & " health left")
                            health = health - henchdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpB
                                Case Else
                                    Console.WriteLine("The Hench lashes back and does " & henchdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until henchhealth <= 0
                Console.WriteLine("You see the control building at the end of the path and go in it")
                Console.ReadKey()
                GoTo killA
            Case Else
                Console.WriteLine("As you did nothing the Hench Grabs you by the head and tears your face off!")
                Console.ReadKey()
                GoTo ckpB
        End Select 'PORT right path, hench attack

ckpB:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo pathoneright
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckpB
        End Select 'PORT check point to right path, hench attack

killB:
        Console.Clear()
        Console.WriteLine("On the other side of the door there are two sets of stairs, which do you choose? (right/left)")
        coridorone = Console.ReadLine
        coridorone = UCase(coridorone)
        Select Case coridorone
            Case "RIGHT"
                GoTo starisright2
            Case "LEFT"
                GoTo starisleft2
            Case Else
                Console.WriteLine("As you could not decide which to take you decided to throw a frag to decide which way to go, however it bounced back and killed you!")
                Console.ReadKey()
                GoTo ckpC
        End Select 'PORT right or left choice 2

ckpC:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo KillB
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckpC
        End Select 'PORT check point to right or left choice 2

starisleft2:
        Console.Clear()
        Console.WriteLine("When you go to the left you are attacked by a Dvar-lou Warrior, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        warriorhealth = 70
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    warriordamage = Int(Rnd() * 60)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the warrior and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > warriorhealth
                            Console.WriteLine("You kill the warrior")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo killC
                        Case Else
                            warriorhealth = warriorhealth - damage
                            Console.WriteLine("The warrior now has " & warriorhealth & " health left")
                            health = health - warriordamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpD
                                Case Else
                                    Console.WriteLine("The warrior lashes back and does " & warriordamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until warriorhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo killC
            Case "SHOOT"
                Do
                    Randomize()
                    warriordamage = Int(Rnd() * 60)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the warrior doing " & damage & " damage")
                    Select Case damage
                        Case Is > warriorhealth
                            Console.WriteLine("You kill the warrior")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo killC
                        Case Else
                            warriorhealth = warriorhealth - damage
                            Console.WriteLine("The warrior now has " & warriorhealth & " health left")
                            health = health - warriordamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpD
                                Case Else
                                    Console.WriteLine("The warrior lashes back and does " & warriordamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until warriorhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo killC
            Case Else
                Console.WriteLine("As you did nothing the warrior grabs you and rips your limbs off!")
                Console.ReadKey()
                GoTo ckpD
        End Select 'PORT left stairs, warrior attack

ckpD:
        health = 200
        Console.Clear()
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo starisleft2
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckpD
        End Select 'PORT check point to left stairs, warrior attack

killC:
        Console.Clear()
        Console.WriteLine("On the other side of the door is a large room with a window, in the corner of this room there is a Dvar-Lou Rouge, attacking some civilians, above its head is a cage and the rooms controls are to your right. Do you cage the Rouge and save the civilians, but cause yourself damage via electrocution from the damaged controls, or do you use the emergency infection command to torch the room killing both the rouge and the civilians? (trap/torch)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "TRAP"
                healthpack = 50
                Randomize()
                rougedamage = Int(Rnd() * 60)
                Console.WriteLine("You activate the trap button on the console causing " & rougedamage & " damage to yourself")
                health = health - rougedamage
                Select Case health
                    Case Is <= 0
                        Console.WriteLine("You die!")
                        GoTo ckpE
                    Case Else
                        Console.WriteLine("For your kindness you are awarded with a health pack and the civilians have survived")
                        health = health + healthpack
                        Console.WriteLine("You now have " & health & " health, as you go through the next door")
                        Console.ReadKey()
                        GoTo KillD
                End Select
            Case "TORCH"
                Console.WriteLine("You decide to sacrifice the civilians for the good of the cause and torch the room to kill the rouge, and walk through the next door.")
                Console.ReadKey()
                GoTo killD
            Case Else
                Console.WriteLine("As you did nothing the Rouge kills the civilian's, spots you and uses one of the controls in its room to torch yours!")
                GoTo ckpE
        End Select 'PORT rouge trap or torch

ckpE:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo killC
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckpE
        End Select 'PORT check point to rouge trap or torch

starisright2:
        Console.Clear()
        Console.WriteLine("When you go to the right you are attacked by a Dvar-lou assassin, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        assasinhealth = 80
        Randomize()
        assasindamage = Int(Rnd() * 70)
        Randomize()
        damage = Int(Rnd() * 50)
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Console.WriteLine("You run at the assassin and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > assasinhealth
                            Console.WriteLine("You kill the assassin")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo killC
                        Case Else
                            assasinhealth = assasinhealth - damage
                            Console.WriteLine("The assassin now has " & assasinhealth & " health left")
                            health = health - assasindamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpF
                                Case Else
                                    Console.WriteLine("The assassin lashes back and does " & assasindamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until assasinhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo killC
            Case "SHOOT"
                Do
                    Console.WriteLine("You shoot at the assassin doing " & damage & " damage")
                    Select Case damage
                        Case Is > assasinhealth
                            Console.WriteLine("You kill the assassin")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo killC
                        Case Else
                            assasinhealth = assasinhealth - damage
                            Console.WriteLine("The assassin now has " & assasinhealth & " health left")
                            health = health - assasindamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpF
                                Case Else
                                    Console.WriteLine("The assassin lashes back and does " & assasindamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until assasinhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo killC
            Case Else
                Console.WriteLine("As you did nothing the assassin grabs you by the neck and pulls out your windpipe!")
                Console.ReadKey()
                GoTo ckpF
        End Select 'PORT right stairs, assasin attack

ckpF:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo starisright2
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckpF
        End Select 'PORT check point to right stairs, assasin attack

killD:
        Console.Clear()
        Console.WriteLine("When you go through the doors you realise that you have reached the top of the port control building, you head towards the controls when suddenly the Dvar-lou leader of the port jumps down from on the ceiling")
        leaderhealth = 120
        Do
            Randomize()
            leaderdamage = Int(Rnd() * 70)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 80)
                    Console.WriteLine("You run at the leader and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill the leader")
                            Console.ReadKey()
                            GoTo endport
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("The leader now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpG
                                Case Else
                                    Console.WriteLine("The leader lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Select Case damage
                        Case Is = 30
                            damage = damage + 50
                            Console.WriteLine("You shoot at the leader and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at the leader doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill the leader")
                            Console.ReadKey()
                            GoTo endport
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("The leader now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpG
                                Case Else
                                    Console.WriteLine("The leader lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing the leader picks you up and throws you of the top of the array!")
                    Console.ReadKey()
                    GoTo ckpG
            End Select
        Loop Until leaderhealth <= 0 'PORT leader battle

ckpG:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo killD
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckpG
        End Select 'PORT check point to leader battle

endport:
        Console.Clear()
        completion = completion + 1
        Console.WriteLine("Congratulation on defeating the leader of the port, now we can evacuate the rest of the colonists for safety!")
        Select Case completion
            Case Is = 1
                Console.WriteLine()
                Console.WriteLine("All we need you to do now is take back the array, we will transport you there immediately " & charname)
                Console.ReadKey()
                GoTo Array
            Case Is = 2
                Console.ReadKey()
                GoTo endlevel
            Case Else
                Console.ReadKey()
                GoTo endport
        End Select 'PORT end

gmaeover:
        Dim playagaino As String
        Console.Clear()
        Console.WriteLine("GAME OVER")
        Console.WriteLine("Play again? (yes/no)")
        playagaino = Console.ReadLine
        playagaino = UCase(playagaino)
        Select Case playagaino
            Case "YES"
                GoTo story
            Case Else
                GoTo mainmenu
        End Select 'story game over

endlevel:
        Console.Clear()
        Console.WriteLine("Your last task " & charname & " is to defeat the head of all of the Dvar-Lou, Scrorpi. We have located the Dvar-Lou stronghold and we need you to infiltrate it and take him out. Here is some new armour that will increase your health, remember it is your job to finish this war once and for all, and this can be done by eliminating this VIP. Good luck!")
        Console.ReadKey()
        health = 400
        GoTo stronghold 'END LEVEL explained

stronghold:
        Console.Clear()
        Console.WriteLine("We have arrived just outside the stronghold " & charname & ", you will need to get to the main hall in order to get a chance at eliminating Scropri")
        Console.WriteLine()
        Console.WriteLine("You walk towards the strongholds doors, on the side you see that there is a form of a code required to open the door, you walk towards it.")
        Randomize()
        numbrqan = Int(Rnd() * 21)
        Console.WriteLine("Hack the code by working out the access number which is between 0 and 20. Code is:")
        Select Case numbrqan
            Case Is > 10
                Console.WriteLine(">10")
            Case Else
                Console.WriteLine("<10")
        End Select
        Do
            codechoice = Console.ReadLine
            Select Case codechoice
                Case Is > numbrqan
                    Console.WriteLine("INCORRECT CODE, Code is <")
                Case Is < numbrqan
                    Console.WriteLine("INCORRECT CODE, Code is >")
            End Select
        Loop Until codechoice = numbrqan
        Console.WriteLine("CODE ACCEPTED")
        Console.WriteLine("The door has unlocked and you walk through it.")
        Console.ReadKey()
        GoTo strongholdchoice 'END LEVEL code hack

strongholdchoice:
        Console.Clear()
        Console.WriteLine("On the otherside of the door, there is right or left corridor to take, which do you choose? (right/left)")
        coridorone = Console.ReadLine
        coridorone = UCase(coridorone)
        Select Case coridorone
            Case "RIGHT"
                GoTo strongholdright
            Case "LEFT"
                GoTo strongholdleft
            Case Else
                Console.WriteLine("As you could not decide which to take you decided to throw your knife to decide which way to go, however it bounced back and killed you!")
                Console.ReadKey()
                GoTo strongholdchoice
        End Select 'END LEVEL right or left choice

strongholdright:
        Console.Clear()
        Console.WriteLine("When you go to the right you are attacked by a Dvar-lou Warrior, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        warriorhealth = 70
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    warriordamage = Int(Rnd() * 60)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the warrior and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > warriorhealth
                            Console.WriteLine("You kill the warrior")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo killE1
                        Case Else
                            warriorhealth = warriorhealth - damage
                            Console.WriteLine("The warrior now has " & warriorhealth & " health left")
                            health = health - warriordamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp1A
                                Case Else
                                    Console.WriteLine("The warrior lashes back and does " & warriordamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until warriorhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo killE1
            Case "SHOOT"
                Do
                    Randomize()
                    warriordamage = Int(Rnd() * 60)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the warrior doing " & damage & " damage")
                    Select Case damage
                        Case Is > warriorhealth
                            Console.WriteLine("You kill the warrior")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo killE1
                        Case Else
                            warriorhealth = warriorhealth - damage
                            Console.WriteLine("The warrior now has " & warriorhealth & " health left")
                            health = health - warriordamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp1A
                                Case Else
                                    Console.WriteLine("The warrior lashes back and does " & warriordamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until warriorhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo killE1
            Case Else
                Console.WriteLine("As you did nothing the warrior grabs you and rips your limbs off!")
                Console.ReadKey()
                GoTo ckp1A
        End Select 'END LEVEL right corridor, warrior attack

ckp1A:
        health = 300
        Console.Clear()
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo strongholdright
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp1A
        End Select 'END LEVEL check point to right corridor, warrior attack

strongholdleft:
        Console.Clear()
        Console.WriteLine("When you go to the left you are attacked by a Dvar-lou assassin, do you fire your rifle, use your knife or do nothing? (melee/shoot)")
        assasinhealth = 80
        battlechoice = Console.ReadLine
        battlechoice = UCase(battlechoice)
        Select Case battlechoice
            Case "MELEE"
                Do
                    Randomize()
                    assasindamage = Int(Rnd() * 70)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the assassin and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > assasinhealth
                            Console.WriteLine("You kill the assassin")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo killE1
                        Case Else
                            assasinhealth = assasinhealth - damage
                            Console.WriteLine("The assassin now has " & assasinhealth & " health left")
                            health = health - assasindamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp1B
                                Case Else
                                    Console.WriteLine("The assassin lashes back and does " & assasindamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until assasinhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo killE1
            Case "SHOOT"
                Do
                    Randomize()
                    assasindamage = Int(Rnd() * 70)
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You shoot at the assassin doing " & damage & " damage")
                    Select Case damage
                        Case Is > assasinhealth
                            Console.WriteLine("You kill the assassin")
                            Console.WriteLine("You see a door at the end of the corridor and go through it")
                            Console.ReadKey()
                            GoTo killE1
                        Case Else
                            assasinhealth = assasinhealth - damage
                            Console.WriteLine("The assassin now has " & assasinhealth & " health left")
                            health = health - assasindamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckp1B
                                Case Else
                                    Console.WriteLine("The assassin lashes back and does " & assasindamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Loop Until assasinhealth <= 0
                Console.WriteLine("You see a door at the end of the corridor and go through it")
                Console.ReadKey()
                GoTo killE1
            Case Else
                Console.WriteLine("As you did nothing the assassin grabs you by the neck and pulls out your windpipe!")
                Console.ReadKey()
                GoTo ckp1B
        End Select 'END LEVEL left corridor, assasin attack

ckp1B:
        health = 300
        Console.Clear()
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo strongholdleft
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp1B
        End Select 'END LEVEL check point to left corridor, assasin attack

killE1:
        Console.Clear()
        Console.WriteLine("On the other side of the door is a large room, in the corner of this room there is a Dvar-Lou Rouge, attacking some unarmed troopers. Do you fight the Rouge and save the troopers, or do you use them as a distraction to sneak past? (fight/sneak)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "FIGHT"
                Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
                healthpack = 50
                rougehealth = 60
                battlechoice = Console.ReadLine
                battlechoice = UCase(battlechoice)
                Select Case battlechoice
                    Case "MELEE"
                        Do
                            Randomize()
                            rougedamage = Int(Rnd() * 50)
                            Randomize()
                            damage = Int(Rnd() * 50)
                            Console.WriteLine("You run at the Rouge and stab it doing " & damage & " damage")
                            Select Case damage
                                Case Is > rougehealth
                                    Console.WriteLine("You kill the Rouge")
                                    Console.WriteLine("You are awarded with a Health pack for your bravery")
                                    health = health + 50
                                    Console.WriteLine("Your health is now at " & health)
                                    Console.WriteLine("Now that the troopers are safe you walk through the next door")
                                    Console.ReadKey()
                                    GoTo endbattle
                                Case Else
                                    rougehealth = rougehealth - damage
                                    Console.WriteLine("The Rouge now has " & rougehealth & " health left")
                                    health = health - rougedamage
                                    Select Case health
                                        Case Is <= 0
                                            Console.WriteLine("You die!")
                                            Console.ReadKey()
                                            GoTo ckp1C
                                        Case Else
                                            Console.WriteLine("The Rouge lashes back and does " & rougedamage & " damage, you now have " & health & " left")
                                    End Select
                            End Select
                        Loop Until rougehealth <= 0
                        Console.WriteLine("You are awarded with a Health pack for your bravery")
                        health = health + 50
                        Console.WriteLine("Your health is now at " & health)
                        Console.WriteLine("Now that the troopers are safe you walk through the next door")
                        Console.ReadKey()
                        GoTo endbattle
                    Case "SHOOT"
                        Do
                            Randomize()
                            rougedamage = Int(Rnd() * 50)
                            Randomize()
                            damage = Int(Rnd() * 50)
                            Console.WriteLine("You shoot at the Rouge doing " & damage & " damage")
                            Select Case damage
                                Case Is > rougehealth
                                    Console.WriteLine("You kill the Rouge")
                                    Console.WriteLine("You are awarded with a Health pack for your bravery")
                                    health = health + 50
                                    Console.WriteLine("Your health is now at " & health)
                                    Console.WriteLine("Now that the troopers are safe you walk through the next door")
                                    Console.ReadKey()
                                    GoTo endbattle
                                Case Else
                                    rougehealth = rougehealth - damage
                                    Console.WriteLine("The Rouge now has " & rougehealth & " health left")
                                    health = health - rougedamage
                                    Select Case health
                                        Case Is <= 0
                                            Console.WriteLine("You die!")
                                            Console.ReadKey()
                                            GoTo ckp1C
                                        Case Else
                                            Console.WriteLine("The Rouge lashes back and does " & rougedamage & " damage, you now have " & health & " left")
                                    End Select
                            End Select
                        Loop Until rougehealth <= 0
                        Console.WriteLine("You are awarded with a Health pack for your bravery")
                        health = health + 50
                        Console.WriteLine("Your health is now at " & health)
                        Console.WriteLine("Now that the troopers are safe you walk through the next door")
                        Console.ReadKey()
                        GoTo endbattle
                    Case Else
                        Console.WriteLine("As you did nothing the Rouge kills the troopers and uses one of the troopers's dead bodies to beat you to death!")
                        Console.ReadKey()
                        GoTo ckp1C
                End Select
            Case "SNEAK"
                Console.WriteLine("You decide to sacrifice the troopers for the good of the cause and use there screaming to drown out your footsteps, to sneak through the next door.")
                Console.ReadKey()
                GoTo endbattle
            Case Else
                Console.WriteLine("As you did nothing the Rouge kills the troopers, spots you and uses one of the trooperss dead bodies to beat you to death!")
                Console.ReadKey()
                GoTo ckp1C
        End Select 'END LEVEL rouge sneek or fight (from corridor right or corridor left choice)

ckp1C:
        Console.Clear()
        health = 200
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo killE1
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckp1C
        End Select 'END LEVEL check point to rouge sneek or attack

endbattle:
        Console.Clear()
        Console.WriteLine("After entering the room you realise that it is a sub hall for the main stronghold, you hold your breath and run at the doors. As you rush into the strongholds main hall you realise that you have reached the end of your journey, and that you will either save the entire colony or die trying. The Dvar-lou head leader Scorprpi spots you, throws the remains of a captured trooper aside and raises his hand into a fighting position")
        leaderhealth = 200
        Do
            Randomize()
            leaderdamage = Int(Rnd() * 100)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 100)
                    Console.WriteLine("You run at Scrorpi and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill Scropri")
                            Console.ReadKey()
                            GoTo endstory
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("Scropri now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpS
                                Case Else
                                    Console.WriteLine("Scropri lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 80)
                    Select Case damage
                        Case Is = 56
                            damage = damage + 50
                            Console.WriteLine("You shoot at Scropri and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at Scropri doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill Scropri")
                            Console.ReadKey()
                            GoTo endstory
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("Scropri now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo ckpS
                                Case Else
                                    Console.WriteLine("Scropri lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing Scropri picks you up and throws you in to a pool of lava!")
                    Console.ReadKey()
                    GoTo ckpS
            End Select
        Loop Until leaderhealth <= 0 'END LEVEL scrorpi battle

ckpS:
        Console.Clear()
        health = 400
        Console.WriteLine("Go back to the last checkpoint (yes/no)")
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "YES"
                GoTo endbattle
            Case "NO"
                GoTo gmaeover
            Case Else
                GoTo ckpS
        End Select 'END LEVEL check point to scrorpi battle

endstory:
        Console.WriteLine("Now that Scrorpi has been defeated and the reinforcements have arrived, our victory is certain, trooper you have saved the entire colony!")
        Console.WriteLine(charname & " Well Done!")
        Console.WriteLine("            |         ")
        Console.WriteLine("            |         ")
        Console.WriteLine("         O  +        ")
        Console.WriteLine("         ^ /         ")
        Console.WriteLine("     ___/|           ")
        Console.WriteLine("     |0| |           ")
        Console.WriteLine("      V  ^           ")
        Console.WriteLine("        / \          ")
        Console.WriteLine("      _/   \_        ")
        Console.ReadKey()
        GoTo mainmenu 'END LEVEL end story explained

battlemode:
        Console.Clear()
        health = 300
        Console.WriteLine("Please choose the class of enemy you wish to fight: (Grunt/Hench/Rouge/Assassin/Warrior/Leader/Scrorpi/Back to main)")
        Console.WriteLine()
        Console.WriteLine("                                                 |         ")
        Console.WriteLine("                                                 |         ")
        Console.WriteLine("                                              O  +        ")
        Console.WriteLine("                                              ^ /         ")
        Console.WriteLine("                                          ___/|           ")
        Console.WriteLine("                                          |0| |           ")
        Console.WriteLine("                                           V  ^           ")
        Console.WriteLine("                                             / \          ")
        Console.WriteLine("                                           _/   \_        ")
        Console.WriteLine()
        choice = Console.ReadLine
        choice = UCase(choice)
        Select Case choice
            Case "GRUNT"
                GoTo grunt
            Case "HENCH"
                GoTo hench
            Case "ROUGE"
                GoTo rouge
            Case "ASSASSIN"
                GoTo assasin
            Case "WARRIOR"
                GoTo warrior
            Case "LEADER"
                GoTo leader
            Case "SCRORPI"
                GoTo scrorpi
            Case "BACK TO MAIN"
                GoTo mainmenu
            Case Else
                GoTo battlemode
        End Select 'BATTLE MODE menu

grunt:
        Console.Clear()
        Console.WriteLine("A Dvar-lou grunt appears, and raises its hand to fight")
        grunthealth = 30
        Do
            Randomize()
            gruntdamage = Int(Rnd() * 10)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 15)
                    Console.WriteLine("You run at the grunt and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > rougehealth
                            Console.WriteLine("You kill the grunt")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            grunthealth = grunthealth - damage
                            Console.WriteLine("The grunt now has " & grunthealth & " health left")
                            health = health - gruntdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The grunt lashes back and does " & gruntdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 10)
                    Select Case damage
                        Case Is = 6
                            damage = damage + 15
                            Console.WriteLine("You shoot at the grunt and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at the grunt doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > grunthealth
                            Console.WriteLine("You kill the grunt")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            grunthealth = grunthealth - damage
                            Console.WriteLine("The grunt now has " & grunthealth & " health left")
                            health = health - gruntdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The grunt lashes back and does " & gruntdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing the Grunt Grabs you by the neck and swallows you whole!")
                    Console.ReadKey()
                    GoTo battleoverlose
            End Select
        Loop Until grunthealth <= 0 'BATTLE MODE grunt attack

hench:
        Console.Clear()
        Console.WriteLine("A Dvar-lou hench appears, and raises its hand to fight")
        henchhealth = 40
        Do
            Randomize()
            henchdamage = Int(Rnd() * 15)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 20)
                    Console.WriteLine("You run at the hench and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > rougehealth
                            Console.WriteLine("You kill the hench")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            henchhealth = henchhealth - damage
                            Console.WriteLine("The hench now has " & henchhealth & " health left")
                            health = health - henchdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The hench lashes back and does " & henchdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 15)
                    Select Case damage
                        Case Is = 10
                            damage = damage + 10
                            Console.WriteLine("You shoot at the hench and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at the hench doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > rougehealth
                            Console.WriteLine("You kill the hench")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            henchhealth = henchhealth - damage
                            Console.WriteLine("The hench now has " & henchhealth & " health left")
                            health = health - henchdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The hench lashes back and does " & henchdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing the Hench Grabs you by the head and tears your face off!")
                    Console.ReadKey()
                    GoTo battleoverlose
            End Select
        Loop Until henchhealth <= 0 'BATTLE MODE hench attack

rouge:
        Console.Clear()
        Console.WriteLine("A Dvar-lou rouge appears, and raises its hand to fight")
        rougehealth = 60
        Do
            Randomize()
            rougedamage = Int(Rnd() * 50)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 30)
                    Console.WriteLine("You run at the rouge and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > rougehealth
                            Console.WriteLine("You kill the rouge")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            rougehealth = rougehealth - damage
                            Console.WriteLine("The rouge now has " & rougehealth & " health left")
                            health = health - rougedamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The rouge lashes back and does " & rougedamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 20)
                    Select Case damage
                        Case Is = 10
                            damage = damage + 20
                            Console.WriteLine("You shoot at the rouge and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at the rouge doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > rougehealth
                            Console.WriteLine("You kill the rouge")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            rougehealth = rougehealth - damage
                            Console.WriteLine("The rouge now has " & rougehealth & " health left")
                            health = health - rougedamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The rouge lashes back and does " & rougedamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing the Rouge kills you by using a club made of a dead civilian's dead body to beat you to death!")
                    Console.ReadKey()
                    GoTo battleoverlose
            End Select
        Loop Until rougehealth <= 0 'BATTLE MODE rouge attack

assasin:
        Console.Clear()
        Console.WriteLine("A Dvar-lou assassin appears, and raises its hand to fight")
        assasinhealth = 80
        Do
            Randomize()
            assasindamage = Int(Rnd() * 70)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 40)
                    Console.WriteLine("You run at the assassin and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > assasinhealth
                            Console.WriteLine("You kill the assassin")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            assasinhealth = assasinhealth - damage
                            Console.WriteLine("The assassin now has " & assasinhealth & " health left")
                            health = health - assasindamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The assassin lashes back and does " & assasindamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 20)
                    Select Case damage
                        Case Is = 15
                            damage = damage + 30
                            Console.WriteLine("You shoot at the assassin and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at the assassin doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > assasinhealth
                            Console.WriteLine("You kill the assassin")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            assasinhealth = assasinhealth - damage
                            Console.WriteLine("The assassin now has " & assasinhealth & " health left")
                            health = health - assasindamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The assassin lashes back and does " & assasindamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing the assassin grabs you by the neck and pulls out your windpipe!")
                    Console.ReadKey()
                    GoTo battleoverlose
            End Select
        Loop Until assasinhealth <= 0 'BATTLE MODE assasin attack

warrior:
        Console.Clear()
        Console.WriteLine("A Dvar-lou Warrior appears, and raises its hand to fight")
        warriorhealth = 70
        Do
            Randomize()
            warriordamage = Int(Rnd() * 60)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Console.WriteLine("You run at the warrior and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > warriorhealth
                            Console.WriteLine("You kill the warrior")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            warriorhealth = warriorhealth - damage
                            Console.WriteLine("The warrior now has " & warriorhealth & " health left")
                            health = health - warriordamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The warrior lashes back and does " & warriordamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 30)
                    Select Case damage
                        Case Is = 20
                            damage = damage + 30
                            Console.WriteLine("You shoot at the warrior and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at the warrior doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > warriorhealth
                            Console.WriteLine("You kill the warrior")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            warriorhealth = warriorhealth - damage
                            Console.WriteLine("The warrior now has " & warriorhealth & " health left")
                            health = health - warriordamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The Warrior lashes back and does " & warriordamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing the warrior grabs you and rips your limbs off!")
                    Console.ReadKey()
                    GoTo battleoverlose
            End Select
        Loop Until warriorhealth <= 0 'BATTLE MODE warrior attack

leader:
        Console.Clear()
        Console.WriteLine("The Dvar-lou leader jumps down from on the roof, and raises its hand to fight")
        leaderhealth = 120
        Do
            Randomize()
            leaderdamage = Int(Rnd() * 70)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 80)
                    Console.WriteLine("You run at the leader and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill the leader")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("The leader now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The leader lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 50)
                    Select Case damage
                        Case Is = 30
                            damage = damage + 50
                            Console.WriteLine("You shoot at the leader and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at the leader doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill the leader")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("The leader now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("The leader lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing the leader picks you up and throws you of the top of the array!")
                    Console.ReadKey()
                    GoTo battleoverlose
            End Select
        Loop Until leaderhealth <= 0 'BATTLE MODE leader attack

scrorpi:
        Console.Clear()
        Console.WriteLine("Scorprpi spots you, and raises his hand into a fighting position")
        health = 400
        leaderhealth = 200
        Do
            Randomize()
            leaderdamage = Int(Rnd() * 100)
            Console.WriteLine()
            Console.WriteLine("Do you fire your rifle, use your knife or do nothing? (melee/shoot)")
            battlechoice = Console.ReadLine
            battlechoice = UCase(battlechoice)
            Select Case battlechoice
                Case "MELEE"
                    Randomize()
                    damage = Int(Rnd() * 100)
                    Console.WriteLine("You run at Scropri and stab it doing " & damage & " damage")
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill Scropri")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("Scropri now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("Scropri lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case "SHOOT"
                    Randomize()
                    damage = Int(Rnd() * 80)
                    Select Case damage
                        Case Is = 56
                            damage = damage + 50
                            Console.WriteLine("You shoot at Scropri and do a critical hit causing " & damage & " damage")
                        Case Else
                            Console.WriteLine("You shoot at Scropri doing " & damage & " damage")
                    End Select
                    Select Case damage
                        Case Is > leaderhealth
                            Console.WriteLine("You kill Scropri")
                            Console.ReadKey()
                            GoTo battleoverwin
                        Case Else
                            leaderhealth = leaderhealth - damage
                            Console.WriteLine("Scropri now has " & leaderhealth & " health left")
                            health = health - leaderdamage
                            Select Case health
                                Case Is <= 0
                                    Console.WriteLine("You die!")
                                    Console.ReadKey()
                                    GoTo battleoverlose
                                Case Else
                                    Console.WriteLine("Scropri lashes back and does " & leaderdamage & " damage, you now have " & health & " left")
                            End Select
                    End Select
                Case Else
                    Console.WriteLine("As you did nothing Scropri picks you up and throws you in to a pool of lava!")
                    Console.ReadKey()
                    GoTo battleoverlose
            End Select
        Loop Until leaderhealth <= 0 'BATTLE MODE scrorpi attack

battleoverwin:
        Console.Clear()
        Console.WriteLine("YOU WIN")
        Console.WriteLine("Play again? (yes/no)")
        playagaino = Console.ReadLine
        playagaino = UCase(playagaino)
        Select Case playagaino
            Case "YES"
                GoTo battlemode
            Case Else
                GoTo mainmenu
        End Select 'BATTLE MODE win

battleoverlose:
        Console.Clear()
        Console.WriteLine("GAME OVER")
        Console.WriteLine("Play again? (yes/no)")
        playagaino = Console.ReadLine
        playagaino = UCase(playagaino)
        Select Case playagaino
            Case "YES"
                GoTo battlemode
            Case Else
                GoTo mainmenu
        End Select 'BATTLE MODE lose
    End Sub
End Module