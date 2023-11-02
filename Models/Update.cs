using System.ComponentModel.DataAnnotations;

namespace BTrack.Models

{   
    public class Update
    {
        [Key] public int bugId { get; set; }
        public int accountId { get; set; }
        public DateTime updateDate { get; set; }
        public string updateDetails { get; set; }
    }
}
