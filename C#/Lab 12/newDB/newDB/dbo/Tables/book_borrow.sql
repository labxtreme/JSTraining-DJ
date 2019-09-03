CREATE TABLE [dbo].[book_borrow](
	[Book_borrow_id] [int] IDENTITY(1,1) NOT NULL,
	[borrow_date] [datetime] NULL,
	[Book_return] [datetime] NULL,
	[Book_id] [int] NULL,
	[isctive] [bit] NULL,
	[student_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Book_borrow_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[book_borrow]  WITH CHECK ADD FOREIGN KEY([Book_id])
REFERENCES [dbo].[book] ([book_id])
GO
ALTER TABLE [dbo].[book_borrow]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([student_id])