Create view [dbo].[vOrders]
with Schemabinding
As
SELECT OrderDate, Sum(od.OrderNumber) as OrderSum, COUNT_BIG(*) AS COUNT
from dbo.Orders AS od, dbo.OrderHistory as o
where od.OrderID=o.OrderID
group by OrderDate;
GO
/****** Object:  Index [IDX_V1]    Script Date: 8/31/2019 12:38:18 PM ******/
CREATE UNIQUE CLUSTERED INDEX [IDX_V1] ON [dbo].[vOrders]
(
	[OrderDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]