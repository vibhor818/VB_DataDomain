
using VB_DataContext.MyContexts;
using VB_DataDomain.Models;

class Program
{
    public static void Main(string[] args)
    {
        using(VBContext con=new VBContext())
        {
            var data = con.Emp.ToList();

            foreach(Emp item in data)
            {
                Console.WriteLine(item.Id+"  "+item.Name+"  "+item.Address);
            }
        }
    }
}