﻿namespace Caliburn.Micro {
#if WinUI3
    using Microsoft.UI.Xaml;
#else
    using Windows.UI.Xaml;
#endif

    /// <summary>
    /// Interaface usually from the Interactivity SDK's included here for completeness.
    /// </summary>
    public interface IAttachedObject {
        /// <summary>
        /// Attached the specified dependency object
        /// </summary>
        /// <param name="dependencyObject"></param>
        void Attach(DependencyObject dependencyObject);

        /// <summary>
        /// Detach from the previously attached object.
        /// </summary>
        void Detach();

        /// <summary>
        /// The currently attached object.
        /// </summary>
        DependencyObject AssociatedObject
        {
            get;
        }
    }
}
