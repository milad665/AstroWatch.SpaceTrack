using System;

namespace AstroWatch.SpaceTrack.BasicSpaceData
{
    public class PredicateValue
    {
        private readonly object _value;

        public static PredicateValue Null => new PredicateValue {IsNullValue = true};
        public static PredicateValue Now => new PredicateValue {IsDateTimeNow = true};
        public static PredicateValue FromNumberOfDaysAgo(int daysAgo) => new PredicateValue {DaysAgo = daysAgo};

        private PredicateValue()
        {}
        
        public PredicateValue(object value)
        {
            _value = value;
        }

        public string Value => GetValue();

        private string GetValue()
        {
            if (IsNullValue)
                return "null-val";
            if (IsDateTimeNow)
                return "now";
            if (DaysAgo.HasValue)
                return $"now-{DaysAgo}";
            
            if (_value is DateTime time)
                return time.ToString("yyyy-MM-dd hh:mm:ss");
            
            return _value.ToString();
        }

        public static implicit operator long(PredicateValue x) => Convert.ToInt64(x._value);
        public static implicit operator int(PredicateValue x) => Convert.ToInt32(x._value);
        public static implicit operator double(PredicateValue x) => Convert.ToDouble(x._value);
        public static implicit operator DateTime(PredicateValue x) => Convert.ToDateTime(x._value);
        
        public static implicit operator PredicateValue(long x) => new PredicateValue(x);
        public static implicit operator PredicateValue(int x) => new PredicateValue(x);
        public static implicit operator PredicateValue(double x) => new PredicateValue(x);
        public static implicit operator PredicateValue(DateTime x) => new PredicateValue(x);

        private bool IsDateTimeNow { get; set; }
        private int? DaysAgo { get; set; }
        private bool IsNullValue { get; set; }

        public override string ToString() => GetValue();
    }
}