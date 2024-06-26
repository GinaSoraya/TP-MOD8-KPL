﻿using System;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_demam { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public CovidConfig()
    {
        this.satuan_suhu = satuan_suhu;
        this.batas_hari_demam = batas_hari_demam;
        this.pesan_ditolak = pesan_ditolak;
        this.pesan_diterima = pesan_diterima;
    }

    public void UbahSatuan()
    {
        UICovidConfig uiConfig = new UICovidConfig();
        if (uiConfig.config.satuan_suhu == "Celcius")
        {
            uiConfig.config.satuan_suhu = "Fahrenheit";
            uiConfig.WriteNewConfigFile();
        }
        else if (uiConfig.config.satuan_suhu == "Fahrenheit")
        {
            uiConfig.config.satuan_suhu = "Celcius";
            uiConfig.WriteNewConfigFile();
        }
    }
}