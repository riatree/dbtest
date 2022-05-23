using System.ComponentModel.DataAnnotations;

namespace DbTestProj.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Nickname { get; set; }
        public string? Data { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
    }
}
