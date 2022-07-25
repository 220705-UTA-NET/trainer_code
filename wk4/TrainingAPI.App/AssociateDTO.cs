namespace TrainingAPI.App
{
    class AssociateDTO
    {
        // Fields
        public int id { get; set; }
        public string name { get; set; }
        public string? batch { get; set; }

        // Constructor
        public AssociateDTO()
        {
        }

        public AssociateDTO(int id, string name, string? batch)
        {
            this.id = id;
            this.name = name;
            this.batch = batch;
        }

        // Methods
        public override string ToString()
        {
            return $"{id} {name} {batch}";
        }

    }
}