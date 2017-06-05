using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        public Cat(string age)
        {
            Age = age;
            _health = 5;
            Color = new CatColor();
        } 

        private int _health;
        private string _name;

        public string Age { get; }
        public CatColor Color { get; set; }
        public string Name
        {
            get => _name ?? "У вашей кошки нету имени";
            set
            {
                if (string.IsNullOrEmpty(_name))
                    _name = value;
            }
        }
        public string CurrentColor
        {
            get => _health >= 5 ? CurrentColor = Color.HeathyColor : CurrentColor = Color.SickColor;
            set
            {
                if (_health >= 5)
                    Color.HeathyColor = value;
                else
                    Color.SickColor = value;
            }
        }

        public void Feed()
        {
            _health++;
        }

        public void Punish()
        {
            _health--;
        }
    }
}
