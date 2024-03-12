DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM GoartFormAComprehensions)
BEGIN 
	

	INSERT INTO GoartFormAComprehensions(Age_year_from,Age_month_from,Age_year_to,Age_month_to,PercentileRank,Comprehension_from,Comprehension_to,scaled_score,
	ID,CreatedUser,ModifiedUser,CreatedDate,ModifiedDate) 
	VALUES 
	(6,0,6,5,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,1,NULL,NULL,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,2,0,0,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,5,1,1,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,9,2,3,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,16,4,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,25,5,6,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,37,7,8,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,50,9,2,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,63,13,15,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,75,16,20,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,84,21,22,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,91,23,25,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,95,26,29,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,98,30,30,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,99,31,32,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,33,34,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,35,37,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,38,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,1,NULL,NULL,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,2,0,1,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,5,2,3,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,9,4,4,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,16,5,6,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,25,7,8,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,37,9,2,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,50,13,15,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,63,16,20,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,75,21,22,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,84,23,25,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,91,26,29,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,95,30,30,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,98,31,32,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,99,33,34,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,35,37,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,38,39,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,40,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,1,0,1,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,2,2,3,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,5,4,4,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,9,5,6,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,16,7,8,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,25,9,2,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,37,13,15,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,50,16,19,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,63,20,22,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,75,23,25,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,84,26,29,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,91,30,30,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,95,31,32,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,98,33,34,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,99,35,37,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,38,39,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,40,42,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,43,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,0,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,1,1,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,2,4,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,5,5,6,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,9,7,8,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,16,9,2,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,25,13,15,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,37,16,19,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,50,20,22,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,63,23,25,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,75,26,29,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,84,30,30,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,91,31,32,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,95,33,34,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,98,35,37,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,99,38,39,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,40,42,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,43,45,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,46,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,0,3,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,1,4,4,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,2,5,6,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,5,7,8,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,9,9,2,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,16,13,15,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,25,16,19,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,37,20,22,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,50,23,25,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,63,26,29,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,75,30,30,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,84,31,32,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,91,33,34,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,95,35,37,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,98,38,39,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,99,40,42,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,43,45,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,46,48,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,49,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,0,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,1,4,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,1,5,6,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,2,7,8,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,5,9,2,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,9,13,15,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,16,16,19,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,25,20,22,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,37,23,25,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,50,26,28,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,63,29,30,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,75,31,32,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,84,33,34,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,91,35,37,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,95,38,39,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,98,40,42,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,99,43,45,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,46,48,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,49,50,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,51,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,0,3,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,4,6,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,1,7,8,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,2,9,2,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,5,13,15,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,9,16,19,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,16,20,22,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,25,23,25,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,37,26,26,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,50,27,29,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,63,30,32,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,75,33,34,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,84,35,37,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,91,38,39,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,95,40,42,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,98,43,45,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,99,46,48,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,49,50,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,51,53,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,54,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,0,6,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,7,8,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,1,9,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,2,11,13,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,5,14,16,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,9,17,21,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,16,22,25,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,25,26,26,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,37,27,28,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,50,29,32,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,63,33,34,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,75,35,36,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,84,37,39,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,91,40,42,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,95,43,45,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,98,46,48,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,99,49,50,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,51,53,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,54,56,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,57,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,8,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,1,10,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,2,14,16,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,5,17,19,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,9,20,22,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,16,23,26,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,25,27,28,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,37,29,30,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,50,31,33,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,63,34,35,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,75,36,38,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,84,39,41,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,91,42,44,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,95,45,47,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,98,48,50,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,99,51,53,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,54,56,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,57,59,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,60,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,0,8,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,1,11,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,2,14,16,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,5,17,19,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,9,20,22,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,16,23,26,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,25,27,29,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,37,30,32,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,50,33,35,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,63,36,38,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,75,39,41,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,84,42,44,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,91,45,47,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,95,48,50,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,98,51,53,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,99,54,56,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,100,57,59,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,100,60,62,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,5,100,63,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,8,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,1,11,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,2,14,17,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,5,18,20,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,9,21,23,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,16,24,26,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,25,27,30,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,37,31,33,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,50,34,36,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,63,37,40,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,75,41,43,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,84,44,46,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,91,47,49,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,95,50,53,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,98,54,56,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,99,57,59,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,60,62,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,63,66,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,67,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,8,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,1,11,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,2,14,17,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,5,18,20,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,9,21,24,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,16,25,27,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,25,28,31,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,37,32,34,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,50,35,38,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,63,39,41,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,75,42,45,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,84,46,48,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,91,49,52,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,95,53,55,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,98,56,59,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,99,60,62,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,63,66,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,67,69,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,70,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,8,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,1,11,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,2,14,17,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,5,18,21,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,9,22,25,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,16,26,28,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,25,29,32,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,37,33,36,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,50,37,39,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,63,40,43,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,75,44,47,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,84,48,50,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,91,51,54,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,95,55,58,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,98,59,61,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,99,62,65,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,66,69,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,70,72,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,73,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,8,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,1,11,14,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,2,15,17,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,5,18,21,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,9,22,25,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,16,26,29,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,25,30,33,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,37,34,37,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,50,38,41,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,63,42,45,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,75,46,49,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,84,50,52,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,91,53,56,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,95,57,60,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,98,61,64,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,99,65,68,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,69,72,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,73,76,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,77,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,8,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,1,11,14,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,2,15,18,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,5,19,22,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,9,23,26,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,16,27,30,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,25,31,34,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,37,35,39,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,50,40,43,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,63,44,47,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,75,48,51,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,84,52,55,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,91,56,59,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,95,60,63,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,98,64,67,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,99,68,71,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,72,75,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,76,79,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,80,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,8,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,1,11,14,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,2,15,19,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,5,20,23,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,9,24,27,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,16,28,32,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,25,33,36,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,37,37,40,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,50,41,44,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,63,45,49,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,75,50,53,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,84,54,57,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,91,58,61,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,95,62,66,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,98,67,70,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,99,71,74,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,75,78,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,79,80,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,8,1,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,1,12,15,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,2,16,20,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,5,21,24,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,9,25,29,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,16,30,35,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,25,36,39,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,37,40,43,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,50,44,48,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,63,49,52,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,75,53,55,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,84,56,60,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,91,61,66,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,95,67,70,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,98,71,73,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,99,74,77,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,78,80,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,0,8,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,9,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,1,13,17,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,2,18,21,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,5,22,26,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,9,27,29,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,16,30,35,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,25,36,39,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,37,40,44,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,50,45,49,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,63,50,52,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,75,53,56,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,84,57,60,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,91,61,66,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,95,67,70,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,98,71,76,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,99,77,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,0,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,11,14,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,1,15,19,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,2,20,24,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,5,25,28,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,9,29,33,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,16,34,37,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,25,38,42,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,37,43,47,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,50,48,51,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,63,52,56,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,75,57,60,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,84,61,65,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,91,66,70,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,95,71,74,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,98,75,79,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,99,80,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,0,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,11,16,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,1,17,21,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,2,22,25,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,5,26,30,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,9,31,34,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,16,35,39,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,25,40,44,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,37,45,49,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,50,50,53,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,63,54,58,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,75,59,62,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,84,63,67,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,91,68,71,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,95,72,74,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,98,75,79,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,99,80,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,0,6,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,17,21,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,1,22,25,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,2,26,30,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,5,31,34,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,9,35,39,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,16,40,44,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,25,45,48,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,37,49,53,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,50,54,58,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,63,59,62,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,75,63,67,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,84,68,71,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,91,72,74,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,95,75,77,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,98,78,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,0,22,25,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,1,26,30,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,2,31,34,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,5,35,39,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,9,40,44,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,16,45,48,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,25,49,53,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,37,54,58,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,50,59,62,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,63,63,67,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,75,68,71,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,84,72,74,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,91,75,77,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,95,78,79,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,98,80,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE());


END
