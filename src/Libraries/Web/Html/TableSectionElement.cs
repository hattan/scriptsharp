// TableSectionElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public sealed class TableSectionElement : Element {

        private TableSectionElement() {
        }

        [IntrinsicProperty]
        public ElementCollection Rows {
            get {
                return null;
            }
        }
    }
}
