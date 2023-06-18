using System;
using System.Security.Claims;
using System.Text.Json;
using Fiorello.Data;
using Fiorello.Models;
using Fiorello.Services.Interfaces;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Fiorello.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _accessor;
        private readonly IBasketService _basketService;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(AppDbContext context,
                             IHttpContextAccessor accessor,
                             IBasketService basketService,
                             UserManager<AppUser> userManager)
        {
            _context = context;
            _accessor = accessor;
            _basketService = basketService;
            _userManager = userManager;
        }

        public async Task<LayoutVM> GetAllDatas()
        {
            var userId = _accessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            int count = _basketService.GetCount();
            var datas = _context.settings.AsEnumerable().ToDictionary(m => m.Key, m => m.Value);

            return new LayoutVM { BasketCount = count, SettingData = datas, UserFullname = user?.FullName };
        }
    }
}

