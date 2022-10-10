using NetCoreIso8583x64Lib;
using System.Diagnostics.CodeAnalysis;

namespace NetCoreIso8583x64LibMsTest
{
    [ExcludeFromCodeCoverage]
    [ISO_8583(standard: STANDARD.ISO_8583_1993)]
    internal class ExampleModel1993Test
    {
        public int Id { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Message_Type_Indicator)]
        public string MessageTypeIndicator { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Primary_Account_Number)]
        public string PrimaryAccountNumber { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Amount_Txn)]
        public string AmountTxn { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Systems_Trace_Audit_Number)]
        public string SystemsTraceAuditNumber { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Action_Code)]
        public string ActionCode { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Card_Acceptor_Terminal_Id)]
        public string CardAcceptorTerminalId { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Card_Acceptor_Id_Code)]
        public string CardAcceptorIdCode { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Reserved_for_Private_use_5)]
        public string ReservedForPrivateUse { get; set; }
    }
}
