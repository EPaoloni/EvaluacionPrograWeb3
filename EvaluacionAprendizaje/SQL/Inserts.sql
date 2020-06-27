use evaluacion2
go

insert into Competidor(Nombre)
		values	('Pepe'),
				('Ana'),
				('Dario'),
				('Ezequiel');
go


insert into PremiosCompetidor(cantidadPremios, anio, idCompetidor)
		values	(3, 2018, 1),
				(1, 2019, 1),
				(4, 2018, 2),
				(1, 2020, 3);
go