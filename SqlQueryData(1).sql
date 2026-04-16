--1
Select Id, Title, Price 
from Books
where price>300
order by price desc;

select Id, CategoryName from Categories
--2
Insert into Books(Title,Price,CategoryId)
Values ('Clean Code', 600, 1),
('OOP', 230, 2),
('C#', 730, 3);

Insert into Categories(CategoryName)
values ('Програмування'),
('OOP'),
('Мова програмування');

--3
Update Books
set Price = 750
where Id = 1

--4
Select c.CategoryName, b.Title 
from Books b
Inner join Categories c
on b.CategoryId=c.Id

--5
Select CategoryId, COUNT(*) as TotalBooks
from Books
Group by CategoryId

--6
Update Books
Set IsDeleted = 1
where id = 3

SELECT * FROM Books
WHERE IsDeleted = 1;




