select * from Accounts
insert into Accounts(accountname, AccountDescription, AccountLogo) 
values 
('Google', 'Search Online', 'FileName/GoogleLogo'),
('Facebook', 'Social Media Network', 'FileName/FacebookLogo'),
('Softwriters', 'Long Term Care Pharmacy Software', 'FileName/SoftwritersLogo')
select * from trainings where AccountID = 2
select * from trainings
	full outer join TrainingFiles
	on Trainings.TrainingID = trainingFiles.TrainingID
	insert into trainings 
	(accountId, trainingName, TrainingDescription) values
	(2, 'Algebra', 'nEW item added'),
	(2, 'Biology', 'Knowledge Of Fish'),
	(2, 'SQL', 'Basic Queries'),
	(2, 'Trigonometry', 'Trigonometry Level Math'),
		(3, 'Calculus', 'Calculus Level Math'),
	(3, 'Biology', 'Knowledge Of Fish'),
	(3, 'SQL', 'Basic Queries'),
	(3, 'Trigonometry', 'Trigonometry Level Math'),
		(4, 'Calculus', 'Calculus Level Math'),
	(4, 'Biology', 'Knowledge Of Fish'),
	(4, 'SQL', 'Basic Queries'),
	(4, 'Trigonometry', 'Trigonometry Level Math'),
		(5, 'Calculus', 'Calculus Level Math'),
	(5, 'Biology', 'Knowledge Of Fish'),
	(5, 'SQL', 'Basic Queries'),
	(5, 'Trigonometry', 'Trigonometry Level Math')


	select * from trainings
	--get list of files for a specific training
	select * from trainings
	full outer join TrainingFiles
	on Trainings.TrainingID = trainingFiles.TrainingID
	where trainings.trainingId = 2
	order by TrainingFileOrderNo asc

	--get all training names for a company
	select trainingname as TrainingName from trainings where accountid = 1

	--need to have training categories maybe associated tags for the trainings



insert into TrainingFiles
(trainingid, trainingfileorderno, trainingFileDescription, TrainingFilePath)
values
(2, 1, 'how to be a plumber', 'plumbing.pdf')
insert into TrainingFiles
(trainingid, trainingfileorderno, trainingFileDescription, TrainingFilePath)
values
(2, 2, 'basics in plumbing', 'plumbingbasics.pdf')

--compositeTraining bit--
--composed training id'ed by trainingid and TrainingFileOrderNo

insert into TrainingFiles
(trainingid, trainingfileorderno, trainingFileDescription, TrainingFilePath)
values
(2, 3, 'plumb your first toilet', 'firsttoilet.pdf')
insert into TrainingFiles
(trainingid, trainingfileorderno, trainingFileDescription, TrainingFilePath)
values
(2, 4, 'get the sink on', 'plumbsink.pdf')

update trainingfiles
set TrainingFileDescription = 'how to develop software',
TrainingFilePath = 'developsoftware.pdf'
where TrainingID = 1 and TrainingFileOrderNo = 1

insert into trainings (accountId, trainingName, TrainingDescription) values (1, 'engineerplumber', 'sometimes an engineer needs to know plumbing')
						trainingid, 
insert into TrainingFiles (
						trainingfileorderno, 
						trainingFileDescription, 
						TrainingFilePath, 
						iscomposite, 
						compositereftrainingid, 
						compositereffileorderno
						) values (
							4,
							1,
							'start engineer plumbing with some engineering',
							'developsoftware.pdf',
							1,
							1,
							1)


							select trainingfiledescription from Trainings
							full outer join TrainingFiles
	on Trainings.TrainingID = trainingFiles.TrainingID
	where trainings.trainingid = 1 and trainingfiles.TrainingFileOrderNo = 1