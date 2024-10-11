using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					Username= "Test"
				},
				new UserComment
				{
					ID= 2,
					Username = "Test2"
				}
			};
			return View(commentvalues);
		}
	}
}
