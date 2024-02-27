using System;

class Shop
{
    private double area;

    public double Area
    {
        get { return area; }
        set { area = value; }
    }

    
    public static Shop operator +(Shop shop, double size)
    {
        shop.area += size;
        return shop;
    }

    public static Shop operator -(Shop shop, double size)
    {
        shop.area -= size;
        return shop;
    }

    public static bool operator ==(Shop shop1, Shop shop2)
    {
        return shop1.area == shop2.area;
    }

    public static bool operator !=(Shop shop1, Shop shop2)
    {
        return shop1.area != shop2.area;
    }

    public static bool operator >(Shop shop1, Shop shop2)
    {
        return shop1.area > shop2.area;
    }

    public static bool operator <(Shop shop1, Shop shop2)
    {
        return shop1.area < shop2.area;
    }

    
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Shop shop = (Shop)obj;
        return this.area == shop.area;
    }
}
