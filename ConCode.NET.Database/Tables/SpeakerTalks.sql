﻿CREATE TABLE [dbo].[SpeakerTalks]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [SpeakerId] BIGINT NOT NULL, 
    [TalkId] BIGINT NOT NULL
)
