USE LastBD;

CREATE TABLE Users (
UserID INT PRIMARY KEY IDENTITY(1,1) ,
FullName NVARCHAR(255) NOT NULL,
PhoneNumber NVARCHAR(20) NOT NULL,
Login NVARCHAR(50) NOT NULL UNIQUE,
Password NVARCHAR(255) NOT NULL,
SpecialistID INT NOT NULL,
ClientID INT NOT NULL,
FOREIGN KEY (SpecialistID) REFERENCES SpecialistsType(SpecialistID),
FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

CREATE TABLE Clients (
ClientID INT PRIMARY KEY IDENTITY(1,1),
Type NVARCHAR(20) NOT NULL
);

CREATE TABLE Statuses (
StatusID INT PRIMARY KEY IDENTITY(1,1),
StatusName NVARCHAR(50) NOT NULL
);

CREATE TABLE SpecialistsType (
SpecialistID INT PRIMARY KEY IDENTITY(1,1),
Type NVARCHAR(20) NOT NULL
);

CREATE TABLE HomeTech (
homeTechID INT PRIMARY KEY IDENTITY(1,1),
homeTechType NVARCHAR(100) NOT NULL,
homeTechModel NVARCHAR(150) NOT NULL
);

CREATE TABLE Requests (
RequestID INT PRIMARY KEY IDENTITY(1,1),
RequestDate DATETIME NOT NULL,
homeTechID INT NOT NULL,
FaultType NVARCHAR(100) NOT NULL,
UserID INT NOT NULL, 
StatusID INT NOT NULL, 
CompletionDate DATETIME NULL,
SpecialistID INT NOT NULL,
ClientID INT NOT NULL,
FOREIGN KEY (homeTechID) REFERENCES HomeTech(homeTechID),
FOREIGN KEY (SpecialistID) REFERENCES SpecialistsType(SpecialistID),
FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
FOREIGN KEY (StatusID) REFERENCES Statuses(StatusID)
);

CREATE TABLE TechnicianComments (
CommentID INT PRIMARY KEY IDENTITY(1,1),
RequestID INT NOT NULL,
CommentText NVARCHAR(MAX) NOT NULL,
SpecialistID INT NOT NULL,
FOREIGN KEY (SpecialistID) REFERENCES SpecialistsType(SpecialistID),
FOREIGN KEY (RequestID) REFERENCES Requests(RequestID)
);

INSERT INTO Users (FullName, PhoneNumber, Login, Password, SpecialistID, ClientID) VALUES
('Трубин Никита Юрьевич', '89210563128', 'kasoo', 'root', 1, 1),
('Мурашов Андрей Юрьевич', '89535078985', 'murashov123', 'qwerty', 2, 1),
('Степанов Андрей Викторович', '89210673849', 'test1', 'test1', 2, 1),
('Перина Анастасия Денисовна', '89990563748', 'perinaAD', '250519', 3, 1),
('Мажитова Ксения Сергеевна', '89994563847', 'krutiha1234567', '1234567890', 3, 1),
('Семенова Ясмина Марковна', '89994563847', 'login1', 'pass1', 2, 1),
('Баранова Эмилия Марковна', '89994563841', 'login2', 'pass2', 4, 1),
('Егорова Алиса Платоновна', '89994563842', 'login3', 'pass3', 4, 1),
('Титов Максим Иванович', '89994563843', 'login4', 'pass4', 2, 1),
('Иванов Марк Максимович', '89994563844', 'login5', 'pass5', 2, 1);

INSERT INTO Clients (Type) VALUES
('Заказчик');

INSERT INTO Statuses (StatusName) VALUES
('В процессе ремонта'),
('Готова к выдаче'),
('Новая заявка');

INSERT INTO SpecialistsType (Type) VALUES
('Менеджер'),
('Мастер'),
('Оператор'),
('Заказчик');

INSERT INTO HomeTech (homeTechType, homeTechModel) VALUES
('Фен', 'Ладомир ТА112 белый'),
('Тостер', 'Redmond RT-437 черный'),
('Холодильник', 'Indesit DS 316 W белый'),
('Стиральная машина', 'DEXP WM-F610NTMA/WW белый'),
('Мультиварка', 'Redmond RMC-M95 черный'),
('Фен', 'Ладомир ТА113 чёрный'),
('Холодильник', 'Indesit DS 314 W серый');

INSERT INTO Requests (RequestDate, homeTechID, FaultType, UserID, StatusID, CompletionDate, SpecialistID, ClientID) VALUES
('2023-06-06', 1, 'Перестал работать', 2, 1, NULL, 2, 1),
('2023-05-05', 2, 'Перестал работать', 3, 1, NULL, 3, 1),
('2022-07-07', 3, 'Не морозит одна из камер холодильника', 2, 2, '2023-01-01', 2, 1),
('2023-08-02', 4, 'Перестали работать многие режимы стирки', NULL, 3, NULL, NULL, 1),
('2023-08-02', 5, 'Перестала включаться', NULL, 3, NULL, NULL, 1),
('2023-08-02', 1, 'Перестал работать', 2, 2, '2023-08-03', 2, 1),
('2023-07-09', 6, 'Гудит, но не замораживает', 2, 2, '2023-08-03', 2, 1);

INSERT INTO TechnicianComments (RequestID, CommentText, SpecialistID) VALUES
(1, 'Интересная поломка', 2),
(2, 'Очень странно, будем разбираться!', 3),
(3, 'Скорее всего потребуется мотор обдува!', 2),
(4, 'Интересная поломка', 2),
(5, 'Очень странно, будем разбираться!', 3);
