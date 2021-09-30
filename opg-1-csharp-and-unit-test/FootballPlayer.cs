using System;

namespace opg_1_csharp_and_unit_test
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private double _price;
        private int _shirt_number;
        public FootballPlayer(int id, string name, double price, int shirt_number)
        {
            Id = id;
            Name = name;
            Price = price;
            Shirt_number = shirt_number;
        }
        /// <summary>
        /// Get or Set Id for football player, Id must be an integar
        /// </summary>
        public int Id { get => _id; set => _id = value; }
        /// <summary>
        /// Get or Set name for football player, Name must be atleast 4 characters long
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("Name must be atleast 4 charcters long");
                }
                _name = value;
            }
        }
        /// <summary>
        /// Get or Set price for foolball player, price must be >= 0
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be higher than 0");
                }
                _price = value;

            }
        }
        /// <summary>
        /// Get or Set shirtnumber for football player, shirtnumber must be >=1 and <=100
        /// </summary>
        public int Shirt_number
        {
            get => _shirt_number;
            set
            {
                if (value > 100 || value < 1)
                {
                    throw new ArgumentOutOfRangeException("Shirt number must be between 1 - 100");
                }
                _shirt_number = value;
            }
        }
    }
}
