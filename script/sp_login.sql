USE [QuestionnaireBank]
GO
/****** Object:  StoredProcedure [dbo].[sp_Answer_getByTop]    Script Date: 26/02/2018 22:34:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_Login]
@User nvarchar(Max),
@Password nvarchar(MAX)
AS
	Begin 
	select * from tb_Teacher where username = @User and [password] = @Password
	End
go


execute sp_Login @User =N'ninh',@Password=N'1234'
