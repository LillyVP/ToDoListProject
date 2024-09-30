CREATE TABLE Tasks (
    TaskID INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Description TEXT,
    DueDate DATETIME,
    Priority TEXT,
    IsCompleted BOOLEAN
);
