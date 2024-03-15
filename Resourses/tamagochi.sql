-- create database tamagochi;
use tamagochi;

create table statuses(
	id int auto_increment primary key,
    name varchar(35)
);
insert into statuses(name) values ('в продаже'), ('продано'); commit;

create table properties(
id int auto_increment primary key,
    name varchar(35)
);
insert into properties(name) values ('голод'), ('жажда'), ('настроение'), ('сонливость'), ('красота'), ('здоровье'); commit;

create table items(
	id int auto_increment primary key,
    name varchar(35),
    property int,
    count int,
    price int,
    status int,
    in_inventory boolean,
    picture varchar(15),
    foreign key (property) references properties(id),
    foreign key (status) references statuses(id)
);
insert into items(name, property, count, price, status, in_inventory, picture) values
('аквариум с рыбкой', 3, 5, 15, 1, false, 'item1.png'),
('домик с когтеточкой', 3, 10, 25, 1, false, 'item2.png'),
('две таблетки', 6, 5, 25, 1, false, 'item3.png'),
('два домика с когтеточкой', 3, 20, 25, 1, false, 'item4.png'); commit;

-- update items set in_inventory = false, status = 1 where id = 1; commit;

select i.id, i.name, p.name as property, i.count, i.price, s.name as status,  i.in_inventory, i.picture from items as i join statuses as s on i.status = s.id join properties as p on i.property = p.id;