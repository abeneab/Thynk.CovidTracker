﻿namespace TestManagement.Domain.Enumerations
{
    public class Gender : Enumeration
    {
        public static Gender Male = new Gender(1,nameof(Male).ToLowerInvariant());
        public static Gender Female = new Gender(2,nameof(Female).ToLowerInvariant());
        public static Gender NotSpecicifed = new Gender(3, nameof(NotSpecicifed).ToLowerInvariant());   
        public static IEnumerable<Gender> List() => new [] { Male, Female, NotSpecicifed };  
        internal Gender(int id, string name) : base(id, name)
        {
        }
    }
}
