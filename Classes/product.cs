using System;
using System.Collections.Generic;
using System.Collections;
using System.Xml.Serialization;

namespace Kosmelita
{
    public class Product
    {
        public string id {get;set;}
        public string name {get;set;}
        public double price {get;set;}
        public double vat_rate {get;set;}
        public string type {get;set;}
        public string productionn_date {get;set;}
        public string expiration_date {get;set;}
        public string manufacturer {get;set;}
        public string barcode {get;set;}
        public string barcode2 {get;set;}
        [XmlArray("Alias")]
        [XmlArrayItem("Alias")]
        public List<string> alias {get;set;}
        public string origin_country {get;set;}
        public string origin_town {get;set;}
        public string production_country {get;set;}
        public string production_town {get;set;}
        public string supplier_name {get;set;}
        public string supplier_code {get;set;}
        public string supplier_address {get;set;}
        [XmlArray("Options")]
        [XmlArrayItem("Option")]
        public List<string> options {get;set;}
        public Product() 
        {
            this.alias = new List<string>();
            this.options = new List<string>();
        }
       
    }
}
