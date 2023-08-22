namespace Allari_SSE_ASSESSMENT_PROJECT_Alexandre_Pirfo.Models
{
    public class Owner
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public Owner (string name, string phoneNumber, string email) {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }
}
