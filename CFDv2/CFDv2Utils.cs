using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.OpenSsl;
using Mictlanix.CFDv2.Resources;

namespace Mictlanix.CFDv2
{
	public static class CFDv2Utils
	{
		public static string DigitalSignature (Comprobante cfd, byte[] privateKey, byte[] password)
		{
			return SHA1WithRSA (privateKey, password, OriginalString (cfd));
		}

		public static string OriginalString (Comprobante cfd)
		{
			var resolver = new EmbeddedResourceResolver ();
			
			using (var xml = SerializeToXmlStream (cfd)) {
				using (var output = new StringWriter()) {
					using (var xsl_stream = resolver.GetResource ("cadenaoriginal_2_0.xslt")) {
						XslCompiledTransform xslt = new XslCompiledTransform ();
						xslt.Load (XmlReader.Create (xsl_stream), XsltSettings.TrustedXslt, resolver);
						xslt.Transform (XmlReader.Create (xml), null, output);
						return output.ToString ();
					}
				}
			}
		}
		
		public static MemoryStream SerializeToXmlStream (Comprobante obj)
		{
			var ms = new MemoryStream (4 * 1024);
			var xs = new XmlSerializer (typeof(Comprobante));
			var xml = new XmlTextWriter (ms, Encoding.UTF8);
			var xmlns = new XmlSerializerNamespaces (new XmlQualifiedName[] {
                new XmlQualifiedName ("", "http://www.sat.gob.mx/cfd/2"),
                new XmlQualifiedName ("xsi", "http://www.w3.org/2001/XMLSchema-instance")
            });

			xs.Serialize (xml, obj, xmlns);
			ms.Seek (0, SeekOrigin.Begin);
			
			return ms;
		}
		
		internal static string SHA1WithRSA (byte[] data, byte[] password, string message)
		{
			ISigner signer;
			byte[] signature;
			AsymmetricKeyParameter key;
            
			key = PrivateKeyFactory.DecryptKey (UTF8Encoding.UTF8.GetString (password).ToCharArray (), data);
			signer = SignerUtilities.GetSigner ("SHA1WithRSA");
			signer.Init (true, key);

			data = Encoding.UTF8.GetBytes (message);
			signer.BlockUpdate (data, 0, data.Length);
			signature = signer.GenerateSignature ();

			return Convert.ToBase64String (signature);
		}
	}
}
