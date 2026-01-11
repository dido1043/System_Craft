SELECT TOP (1000) [Id]
      ,[Name]
      ,[Price]
      ,[Description]
      ,[Brand]
      ,[Model]
      ,[Processor]
      ,[RAM]
      ,[Storage]
      ,[StorageType]
      ,[OperatingSystem]
      ,[CaseType]
      ,[GraphicsCard]
      ,[USBPorts]
      ,[HasHDMI]
      ,[HasEthernet]
      ,[HasWiFi]
      ,[PowerSupply]
      ,[Warranty]
      ,[ReleaseDate]
      ,[Rating]
      ,[InStock]
      ,[StockQuantity]
  FROM [SystemCraftDb].[dbo].[Computers]


  insert into Computers 
  values ('Gaming Beast', 1499.99, 'High-performance gaming laptop with advanced cooling system', 'GamerTech', 'GTX-5000', 'Intel i9-11900K', 32, 1, 'SSD', 'Windows 11', 'Laptop', 'NVIDIA RTX 3080', 4, 1, 1, 1, '750W', 3, '2022-11-15', 4.8, 1, 25),
         ('GAMING-PC', 1299.99, 'Sleek and lightweight ultrabook for professionals on the go', 'UltraTech', 'UBP-2022', 'Intel i7-1165G7', 16, 512, 'SSD', 'Windows 11', 'Ultrabook', 'Integrated Graphics', 3, 1, 1, 1, '65W', 2, '2022-09-10', 4.5, 1, 40),
         ('Budget Buddy', 499.99, 'Affordable desktop computer for everyday tasks', 'EconoComp', 'EB-1000', 'AMD Ryzen 3 3200G', 8, 1, 'HDD', 'Windows 10', 'Desktop', 'Integrated Graphics', 2, 0, 1, 1, '300W', 1, '2021-06-20', 4.0, 1, 100);