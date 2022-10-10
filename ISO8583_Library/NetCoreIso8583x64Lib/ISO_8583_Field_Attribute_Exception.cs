namespace NetCoreIso8583x64Lib
{
    public class ISO_8583_Field_Attribute_Exception : Exception
    {
        public ISO_8583_Field_Attribute_Exception()
            : base("The properties passed to this method don't use ISO_8583 Field/Property Attribute.") { }
    }
}
