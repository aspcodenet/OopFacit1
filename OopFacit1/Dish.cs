namespace OopFacit1;

public enum DishType
{
    Vegetarian,
    Vegan,
    Meat
}

public class Dish
{
    private string name;
    private int price;
    private DishType dishType;
    private int calories;

    public Dish(string name, int price, int calories, DishType dishType)
    {
        this.name = name;
        this.price = price;
        this.calories = calories;
        this.dishType = dishType;
    }

    public string Name { get { return name; } }
    public DishType DishType
    {
        get { return dishType; }
    }

    public int Calories
    {
        get { return calories; }
    }

    public int Price
    {
        get
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday && DateTime.Now.Hour >= 11 && DateTime.Now.Hour < 16)
                return Convert.ToInt32(price * 0.8);
            else
                return price;
        }
    }
}