using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace StockInventoryManagement
{
    public class FetchStocks
    {
        public StockDetails Read(string path)
        {
            using (StreamReader file  = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockDetails>(json);
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
