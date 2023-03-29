# 4. gyakorlat

hozzunk létre command line-ból c# projekteket

releváns parancsok:
- [sln](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln) 
- [new](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new)

```powershell
dotnet new sln --output Cactus
cd Cactus
dotnet new console -n Cactus
dotnet sln .\Cactus.sln add .\Cactus\Cactus.csproj
```

## Programnyelvi kompetenciák
- break vagy return
- szöveges állományból olvasás
- szöveges állományba írás
  

## Feladatok
1. Kaktuszos feladat
   1. Van-e piros virágú kaktusz?  
   2. Válogassuk ki a piros virágú, és külön a mexikói kaktuszoknak a neveit. 
   3. Melyik a legnagyobb piros virágú kaktusznak a neve?
2. Minden szám páros-e egy input fájlban

A feladatokhoz a TextFileReader osztályt fogjuk használni.
Ha a program.cs-ben írjuk a megoldásunkat **statikus** függvényekkel dolgozzunk