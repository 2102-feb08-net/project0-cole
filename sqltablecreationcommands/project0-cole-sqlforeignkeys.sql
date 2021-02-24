--Commands to link Inventory to Product and Store Location.

ALTER TABLE proj0.Inventory
ADD FOREIGN KEY (ProductId) REFERENCES proj0.Product(Id)

ALTER TABLE proj0.Inventory
ADD FOREIGN KEY (StoreId) REFERENCES proj0.StoreLocation(Id)


--Commands to Link an Orderline with its Order and Product


ALTER TABLE proj0.OrderLine
ADD FOREIGN KEY (OrderId) REFERENCES proj0.Orders(Id)


ALTER TABLE proj0.OrderLine
ADD FOREIGN KEY (ProductId) REFERENCES proj0.Product(Id)


--Commands to link Orders with the Customers that placed them, as

ALTER TABLE proj0.Orders
ADD FOREIGN KEY (CustomerId) REFERENCES proj0.Customer(Id)

ALTER TABLE proj0.Orders
ADD FOREIGN KEY (StoreLocationId) REFERENCES proj0.StoreLocation(Id)




