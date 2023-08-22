namespace Allari_SSE_ASSESSMENT_PROJECT_Alexandre_Pirfo.Models
{
    public class PropertiesList
    {
        public List<Property> GeerateDefaultProperties()
        {
            Owner owner1 = new Owner("Jhon", "9999-9999", "jhon@gmail.com");
            Owner owner2 = new Owner("Jack", "8888-8888", "jack@gmail.com");

            List<Property> defaultPropertiesList = new List<Property>();

            for (int i = 0; i < 10; i++)
            {
                defaultPropertiesList.Add(new Property(owner2, "Farm" + (i + 1), null, "Orlando", "Florida", "USA"));
            }
            return defaultPropertiesList;
        }
    }
}
