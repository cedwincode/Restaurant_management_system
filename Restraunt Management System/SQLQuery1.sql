SELECT * FROM Bill;
UPDATE Bill  SET Id =1 WHERE Id = null;
INSERT INTO Bill ([Food type],[Food qty],[Drink type],[Drink qty],[Discount],[Total],[Datetime],[B_id]) VALUES('kaju',5,'soda',2,0,7,'2023-03-29',1);

DELETE FROM Bill WHERE ID BETWEEN 1 AND 4;
SELECT MAX(Id) FROM Bill;

