namespace LaMiaPizzeriaNew.Models
{
    public class PizzaCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public List<GustiPizza> GustiPizza { get; set; }

   

        public PizzaCategory(string name, string? description)
        {
            Name = name;
            Description = description;
            GustiPizza = new List<GustiPizza>();
        }
    }
}
