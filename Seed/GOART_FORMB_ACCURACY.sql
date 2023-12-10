DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM GoartFormBAccuracys)
BEGIN 
	
	INSERT INTO GoartFormBAccuracys(age_year_from,age_month_from,age_year_to,age_month_to,percentile_Rank,Accuracy_from,Accuracy_to,scaled_score,
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
	(6,0,6,5,63,9,2,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,75,13,17,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,84,18,21,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,91,22,25,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,95,26,28,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,98,29,31,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,99,32,33,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,34,36,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,37,38,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,39,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,1,NULL,NULL,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,2,0,0,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,5,1,1,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,9,2,2,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,16,3,3,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,25,4,4,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,37,5,8,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,50,9,2,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,63,13,17,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,75,18,21,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,84,22,25,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,91,26,28,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,95,29,30,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,98,31,33,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,99,34,36,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,37,38,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,39,43,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,44,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,1,NULL,NULL,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,2,0,0,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,5,1,2,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,9,3,3,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,16,4,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,25,5,8,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,37,9,2,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,50,13,17,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,63,18,21,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,75,22,25,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,84,26,28,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,91,29,30,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,95,31,33,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,98,34,36,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,99,37,38,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,39,43,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,44,47,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,48,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,NULL,NULL,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,1,0,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,2,1,1,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,5,3,3,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,9,4,4,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,16,5,8,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,25,9,2,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,37,13,17,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,50,18,21,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,63,22,25,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,75,26,27,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,84,28,30,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,91,31,33,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,95,34,36,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,98,37,38,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,99,39,43,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,44,47,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,48,50,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,51,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,0,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,1,1,2,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,2,3,3,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,5,4,4,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,9,5,8,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,16,9,2,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,25,13,17,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,37,18,21,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,50,22,25,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,63,26,27,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,75,28,30,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,84,31,33,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,91,34,36,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,95,37,38,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,98,39,43,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,99,44,47,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,48,50,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,51,53,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,54,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,NULL,NULL,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,0,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,1,3,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,2,4,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,5,5,8,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,9,9,2,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,16,13,17,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,25,18,21,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,37,22,24,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,50,25,27,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,63,28,30,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,75,31,33,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,84,34,36,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,91,37,38,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,95,39,43,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,98,44,47,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,99,48,50,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,51,53,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,54,56,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,57,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,0,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,1,3,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,1,4,4,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,2,5,8,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,5,9,2,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,9,13,17,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,16,18,21,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,25,22,23,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,37,24,27,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,50,28,30,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,63,31,33,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,75,34,35,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,84,36,38,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,91,39,43,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,95,44,46,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,98,47,50,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,99,51,53,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,54,56,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,57,60,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,61,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,24,24,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,1,5,6,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,2,7,1,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,5,12,15,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,9,16,18,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,16,19,22,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,25,23,25,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,37,26,29,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,50,30,32,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,63,33,35,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,75,36,38,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,84,39,42,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,91,43,46,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,95,47,49,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,98,50,53,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,99,54,56,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,57,60,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,61,63,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,64,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,2,5,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,1,6,8,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,2,9,2,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,5,13,16,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,9,17,19,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,16,20,23,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,25,24,27,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,37,28,30,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,50,31,34,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,63,35,38,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,75,39,41,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,84,42,45,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,91,46,48,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,95,49,52,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,98,53,56,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,99,57,59,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,60,63,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,64,67,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,68,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,0,2,5,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,1,6,9,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,2,10,13,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,5,14,17,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,9,18,20,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,16,21,24,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,25,25,28,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,37,29,32,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,50,33,36,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,63,37,40,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,75,41,43,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,84,44,47,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,91,48,51,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,95,52,55,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,98,56,59,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,99,60,62,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,63,66,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,67,70,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,71,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,2,5,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,1,6,9,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,2,10,13,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,5,14,7,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,9,18,21,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,16,22,25,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,25,26,29,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,37,30,33,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,50,34,37,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,63,38,41,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,75,42,45,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,84,46,49,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,91,50,53,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,95,54,57,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,98,58,61,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,99,62,65,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,66,69,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,70,73,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,74,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,2,5,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,1,6,9,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,2,10,14,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,5,15,18,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,9,19,22,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,16,23,26,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,25,27,30,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,37,31,35,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,50,36,39,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,63,40,43,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,75,44,47,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,84,48,52,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,91,53,56,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,95,57,60,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,98,61,64,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,99,65,68,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,69,73,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,74,77,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,78,80,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,2,5,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,1,6,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,2,11,14,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,5,15,18,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,9,19,23,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,16,24,27,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,25,28,32,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,37,33,36,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,50,37,40,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,63,41,45,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,75,46,49,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,84,50,54,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,91,55,58,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,95,59,62,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,98,63,67,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,99,68,71,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,72,76,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,77,80,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,2,5,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,1,6,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,2,11,14,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,5,15,19,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,9,20,24,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,16,25,28,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,25,29,33,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,37,34,37,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,50,38,42,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,63,43,47,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,75,48,51,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,84,52,56,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,91,57,60,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,95,61,65,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,98,66,70,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,99,71,74,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,75,79,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,80,80,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,2,6,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,1,7,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,2,11,15,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,5,16,21,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,9,22,25,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,16,26,30,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,25,31,35,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,37,36,39,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,50,40,44,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,63,45,50,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,75,51,53,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,84,54,58,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,91,59,64,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,95,65,68,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,98,69,73,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,99,74,77,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,78,80,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,0,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,2,6,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,1,7,1,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,2,12,16,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,5,17,21,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,9,22,26,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,16,27,31,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,25,32,36,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,37,37,41,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,50,42,46,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,63,47,51,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,75,52,56,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,84,57,61,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,91,62,66,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,95,67,70,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,98,71,75,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,99,76,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,0,2,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,3,7,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,1,8,2,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,2,13,18,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,5,19,24,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,9,25,29,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,16,30,34,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,25,35,39,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,37,40,43,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,50,44,48,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,63,49,55,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,75,56,59,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,84,60,64,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,91,65,70,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,95,71,75,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,98,76,78,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,99,79,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,0,4,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,5,9,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,1,10,14,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,2,15,19,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,5,20,25,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,9,26,30,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,16,31,35,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,25,36,40,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,37,41,45,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,50,46,50,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,63,51,56,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,75,57,61,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,84,62,64,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,91,65,70,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,95,71,75,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,98,76,78,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,99,79,80,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,0,6,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,7,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,1,13,17,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,2,18,22,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,5,23,27,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,9,28,32,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,16,33,38,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,25,39,43,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,37,44,48,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,50,49,53,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,63,54,59,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,75,60,64,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,84,65,69,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,91,70,74,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,95,75,78,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,98,79,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,0,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,11,15,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,1,16,20,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,2,21,25,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,5,26,29,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,9,30,34,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,16,35,41,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,25,42,46,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,37,47,51,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,50,52,56,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,63,57,62,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,75,63,68,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,84,69,71,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,91,72,74,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,95,75,78,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,98,79,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,0,4,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,15,19,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,1,20,24,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,2,25,29,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,5,30,34,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,9,35,40,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,16,41,46,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,25,47,51,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,37,52,56,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,50,57,62,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,63,63,68,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,75,69,71,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,84,72,74,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,91,75,76,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,95,77,79,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,98,80,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,0,0,9,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,0,20,24,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,1,25,29,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,2,30,34,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,5,35,40,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,9,41,46,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,16,47,51,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,25,52,55,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,37,56,62,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,50,63,68,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,63,69,71,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,75,72,73,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,84,74,76,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,91,77,78,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,95,79,79,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,98,80,80,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,99,NULL,NULL,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,NULL,NULL,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,NULL,NULL,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,23,11,100,NULL,NULL,20,NEWID(),@ID,@ID,GETDATE(),GETDATE());

END
