﻿using System.ComponentModel.DataAnnotations;

namespace ETCTask.ViewModel
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
    }
}