using System;
using JetBrains.Annotations;

namespace FemidaLocker
{
    /// <summary>
    ///     Specifies a FemidaLocker module responsible for a certain component of functionality.
    /// </summary>
    [UsedImplicitly]
    public abstract class FemidaLockerModule : IDisposable
    {
        protected FemidaLockerModule([NotNull] NoCheatPlugin plugin)
        {
            Plugin = plugin ?? throw new ArgumentNullException(nameof(plugin));
        }

        /// <summary>
        ///     Gets the FemidaLocker plugin.
        /// </summary>
        [NotNull]
        protected FemidaLocker Plugin { get; }

        public abstract void Dispose();
        public abstract void Initialize();
    }
}
