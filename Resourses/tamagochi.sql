-- create database tamagochi;
use tamagochi;

/*
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
*/

drop table items;

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


#delete from items where id > 0; commit;

insert into items(name, property, count, price, status, in_inventory, picture) values
('аквариум с рыбкой', 3, 5, 15, 1, false, 'item 1.png'),
('домик с когтеточкой', 3, 10, 25, 1, false, 'item 2.png'),
('две таблетки', 6, 5, 25, 1, false, 'item 3.png'),
('два домика с когтеточкой', 3, 20, 25, 1, false, 'item 4.png'),
('два кошачьих корма', 1, 15, 15, 1, false, 'item 5.png'),
('кошачий корм', 1, 10, 10, 1, false, 'item 6.png'),
('две рыбных консервы', 1, 15, 25, 1, false, 'item 7.png'),
('заводная мышка', 3, 15, 25, 1, false, 'item 8.png'),
('клубок', 3, 10, 15, 1, false, 'item 9.png'),
('солнечные очки', 5, 25, 55, 1, false, 'item 10.png'),
('переноска', 4, 15, 25, 1, false, 'item 11.png'),
('значок', 5, 15, 25, 1, false, 'item 12.png'),
('две баночки таблеток', 6, 25, 45, 1, false, 'item 13.png'),
('две игрушечных мышки', 3, 25, 35, 1, false, 'item 14.png')
;commit;

# update items set in_inventory = false, status = 1 where id = 1; commit;

select i.id, i.name, p.name as property, i.count, i.price, s.name as status,  i.in_inventory, i.picture from items as i join statuses as s on i.status = s.id join properties as p on i.property = p.id;