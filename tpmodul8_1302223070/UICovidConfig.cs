using System;
using System.Text.Json;
using System.Xml.Serialization;

public class UICovidConfig
{
    public CovidConfig config;
    public const string filePath = "C:\\GINA\\KULIAH\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\PRAKTIKUM\\MINGGU 8\\tpmodul8_1302223070\\tpmodul8_1302223070\\CovidConfig.json";
    public UICovidConfig()
    {
        try
        {
            ReadConfigFile();
        }
        catch (Exception)
        {
            setDefault();
            WriteNewConfigFile();
        }
    }
    public CovidConfig ReadConfigFile()
    {
        string jsonData = File.ReadAllText(filePath);
        config = JsonSerializer.Deserialize<CovidConfig>(jsonData);
        return config;
    }
    public void setDefault()
    {
        config.satuan_suhu = "Celcius";
        config.batas_hari_demam = 14;
        config.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        config.pesan_diterima = "Anda dipersilahkan masuk ke dalam gedung ini";
    }
    public void WriteNewConfigFile()
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        string jsonString = JsonSerializer.Serialize(config, options);
        File.WriteAllText(filePath, jsonString);
    }
}
