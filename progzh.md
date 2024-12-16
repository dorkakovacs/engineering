# Pontozólap

## Cherry Picking	ZH

##### Tábla adatainak megjelenítése `ListBox`-ban. 

- `1x2p` Adatok  megjelenítése
- `2x2p` Ha az adatok tetszőleges módszerrel, pl. `TextBox`-on keresztül szűrhetőek. 
- `1x2p` Ha a tábla adatforrása saját osztály.  
Textboxokon keresztül lehet szűrni a listboxokban megjelnített adatokra.

##### Tábla adatainak megjelenítése `DataGridView`-ban 

- `1x2p` Adatok  megjelenítése
- `1x2p` Ha a tábla adatforrása saját osztály.  

##### Adatkötés `BindingSource` -on keresztül

- `1x2p` Működő  `BindingSource`
- `1x1p` Egy `BindingSource`-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint `TextBox`, `DateTimePicker`, `ComboBox` idegen kulcs értékének beállítására, stb.  
A BindingSourcre rá van kötve a textbox is, a szűrés megvalósításának céljából.


### ASP .NET 

- `1x2p`  `program.cs` beállítása `wwwroot` mappában tárolt statikus tartalmak megosztására

##### API végpontok

- `1x3p` Teljes SQL tábla adatainak szolgáltatása API végponton keresztül 
- `2x2p` SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül
- `1x3p` SQL tábla egy választható rekordjának törlése 
- `1x5p` Új rekord felvétele `HttpPost` metóduson keresztül SQL táblába 
- `2x3p` Rekord módosítása `HttpPost` metóduson keresztül SQL táblába
A fentebb felsorolt funkciók működnek mind a Celebrity és a Movies táblán is.

### Hozott anyagok

##### Saját Adatbázis

- `2x1p` Az alkalmazásban használt táblánként pont: Awards, Celebrities
- `1x1p` Az adatbázis tartalmaz Constraint-eket (min 2): Primary key, Not null
- `1x1p` Az adatbázis adatainak forrásmegjelölése értsd: miből készült és hogyan: Az adatbázis Azure Data Studio használatával készült, három adattáblát használva (Celebrities, Movies, Awards) az adattábla adataid ChatGPT-vel generáltam.
- `1x2p` Az adatbázis saját Azure SQL szerveren van

### Egyéb, extra

- `2x1p`  `Scaffold-DbContext` használata (ajándék)

### Összesen: 46 pont
Igazából a projektem önmagában annyira nem hasznos és értelmes, de én nagyon igyekeztem minden kis tudásomat belerakni és a lehető legtöbbet kihozni belőle :)
