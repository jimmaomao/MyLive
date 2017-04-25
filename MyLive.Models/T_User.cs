using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyLive.Models
{
    /// <summary>
    /// 用户模型
    /// </summary>
    public class T_User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        public int UserID { get; set; }

        /// <summary>
        ///用户名
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{1}到{0}个字符")]
        [DisplayName("用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 显示名
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "显示名")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{1}到{0}个字符")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{1}到{0}个字符")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "邮箱")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// 用户状态
        /// 0正常，1 锁定，2未通过邮件验证，3未通过管理员
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegistrationTime { get; set; }

        /// <summary>
        /// 上次登录时间  
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// 上次登陆ip
        /// </summary>
        public string LoginIp { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "用户组ID")]
        public int GroupID { get; set; }

        public virtual T_UserGroup Group { get; set; }
    }
}
