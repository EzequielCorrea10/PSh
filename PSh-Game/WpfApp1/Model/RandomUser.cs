using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.Services.RandomizeService;

namespace WpfApp1.Model
{
    public class RandomUserResponse
    {
        public List<RandomUser> Results { get; set; }
    }

    public class RandomUser
    {
        public Name Name { get; set; }
        public Picture Picture { get; set; }
    }

    public class Name
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class Picture
    {
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }
}
