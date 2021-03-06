// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Common.Properties;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Represents the configuration settings that describe an <see cref="SystemConfigurationSource"/>.
    /// </summary>
    [ResourceDescription(typeof(DesignResources), "SystemConfigurationSourceElementDescription")]
    [ResourceDisplayName(typeof(DesignResources), "SystemConfigurationSourceElementDisplayName")]
    [Browsable(true)]
    public class SystemConfigurationSourceElement : ConfigurationSourceElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigurationSourceElement"/> class with default values.
        /// </summary>
        public SystemConfigurationSourceElement()
            : this(Resources.SystemConfigurationSourceName)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigurationSourceElement"/> class with a name and an type.
        /// </summary>
        /// <param name="name">The instance name.</param>
        public SystemConfigurationSourceElement(string name)
            : base(name, typeof(SystemConfigurationSource))
        { }

        /// <summary>
        /// Returns a new <see cref="SystemConfigurationSource"/>.
        /// </summary>
        /// <returns>A new configuration source.</returns>
        public override IConfigurationSource CreateSource()
        {
            IConfigurationSource createdObject = new SystemConfigurationSource();

            return createdObject;
        }
    }
}

