﻿namespace GeekPizza.Models
{
    public class PizzaMenuItem : BaseDataObject
    {
        string _name = string.Empty;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        string _ingredients = string.Empty;
        public string Ingredients
        {
            get => _ingredients;
            set => SetProperty(ref _ingredients, value);
        }

        int _calories = 0;
        public int Calories
        {
            get => _calories;
            set => SetProperty(ref _calories, value);
        }
    }
}
