﻿using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class CosiSignature
    {
        [ProtoMember(1, Name = @"signature")]
        public byte[] Signature { get; set; }

        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;
    }
}