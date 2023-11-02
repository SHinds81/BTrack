namespace BTrack.Models

{   
    public class Update
    {
        public int bugId {  get; set; }
        public int accountId { get; set; }
        public DateTime updateDate { get; set; }
        public string updateDetails { get; set; }
    }
}
