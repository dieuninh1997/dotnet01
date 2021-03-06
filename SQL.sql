USE [QuestionnaireBank]
GO
/****** Object:  StoredProcedure [dbo].[sp_Answer_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Answer_Delete]
	@id int
AS
	BEGIN
		DELETE FROM tb_Answer WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Answer_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Answer_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop='100 percent'
		END
	Select @SQL= 'SELECT top'+ @strTop +'* FROM [tb_Answer]'
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + 'Where' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +'Order by'+@Order
		END
	EXEC(@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_Answer_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Answer_Insert]
	@questionID int,
	@answer ntext,
	@isCorrect int
AS
	BEGIN
		INSERT INTO tb_Answer VALUES (@questionID,@answer,@isCorrect)
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_Answer_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Answer_Update]
	@id int,
	@questionID int,
	@answer ntext,
	@isCorrect int
AS
	BEGIN
		UPDATE tb_Answer SET
		questionID=@questionID,
		answer=@answer,
		isCorrect=@isCorrect
	WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Class_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Class_Delete]
	@id int
AS
	BEGIN
		DELETE FROM tb_Class WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Class_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Class_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop=' 100 percent '
		END
	Select @SQL= ' SELECT top '+ @strTop +' tb_Class.*,(select [facultyName] from tb_Faculty where facultyID = tb_Faculty.id) as ''facultyName'' FROM [tb_Class] '
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' Where ' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +' Order by '+@Order
		END
	EXEC(@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_Class_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Class_Insert]
	@className nvarchar(50),
	@facultyID int
AS
	BEGIN
		INSERT INTO tb_Class VALUES (@className,@facultyID)
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Class_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Class_Update]
	@id int,
	@className nvarchar(50),
	@facultyID int
AS
	BEGIN
		UPDATE tb_Class SET
		className=@className,
		facultyID=@facultyID
	WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Faculty_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Faculty_Delete]
	@id int
AS
	BEGIN
		DELETE FROM tb_Faculty WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Faculty_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Faculty_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop=' 100 percent '
		END
	Select @SQL= 'SELECT top '+ @strTop +' * FROM [tb_Faculty]'
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' Where ' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +' Order by '+@Order
		END
	EXEC(@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_Faculty_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Faculty_Insert]
	@facultyName nvarchar(50)
AS
	BEGIN
		INSERT INTO tb_Faculty VALUES (@facultyName)
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Faculty_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Faculty_Update]
	@id int,
	@facultyName nvarchar(50)
AS
	BEGIN
		UPDATE tb_Faculty SET
		facultyName=@facultyName
	WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Question_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Question_Delete]
	@id int
AS
	BEGIN
		DELETE FROM tb_Question WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Question_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Question_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop=' 100 percent '
		END
	Select @SQL= 'SELECT top '+ @strTop +' * FROM [tb_Question]'
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' Where ' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +' Order by '+@Order
		END
	EXEC(@SQL)

GO
/****** Object:  StoredProcedure [dbo].[sp_Question_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Question_Insert]
	@subjectID int,
	@topicID int,
	@levelID int,
	@content ntext,
	@reuse int,
	@createDate date
AS
	BEGIN
		INSERT INTO tb_Question VALUES (@subjectID,@topicID,@levelID,@content,@reuse,@createDate)
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_Question_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Question_Update]
	@id int,
	@subjectID int,
	@topicID int,
	@levelID int,
	@content ntext,
	@reuse int,
	@createDate date
AS
	BEGIN
		UPDATE tb_Question SET
		subjectID=@subjectID,
		topicID=@topicID,
		levelID=@levelID,
		reuse=@reuse,
		content = @content,
		createDate=@createDate
	WHERE id=@id
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_Student_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Student_Delete]
	@id int
AS
	BEGIN
		DELETE FROM tb_Student WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Student_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Student_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop=' 100 percent '
		END
	Select @SQL= 'SELECT top'+ @strTop +' * FROM tb_Student, tb_Class where tb_Student.classID=tb_Class.id '
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' ' + @Where
			--Select @SQL= @SQL + 'Where' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +'Order by'+@Order
		END
	EXEC(@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_Student_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Student_Insert]
	@fullname nvarchar(50),
	@username varchar(50),
	@password varchar(50),
	@classID int,
	@status nvarchar(200)
AS
	BEGIN
		INSERT INTO tb_Student VALUES (@fullname,@username,@password,@classID,@status)
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_Student_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Student_Update]
	@id int,
	@fullname nvarchar(50),
	@username varchar(50),
	@password varchar(50),
	@classID int,
	@status nvarchar(200)
AS
	BEGIN
		UPDATE tb_Student SET
		fullname=@fullname,
		username=@username,
		password=@password,
		classID=@classID,
		status=@status
	WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentExam_Delet]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_StudentExam_Delet]
	@id int
AS
	BEGIN
		DELETE FROM tb_Student_Exam WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentExam_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_StudentExam_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop='100 percent '
		END
	Select @SQL= 'SELECT top '+ @strTop +' * FROM tb_Student_Exam'
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' Where ' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +' Order by '+@Order
		END
	EXEC(@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentExam_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_StudentExam_Insert]
	@examID int,
	@studentID int,
	@flag int,
	@startTime datetime
AS
	BEGIN
		INSERT INTO tb_Student_Exam VALUES (@examID,@studentID,@flag,@startTime)
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_Subject_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Subject_Delete]
	@id int
AS
	BEGIN try
	if not exists (select * from tb_Topic where subjectID=@id)
	begin
		DELETE FROM tb_Subject WHERE id=@id
	END
	end try
	begin catch

	end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_Subject_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Subject_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop=' 100 percent '
		END
	Select @SQL= 'SELECT top '+ @strTop +' * FROM [tb_Subject]'
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' Where ' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +' Order by '+@Order
		END
	EXEC(@SQL)

GO
/****** Object:  StoredProcedure [dbo].[sp_Subject_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Subject_Insert]
	@subjectName nvarchar(50),
	@facultyID int
AS
	BEGIN
		INSERT INTO tb_Subject (subjectName, facultyID) VALUES (@subjectName,@facultyID)
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Subject_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Subject_Update]
	@id int,
	@subjectName nvarchar(50),
	@facultyID int
AS
	BEGIN
		UPDATE tb_Subject SET
		subjectName=@subjectName,
		facultyID=@facultyID
	WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_SubQuestion_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SubQuestion_Delete]
	@id int
AS
	BEGIN
		DELETE FROM tb_SubQuestion WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_SubQuestion_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SubQuestion_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop=' 100 percent '
		END
	Select @SQL= 'SELECT top '+ @strTop +' * FROM [tb_SubQuestion]'
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' Where ' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +' Order by '+@Order
		END
	EXEC(@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_SubQuestion_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SubQuestion_Insert]
	@questionID int,
	@content ntext,
	@reportCount int,
	@active bit
AS
	BEGIN
		INSERT INTO tb_SubQuestion VALUES (@questionID,@content,@reportCount,@active)
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_SubQuestion_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SubQuestion_Update]
	@id int,
	@questionID int,
	@content ntext,
	@reportCount int,
	@active bit
AS
	BEGIN
		UPDATE tb_SubQuestion SET
		questionID=@questionID,
		content=@content,
		reportCount=@reportCount,
		active=@active
	WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Teacher_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Teacher_Delete]
	@id int
AS
	BEGIN
		DELETE FROM tb_Teacher WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Teacher_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Teacher_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop=' 100 percent '
		END
	Select @SQL= 'SELECT top'+ @strTop +'* FROM [tb_Teacher]'
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' Where ' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +' Order by '+@Order
		END
	EXEC(@SQL)


GO
/****** Object:  StoredProcedure [dbo].[sp_Teacher_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Teacher_Insert]
	@name nvarchar(50),
	@username varchar(50),
	@password varchar(50),
	@avatar text
AS
	BEGIN
		INSERT INTO tb_Teacher VALUES (@name,@username,@password,@avatar)
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_Teacher_LoginValid]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Teacher_LoginValid]
	@username varchar(50),
	@password varchar(50)
AS
BEGIN
	select count(*) from tb_Teacher where username = @username and password = @password
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Teacher_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Teacher_Update]
	@id int,
	@name nvarchar(50),
	@username varchar(50),
	@password varchar(50),
	@avatar text
AS
	BEGIN
		UPDATE tb_Teacher SET
		name=@name,
		username=@username,
		password=@password,
		avatar=@avatar
	WHERE id=@id
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_Delete]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_Topic_Delete]
	@id int
AS
	begin
		DELETE FROM tb_Topic WHERE id=@id
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_getByTop]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_Topic_getByTop]
@Top nvarchar(10),
@Where nvarchar(MAX),
@Order nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop='('+ @Top +')'
	if len(@Top)=0
		BEGIN
			Select @strTop=' 100 percent '
		END
	Select @SQL= 'SELECT top '+ @strTop +' * FROM [tb_Topic]'
	if len(@Where)>0
		BEGIN
			Select @SQL= @SQL + ' Where ' + @Where
		END
	if len(@Order)>0
		BEGIN
			Select @SQL=@SQL +' Order by '+@Order
		END
	EXEC(@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_Insert]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_Topic_Insert]
	@topicName nvarchar(200),
	@subjectID int
AS
	BEGIN
		INSERT INTO tb_Topic(topicName, subjectID) VALUES (@topicName,@subjectID)
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_Update]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_Topic_Update]
	@id int,
	@topicName nvarchar(50),
	@subjectID int
AS
	BEGIN
		UPDATE tb_Topic SET
		topicName=@topicName,
		subjectID=@subjectID
	WHERE id=@id
	END
GO
/****** Object:  Table [dbo].[tb_Answer]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Answer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[questionID] [int] NULL,
	[answer] [ntext] NULL,
	[isCorrect] [bit] NULL,
 CONSTRAINT [PK_tb_Answer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Class]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Class](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[className] [nvarchar](50) NULL,
	[facultyID] [int] NULL,
 CONSTRAINT [PK_tb_Class] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Faculty]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Faculty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[facultyName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Faculty] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Image]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Image](
	[id] [int] NOT NULL,
	[url] [ntext] NULL,
	[questionID] [int] NULL,
	[alt] [ntext] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Level]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Level](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[levelName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Level] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Question]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Question](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subjectID] [int] NULL,
	[topicID] [int] NULL,
	[levelID] [int] NULL,
	[content] [ntext] NULL,
	[reuse] [int] NULL CONSTRAINT [DF_tb_Question_reuse]  DEFAULT ((0)),
	[createDate] [datetime] NULL CONSTRAINT [DF_tb_Question_createDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_tb_Question] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Quiz]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Quiz](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subjectID] [int] NULL,
	[quizName] [nvarchar](50) NULL,
	[questionCount] [int] NULL,
	[timeStart] [time](7) NULL,
	[time] [text] NULL,
	[questionList] [text] NULL,
	[teacherID] [int] NULL,
 CONSTRAINT [PK_tb_Quiz] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Result]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Result](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[studentID] [int] NULL,
	[quizID] [int] NULL,
	[score] [int] NULL,
	[quizDate] [date] NULL,
	[flag] [int] NULL,
 CONSTRAINT [PK_tb_Result] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Student]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_Student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [nvarchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[classID] [int] NULL,
	[status] [nvarchar](200) NULL,
 CONSTRAINT [PK_tb_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_Subject]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Subject](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subjectName] [nvarchar](50) NULL,
	[facultyID] [int] NULL,
 CONSTRAINT [PK_tb_Subject] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_SubQuestion]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_SubQuestion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[questionID] [int] NULL,
	[content] [ntext] NULL,
	[reportCount] [int] NULL,
	[active] [bit] NULL,
 CONSTRAINT [PK_tb_SubQuestion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Teacher]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_Teacher](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[avatar] [text] NULL,
 CONSTRAINT [PK_tb_Teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_Topic]    Script Date: 2/24/2018 8:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Topic](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[topicName] [nvarchar](200) NULL,
	[subjectID] [int] NULL,
 CONSTRAINT [PK_tb_Topic] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tb_Class] ON 

INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (1, N'D10CNPM', 1)
INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (2, N'D10TMDT', 1)
INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (3, N'D10QTANM', 1)
INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (4, N'D10QLNL1', 5)
INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (5, N'D10QLNL2', 5)
INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (6, N'D10CODT', 2)
INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (7, N'D9CODT', 2)
INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (8, N'D10QTDN1', 6)
INSERT [dbo].[tb_Class] ([id], [className], [facultyID]) VALUES (9, N'D10QTDN2', 6)
SET IDENTITY_INSERT [dbo].[tb_Class] OFF
SET IDENTITY_INSERT [dbo].[tb_Faculty] ON 

INSERT [dbo].[tb_Faculty] ([id], [facultyName]) VALUES (1, N'Công nghệ thông tin')
INSERT [dbo].[tb_Faculty] ([id], [facultyName]) VALUES (2, N'Cơ khí')
INSERT [dbo].[tb_Faculty] ([id], [facultyName]) VALUES (3, N'Điện hạt nhân')
INSERT [dbo].[tb_Faculty] ([id], [facultyName]) VALUES (4, N'Điện tử viễn thông')
INSERT [dbo].[tb_Faculty] ([id], [facultyName]) VALUES (5, N'Quản lý năng lượng')
INSERT [dbo].[tb_Faculty] ([id], [facultyName]) VALUES (6, N'Tài chính kế toán')
SET IDENTITY_INSERT [dbo].[tb_Faculty] OFF
SET IDENTITY_INSERT [dbo].[tb_Level] ON 

INSERT [dbo].[tb_Level] ([id], [levelName]) VALUES (1, N'easy')
INSERT [dbo].[tb_Level] ([id], [levelName]) VALUES (2, N'basic')
INSERT [dbo].[tb_Level] ([id], [levelName]) VALUES (3, N'advanced')
SET IDENTITY_INSERT [dbo].[tb_Level] OFF
SET IDENTITY_INSERT [dbo].[tb_Question] ON 

INSERT [dbo].[tb_Question] ([id], [subjectID], [topicID], [levelID], [content], [reuse], [createDate]) VALUES (3, 1, 22, NULL, N'ABC là gì?', 0, CAST(N'2018-02-24 17:12:07.067' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_Question] OFF
SET IDENTITY_INSERT [dbo].[tb_Student] ON 

INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (1, N'Đinh Văn Đông', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (2, N'Trần Thị Diệu Ninh', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (3, N'Trịnh Đức Dương', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (4, N'Phạm Xuân Duy', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (5, N'Nguyễn Văn Dương', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (6, N'Bùi Thị Hải Vân', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (7, N'Nguyễn Thu Hà', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (8, N'Đào Văn Hiệp', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (9, N'Nguyễn Ngọc An', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (10, N'Nguyễn Hồng Cẩm', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (11, N'Nguyễn Thị Hồng Ngọc', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (12, N'Đặng Thị Thúy', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (13, N'Nguyễn Văn Tú', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (14, N'Nguyễn Thành Đạt', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (15, N'Nguyễn Văn Cường', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (16, N'Trịnh Thị Lệ', NULL, NULL, 1, NULL)
INSERT [dbo].[tb_Student] ([id], [fullname], [username], [password], [classID], [status]) VALUES (17, N'Lương Văn Tiến', NULL, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[tb_Student] OFF
SET IDENTITY_INSERT [dbo].[tb_Subject] ON 

INSERT [dbo].[tb_Subject] ([id], [subjectName], [facultyID]) VALUES (1, N'Mạng máy tính', 1)
INSERT [dbo].[tb_Subject] ([id], [subjectName], [facultyID]) VALUES (2, N'Tiếng anh 1', 1)
INSERT [dbo].[tb_Subject] ([id], [subjectName], [facultyID]) VALUES (3, N'Tiếng anh chuyên ngành', 2)
INSERT [dbo].[tb_Subject] ([id], [subjectName], [facultyID]) VALUES (4, N'Kỹ thuật điện đại cương', 5)
INSERT [dbo].[tb_Subject] ([id], [subjectName], [facultyID]) VALUES (5, N'Toán rời rạc', 1)
SET IDENTITY_INSERT [dbo].[tb_Subject] OFF
SET IDENTITY_INSERT [dbo].[tb_Teacher] ON 

INSERT [dbo].[tb_Teacher] ([id], [name], [username], [password], [avatar]) VALUES (1, N'Trần Thị Diệu Ninh', N'ninh', N'ninh', N'C:\Users\Admin\Downloads\ninh.jpg')
INSERT [dbo].[tb_Teacher] ([id], [name], [username], [password], [avatar]) VALUES (2, N'Đinh Văn Đông', N'dong', N'dong', N'C:\Users\Admin\Downloads\dong.jpg')
SET IDENTITY_INSERT [dbo].[tb_Teacher] OFF
SET IDENTITY_INSERT [dbo].[tb_Topic] ON 

INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (7, N'Chương 2: Tầng ứng dụng trong TCP/IP', 1)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (9, N'Topic 3', 1)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (10, N'Topic 4', 1)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (11, N'Topic 1', 2)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (12, N'Topic 2', 2)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (13, N'Topic 3', 2)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (14, N'Topic 4', 2)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (15, N'Topic 1', 3)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (16, N'Topic 2', 3)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (17, N'Topic 3', 3)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (18, N'Topic 1', 4)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (19, N'Topic 2', 4)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (20, N'Topic 3', 4)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (21, N'Topic 4', 4)
INSERT [dbo].[tb_Topic] ([id], [topicName], [subjectID]) VALUES (22, N'Chương 1: Tổng quan về mạng máy tính', 1)
SET IDENTITY_INSERT [dbo].[tb_Topic] OFF
ALTER TABLE [dbo].[tb_Answer] ADD  CONSTRAINT [DF_tb_Answer_isCorrect]  DEFAULT ((0)) FOR [isCorrect]
GO
ALTER TABLE [dbo].[tb_Result] ADD  CONSTRAINT [DF_tb_Result_quizDate]  DEFAULT (getdate()) FOR [quizDate]
GO
ALTER TABLE [dbo].[tb_Result] ADD  CONSTRAINT [DF_tb_Result_flag]  DEFAULT ((1)) FOR [flag]
GO
ALTER TABLE [dbo].[tb_SubQuestion] ADD  CONSTRAINT [DF_tb_SubQuestion_reportCount]  DEFAULT ((0)) FOR [reportCount]
GO
ALTER TABLE [dbo].[tb_SubQuestion] ADD  CONSTRAINT [DF_tb_SubQuestion_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[tb_Answer]  WITH CHECK ADD  CONSTRAINT [FK_tb_Answer_tb_Question] FOREIGN KEY([questionID])
REFERENCES [dbo].[tb_Question] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Answer] CHECK CONSTRAINT [FK_tb_Answer_tb_Question]
GO
ALTER TABLE [dbo].[tb_Answer]  WITH CHECK ADD  CONSTRAINT [FK_tb_Answer_tb_SubQuestion] FOREIGN KEY([questionID])
REFERENCES [dbo].[tb_SubQuestion] ([id])
GO
ALTER TABLE [dbo].[tb_Answer] CHECK CONSTRAINT [FK_tb_Answer_tb_SubQuestion]
GO
ALTER TABLE [dbo].[tb_Class]  WITH CHECK ADD  CONSTRAINT [FK_tb_Class_tb_Faculty] FOREIGN KEY([facultyID])
REFERENCES [dbo].[tb_Faculty] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Class] CHECK CONSTRAINT [FK_tb_Class_tb_Faculty]
GO
ALTER TABLE [dbo].[tb_Image]  WITH CHECK ADD  CONSTRAINT [FK_tb_Image_tb_Question] FOREIGN KEY([questionID])
REFERENCES [dbo].[tb_Question] ([id])
GO
ALTER TABLE [dbo].[tb_Image] CHECK CONSTRAINT [FK_tb_Image_tb_Question]
GO
ALTER TABLE [dbo].[tb_Image]  WITH CHECK ADD  CONSTRAINT [FK_tb_Image_tb_Question1] FOREIGN KEY([questionID])
REFERENCES [dbo].[tb_Question] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Image] CHECK CONSTRAINT [FK_tb_Image_tb_Question1]
GO
ALTER TABLE [dbo].[tb_Question]  WITH CHECK ADD  CONSTRAINT [FK_tb_Question_tb_Level] FOREIGN KEY([levelID])
REFERENCES [dbo].[tb_Level] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Question] CHECK CONSTRAINT [FK_tb_Question_tb_Level]
GO
ALTER TABLE [dbo].[tb_Question]  WITH CHECK ADD  CONSTRAINT [FK_tb_Question_tb_Subject] FOREIGN KEY([subjectID])
REFERENCES [dbo].[tb_Subject] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Question] CHECK CONSTRAINT [FK_tb_Question_tb_Subject]
GO
ALTER TABLE [dbo].[tb_Question]  WITH CHECK ADD  CONSTRAINT [FK_tb_Question_tb_Topic] FOREIGN KEY([topicID])
REFERENCES [dbo].[tb_Topic] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Question] CHECK CONSTRAINT [FK_tb_Question_tb_Topic]
GO
ALTER TABLE [dbo].[tb_Quiz]  WITH CHECK ADD  CONSTRAINT [FK_tb_Quiz_tb_Subject] FOREIGN KEY([subjectID])
REFERENCES [dbo].[tb_Subject] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Quiz] CHECK CONSTRAINT [FK_tb_Quiz_tb_Subject]
GO
ALTER TABLE [dbo].[tb_Quiz]  WITH CHECK ADD  CONSTRAINT [FK_tb_Quiz_tb_Teacher] FOREIGN KEY([teacherID])
REFERENCES [dbo].[tb_Teacher] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Quiz] CHECK CONSTRAINT [FK_tb_Quiz_tb_Teacher]
GO
ALTER TABLE [dbo].[tb_Result]  WITH CHECK ADD  CONSTRAINT [FK_tb_Result_tb_Quiz] FOREIGN KEY([quizID])
REFERENCES [dbo].[tb_Quiz] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Result] CHECK CONSTRAINT [FK_tb_Result_tb_Quiz]
GO
ALTER TABLE [dbo].[tb_Result]  WITH CHECK ADD  CONSTRAINT [FK_tb_Result_tb_Student] FOREIGN KEY([studentID])
REFERENCES [dbo].[tb_Student] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Result] CHECK CONSTRAINT [FK_tb_Result_tb_Student]
GO
ALTER TABLE [dbo].[tb_Student]  WITH CHECK ADD  CONSTRAINT [FK_tb_Student_tb_Class] FOREIGN KEY([classID])
REFERENCES [dbo].[tb_Class] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Student] CHECK CONSTRAINT [FK_tb_Student_tb_Class]
GO
ALTER TABLE [dbo].[tb_Subject]  WITH CHECK ADD  CONSTRAINT [FK_tb_Subject_tb_Faculty] FOREIGN KEY([facultyID])
REFERENCES [dbo].[tb_Faculty] ([id])
GO
ALTER TABLE [dbo].[tb_Subject] CHECK CONSTRAINT [FK_tb_Subject_tb_Faculty]
GO
ALTER TABLE [dbo].[tb_SubQuestion]  WITH CHECK ADD  CONSTRAINT [FK_tb_SubQuestion_tb_Question] FOREIGN KEY([questionID])
REFERENCES [dbo].[tb_Question] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_SubQuestion] CHECK CONSTRAINT [FK_tb_SubQuestion_tb_Question]
GO
ALTER TABLE [dbo].[tb_Topic]  WITH CHECK ADD  CONSTRAINT [FK_tb_Topic_tb_Subject] FOREIGN KEY([subjectID])
REFERENCES [dbo].[tb_Subject] ([id])
GO
ALTER TABLE [dbo].[tb_Topic] CHECK CONSTRAINT [FK_tb_Topic_tb_Subject]
GO
