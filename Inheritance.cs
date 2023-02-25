using cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace cs
{
    class Time
    {
        public Time()
        {

        }
        public int entr_per, sale_per, per_of_write_downs;
    }
    class Product : Time
    {
        public Product()
        {

        }
        public virtual void entrance()
        {

        }
        public virtual void entry()
        {

        }
    }
    class Products : Product
    {
        public Products()
        {

        }
        public string output_type = "продукты";
    }
    class Hous_chem : Product
    {
        public Hous_chem()
        {

        }
        public string chemicals = "бытовая химия";
    }
    class Air_fresh : Hous_chem
    {
        public Air_fresh()
        {

        }
        public string giv_name = "освежитель воздуха";
        public Time hous_chem_3 = new Time();
        public Hous_chem commodity = new Hous_chem();
        public override void entrance()
        {
            WriteLine(commodity.chemicals);
            WriteLine(giv_name);
            WriteLine("поступление (числомесяцгод)");
            hous_chem_3.entr_per = Convert.ToInt32(ReadLine());
            sale();
            write_downs();
            data_output();
        }
        public void sale()
        {
            WriteLine("продажа (числомесяцгод)");
            hous_chem_3.sale_per = Convert.ToInt32(ReadLine());
        }
        public void write_downs()
        {
            WriteLine("списание (числомесяцгод)");
            hous_chem_3.per_of_write_downs = Convert.ToInt32(ReadLine());
        }
        public void data_output()
        {
            WriteLine("поступление   " + hous_chem_3.entr_per + "   продажа   " + hous_chem_3.sale_per + "   списание   " + hous_chem_3.per_of_write_downs);
            if (hous_chem_3.entr_per > hous_chem_3.per_of_write_downs || hous_chem_3.sale_per > hous_chem_3.per_of_write_downs || hous_chem_3.entr_per > hous_chem_3.sale_per) WriteLine("ошибка");
        }
    }
    class Bread : Products
    {
        public Bread()
        {

        }
        public string giv_name = "хлеб";
        public Time product_2 = new Time();
        public Products produce = new Products();
        public override void entry()
        {
            WriteLine(produce.output_type);
            WriteLine(giv_name);
            WriteLine("поступление(числомесяцгод)");
            product_2.entr_per = Convert.ToInt32(ReadLine());
            sale();
            write_downs();
            data_output();
        }
        public void sale()
        {
            WriteLine("продажа (числомесяцгод)");
            product_2.sale_per = Convert.ToInt32(ReadLine());
        }
        public void write_downs()
        {
            WriteLine("списание (числомесяцгод)");
            product_2.per_of_write_downs = Convert.ToInt32(ReadLine());
        }
        public void data_output()
        {
            WriteLine("поступление   " + product_2.entr_per + "   продажа   " + product_2.sale_per + "   списание   " + product_2.per_of_write_downs);
            if (product_2.entr_per > product_2.per_of_write_downs || product_2.sale_per > product_2.per_of_write_downs || product_2.entr_per > product_2.sale_per) WriteLine("ошибка");
        }
    }
    class Milk : Products
    {
        public Milk()
        {

        }
        public string giv_name = "молоко";
        public Time product_1 = new Time();
        public Products produce = new Products();
        public override void entry()
        {
            WriteLine(produce.output_type);
            WriteLine(giv_name);
            WriteLine("поступление (числомесяцгод)");
            product_1.entr_per = Convert.ToInt32(ReadLine());
            sale();
            write_downs();
            data_output();
        }
        public void sale()
        {
            WriteLine("продажа (числомесяцгод)");
            product_1.sale_per = Convert.ToInt32(ReadLine());
        }
        public void write_downs()
        {
            WriteLine("списание (числомесяцгод)");
            product_1.per_of_write_downs = Convert.ToInt32(ReadLine());
        }
        public void data_output()
        {
            WriteLine("поступление   " + product_1.entr_per + "   продажа   " + product_1.sale_per + "   списание   " + product_1.per_of_write_downs);
            if (product_1.entr_per > product_1.per_of_write_downs || product_1.sale_per > product_1.per_of_write_downs || product_1.entr_per > product_1.sale_per) WriteLine("ошибка");
        }
    }
    class Rice : Products
    {
        public Rice()
        {

        }
        public string giv_name = "рис";
        Time product_3 = new Time();
        Products produce = new Products();
        public override void entry()
        {
            WriteLine(produce.output_type);
            WriteLine(giv_name);
            WriteLine("поступление (числомесяцгод)");
            product_3.entr_per = Convert.ToInt32(ReadLine());
            sale();
            write_downs();
            data_output();
        }
        public void sale()
        {
            WriteLine("продажа (числомесяцгод)");
            product_3.sale_per = Convert.ToInt32(ReadLine());
        }
        public void write_downs()
        {
            WriteLine("списание (числомесяцгод)");
            product_3.per_of_write_downs = Convert.ToInt32(ReadLine());
        }
        public void data_output()
        {
            WriteLine("поступление   " + product_3.entr_per + "   продажа   " + product_3.sale_per + "   списание   " + product_3.per_of_write_downs);
            if (product_3.entr_per > product_3.per_of_write_downs || product_3.sale_per > product_3.per_of_write_downs || product_3.entr_per > product_3.sale_per) WriteLine("ошибка");
        }
    }
    class Soap : Hous_chem
    {
        public Soap()
        {

        }
        public string giv_name = "мыло";
        public Time hous_chem_1 = new Time();
        public Hous_chem commodity = new Hous_chem();
        public override void entrance()
        {
            WriteLine(commodity.chemicals);
            WriteLine(giv_name);
            WriteLine("поступление (числомесяцгод)");
            hous_chem_1.entr_per = Convert.ToInt32(ReadLine());
            sale();
            write_downs();
            data_output();
        }
        public void sale()
        {
            WriteLine("продажа (числомесяцгод)");
            hous_chem_1.sale_per = Convert.ToInt32(ReadLine());
        }
        public void write_downs()
        {
            WriteLine("списание (числомесяцгод)");
            hous_chem_1.per_of_write_downs = Convert.ToInt32(ReadLine());
        }
        public void data_output()
        {
            WriteLine("поступление   " + hous_chem_1.entr_per + "   продажа   " + hous_chem_1.sale_per + "   списание   " + hous_chem_1.per_of_write_downs);
            if (hous_chem_1.entr_per > hous_chem_1.per_of_write_downs || hous_chem_1.sale_per > hous_chem_1.per_of_write_downs || hous_chem_1.entr_per > hous_chem_1.sale_per) WriteLine("ошибка");
        }
    }
    class Wash_powd : Hous_chem
    {
        public Wash_powd()
        {

        }
        public string giv_name = "стиральный порошок";
        public Time hous_chem_2 = new Time();
        public Hous_chem commodity = new Hous_chem();
        public override void entrance()
        {
            WriteLine(commodity.chemicals);
            WriteLine(giv_name);
            WriteLine("поступление (числомесяцгод)");
            hous_chem_2.entr_per = Convert.ToInt32(ReadLine());
            sale();
            write_downs();
            data_output();
        }
        public void sale()
        {
            WriteLine("продажа (числомесяцгод)");
            hous_chem_2.sale_per = Convert.ToInt32(ReadLine());
        }
        public void write_downs()
        {
            WriteLine("списание (числомесяцгод)");
            hous_chem_2.per_of_write_downs = Convert.ToInt32(ReadLine());
        }
        public void data_output()
        {
            WriteLine("поступление   " + hous_chem_2.entr_per + "   продажа   " + hous_chem_2.sale_per + "   списание   " + hous_chem_2.per_of_write_downs);
            if (hous_chem_2.entr_per > hous_chem_2.per_of_write_downs || hous_chem_2.sale_per > hous_chem_2.per_of_write_downs || hous_chem_2.entr_per > hous_chem_2.sale_per) WriteLine("ошибка");
        }
    }
    class Menu
    {
        public Menu()
        {

        }
        public void carte()
        {
            WriteLine("молоко=1, хлеб=2, рис=3, мыло=4, стиральный порошок=5, освежитель воздуха=6");
        }
    }
}
internal class Inheritance
{
    static void Main(string[] args)
    {
        Milk milk = new Milk();
        Bread loaf = new Bread();
        Rice rhys = new Rice();
        Soap lather = new Soap();
        Wash_powd powd = new Wash_powd();
        Air_fresh fresh = new Air_fresh();
        int variant;
        Product[] goods = { milk, loaf, rhys, lather, powd, fresh };
        Menu menu = new Menu();
        menu.carte();
        variant = Convert.ToInt32(ReadLine());
        if (variant == 1) goods[0].entry();
        else if (variant == 2) goods[1].entry();
        else if (variant == 3) goods[2].entry();
        else if (variant == 4) goods[3].entrance();
        else if (variant == 5) goods[4].entrance();
        else if (variant == 6) goods[5].entrance();
        else WriteLine("ошибка");
    }
}