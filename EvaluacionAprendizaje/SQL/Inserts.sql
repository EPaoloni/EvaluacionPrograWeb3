use evaluacion2
go

insert into Competidor(id, Nombre)
		values	(1, 'Pepe'),
				(2, 'Ana'),
				(3, 'Dario'),
				(4, 'Ezequiel');
go


insert into PremiosCompetidor(id, cantidadPremios, anio, idCompetidor)
		values	(1, 3, 2018, 1),
				(2, 1, 2019, 1),
				(3, 4, 2018, 2),
				(4, 1, 2020, 3);
go