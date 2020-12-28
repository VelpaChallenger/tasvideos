﻿using Microsoft.AspNetCore.Mvc;
using TASVideos.Data.Entity;

namespace TASVideos.ViewComponents
{
	public class CurrentEditLink : ViewComponent
	{
		public IViewComponentResult Invoke(WikiPage pageData)
		{
			return View(pageData);
		}
	}
}
