create table cliente(
	id int primary key identity,
	nome varchar(50),
);

create table telefone(
	id int,
	ddd varchar(3),
	telefone varchar (9),
	foreign key(id) references cliente(id),
);