using _7Net.Enums;

public class Connection
    {
		public Guid Source { get; }
		public Guid Destiny {get;}
        public PropertiesEnum GenreEnum { get;}
        public Connection(Guid source, Guid destiny, PropertiesEnum genre)
        {
            Source = source;
            Destiny = destiny;
            GenreEnum = genre;
        }
    }