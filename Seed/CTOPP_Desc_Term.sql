DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'


IF NOT EXISTS (SELECT 1 FROM CTOPPDescriptiveTerms)
BEGIN 

	INSERT INTO CTOPPDescriptiveTerms(ScaledScoreFrom,ScaledScoreTo,DescriptiveTerm,CompositeScoreFrom,CompositeScoreTo,ID,CreatedUser,ModifiedUser,CreatedDate,ModifiedDate)  
	VALUES 
	(1,3,'Very Low',0,69,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(4,5,'Low',70,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,7,'Below Average',80,84,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(6,7,'Low Average',85,89,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(8,12,'Mid Average',90,110,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,14,'High Average',111,115,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(13,14,'Above Average',116,120,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(15,16,'High',121,130,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(17,20,'Very High',131,0,NEWID(),@ID,@ID,GETDATE(),GETDATE());

END;

