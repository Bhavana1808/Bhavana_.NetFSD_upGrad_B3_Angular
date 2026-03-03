
 --CREATE DATABASE

CREATE DATABASE EventDb;
USE EventDb;

-- CREATE TABLE: UserInfo
CREATE TABLE UserInfo (
    EmailId VARCHAR(100) PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL  CHECK (LEN(UserName) BETWEEN 1 AND 50),
    Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin','Participant')),
	Password VARCHAR(20) NOT NULL CHECK (LEN(Password) BETWEEN 6 AND 20)
);
 
 --CREATE TABLE: EventDetail
CREATE TABLE EventDetails (
    EventId INT PRIMARY KEY,
    EventName VARCHAR(50) NOT NULL CHECK (LEN(EventName) BETWEEN 1 AND 50),
    EventCategory VARCHAR(50) NOT NULL  CHECK (LEN(EventCategory) BETWEEN 1 AND 50),
    EventDate DATETIME NOT NULL,
    Description VARCHAR(255) NULL,
    Status VARCHAR(20)  CHECK (Status IN ('Active','In-Active'))
);

  --CREATE TABLE: SpeakersDetails
CREATE TABLE SpeakersDetails (
    SpeakerId INT PRIMARY KEY,
    SpeakerName VARCHAR(50) NOT NULL CHECK (LEN(SpeakerName) BETWEEN 1 AND 50)
);

   --CREATE TABLE: SessionInfo
CREATE TABLE SessionInfo (
    SessionId INT PRIMARY KEY,
	EventId INT NOT NULL,
	SessionTitle VARCHAR(50) NOT NULL CHECK (LEN(SessionTitle) BETWEEN 1 AND 50),
	SpeakerId INT NOT NULL,
	Description VARCHAR(255) NULL,
	SessionStart DATETIME NOT NULL,
	SessionEnd DATETIME NOT NULL,
	SessionUrl VARCHAR(255),
	FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
	FOREIGN KEY (SpeakerId) REFERENCES SpeakersDetails(SpeakerId)
);

 --CREATE TABLE: ParticipantEventDetails
CREATE TABLE ParticipantEventDetails (
    Id INT PRIMARY KEY,
	ParticipantEmailId VARCHAR(100) NOT NULL,
	EventId INT NOT NULL,
	SessionId INT NOT NULL,
	IsAttended BIT CHECK (IsAttended IN (0,1)),
	FOREIGN KEY (ParticipantEmailId)  REFERENCES UserInfo(EmailId),
	FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
	FOREIGN KEY (SessionId) REFERENCES SessionInfo(SessionId)
);


   --INSERT SAMPLE DATA

-- Insert Users
INSERT INTO UserInfo VALUES
('koushi@gmail.com','Koushik','Admin','admin123'),
('bhavana@gmail.com','Bhavana','Participant','pass123');

-- Insert Event
INSERT INTO EventDetails VALUES
(1,'Tech Summit','Technology','2026-04-10',
 'Annual Tech Event','Active');

-- Insert Speaker
INSERT INTO SpeakersDetails VALUES
(101,'Sujith Kumar');

-- Insert Session
INSERT INTO SessionInfo VALUES
(201,1,'AI Basics',101,
 'Introduction to Artificial Intelligence',
 '2026-04-10 10:00:00 ',
 '2026-04-10 05:00:00',
 'www.sessionlink.com');

-- Insert Participant Event Details
INSERT INTO ParticipantEventDetails VALUES
(1,'bhavana@gmail.com',1,201,1);




  --RETRIEVAL QUERIES


SELECT * FROM UserInfo;
SELECT * FROM EventDetails;
SELECT * FROM SpeakersDetails;
SELECT * FROM SessionInfo;
SELECT * FROM ParticipantEventDetails;

