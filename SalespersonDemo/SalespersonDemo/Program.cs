namespace SalespersonDemo;

class Program
{
    static void Main(string[] args)
    {
        RealEstateSalesperson realtor1 = new RealEstateSalesperson("Ken", "Griffin", 0.03);
        GirlScout girly1 = new GirlScout("Jessica", "Simpson");
        realtor1.SalesSpeech();
        girly1.SalesSpeech();
        realtor1.MakeSale(325000);
        realtor1.MakeSale(799999);
        realtor1.MakeSale(157699);
        girly1.MakeSale(22);
        girly1.MakeSale(13);
        girly1.MakeSale(42);
    }
}

