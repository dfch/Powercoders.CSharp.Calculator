// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PcCalcBigBrain.cs" company="Genossenschaft Migros Aare">
//   M. Styczynski
// </copyright>
// <summary>
//   Main class for Calculator UI
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Powercoders.Calculator.Brain
{
    /// <summary>
    /// BigBrain implemented as an Singleton
    /// </summary>
    public sealed class PcCalcBigBrain
    {
        /// <summary>
        /// The instance var of the class
        /// </summary>
        private static readonly PcCalcBigBrain StaticInstance = new PcCalcBigBrain();

        /// <summary>
        /// Prevents a default instance of the <see cref="PcCalcBigBrain"/> class from being created.
        /// </summary>
        private PcCalcBigBrain()
        {
            // TODO: class initializations has to be here...
        }

        /// <summary>
        /// Returns an instance of the class
        /// </summary>
        public static PcCalcBigBrain Instance => StaticInstance;
    }
}