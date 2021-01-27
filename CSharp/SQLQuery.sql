--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir From Customers

Select * From Customers where City='London'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

--ascending ----->Artan
--descendin ----->Düşen
--CategoryId si 1 olan ürünleri fiyatlarına göre azalayarak sıralayınız.
select*from Products where CategoryID=1 order by UnitPrice desc 

--Toplam Ürüm sayısı
Select count(*) Adet from Products

--CategoryId si 2 olan ürünlerin toplam sayısı
Select count(*) from Products where CategoryID=2

--Group by yapıldığında arka planda her biri için ayrı ayrı tablo oluşturmuş olunur.
Select categoryId, count(*) from Products group by CategoryID

--uNİTpRİCE'İ 20 DEN BÜYÜK OLANLARI CategoryIdye göre grupla ve sayısı 10 san küçük olanları getir
Select categoryId, count(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10

--on durumunda şartında
--Ürünler ile Kategorilerin birleştirilmesini istiyorum.
Select	ProductID, ProductName, UnitPrice , Categories.CategoryName From Products inner join Categories on Products.CategoryID=Categories.CategoryID

--DTO Data ransformation Object

--İnner join bağlantılı olanları getirir
Select * from Products p inner join [Order Details] od on p.ProductId=od.ProductID

--Solda olup sağda olmayanlarıda getir
--Ürünlerde olup OrderDetailste olmayan
Select * from Products p left join [Order Details] od on p.ProductId=od.ProductID

--Solda olup sağda olmayaları getir. Sağda olmayanlar null gelir.
Select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

--ikiden daha fazla  tabloyu join etmek
Select * from Products p inner join [Order Details] od on p.ProductId=od.ProductID inner Join Orders o on o.OrderID=od.OrderID

