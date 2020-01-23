using System;
using System.Collections.Generic;
using System.Text;

namespace Pampa.Share.Core.Student
{
   public class Guardian:BaseEntity
    {
        public virtual string Name { get; set; }

        public virtual string Gender { get; set; }

        public virtual string  RelationshipToStudent { get; set; }

        public virtual string Address { get; set; }

        public virtual string Hometown { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string EmailAddress { get; set; }

        public virtual string Occupation { get; set; }

        public ICollection<StudentGuardians> StudentGuardians { get; set; }

    }
}
