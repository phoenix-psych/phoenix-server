DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM GoartFormBRates)
BEGIN 
	

	INSERT INTO GoartFormBRates(age_year_from,age_month_from,age_year_to,age_month_to,percentile_Rank,scaled_score,rate_from,rate_to,
	ID,CreatedUser,ModifiedUser,CreatedDate,ModifiedDate) 
	VALUES 
	(6,0,6,5,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,0,2,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,1,3,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,2,4,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,5,5,0,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,9,6,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,16,7,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,25,8,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,37,9,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,50,10,5,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,63,11,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,75,12,13,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,84,13,16,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,91,14,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,95,15,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,98,16,28,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,99,17,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,18,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,19,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,20,40,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,2,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,1,3,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,2,4,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,5,5,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,9,6,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,16,7,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,25,8,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,37,9,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,50,10,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,63,11,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,75,12,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,84,13,21,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,91,14,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,95,15,28,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,98,16,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,99,17,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,18,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,19,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,20,43,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,2,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,1,3,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,2,4,0,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,5,5,1,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,9,6,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,16,7,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,25,8,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,37,9,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,50,10,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,63,11,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,75,12,21,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,84,13,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,91,14,28,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,95,15,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,98,16,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,99,17,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,18,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,19,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,20,46,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,2,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,1,3,0,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,2,4,1,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,5,5,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,9,6,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,16,7,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,25,8,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,37,9,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,50,10,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,63,11,21,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,75,12,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,84,13,28,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,91,14,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,95,15,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,98,16,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,99,17,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,18,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,19,46,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,20,49,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,2,0,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,1,3,1,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,2,4,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,5,5,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,9,6,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,16,7,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,25,8,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,37,9,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,50,10,21,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,63,11,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,75,12,28,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,84,13,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,91,14,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,95,15,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,98,16,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,99,17,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,18,46,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,19,49,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,20,52,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,2,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,1,3,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,2,4,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,5,5,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,9,6,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,16,7,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,25,8,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,37,9,21,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,50,10,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,63,11,28,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,75,12,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,84,13,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,91,14,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,95,15,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,98,16,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,99,17,46,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,18,49,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,19,52,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,20,55,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,1,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,2,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,1,3,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,2,4,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,5,5,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,9,6,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,16,7,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,25,8,21,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,37,9,24,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,50,10,27,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,63,11,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,75,12,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,84,13,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,91,14,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,95,15,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,98,16,46,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,99,17,49,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,18,52,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,19,55,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,20,59,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,1,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,2,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,1,3,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,2,4,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,5,5,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,9,6,16,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,16,7,20,22,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,25,8,23,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,37,9,27,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,50,10,30,32,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,63,11,33,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,75,12,36,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,84,13,39,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,91,14,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,95,15,46,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,98,16,49,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,99,17,52,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,18,55,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,19,59,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,20,62,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,1,0,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,2,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,1,3,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,2,4,11,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,5,5,15,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,9,6,18,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,16,7,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,25,8,25,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,37,9,29,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,50,10,32,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,63,11,35,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,75,12,39,41,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,84,13,42,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,91,14,45,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,95,15,49,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,98,16,52,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,99,17,55,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,18,59,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,19,62,65,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,20,66,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,0,1,0,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,0,2,6,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,1,3,10,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,2,4,13,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,5,5,17,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,9,6,20,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,16,7,24,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,25,8,27,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,37,9,31,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,50,10,34,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,63,11,38,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,75,12,41,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,84,13,45,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,91,14,48,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,95,15,52,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,98,16,55,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,99,17,59,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,18,62,65,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,19,66,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,20,69,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,1,0,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,2,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,1,3,10,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,2,4,14,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,5,5,18,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,9,6,21,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,16,7,25,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,25,8,29,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,37,9,32,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,50,10,36,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,63,11,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,75,12,43,46,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,84,13,47,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,91,14,51,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,95,15,54,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,98,16,58,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,99,17,62,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,18,65,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,19,69,72,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,20,73,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,1,0,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,2,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,1,3,11,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,2,4,15,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,5,5,18,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,9,6,22,25,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,16,7,26,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,25,8,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,37,9,34,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,50,10,38,41,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,63,11,42,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,75,12,45,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,84,13,49,52,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,91,14,53,56,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,95,15,57,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,98,16,61,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,99,17,65,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,18,69,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,19,72,75,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,20,76,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,1,0,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,2,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,1,3,11,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,2,4,15,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,5,5,19,22,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,9,6,23,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,16,7,27,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,25,8,31,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,37,9,35,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,50,10,39,43,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,63,11,44,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,75,12,48,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,84,13,52,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,91,14,56,59,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,95,15,60,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,98,16,64,67,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,99,17,68,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,18,72,75,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,19,76,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,20,80,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,1,0,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,2,7,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,1,3,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,2,4,16,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,5,5,20,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,9,6,24,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,16,7,28,32,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,25,8,33,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,37,9,37,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,50,10,41,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,63,11,45,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,75,12,50,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,84,13,54,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,91,14,58,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,95,15,62,66,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,98,16,67,70,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,99,17,71,74,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,18,75,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,19,79,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,1,0,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,2,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,1,3,12,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,2,4,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,5,5,21,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,9,6,25,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,16,7,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,25,8,34,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,37,9,38,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,50,10,43,46,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,63,11,47,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,75,12,50,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,84,13,56,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,91,14,61,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,95,15,65,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,98,16,69,73,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,99,17,74,77,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,18,78,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,1,0,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,2,8,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,1,3,12,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,2,4,17,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,5,5,22,25,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,9,6,26,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,16,7,31,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,25,8,35,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,37,9,40,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,50,10,45,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,63,11,49,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,75,12,54,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,84,13,58,62,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,91,14,63,67,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,95,15,68,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,98,16,72,76,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,99,17,77,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,1,0,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,2,8,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,1,3,13,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,2,4,18,22,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,5,5,23,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,9,6,27,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,16,7,32,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,25,8,37,41,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,37,9,42,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,50,10,46,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,63,11,50,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,75,12,55,59,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,84,13,60,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,91,14,65,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,95,15,69,74,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,98,16,75,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,99,17,80,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,1,0,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,2,9,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,1,3,14,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,2,4,19,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,5,5,24,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,9,6,29,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,16,7,34,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,25,8,39,43,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,37,9,44,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,50,10,49,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,63,11,54,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,75,12,58,62,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,84,13,63,67,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,91,14,68,72,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,95,15,73,77,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,98,16,78,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,1,0,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,2,10,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,1,3,15,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,2,4,20,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,5,5,25,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,9,6,30,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,16,7,35,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,25,8,41,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,37,9,46,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,50,10,51,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,63,11,56,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,75,12,61,65,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,84,13,66,70,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,91,14,71,75,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,95,15,76,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,98,16,79,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,1,0,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,2,11,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,1,3,17,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,2,4,22,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,5,5,27,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,9,6,32,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,16,7,38,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,25,8,43,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,37,9,48,52,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,50,10,53,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,63,11,59,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,75,12,64,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,84,13,69,73,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,91,14,74,77,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,95,15,78,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,98,16,79,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,1,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,2,13,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,1,3,19,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,2,4,24,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,5,5,29,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,9,6,35,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,16,7,40,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,25,8,45,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,37,9,51,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,50,10,56,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,63,11,61,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,75,12,69,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,84,13,72,76,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,91,14,77,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,95,15,79,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,98,16,80,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,0,1,0,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,0,2,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,1,3,21,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,2,4,27,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,5,5,32,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,9,6,38,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,16,7,43,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,25,8,49,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,37,9,55,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,50,10,61,67,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,63,11,68,69,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,75,12,70,74,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,84,13,75,77,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,91,14,78,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,95,15,79,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,98,16,80,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE());


END

