using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTimeOffset? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}