using NetCoreIso8583x64Lib;
using System.Diagnostics.CodeAnalysis;

namespace NetCoreIso8583x64LibMsTest
{
    [ExcludeFromCodeCoverage]
    [ISO_8583(standard: STANDARD.ISO_8583_1993)]
    internal class ExampleModelWithoutFieldAttribute
    {
        public int Id { get; set; }
    }
}
