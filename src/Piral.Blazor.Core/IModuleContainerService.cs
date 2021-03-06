﻿using System;

namespace Piral.Blazor.Core
{
    public interface IModuleContainerService
    {
        /// <summary>
        /// Configures the component for rendering.
        /// </summary>
        /// <param name="type">The type to configure.</param>
        /// <param name="provider">The associated provider.</param>
        void ConfigureComponent(Type type, IServiceProvider provider);

        /// <summary>
        /// Removes the component from the render initializer.
        /// </summary>
        /// <param name="type">The type to forget.</param>
        void ForgetComponent(Type type);
    }
}
