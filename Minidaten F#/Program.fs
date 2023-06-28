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

let loop = 1
let saves = [""]
let updatedsave = [""]

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
    let updatedsave = [$"{Vorname} "; $"{Nachname} "; $"{Telefonnummer} "; $"{Straße} "; $"{Hausnummer} "; $"{PLZ} "; $"{Stadt} "; $"{Geburtsdatum} "; $"{Einkommen} "]
    let saves = updatedsave @ []
    List.iter (fun item -> printf "%s" item) saves

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


done

while not Break2 do 

printfn "Was möchten Sie filtern? (Adresse, Kontaktinformationen, Einkommen)"
let Auswahl = System.Console.ReadLine(); 

if Auswahl = "Adresse" then printfn $"
{Straße} {Hausnummer}, {PLZ} {Stadt}"
if Auswahl = "Kontaktinformationen" then printfn $"
{Vorname} {Nachname},
{Telefonnummer} 
{Geburtsdatum}"
if Auswahl = "Einkommen" then printfn $"
Ihr Einkommen ist: {Einkommen}"




printfn "
Nochmal? (Ja/Nein)"
let Break2answer = System.Console.ReadLine();
if Break2answer = "Ja" then 
    System.Console.Clear(); 
    printfn "Okay!"  
    

if Break2answer = "Nein" then  
    System.Console.Clear(); 
    printfn "Aufwiedersehen!" 
    Break2 <- true
done