--Script Affectation BDD
/* 
UPDATE parties set DonjonLancerId=0;
UPDATE characters set Ilvl=0;
UPDATE donjons set Temps="00:02:00";

UPDATE characters set Party_Id=1 where Id in (1,2,3,4,5);
UPDATE characters set Party_Id=2 where Id in (6,7,8,9,10);
UPDATE characters set Party_Id=3 where Id in (11,12,13,14,15);

UPDATE donjons set IlvlLuck=160 where Id=1;
UPDATE donjons set IlvlLuck=165 where Id=2;
UPDATE donjons set IlvlLuck=170 where Id=3;
UPDATE donjons set IlvlLuck=180 where Id=4;
UPDATE donjons set IlvlLuck=190 where Id=5;

UPDATE bosses set Donjon_Id=1 where Id in (1,2,3,4,5);
UPDATE bosses set Donjon_Id=2 where Id in (6,7,8,9,10);
UPDATE bosses set Donjon_Id=3 where Id in (11,12,13,14,15);
UPDATE bosses set Donjon_Id=4 where Id in (16,17,18,19,20);
UPDATE bosses set Donjon_Id=5 where Id in (20,21,22,23,24);

UPDATE items set Boss_Id=1,Ilvl=155 where Id in (1,2,3,4,5);
UPDATE items set Boss_Id=2,Ilvl=160 where Id in (6,7,8,9,10);
UPDATE items set Boss_Id=3,Ilvl=165 where Id in (11,12,13,14,15);
UPDATE items set Boss_Id=4,Ilvl=170 where Id in (16,17,18,19,20);
UPDATE items set Boss_Id=5,Ilvl=175 where Id in (20,21,22,23,24);


*/