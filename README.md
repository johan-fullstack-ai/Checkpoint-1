# Checkpoint-1

Detta är projektet för Checkpoint-1. Det är nivå 3 av uppgiften. 
Här testar jag Git, GitHub och Visual Studio. Har tilldelats grupp 3 - green, men vi har ännu inte hunnit koda något tillsammans.

## Innehåll
- Projektfiler
- .gitignore
- .gitattributes
- README.md

## Syfte
Att öva Git och GitHub samt göra miniprojekt 1.

## Hur man använder programmet
Programmet låter dig skriva in produktnamn som kontrolleras enligt bestämda regler. Endast giltiga produkter sparas. Avsluta genom att skriva `exit` (valfri kombination av stora/små bokstäver och mellanslag).

Regler för giltiga produktnamn
Ett produktnamn måste:
- ha en vänsterdel med endast bokstäver  
- innehålla ett bindestreck  
- ha en sifferdel mellan **200–500**

**Giltiga exempel:** `CE-400`, `XX-480`, `LABAN-231`  
**Ogiltiga exempel:** `CE400`, `XX3-480`, `LABAN-100`

### Felmeddelanden
Programmet visar fel om:
- vänstra delen inte är bokstäver  
- högra delen inte är ett heltal  
- talet inte är 200–500  
- inmatningen är tom

### Avslut och resultat
Skriv `exit` för att avsluta. Programmet accepterar alla varianter:
- `exit`
- `EXIT`
- `eXiT`
- `  exit   `

Programmet visar sedan alla **giltiga** produkter i **alfabetisk ordning**

## Credits
Johan Granvinge
