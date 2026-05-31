CREATE DATABASE Mini_Project;
USE Mini_Project;

CREATE TABLE Users
(
UserId INT PRIMARY KEY IDENTITY(1,1),

UserName VARCHAR(50) NOT NULL,

Password VARCHAR(50) NOT NULL,

UserType VARCHAR(20) NOT NULL

);

CREATE TABLE TrainDetails
(
TrainNo INT PRIMARY KEY,

TrainName VARCHAR(100) NOT NULL,

FromStation VARCHAR(100) NOT NULL,

ToStation VARCHAR(100) NOT NULL,

TravelClass VARCHAR(20) NOT NULL,

Availability INT NOT NULL,

Charges DECIMAL(10,2) NOT NULL,

IsDeleted BIT DEFAULT 0

);

CREATE TABLE BookingDetails
(
BookingId INT PRIMARY KEY IDENTITY(1,1),

BookDate DATETIME DEFAULT GETDATE(),

TravelDate DATE NOT NULL,

TrainNo INT NOT NULL,

TravelClass VARCHAR(20) NOT NULL,

Passengers INT NOT NULL,

Amount DECIMAL(10,2) NOT NULL,

FOREIGN KEY(TrainNo)
REFERENCES TrainDetails(TrainNo)

);

CREATE TABLE CancellationDetails
(
CId INT PRIMARY KEY IDENTITY(1,1),

BookingId INT NOT NULL,

NoTickets INT NOT NULL,

RefundAmount DECIMAL(10,2) NOT NULL,

FOREIGN KEY(BookingId)
REFERENCES BookingDetails(BookingId)

);

INSERT INTO Users
VALUES
('admin','admin123','Admin'),
('arun','user123','User');

INSERT INTO TrainDetails
VALUES
(
101,
'Chennai Express',
'Chennai',
'Bangalore',
'Sleeper',
100,
500,
0
);

INSERT INTO TrainDetails
VALUES
(
102,
'Coimbatore Express',
'Chennai',
'Coimbatore',
'3AC',
50,
1200,
0
);

INSERT INTO TrainDetails
VALUES
(
103,
'Madurai SuperFast',
'Chennai',
'Madurai',
'2AC',
40,
1800,
0
);

CREATE PROCEDURE sp_AddTrain
(
@TrainNo INT,
@TrainName VARCHAR(100),
@FromStation VARCHAR(100),
@ToStation VARCHAR(100),
@TravelClass VARCHAR(20),
@Availability INT,
@Charges DECIMAL(10,2)
)
AS
BEGIN

INSERT INTO TrainDetails
VALUES
(
    @TrainNo,
    @TrainName,
    @FromStation,
    @ToStation,
    @TravelClass,
    @Availability,
    @Charges,
    0
)
END

CREATE PROCEDURE sp_ViewTrains
AS
BEGIN

SELECT *
FROM TrainDetails
WHERE IsDeleted = 0
END

CREATE PROCEDURE sp_SearchTrain
(
@FromStation VARCHAR(100),
@ToStation VARCHAR(100)
)
AS
BEGIN

SELECT *
FROM TrainDetails
WHERE FromStation=@FromStation
AND ToStation=@ToStation
AND IsDeleted=0
END

CREATE PROCEDURE sp_UserLogin
(
@UserName VARCHAR(50),
@Password VARCHAR(50)
)
AS
BEGIN
SELECT COUNT(*)
FROM Users
WHERE UserName=@UserName
AND Password=@Password
END

CREATE PROCEDURE sp_BookTicket
(
@TravelDate DATE,
@TrainNo INT,
@TravelClass VARCHAR(20),
@Passengers INT,
@Amount DECIMAL(10,2)
)
AS
BEGIN

INSERT INTO BookingDetails
(
    TravelDate,
    TrainNo,
    TravelClass,
    Passengers,
    Amount
)

VALUES
(
    @TravelDate,
    @TrainNo,
    @TravelClass,
    @Passengers,
    @Amount
)
END

CREATE PROCEDURE sp_UpdateAvailability
(
@TrainNo INT,
@Passengers INT
)
AS
BEGIN

UPDATE TrainDetails

SET Availability = Availability - @Passengers

WHERE TrainNo=@TrainNo

END

CREATE PROCEDURE sp_CancelTicket
(
@BookingId INT,
@NoTickets INT,
@RefundAmount DECIMAL(10,2)
)
AS
BEGIN

INSERT INTO CancellationDetails
(
    BookingId,
    NoTickets,
    RefundAmount
)

VALUES
(
    @BookingId,
    @NoTickets,
    @RefundAmount
)

END

CREATE PROCEDURE sp_DeleteTrain
(
@TrainNo INT
)
AS
BEGIN

IF EXISTS
(
    SELECT *
    FROM BookingDetails
    WHERE TrainNo=@TrainNo
)

BEGIN
    PRINT 'Bookings Exist. Cannot Delete Train'
END

ELSE

BEGIN

    UPDATE TrainDetails

    SET IsDeleted = 1

    WHERE TrainNo=@TrainNo

END

END

CREATE VIEW vw_BookingDetails
AS

SELECT

B.BookingId,

B.BookDate,

B.TravelDate,

B.TrainNo,

T.TrainName,

B.TravelClass,

B.Passengers,

B.Amount

FROM BookingDetails B

INNER JOIN TrainDetails T
ON B.TrainNo = T.TrainNo;

CREATE PROCEDURE sp_TotalRevenue
AS
BEGIN

SELECT
SUM(Amount) AS TotalRevenue

FROM BookingDetails

END

SELECT *
FROM TrainDetails
WHERE IsDeleted=0;

SELECT *
FROM BookingDetails;

SELECT *
FROM CancellationDetails;

SELECT *
FROM vw_BookingDetails;