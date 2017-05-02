using MyLive.Areas.Member.Models;
using MyLive.BLL;
using MyLive.Common;
using MyLive.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLive.Areas.Member.Controllers
{
    public class UserController : Controller
    {
        UserService userService = new UserService();

        // GET: Member/User
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 在控制器中写一个VerificationCode方法。
        /// 过程是：在方法中我们先创建6位验证码字符串->
        /// 使用CreateVerificationImage创建验证码图片->
        /// 把图片写入OutputStream中->
        /// 把验证码字符串写入TempData中
        /// 保存在TempData中和Session中的区别：
        /// TempData只传递一次，也就是传递到下一个action后，
        /// action代码执行完毕就会销毁，
        /// Session会持续保存，
        /// 所以验证码用TempData比较合适。
        /// </summary>
        public ActionResult VerificationCode()
        {
            string verifivationCode = Security.CreateVerificationText(6);
            Bitmap _img = Security.BitmapCreateVerificationImage(verifivationCode, 16, 30);
            _img.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            TempData["VerificationCode"] = verifivationCode.ToUpper();
            return null;
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel register)
        {
            if (TempData["VerificationCode"] == null || TempData["VerificationCode"].ToString() != register.VerificationCode.ToUpper())
            {
                ModelState.AddModelError("VerifivationCode", "验证码不正确");
                return View(register);
            }
            if (ModelState.IsValid)
            {
                if (userService.Exsit(register.UserName))
                {
                    ModelState.AddModelError("UserName", "用户名已存在");
                }
                else
                {
                    T_User _user = new T_User()
                    {
                        UserName = register.UserName,
                        DisplayName = register.DisplayName,
                        Password = Security.Sha256(register.Password),
                        Email = register.Email,
                        Status = 0,
                        RegistrationTime = DateTime.Now
                    };
                    _user = userService.Add(_user);
                    if (_user.UserID > 0)
                    {
                        return Content("注册成功");
                    }
                    else
                    {
                        ModelState.AddModelError("", "注册失败");
                    }
                }
            }
            return View(register);
        }
    }

}
