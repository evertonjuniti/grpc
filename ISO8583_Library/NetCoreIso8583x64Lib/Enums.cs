namespace NetCoreIso8583x64Lib
{
    public enum STANDARD: ushort
    {
        ISO_8583_1993 = 0,
        ISO_8583_1987 = 1
    }

    public enum FIELD_TYPE
    {
        FIXED,
        BITMAP,
        VARIABLE_99,
        VARIABLE_999
    }

    public enum ISO_8583_1993: uint
    {
        /// <summary>
        /// Message Type Indicator: size = 4, fixed data
        /// </summary>
        Message_Type_Indicator = 0,
        /// <summary>
        /// Bitmap: size = 16, NB special type for bitmap continuation bit
        /// </summary>
        Bitmap = 1,
        /// <summary>
        /// Primary Account Number: size = 19, Variable - 0..99
        /// </summary>
        Primary_Account_Number = 2,
        /// <summary>
        /// Processing Code: size = 6, fixed data
        /// </summary>
        Processing_Code = 3,
        /// <summary>
        /// Amount, Txn: size = 12, fixed data
        /// </summary>
        Amount_Txn = 4,
        /// <summary>
        /// Amount, Reconciliation: size = 12, fixed data
        /// </summary>
        Amount_Reconciliation = 5,
        /// <summary>
        /// Amount, Cardholder Billing: size = 12, fixed data
        /// </summary>
        Amount_Cardholder_Billing = 6,
        /// <summary>
        /// Date and Time, Transmission: size = 10, fixed data
        /// </summary>
        Date_and_Time_Transmission = 7,
        /// <summary>
        /// Amount, Cardholder Billing Fee: size = 8, fixed data
        /// </summary>
        Amount_Cardholder_Billing_Fee = 8,
        /// <summary>
        /// Conversion Rate, Reconciliation: size = 8, fixed data
        /// </summary>
        Conversion_Rate_Reconciliation = 9,
        /// <summary>
        /// Conversion Rate, Cardholder Billing: size = 8, fixed data
        /// </summary>
        Conversion_Rate_Cardholder_Billing = 10,
        /// <summary>
        /// Systems Trace Audit Number: size = 6, fixed data
        /// </summary>
        Systems_Trace_Audit_Number = 11,
        /// <summary>
        /// Date and Time, Local Txn: size = 12, fixed data
        /// </summary>
        Date_and_Time_Local_Txn = 12,
        /// <summary>
        /// Date, Effective: size = 4, fixed data
        /// </summary>
        Date_Effective = 13,
        /// <summary>
        /// Date, Expiration: size = 4, fixed data
        /// </summary>
        Date_Expiration = 14,
        /// <summary>
        /// Date, Settlement: size = 6, fixed data
        /// </summary>
        Date_Settlement = 15,
        /// <summary>
        /// Date, Conversion: size = 4, fixed data
        /// </summary>
        Date_Conversion = 16,
        /// <summary>
        /// Date, Capture: size = 4, fixed data
        /// </summary>
        Date_Capture = 17,
        /// <summary>
        /// Merchant Type: size = 4, fixed data
        /// </summary>
        Merchant_Type = 18,
        /// <summary>
        /// Country Code, Acquiring Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Acquiring_Inst = 19,
        /// <summary>
        /// Country Code, Primary Account Number: size = 3, fixed data
        /// </summary>
        Country_Code_Primary_Account_Number = 20,
        /// <summary>
        /// Country Code, Forwarding Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Forwarding_Inst = 21,
        /// <summary>
        /// Point of Service Data Code: size = 12, fixed data
        /// </summary>
        Point_of_Service_Data_Code = 22,
        /// <summary>
        /// Card Sequence Number: size = 3, fixed data
        /// </summary>
        Card_Sequence_Number = 23,
        /// <summary>
        /// Function Code: size = 3, fixed data
        /// </summary>
        Function_Code = 24,
        /// <summary>
        /// Message Reason Code: size = 4, fixed data
        /// </summary>
        Message_Reason_Code = 25,
        /// <summary>
        /// Card Acceptor Business Code: size = 4, fixed data
        /// </summary>
        Card_Acceptor_Business_Code = 26,
        /// <summary>
        /// Approval Code Length: size = 1, fixed data
        /// </summary>
        Approval_Code_Length = 27,
        /// <summary>
        /// Date, Reconciliation: size = 6, fixed data
        /// </summary>
        Date_Reconciliation = 28,
        /// <summary>
        /// Reconciliation Indicator: size = 3, fixed data
        /// </summary>
        Reconciliation_Indicator = 29,
        /// <summary>
        /// Amounts, Original: size = 24, fixed data
        /// </summary>
        Amounts_Original = 30,
        /// <summary>
        /// Acquirer Reference Data: size = 24, Variable - 0..99
        /// </summary>
        Acquirer_Reference_Data = 31,
        /// <summary>
        /// Acquirer Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Acquirer_Inst_Id_Code = 32,
        /// <summary>
        /// Forwarding Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Forwarding_Inst_Id_Code = 33,
        /// <summary>
        /// Primary Account Number, Extended: size = 28, Variable - 0..99
        /// </summary>
        Primary_Account_Number_Extended = 34,
        /// <summary>
        /// Track 2 Data, Extended: size = 37, Variable - 0..99
        /// </summary>
        Track_2_Data = 35,
        /// <summary>
        /// Track 3 Data: size = 104, Variable - Variable - 0..999
        /// </summary>
        Track_3_Data = 36,
        /// <summary>
        /// Retrieval Reference Number: size = 12, fixed data
        /// </summary>
        Retrieval_Reference_Number = 37,
        /// <summary>
        /// Approval Code: size = 6, fixed data
        /// </summary>
        Approval_Code = 38,
        /// <summary>
        /// Action Code: size = 3, fixed data
        /// </summary>
        Action_Code = 39,
        /// <summary>
        /// Service Code: size = 3, fixed data
        /// </summary>
        Service_Code = 40,
        /// <summary>
        /// Card Acceptor Terminal Id: size = 8, fixed data
        /// </summary>
        Card_Acceptor_Terminal_Id = 41,
        /// <summary>
        /// Card Acceptor Id Code: size = 15, fixed data
        /// </summary>
        Card_Acceptor_Id_Code = 42,
        /// <summary>
        /// Card Acceptor Name/Location: size = 99, Variable - 0..99
        /// </summary>
        Card_Acceptor_Name_Location = 43,
        /// <summary>
        /// Additional Response Data: size = 99, Variable - 0..99
        /// </summary>
        Additional_Response_Data = 44,
        /// <summary>
        /// Track 1 Data: size = 76, Variable - 0..99
        /// </summary>
        Track_1_Data = 45,
        /// <summary>
        /// Amounts, Fees: size = 204, Variable - Variable - 0..999
        /// </summary>
        Amounts_Fees = 46,
        /// <summary>
        /// Additional Data - National: size = 999, Variable - Variable - 0..999
        /// </summary>
        Additional_Data_National = 47,
        /// <summary>
        /// Additional Data - Private: size = 999, Variable - Variable - 0..999
        /// </summary>
        Additional_Data_Private = 48,
        /// <summary>
        /// Currency Code, Txn: size = 3, fixed data
        /// </summary>
        Currency_Code_Txn = 49,
        /// <summary>
        /// Currency Code, Reconciliation: size = 3, fixed data
        /// </summary>
        Currency_Code_Reconciliation = 50,
        /// <summary>
        /// Currency Code, Cardholder Billing: size = 3, fixed data
        /// </summary>
        Currency_Code_Cardholder_Billing = 51,
        /// <summary>
        /// Personal Id Number (PIN) Data: size = 8, fixed data
        /// </summary>
        Personal_Id_Number_PIN_Data = 52,
        /// <summary>
        /// Security Related Control Information: size = 48, Variable - 0..99
        /// </summary>
        Security_Related_Control_Information = 53,
        /// <summary>
        /// Amounts, Additional: size = 120, Variable - Variable - 0..999
        /// </summary>
        Amounts_Additional = 54,
        /// <summary>
        /// IC Card System Related Data: size = 255, Variable - Variable - 0..999
        /// </summary>
        IC_Card_System_Related_Data = 55,
        /// <summary>
        /// Original Data Elements: size = 35, Variable - 0..99
        /// </summary>
        Original_Data_Elements = 56,
        /// <summary>
        /// Authorization Life Cycle Code: size = 3, fixed data
        /// </summary>
        Authorization_Life_Cycle_Code = 57,
        /// <summary>
        /// Authorizing Agent Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Authorizing_Agent_Inst_Id_Code = 58,
        /// <summary>
        /// Transport Data: size = 999, Variable - Variable - 0..999
        /// </summary>
        Transport_Data = 59,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_1 = 60,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_2 = 61,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_1 = 62,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_2 = 63,
        /// <summary>
        /// Message Authentication Code Field: size = 8, fixed data
        /// </summary>
        Message_Authentication_Code_Field_1 = 64,
        /// <summary>
        /// Reserved for ISO use: size = 8, fixed data
        /// </summary>
        Reserved_for_ISO_use = 65,
        /// <summary>
        /// Amounts, Original Fees: size = 204, Variable - Variable - 0..999
        /// </summary>
        Amounts_Original_Fees = 66,
        /// <summary>
        /// Extended Payment Data: size = 2, fixed data
        /// </summary>
        Extended_Payment_Data = 67,
        /// <summary>
        /// Country Code, Receiving Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Receiving_Inst = 68,
        /// <summary>
        /// Country Code, Settlement Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Settlement_Inst = 69,
        /// <summary>
        /// Country Code, Authorizing Agent Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Authorizing_Agent_Inst = 70,
        /// <summary>
        /// Message Number: size = 6, fixed data
        /// </summary>
        Message_Number = 71,
        /// <summary>
        /// Data Record: size = 999, Variable - Variable - 0..999
        /// </summary>
        Data_Record = 72,
        /// <summary>
        /// Date, Action: size = 6, fixed data
        /// </summary>
        Date_Action = 73,
        /// <summary>
        /// Credits, Number: size = 10, fixed data
        /// </summary>
        Credits_Number = 74,
        /// <summary>
        /// Credits, Reversal Number: size = 10, fixed data
        /// </summary>
        Credits_Reversal_Number = 75,
        /// <summary>
        /// Debits, Number: size = 10, fixed data
        /// </summary>
        Debits_Number = 76,
        /// <summary>
        /// Debits, Reversal Number: size = 10, fixed data
        /// </summary>
        Debits_Reversal_Number = 77,
        /// <summary>
        /// Transfer, Number: size = 10, fixed data
        /// </summary>
        Transfer_Number = 78,
        /// <summary>
        /// Transfer, Reversal Number: size = 10, fixed data
        /// </summary>
        Transfer_Reversal_Number = 79,
        /// <summary>
        /// Inquiries, Number: size = 10, fixed data
        /// </summary>
        Inquiries_Number = 80,
        /// <summary>
        /// Authorizations, Number: size = 10, fixed data
        /// </summary>
        Authorizations_Number = 81,
        /// <summary>
        /// Inquiries, Reversal Number: size = 10, fixed data
        /// </summary>
        Inquiries_Reversal_Number = 82,
        /// <summary>
        /// Payments, Number: size = 10, fixed data
        /// </summary>
        Payments_Number = 83,
        /// <summary>
        /// Payments, Reversal Number: size = 10, fixed data
        /// </summary>
        Payments_Reversal_Number = 84,
        /// <summary>
        /// Fee Collections, Number: size = 10, fixed data
        /// </summary>
        Fee_Collections_Number = 85,
        /// <summary>
        /// Credits, Amount: size = 16, fixed data
        /// </summary>
        Credits_Amount = 86,
        /// <summary>
        /// Credits, Reversal Amount: size = 16, fixed data
        /// </summary>
        Credits_Reversal_Amount = 87,
        /// <summary>
        /// Debits, Amount: size = 16, fixed data
        /// </summary>
        Debits_Amount = 88,
        /// <summary>
        /// Debits, Reversal Amount: size = 16, fixed data
        /// </summary>
        Debits_Reversal_Amount = 89,
        /// <summary>
        /// Authorizations, Reversal Number: size = 10, fixed data
        /// </summary>
        Authorizations_Reversal_Number = 90,
        /// <summary>
        /// Country Code, Txn Destination Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Txn_Destination_Inst = 91,
        /// <summary>
        /// Country Code, Txn Originator Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Txn_Originator_Inst = 92,
        /// <summary>
        /// Txn Destination Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Txn_Destination_Inst_Id_Code = 93,
        /// <summary>
        /// Txn Originator Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Txn_Originator_Inst_Id_Code = 94,
        /// <summary>
        /// Card Issuer Reference Data: size = 99, Variable - 0..99
        /// </summary>
        Card_Issuer_Reference_Data = 95,
        /// <summary>
        /// Key Management Data: size = 999, Variable - Variable - 0..999
        /// </summary>
        Key_Management_Data = 96,
        /// <summary>
        /// Amount, Net Reconciliation: size = 17, fixed data
        /// </summary>
        Amount_Net_Reconciliation = 97,
        /// <summary>
        /// Payee: size = 25, fixed data
        /// </summary>
        Payee = 98,
        /// <summary>
        /// Settlement Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Settlement_Inst_Id_Code = 99,
        /// <summary>
        /// Receiving Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Receiving_Inst_Id_Code = 100,
        /// <summary>
        /// File Name: size = 17, Variable - 0..99
        /// </summary>
        File_Name = 101,
        /// <summary>
        /// Account Id 1: size = 28, Variable - 0..99
        /// </summary>
        Account_Id_1 = 102,
        /// <summary>
        /// Account Id 2: size = 28, Variable - 0..99
        /// </summary>
        Account_Id_2 = 103,
        /// <summary>
        /// Txn Description: size = 100, Variable - Variable - 0..999
        /// </summary>
        Txn_Description = 104,
        /// <summary>
        /// Credits, Chargeback Amount: size = 16, fixed data
        /// </summary>
        Credits_Chargeback_Amount = 105,
        /// <summary>
        /// Debits, Chargeback Amount: size = 16, fixed data
        /// </summary>
        Debits_Chargeback_Amount = 106,
        /// <summary>
        /// Credits, Chargeback Number: size = 10, fixed data
        /// </summary>
        Credits_Chargeback_Number = 107,
        /// <summary>
        /// Debits, Chargeback Number: size = 10, fixed data
        /// </summary>
        Debits_Chargeback_Number = 108,
        /// <summary>
        /// Credits, Fee Amounts: size = 84, Variable - 0..99
        /// </summary>
        Credits_Fee_Amounts = 109,
        /// <summary>
        /// Debits, Fee Amounts: size = 84, Variable - 0..99
        /// </summary>
        Debits_Fee_Amounts = 110,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_1 = 111,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_2 = 112,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_3 = 113,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_4 = 114,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_5 = 115,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_3 = 116,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_4 = 117,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_5 = 118,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_6 = 119,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_7 = 120,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_8 = 121,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_National_use_9 = 122,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_3 = 123,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_4 = 124,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_5 = 125,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_6 = 126,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_7 = 127,
        /// <summary>
        /// Message Authentication Code Field: size = 8, fixed data
        /// </summary>
        Message_Authentication_Code_Field_2 = 128
    }

    public enum ISO_8583_1987: uint
    {
        /// <summary>
        /// Message Type Indicator: size = 4, fixed data
        /// </summary>
        Message_Type_Indicator = 0,
        /// <summary>
        /// Bitmap: size = 16, NB special type for bitmap continuation bit
        /// </summary>
        Bitmap = 1,
        /// <summary>
        /// Primary Account Number: size = 19, Variable - 0..99
        /// </summary>
        Primary_Account_Number = 2,
        /// <summary>
        /// Processing Code: size = 6, fixed data
        /// </summary>
        Processing_Code = 3,
        /// <summary>
        /// Amount, Txn: size = 12, fixed data
        /// </summary>
        Amount_Txn = 4,
        /// <summary>
        /// Amount, Settlement: size = 12, fixed data
        /// </summary>
        Amount_Settlement = 5,
        /// <summary>
        /// Amount, Cardholder Billing: size = 12, fixed data
        /// </summary>
        Amount_Cardholder_Billing = 6,
        /// <summary>
        /// Date and Time, Transmission: size = 10, fixed data
        /// </summary>
        Date_and_Time_Transmission = 7,
        /// <summary>
        /// Amount, Cardholder Billing Fee: size = 8, fixed data
        /// </summary>
        Amount_Cardholder_Billing_Fee = 8,
        /// <summary>
        /// Conversion Rate, Settlement: size = 8, fixed data
        /// </summary>
        Conversion_Rate_Settlement = 9,
        /// <summary>
        /// Conversion Rate, Cardholder Billing: size = 8, fixed data
        /// </summary>
        Conversion_Rate_Cardholder_Billing = 10,
        /// <summary>
        /// Systems Trace Audit Number: size = 6, fixed data
        /// </summary>
        Systems_Trace_Audit_Number = 11,
        /// <summary>
        /// Time, Local Txn: size = 6, fixed data
        /// </summary>
        Time_Local_Txn = 12,
        /// <summary>
        /// Date, Local Txn: size = 4, fixed data
        /// </summary>
        Date_Local_Txn = 13,
        /// <summary>
        /// Date, Expiration: size = 4, fixed data
        /// </summary>
        Date_Expiration = 14,
        /// <summary>
        /// Date, Settlement: size = 6, fixed data
        /// </summary>
        Date_Settlement = 15,
        /// <summary>
        /// Date, Conversion: size = 4, fixed data
        /// </summary>
        Date_Conversion = 16,
        /// <summary>
        /// Date, Capture: size = 4, fixed data
        /// </summary>
        Date_Capture = 17,
        /// <summary>
        /// Merchant Type: size = 4, fixed data
        /// </summary>
        Merchant_Type = 18,
        /// <summary>
        /// Country Code, Acquiring Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Acquiring_Inst = 19,
        /// <summary>
        /// Country Code, Primary Account Number: size = 3, fixed data
        /// </summary>
        Country_Code_Primary_Account_Number = 20,
        /// <summary>
        /// Country Code, Forwarding Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Forwarding_Inst = 21,
        /// <summary>
        /// Point of Service Entry Mode: size = 3, fixed data
        /// </summary>
        Point_of_Service_Entry_Mode = 22,
        /// <summary>
        /// Application PAN number: size = 3, fixed data
        /// </summary>
        Application_PAN_number = 23,
        /// <summary>
        /// Network International Identifier: size = 3, fixed data
        /// </summary>
        Network_International_Identifier = 24,
        /// <summary>
        /// Point of Service Condition Code: size = 2, fixed data
        /// </summary>
        Point_of_Service_Condition_Code = 25,
        /// <summary>
        /// Point of Service PIN Capture Code: size = 2, fixed data
        /// </summary>
        Point_of_Service_PIN_Capture_Code = 26,
        /// <summary>
        /// Authorization Identification Response Length: size = 1, fixed data
        /// </summary>
        Authorization_Identification_Response_Length = 27,
        /// <summary>
        /// Amount, Txn Fee: size = 9, fixed data
        /// </summary>
        Amount_Txn_Fee = 28,
        /// <summary>
        /// Amount, Settlement Fee: size = 9, fixed data
        /// </summary>
        Amount_Settlement_Fee = 29,
        /// <summary>
        /// Amount, Txn Processing Fee: size = 9, fixed data
        /// </summary>
        Amount_Txn_Processing_Fee = 30,
        /// <summary>
        /// Amount, Settlement Processing Fee: size = 9, fixed data
        /// </summary>
        Amount_Settlement_Processing_Fee = 31,
        /// <summary>
        /// Acquirer Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Acquirer_Inst_Id_Code = 32,
        /// <summary>
        /// Forwarding Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Forwarding_Inst_Id_Code = 33,
        /// <summary>
        /// Primary Account Number, Extended: size = 28, Variable - 0..99
        /// </summary>
        Primary_Account_Number_Extended = 34,
        /// <summary>
        /// Track 2 Data: size = 37, Variable - 0..99
        /// </summary>
        Track_2_Data = 35,
        /// <summary>
        /// Track 3 Data: size = 104, Variable - 0..999
        /// </summary>
        Track_3_Data = 36,
        /// <summary>
        /// Retrieval Reference Number: size = 12, Variable - 0..99
        /// </summary>
        Retrieval_Reference_Number = 37,
        /// <summary>
        /// Approval Code: size = 6, fixed data
        /// </summary>
        Approval_Code = 38,
        /// <summary>
        /// Response Code: size = 2, fixed data
        /// </summary>
        Response_Code = 39,
        /// <summary>
        /// Service Restriction Code: size = 3, fixed data
        /// </summary>
        Service_Restriction_Code = 40,
        /// <summary>
        /// Card Acceptor Terminal Id: size = 3, fixed data
        /// </summary>
        Card_Acceptor_Terminal_Id = 41,
        /// <summary>
        /// Card Acceptor Id Code: size = 15, fixed data
        /// </summary>
        Card_Acceptor_Id_Code = 42,
        /// <summary>
        /// Card Acceptor Name/Location: size = 40, fixed data
        /// </summary>
        Card_Acceptor_Name_Location = 43,
        /// <summary>
        /// Additional Response Data: size = 25, Variable - 0..99
        /// </summary>
        Additional_Response_Data = 44,
        /// <summary>
        /// Track 1 Data: size = 76, Variable - 0..99
        /// </summary>
        Track_1_Data = 45,
        /// <summary>
        /// Additional Data - ISO: size = 999, Variable - 0..999
        /// </summary>
        Additional_Data_ISO = 46,
        /// <summary>
        /// Additional Data - National: size = 999, Variable - 0..999
        /// </summary>
        Additional_Data_National = 47,
        /// <summary>
        /// Additional Data - Private: size = 999, Variable - 0..999
        /// </summary>
        Additional_Data_Private = 48,
        /// <summary>
        /// Currency Code, Txn: size = 3, fixed data
        /// </summary>
        Currency_Code_Txn = 49,
        /// <summary>
        /// Currency Code, Settlement: size = 3, fixed data
        /// </summary>
        Currency_Code_Settlement = 50,
        /// <summary>
        /// Currency Code, Cardholder Billing: size = 3, fixed data
        /// </summary>
        Currency_Code_Cardholder_Billing = 51,
        /// <summary>
        /// Personal Id Number (PIN) Data: size = 8, fixed data
        /// </summary>
        Personal_Id_Number_PIN_Data = 52,
        /// <summary>
        /// Security Related Control Information: size = 16, fixed data
        /// </summary>
        Security_Related_Control_Information = 53,
        /// <summary>
        /// Amounts, Additional: size = 120, Variable - 0..999
        /// </summary>
        Amounts_Additional = 54,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_1 = 55,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_2 = 56,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_1 = 57,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_2 = 58,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_3 = 59,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_1 = 60,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_2 = 61,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_3 = 62,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_4 = 63,
        /// <summary>
        /// Message Authentication Code Field: size = 8, fixed data
        /// </summary>
        Message_Authentication_Code_Field_1 = 64,
        /// <summary>
        /// Reserved for ISO use: size = 8, fixed data
        /// </summary>
        Reserved_for_ISO_use_3 = 65,
        /// <summary>
        /// Code, Settlement: size = 1, fixed data
        /// </summary>
        Code_Settlement = 66,
        /// <summary>
        /// Extended Payment Code: size = 2, fixed data
        /// </summary>
        Extended_Payment_Code = 67,
        /// <summary>
        /// Country Code, Receiving Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Receiving_Inst = 68,
        /// <summary>
        /// Country Code, Settlement Inst: size = 3, fixed data
        /// </summary>
        Country_Code_Settlement_Inst = 69,
        /// <summary>
        /// Network Management Information Code: size = 3, fixed data
        /// </summary>
        Network_Management_Information_Code = 70,
        /// <summary>
        /// Message Number: size = 4, fixed data
        /// </summary>
        Message_Number = 71,
        /// <summary>
        /// Message Number Last: size = 4, fixed data
        /// </summary>
        Message_Number_Last = 72,
        /// <summary>
        /// Date, Action: size = 6, fixed data
        /// </summary>
        Date_Action = 73,
        /// <summary>
        /// Credits, Number: size = 10, fixed data
        /// </summary>
        Credits_Number = 74,
        /// <summary>
        /// Credits, Reversal Number: size = 10, fixed data
        /// </summary>
        Credits_Reversal_Number = 75,
        /// <summary>
        /// Debits, Number: size = 10, fixed data
        /// </summary>
        Debits_Number = 76,
        /// <summary>
        /// Debits, Reversal Number: size = 10, fixed data
        /// </summary>
        Debits_Reversal_Number = 77,
        /// <summary>
        /// Transfer, Number: size = 10, fixed data
        /// </summary>
        Transfer_Number = 78,
        /// <summary>
        /// Transfer, Reversal Number: size = 10, fixed data
        /// </summary>
        Transfer_Reversal_Number = 79,
        /// <summary>
        /// Inquiries, Number: size = 10, fixed data
        /// </summary>
        Inquiries_Number = 80,
        /// <summary>
        /// Authorization, Number: size = 10, fixed data
        /// </summary>
        Authorization_Number = 81,
        /// <summary>
        /// Credits, Processing Fee: size = 12, fixed data
        /// </summary>
        Credits_Processing_Fee = 82,
        /// <summary>
        /// Credits, Txn Fee: size = 12, fixed data
        /// </summary>
        Credits_Txn_Fee = 83,
        /// <summary>
        /// Debits, Processing Fee: size = 12, fixed data
        /// </summary>
        Debits_Processing_Fee = 84,
        /// <summary>
        /// Debits, Txn Fee: size = 12, fixed data
        /// </summary>
        Debits_Txn_Fee = 85,
        /// <summary>
        /// Credits, Amount: size = 15, fixed data
        /// </summary>
        Credits_Amount = 86,
        /// <summary>
        /// Credits, Reversal Amount: size = 15, fixed data
        /// </summary>
        Credits_Reversal_Amount = 87,
        /// <summary>
        /// Debits, Amount: size = 15, fixed data
        /// </summary>
        Debits_Amount = 88,
        /// <summary>
        /// Debits, Reversal Amount: size = 15, fixed data
        /// </summary>
        Debits_Reversal_Amount = 89,
        /// <summary>
        /// Original Data Elements: size = 42, fixed data
        /// </summary>
        Original_Data_Elements = 90,
        /// <summary>
        /// File Update Code: size = 1, fixed data
        /// </summary>
        File_Update_Code = 91,
        /// <summary>
        /// File Security Code: size = 2, fixed data
        /// </summary>
        File_Security_Code = 92,
        /// <summary>
        /// Response Indicator: size = 5, fixed data
        /// </summary>
        Response_Indicator = 93,
        /// <summary>
        /// Service Indicator: size = 7, fixed data
        /// </summary>
        Service_Indicator = 94,
        /// <summary>
        /// Amount, Replacement: size = 42, fixed data
        /// </summary>
        Amount_Replacement = 95,
        /// <summary>
        /// Message Security Code: size = 8, fixed data
        /// </summary>
        Message_Security_Code = 96,
        /// <summary>
        /// Amount, Net Settlement: size = 17, fixed data
        /// </summary>
        Amount_Net_Settlement = 97,
        /// <summary>
        /// Payee: size = 25, fixed data
        /// </summary>
        Payee = 98,
        /// <summary>
        /// Settlement Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Settlement_Inst_Id_Code = 99,
        /// <summary>
        /// Receiving Inst Id Code: size = 11, Variable - 0..99
        /// </summary>
        Receiving_Inst_Id_Code = 100,
        /// <summary>
        /// File Name: size = 17, Variable - 0..99
        /// </summary>
        File_Name = 101,
        /// <summary>
        /// Account Id 1: size = 28, Variable - 0..99
        /// </summary>
        Account_Id_1 = 102,
        /// <summary>
        /// Account Id 2: size = 28, Variable - 0..99
        /// </summary>
        Account_Id_2 = 103,
        /// <summary>
        /// Txn Description: size = 100, Variable - 0..999
        /// </summary>
        Txn_Description = 104,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_4 = 105,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_5 = 106,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_6 = 107,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_7 = 108,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_8 = 109,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_9 = 110,
        /// <summary>
        /// Reserved for ISO use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_ISO_use_10 = 111,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_4 = 112,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_5 = 113,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_6 = 114,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_7 = 115,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_8 = 116,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_9 = 117,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_10 = 118,
        /// <summary>
        /// Reserved for National use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_National_use_11 = 119,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_5 = 120,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_6 = 121,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_7 = 122,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_8 = 123,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_9 = 124,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_10 = 125,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_11 = 126,
        /// <summary>
        /// Reserved for Private use: size = 999, Variable - 0..999
        /// </summary>
        Reserved_for_Private_use_12 = 127,
        /// <summary>
        /// Message Authentication Code Field: size = 8, fixed data
        /// </summary>
        Message_Authentication_Code_Field_2 = 128
    }
}
