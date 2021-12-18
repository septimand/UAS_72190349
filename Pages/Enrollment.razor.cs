using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class Enrollment
    {
        public List<Student> Students { get; set; } = new List<Student>();

        [Inject]
        public IStudent StudentService { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            Students = (await StudentService.GetAll()).ToList();
        }
    }
}