﻿// --------------------------------------------------------------------------------------------------------------------
// Outcold Solutions (http://outcoldman.com)
// --------------------------------------------------------------------------------------------------------------------
namespace OutcoldSolutions
{
    using OutcoldSolutions.Views;

    /// <summary>
    /// The ViewRegionProvider interface.
    /// </summary>
    public interface IViewRegionProvider
    {
        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="view">
        /// The view.
        /// </param>
        void Show(IView view);
    }
}