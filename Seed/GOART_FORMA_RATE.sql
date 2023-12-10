DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM GoartFormARates)
BEGIN 
	
	INSERT INTO GoartFormARates(age_year_from,age_month_from,age_year_to,age_month_to,percentile_Rank,Rate_from,Rate_to,scaled_score,
	ID,CreatedUser,ModifiedUser,CreatedDate,ModifiedDate) 
	VALUES 
	(6,0,6,5,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,1,NULL,NULL,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,2,NULL,NULL,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,5,0,0,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,9,1,1,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,16,2,2,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,25,3,3,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,37,4,4,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,50,5,8,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,63,9,3,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,75,14,17,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,84,18,20,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,91,21,3,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,95,24,27,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,98,28,29,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,99,30,32,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,33,35,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,36,38,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,39,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,1,NULL,NULL,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,2,NULL,NULL,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,5,0,1,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,9,2,2,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,16,3,3,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,25,4,4,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,37,5,8,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,50,9,3,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,63,14,17,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,75,18,20,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,84,21,23,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,91,24,27,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,95,28,29,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,98,30,32,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,99,33,-34,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,35,37,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,38,40,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,41,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,1,NULL,NULL,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,2,0,1,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,5,2,2,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,9,3,3,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,16,4,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,25,5,8,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,37,9,3,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,50,14,17,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,63,18,20,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,75,21,23,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,84,24,27,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,91,28,29,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,95,30,32,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,98,33,34,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,99,35,37,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,38,40,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,41,43,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,44,-80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,1,0,1,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,2,2,2,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,5,3,3,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,9,4,4,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,16,5,8,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,25,9,3,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,37,14,17,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,50,18,20,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,63,21,23,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,75,24,27,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,84,28,29,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,91,30,32,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,95,33,34,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,98,35,37,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,99,38,40,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,41,43,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,44,6,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,47,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,0,1,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,1,2,2,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,2,3,3,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,5,4,4,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,9,5,8,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,16,9,3,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,25,14,17,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,37,18,20,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,50,21,23,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,63,24,27,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,75,28,29,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,84,30,32,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,91,33,34,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,95,35,37,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,98,38,40,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,99,41,43,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,44,46,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,47,9,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,50,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,2,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,1,3,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,2,4,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,5,5,8,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,9,9,3,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,16,14,17,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,25,18,20,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,37,21,23,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,50,24,27,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,63,28,29,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,75,30,32,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,84,33,34,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,91,35,37,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,95,38,40,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,98,41,43,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,99,44,46,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,47,49,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,50,52,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,53,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,0,2,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,3,3,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,1,4,4,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,2,5,8,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,5,9,3,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,9,14,17,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,16,18,20,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,25,21,23,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,37,24,26,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,50,27,29,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,63,30,32,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,75,33,34,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,84,35,37,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,91,38,40,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,95,41,43,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,98,44,46,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,99,47,49,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,50,52,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,53,55,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,56,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,0,3,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,4,4,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,1,5,8,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,2,9,3,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,5,14,16,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,9,17,19,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,16,20,22,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,25,23,25,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,37,26,28,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,50,29,31,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,63,32,34,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,75,35,37,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,84,38,40,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,91,41,43,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,95,44,46,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,98,47,49,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,99,50,52,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,53,55,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,56,59,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,60,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,0,4,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,5,8,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,1,9,1,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,2,12,15,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,5,16,18,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,9,19,21,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,16,22,24,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,25,25,27,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,37,28,30,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,50,31,33,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,63,34,36,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,75,37,40,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,84,41,43,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,91,44,46,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,95,47,49,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,98,50,52,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,99,53,55,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,56,59,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,60,62,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,63,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,0,0,4,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,0,5,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,1,10,12,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,2,13,15,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,5,16,19,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,9,20,22,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,16,23,25,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,25,26,29,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,37,30,32,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,50,33,35,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,63,36,39,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,75,40,42,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,84,43,45,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,91,46,49,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,95,50,52,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,98,53,55,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,99,56,59,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,60,62,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,63,66,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,67,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,6,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,1,10,12,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,2,13,16,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,5,17,20,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,9,21,23,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,16,24,27,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,25,28,30,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,37,31,34,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,50,35,37,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,63,38,41,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,75,42,45,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,84,46,48,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,91,49,52,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,95,53,55,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,98,56,59,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,99,60,62,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,63,66,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,67,70,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,71,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,6,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,1,10,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,2,14,16,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,5,17,20,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,9,21,24,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,16,25,28,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,25,29,32,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,37,33,36,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,50,37,39,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,63,40,43,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,75,44,47,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,84,48,51,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,91,52,55,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,95,56,58,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,98,59,62,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,99,63,66,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,67,70,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,71,74,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,75,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,6,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,1,10,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,2,14,17,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,5,18,21,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,9,22,25,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,16,26,29,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,25,30,33,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,37,34,37,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,50,38,41,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,63,42,45,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,75,46,49,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,84,50,53,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,91,54,57,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,95,58,61,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,98,62,65,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,99,66,70,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,71,74,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,75,78,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,79,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,6,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,1,10,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,2,14,17,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,5,18,22,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,9,23,26,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,16,27,30,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,25,31,35,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,37,36,39,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,50,40,43,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,63,44,47,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,75,48,52,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,84,53,56,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,91,57,60,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,95,61,65,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,98,66,69,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,99,70,73,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,74,78,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,79,80,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,6,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,1,10,13,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,2,14,18,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,5,19,22,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,9,23,27,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,16,28,31,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,25,32,36,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,37,37,41,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,50,42,45,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,63,46,50,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,75,51,54,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,84,55,59,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,91,60,63,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,95,64,68,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,98,69,72,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,99,73,77,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,78,80,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,6,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,1,10,14,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,2,15,19,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,5,20,23,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,9,24,28,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,16,29,33,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,25,34,38,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,37,39,43,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,50,44,47,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,63,48,52,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,75,53,57,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,84,58,61,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,91,62,66,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,95,67,71,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,98,72,76,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,99,77,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,6,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,1,11,15,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,2,16,20,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,5,21,25,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,9,26,30,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,16,31,34,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,25,35,39,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,37,40,44,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,50,45,48,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,63,49,54,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,75,55,59,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,84,60,64,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,91,65,69,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,95,70,74,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,98,75,79,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,99,80,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,6,1,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,1,12,16,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,2,17,21,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,5,22,26,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,9,27,31,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,16,32,36,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,25,37,41,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,37,42,47,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,50,48,52,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,63,53,57,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,75,58,62,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,84,63,67,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,91,68,72,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,95,73,77,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,98,78,79,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,99,80,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,0,7,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,8,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,1,13,17,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,2,18,23,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,5,24,28,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,9,29,33,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,16,34,39,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,25,40,44,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,37,45,49,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,50,50,54,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,63,55,60,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,75,61,65,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,84,66,70,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,91,71,75,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,95,76,78,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,98,79,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,0,9,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,10,14,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,1,15,20,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,2,21,25,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,5,26,30,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,9,31,36,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,16,37,41,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,25,42,46,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,37,47,52,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,50,53,57,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,63,58,63,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,75,64,68,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,84,69,73,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,91,74,77,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,95,78,78,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,98,79,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,0,2,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,13,17,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,1,18,23,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,2,24,28,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,5,29,33,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,9,34,39,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,16,40,44,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,25,45,50,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,37,51,55,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,50,56,60,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,63,61,66,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,75,67,71,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,84,72,76,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,91,77,78,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,95,79,79,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,98,80,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,0,0,5,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,0,16,21,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,1,22,26,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,2,27,32,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,5,33,37,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,9,38,42,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,16,43,48,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,25,49,53,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,37,54,59,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,50,60,65,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,63,66,70,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,75,71,73,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,84,74,76,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,91,77,78,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,95,79,79,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,98,80,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE());

END

