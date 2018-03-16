namespace Species
{

    public class Pet
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string GetPetInfo()
        {
            return "This pet's properties are: " +
                    $"\n Color: { Color }" +
                    $"\n Name: { Name }" +
                    $"\n Type: { Type }";
        }
    }
}
