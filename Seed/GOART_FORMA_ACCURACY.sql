DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM GoartFormAAccuracys)
BEGIN 
	
	INSERT INTO GoartFormAAccuracys(year_from,month_from,year_to,month_to,ile_Rank,scaled_score,Accuracy_from,Accuracy_to,
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
	(6,0,6,5,37,9,4,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,50,10,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,63,11,10,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,75,12,15,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,84,13,19,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,91,14,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,95,15,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,98,16,28,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,99,17,31,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,18,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,19,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,0,6,5,100,20,40,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,0,2,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,1,3,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,2,4,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,5,5,0,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,9,6,1,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,16,7,3,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,25,8,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,37,9,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,50,10,10,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,63,11,15,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,75,12,19,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,84,13,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,91,14,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,95,15,28,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,98,16,31,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,99,17,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,18,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,19,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,6,6,11,100,20,43,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,0,2,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,1,3,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,2,4,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,5,5,2,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,9,6,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,16,7,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,25,8,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,37,9,10,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,50,10,15,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,63,11,19,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,75,12,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,84,13,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,91,14,28,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,95,15,31,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,98,16,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,99,17,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,18,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,19,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,0,7,5,100,20,46,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,0,2,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,1,3,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,2,4,0,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,5,5,3,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,9,6,5,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,16,7,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,25,8,10,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,37,9,15,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,50,10,19,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,63,11,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,75,12,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,84,13,28,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,91,14,31,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,95,15,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,98,16,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,99,17,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,18,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,19,46,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(7,6,7,11,100,20,49,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,0,2,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,1,3,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,2,4,2,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,5,5,4,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,9,6,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,16,7,10,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,25,8,15,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,37,9,19,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,50,10,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,63,11,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,75,12,28,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,84,13,31,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,91,14,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,95,15,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,98,16,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,99,17,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,18,46,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,19,49,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,0,8,5,100,20,52,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,0,2,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,1,3,2,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,2,4,4,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,5,5,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,9,6,10,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,16,7,15,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,25,8,19,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,37,9,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,50,10,25,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,63,11,28,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,75,12,31,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,84,13,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,91,14,37,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,95,15,40,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,98,16,43,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,99,17,46,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,18,49,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,19,52,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,6,8,11,100,20,55,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,1,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,0,2,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,1,3,4,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,2,4,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,5,5,10,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,9,6,15,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,16,7,18,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
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
	(9,0,9,5,100,19,55,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,0,9,5,100,20,58,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,1,0,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,0,2,1,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,1,3,7,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,2,4,10,11,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,5,5,12,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,9,6,17,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,16,7,20,22,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,25,8,23,25,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,37,9,26,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,50,10,29,32,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,63,11,33,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,75,12,36,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,84,13,39,41,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,91,14,42,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,95,15,45,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,98,16,48,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,99,17,52,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,18,55,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,19,58,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(9,6,9,11,100,20,61,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,1,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,0,2,2,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,1,3,8,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,2,4,11,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,5,5,14,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,9,6,18,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,16,7,21,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,25,8,24,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,37,9,28,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,50,10,31,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,63,11,34,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,75,12,38,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,84,13,41,43,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,91,14,44,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,95,15,48,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,98,16,51,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,99,17,54,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,18,58,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,19,61,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,0,10,5,100,20,64,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,0,1,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,0,2,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,1,3,8,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,2,4,11,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,5,5,15,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,9,6,18,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,16,7,22,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,25,8,25,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,37,9,29,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,50,10,32,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,63,11,36,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,75,12,39,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,84,13,43,46,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,91,14,47,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,95,15,50,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,98,16,54,56,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,99,17,57,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,18,61,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,19,64,67,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(10,6,10,11,100,20,68,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,1,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,0,2,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,1,3,8,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,2,4,12,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,5,5,15,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,9,6,19,22,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,16,7,23,25,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,25,8,26,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,37,9,30,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,50,10,34,36,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,63,11,37,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,75,12,41,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,84,13,45,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,91,14,49,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,95,15,52,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,98,16,56,59,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,99,17,60,62,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,18,63,66,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,19,67,70,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,0,11,5,100,20,71,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,1,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,0,2,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,1,3,8,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,2,4,12,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,5,5,16,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,9,6,19,22,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,16,7,23,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,25,8,27,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,37,9,31,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,50,10,35,38,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,63,11,39,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,75,12,43,46,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,84,13,47,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,91,14,51,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,95,15,55,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,98,16,59,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,99,17,62,65,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,18,66,69,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,19,70,73,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(11,6,11,11,100,20,74,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,1,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,0,2,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,1,3,8,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,2,4,12,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,5,5,16,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,9,6,20,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,16,7,24,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,25,8,28,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,37,9,32,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,50,10,36,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,63,11,41,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,75,12,45,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,84,13,49,52,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,91,14,53,56,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,95,15,57,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,98,16,61,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,99,17,65,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,18,69,72,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,19,73,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,0,12,5,100,20,78,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,1,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,0,2,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,1,3,8,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,2,4,12,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,5,5,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,9,6,21,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,16,7,25,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,25,8,29,32,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,37,9,33,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,50,10,38,41,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,63,11,42,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,75,12,46,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,84,13,51,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,91,14,55,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,95,15,59,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,98,16,64,67,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,99,17,68,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,18,72,76,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,19,77,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(12,6,12,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,1,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,0,2,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,1,3,8,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,2,4,12,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,5,5,18,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,9,6,22,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,16,7,27,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,25,8,31,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,37,9,36,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,50,10,40,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,63,11,45,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,75,12,49,52,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,84,13,53,56,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,91,14,57,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,95,15,62,65,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,98,16,66,70,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,99,17,71,74,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,18,75,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,19,80,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,0,13,5,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,1,0,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,0,2,4,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,1,3,8,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,2,4,13,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,5,5,18,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,9,6,22,26,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,16,7,27,31,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,25,8,32,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,37,9,36,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,50,10,41,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,63,11,46,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,75,12,50,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,84,13,55,59,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,91,14,60,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,95,15,65,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,98,16,69,73,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,99,17,74,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,18,79,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,6,13,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,1,0,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,0,2,5,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,1,3,9,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,2,4,14,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,5,5,19,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,9,6,24,28,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,16,7,29,33,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,25,8,34,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,37,9,38,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,50,10,45,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,63,11,49,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,75,12,54,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,84,13,59,62,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,91,14,63,66,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,95,15,67,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,98,16,72,76,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,99,17,77,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(14,0,14,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,1,0,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,0,2,6,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,1,3,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,2,4,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,5,5,21,25,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,9,6,26,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,16,7,31,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,25,8,36,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,37,9,41,44,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,50,10,45,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,63,11,50,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,75,12,55,59,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,84,13,60,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,91,14,65,69,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,95,15,70,74,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,98,16,75,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,99,17,80,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,0,15,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,1,0,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,0,2,8,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,1,3,13,17,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,2,4,18,22,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,5,5,23,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,9,6,28,32,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,16,7,33,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,25,8,38,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,37,9,43,46,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,50,10,47,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,63,11,52,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,75,12,58,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,84,13,64,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,91,14,69,73,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,95,15,74,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,98,16,79,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(16,0,16,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,1,0,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,0,2,11,15,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,1,3,16,20,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,2,4,21,25,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,5,5,26,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,9,6,31,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,16,7,36,41,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,25,8,42,46,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,37,9,47,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,50,10,51,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,63,11,56,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,75,12,62,66,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,84,13,67,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,91,14,72,76,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,95,15,77,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,98,16,79,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,0,17,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,1,0,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,0,2,15,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,1,3,20,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,2,4,25,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,5,5,30,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,9,6,35,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,16,7,41,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,25,8,46,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,37,9,51,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,50,10,56,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,63,11,61,65,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,75,12,66,70,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,84,13,71,73,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,91,14,74,76,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,95,15,77,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,98,16,79,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(18,0,18,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,0,1,0,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,0,2,20,24,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,1,3,25,29,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,2,4,30,34,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,5,5,35,40,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,9,6,41,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,16,7,46,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,25,8,51,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,37,9,56,59,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,50,10,60,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,63,11,65,69,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,75,12,70,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,84,13,72,74,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,91,14,75,77,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,95,15,78,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,98,16,80,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,99,17,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,100,18,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,100,19,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(19,0,99,11,100,20,NULL,NULL,NEWID(),@ID,@ID,GETDATE(),GETDATE());

END
