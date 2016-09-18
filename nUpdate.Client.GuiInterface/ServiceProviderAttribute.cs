﻿// Author: Dominic Beger (Trade/ProgTrade) 2016

using System;

namespace nUpdate.UpdateInstaller.Client.GuiInterface
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class ServiceProviderAttribute : Attribute
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ServiceProviderAttribute" /> class.
        /// </summary>
        /// <param name="serviceType">The type of the progress service provider.</param>
        /// <exception cref="System.ArgumentNullException">servicesType is null.</exception>
        /// <exception cref="System.ArgumentException">Implementation of IServiceProvider is missing.;servicesType</exception>
        public ServiceProviderAttribute(Type serviceType)
        {
            if (serviceType == null)
                throw new ArgumentNullException(nameof(serviceType));
            if (!typeof (IServiceProvider).IsAssignableFrom(serviceType))
                throw new ArgumentException("Implementation of IServiceProvider is missing.", nameof(serviceType));
            ServiceType = serviceType;
        }

        /// <summary>
        ///     Gets the type of the progress services provider.
        /// </summary>
        public Type ServiceType { get; private set; }
    }
}