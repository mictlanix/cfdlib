// 
// Comprobante.Custom.cs
// 
// Author:
//   Eddy Zavaleta <eddy@mictlanix.com>
// 
// Copyright (C) 2017 Mictlanix SAS de CV and contributors.
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
//
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Mictlanix.CFDv33.Resources;

namespace Mictlanix.CFDv33 {
	public partial class Comprobante {
		string schema_location;
		List<XmlQualifiedName> xmlns;

		[XmlAttributeAttribute ("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation {
			get {
				if (schema_location == null) {
					schema_location = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd";
				}

				if (Complemento != null) {
					foreach (var item in Complemento) {
						if (item is TimbreFiscalDigital tfd) {
							if (tfd.SchemaLocation != null && !schema_location.Contains (tfd.SchemaLocation)) {
								schema_location += " " + tfd.SchemaLocation;
							}
						} else if (item is Nomina nomina) {
							if (nomina.SchemaLocation != null && !schema_location.Contains (nomina.SchemaLocation)) {
								schema_location += " " + nomina.SchemaLocation;
							}
						} else if (item is Pagos pagos) {
							if (pagos.SchemaLocation != null && !schema_location.Contains (pagos.SchemaLocation)) {
								schema_location += " " + pagos.SchemaLocation;
							}
						} else if (item is ImpuestosLocales implocal) {
							if (implocal.SchemaLocation != null && !schema_location.Contains (implocal.SchemaLocation)) {
								schema_location += " " + implocal.SchemaLocation;
							}
						}
					}
				}

				return schema_location;
			}
			set { schema_location = value; }
		}

		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Xmlns {
			get {
				if (xmlns == null) {
					xmlns = new List<XmlQualifiedName> {
						new XmlQualifiedName ("cfdi", "http://www.sat.gob.mx/cfd/3"),
						new XmlQualifiedName ("xsi", "http://www.w3.org/2001/XMLSchema-instance")
					};
				}

				if (Complemento != null) {
					foreach (var item in Complemento) {
						if (item is TimbreFiscalDigital && !xmlns.Exists (x => x.Name == "tfd")) {
							xmlns.Add (new XmlQualifiedName ("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital"));
						} else if (item is Nomina && !xmlns.Exists (x => x.Name == "nomina12")) {
							xmlns.Add (new XmlQualifiedName ("nomina12", "http://www.sat.gob.mx/nomina12"));
						} else if (item is Pagos && !xmlns.Exists (x => x.Name == "pago10")) {
							xmlns.Add (new XmlQualifiedName ("pago10", "http://www.sat.gob.mx/nomina12"));
						} else if (item is ImpuestosLocales && !xmlns.Exists (x => x.Name == "implocal")) {
							xmlns.Add (new XmlQualifiedName ("implocal", "http://www.sat.gob.mx/implocal"));
						}
					}
				}

				return new XmlSerializerNamespaces (xmlns.ToArray ());
			}
			set {
				if (value == null) {
					xmlns = null;
					return;
				}

				xmlns = new List<XmlQualifiedName> (value.ToArray ());
			}
		}

		public override string ToString ()
		{
			var resolver = new EmbeddedResourceResolver ();

			using (var xml = ToXmlStream ()) {
				using (var output = new StringWriter ()) {
					using (var xsl_stream = resolver.GetResource ("cadenaoriginal_3_3.xslt")) {
						XslCompiledTransform xslt = new XslCompiledTransform ();
						xslt.Load (XmlReader.Create (xsl_stream), XsltSettings.TrustedXslt, resolver);
						xslt.Transform (XmlReader.Create (xml), null, output);
						return output.ToString ();
					}
				}
			}
		}

		public MemoryStream ToXmlStream ()
		{
			return CFDLib.Utils.SerializeToXmlStream (this, Xmlns);
		}

		public byte[] ToXmlBytes ()
		{
			using (var ms = ToXmlStream ()) {
				return ms.ToArray ();
			}
		}

		public string ToXmlString ()
		{
			using (var ms = ToXmlStream ()) {
				return Encoding.UTF8.GetString (ms.ToArray ());
			}
		}

		public void Sign (byte[] privateKey, byte[] password)
		{
			Sello = CFDLib.Utils.SHA256WithRSA (ToString (), privateKey, password);
		}

		public static Comprobante FromXml (string xml)
		{
			using (var ms = new MemoryStream (Encoding.UTF8.GetBytes (xml))) {
				return FromXml (ms);
			}
		}

		public static Comprobante FromXml (Stream xml)
		{
			var xs = new XmlSerializer (typeof (Comprobante));
			object obj = xs.Deserialize (xml);
			return obj as Comprobante;
		}
	}
}
