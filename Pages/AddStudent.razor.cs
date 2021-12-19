using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]

        public IStudent StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected async Task HandleValidSubmit(){
            NavigationManager.NavigateTo("/studentpage");
            var result = await StudentService.Add(Student);
            
        }
    }
}