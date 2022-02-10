using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Settings
{
    public string DefaultText { get; set; }
    public string DefaultText2 { get; set; }
    public string HeaderText { get; set; }
    public string FooterText { get; set; }
}

public class Manager
{
    public static Settings LoadSettings(String filePath)
    {
        Settings settings = new Settings();
        try
        {
            
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            settings = (Settings)reader.Deserialize(file);
            file.Close();
            return settings;
        }   
        catch (Exception)
        {
            return settings;

        }

    }
    public static void SaveSettings(string filePath, Settings SettingsObject)
    {
        System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));

        System.IO.FileStream file = System.IO.File.Create(filePath);
        writer.Serialize(file, SettingsObject);
    }
    public static Settings LoadDSettings(String filePath)
    {
        Settings settings = new Settings();
        try
        {

            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            settings = (Settings)reader.Deserialize(file);
            file.Close();
            return settings;
        }
        catch (Exception)
        {
            return settings;

        }

    }
    public static void SaveDSettings(string filePath, Settings SettingsObject)
    {
        System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));

        System.IO.FileStream file = System.IO.File.Create(filePath);
        writer.Serialize(file, SettingsObject);
    }
}
