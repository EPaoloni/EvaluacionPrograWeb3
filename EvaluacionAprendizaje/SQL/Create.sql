use evaluacion2
go

create table Competidor(
	id int Primary Key identity,
	nombre varchar(30) not null
)
go



create table PremiosCompetidor(
	id int Primary Key identity,
	cantidadPremios int not null,
	anio int not null,
	idCompetidor int Foreign Key References Competidor(id)
)
go