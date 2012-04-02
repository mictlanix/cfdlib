using System;
using System.Reflection;
using System.IO;
using System.Xml;

namespace Mictlanix.CFDv2.Resources
{
    internal class EmbeddedResourceResolver : XmlUrlResolver
    {
        public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
        {
            return typeof(EmbeddedResourceResolver).Assembly.GetManifestResourceStream(GetType(), Path.GetFileName(absoluteUri.AbsolutePath));
        }

        public Stream GetResource (string name)
		{
			Type type = typeof(EmbeddedResourceResolver);
			
			return type.Assembly.GetManifestResourceStream (type, name);
		}
    }
}