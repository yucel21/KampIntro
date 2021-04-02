--Yorum satırı Select Tablolardan istedigimiz kolonları ve verdigimiz isimlerle istedik
--ANSI
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

--Filtreleme
Select * from Customers where City = 'London'
--Case insesitive Büyük küçük harf duyarsız
select * from Products where categoryId=1 or CategoryID=3
select * from Products where categoryId=1 and UnitPrice>=10

--order by sırala(ürün ismine göre sırala)
select * from Products order by CategoryID,ProductName
select * from Products where categoryId=1 order by UnitPrice desc --ascending --descending

--count Saymak
select count(*) from Products

--Group by Gruplayarak sistemden verinin sayısını almak
Select CategoryID,count(*) from Products group by CategoryID
Select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10
--  getir            Products'tan herbir fiyatı 20den fazla CategoryId ye göre grupla sayıları 10 dan az olanlar

--Join : Bir araya getirmek
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryID
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID

--DTO Data Transformation Object diyoruz

Select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID

--müşterilerden olup siparişte olmayan idleri de getir dedik. sonra da sipariş vermeyen müşteriyi bulduk
--Solda olup sağda olmayanları da getir (aynı mantıkla right join de kullanabiliriz)
select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null
