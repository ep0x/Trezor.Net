﻿using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public enum NEMModificationType
    {
        [ProtoEnum(Name = @"CosignatoryModification_Add")]
        CosignatoryModificationAdd = 1,
        [ProtoEnum(Name = @"CosignatoryModification_Delete")]
        CosignatoryModificationDelete = 2
    }
}