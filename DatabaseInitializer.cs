using GridViewProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace GridViewProject.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            // Here we add some seed (test) data
            GetCurrencies().ForEach(c => context.Currencies.Add(c));
        }

        private static List<Currency> GetCurrencies()
        {
            var currencies = new List<Currency> 
            {
                new Currency 
                { 
                    CurrencyId = 1, 
                    CurrencyName = "Dollar",
                    CurrencySymbol = "$",
                    ExchangeRate = 87,
                    Created = DateTime.Now
                }, 
                new Currency 
                { 
                    CurrencyId = 2, 
                    CurrencyName = "Sterling Pound",
                    CurrencySymbol = "£",
                    ExchangeRate = 131,
                    Created = DateTime.Now
                }
            };

            return currencies;
        }
    }
}