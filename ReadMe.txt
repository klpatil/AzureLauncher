https://docs.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal
https://github.com/Azure-Samples/resource-manager-dotnet-resources-and-groups#list-resources
https://docs.microsoft.com/en-us/rest/api/resources/resources/listbyresourcegroup

**********Example******************
 /*
            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product() { Name = "KP", Description = "This is super long description", Price = 10 });

            var template = Template.Parse(@"
<ul id='products'>
  {{ for product in products }}
    <li>
      <h2>{{ product.name }}</h2>
           Price: {{ product.price }}
           {{ product.description | string.truncate 15 }}
    </li>
  {{ end }}
</ul>
");
            var result = template.Render(new { Products = ProductList });
            //MessageBox.Show(result);
            webBrowser1.DocumentText = result;*/

			 class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }

        }
***********************
  // https://zimmergren.net/developing-with-azure-resource-manager-part-3-build-an-application-using-c-which-is-using-the-azure-resource-manager-apis/

                /* https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/overview#resource-groups
                 * https://github.com/Azure-Samples/resource-manager-dotnet-resources-and-groups
                 */

				