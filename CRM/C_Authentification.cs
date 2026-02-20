using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace CRM
{
    public class C_Authentification
    {
        private readonly IPublicClientApplication _app;
        private readonly string[] _scopes = { "User.Read" };

        public C_Authentification()
        {
            _app = PublicClientApplicationBuilder
                .Create("6aec2a4f-6f2a-48e7-be31-cf28e136ac1e")
                .WithAuthority("https://login.microsoftonline.com/90429b6b-2ae5-4eab-91dc-bbf9b4c426c7")
                .WithRedirectUri("http://localhost") // Pour WinForms
                .Build();
        }

        public async Task<AuthenticationResult> LoginAsync()
        {
            try
            {
                // Tente un login silencieux (token en cache)
                var accounts = await _app.GetAccountsAsync();
                return await _app.AcquireTokenSilent(_scopes, accounts.FirstOrDefault())
                                 .ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                // Ouvre la fenêtre de login Microsoft
                return await _app.AcquireTokenInteractive(_scopes)
                                 .ExecuteAsync();
            }
        }

        public async Task LogoutAsync()
        {
            var accounts = await _app.GetAccountsAsync();
            foreach (var account in accounts)
                await _app.RemoveAsync(account);
        }
    }
}
