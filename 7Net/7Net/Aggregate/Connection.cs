public class Connection
    {
		public Guid Source { get; set; }
		public Guid Destiny {get; set;}
        public Connection(Guid source, Guid destiny)
        {
            Source = source;
            Destiny = destiny;
        }
    }