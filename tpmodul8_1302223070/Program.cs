using System.ComponentModel;
using System.Transactions;
internal class Program
{
    private static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();
        UICovidConfig uiConfig = new UICovidConfig();

        uiConfig.ReadConfigFile();
        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {uiConfig.config.satuan_suhu}");
        double suhu = Convert.ToDouble( Console.ReadLine() );
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hari = Convert.ToInt32( Console.ReadLine() );

        if (uiConfig.config.satuan_suhu == "Celcius")
        {
            if (suhu >= 36.5 && suhu <= 37.5 && hari < uiConfig.config.batas_hari_demam)
            {
                Console.WriteLine(uiConfig.config.pesan_diterima);
            } 
            else
            {
                Console.WriteLine(uiConfig.config.pesan_ditolak);
            }
        }
        else if (uiConfig.config.satuan_suhu == "Fahrenheit")
        {
            if (suhu >= 97.7 && suhu <= 99.5 && hari < uiConfig.config.batas_hari_demam)
            {
                Console.WriteLine(uiConfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(uiConfig.config.pesan_ditolak);
            }
        }

        config.UbahSatuan();
        uiConfig.ReadConfigFile();
        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {uiConfig.config.satuan_suhu}");
        suhu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        hari = Convert.ToInt32(Console.ReadLine());

        if (uiConfig.config.satuan_suhu == "Celcius")
        {
            if (suhu >= 36.5 && suhu <= 37.5 && hari < uiConfig.config.batas_hari_demam)
            {
                Console.WriteLine(uiConfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(uiConfig.config.pesan_ditolak);
            }
        }
        else if (uiConfig.config.satuan_suhu == "Fahrenheit")
        {
            if (suhu >= 97.7 && suhu <= 99.5 && hari < uiConfig.config.batas_hari_demam)
            {
                Console.WriteLine(uiConfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(uiConfig.config.pesan_ditolak);
            }
        }
    }
}