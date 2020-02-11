USE `is-proj` ;

insert into inspector values (null, 'Marko', 'Markovic', 'Poreska', 0, 1, 1, 'marko', 'salt', '2908D2C28DFC047741FC590A026FFADE237AB2BA7E1266F010FE49BDE548B5987A534A86655A0D17F336588E540CD66F67234B152BBB645B4BB85758A1325D64', 1);
insert into inspector values (null, 'Ivan', 'Ivanovic', 'Poreska', 0, 1, 0, 'ivan', 'salt', '2908D2C28DFC047741FC590A026FFADE237AB2BA7E1266F010FE49BDE548B5987A534A86655A0D17F336588E540CD66F67234B152BBB645B4BB85758A1325D64', 1);
insert into inspector values (null, 'Petar', 'Petrovic', 'Poreska', 1, 1, 0, 'petar', 'salt', '2908D2C28DFC047741FC590A026FFADE237AB2BA7E1266F010FE49BDE548B5987A534A86655A0D17F336588E540CD66F67234B152BBB645B4BB85758A1325D64', 1);

insert into admin values (null, 'admin', 'salt', '2908D2C28DFC047741FC590A026FFADE237AB2BA7E1266F010FE49BDE548B5987A534A86655A0D17F336588E540CD66F67234B152BBB645B4BB85758A1325D64', 1);

insert into company values (null, '111111', 'mTel', 'Kralja Alfonsa XIII 15', 'Kum Mile', 'Mile Kitic', null, null, 1);
insert into company values (null, '222222', 'Toplana', 'Kralja Petra I K.', 'Nikola Tesla', 'Tomas Edison', null, null, 1);
insert into company values (null, '333333', 'Vodovod', 'Patre 6', 'Arhimed', 'Dekart', null, null, 1);

insert into vehicle values (1, '111-k-111', 6, 001, 1, 'Golf 6');
insert into vehicle values (2, '222-k-222', 2, 002, 1, 'Pezo 307');
insert into vehicle values (3, '3-k-3', 4, 003, 1, 'Skoda');

insert into control values (null, 1, '2020-1-15', '2020-1-15', 1, 1, 'Nema neregularnosti.', 0, 1);
insert into control values (null, 1, '2020-1-15', null, 0, 1, null, null, 1);
insert into control values (null, 2, '2020-1-15', null, 0, 1, null, null, 1);

insert into control values (null, 2, '2020-1-15', '2020-1-15', 1, 1, 'Nema vecih neregularnosti.', 0, 1);
insert into control values (null, 1, '2020-1-15', '2020-1-15', 1, 1, 'Nema nikakvih neregularnosti.', 0, 1);

insert into control_has_inspector values(1, 1);
insert into control_has_inspector values(1, 2);
insert into control_has_inspector values(1, 3);
insert into control_has_inspector values(2, 3);
insert into control_has_inspector values(3, 1);

insert into vehicle_responsibility values (null, 1, 1, 1, '2020.1.15.');
insert into vehicle_responsibility values (null, 2, 2, 1, '2020.1.15.');
insert into vehicle_responsibility values (null, 3, 3, 2, '2020.1.15.');

insert into department values (null, 'Poreska uprava');

insert into joint_control values (1, 1);
insert into joint_control values (2, 1);
insert into joint_control values (3, 1);





