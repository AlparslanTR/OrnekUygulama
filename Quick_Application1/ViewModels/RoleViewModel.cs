﻿// ---------------------------------------
// Templates: www.ebenmonney.com/templates
// (c) 2023 www.ebenmonney.com/mit-license
// ---------------------------------------

using Quick_Application1.Helpers;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Quick_Application1.ViewModels
{
    public class RoleViewModel : ISanitizeModel
    {
        public virtual void SanitizeModel()
        {
            Id = Id.NullIfWhiteSpace();
            Name = Name.NullIfWhiteSpace();
            Description = Description.NullIfWhiteSpace();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Role name is required"), StringLength(200, MinimumLength = 2, ErrorMessage = "Role name must be between 2 and 200 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        public int UsersCount { get; set; }

        public PermissionViewModel[] Permissions { get; set; }
    }
}
