using System.ComponentModel.DataAnnotations;

namespace BlogPlatform
{

    public interface IBlogInput
    {

        public string name { get; }


        public string description { get; }


        public string websiteUrl { get; }
    }

    public interface IBlog : IBlogInput
    {
        public int id { get; }
    }

}