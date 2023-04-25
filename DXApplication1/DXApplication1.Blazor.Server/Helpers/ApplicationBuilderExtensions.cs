using System.Collections.Specialized;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXApplication1.Blazor.Server.Helpers
{
    public static class ApplicationBuilderExtensions
    {
        private static List<Category> categoryList = new();
        private static List<Product> productList = new();
        public static IApplicationBuilder UseXpoDemoData(this IApplicationBuilder builder)
        {
            IDataStore dataStore = builder.ApplicationServices.GetService<IDataStore>();
            //IDictionary<string, DBTable> schema = Createschema
            return builder;
        }

      

        private static async Task PopulateDemoList()
        {
            Task t = Task.WhenAll(PopulateProductList(), PopulateCategoryList());
            await t;
        }


        private static async Task PopulateCategoryList()
        {
            await Task.Run(() =>
            {
                categoryList.Add(new(null)
                {
                    CategoryName = "Clothings and Apparels",
                    Description = "Clothings and Apparels"
                });
                categoryList.Add(new(null)
                {
                    CategoryName = "Cameras",
                    Description = "Cameras"
                });
                categoryList.Add(new(null)
                {
                    CategoryName = "Mobiles and Gadgets",
                    Description = "Mobiles and Gadgets"
                });
                categoryList.Add(new(null)
                {
                    CategoryName = "Laptops and Computers",
                    Description = "Laptops and Computers"
                });
                categoryList.Add(new(null)
                {
                    CategoryName = "Home and Living",
                    Description = "Home and Living"
                });
            });
        }

        private static async Task PopulateProductList()
        {
            await Task.Run(() =>
            {
                productList.Add(new(null)
                {
                    ProductName = "Adata LEGEND 710 512GB PCIe GEN3 x4 M.2 NVME 2280 Solid State Drive",
                    Price = 27.69M
                });
                productList.Add(new(null)
                {
                    ProductName = "Adata LEGEND 710 1TB PCIe GEN3 x4 M.2 NVME 2280 Solid State Drive",
                    Price = 49.13M
                });
                productList.Add(new(null)
                {
                    ProductName = "Kingston SNVS/1000G 1TB NV1/SNV2S/1000G 1TB NV2 M.2 2280 NVMe",
                    Price = 52.07M
                });
                productList.Add(new(null)
                {
                    ProductName = "Kingston SNVS/1000G 1TB NV1/SNV2S/1000G 1TB NV2 M.2 2280 NVMe",
                    Price = 52.07M
                });
                productList.Add(new(null)
                {
                    ProductName = "COLORFUL Geforce RTX 2060 USED",
                    Price = 146.79M
                });
                productList.Add(new(null)
                {
                    ProductName = "Colorful GeForce RTX 3060 NB Duo 12G L-V & iGame GeForce RTX 3060 Ultra W OC 8G-V",
                    Price = 364.57M
                });
            });
        }
    }
}
