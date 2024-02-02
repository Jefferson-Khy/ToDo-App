using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using todoappbackend.Models;

namespace todoappbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoAppController : ControllerBase
    {
        private static List<Note> notes = new List<Note>()
        {
            // Initialize with some dummy data
            new Note { Id = 1, Description = "Sample Task 1" },
            new Note { Id = 2, Description = "Sample Task 2" },
        };

        [HttpGet]
        [Route("GetNotes")]
        public ActionResult<IEnumerable<Note>> GetNotes()
        {
            return Ok(notes);
        }

        [HttpPost]
        [Route("AddNotes")]
        public ActionResult AddNotes([FromBody] NoteDto noteDto)
        {
            var newNote = new Note { Id = notes.Max(n => n.Id) + 1, Description = noteDto.Description };
            notes.Add(newNote);
            return Ok(notes);
        }

        [HttpDelete]
        [Route("DeleteNotes")]
        public ActionResult DeleteNotes(int id)
        {
            var note = notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                notes.Remove(note);
                return Ok(notes);
            }
            return NotFound();
        }

        /* ==================******CODE BELOW FOR USE WITH DATABASE*******===============
        private IConfiguration _configuration ;
        public TodoAppController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetNotes")]
        public JsonResult GetNotes()
        {
            string query = "select * from dbo.Notes";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("todoAppDBCon");
            SqlDataReader myReader;
            using(SqlConnection myCon=new SqlConnection(sqlDatasource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader=myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }

        [HttpPost]
        [Route("AddNotes")]
        public JsonResult AddNotes([FromForm] string newNotes)
        {
            string query = "insert into dbo.Notes values(@newNotes)";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("todoAppDBCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDatasource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@newNotes", newNotes);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Added Successfully");
        }

        [HttpDelete]
        [Route("DeleteNotes")]
        public JsonResult DeleteNotes(int id)
        {
            string query = "delete from dbo.Notes where id=@id";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("todoAppDBCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDatasource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("DELETED Successfully");
        }
        */
    }
}
