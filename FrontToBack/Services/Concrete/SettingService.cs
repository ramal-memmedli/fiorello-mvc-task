using Data.DAL;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SettingService : ISettingService
    {
        private readonly AppDbContext _context;

        public SettingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, string>> GetSettings()
        {
            Dictionary<string, string> data = await _context.Settings.ToDictionaryAsync(n => n.Key, n => n.Value);

            return data;
        }
    }
}
