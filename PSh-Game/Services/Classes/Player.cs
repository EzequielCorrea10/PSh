using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Classes
{
    public class Player
    {
        private int Id;
        private string NickName;
        private int Score;
        private string Profile_Image;
        private DateTime Creation_Date;

        public Player(int id, string name, string image)
        {
            Id = id;
            NickName = name;
            Profile_Image = image;
            Creation_Date = DateTime.Now;
        }

        public void SetScore(int score)
        {
            Score = score;
        }

    }
}
