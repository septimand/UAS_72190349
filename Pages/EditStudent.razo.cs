using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class EditStudent
    {
        
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudent StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }
        
        protected async override Task OnInitializedAsync()
        {
            Student = await StudentService.GetById(int.Parse(Id));
        }

        protected async Task HandleValidSubmit(){
            var result = await StudentService.Update(int.Parse(Id),Student);
             NavigationManager.NavigateTo("/studentpage");
        }

    }
}