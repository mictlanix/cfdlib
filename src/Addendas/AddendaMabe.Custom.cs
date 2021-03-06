﻿// 
// AddendaMabe.Custom.cs
// 
// Author:
//   Eddy Zavaleta <eddy@mictlanix.com>
// 
// Copyright (C) 2015-2016 Eddy Zavaleta, Mictlanix, and contributors.
// 
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Mictlanix.CFDv32.Resources;

namespace Mictlanix.CFDLib.Addendas.Mabe {
	public partial class Factura {
		string schema_location = string.Empty;
        XmlSerializerNamespaces xmlns;
		
		[XmlAttributeAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation {
			get {
				if (string.IsNullOrWhiteSpace (schema_location)) {
					schema_location = "http://recepcionfe.mabempresa.com/cfd/addenda/v1 http://recepcionfe.mabempresa.com/cfd/addenda/v1/mabev1.xsd";
				}
				
				return schema_location;
			}
			set { schema_location = value; }
		}

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns {
			get {
				if (xmlns == null) {
					xmlns = new XmlSerializerNamespaces (new XmlQualifiedName[] {
						new XmlQualifiedName ("mabe", "http://recepcionfe.mabempresa.com/cfd/addenda/v1"),
						new XmlQualifiedName ("xsi", "http://www.w3.org/2001/XMLSchema-instance")
					});
				}

				return xmlns;
			}
			set { xmlns = value; }
		}

		public override string ToString ()
		{
			return ToXmlString ();
		}

		public string ToXmlString ()
		{
			using (var ms = ToXmlStream ()) {
				return Encoding.UTF8.GetString (ms.ToArray ());
			}
		}

		public MemoryStream ToXmlStream ()
		{
			return CFDLib.Utils.SerializeToXmlStream (this, Xmlns);
		}
    }
}
