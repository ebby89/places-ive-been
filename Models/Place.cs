using System.Collections.Generic;

namespace PlacesWebsite.Models
{
    public class Place
    {
        private static List<Place> _instances = new List<Place>(){};
        public string Name {get; private set;}
        public string ImageURL {get; private set;}
        public int Id {get; private set;}

        public Place(string name, string imageURL)
        {
            Id = _instances.Count;
            Name = name;
            ImageURL = imageURL;
            _instances.Add(this);
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public static Place Find(int id)
        {
            return _instances[id];
        }
    }
}
