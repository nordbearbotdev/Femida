using System;
using System.Diagnostics;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FemidaLocker
{
    
    [JsonObject(MemberSerialization.OptIn)]
    public class Infraction
    {
        
        public Infraction(int points, DateTime expiration, [NotNull] string reason)
        {
            Debug.Assert(points >= 0, "Number of points must be positive.");
            Debug.Assert(reason != null, "Reason must not be null.");

            Points = points;
            Expiration = expiration;
            Reason = reason;
        }

        [JsonProperty]
        public DateTime Expiration { get; }

        [JsonProperty]
        public int Points { get; }

        [JsonProperty]
        [NotNull]
        public string Reason { get; }
    }
}
