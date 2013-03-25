﻿// --------------------------------------------------------------------------------------------------------------------
// OutcoldSolutions (http://outcoldsolutions.com)
// --------------------------------------------------------------------------------------------------------------------
namespace OutcoldSolutions.Views
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The disposable page view base.
    /// </summary>
    public class DisposablePageViewBase : PageViewBase
    {
        private readonly List<IDisposable> disposables = new List<IDisposable>();

        ~DisposablePageViewBase()
        {
            this.Dispose(disposing: false);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Register object for dispose. It will be disposed when <see cref="Dispose"/> will be called.
        /// </summary>
        /// <param name="disposable">
        /// The disposable object.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="disposable"/> is null.
        /// </exception>
        protected void RegisterForDispose(IDisposable disposable)
        {
            if (disposable == null)
            {
                throw new ArgumentNullException("disposable");
            }

            this.disposables.Add(disposable);
        }

        /// <summary>
        /// Method will be called when <see cref="Dispose"/> will be invoked.
        /// </summary>
        protected virtual void OnDisposing()
        {
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.OnDisposing();
                
                foreach (var disposable in this.disposables)
                {
                    disposable.Dispose();
                }

                this.disposables.Clear();
            }
        } 
    }
}