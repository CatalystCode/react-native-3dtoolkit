using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace 3dtoolkit.RN3dtoolkit
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RN3dtoolkitModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RN3dtoolkitModule"/>.
        /// </summary>
        internal RN3dtoolkitModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RN3dtoolkit";
            }
        }
    }
}
