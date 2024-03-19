namespace VetDBM.Models
{
    public class Patient
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Owner { get; set; }

        public string Breed { get; set; }

        public DateTime DOB { get; set; }

        public string Description { get; set; }

        public Patient()
        {
               
        }
    }
}
