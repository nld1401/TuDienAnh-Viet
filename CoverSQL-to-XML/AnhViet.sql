CREATE DATABASE AnhViet
USE AnhViet
CREATE TABLE DictData
(
word NTEXT NOT NULL,
mean NTEXT NOT NULL
)
---- đường dẫn tới DictData.txt
BULK INSERT dbo.DictData FROM 'E:\GitHub\TuDienAnh-Viet\TuDienAnh-Viet\CoverSQL-to-XML\DictData.txt' -- đường dẫn tới DictData.txt
WITH 
(
FIELDTERMINATOR = '/', 
ROWTERMINATOR   = '@',
DATAFILETYPE = 'WIDECHAR')
SELECT * FROM dbo.DictData

DROP DATABASE AnhViet
