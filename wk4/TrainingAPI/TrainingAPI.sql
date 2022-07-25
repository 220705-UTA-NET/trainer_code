CREATE SCHEMA Training;
GO

-- DROP TABLE Training.Associates;

CREATE TABLE Training.Associates
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(255) NOT NULL,
    Batch NVARCHAR(32) NULL
);

SELECT * FROM Training.Associates;

INSERT INTO Training.Associates (Name, Batch)
VALUES
('Annie', '220705-UTA-NET'),
('Samual Jackson', '220705-UTA-NET'),
('Joseph', NULL),
('Eunice', '220307-UTA-NET');

SELECT Id, Name, Batch FROM Training.Associates;