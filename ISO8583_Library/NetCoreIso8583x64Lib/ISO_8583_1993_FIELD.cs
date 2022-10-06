using System.Diagnostics.CodeAnalysis;

namespace NetCoreIso8583x64Lib
{
    [ExcludeFromCodeCoverage]
    public class ISO_8583_1993_FIELD : Enumeration
    {
        /// <summary>
        /// Message Type Indicator: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Message_Type_Indicator = 
            new ISO_8583_1993_FIELD(0, "Message Type Indicator", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Bitmap: size = 16, NB special type for bitmap continuation bit
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Bitmap =
            new ISO_8583_1993_FIELD(1, "Bitmap", STANDARD.ISO_8583_1993, FIELD_TYPE.BITMAP, 16);
        /// <summary>
        /// Primary Account Number: size = 19, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Primary_Account_Number =
            new ISO_8583_1993_FIELD(2, "Primary Account Number", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 19);
        /// <summary>
        /// Processing Code: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Processing_Code =
            new ISO_8583_1993_FIELD(3, "Processing Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Amount, Txn: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amount_Txn =
            new ISO_8583_1993_FIELD(4, "Amount, Txn", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Amount, Reconciliation: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amount_Reconciliation =
            new ISO_8583_1993_FIELD(5, "Amount, Reconciliation", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Amount, Cardholder Billing: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amount_Cardholder_Billing =
            new ISO_8583_1993_FIELD(6, "Amount, Cardholder Billing", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Date and Time, Transmission: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_and_Time_Transmission =
            new ISO_8583_1993_FIELD(7, "Date and Time, Transmission", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Amount, Cardholder Billing Fee: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amount_Cardholder_Billing_Fee =
            new ISO_8583_1993_FIELD(8, "Amount, Cardholder Billing Fee", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Conversion Rate, Reconciliation: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Conversion_Rate_Reconciliation =
            new ISO_8583_1993_FIELD(9, "Conversion Rate, Reconciliation", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Conversion Rate, Cardholder Billing: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Conversion_Rate_Cardholder_Billing =
            new ISO_8583_1993_FIELD(10, "Conversion Rate, Cardholder Billing", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Systems Trace Audit Number: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Systems_Trace_Audit_Number =
            new ISO_8583_1993_FIELD(11, "Systems Trace Audit Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Date and Time, Local Txn: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_and_Time_Local_Txn =
            new ISO_8583_1993_FIELD(12, "Date and Time, Local Txn", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Date, Effective: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_Effective =
            new ISO_8583_1993_FIELD(13, "Date, Effective", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Date, Expiration: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_Expiration =
            new ISO_8583_1993_FIELD(14, "Date, Expiration", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Date, Settlement: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_Settlement =
            new ISO_8583_1993_FIELD(15, "Date, Settlement", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Date, Conversion: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_Conversion =
            new ISO_8583_1993_FIELD(16, "Date, Conversion", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Date, Capture: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_Capture =
            new ISO_8583_1993_FIELD(17, "Date, Capture", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Merchant Type: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Merchant_Type =
            new ISO_8583_1993_FIELD(18, "Merchant Type", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Country Code, Acquiring Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Country_Code_Acquiring_Inst =
            new ISO_8583_1993_FIELD(19, "Country Code, Acquiring Inst", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Country Code, Primary Account Number: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Country_Code_Primary_Account_Number =
            new ISO_8583_1993_FIELD(20, "Country Code, Primary Account Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Country Code, Forwarding Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Country_Code_Forwarding_Inst =
            new ISO_8583_1993_FIELD(21, "Country Code, Forwarding Inst", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Point of Service Data Code: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Point_of_Service_Data_Code =
            new ISO_8583_1993_FIELD(22, "Point of Service Data Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Card Sequence Number: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Card_Sequence_Number =
            new ISO_8583_1993_FIELD(23, "Card Sequence Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Function Code: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Function_Code =
            new ISO_8583_1993_FIELD(24, "Function Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Message Reason Code: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Message_Reason_Code =
            new ISO_8583_1993_FIELD(25, "Message Reason Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Card Acceptor Business Code: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Card_Acceptor_Business_Code =
            new ISO_8583_1993_FIELD(26, "Card Acceptor Business Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Approval Code Length: size = 1, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Approval_Code_Length =
            new ISO_8583_1993_FIELD(27, "Approval Code Length", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 1);
        /// <summary>
        /// Date, Reconciliation: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_Reconciliation =
            new ISO_8583_1993_FIELD(28, "Date, Reconciliation", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Reconciliation Indicator: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reconciliation_Indicator =
            new ISO_8583_1993_FIELD(29, "Reconciliation Indicator", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Amounts, Original: size = 24, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amounts_Original =
            new ISO_8583_1993_FIELD(30, "Amounts, Original", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 24);
        /// <summary>
        /// Acquirer Reference Data: size = 24, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Acquirer_Reference_Data =
            new ISO_8583_1993_FIELD(31, "Acquirer Reference Data", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 24);
        /// <summary>
        /// Acquirer Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Acquirer_Inst_Id_Code =
            new ISO_8583_1993_FIELD(32, "Acquirer Inst Id Code", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Forwarding Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Forwarding_Inst_Id_Code =
            new ISO_8583_1993_FIELD(33, "Forwarding Inst Id Code", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Primary Account Number, Extended: size = 28, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Primary_Account_Number_Extended =
            new ISO_8583_1993_FIELD(34, "Primary Account Number, Extended", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 28);
        /// <summary>
        /// Track 2 Data, Extended: size = 37, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Track_2_Data =
            new ISO_8583_1993_FIELD(35, "Track 2 Data, Extended", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 37);
        /// <summary>
        /// Track 3 Data: size = 104, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Track_3_Data =
            new ISO_8583_1993_FIELD(36, "Track 3 Data", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 104);
        /// <summary>
        /// Retrieval Reference Number: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Retrieval_Reference_Number =
            new ISO_8583_1993_FIELD(37, "Retrieval Reference Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Approval Code: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Approval_Code =
            new ISO_8583_1993_FIELD(38, "Approval Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Action Code: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Action_Code =
            new ISO_8583_1993_FIELD(39, "Action Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Service Code: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Service_Code =
            new ISO_8583_1993_FIELD(40, "Service Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Card Acceptor Terminal Id: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Card_Acceptor_Terminal_Id =
            new ISO_8583_1993_FIELD(41, "Card Acceptor Terminal Id", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Card Acceptor Id Code: size = 15, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Card_Acceptor_Id_Code =
            new ISO_8583_1993_FIELD(42, "Card Acceptor Id Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 15);
        /// <summary>
        /// Card Acceptor Name/Location: size = 99, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Card_Acceptor_Name_Location =
            new ISO_8583_1993_FIELD(43, "Card Acceptor Name/Location", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 99);
        /// <summary>
        /// Additional Response Data: size = 99, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Additional_Response_Data =
            new ISO_8583_1993_FIELD(44, "Additional Response Data", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 99);
        /// <summary>
        /// Track 1 Data: size = 76, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Track_1_Data =
            new ISO_8583_1993_FIELD(45, "Track 1 Data", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 76);
        /// <summary>
        /// Amounts, Fees: size = 204, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amounts_Fees =
            new ISO_8583_1993_FIELD(46, "Amounts, Fees", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 204);
        /// <summary>
        /// Additional Data - National: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Additional_Data_National =
            new ISO_8583_1993_FIELD(47, "Additional Data - National", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Additional Data - Private: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Additional_Data_Private =
            new ISO_8583_1993_FIELD(48, "Additional Data - Private", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Currency Code, Txn: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Currency_Code_Txn =
            new ISO_8583_1993_FIELD(49, "Currency Code, Txn", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Currency Code, Reconciliation: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Currency_Code_Reconciliation =
            new ISO_8583_1993_FIELD(50, "Currency Code, Reconciliation", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Currency Code, Cardholder Billing: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Currency_Code_Cardholder_Billing =
            new ISO_8583_1993_FIELD(51, "Currency Code, Cardholder Billing", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Personal Id Number (PIN) Data: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Personal_Id_Number_PIN_Data =
            new ISO_8583_1993_FIELD(52, "Personal Id Number (PIN) Data", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Security Related Control Information: size = 48, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Security_Related_Control_Information =
            new ISO_8583_1993_FIELD(53, "Security Related Control Information", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 48);
        /// <summary>
        /// Amounts, Additional: size = 120, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amounts_Additional =
            new ISO_8583_1993_FIELD(54, "Amounts, Additional", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 120);
        /// <summary>
        /// IC Card System Related Data: size = 255, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD IC_Card_System_Related_Data =
            new ISO_8583_1993_FIELD(55, "IC Card System Related Data", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 255);
        /// <summary>
        /// Original Data Elements: size = 35, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Original_Data_Elements =
            new ISO_8583_1993_FIELD(56, "Original Data Elements", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 35);
        /// <summary>
        /// Authorization Life Cycle Code: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Authorization_Life_Cycle_Code =
            new ISO_8583_1993_FIELD(57, "Authorization Life Cycle Code", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Authorizing Agent Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Authorizing_Agent_Inst_Id_Code =
            new ISO_8583_1993_FIELD(58, "Authorizing Agent Inst Id Code", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Transport Data: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Transport_Data =
            new ISO_8583_1993_FIELD(59, "Transport Data", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_1 =
            new ISO_8583_1993_FIELD(60, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_2 =
            new ISO_8583_1993_FIELD(61, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_Private_use_1 =
            new ISO_8583_1993_FIELD(62, "Reserved for Private use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_Private_use_2 =
            new ISO_8583_1993_FIELD(63, "Reserved for Private use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Message Authentication Code Field: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Message_Authentication_Code_Field_1 =
            new ISO_8583_1993_FIELD(64, "Message Authentication Code Field", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Reserved for ISO use: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_ISO_use =
            new ISO_8583_1993_FIELD(65, "Reserved for ISO use", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Amounts, Original Fees: size = 204, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amounts_Original_Fees =
            new ISO_8583_1993_FIELD(66, "Amounts, Original Fees", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 204);
        /// <summary>
        /// Extended Payment Data: size = 2, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Extended_Payment_Data =
            new ISO_8583_1993_FIELD(67, "Extended Payment Data", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 2);
        /// <summary>
        /// Country Code, Receiving Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Country_Code_Receiving_Inst =
            new ISO_8583_1993_FIELD(68, "Country Code, Receiving Inst", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Country Code, Settlement Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Country_Code_Settlement_Inst =
            new ISO_8583_1993_FIELD(69, "Country Code, Settlement Inst", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Country Code, Authorizing Agent Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Country_Code_Authorizing_Agent_Inst =
            new ISO_8583_1993_FIELD(70, "Country Code, Authorizing Agent Inst", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Message Number: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Message_Number =
            new ISO_8583_1993_FIELD(71, "Message Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Data Record: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Data_Record =
            new ISO_8583_1993_FIELD(72, "Data Record", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Date, Action: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Date_Action =
            new ISO_8583_1993_FIELD(73, "Date, Action", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Credits, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Credits_Number =
            new ISO_8583_1993_FIELD(74, "Credits, Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Credits, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Credits_Reversal_Number =
            new ISO_8583_1993_FIELD(75, "Credits, Reversal Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Debits, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Debits_Number =
            new ISO_8583_1993_FIELD(76, "Debits, Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Debits, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Debits_Reversal_Number =
            new ISO_8583_1993_FIELD(77, "Debits, Reversal Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Transfer, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Transfer_Number =
            new ISO_8583_1993_FIELD(78, "Transfer, Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Transfer, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Transfer_Reversal_Number =
            new ISO_8583_1993_FIELD(79, "Transfer, Reversal Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Inquiries, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Inquiries_Number =
            new ISO_8583_1993_FIELD(80, "Inquiries, Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Authorizations, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Authorizations_Number =
            new ISO_8583_1993_FIELD(81, "Authorizations, Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Inquiries, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Inquiries_Reversal_Number =
            new ISO_8583_1993_FIELD(82, "Inquiries, Reversal Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Payments, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Payments_Number =
            new ISO_8583_1993_FIELD(83, "Payments, Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Payments, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Payments_Reversal_Number =
            new ISO_8583_1993_FIELD(84, "Payments, Reversal Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Fee Collections, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Fee_Collections_Number =
            new ISO_8583_1993_FIELD(85, "Fee Collections, Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Credits, Amount: size = 16, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Credits_Amount =
            new ISO_8583_1993_FIELD(86, "Credits, Amount", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 16);
        /// <summary>
        /// Credits, Reversal Amount: size = 16, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Credits_Reversal_Amount =
            new ISO_8583_1993_FIELD(87, "Credits, Reversal Amount", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 16);
        /// <summary>
        /// Debits, Amount: size = 16, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Debits_Amount =
            new ISO_8583_1993_FIELD(88, "Credits, Reversal Amount", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 16);
        /// <summary>
        /// Debits, Reversal Amount: size = 16, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Debits_Reversal_Amount =
            new ISO_8583_1993_FIELD(89, "Debits, Reversal Amount", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 16);
        /// <summary>
        /// Authorizations, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Authorizations_Reversal_Number =
            new ISO_8583_1993_FIELD(90, "Authorizations, Reversal Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Country Code, Txn Destination Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Country_Code_Txn_Destination_Inst =
            new ISO_8583_1993_FIELD(91, "Country Code, Txn Destination Inst", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Country Code, Txn Originator Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Country_Code_Txn_Originator_Inst =
            new ISO_8583_1993_FIELD(92, "Country Code, Txn Originator Inst", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Txn Destination Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Txn_Destination_Inst_Id_Code =
            new ISO_8583_1993_FIELD(93, "Txn Destination Inst Id Code", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Txn Originator Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Txn_Originator_Inst_Id_Code =
            new ISO_8583_1993_FIELD(94, "Txn Originator Inst Id Code", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Card Issuer Reference Data: size = 99, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Card_Issuer_Reference_Data =
            new ISO_8583_1993_FIELD(95, "Card Issuer Reference Data", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 99);
        /// <summary>
        /// Key Management Data: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Key_Management_Data =
            new ISO_8583_1993_FIELD(96, "Key Management Data", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Amount, Net Reconciliation: size = 17, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Amount_Net_Reconciliation =
            new ISO_8583_1993_FIELD(97, "Amount, Net Reconciliation", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 17);
        /// <summary>
        /// Payee: size = 25, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Payee =
            new ISO_8583_1993_FIELD(98, "Payee", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 25);
        /// <summary>
        /// Settlement Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Settlement_Inst_Id_Code =
            new ISO_8583_1993_FIELD(99, "Settlement Inst Id Code", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Receiving Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Receiving_Inst_Id_Code =
            new ISO_8583_1993_FIELD(100, "Receiving Inst Id Code", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// File Name: size = 17, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD File_Name =
            new ISO_8583_1993_FIELD(101, "File Name", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 17);
        /// <summary>
        /// Account Id 1: size = 28, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Account_Id_1 =
            new ISO_8583_1993_FIELD(102, "Account Id 1", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 28);
        /// <summary>
        /// Account Id 2: size = 28, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Account_Id_2 =
            new ISO_8583_1993_FIELD(103, "Account Id 2", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 28);
        /// <summary>
        /// Txn Description: size = 100, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Txn_Description =
            new ISO_8583_1993_FIELD(104, "Txn Description", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 100);
        /// <summary>
        /// Credits, Chargeback Amount: size = 16, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Credits_Chargeback_Amount =
            new ISO_8583_1993_FIELD(105, "Credits, Chargeback Amount", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 16);
        /// <summary>
        /// Debits, Chargeback Amount: size = 16, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Debits_Chargeback_Amount =
            new ISO_8583_1993_FIELD(106, "Debits, Chargeback Amount", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 16);
        /// <summary>
        /// Credits, Chargeback Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Credits_Chargeback_Number =
            new ISO_8583_1993_FIELD(107, "Credits, Chargeback Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Debits, Chargeback Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Debits_Chargeback_Number =
            new ISO_8583_1993_FIELD(108, "Debits, Chargeback Number", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Credits, Fee Amounts: size = 84, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Credits_Fee_Amounts =
            new ISO_8583_1993_FIELD(109, "Credits, Fee Amounts", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 84);
        /// <summary>
        /// Debits, Fee Amounts: size = 84, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Debits_Fee_Amounts =
            new ISO_8583_1993_FIELD(110, "Debits, Fee Amounts", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_99, 84);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_ISO_use_1 =
            new ISO_8583_1993_FIELD(111, "Reserved for ISO use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_ISO_use_2 =
            new ISO_8583_1993_FIELD(112, "Reserved for ISO use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_ISO_use_3 =
            new ISO_8583_1993_FIELD(113, "Reserved for ISO use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_ISO_use_4 =
            new ISO_8583_1993_FIELD(114, "Reserved for ISO use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_ISO_use_5 =
            new ISO_8583_1993_FIELD(115, "Reserved for ISO use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_3 =
            new ISO_8583_1993_FIELD(116, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_4 =
            new ISO_8583_1993_FIELD(117, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_5 =
            new ISO_8583_1993_FIELD(118, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_6 =
            new ISO_8583_1993_FIELD(119, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_7 =
            new ISO_8583_1993_FIELD(120, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_8 =
            new ISO_8583_1993_FIELD(121, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_National_use_9 =
            new ISO_8583_1993_FIELD(122, "Reserved for National use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_Private_use_3 =
            new ISO_8583_1993_FIELD(123, "Reserved for Private use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_Private_use_4 =
            new ISO_8583_1993_FIELD(124, "Reserved for Private use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_Private_use_5 =
            new ISO_8583_1993_FIELD(125, "Reserved for Private use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_Private_use_6 =
            new ISO_8583_1993_FIELD(126, "Reserved for Private use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Reserved_for_Private_use_7 =
            new ISO_8583_1993_FIELD(127, "Reserved for Private use", STANDARD.ISO_8583_1993, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Message Authentication Code Field: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1993_FIELD Message_Authentication_Code_Field_2 =
            new ISO_8583_1993_FIELD(128, "Message Authentication Code Field", STANDARD.ISO_8583_1993, FIELD_TYPE.FIXED, 8);

        protected ISO_8583_1993_FIELD(uint position, string description, STANDARD standard, FIELD_TYPE fieldType, ushort maxFieldSize) : 
            base(position, description, standard, fieldType, maxFieldSize)
        {
        }
    }
}
