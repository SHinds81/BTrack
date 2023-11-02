using System.ComponentModel.DataAnnotations;

namespace BTrack.Models

{
    public class Account
    {
        [Key] public int accountId {  get; set; }
        public string accountName { get; set; }
        public string username { get; set; }
    }
}
