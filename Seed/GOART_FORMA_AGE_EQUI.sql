DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM GoartFormAAgeEquis)
BEGIN 

	INSERT INTO GoartFormAAgeEquis(Age_equiv,Rate_FROM,Rate_TO,Accuracy_FROM,Accuracy_TO,Fluency_FROM,Fluency_TO,Comprehension_FROM,Comprehension_TO,
	ID,CreatedUser,ModifiedUser,CreatedDate,ModifiedDate)
	VALUES 
	(5.9,0,5,0,0,0,12,0,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,5,6,5,7,12,15,8,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6.3,7,8,8,9,16,20,11,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6.6,9,0,10,11,21,24,12,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6.9,11,12,12,13,25,28,14,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,13,14,14,15,29,33,16,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7.3,15,16,16,17,34,36,18,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7.6,17,18,18,19,37,39,19,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7.9,19,20,20,21,40,42,21,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,21,21,NULL,NULL,43,45,22,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8.3,22,23,23,24,46,48,24,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8.6,24,25,25,25,49,51,25,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8.9,26,26,26,26,52,54,27,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,27,27,27,27,55,56,28,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9.3,28,28,28,29,57,59,29,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9.6,29,29,30,30,60,60,30,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9.9,30,30,31,31,61,63,31,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,31,31,32,32,64,64,32,32,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10.3,32,32,33,33,65,0.66,33,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10.6,33,33,34,34,67,67,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10.9,34,34,NULL,NULL,68,9,34,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,35,35,35,35,70,71,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11.3,36,36,NULL,NULL,72,73,35,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11.6,37,37,36,36,74,74,36,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11.19,38,38,37,37,75,76,37,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,39,39,NULL,NULL,77,77,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12.3,40,40,38,38,78,79,38,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12.6,41,41,39,39,80,80,39,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12.9,42,42,40,40,81,82,40,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,43,43,41,41,83,85,41,41,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13.3,44,44,42,42,86,86,42,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13.6,45,45,NULL,NULL,87,87,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13.9,46,46,43,43,88,89,43,43,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,NULL,NULL,44,44,90,92,44,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14.3,NULL,NULL,45,45,93,93,45,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14.6,47,47,46,46,94,94,46,46,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14.9,NULL,NULL,NULL,NULL,95,95,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,48,48,NULL,NULL,96,96,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15.3,49,49,NULL,NULL,97,97,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15.6,50,50,47,47,98,98,47,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15.9,NULL,NULL,NULL,NULL,99,99,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,51,51,48,48,100,100,48,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16.3,NULL,NULL,NULL,NULL,101,101,49,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16.6,52,52,49,49,102,102,50,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16.9,NULL,NULL,50,50,103,103,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,53,53,51,51,104,104,51,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17.3,54,54,52,52,105,106,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17.6,55,55,53,53,107,108,52,52,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17.9,NULL,NULL,54,54,109,109,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,56,56,55,55,110,110,53,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19.0,56,0,55,0,110,0,53,0,NEWID(),@ID,@ID,GETDATE(),GETDATE());

END
