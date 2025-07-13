# Huszonegy

## Leírás

A **Huszonegy** egy magyar kártyajáték implementáció C# Windows Forms alkalmazásként. A játék célja, hogy a kézben levő kártyák összege megközelítse vagy elérje a 21-et anélkül, hogy túllépné azt.

## Játékszabályok

### Alapszabályok
- A kártyák összege törekedjen a 21-re, de ne lépje túl
- 16 összegű eredménynél már meg lehet állni, vagy lehet kockáztatni új kártyával
- Az ellenfél egy számítógépes robot
- A nagyobb összegű lap tulajdonosa nyer
- Egyenlő eredmény esetén az osztó nyer
- Ha az első két kártya összege 22 (11+11), az a "huszonegy Joker" és nyerő kombináció

### Nehézségi szintek

#### 🟢 Könnyű
- A robot eredménye túllépheti a 22-őt
- Te vagy az osztó

#### 🟡 Közepes  
- A robot eredménye maximum 4 számmal lépheti túl a 22-őt
- Te vagy az osztó

#### 🔴 Nehéz
- A robot eredménye 16-22 között lehet
- A robot az osztó

## Telepítés és futtatás

### Követelmények
- .NET Framework 4.7.2 vagy újabb
- Windows operációs rendszer

### Alkalmazás
- Visual Studio 2017 vagy újabb (fejlesztéshez)
- A Release-ben található exe fájl (játékhoz)

## Projektszerkezet

```
huszonegy/
├── Form1.cs              # Fő játéklogika és UI kezelés
├── Form1.Designer.cs     # UI elemek definíciója
├── Program.cs            # Alkalmazás belépési pont
├── Properties/
│   ├── AssemblyInfo.cs   # Assembly metaadatok
│   ├── Resources.*       # Erőforrás fájlok
│   └── Settings.*        # Alkalmazás beállítások
├── App.config            # Konfigurációs fájl
├── packages.config       # NuGet csomagok
├── stylecop.json         # Kódstílus beállítások
└── huszonegy.csproj      # Projekt fájl
```

## Fejlesztési információk

### Használt technológiák
- **Nyelv**: C# (.NET Framework 4.7.2)
- **UI Framework**: Windows Forms
- **Kódstílus**: StyleCop Analyzers
- **Fejlesztői környezet**: Visual Studio

## Készítő

- **Matula Márton**  
- Első változat: 2022. május 25. *v.1.0.0.0*
- Legutóbbi változat: 2025. július 13. *v.1.0.0.5*
---

*Ez a README az 5. verzió (2025.07.13.) alapján készült.*
