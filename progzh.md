# Pontozólap

## Cherry Picking	ZH

##### Tábla adatainak megjelenítése `ListBox`-ban. 

- `1x2p` Adatok  megjelenítése
- `2x2p` Ha az adatok tetszőleges módszerrel, pl. `TextBox`-on keresztül szűrhetőek. 
- `1x2p` Ha a tábla adatforrása saját osztály.  
Textboxokon keresztül lehet szűrni a listboxokban megjelnített adatokra.
![Screenshot 2024-12-16 162041](https://github.com/user-attachments/assets/887fa810-1e94-41e4-aa76-8add2f9badfe)


##### Tábla adatainak megjelenítése `DataGridView`-ban 

- `1x2p` Adatok  megjelenítése
- `1x2p` Ha a tábla adatforrása saját osztály.
  ![Screenshot 2024-12-16 162041](https://github.com/user-attachments/assets/1a23146e-ddc7-46b4-b808-23acbdbd009e)


##### Adatkötés `BindingSource` -on keresztül

- `1x2p` Működő  `BindingSource`
- `1x1p` Egy `BindingSource`-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint `TextBox`, `DateTimePicker`, `ComboBox` idegen kulcs értékének beállítására, stb.  
A BindingSource-ra rá van kötve a textbox is, a szűrés megvalósításának céljából.
![Screenshot 2024-12-16 162001](https://github.com/user-attachments/assets/11fa7576-f596-4c14-849b-63f346b74bfe)

![Screenshot 2024-12-16 162835](https://github.com/user-attachments/assets/b131372e-82c2-4a4a-890d-01599aa48490)


### ASP .NET 

- `1x2p`  `program.cs` beállítása `wwwroot` mappában tárolt statikus tartalmak megosztására
  ![Screenshot 2024-12-15 193904](https://github.com/user-attachments/assets/11ab2dda-9640-4e75-bc1e-31ba965a649b)


##### API végpontok

- `1x3p` Teljes SQL tábla adatainak szolgáltatása API végponton keresztül
  ![Screenshot 2024-12-15 224947](https://github.com/user-attachments/assets/0f79cb9a-6f58-489b-8caa-e234e8f0cb8e)

- `2x2p` SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül
  ![Screenshot 2024-12-15 225315](https://github.com/user-attachments/assets/29806ef1-ed72-4029-ba50-a84114d2452c)
  ![Screenshot 2024-12-15 233031](https://github.com/user-attachments/assets/80aedcf1-7efd-4f97-a169-9684c8a45fc8)

- `1x3p` SQL tábla egy választható rekordjának törlése
  ![Screenshot 2024-12-15 225423](https://github.com/user-attachments/assets/bd9cdab2-d98f-4f97-bb3e-742aaa2356dc)

- `1x5p` Új rekord felvétele `HttpPost` metóduson keresztül SQL táblába
  ![Screenshot 2024-12-15 231824](https://github.com/user-attachments/assets/1590bb33-6867-4f33-9587-714376e17473)

- `2x3p` Rekord módosítása `HttpPost` metóduson keresztül SQL táblába
  ![Screenshot 2024-12-15 231953](https://github.com/user-attachments/assets/dbc03c0a-d844-450c-a16c-0933d868b955)
  ![Screenshot 2024-12-15 232850](https://github.com/user-attachments/assets/494b1690-54ba-4984-8a76-8fe407c21e45)


A fentebb felsorolt funkciók működnek mind a Celebrity és a Movies táblán is.

### Hozott anyagok

##### Saját Adatbázis

- `2x1p` Az alkalmazásban használt táblánként pont: Awards, Celebrities
  ![Screenshot 2024-12-16 162041](https://github.com/user-attachments/assets/10bb8a33-4154-4642-8060-ebd1cc4a2d43)

- `1x1p` Az adatbázis tartalmaz Constraint-eket (min 2): Primary key, Not null
- `1x1p` Az adatbázis adatainak forrásmegjelölése értsd: miből készült és hogyan: Az adatbázis Azure Data Studio használatával készült, három adattáblát használva (Celebrities, Movies, Awards) az adattábla adataid ChatGPT-vel generáltam.
- `1x2p` Az adatbázis saját Azure SQL szerveren van
  ![Screenshot 2024-12-15 180551](https://github.com/user-attachments/assets/242cad48-2a1d-419f-8565-e6b1d5d10b93)


### Egyéb, extra

- `2x1p`  `Scaffold-DbContext` használata (ajándék)
  ![Screenshot 2024-12-15 224005](https://github.com/user-attachments/assets/1e206f8d-e346-4334-b384-2ad09b8c3ded)
  ![Screenshot 2024-12-15 233357](https://github.com/user-attachments/assets/6fbfb075-01e1-4aa2-827f-8b08a282c92f)

### Összesen: 46 pont
Igazából a projektem önmagában annyira nem hasznos és értelmes, de én nagyon igyekeztem minden kis tudásomat belerakni és a lehető legtöbbet kihozni belőle :)
Kellemes ünnepeket!
