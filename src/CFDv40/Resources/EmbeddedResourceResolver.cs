// 
// EmbeddedResourceResolver.cs
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
using System.Reflection;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace Mictlanix.CFDv40.Resources {
	internal class EmbeddedResourceResolver : XmlUrlResolver {
		public override object GetEntity (Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			
				Type type = typeof (EmbeddedResourceResolver);

				return type.Assembly.GetManifestResourceStream (type, Path.GetFileName (absoluteUri.AbsolutePath));
			
			
		}

		public Stream GetResource (string name)
		{
			Type type = typeof (EmbeddedResourceResolver);

			return type.Assembly.GetManifestResourceStream (type, name);			
		}
	}
}