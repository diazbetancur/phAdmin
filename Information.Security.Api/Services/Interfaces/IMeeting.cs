using Information.Security.Api.Models.Dto;

namespace Information.Security.Api.Services.Interfaces
{
    public interface IMeeting
    {
        MeetingDto CreateMeeting(string user, MeetingDto meeting);
        MeetingDto AddMeeting(string user, MeetingDto meeting);
        MeetingDto DeleteMeeting(string user, int meetingId);
        MeetingDto UpdateMeeting(string user, MeetingDto meeting);
        IEnumerable<MeetingDto> GetAll();
    }
}
