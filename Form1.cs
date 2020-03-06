using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using Microsoft.Rest.Azure;
using Microsoft.Rest.Azure.Authentication;
using Scriban;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string lblClientId = "ClientId";
        private const string lblServicePrincipalPassword = "ServicePrincipalPassword";
        private const string lblAzureTenantId = "AzureTenantId";
        private const string lblAzureSubscriptionId = "AzureSubscriptionId";

       
        private static TokenCredentials TokenCredentials { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (new List<string> { txtClientID.Text, txtServicePrincipalPassword.Text, txtAzureTenantId.Text,
                    txtAzureSubscriptionId.Text,txtResourceGroupName.Text }.Any(i => String.IsNullOrWhiteSpace(i)))
                {
                    MessageBox.Show("Please provide ClientId, ServicePrincipalPassword, AzureTenantId and AzureSubscriptionId.", "Error");
                }
                else if (txtAzureSubscriptionId.Text == lblAzureSubscriptionId ||
                       txtAzureTenantId.Text == lblAzureTenantId ||
                       txtClientID.Text == lblClientId ||
                       txtServicePrincipalPassword.Text == lblServicePrincipalPassword
                       )
                {
                    MessageBox.Show("Please provide real values for ClientId,ServicePrincipalPassword, AzureTenantId and AzureSubscriptionId.", "Error");
                }
                else
                {
                   
                    var token = GetAuthorizationToken();
                    TokenCredentials = new TokenCredentials(token);
                    var resources = GetWebResourceByResourceGroup(txtResourceGroupName.Text);
                    bool result = RenderOutput(resources);
                    if (result && chkPersist.Checked)
                    {
                        Properties.Settings.Default.AzureSubscriptionId = txtAzureSubscriptionId.Text;
                        Properties.Settings.Default.AzureTenantId = txtAzureTenantId.Text;
                        Properties.Settings.Default.ClientId = txtClientID.Text;
                        Properties.Settings.Default.ServicePrincipalPassword = txtServicePrincipalPassword.Text;
                        Properties.Settings.Default.ResourceGroupName = txtResourceGroupName.Text;
                        Properties.Settings.Default.Save();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private bool RenderOutput(IPage<GenericResource> resources)
        {
            bool isrendered = false;
            if (resources == null && !resources.Any())
            {
                isrendered = false;
                MessageBox.Show("No resource found");
            }
            else
            {
                var template = Template.Parse(@"
                         <table border='1' width='100%'>
                <tr>
            <th>Resource Name</th>
            <th>KUDU Link</th>
            <th>App Editor Link</th>
            <th>Website Link</th>
        </tr>
                          {{ for resource in resources }}
                             <tr>
            <td>{{ resource.name }}</td>
            <td><a href='https://{{ resource.name }}.scm.azurewebsites.net/DebugConsole' target='_blank'>KUDU</a></td>
            <td><a href='https://{{ resource.name }}.scm.azurewebsites.net/dev/wwwroot/' target='_blank'>App Editor</a></td>
            <td><a href='https://{{ resource.name }}.azurewebsites.net/' target='_blank'>Website</a></td>
        </tr>
                          {{ end }}   
            </table>");

                var resourcesList = resources.ToList();
                var result = template.Render(new { Resources = resourcesList });
                webBrowser1.DocumentText = result;
                isrendered = true;

            }

            return isrendered;

        }
        

        private  string GetAuthorizationToken()
        {
            ClientCredential cc = new ClientCredential(txtClientID.Text, txtServicePrincipalPassword.Text);
            var context = new AuthenticationContext("https://login.windows.net/" + txtAzureTenantId.Text);
            var result = context.AcquireTokenAsync("https://management.azure.com/", cc);
            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }

            return result.Result.AccessToken;
        }

        private IPage<GenericResource> GetWebResourceByResourceGroup(string resourceGroupName)
        {
            var resourceManagementClient = new ResourceManagementClient(TokenCredentials)
            {
                SubscriptionId = txtAzureSubscriptionId.Text
            };

            var resources = resourceManagementClient.Resources.ListByResourceGroup(resourceGroupName,
                new Microsoft.Rest.Azure.OData.ODataQuery<Microsoft.Azure.Management.ResourceManager.Models.GenericResourceFilter>
                ("$filter=resourceType eq 'microsoft.web/sites'"));

            return resources;

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.AzureSubscriptionId))
            {
                txtAzureSubscriptionId.Text = Properties.Settings.Default.AzureSubscriptionId;
            }

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.AzureTenantId))
            {
                txtAzureTenantId.Text = Properties.Settings.Default.AzureTenantId;
            }

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.ClientId))
            {
                txtClientID.Text = Properties.Settings.Default.ClientId;
            }

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.ServicePrincipalPassword))
            {
                txtServicePrincipalPassword.Text = Properties.Settings.Default.ServicePrincipalPassword;
            }

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.ResourceGroupName))
            {
                txtResourceGroupName.Text = Properties.Settings.Default.ResourceGroupName;
            }
        }
    }
}
