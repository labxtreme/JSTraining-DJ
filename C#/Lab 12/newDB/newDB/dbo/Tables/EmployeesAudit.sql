CREATE TABLE [dbo].[EmployeesAudit](
	[AuditID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[EmployeeName] [varchar](50) NULL,
	[EmployeeAddress] [varchar](50) NULL,
	[MonthSalary] [numeric](10, 2) NULL,
	[ModifiedBy] [varchar](120) NULL,
	[ModifiedDate] [datetime] NULL,
	[Operation] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]