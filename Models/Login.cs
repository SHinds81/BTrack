using System.ComponentModel.DataAnnotations;

namespace BTrack.Models

{    
    public class Login
    {
        [Key] public string username { get; set; }
        public string password { get; set; }
    }
}
