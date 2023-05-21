using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Tube
{
    public List<string> TextBoxValues { get; set; }
    public string RichTextBoxValue1 { get; set; }
    public string RichTextBoxValue2 { get; set; }

    public Tube()
    {
        TextBoxValues = new List<string>();
    }

    public void Save(string filePath)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while saving Tube: " + ex.Message);
        }
    }

    public static Tube Open(string filePath)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Tube)formatter.Deserialize(fs);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while opening Tube: " + ex.Message);
            return null;
        }
    }
}
