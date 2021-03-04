# Salary
Aplikacja webowa napisana w ASP.NET Core służąca do obliczenia wypłat pracowników na podstawie z góry określonego budżetu.
 
##Instalacja projektu:
Repozytorium:
```
https://github.com/uranowski-wsei/Salary.git
```
Instalacja bazy danych:
```
sqllocaldb create SalaryDB 
sqllocaldb start SalaryDB
```
Aktualizacja bazy danych:
```
dotnet tool install --global dotnet-ef
dotnet ef migrations add Initial
dotnet ef database update
```
###Autor
Antoni Uranowski
Nr. albumu: 11859
