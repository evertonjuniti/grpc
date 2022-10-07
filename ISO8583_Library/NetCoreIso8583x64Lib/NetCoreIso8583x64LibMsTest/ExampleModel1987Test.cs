using NetCoreIso8583x64Lib;

namespace NetCoreIso8583x64LibMsTest
{
    [ISO_8583(standard: STANDARD.ISO_8583_1987)]
    internal class ExampleModelTest
    {
        [ISO_8583_1987(field: ISO_8583_1987.Message_Type_Indicator)]
        public string MessageTypeIndicator { get; set; }

        [ISO_8583_1987(field: ISO_8583_1987.Primary_Account_Number)]
        public string PrimaryAccountNumber { get; set; }

        [ISO_8583_1987(field: ISO_8583_1987.Amount_Txn)]
        public string AmountTxn { get; set; }

        [ISO_8583_1987(field: ISO_8583_1987.Systems_Trace_Audit_Number)]
        public string SystemsTraceAuditNumber { get; set; }

        [ISO_8583_1987(field: ISO_8583_1987.Action_Code)]
        public string ActionCode { get; set; }

        [ISO_8583_1987(field: ISO_8583_1987.Card_Acceptor_Terminal_Id)]
        public string CardAcceptorTerminalId { get; set; }

        [ISO_8583_1987(field: ISO_8583_1987.Card_Acceptor_Id_Code)]
        public string CardAcceptorIdCode { get; set; }

        [ISO_8583_1987(field: ISO_8583_1987.Reserved_for_Private_use_5)]
        public string ReservedForPrivateUse { get; set; }
    }
}
