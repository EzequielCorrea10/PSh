using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public int Score{ get; set; }
        public string ProfileImage { get; set; }

        public Player() { }
        public Player(int? id, string name, string image)
        {
            if (id.HasValue)
            {
                Id= id.Value;
            }
            Nickname = name;
            ProfileImage = image;
        }

        public int SetScore(int score)
        {
            Score = score; 
            return Score;
        }

    }
}
