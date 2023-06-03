namespace BlogPlatform.Entity
{
    public class BlogEntity
    {
        static private int counter = 0;
        public BlogEntity(string name, string description, string websiteUrl)
        {
            this.name = name;
            this.description = description;
            this.websiteUrl = websiteUrl;
            this.id = counter++;
        }
        private int id;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string name;
        private string description;
        private string websiteUrl;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Description
        {
            get { return description; }
            private set { description = value; }
        }

        public string WebsiteUrl
        {
            get { return websiteUrl; }
            private set { websiteUrl = value; }
        }
    }
}
