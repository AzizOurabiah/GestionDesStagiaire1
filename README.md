# GestionDesStagiaire1
il faut exécuter le Scripte de SQL sur SQLServeur pour que l'application fonction avec la base de données 

#Voilà le scripte
create database TDI
go
use TDI
go
create table STAGIAIRE1
(Mat int,
Nom nvarchar(50),
Prenom nvarchar(50),
Moyenne float,
Age int
)
go
select * from STAGIAIRE1

insert into STAGIAIRE1 values(1, 'Hajjar', 'Hind', 18,25)
insert into STAGIAIRE1 values(2, 'El-ouafi', 'Mouad', 18,25)
insert into STAGIAIRE1 values(3, 'Idrissi', 'Dalal', 18,25)
insert into STAGIAIRE1 values(4, 'Chadir', 'Imane', 18,25)
