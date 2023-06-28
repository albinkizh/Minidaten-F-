let loop = 2

while (1 < loop) do

printfn "Vorname:"
let Vorname = System.Console.ReadLine();

printfn "Nachname:"
let Nachname = System.Console.ReadLine();

printfn "Straße:"
let Straße = System.Console.ReadLine();

printfn "Hausnummer:"
let Hausnummer = System.Console.ReadLine();

printfn "Telefonnummer:"
let Telefonnummer = System.Console.ReadLine();

printfn "PLZ:"
let PLZ = System.Console.ReadLine();

printfn "Stadt:"
let Stadt = System.Console.ReadLine();

printfn "Geburtsdatum:"
let Geburtsdatum = System.Console.ReadLine();

printfn "Einkommen:"
let Einkommen = System.Console.ReadLine();

let Name = printfn $"
{Vorname} {Nachname}"
let Addresse = printfn $"{Straße} {Hausnummer}, {PLZ} {Stadt}"
let Geburtstag = printfn $"{Geburtsdatum}"
let Lohn = printfn $"Einkommen: {Einkommen} Euro"

printfn "Stimmt alles?"
let Frage = System.Console.ReadLine();

if Frage = "Ja" then
    System.Console.Clear();
    printfn "Daten gespeichert!
    "
    

else 
    System.Console.Clear();
    printfn "Dann ein nochmal!
    " 



















loop = loop + 1


