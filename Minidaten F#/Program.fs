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

while not wholeshibreak do
    while not Break do

    printfn "Vorname:"
    let Vornameant = System.Console.ReadLine();
    Vorname <- Vorname + Vornameant

    printfn "
Nachname:"
    let Nachnameant = System.Console.ReadLine();
    Nachname <- Nachname + Nachnameant

    printfn "
Straße:"
    let Straßeant = System.Console.ReadLine();
    Straße <- Straße + Straßeant

    printfn "
Hausnummer:"
    let Hausnummerant = System.Console.ReadLine();
    Hausnummer <- Hausnummer + Hausnummerant

    printfn "
Telefonnummer:"
    let Telefonnummerant = System.Console.ReadLine();
    Telefonnummer <- Telefonnummer + Telefonnummerant

    printfn "
PLZ:"
    let PLZant = System.Console.ReadLine();
    PLZ <- PLZ + PLZant

    printfn "
Stadt:"
    let Stadtant = System.Console.ReadLine();
    Stadt <- Stadt + Stadtant

    printfn "
Geburtsdatum:"
    let Geburtsdatumant = System.Console.ReadLine();
    Geburtsdatum <- Geburtsdatum + Geburtsdatumant

    printfn "
Einkommen:"
    let Einkommenant = System.Console.ReadLine();
    Einkommen <- Einkommen + Einkommenant
    System.Console.Clear();

    printfn $"
{Vorname} {Nachname}, {Telefonnummer}"
    printfn $"{Straße} {Hausnummer}, {PLZ} {Stadt}"
    printfn $"{Geburtsdatum}"
    printfn $"Einkommen: {Einkommen} Euro"

    printfn "
Stimmt alles?"
    let Frage = System.Console.ReadLine();

    if Frage = "Ja" then

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
        updatedsave2 = []
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
Nochmal? (Ja oder Enter / Nein) | Datenbank anschauen? (B) | Account entfernen? (D) |Neuer Account? (A)"
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
        if AccountDeleteAnswer = "1" then
            let updatedsaves = List.tail saves
            List.iter (printfn "%s") updatedsaves
            saves <- updatedsaves @ []

            

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
    done
done