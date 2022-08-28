using Microsoft.AspNetCore.Components;

namespace BlazorJwtToken.Shared
{
    public partial class LoginRedirect
    {
        [Inject] NavigationManager? NavigationManager { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            var returnUrl = NavigationManager?.ToBaseRelativePath(NavigationManager.Uri);
            
            NavigationManager?.NavigateTo($"/account/login/{returnUrl}", false);

            await base.OnInitializedAsync();
        }
    }
}