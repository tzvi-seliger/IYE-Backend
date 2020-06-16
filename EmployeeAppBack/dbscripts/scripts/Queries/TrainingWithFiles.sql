  select * 
  from Trainings a 
  join TrainingFiles b on a.TrainingID = b.TrainingID 
  Where a.TrainingId = 2 
  order by b.TrainingFileOrderNo