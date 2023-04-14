namespace _7Net.Aggregate
{
    public class Band
	{
        public Guid BandId { get; set; }
        public string? Name { get; set; }
        public Guid CountryId { get; set; }
        public string? Status { get; set; }
        public DateTime FormedIn { get; set; }
        public DateTime Active { get; set; }
        public string? Description { get; set; }
        public List<Guid>? GenreId { get; set; }
        public List<Guid>? ThemesId { get; set; }
        public string? LastLabel { get; set; }
        public string? imageLogo { get; set; }
        public List<string>? imagesBand { get; set; }
        public List<Discography>? Discography { get; set; }
        public List<Member>? Members { get; set; }
        public List<Interview>? Interviews { get; set; }
        public List<Guid>? SimilarArtists { get; set; }
        public List<Links>? RelatedLinks { get; set; }
        public Guid CreatedId { get; set; }
        public List<Guid>? ModifiedId { get; set; }

    }
}

