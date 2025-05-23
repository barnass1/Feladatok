﻿using FeladatokWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Linq;


namespace FeladatokWebApp.Controllers
{

    //Scaffold-DbContext "Data Source=barnimedve.database.windows.net;Initial Catalog=Feladatok;Persist Security Info=True;User ID=barnimedve;Password=Corvo12345;Encrypt=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context FeladatokDbContext

    [Route("api/tasks")]
    [ApiController]
    public class FeladatController : ControllerBase
    {
        // GET: api/<FeladatController>
        [HttpGet]
        public IActionResult Get()
        {
            using (var dbContext = new FeladatokDbContext())
            {
                var tasks = dbContext.Tasks
                    .Select(task => new
                    {
                        task.Id,
                        task.Title,
                        task.Description,
                        task.DueDate,
                        task.Priority,
                        task.Status,
                        UserName = dbContext.Users
                            .Where(user => user.Id == task.UserId)
                            .Select(user => user.Username)
                            .FirstOrDefault(),
                        UserId = task.UserId
                    })
                    .ToList();

                return Ok(tasks);
            }
        }

        // GET api/<FeladatController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var dbContext = new FeladatokDbContext())
            {
                var task = dbContext.Tasks
                    .Where(t => t.Id == id)
                    .Select(task => new
                    {
                        task.Id,
                        task.Title,
                        task.Description,
                        task.DueDate,
                        task.Priority,
                        task.Status,
                        UserName = dbContext.Users
                            .Where(user => user.Id == task.UserId)
                            .Select(user => user.Username)
                            .FirstOrDefault()
                    })
                    .FirstOrDefault();

                if (task == null)
                {
                    return NotFound();
                }

                return Ok(task);
            }
        }

        // POST api/<FeladatController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Task newTask)
        {
            if (newTask == null)
            {
                return BadRequest("A feladat adatai nem lehetnek üresek.");
            }

            using (var dbContext = new FeladatokDbContext())
            {
                try
                {
                    dbContext.Tasks.Add(newTask);
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Hiba történt a mentés során: {ex.Message}");
                }
            }
            return CreatedAtAction(nameof(Get), new { id = newTask.Id }, newTask);
        }

        // PUT api/<FeladatController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FeladatController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (var dbContext = new FeladatokDbContext())
            {
                var taskToDelete = dbContext.Tasks.Find(id);
                if (taskToDelete == null)
                {
                    return NotFound($"Feladat a következő ID-val nem található: {id}");
                }

                dbContext.Tasks.Remove(taskToDelete);

                try
                {
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Hiba történt a törlés során: {ex.Message}");
                }
            }

            return NoContent();
        }
    }
}
