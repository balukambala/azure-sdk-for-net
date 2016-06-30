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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the create compilation job operation.
    /// </summary>
    public partial class DscCompilationJobCreateProperties
    {
        private DscConfigurationAssociationProperty _configuration;
        
        /// <summary>
        /// Required. Gets or sets the configuration.
        /// </summary>
        public DscConfigurationAssociationProperty Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }
        
        private IDictionary<string, string> _parameters;
        
        /// <summary>
        /// Optional. Gets or sets the parameters of the job.
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }
        
        private string _runOn;
        
        /// <summary>
        /// Optional. Gets or sets the hybrid worker group name for the job.
        /// </summary>
        public string RunOn
        {
            get { return this._runOn; }
            set { this._runOn = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscCompilationJobCreateProperties
        /// class.
        /// </summary>
        public DscCompilationJobCreateProperties()
        {
            this.Parameters = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the DscCompilationJobCreateProperties
        /// class with required arguments.
        /// </summary>
        public DscCompilationJobCreateProperties(DscConfigurationAssociationProperty configuration)
            : this()
        {
            if (configuration == null)
            {
                throw new ArgumentNullException("configuration");
            }
            this.Configuration = configuration;
        }
    }
}
