using System;

namespace AstroWatch.SpaceTrack.Common
{
    public class PredicateNameAttribute : Attribute
    {
        private string _name;

        public PredicateNameAttribute(string name)
        {
            _name = name;
        }
    }
}