using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class EnrollmentPage
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IEnrollService EnrollService { get; set; }

        //public List<Student> Students { get; set; } = new List<Student>();
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Enrollments = (await EnrollService.GetById(int.Parse(id))).ToList();
        }

    }
}