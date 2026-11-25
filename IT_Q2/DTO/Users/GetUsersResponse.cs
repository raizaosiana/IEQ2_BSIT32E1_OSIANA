namespace IEQ2_BSIT32E1_OSIANA.Model.Users
{
    public class GetUsersResponse
    {
        public List<GetUserDto> Users { get; set; }
    }

    public class GetUserDto
    {
        public int Id {get; set; } 

        public string Name {get; set; }

        public string Email {get; set; }
    }
}
