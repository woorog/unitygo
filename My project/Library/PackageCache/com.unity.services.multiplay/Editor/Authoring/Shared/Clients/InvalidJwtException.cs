// WARNING: Auto generated code. Modifications will be lost!
using System;

namespace Unity.Services.Multiplay.Authoring.Editor.Shared.Clients
{
    class InvalidJwtException : Exception
    {
        public string Token { get; }

        public InvalidJwtException(string message, string token) : base(message)
        {
            Token = token;
        }
    }
}
