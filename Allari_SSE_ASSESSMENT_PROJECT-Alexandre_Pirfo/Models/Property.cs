using System.Collections.Generic;

namespace Allari_SSE_ASSESSMENT_PROJECT_Alexandre_Pirfo.Models
{
    public class Property
    {

        public string _id;
        public Owner _owner;
        public string name;
        public string? description;
        public string province;
        public string state;
        public string country;

        public Property(Owner owner, string name, string? description, string province, string state, string country)
        {
            _id = Guid.NewGuid().ToString();
            _owner = owner; ;
            this.name = name;
            this.description = description;
            this.province = province;
            this.state = state;
            this.country = country;
        }
    }
}
