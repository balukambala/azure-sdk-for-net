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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Details of the OS Disk.
    /// </summary>
    public partial class OSDiskDetails
    {
        private string _oSType;
        
        /// <summary>
        /// Optional. The type of the OS on the VM.
        /// </summary>
        public string OSType
        {
            get { return this._oSType; }
            set { this._oSType = value; }
        }
        
        private string _oSVhdId;
        
        /// <summary>
        /// Optional. The id of the disk containing the OS.
        /// </summary>
        public string OSVhdId
        {
            get { return this._oSVhdId; }
            set { this._oSVhdId = value; }
        }
        
        private string _vhdName;
        
        /// <summary>
        /// Optional. The OS disk VHD name.
        /// </summary>
        public string VhdName
        {
            get { return this._vhdName; }
            set { this._vhdName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OSDiskDetails class.
        /// </summary>
        public OSDiskDetails()
        {
        }
    }
}
