﻿using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using TASVideos.Data.Entity;
using TASVideos.Data.SampleData;
using TASVideos.Tasks;

namespace TASVideos.ViewComponents
{
	// TODO: a better name for this is FrontPageMovie or something like that
	public class DisplayMiniMovie : ViewComponent
	{
		private readonly PublicationTasks _publicationTasks;

		public DisplayMiniMovie(PublicationTasks publicationTasks)
		{
			_publicationTasks = publicationTasks;
		}

		public async Task<IViewComponentResult> InvokeAsync(WikiPage pageData, string pp)
		{
			var candidateIds = await _publicationTasks.FrontPageMovieCandidates();
			var id = candidateIds.ToList().AtRandom();
			var movie = await _publicationTasks.GetPublicationMiniMovie(id);
			return View(movie);
		}
	}
}
