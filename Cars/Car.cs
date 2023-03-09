using System;

namespace Cars
{
    internal class CarClass
    {
        public string Mark;
        public string Model;
        public string Color;
        public string Number;
        public string Arrive;
        public string OnPark;


        public CarClass(string mark = "No mark", string model = "model", string color = "No color", string number = "No number", string arrive = "No arrived", string onparking = "No parking")
        {
            this.Mark = mark;
            this.Model = model;
            this.Color = color;
            this.Number = number;
            this.Arrive = arrive;
            this.OnPark = onparking;
        }
    }
}