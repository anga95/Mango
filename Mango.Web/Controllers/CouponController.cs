using Mango.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers;

public class CouponController : Controller
{
    private readonly ICouponService _couponService;
    public CouponController(ICouponService couponService)
    {
        _couponService = couponService;
    }
    
    // GET
    public async Task<IActionResult> CouponIndex()
    {
        return View();
    }
}