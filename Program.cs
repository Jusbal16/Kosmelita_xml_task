using System;
using System.Net;
using System.Windows;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Kosmelita
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                id = "123548",
                name = "Kava",
                price = 1.25,
                vat_rate = 25,
                type = "food",
                productionn_date = new DateTime(2019, 5, 8).ToString("yyyy-MM-dd"),
                expiration_date = new DateTime(2021, 5, 8).ToString("yyyy-MM-dd"),
                manufacturer = "Kavos turgus",
                barcode = "5564846513",
                barcode2 = "55648465135",
                origin_country = "Mianmar",
                origin_town = "Birma",
                production_country = "Lithuania",
                production_town = "Kaunas",
                supplier_name = "bigfood",
                supplier_code = "1236859",
                supplier_address = "islandijos 88A, Kaunas"
            };
            product1.alias.Add("skani kava");
            product1.alias.Add("Gurmanu Kava");


            Product product2 = new Product()
            {
                id = "S1284",
                name = "spausdinimas",
                price = 0.1,
                type = "serive",
                barcode2 = "1356484",
                production_country = "Lithuania",
                production_town = "Kaunas"
            };
            product2.alias.Add("spalvotas spausdinimas");
            product2.alias.Add("pigus spausdinimas");
            product2.options.Add("spalvotas");
            product2.options.Add("nespalvotas");
            product2.options.Add("kietu lapu");
            product2.options.Add("kartonu");

            List<Product> products = new List<Product>();

            products.Add(product1);
            products.Add(product2);
    
        


            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
		
            var stringwriter = new System.IO.StringWriter();

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("","");
            serializer.Serialize(stringwriter, products,ns);
            File.WriteAllText("Products.xml",stringwriter.ToString());

        }
    }
}
