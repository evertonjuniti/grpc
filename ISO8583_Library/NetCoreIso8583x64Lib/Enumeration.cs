using System.Reflection;

namespace NetCoreIso8583x64Lib
{
    public abstract partial class Enumeration : IComparable
    {
        public uint Position { get; }

        public string Description { get; }

        public STANDARD Standard { get; }

        public FIELD_TYPE FieldType { get; }

        public ushort MaxFieldSize { get; }

        public string Message { get; set; }

        protected Enumeration(uint position, string description, STANDARD standard, FIELD_TYPE fieldType, ushort maxFieldSize)
        {
            Position = position;
            Description = description;
            Standard = standard;
            FieldType = fieldType;
            MaxFieldSize = maxFieldSize;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
                 .Select(f => f.GetValue(null))
                 .Cast<T>();

        public override bool Equals(object obj)
        {
            if (obj is not Enumeration otherValue)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Position.Equals(otherValue.Position) && 
                               Description.Equals(otherValue.Description) &&
                               Standard.Equals(otherValue.Standard) &&
                               FieldType.Equals(otherValue.FieldType) &&
                               MaxFieldSize.Equals(otherValue.MaxFieldSize);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object other)
        {
            return Position.CompareTo(((Enumeration)other).Position) + 
                   Description.CompareTo(((Enumeration)other).Description) +
                   Standard.CompareTo(((Enumeration)other).Standard) +
                   FieldType.CompareTo(((Enumeration)other).FieldType) +
                   MaxFieldSize.CompareTo(((Enumeration)other).MaxFieldSize);
        }

        public static bool operator ==(Enumeration left, Enumeration right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(Enumeration left, Enumeration right)
        {
            return !(left == right);
        }

        public static bool operator <(Enumeration left, Enumeration right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(Enumeration left, Enumeration right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(Enumeration left, Enumeration right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(Enumeration left, Enumeration right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }
    }
}
