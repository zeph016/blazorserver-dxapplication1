using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DXApplication1.Module.BusinessObjects.XPO;

namespace DXApplication1.Blazor.Server.Pages.Products
{
    public partial class ProductView
    {
        private string sampleStr = "Hello World";
        private bool dataFetched, _disposed;
        private Product product = new(new());
        private Product selectedProduct { get; set; }
        private IEnumerable<Product> productList { get; set; }
        private int progressValue;
        private object key;
        private const string connectionString = 
            @"XpoProvider=MSSqlServer;data source=(local);integrated security=SSPI;initial catalog=DxSample2;User Id=sa;Password=123";


        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
           await GetProductList();
        }

        private void CompletedFetch()
        {
            dataFetched = true;
            StateHasChanged();
        }
        private void GetData()
        {
            using (UnitOfWork uow = new())
            {
                product = selectedProduct;
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
                var _product = uow.GetObjectByKey<Product>(product.Oid);
                if (_product != null) 
                    product = _product;
                uow.CommitChanges();
            }
        }

        private async System.Threading.Tasks.Task GetProductList()
        {
            StartProgressValue();
            using (UnitOfWork uow = new())
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
                var _productList = uow.Query<Product>().ToListAsync();
                if (_productList != null)
                    productList = await _productList;
                uow.CommitChanges();
            }
            CompletedFetch();
        }
        private void ClearData() => product = new(new());

        private async void StartProgressValue()
        {
            progressValue = 0;
            do
            {
                if (_disposed)
                {
                    progressValue = 100;
                    return;
                }
                progressValue += 4;
                StateHasChanged();
                await System.Threading.Tasks.Task.Delay(500);

            } while (progressValue < 100);

            StartProgressValue();
        }

        protected void Dispose() => _disposed = true;
    }
}
