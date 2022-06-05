using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontToBack.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly ISettingService _settingService;

        public FooterViewComponent(ISettingService setting)
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
