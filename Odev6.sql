select Products.ProductName UrunAdi,SUM([Order Details].UnitPrice*Quantity) EldeEdilenToplamGelir 
from Products inner join [Order Details] on Products.productId=[Order Details].ProductId
inner join Orders on Orders.OrderID=[Order Details].OrderID
group by Products.ProductName