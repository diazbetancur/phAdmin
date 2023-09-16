namespace Information.Security.Api.Models.Entities
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Site { get; set; }
        public string DateMeeting { get; set; }   
        public bool IsModified { get; set; }
        public string DateModified { get; set; }
    }
}
