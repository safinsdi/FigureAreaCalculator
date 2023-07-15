SELECT Products.ProductName, Categories.CategoryName
  FROM Products
  LEFT JOIN Compliance ON Products.ProductID = Compliance.ProductID
  LEFT JOIN Categories ON Categories.CategoryID = Compliance.CategoryID 
    OR Compliance.CategoryID IS NULL;
