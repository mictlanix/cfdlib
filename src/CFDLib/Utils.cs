// 
// CFDv2Utils.cs
// 
// Author:
//   Eddy Zavaleta <eddy@mictlanix.com>
// 
// Copyright (C) 2012-2016 Eddy Zavaleta, Mictlanix, and contributors.
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
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.OpenSsl;
using Mictlanix.CFDv22.Resources;

namespace Mictlanix.CFDLib
{
	public static class Utils
	{
        public static MemoryStream SerializeToXmlStream<T>(T obj, XmlSerializerNamespaces xmlns)
		{
			var ms = new MemoryStream (4 * 1024);
			var xs = new XmlSerializer (typeof(T));
			var xml = new XmlTextWriter (ms, new UTF8Encoding (false));

			xs.Serialize (xml, obj, xmlns);
			ms.Seek (0, SeekOrigin.Begin);
			
			return ms;
		}
		
		public static string SHA1WithRSA (string message, byte[] data, byte[] password)
		{
			ISigner signer;
			byte[] signature;
			AsymmetricKeyParameter key;

			key = PrivateKeyFactory.DecryptKey (Encoding.UTF8.GetString (password).ToCharArray (), data);
			signer = SignerUtilities.GetSigner ("SHA1WithRSA");
			signer.Init (true, key);

			data = Encoding.UTF8.GetBytes (message);
			signer.BlockUpdate (data, 0, data.Length);
			signature = signer.GenerateSignature ();

			return Convert.ToBase64String (signature);
		}

		public static bool PrivateKeyTest (byte[] data, byte[] password)
		{
			try {
				var key = PrivateKeyFactory.DecryptKey (UTF8Encoding.UTF8.GetString (password).ToCharArray (), data);
				return key.IsPrivate;
			} catch {
			}

			return false;
		}
	}
}
