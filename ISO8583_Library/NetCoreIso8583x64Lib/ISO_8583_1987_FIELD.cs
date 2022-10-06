using System.Diagnostics.CodeAnalysis;

namespace NetCoreIso8583x64Lib
{
    [ExcludeFromCodeCoverage]
    public class ISO_8583_1987_FIELD : Enumeration
    {
        /// <summary>
        /// Message Type Indicator: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Message_Type_Indicator =
            new ISO_8583_1987_FIELD(0, "Message Type Indicator", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Bitmap: size = 16, NB special type for bitmap continuation bit
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Bitmap =
            new ISO_8583_1987_FIELD(1, "Bitmap", STANDARD.ISO_8583_1987, FIELD_TYPE.BITMAP, 16);
        /// <summary>
        /// Primary Account Number: size = 19, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Primary_Account_Number =
            new ISO_8583_1987_FIELD(2, "Primary Account Number", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 19);
        /// <summary>
        /// Processing Code: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Processing_Code =
            new ISO_8583_1987_FIELD(3, "Processing Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Amount, Txn: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Txn =
            new ISO_8583_1987_FIELD(4, "Amount, Txn", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Amount, Settlement: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Settlement =
            new ISO_8583_1987_FIELD(5, "Amount, Settlement", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Amount, Cardholder Billing: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Cardholder_Billing =
            new ISO_8583_1987_FIELD(6, "Amount, Cardholder Billing", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Date and Time, Transmission: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Date_and_Time_Transmission =
            new ISO_8583_1987_FIELD(7, "Date and Time, Transmission", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Amount, Cardholder Billing Fee: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Cardholder_Billing_Fee =
            new ISO_8583_1987_FIELD(8, "Amount, Cardholder Billing Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Conversion Rate, Settlement: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Conversion_Rate_Settlement =
            new ISO_8583_1987_FIELD(9, "Conversion Rate, Settlement", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Conversion Rate, Cardholder Billing: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Conversion_Rate_Cardholder_Billing =
            new ISO_8583_1987_FIELD(10, "Conversion Rate, Cardholder Billing", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Systems Trace Audit Number: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Systems_Trace_Audit_Number =
            new ISO_8583_1987_FIELD(11, "Systems Trace Audit Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Time, Local Txn: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Time_Local_Txn =
            new ISO_8583_1987_FIELD(12, "Time, Local Txn", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Date, Local Txn: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Date_Local_Txn =
            new ISO_8583_1987_FIELD(13, "Date, Local Txn", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Date, Expiration: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Date_Expiration =
            new ISO_8583_1987_FIELD(14, "Date, Expiration", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Date, Settlement: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Date_Settlement =
            new ISO_8583_1987_FIELD(15, "Date, Settlement", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Date, Conversion: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Date_Conversion =
            new ISO_8583_1987_FIELD(16, "Date, Conversion", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Date, Capture: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Date_Capture =
            new ISO_8583_1987_FIELD(17, "Date, Capture", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Merchant Type: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Merchant_Type =
            new ISO_8583_1987_FIELD(18, "Merchant Type", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Country Code, Acquiring Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Country_Code_Acquiring_Inst =
            new ISO_8583_1987_FIELD(19, "Country Code, Acquiring Inst", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Country Code, Primary Account Number: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Country_Code_Primary_Account_Number =
            new ISO_8583_1987_FIELD(20, "Country Code, Primary Account Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Country Code, Forwarding Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Country_Code_Forwarding_Inst =
            new ISO_8583_1987_FIELD(21, "Country Code, Forwarding Inst", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Point of Service Entry Mode: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Point_of_Service_Entry_Mode =
            new ISO_8583_1987_FIELD(22, "Point of Service Entry Mode", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Application PAN number: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Application_PAN_number =
            new ISO_8583_1987_FIELD(23, "Application PAN number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Network International Identifier: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Network_International_Identifier =
            new ISO_8583_1987_FIELD(24, "Network International Identifier", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Point of Service Condition Code: size = 2, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Point_of_Service_Condition_Code =
            new ISO_8583_1987_FIELD(25, "Point of Service Condition Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 2);
        /// <summary>
        /// Point of Service PIN Capture Code: size = 2, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Point_of_Service_PIN_Capture_Code =
            new ISO_8583_1987_FIELD(26, "Point of Service PIN Capture Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 2);
        /// <summary>
        /// Authorization Identification Response Length: size = 1, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Authorization_Identification_Response_Length =
            new ISO_8583_1987_FIELD(27, "Authorization Identification Response Length", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 1);
        /// <summary>
        /// Amount, Txn Fee: size = 9, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Txn_Fee =
            new ISO_8583_1987_FIELD(28, "Amount, Txn Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 9);
        /// <summary>
        /// Amount, Settlement Fee: size = 9, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Settlement_Fee =
            new ISO_8583_1987_FIELD(29, "Amount, Settlement Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 9);
        /// <summary>
        /// Amount, Txn Processing Fee: size = 9, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Txn_Processing_Fee =
            new ISO_8583_1987_FIELD(30, "Amount, Txn Processing Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 9);
        /// <summary>
        /// Amount, Settlement Processing Fee: size = 9, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Settlement_Processing_Fee =
            new ISO_8583_1987_FIELD(31, "Amount, Settlement Processing Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 9);
        /// <summary>
        /// Acquirer Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Acquirer_Inst_Id_Code =
            new ISO_8583_1987_FIELD(32, "Acquirer Inst Id Code", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Forwarding Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Forwarding_Inst_Id_Code =
            new ISO_8583_1987_FIELD(33, "Forwarding Inst Id Code", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Primary Account Number, Extended: size = 28, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Primary_Account_Number_Extended =
            new ISO_8583_1987_FIELD(34, "Primary Account Number, Extended", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 28);
        /// <summary>
        /// Track 2 Data: size = 37, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Track_2_Data =
            new ISO_8583_1987_FIELD(35, "Track 2 Data", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 37);
        /// <summary>
        /// Track 3 Data: size = 104, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Track_3_Data =
            new ISO_8583_1987_FIELD(36, "Track 3 Data", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 104);
        /// <summary>
        /// Retrieval Reference Number: size = 12, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Retrieval_Reference_Number =
            new ISO_8583_1987_FIELD(37, "Retrieval Reference Number", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 12);
        /// <summary>
        /// Approval Code: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Approval_Code =
            new ISO_8583_1987_FIELD(38, "Approval Code", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 6);
        /// <summary>
        /// Response Code: size = 2, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Response_Code =
            new ISO_8583_1987_FIELD(39, "Response Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 2);
        /// <summary>
        /// Service Restriction Code: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Service_Restriction_Code =
            new ISO_8583_1987_FIELD(40, "Service Restriction Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Card Acceptor Terminal Id: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Card_Acceptor_Terminal_Id =
            new ISO_8583_1987_FIELD(41, "Card Acceptor Terminal Id", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Card Acceptor Id Code: size = 15, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Card_Acceptor_Id_Code =
            new ISO_8583_1987_FIELD(42, "Card Acceptor Id Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 15);
        /// <summary>
        /// Card Acceptor Name/Location: size = 40, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Card_Acceptor_Name_Location =
            new ISO_8583_1987_FIELD(43, "Card Acceptor Name/Location", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 40);
        /// <summary>
        /// Additional Response Data: size = 25, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Additional_Response_Data =
            new ISO_8583_1987_FIELD(44, "Additional Response Data", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 25);
        /// <summary>
        /// Track 1 Data: size = 76, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Track_1_Data =
            new ISO_8583_1987_FIELD(45, "Track 1 Data", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 76);
        /// <summary>
        /// Additional Data - ISO: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Additional_Data_ISO =
            new ISO_8583_1987_FIELD(46, "Additional Data - ISO", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Additional Data - National: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Additional_Data_National =
            new ISO_8583_1987_FIELD(47, "Additional Data - National", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Additional Data - Private: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Additional_Data_Private =
            new ISO_8583_1987_FIELD(48, "Additional Data - Private", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Currency Code, Txn: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Currency_Code_Txn =
            new ISO_8583_1987_FIELD(49, "Currency Code, Txn", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Currency Code, Settlement: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Currency_Code_Settlement =
            new ISO_8583_1987_FIELD(50, "Currency Code, Settlement", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Currency Code, Cardholder Billing: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Currency_Code_Cardholder_Billing =
            new ISO_8583_1987_FIELD(51, "Currency Code, Cardholder Billing", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Personal Id Number (PIN) Data: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Personal_Id_Number_PIN_Data =
            new ISO_8583_1987_FIELD(52, "Personal Id Number (PIN) Data", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Security Related Control Information: size = 16, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Security_Related_Control_Information =
            new ISO_8583_1987_FIELD(53, "Security Related Control Information", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 16);
        /// <summary>
        /// Amounts, Additional: size = 120, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amounts_Additional =
            new ISO_8583_1987_FIELD(54, "Amounts, Additional", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 120);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_1 =
            new ISO_8583_1987_FIELD(55, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_2 =
            new ISO_8583_1987_FIELD(56, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_1 =
            new ISO_8583_1987_FIELD(57, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_2 =
            new ISO_8583_1987_FIELD(58, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_3 =
            new ISO_8583_1987_FIELD(59, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_1 =
            new ISO_8583_1987_FIELD(60, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_2 =
            new ISO_8583_1987_FIELD(61, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_3 =
            new ISO_8583_1987_FIELD(62, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_4 =
            new ISO_8583_1987_FIELD(63, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Message Authentication Code Field: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Message_Authentication_Code_Field_1 =
            new ISO_8583_1987_FIELD(64, "Message Authentication Code Field", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Reserved for ISO use: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_3 =
            new ISO_8583_1987_FIELD(65, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Code, Settlement: size = 1, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Code_Settlement =
            new ISO_8583_1987_FIELD(66, "Code, Settlement", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 1);
        /// <summary>
        /// Extended Payment Code: size = 2, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Extended_Payment_Code =
            new ISO_8583_1987_FIELD(67, "Extended Payment Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 2);
        /// <summary>
        /// Country Code, Receiving Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Country_Code_Receiving_Inst =
            new ISO_8583_1987_FIELD(68, "Country Code, Receiving Inst", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Country Code, Settlement Inst: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Country_Code_Settlement_Inst =
            new ISO_8583_1987_FIELD(69, "Country Code, Settlement Inst", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Network Management Information Code: size = 3, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Network_Management_Information_Code =
            new ISO_8583_1987_FIELD(70, "Network Management Information Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 3);
        /// <summary>
        /// Message Number: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Message_Number =
            new ISO_8583_1987_FIELD(71, "Message Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Message Number Last: size = 4, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Message_Number_Last =
            new ISO_8583_1987_FIELD(72, "Message Number Last", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 4);
        /// <summary>
        /// Date, Action: size = 6, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Date_Action =
            new ISO_8583_1987_FIELD(73, "Date, Action", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 6);
        /// <summary>
        /// Credits, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Credits_Number =
            new ISO_8583_1987_FIELD(74, "Credits, Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Credits, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Credits_Reversal_Number =
            new ISO_8583_1987_FIELD(75, "Credits, Reversal Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Debits, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Debits_Number =
            new ISO_8583_1987_FIELD(76, "Debits, Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Debits, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Debits_Reversal_Number =
            new ISO_8583_1987_FIELD(77, "Debits, Reversal Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Transfer, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Transfer_Number =
            new ISO_8583_1987_FIELD(78, "Transfer, Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Transfer, Reversal Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Transfer_Reversal_Number =
            new ISO_8583_1987_FIELD(79, "Transfer, Reversal Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Inquiries, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Inquiries_Number =
            new ISO_8583_1987_FIELD(80, "Inquiries, Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Authorization, Number: size = 10, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Authorization_Number =
            new ISO_8583_1987_FIELD(81, "Authorization, Number", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 10);
        /// <summary>
        /// Credits, Processing Fee: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Credits_Processing_Fee =
            new ISO_8583_1987_FIELD(82, "Credits, Processing Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Credits, Txn Fee: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Credits_Txn_Fee =
            new ISO_8583_1987_FIELD(83, "Credits, Txn Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Debits, Processing Fee: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Debits_Processing_Fee =
            new ISO_8583_1987_FIELD(84, "Debits, Processing Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Debits, Txn Fee: size = 12, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Debits_Txn_Fee =
            new ISO_8583_1987_FIELD(85, "Debits, Txn Fee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 12);
        /// <summary>
        /// Credits, Amount: size = 15, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Credits_Amount =
            new ISO_8583_1987_FIELD(86, "Credits, Amount", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 15);
        /// <summary>
        /// Credits, Reversal Amount: size = 15, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Credits_Reversal_Amount =
            new ISO_8583_1987_FIELD(87, "Credits, Reversal Amount", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 15);
        /// <summary>
        /// Debits, Amount: size = 15, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Debits_Amount =
            new ISO_8583_1987_FIELD(88, "Debits, Amount", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 15);
        /// <summary>
        /// Debits, Reversal Amount: size = 15, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Debits_Reversal_Amount =
            new ISO_8583_1987_FIELD(89, "Debits, Reversal Amount", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 15);
        /// <summary>
        /// Original Data Elements: size = 42, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Original_Data_Elements =
            new ISO_8583_1987_FIELD(90, "Original Data Elements", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 42);
        /// <summary>
        /// File Update Code: size = 1, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD File_Update_Code =
            new ISO_8583_1987_FIELD(91, "File Update Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 1);
        /// <summary>
        /// File Security Code: size = 2, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD File_Security_Code =
            new ISO_8583_1987_FIELD(92, "File Security Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 2);
        /// <summary>
        /// Response Indicator: size = 5, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Response_Indicator =
            new ISO_8583_1987_FIELD(93, "Response Indicator", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 5);
        /// <summary>
        /// Service Indicator: size = 7, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Service_Indicator =
            new ISO_8583_1987_FIELD(94, "Service Indicator", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 7);
        /// <summary>
        /// Amount, Replacement: size = 42, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Replacement =
            new ISO_8583_1987_FIELD(95, "Amount, Replacement", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 42);
        /// <summary>
        /// Message Security Code: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Message_Security_Code =
            new ISO_8583_1987_FIELD(96, "Message Security Code", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 8);
        /// <summary>
        /// Amount, Net Settlement: size = 17, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Amount_Net_Settlement =
            new ISO_8583_1987_FIELD(97, "Amount, Net Settlement", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 17);
        /// <summary>
        /// Payee: size = 25, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Payee =
            new ISO_8583_1987_FIELD(98, "Payee", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 25);
        /// <summary>
        /// Settlement Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Settlement_Inst_Id_Code =
            new ISO_8583_1987_FIELD(99, "Settlement Inst Id Code", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// Receiving Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Receiving_Inst_Id_Code =
            new ISO_8583_1987_FIELD(100, "Receiving Inst Id Code", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 11);
        /// <summary>
        /// File Name: size = 17, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD File_Name =
            new ISO_8583_1987_FIELD(101, "File Name", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 17);
        /// <summary>
        /// Account Id 1: size = 28, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Account_Id_1 =
            new ISO_8583_1987_FIELD(102, "Account Id 1", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 28);
        /// <summary>
        /// Account Id 2: size = 28, Variable - 0..99
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Account_Id_2 =
            new ISO_8583_1987_FIELD(103, "Account Id 2", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_99, 28);
        /// <summary>
        /// Txn Description: size = 100, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Txn_Description =
            new ISO_8583_1987_FIELD(104, "Txn Description", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 100);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_4 =
            new ISO_8583_1987_FIELD(105, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_5 =
            new ISO_8583_1987_FIELD(106, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_6 =
            new ISO_8583_1987_FIELD(107, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_7 =
            new ISO_8583_1987_FIELD(108, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_8 =
            new ISO_8583_1987_FIELD(109, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_9 =
            new ISO_8583_1987_FIELD(110, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_ISO_use_10 =
            new ISO_8583_1987_FIELD(111, "Reserved for ISO use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_4 =
            new ISO_8583_1987_FIELD(112, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_5 =
            new ISO_8583_1987_FIELD(113, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_6 =
            new ISO_8583_1987_FIELD(114, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_7 =
            new ISO_8583_1987_FIELD(115, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_8 =
            new ISO_8583_1987_FIELD(116, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_9 =
            new ISO_8583_1987_FIELD(117, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_10 =
            new ISO_8583_1987_FIELD(118, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_National_use_11 =
            new ISO_8583_1987_FIELD(119, "Reserved for National use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_5 =
            new ISO_8583_1987_FIELD(120, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_6 =
            new ISO_8583_1987_FIELD(121, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_7 =
            new ISO_8583_1987_FIELD(122, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_8 =
            new ISO_8583_1987_FIELD(123, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_9 =
            new ISO_8583_1987_FIELD(124, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_10 =
            new ISO_8583_1987_FIELD(125, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_11 =
            new ISO_8583_1987_FIELD(126, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Reserved_for_Private_use_12 =
            new ISO_8583_1987_FIELD(127, "Reserved for Private use", STANDARD.ISO_8583_1987, FIELD_TYPE.VARIABLE_999, 999);
        /// <summary>
        /// Message Authentication Code Field: size = 8, fixed data
        /// </summary>
        public static readonly ISO_8583_1987_FIELD Message_Authentication_Code_Field_2 =
            new ISO_8583_1987_FIELD(128, "Message Authentication Code Field", STANDARD.ISO_8583_1987, FIELD_TYPE.FIXED, 8);

        protected ISO_8583_1987_FIELD(uint position, string description, STANDARD standard, FIELD_TYPE fieldType, ushort maxFieldSize) :
            base(position, description, standard, fieldType, maxFieldSize)
        {
        }
    }
}
