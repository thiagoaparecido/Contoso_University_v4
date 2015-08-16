using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength=3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName="money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }


        [Display(Name ="Administrator")]
        public int? InstructorID { get; set; }

        //used for concurrency handling
        [Timestamp]
        public byte[] RowVersion { get; set; }

        //navigational properties
        public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}