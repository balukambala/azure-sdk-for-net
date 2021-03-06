// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// PublicIPAddress resource
    /// </summary>
    public partial class PublicIpAddress : TopLevelResource
    {
        private PublicIpAddressDnsSettings _dnsSettings;
        
        /// <summary>
        /// Optional. Gets or sets FQDN of the DNS record associated with the
        /// public IP address
        /// </summary>
        public PublicIpAddressDnsSettings DnsSettings
        {
            get { return this._dnsSettings; }
            set { this._dnsSettings = value; }
        }
        
        private int? _idleTimeoutInMinutes;
        
        /// <summary>
        /// Optional. Gets or sets the Idletimeout of the public IP address
        /// </summary>
        public int? IdleTimeoutInMinutes
        {
            get { return this._idleTimeoutInMinutes; }
            set { this._idleTimeoutInMinutes = value; }
        }
        
        private string _ipAddress;
        
        /// <summary>
        /// Optional. Gets the assigned public IP address
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private ResourceId _ipConfiguration;
        
        /// <summary>
        /// Optional. Gets a reference to the network interface IP
        /// configurations using this public IP address
        /// </summary>
        public ResourceId IpConfiguration
        {
            get { return this._ipConfiguration; }
            set { this._ipConfiguration = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _publicIpAllocationMethod;
        
        /// <summary>
        /// Required. Gets or sets PublicIP allocation method (Static/Dynamic)
        /// </summary>
        public string PublicIpAllocationMethod
        {
            get { return this._publicIpAllocationMethod; }
            set { this._publicIpAllocationMethod = value; }
        }
        
        private string _resourceGuid;
        
        /// <summary>
        /// Optional. Gets or sets resource guid property of the PublicIP
        /// resource
        /// </summary>
        public string ResourceGuid
        {
            get { return this._resourceGuid; }
            set { this._resourceGuid = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PublicIpAddress class.
        /// </summary>
        public PublicIpAddress()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the PublicIpAddress class with
        /// required arguments.
        /// </summary>
        public PublicIpAddress(string publicIpAllocationMethod, string location)
            : this()
        {
            if (publicIpAllocationMethod == null)
            {
                throw new ArgumentNullException("publicIpAllocationMethod");
            }
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.PublicIpAllocationMethod = publicIpAllocationMethod;
            this.Location = location;
        }
    }
}
