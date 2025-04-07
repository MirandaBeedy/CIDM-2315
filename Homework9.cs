using System;

class Food{
   public static List<Food> food_list = new List<Food>();
   public string food_name = string.Empty;
   public double food_price;

   public Food (string f_name, double f_price){
        food_name = f_name;
        food_price = f_price;
        food_list.Add(this);
   }
}

class Program
{
    static void Main(string[] args)
   {
      Food sandwish = new Food("Sandwich", 6);
      Food burger = new Food("Burger", 7);
      Food drink = new Food("Soda", 8);

      if (Food.food_list.Contains(sandwish)){
         Food.food_list.Remove(burger);
      }
      Food side = new Food("Fries", 3);
      double total = 0;
      foreach(var f in Food.food_list){
         total += f.food_price;
      }
      Console.WriteLine(total);
   }
}
