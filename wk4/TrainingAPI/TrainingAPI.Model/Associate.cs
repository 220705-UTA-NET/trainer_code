namespace TrainingAPI.Model
{
    public class Associate
    {
        // Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Batch { get; set; }

        // Constructor

        public Associate() { }

        public Associate(int id, string name, string? batch)
        {
            Id = id;
            Name = name;
            Batch = batch;
        }

        // Methods
    }
}