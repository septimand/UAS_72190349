using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Services;

namespace UAS.Pages
{
    public partial class  DeleteStudent
    {
         [Parameter]
        public string Id { get; set; }

        [Inject]
        public IStudent StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await StudentService.Delete(int.Parse(Id));
             NavigationManager.NavigateTo("/studentpage");
        }

    }
}