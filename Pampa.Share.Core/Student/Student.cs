using System;
using System.Collections.Generic;
using System.Text;

namespace Pampa.Share.Core.Student
{
   public class Student:BaseEntity
    {
        public virtual string  FirstName { get; set; }

        public virtual string  LastName { get; set; }

        public virtual string Gender { get; set; }

        public virtual DateTime? Dob { get; set; }

        public virtual long? CurrentClass { get; set; }

        public virtual string Religion { get; set; }

        public virtual string Hometown { get; set; }

        public virtual string StudentNumber { get; set; }

        public ICollection<StudentGuardians> StudentGuardians { get; set; }
    }
}
