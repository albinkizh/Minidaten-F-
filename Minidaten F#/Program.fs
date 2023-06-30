let mutable wholeshibreak = false
let mutable Break = false
let mutable Break2 = false
let mutable Vorname = ""
let mutable Nachname = ""
let mutable Straße = ""
let mutable Hausnummer = ""
let mutable Telefonnummer = ""
let mutable PLZ = ""
let mutable Stadt = ""
let mutable Geburtsdatum = ""
let mutable Einkommen = ""
let mutable AccountNum = 0
let mutable saves = []
let mutable updatedsave = []
let mutable Text = ""
let mutable Reader = ""




while not wholeshibreak do
    while not Break do

    let GridforUI (Text: string)  (Read: string)  =
        let gridform = $"------------------------------
|
|
| {Text}: {Read}
|
|
"
        gridform

    let Gridafterinput Text Input  =
            let gridform = $"------------------------------
|
|
| {Text}: {Input}
|
|
"
            gridform

    let Reader1 = System.Console.ReadLine();
    let Name = "Vorname"
    let result = GridforUI Name  Reader1
    printfn "%s" result
    Reader <- Reader + Reader1

    printf $"" // Nachnamen
    let Nachnameant = System.Console.ReadLine();
    Nachname <- Nachname + Nachnameant

    printf $"" // Straße
    let Straßeant = System.Console.ReadLine();
    Straße <- Straße + Straßeant

    printf $"" // Hausnummer
    let Hausnummerant = System.Console.ReadLine();
    Hausnummer <- Hausnummer + Hausnummerant

    printf $"" // Telefonnummer
    let Telefonnummerant = System.Console.ReadLine();
    Telefonnummer <- Telefonnummer + Telefonnummerant

    printf $"" // PLZ
    let PLZant = System.Console.ReadLine();
    PLZ <- PLZ + PLZant

    printf $"" // Stadt
    let Stadtant = System.Console.ReadLine();
    Stadt <- Stadt + Stadtant

    printf $"" // Geburtsdatum
    let Geburtsdatumant = System.Console.ReadLine();
    Geburtsdatum <- Geburtsdatum + Geburtsdatumant

    printf $"" // Einkommen
    let Einkommenant = System.Console.ReadLine();
    Einkommen <- Einkommen + Einkommenant



    printfn $"---------[{AccountNum}]---------
{Vorname} {Nachname}, {Telefonnummer}
{Straße} {Hausnummer}, {PLZ} {Stadt}
{Geburtsdatum}
{Einkommen}"

    printfn "
Stimmt alles?"
    let Frage = System.Console.ReadLine();

    if Frage = "Ja" || Frage = "ja" then

        System.Console.Clear();
        Break <- true
        printfn "Daten gespeichert!
        " 
        AccountNum <- AccountNum + 1
        let updatedsave2 = [$"---------[{AccountNum}]---------
{Vorname} {Nachname}, {Telefonnummer}
{Straße} {Hausnummer}, {PLZ} {Stadt}
{Geburtsdatum}
{Einkommen}"]
        updatedsave <- updatedsave2 @ []
        saves <- List.append saves updatedsave
        Break2 <- false
    else 
        System.Console.Clear();  
        printfn "Dann ein nochmal!
        "
        Vorname <- ""
        Nachname <- ""
        Telefonnummer <- ""
        Straße <- ""
        Hausnummer <- ""
        PLZ <- ""
        Stadt <- ""
        Geburtsdatum <- ""
        Einkommen <- ""
        Break2 <- false
    done

    while not Break2 do 


    printfn "
Nochmal? (Ja / Nein) | Datenbank anschauen? (B) | Account entfernen? (D) |Neuer Account? (A)"
    let Break2answer = System.Console.ReadLine();
    if Break2answer = "Ja" then 
        System.Console.Clear(); 
        printfn "Okay!"  
    

    if Break2answer = "Nein" then  
        System.Console.Clear(); 
        printfn "Aufwiedersehen!" 
        Break2 <- true 

    if Break2answer = "B" then
        System.Console.Clear();
        List.iter (fun item -> printfn"%s" item) saves
        printfn "
Fertig?(Ja)"
        let anstocontinue = System.Console.ReadLine();
        if anstocontinue = "Ja" then
                System.Console.Clear();
                printfn"Les go"
    
    if Break2answer = "D" then

        System.Console.Clear();
        List.iter (fun item -> printfn"%s" item) saves
        printfn"Welchen Account wollen Sie löschen? (1,2,3...)"
        let AccountDeleteAnswer = System.Console.ReadLine();
        let Accounddelconverted = AccountDeleteAnswer |> int32
        let AccountDeleteAnswer2 = Accounddelconverted - 1

        if AccountDeleteAnswer = AccountDeleteAnswer then
            let updatedsaves =  (List.take AccountDeleteAnswer2 saves) @ (List.skip Accounddelconverted saves)
            saves <- updatedsaves @ []
            System.Console.Clear();
            List.iter (printfn "%s") saves
            AccountNum <- AccountNum - 1

    if Break2answer = "A" then
        System.Console.Clear();
        updatedsave <- []
        Vorname <- ""
        Nachname <- ""
        Telefonnummer <- ""
        Straße <- ""
        Hausnummer <- ""
        PLZ <- ""
        Stadt <- ""
        Geburtsdatum <- ""
        Einkommen <- ""
        Break2 <- true
        Break <- false


    (*'if Break2answer = "F" then
        System.Console.Clear();
        printfn"Was möchten Sie filtern? (Bundesländer [B] | Namen [N] | Alter [A])"
        let Filteranswer = System.Console.ReadLine();

        if Filteranswer = "B" then 
            System.Console.Clear();
            printfn"Welches Bundesland möchten Sie wählen? 
( [1] Wien, [2] Niederösterreich, [3] Oberösterreich, Salzburg, Steiermark, Burgenland, Kärnten, Tirol, Vorarlberg)"
            let indexpointer = System.Console.ReadLine();
            let bundeslandshower = List.item indexpointer saves

            let extractHausnummer (str: string) =
                let startIndex = str.IndexOf("Hausnummer") + "Hausnummer".Length
                let endIndex = str.IndexOf(",", startIndex)
                if startIndex >= 0 && endIndex >= 0 then
                    str.Substring(startIndex, endIndex - startIndex).Trim()
                else
                    ""
            let hausnummer = saves
                            |> List.map extractHausnummer
                            |> List.head

            // Print the extracted "Hausnummer" value
            printfn "%s" hausnummer*)




    done
done