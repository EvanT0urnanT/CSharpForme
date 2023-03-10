using ProjectFormes.Models.Formes;
public class AreaCalcultor
{
    public double TotalArea(Shape[] arrObject)
    {
        double area = 0;
        foreach(var obj in arrObject)
        {
            area += obj.Area();
        }
        return area;
    }
}