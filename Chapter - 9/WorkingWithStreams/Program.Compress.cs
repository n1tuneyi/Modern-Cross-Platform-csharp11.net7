﻿using System.IO.Compression;
using System.Xml;
using static System.Environment;
using static System.IO.Path;
partial class Program
{
    static void Compress(string algorithm = "gzip")
    {
        string filePath = Combine(CurrentDirectory, $"streams.{algorithm}");
        FileStream file = File.Create(filePath);
        Stream compressor;
        if (algorithm == "gzip")
        {
            compressor = new GZipStream(file, CompressionMode.Compress);
        }
        else
        {
            compressor = new BrotliStream(file, CompressionMode.Compress);
        }
        using (compressor)
        {
            using (XmlWriter xml = XmlWriter.Create(compressor))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("callsigns");
                foreach (string item in Viper.Callsigns)
                {
                    xml.WriteElementString("callsign", item);
                }
            }
        }

        WriteLine("{0} contains {1:N0} bytes.",
        filePath, new FileInfo(filePath).Length);
        WriteLine($"The compressed contents:");
        WriteLine(File.ReadAllText(filePath));

        WriteLine("Reading the compressed XML file:");
        file = File.Open(filePath, FileMode.Open);
        Stream decompressor;
        if (algorithm == "gzip")
        {
            decompressor = new GZipStream(
            file, CompressionMode.Decompress);
        }
        else
        {
            decompressor = new BrotliStream(
            file, CompressionMode.Decompress);
        }
        using (decompressor)
        using (XmlReader reader = XmlReader.Create(decompressor))
            while (reader.Read())
            {

                if ((reader.NodeType == XmlNodeType.Element)
                && (reader.Name == "callsign"))
                {
                    reader.Read();
                    WriteLine($"{reader.Value}");
                }
            }
    }
}