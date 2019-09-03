CREATE procedure [dbo].[spGetAgeandName] @Age Int, @Fname varchar(50),@Lname varchar(50)
As
select ps.AGE, ps.Firstname+' '+ps.Lastname as NAME
From persons as ps
where ps.Age=@Age and ps.Firstname=@Fname and ps.Lastname=@Lname