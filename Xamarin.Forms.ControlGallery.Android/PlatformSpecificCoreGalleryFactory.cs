﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.ControlGallery.Android;
using Xamarin.Forms.Controls;

[assembly: Dependency(typeof(PlatformSpecificCoreGalleryFactory))]

namespace Xamarin.Forms.ControlGallery.Android
{
	public class PlatformSpecificCoreGalleryFactory : IPlatformSpecificCoreGalleryFactory
	{
		public string Title => "Android Core Gallery";

		public IEnumerable<(Func<Page> Create, string Title)> GetPages()
		{
#if HAVE_OPENTK
			yield return (() => new AdvancedOpenGLGallery(), "Advanced OpenGL Gallery - Legacy");
#else
			return null;
#endif
		}
	}
}
