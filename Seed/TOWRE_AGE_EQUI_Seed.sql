DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM TowreAgeEquis)
BEGIN 

	INSERT INTO TowreAgeEquis(Age_equivalent,Sight_Word_Efficiency_raw_score_FROM,Sight_Word_Efficiency_raw_score_TO,Phonemic_Decoding_Efficiency_raw_score_FROM,Phonemic_Decoding_Efficiency_raw_score_TO,
			ID,CreatedUser,ModifiedUser,CreatedDate,ModifiedDate)  
	VALUES 
	('6-0',0,14,0,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('6-0',14,19,5,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('6-3',20,25,8,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('6-6',26,28,11,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('6-9',29,33,13,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('7-0',34,37,15,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('7-3',38,40,17,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('7-6',41,47,19,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('7-9',48,51,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('8-0',52,54,25,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('8-3',55,57,27,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('8-6',58,60,29,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('8-9',61,64,31,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('9-0',65,66,32,32,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('9-3',67,67,33,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('9-6',68,68,34,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('9-9',69,69,35,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('10-0',NULL,NULL,36,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('10-3',70,70,37,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('10-6',71,71,38,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('10-9',72,72,39,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('11-0',73,73,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('11-3',74,74,40,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('11-6',75,75,41,41,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('11-9',76,76,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('12-0',NULL,NULL,42,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('12-3',77,77,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('12-6',78,78,43,43,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('12-9',NULL,NULL,44,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('13-0',79,79,45,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('13-6',80,80,46,46,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('13-9',81,81,47,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('14-0',82,82,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('14-6',83,83,48,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('15-0',84,84,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('15-6',85,85,49,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('15-9',86,86,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('16-3',87,87,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('16-6',88,88,50,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('17-0',89,89,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('17-6',90,90,51,52,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('17-9',NULL,NULL,53,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	('17',90,0,54,0,NEWID(),@ID,@ID,GETDATE(),GETDATE());

END;