using System;

namespace Shared
{
    public class StudentArgs : EventArgs
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }

    }
}
