DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM TowreRanks)
BEGIN 

	INSERT INTO TowreRanks([Index],Percentile_rank_FROM,Percentile_rank_TO,
			ID,CreatedUser,ModifiedUser,CreatedDate,ModifiedDate)  
	VALUES 
	(53,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(54,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(55,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(56,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(57,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(58,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(59,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(60,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(61,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(62,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(63,0,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(64,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(65,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(66,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(67,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(68,1,1,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(69,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(70,2,2,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(71,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(72,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(73,3,3,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(74,4,4,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(75,5,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(76,5,5,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(77,6,6,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(78,7,7,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(79,8,8,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(80,9,9,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(81,10,10,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(82,12,12,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(83,13,13,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(84,14,14,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(85,16,16,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(86,18,18,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(87,19,19,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(88,21,21,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(89,23,23,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(90,25,25,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(91,27,27,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(92,30,30,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(93,32,32,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(94,35,35,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(95,37,37,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(96,39,39,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(97,42,42,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(98,45,45,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(99,47,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(100,50,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(101,53,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(102,55,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(103,58,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(104,61,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(105,63,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(106,65,65,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(107,68,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(108,70,70,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(109,73,73,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(110,75,75,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(111,77,77,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(112,79,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(113,81,81,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(114,82,82,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(115,84,84,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(116,86,86,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(117,87,87,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(118,89,89,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(119,90,90,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(120,91,91,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(121,92,92,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(122,93,93,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(123,94,94,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(124,95,95,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(125,95,95,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(126,96,96,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(127,97,97,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(128,97,97,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(129,97,97,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(130,98,98,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(131,98,98,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(132,99,99,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(133,99,99,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(134,99,99,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(135,99,99,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(136,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(137,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(138,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(139,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(140,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(141,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(142,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(143,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(144,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(145,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(146,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(147,99,0,NEWID(),@ID,@ID,GETDATE(),GETDATE());

END;