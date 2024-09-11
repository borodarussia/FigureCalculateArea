SELECT pt.productName, ct.categoryName
FROM productTable pt
LEFT JOIN categoryTable ct ON pt.categoryId = ct.categoryId