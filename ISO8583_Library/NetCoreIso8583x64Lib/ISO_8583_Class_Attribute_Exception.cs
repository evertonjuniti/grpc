namespace NetCoreIso8583x64Lib
{
    public class ISO_8583_Class_Attribute_Exception : Exception
    {
        public ISO_8583_Class_Attribute_Exception()
            : base("The class passed to this method don't use ISO_8583 class Attribute.") { }
    }
}
