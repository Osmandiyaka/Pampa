using System;
using System.Collections.Generic;
using System.Text;

namespace Pampa.Share.Core.Student
{
   public class StudentGuardians
    {
        public virtual long StudentId { get; set; }

        public virtual Student Student { get; set; }

        public virtual long GuardianId { get; set; }

        public virtual Guardian Guardian { get; set; }

    }
}
