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
using Microsoft.Azure.Management.DataFactories.Core.Models;

namespace Microsoft.Azure.Management.DataFactories.Core.Models
{
    /// <summary>
    /// Parameters specifying the dataset to be created or updated.
    /// </summary>
    public partial class DatasetCreateOrUpdateParameters
    {
        private Dataset _dataset;
        
        /// <summary>
        /// Optional. The definition of the dataset to be created or updated.
        /// </summary>
        public Dataset Dataset
        {
            get { return this._dataset; }
            set { this._dataset = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatasetCreateOrUpdateParameters
        /// class.
        /// </summary>
        public DatasetCreateOrUpdateParameters()
        {
        }
    }
}
