using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class Detail
    {      
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IStudent StudentService { get; set; }

        public Student Students { get; set; } = new Student();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Students = await StudentService.GetById(int.Parse(id));
        }
    }
}