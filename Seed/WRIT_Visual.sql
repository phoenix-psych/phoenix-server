DECLARE @ID uniqueidentifier 
SELECT @ID=Id FROM [dbo].[Users] WHERE Username = 'admin'

IF NOT EXISTS (SELECT 1 FROM WRITVisuals)
BEGIN 

	INSERT INTO WRITVisuals
	(SUM_OF_VISUAL_STD_SCORES_FROM,SUM_OF_VISUAL_STD_SCORES_TO,IQ_SCORES_FREOM,IQ_SCORES_TO,PERCENTILES_FROM,PERCENTILES_TO,CONFIDENCE_INTERVALS90_FROM,CONFIDENCE_INTERVALS90_TO,CONFIDENCE_INTERVAL_95_FROM,CONFIDENCE_INTERVAL_95_TO,
			ID,CreatedUser,ModifiedUser,CreatedDate,ModifiedDate)   
	VALUES 
	(0,91,0,36,0,0.01,33,46,32,47,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(91,92,35,35,0,0.01,34,47,33,48,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(93,94,36,36,0,0.01,35,48,33,49,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(95,95,37,37,0,0.01,36,48,34,50,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(96,97,38,38,0,0.01,37,49,35,51,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(98,99,39,39,0,0.01,37,50,36,52,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(100,100,40,40,0,0.01,38,51,38,53,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(101,102,41,41,0,0.01,39,52,39,54,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(103,104,42,42,0,0.01,40,53,40,55,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(105,105,43,43,0,0.01,41,54,41,56,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(106,107,44,44,0.01,0.01,42,55,42,57,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(108,109,45,45,0.02,0.02,43,56,43,58,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(110,110,46,46,0.03,0.03,44,57,44,59,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(111,112,47,47,0.04,0.04,45,58,45,60,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(113,114,48,48,0.05,0.05,46,59,45,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(115,115,49,49,0.06,0.06,47,60,45,61,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(116,117,50,50,0.07,0.07,48,60,46,62,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(118,119,51,51,0.08,0.08,48,61,47,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(120,120,52,52,0.09,0.09,49,62,48,63,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(121,122,53,53,0.1,0.1,50,63,49,64,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(123,124,54,54,0.2,0.2,51,64,50,65,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(125,125,55,55,0.3,0.3,52,65,51,66,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(126,127,56,56,0.4,0.4,53,66,52,67,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(128,129,57,57,0.5,0.5,54,67,53,68,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(130,130,58,58,0.6,0.6,55,68,54,69,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(131,132,59,59,0.7,0.7,56,69,55,70,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(133,134,60,60,0.8,0.8,57,70,56,71,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(135,135,61,61,0.9,0.9,58,71,56,72,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(136,137,62,62,1,1,59,71,57,73,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(138,139,63,63,1,1,60,72,58,74,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(140,140,64,64,1,1,60,73,59,75,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(141,142,65,65,1,1,61,74,60,75,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(143,143,66,66,1,1,62,75,61,76,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(144,145,67,67,1,1,63,76,62,77,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(146,147,68,68,2,2,64,77,63,78,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(148,148,69,69,2,2,65,78,64,79,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(149,150,70,70,2,2,66,79,65,80,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(151,152,71,71,3,3,57,80,66,81,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(153,153,72,72,3,3,68,81,67,82,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(154,155,73,73,4,4,69,82,68,83,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(156,157,74,74,4,4,70,83,68,84,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(158,158,75,75,5,5,71,83,69,85,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(159,160,76,76,5,5,71,84,70,86,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(161,162,77,77,6,6,72,85,71,86,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(163,163,78,78,7,7,73,86,72,87,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(164,165,79,79,8,8,74,87,73,88,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(166,167,80,80,9,9,75,88,74,89,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(168,168,81,81,10,10,76,89,75,90,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(169,170,82,82,12,12,77,90,76,91,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(171,172,83,83,13,13,78,91,77,92,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(173,173,84,84,14,14,79,92,78,93,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(174,175,85,85,16,16,80,92,79,94,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(176,177,86,86,18,18,81,94,79,95,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(178,178,87,87,19,19,82,94,80,96,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(179,180,88,88,21,21,83,95,81,97,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(181,182,89,89,23,23,83,96,82,97,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(183,183,90,90,25,25,84,97,83,98,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(184,185,91,91,27,27,85,98,84,99,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(186,187,92,92,30,30,86,99,85,100,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(188,188,93,93,32,32,87,100,86,101,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(189,190,94,94,34,34,88,101,87,102,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(191,192,95,95,37,37,89,102,88,103,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(193,193,96,96,39,39,90,103,89,104,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(194,195,97,97,42,42,91,104,90,105,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(196,197,98,98,45,45,92,105,91,106,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(198,198,99,99,47,47,93,106,91,107,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(199,200,100,100,50,50,94,106,92,108,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(201,202,101,101,53,53,94,107,93,109,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(203,203,102,102,55,55,95,108,94,109,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(204,205,103,103,58,58,96,109,95,110,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(206,207,104,104,61,61,97,110,96,111,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(208,208,105,105,63,63,98,111,97,112,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(209,210,106,106,66,66,99,111,98,113,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(211,212,107,107,68,68,100,113,99,114,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(213,213,108,108,70,70,101,114,100,115,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(214,215,109,109,73,73,102,115,101,116,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(216,217,110,110,75,75,103,116,102,117,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(218,218,111,111,77,77,104,117,102,118,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(219,220,112,112,79,79,105,117,103,119,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(221,222,113,113,81,81,106,118,104,120,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(223,223,114,114,83,83,107,119,105,121,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(224,225,115,115,84,84,107,120,106,121,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(226,227,116,116,86,86,108,121,107,122,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(228,228,117,117,87,87,109,122,108,123,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(229,230,118,118,88,88,110,123,109,124,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(231,232,119,119,90,90,111,124,110,125,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(233,233,120,120,91,91,112,125,111,126,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(234,235,121,121,92,92,113,126,112,127,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(236,237,122,122,93,93,114,127,113,128,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(238,238,123,123,94,94,115,128,114,129,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(239,240,124,124,95,95,116,129,114,130,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(241,242,125,125,95,95,117,129,115,131,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(243,243,126,126,96,96,117,130,116,132,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(244,245,127,127,96,96,118,131,117,132,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(246,246,128,128,97,97,119,132,118,133,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(247,248,129,129,97,97,120,133,119,134,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(249,250,130,130,98,98,121,134,120,135,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(251,251,131,131,98,98,122,135,121,136,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(252,253,132,132,98,98,123,136,122,137,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(254,255,133,133,99,99,124,137,123,138,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(256,256,134,134,99,99,125,138,124,139,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(257,258,135,135,99,99,126,139,125,140,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(259,260,136,136,99,99,127,140,125,141,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(261,261,137,137,99,99,128,140,126,142,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(262,263,138,138,99,99,129,141,127,143,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(264,265,139,139,99.1,99.1,130,142,128,144,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(266,266,140,140,99.2,99.2,130,143,129,144,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(267,268,141,141,99.3,99.3,131,144,130,145,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(269,270,142,142,99.4,99.4,132,145,131,146,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(271,271,143,143,99.5,99.5,133,146,132,147,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(272,273,144,144,99.6,99.6,134,147,133,148,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(274,275,145,145,99.7,99.7,135,148,134,149,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(276,276,146,146,99.8,99.8,136,149,135,150,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(277,278,147,147,99.9,99.9,137,150,136,151,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(279,280,148,148,99.91,99.91,138,151,137,152,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(281,281,149,149,99.92,99.92,139,152,137,153,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(282,283,150,150,99.93,99.93,140,152,138,154,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(284,285,151,151,99.94,99.94,140,153,139,155,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(286,286,152,152,99.95,99.95,141,154,140,155,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(287,288,153,153,99.96,99.96,142,155,141,156,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(289,290,154,154,99.97,99.97,143,156,142,157,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(291,291,155,155,99.98,99.98,144,157,143,158,NEWID(),@ID,@ID,GETDATE(),GETDATE()),
	(292,292,155,0,99.98,0,145,158,144,159,NEWID(),@ID,@ID,GETDATE(),GETDATE());

END