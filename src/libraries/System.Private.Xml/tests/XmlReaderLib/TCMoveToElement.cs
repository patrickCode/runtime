// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using OLEDB.Test.ModuleCore;

namespace System.Xml.Tests
{
    public partial class TCMoveToElement : TCXMLReaderBaseGeneral
    {
        // Type is System.Xml.Tests.TCMoveToElement
        // Test Case
        public override void AddChildren()
        {
            // for function v1
            {
                this.AddChild(new CVariation(v1) { Attribute = new Variation("Attribute node") });
            }


            // for function v2
            {
                this.AddChild(new CVariation(v2) { Attribute = new Variation("Element node") });
            }


            // for function v3
            {
                this.AddChild(new CVariation(v3) { Attribute = new Variation("XmlDeclaration node") });
            }


            // for function v5
            {
                this.AddChild(new CVariation(v5) { Attribute = new Variation("Comment node") });
            }
        }
    }
}
