# Salary
 
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
