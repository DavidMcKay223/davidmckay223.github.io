namespace MyApp.Application.DTOs.NPI
{
    [Serializable]
    public class IdentifierDto
    {
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? Issuer { get; set; }
        public string? IdentifierValue { get; set; }
        public string? State { get; set; }
    }
}
