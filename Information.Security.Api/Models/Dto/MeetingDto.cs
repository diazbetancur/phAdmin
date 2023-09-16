namespace Information.Security.Api.Models.Dto
{
    public class MeetingDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Site { get; set; }
        public string DateMeeting { get; set; }
        public bool IsDeleted { get; set; }
    }
}
