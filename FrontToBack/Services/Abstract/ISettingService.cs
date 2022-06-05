using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ISettingService
    {
        Task<Dictionary<string, string>> GetSettings();
    }
}
