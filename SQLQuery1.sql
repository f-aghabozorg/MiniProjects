---------------------------------------------------------------------------
--37

---------------------------------------------------------------------------
--36

---------------------------------------------------------------------------
--35

---------------------------------------------------------------------------
--34


---------------------------------------------------------------------------
--33
alter view dbo.view_PayStudent
as
select  S.FirstName
	   ,S.LastName
	   ,db.Id		 as  DebtId
	   ,db.StudentId as DebtStudentId
	   ,db.SelectionId
	   ,db.TermId	as  DebtTermId
	   ,db.[Value]	as  DebtValue
	   ,P.Id		as  PayId
	   ,P.StudentId as  PayStudentId
	   ,P.TermId    as	PayTermId
	   ,P.PayTypeId
	   ,P.[Value]   as	PayValue
	   ,P.PayTime
	   ,P.Description
	   ,P_O.PayId	as	PayOffId
	   ,P_O.DebtId	as  PayOffDebtId
	   ,P_O.[Value]	as	PayOffValue
from [DB_F.Aghabozorg].[EDU].[Student] s
	 inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
	 inner join [DB_F.Aghabozorg].[ML].[Debt]			db	on db.SelectionId = sct.Id
	 inner join [DB_F.Aghabozorg].[ML].Payoff			P_O on P_O.DebtId = db.Id
	 inner join [DB_F.Aghabozorg].[ML].Pay				P   on P.Id=P_O.PayId

	 select *
	 from dbo.view_PayStudent
---------------------------------------------------------------------------
--32
--temp table
--derived table
--cte

---------------------------------------------------------------------------
--31 solved
select s.FirstName
	   ,s.LastName
	   ,( select count(distinct c.Id)
		  from [DB_F.Aghabozorg].[EDU].[Selection]			 sct
		  inner join [DB_F.Aghabozorg].[EDU].[Unit]			 u   on u.Id=sct.UnitId
		  inner join [DB_F.Aghabozorg].EDU.Teach			 t	 on u.TeachId = t.Id
		  inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh] cr  on t.CourseReshtehid = cr.Id
		  inner join [DB_F.Aghabozorg].[EDU].[Course]		 c	 on c.Id = cr.CourseId
		  where sct.StudentId = s.Id
				and sct.SelectionTypeId = 11) CountCourse
from [DB_F.Aghabozorg].[EDU].[Student] s
---------------------------------------------------------------------------
--30 solved
--add comupted colum to db please
select Month(sct.RegTime)
from [DB_F.Aghabozorg].[EDU].[Selection] sct

---------------------------------------------------------------------------
--29 solved
select  N'مبلغ ' 
		+ cast(P.[Value] as varchar(10))
		+ N'بابت شھریه ترم ' 
		+ cast(P.TermId as varchar(4))
		+ N'توسط دانشجوی '
		+ s.FirstName + ' ' + s.LastName + ' '
		+ N'پرداخت شده است '
from [DB_F.Aghabozorg].[EDU].Student     s
inner join [DB_F.Aghabozorg].ML.Pay		 P		on P.StudentId = s.Id
inner join [DB_F.Aghabozorg].[ML].Payoff PO		on PO.PayId = P.Id
inner join [DB_F.Aghabozorg].[ML].[Debt] D		on D.Id = PO.DebtId
where D.SelectionId is null
---------------------------------------------------------------------------
--28 solved
--select cast('93/07/26' as date)
select year(convert(date,'93/07/26' ,2))%100	yearr
	  ,month(convert(date,'93/07/26' ,2))		monthh
	  ,day(convert(date,'93/07/26' ,2))			dayy

--select format(GETDATE(), 'yyyy/MM/dd-HH:mm:ss', 'fa')

---------------------------------------------------------------------------
--27 solved
select Right('93/07/26',2)		  dayy		--day
	   ,SUBSTRING('93/07/26',4,2) monthh	--month
	   ,Left('93/07/26',2)		  yearr		--year

---------------------------------------------------------------------------
--26 solved
select DATEDIFF ( dd, getdate() , '2025-01-01 00:00:00' ) 

---------------------------------------------------------------------------
--25 solved
select sct.StudentId	 StudentId 
	   ,u.TermId
from [DB_F.Aghabozorg].[EDU].[Student] s
			 inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
			 inner join [DB_F.Aghabozorg].[EDU].[Unit]			u   on u.Id=sct.UnitId
			 where sct.SelectionTypeId = 11
			 group by sct.StudentId,u.TermId
			 having count(sct.UnitId) = (select max(calc_table.CountUnit)
										 from  (select sct.StudentId	     StudentId 
													   ,u.TermId			     TermId
													   ,count(sct.UnitId)	 CountUnit
												from [DB_F.Aghabozorg].[EDU].[Student] s
														inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
														inner join [DB_F.Aghabozorg].[EDU].[Unit]		   u   on u.Id=sct.UnitId
														where sct.SelectionTypeId = 11
														group by sct.StudentId,u.TermId) calc_table)
---------------------------------------------------------------------------
--24 solved
select s.FirstName
	   ,s.LastName
	   ,count(c.Id) CountCourse
from [DB_F.Aghabozorg].[EDU].[Student] s
	 inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
	 inner join [DB_F.Aghabozorg].[EDU].[Unit]			u   on u.Id=sct.UnitId
	 inner join [DB_F.Aghabozorg].EDU.Teach				t	on u.TeachId = t.Id
	 inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh] cr  on t.CourseReshtehid = cr.Id
	 inner join [DB_F.Aghabozorg].[EDU].[Course]		c	on c.Id = cr.CourseId
	 where sct.SelectionTypeId = 11
	 group by s.Id,s.FirstName,s.LastName
	 having count(c.Id) < 3

---------------------------------------------------------------------------
--23 solved
select sct.StudentId, avg(sct.grade)
from [DB_F.Aghabozorg].[EDU].[Student] s
	 inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
	 where sct.SelectionTypeId = 11
	 group by sct.StudentId


---------------------------------------------------------------------------
--22
select c.Name
	   ,db.Value	CourseCost
	   --نمایش پرداخت های دانشجو
from [DB_F.Aghabozorg].[EDU].[Student] s
	inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
	 inner join [DB_F.Aghabozorg].[EDU].[Unit]			u   on u.Id=sct.UnitId
	 inner join [DB_F.Aghabozorg].EDU.Teach				t	on u.TeachId = t.Id
	 inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh] cr  on t.CourseReshtehid = cr.Id
	 inner join [DB_F.Aghabozorg].[EDU].[Course]		c	on c.Id = cr.CourseId
	 inner join [DB_F.Aghabozorg].[ML].[Debt]			db	on db.SelectionId = sct.Id
where u.TermId = s.EnterTermId
	  and sct.SelectionTypeId = 11
	  and s.Id = 2

union all
select N' شهریه ثابت' CourseCost
	  ,t.Price
from [DB_F.Aghabozorg].[EDU].[Student] s
inner join [DB_F.Aghabozorg].[EDU].[Term] t on t.Id = s.EnterTermId
where t.Id = s.EnterTermId

union all
select N'مجموع شهریه ترم' CourseCost
	  ,sum(db.Value)
from [DB_F.Aghabozorg].[EDU].[Student] s
	 inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
	 inner join [DB_F.Aghabozorg].[EDU].[Unit]			u   on u.Id=sct.UnitId
	 inner join [DB_F.Aghabozorg].EDU.Teach				t	on u.TeachId = t.Id
	 inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh] cr  on t.CourseReshtehid = cr.Id
	 inner join [DB_F.Aghabozorg].[EDU].[Course]		c	on c.Id = cr.CourseId
	 inner join [DB_F.Aghabozorg].[ML].[Debt]			db	on db.SelectionId = sct.Id
where u.TermId = s.EnterTermId
	  and sct.SelectionTypeId = 11
	  and s.Id = 2

	  --بدهکاری یا بستانکاری بدون توجه به ترم
select *
from [DB_F.Aghabozorg].[EDU].[Student] s
	 inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
	 inner join [DB_F.Aghabozorg].[ML].[Debt]			db	on db.SelectionId = sct.Id
	 inner join [DB_F.Aghabozorg].[ML].Payoff			P_O on P_O.DebtId = db.Id



---------------------------------------------------------------------------
--21 solved
select c.Name
	   ,sct.Grade
from [DB_F.Aghabozorg].[EDU].[Student] s
	 inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
	 inner join [DB_F.Aghabozorg].[EDU].[Unit]			u   on u.Id = sct.UnitId
	 inner join [DB_F.Aghabozorg].EDU.Teach				t	on u.TeachId = t.Id
	 inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh]	cr	on cr.Id = t.CourseReshtehid
	 inner join [DB_F.Aghabozorg].EDU.Course			c	on c.Id = cr.CourseId
where u.TermId = s.EnterTermId
	  and s.Id = 2
	  and sct.SelectionTypeId = 11
union all
	  select N'معدل کل'
			,avg(sct.Grade)
		from [DB_F.Aghabozorg].[EDU].[Student] s
			inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
			inner join [DB_F.Aghabozorg].[EDU].[Unit]			u   on u.Id = sct.UnitId
			inner join [DB_F.Aghabozorg].EDU.Teach				t	on u.TeachId = t.Id
			inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh]	cr	on cr.Id = t.CourseReshtehid
			inner join [DB_F.Aghabozorg].EDU.Course			c	on c.Id = cr.CourseId
		where u.TermId = s.EnterTermId
			  and s.Id = 2
			  and sct.SelectionTypeId = 11
			  --سوال: اینجا از گروپ بای ترم استفاده نشده موردی نداره؟


---------------------------------------------------------------------------
--20 solved 
select s.[Id]
      ,s.[ReshtehId]
      ,s.[EnterTermId]
      ,IIF(s.[ActiveId] = 1 , N'فعال' , N'غیرفعال') [ActiveId]
      ,s.[StudentCode]
      ,s.[FirstName]
      ,s.[LastName]
	  ,c.Name
	  ,IIF(c.CourseTypeId = 3 , N'عملی' , N'غیرعملی' ) CourseTypeId
	  ,(case 
		when sct.Grade > 17 then 'A'
		when sct.Grade between 15 and 17 then 'B'
		when sct.Grade between 12 and 15 then 'C'
		when sct.Grade < 12 then 'D'
		end)
	  ,u.[TermId] unitTermId
from [DB_F.Aghabozorg].[EDU].[Student] s
	 inner join [DB_F.Aghabozorg].[EDU].[Selection]     sct on sct.StudentId = s.Id
	 inner join [DB_F.Aghabozorg].[EDU].[Unit]			u   on u.Id = sct.UnitId
	 inner join [DB_F.Aghabozorg].EDU.Teach				t	on u.TeachId = t.Id
	 inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh]	cr	on cr.Id = t.CourseReshtehid
	 inner join [DB_F.Aghabozorg].EDU.Course			c	on c.Id = cr.CourseId
where u.TermId = s.EnterTermId
	  and sct.SelectionTypeId = 11
---------------------------------------------------------------------------------------
--15 solved
select te.FirstName,te.LastName
from    [DB_F.Aghabozorg].EDU.Course c
		inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh] cr	on cr.CourseId = c.Id
		inner join [DB_F.Aghabozorg].EDU.Teach  t   on t.CourseReshtehid =  cr.Id
		inner join [DB_F.Aghabozorg].EDU.Teacher te on te.Id = t.TeacherId 
		inner join [DB_F.Aghabozorg].EDU.Unit   u   on u.TeachId = t.Id
where c.Name = N'معماری کامپیوتر'
	  and exists (select *
				  from [DB_F.Aghabozorg].EDU.Course cou
						inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh] c_r	ON c_r.CourseId = cou.Id
						inner join [DB_F.Aghabozorg].EDU.Teach  tch   ON tch.CourseReshtehid =  c_r.Id
						inner join [DB_F.Aghabozorg].EDU.Teacher tee ON tee.Id = tch.TeacherId 
						inner join [DB_F.Aghabozorg].EDU.Unit   un   ON un.TeachId = tch.Id
				  where cou.Name = N'ساختمان داده'
						and un.TermId = u.TermId
						and t.Id = tee.Id)
------------------------------------------------------------------------------------------
--11


------------------------------------------------------------------------------------------
--8

------------------------------------------------------------------------------------------
--7
select *
from [DB_F.Aghabozorg].[EDU].[Student] s
	 --inner join [DB_F.Aghabozorg].[EDU].[Selection] sct		on sct.StudentId = s.Id
	 inner join [DB_F.Aghabozorg].[EDU].[CourseReshteh] cr  on s.ReshtehId = cr.ReshtehId
where s.[ReshtehId] = 1
	  and not exists (select *
					  from [DB_F.Aghabozorg].[EDU].[Selection] sct
					  where sct.Grade < 10)
