using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInventoryManagement
{
    public static class FetchInventoryDetails
    {
        public static class FetchForJsonInventoryData
        {
            public Inventory Read(string path)
            {
                using (StreamReader file = new StreamReader(path))
                {
                    try
                    {
                        string json = file.ReadToEnd();
                        return JsonConvert.DeserializeObject<Inventory>(json);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        return null;
                    }
                }
            }
        }
    }
}
