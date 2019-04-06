// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace hw.trezor.messages
{

    [global::ProtoBuf.ProtoContract()]
    public enum MessageType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_Initialize")]
        MessageTypeInitialize = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_Ping")]
        MessageTypePing = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_Success")]
        MessageTypeSuccess = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_Failure")]
        MessageTypeFailure = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_ChangePin")]
        MessageTypeChangePin = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_WipeDevice")]
        MessageTypeWipeDevice = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_GetEntropy")]
        MessageTypeGetEntropy = 9,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_Entropy")]
        MessageTypeEntropy = 10,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LoadDevice")]
        MessageTypeLoadDevice = 13,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_ResetDevice")]
        MessageTypeResetDevice = 14,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_Features")]
        MessageTypeFeatures = 17,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_PinMatrixRequest")]
        MessageTypePinMatrixRequest = 18,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_PinMatrixAck")]
        MessageTypePinMatrixAck = 19,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_Cancel")]
        MessageTypeCancel = 20,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_ClearSession")]
        MessageTypeClearSession = 24,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_ApplySettings")]
        MessageTypeApplySettings = 25,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_ButtonRequest")]
        MessageTypeButtonRequest = 26,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_ButtonAck")]
        MessageTypeButtonAck = 27,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_ApplyFlags")]
        MessageTypeApplyFlags = 28,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BackupDevice")]
        MessageTypeBackupDevice = 34,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EntropyRequest")]
        MessageTypeEntropyRequest = 35,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EntropyAck")]
        MessageTypeEntropyAck = 36,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_PassphraseRequest")]
        MessageTypePassphraseRequest = 41,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_PassphraseAck")]
        MessageTypePassphraseAck = 42,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_PassphraseStateRequest")]
        MessageTypePassphraseStateRequest = 77,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_PassphraseStateAck")]
        MessageTypePassphraseStateAck = 78,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_RecoveryDevice")]
        MessageTypeRecoveryDevice = 45,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_WordRequest")]
        MessageTypeWordRequest = 46,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_WordAck")]
        MessageTypeWordAck = 47,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_GetFeatures")]
        MessageTypeGetFeatures = 55,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_SetU2FCounter")]
        MessageTypeSetU2FCounter = 63,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_FirmwareErase")]
        MessageTypeFirmwareErase = 6,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_FirmwareUpload")]
        MessageTypeFirmwareUpload = 7,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_FirmwareRequest")]
        MessageTypeFirmwareRequest = 8,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_SelfTest")]
        MessageTypeSelfTest = 32,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_GetPublicKey")]
        MessageTypeGetPublicKey = 11,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_PublicKey")]
        MessageTypePublicKey = 12,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_SignTx")]
        MessageTypeSignTx = 15,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TxRequest")]
        MessageTypeTxRequest = 21,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TxAck")]
        MessageTypeTxAck = 22,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_GetAddress")]
        MessageTypeGetAddress = 29,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_Address")]
        MessageTypeAddress = 30,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_SignMessage")]
        MessageTypeSignMessage = 38,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_VerifyMessage")]
        MessageTypeVerifyMessage = 39,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MessageSignature")]
        MessageTypeMessageSignature = 40,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CipherKeyValue")]
        MessageTypeCipherKeyValue = 23,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CipheredKeyValue")]
        MessageTypeCipheredKeyValue = 48,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_SignIdentity")]
        MessageTypeSignIdentity = 53,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_SignedIdentity")]
        MessageTypeSignedIdentity = 54,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_GetECDHSessionKey")]
        MessageTypeGetECDHSessionKey = 61,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_ECDHSessionKey")]
        MessageTypeECDHSessionKey = 62,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CosiCommit")]
        MessageTypeCosiCommit = 71,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CosiCommitment")]
        MessageTypeCosiCommitment = 72,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CosiSign")]
        MessageTypeCosiSign = 73,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CosiSignature")]
        MessageTypeCosiSignature = 74,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkDecision")]
        MessageTypeDebugLinkDecision = 100,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkGetState")]
        MessageTypeDebugLinkGetState = 101,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkState")]
        MessageTypeDebugLinkState = 102,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkStop")]
        MessageTypeDebugLinkStop = 103,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkLog")]
        MessageTypeDebugLinkLog = 104,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkMemoryRead")]
        MessageTypeDebugLinkMemoryRead = 110,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkMemory")]
        MessageTypeDebugLinkMemory = 111,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkMemoryWrite")]
        MessageTypeDebugLinkMemoryWrite = 112,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugLinkFlashErase")]
        MessageTypeDebugLinkFlashErase = 113,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumGetPublicKey")]
        MessageTypeEthereumGetPublicKey = 450,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumPublicKey")]
        MessageTypeEthereumPublicKey = 451,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumGetAddress")]
        MessageTypeEthereumGetAddress = 56,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumAddress")]
        MessageTypeEthereumAddress = 57,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumSignTx")]
        MessageTypeEthereumSignTx = 58,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumTxRequest")]
        MessageTypeEthereumTxRequest = 59,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumTxAck")]
        MessageTypeEthereumTxAck = 60,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumSignMessage")]
        MessageTypeEthereumSignMessage = 64,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumVerifyMessage")]
        MessageTypeEthereumVerifyMessage = 65,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EthereumMessageSignature")]
        MessageTypeEthereumMessageSignature = 66,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_NEMGetAddress")]
        MessageTypeNEMGetAddress = 67,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_NEMAddress")]
        MessageTypeNEMAddress = 68,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_NEMSignTx")]
        MessageTypeNEMSignTx = 69,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_NEMSignedTx")]
        MessageTypeNEMSignedTx = 70,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_NEMDecryptMessage")]
        MessageTypeNEMDecryptMessage = 75,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_NEMDecryptedMessage")]
        MessageTypeNEMDecryptedMessage = 76,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskGetAddress")]
        MessageTypeLiskGetAddress = 114,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskAddress")]
        MessageTypeLiskAddress = 115,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskSignTx")]
        MessageTypeLiskSignTx = 116,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskSignedTx")]
        MessageTypeLiskSignedTx = 117,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskSignMessage")]
        MessageTypeLiskSignMessage = 118,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskMessageSignature")]
        MessageTypeLiskMessageSignature = 119,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskVerifyMessage")]
        MessageTypeLiskVerifyMessage = 120,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskGetPublicKey")]
        MessageTypeLiskGetPublicKey = 121,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_LiskPublicKey")]
        MessageTypeLiskPublicKey = 122,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TezosGetAddress")]
        MessageTypeTezosGetAddress = 150,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TezosAddress")]
        MessageTypeTezosAddress = 151,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TezosSignTx")]
        MessageTypeTezosSignTx = 152,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TezosSignedTx")]
        MessageTypeTezosSignedTx = 153,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TezosGetPublicKey")]
        MessageTypeTezosGetPublicKey = 154,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TezosPublicKey")]
        MessageTypeTezosPublicKey = 155,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarSignTx")]
        MessageTypeStellarSignTx = 202,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarTxOpRequest")]
        MessageTypeStellarTxOpRequest = 203,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarGetAddress")]
        MessageTypeStellarGetAddress = 207,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarAddress")]
        MessageTypeStellarAddress = 208,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarCreateAccountOp")]
        MessageTypeStellarCreateAccountOp = 210,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarPaymentOp")]
        MessageTypeStellarPaymentOp = 211,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarPathPaymentOp")]
        MessageTypeStellarPathPaymentOp = 212,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarManageOfferOp")]
        MessageTypeStellarManageOfferOp = 213,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarCreatePassiveOfferOp")]
        MessageTypeStellarCreatePassiveOfferOp = 214,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarSetOptionsOp")]
        MessageTypeStellarSetOptionsOp = 215,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarChangeTrustOp")]
        MessageTypeStellarChangeTrustOp = 216,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarAllowTrustOp")]
        MessageTypeStellarAllowTrustOp = 217,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarAccountMergeOp")]
        MessageTypeStellarAccountMergeOp = 218,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarManageDataOp")]
        MessageTypeStellarManageDataOp = 220,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarBumpSequenceOp")]
        MessageTypeStellarBumpSequenceOp = 221,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_StellarSignedTx")]
        MessageTypeStellarSignedTx = 230,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TronGetAddress")]
        MessageTypeTronGetAddress = 250,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TronAddress")]
        MessageTypeTronAddress = 251,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TronSignTx")]
        MessageTypeTronSignTx = 252,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_TronSignedTx")]
        MessageTypeTronSignedTx = 253,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CardanoSignTx")]
        MessageTypeCardanoSignTx = 303,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CardanoTxRequest")]
        MessageTypeCardanoTxRequest = 304,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CardanoGetPublicKey")]
        MessageTypeCardanoGetPublicKey = 305,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CardanoPublicKey")]
        MessageTypeCardanoPublicKey = 306,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CardanoGetAddress")]
        MessageTypeCardanoGetAddress = 307,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CardanoAddress")]
        MessageTypeCardanoAddress = 308,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CardanoTxAck")]
        MessageTypeCardanoTxAck = 309,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_CardanoSignedTx")]
        MessageTypeCardanoSignedTx = 310,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologyGetAddress")]
        MessageTypeOntologyGetAddress = 350,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologyAddress")]
        MessageTypeOntologyAddress = 351,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologyGetPublicKey")]
        MessageTypeOntologyGetPublicKey = 352,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologyPublicKey")]
        MessageTypeOntologyPublicKey = 353,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologySignTransfer")]
        MessageTypeOntologySignTransfer = 354,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologySignedTransfer")]
        MessageTypeOntologySignedTransfer = 355,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologySignWithdrawOng")]
        MessageTypeOntologySignWithdrawOng = 356,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologySignedWithdrawOng")]
        MessageTypeOntologySignedWithdrawOng = 357,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologySignOntIdRegister")]
        MessageTypeOntologySignOntIdRegister = 358,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologySignedOntIdRegister")]
        MessageTypeOntologySignedOntIdRegister = 359,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologySignOntIdAddAttributes")]
        MessageTypeOntologySignOntIdAddAttributes = 360,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_OntologySignedOntIdAddAttributes")]
        MessageTypeOntologySignedOntIdAddAttributes = 361,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_RippleGetAddress")]
        MessageTypeRippleGetAddress = 400,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_RippleAddress")]
        MessageTypeRippleAddress = 401,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_RippleSignTx")]
        MessageTypeRippleSignTx = 402,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_RippleSignedTx")]
        MessageTypeRippleSignedTx = 403,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionInitRequest")]
        MessageTypeMoneroTransactionInitRequest = 501,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionInitAck")]
        MessageTypeMoneroTransactionInitAck = 502,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionSetInputRequest")]
        MessageTypeMoneroTransactionSetInputRequest = 503,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionSetInputAck")]
        MessageTypeMoneroTransactionSetInputAck = 504,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionInputsPermutationRequest")]
        MessageTypeMoneroTransactionInputsPermutationRequest = 505,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionInputsPermutationAck")]
        MessageTypeMoneroTransactionInputsPermutationAck = 506,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionInputViniRequest")]
        MessageTypeMoneroTransactionInputViniRequest = 507,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionInputViniAck")]
        MessageTypeMoneroTransactionInputViniAck = 508,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionAllInputsSetRequest")]
        MessageTypeMoneroTransactionAllInputsSetRequest = 509,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionAllInputsSetAck")]
        MessageTypeMoneroTransactionAllInputsSetAck = 510,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionSetOutputRequest")]
        MessageTypeMoneroTransactionSetOutputRequest = 511,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionSetOutputAck")]
        MessageTypeMoneroTransactionSetOutputAck = 512,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionAllOutSetRequest")]
        MessageTypeMoneroTransactionAllOutSetRequest = 513,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionAllOutSetAck")]
        MessageTypeMoneroTransactionAllOutSetAck = 514,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionSignInputRequest")]
        MessageTypeMoneroTransactionSignInputRequest = 515,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionSignInputAck")]
        MessageTypeMoneroTransactionSignInputAck = 516,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionFinalRequest")]
        MessageTypeMoneroTransactionFinalRequest = 517,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroTransactionFinalAck")]
        MessageTypeMoneroTransactionFinalAck = 518,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroKeyImageExportInitRequest")]
        MessageTypeMoneroKeyImageExportInitRequest = 530,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroKeyImageExportInitAck")]
        MessageTypeMoneroKeyImageExportInitAck = 531,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroKeyImageSyncStepRequest")]
        MessageTypeMoneroKeyImageSyncStepRequest = 532,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroKeyImageSyncStepAck")]
        MessageTypeMoneroKeyImageSyncStepAck = 533,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroKeyImageSyncFinalRequest")]
        MessageTypeMoneroKeyImageSyncFinalRequest = 534,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroKeyImageSyncFinalAck")]
        MessageTypeMoneroKeyImageSyncFinalAck = 535,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroGetAddress")]
        MessageTypeMoneroGetAddress = 540,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroAddress")]
        MessageTypeMoneroAddress = 541,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroGetWatchKey")]
        MessageTypeMoneroGetWatchKey = 542,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroWatchKey")]
        MessageTypeMoneroWatchKey = 543,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugMoneroDiagRequest")]
        MessageTypeDebugMoneroDiagRequest = 546,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_DebugMoneroDiagAck")]
        MessageTypeDebugMoneroDiagAck = 547,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroGetTxKeyRequest")]
        MessageTypeMoneroGetTxKeyRequest = 550,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroGetTxKeyAck")]
        MessageTypeMoneroGetTxKeyAck = 551,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroLiveRefreshStartRequest")]
        MessageTypeMoneroLiveRefreshStartRequest = 552,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroLiveRefreshStartAck")]
        MessageTypeMoneroLiveRefreshStartAck = 553,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroLiveRefreshStepRequest")]
        MessageTypeMoneroLiveRefreshStepRequest = 554,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroLiveRefreshStepAck")]
        MessageTypeMoneroLiveRefreshStepAck = 555,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroLiveRefreshFinalRequest")]
        MessageTypeMoneroLiveRefreshFinalRequest = 556,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_MoneroLiveRefreshFinalAck")]
        MessageTypeMoneroLiveRefreshFinalAck = 557,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EosGetPublicKey")]
        MessageTypeEosGetPublicKey = 600,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EosPublicKey")]
        MessageTypeEosPublicKey = 601,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EosSignTx")]
        MessageTypeEosSignTx = 602,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EosTxActionRequest")]
        MessageTypeEosTxActionRequest = 603,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EosTxActionAck")]
        MessageTypeEosTxActionAck = 604,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_EosSignedTx")]
        MessageTypeEosSignedTx = 605,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceGetAddress")]
        MessageTypeBinanceGetAddress = 700,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceAddress")]
        MessageTypeBinanceAddress = 701,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceGetPublicKey")]
        MessageTypeBinanceGetPublicKey = 702,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinancePublicKey")]
        MessageTypeBinancePublicKey = 703,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceSignTx")]
        MessageTypeBinanceSignTx = 704,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceTxRequest")]
        MessageTypeBinanceTxRequest = 705,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceTransferMsg")]
        MessageTypeBinanceTransferMsg = 706,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceOrderMsg")]
        MessageTypeBinanceOrderMsg = 707,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceCancelMsg")]
        MessageTypeBinanceCancelMsg = 708,
        [global::ProtoBuf.ProtoEnum(Name = @"MessageType_BinanceSignedTx")]
        MessageTypeBinanceSignedTx = 709,
    }

    public static class Extensions
    {
        public static bool GetWireIn(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50002);

        public static void SetWireIn(this global::Google.Protobuf.Reflection.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50002, value);

        public static bool GetWireOut(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50003);

        public static void SetWireOut(this global::Google.Protobuf.Reflection.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50003, value);

        public static bool GetWireDebugIn(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50004);

        public static void SetWireDebugIn(this global::Google.Protobuf.Reflection.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50004, value);

        public static bool GetWireDebugOut(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50005);

        public static void SetWireDebugOut(this global::Google.Protobuf.Reflection.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50005, value);

        public static bool GetWireTiny(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50006);

        public static void SetWireTiny(this global::Google.Protobuf.Reflection.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50006, value);

        public static bool GetWireBootloader(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50007);

        public static void SetWireBootloader(this global::Google.Protobuf.Reflection.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50007, value);

        public static bool GetWireNoFsm(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50008);

        public static void SetWireNoFsm(this global::Google.Protobuf.Reflection.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50008, value);

    }
}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
