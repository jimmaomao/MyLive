﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLive.Models
{

    /// <summary>
    /// 用户配置
    /// </summary>
    public class T_UserConfig
    {
        [Key]
        public int ConfigID { get; set; }

        /// <summary>
        /// 启用注册
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "启用注册")]
        public bool Enabled { get; set; }

        /// <summary>
        /// 禁止使用的用户名
        /// 用户名之间用“|”隔开
        /// </summary>
        [Display(Name = "禁止使用的用户名")]
        public string ProhitbitUserName { get; set; }

        /// <summary>
        /// 启用管理员验证
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "启用管理员验证")]
        public bool EnabledAdminVerify { get; set; }

        /// <summary>
        /// 启用邮件验证
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "启用邮件验证")]
        public bool EnabledEmailVerify { get; set; }

        /// <summary>
        /// 默认用户组ID
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "默认用户组ID")]
        public int DefaultGroupID { get; set; }
    }
}
