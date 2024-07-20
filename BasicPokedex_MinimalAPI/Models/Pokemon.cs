namespace BasicPokedex_MinimalAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string SecondaryType { get; set; }
        public string Generation { get; set; }
    }
}
