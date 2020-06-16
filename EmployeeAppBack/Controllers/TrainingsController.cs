using EmployeeAppBack.Models;
using EmployeeAppBack.Queries;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;

namespace EmployeeAppBack.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class TrainingsController : ControllerBase
    {
        // TODO Get AllFilesForTraining by training Id
        // TODO POST TrainingWithFiles
        // TODO PATCH UpdateTrainingAddNewFile
        // TODO PATCH UpdateTrainingAddExistingTraining
        private readonly Query query;
        private readonly QueryReturn queryReturn;

        public GetTrainings getTrainings;
        public TrainingsByAccount trainingsByAccount;

        public TrainingsController(
            GetTrainings _getTrainings,
            TrainingsByAccount _trainingsByAccount,
            Query query,
            QueryReturn queryReturn
        )
        {
            this.getTrainings = _getTrainings;
            this.trainingsByAccount = _trainingsByAccount;
            this.query = query;
            this.queryReturn = queryReturn;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Training> trainings = getTrainings.Execute();

            return Ok(trainings);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            List<Training> trainings = trainingsByAccount.Execute(id);
            return Ok(trainings);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Training training)
        {
            query.Execute(new AddTraining(training));

            return Ok();
        }

        [HttpGet]
        [Route("files/{id}")]
        public IActionResult GetTrainingFiles(int id)
        {
            List<TrainingFile> files = queryReturn.Execute(new GetTrainingFilesByTraining(id));

            return Ok(files);
        }

        [HttpGet]
        [Route("GetFileLocation")]
        public IActionResult GetFileLocation([FromQuery] string trainingId)
        {
            var file = Request.Form.Files[0];
            var folderName = Path.Combine("Resources", trainingId);
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);
            }
            return Ok(pathToSave);
        }

        [HttpPost, DisableRequestSizeLimit]
        [Route("file")]
        public IActionResult Upload([FromQuery] string trainingId)
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", trainingId);
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}