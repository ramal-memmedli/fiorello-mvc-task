using Data.DAL;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontToBack.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ISettingService _settingService;

        public HeaderViewComponent(ISettingService setting)
        {
            _settingService = setting;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Dictionary<string, string> data = await _settingService.GetSettings();

            return View(data);
        }
    }
}
