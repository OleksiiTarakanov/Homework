Create trigger StudentsCounterOne
on Users
after insert, update, delete
as
declare @tab table (UpdatedCount int, SchoolId int)
insert into @tab (UpdatedCount, SchoolId)
select Count(SchoolId),SchoolId
from Users 
group by SchoolId
update Schools
set Schools.Count = (Select UpdatedCount from @tab as tab where Schools.Id = tab.SchoolId)

