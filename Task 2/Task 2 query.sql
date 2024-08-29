SELECT *
FROM dbo.Product
LEFT JOIN dbo.ProductCategory on dbo.Product.Id = dbo.ProductCategory.ProductId
LEFT JOIN dbo.Category on dbo.Category.Id = dbo.ProductCategory.CategoryId