﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Biz
{
    public class CompanyRepository
    {
        private List<Company> companies;
        
        public Company Retrieve(int vendorId)
        {

            Company vendor = new Company();


            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }
        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;
            return value;
        }
        public Company[] RetrieveArray()
        {
            var vendors = new Company[2]
                {
            new Company()
            { VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" },
            new Company()
            { VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" }
                };
            return vendors;
        }
        public IEnumerable<Company> Retrieve()
        {
            if (companies == null)
            {
                companies = new List<Company>();
                companies.Add(new Company() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                companies.Add(new Company() { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company);
            }

            return companies;
        }

        public IEnumerable<Company> RetrieveWithIterator()
        {

            this.Retrieve();

            foreach(var company in companies)
            {
                Console.WriteLine($"Vendor Id : {company.VendorId} ");
                yield return company;
            }
        }

        public Dictionary<string, Company> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Company>()
            {
                {"ABC Corp" , new Company()
                {VendorId = 5, CompanyName = "ABC Corp" , Email = "abc@abc.com" }},
                { "XYZ Inc" , new Company()
                {VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" }}
            };
            foreach (var element in vendors)
            {
                var vendor = element.Value;
                var key = element.Key;
                Console.WriteLine($"key: {key} value: {vendor}");
            }

            return vendors;
        }
    }
}