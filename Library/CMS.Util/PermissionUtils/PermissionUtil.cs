using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Permissions;
using Domain.Roles;
using PracticeIdentity.Permissions;

namespace CMS.Util.PermissionUtils
{
    public static class PermissionUtil
    {
        public static void DisplayPermission(List<PermissionModel> permissionModels)
        {
            foreach (var permission in permissionModels)
            {
                Console.WriteLine($"Name: {permission.GroupPermission}");
                Console.WriteLine($"View: {permission.View}");
                Console.WriteLine($"Create: {permission.Create}");
                Console.WriteLine($"Edit: {permission.Edit}");
                Console.WriteLine($"Delete: {permission.Delete}");
            }
        }

        public static List<string> GeneratePermissionsAsString()
        {
            List<string> permissions = new List<string>();
            var parentType = typeof(PermissionsAuthorize);

            // Get all nested types (classes)
            foreach (var type in parentType.GetNestedTypes(BindingFlags.Public | BindingFlags.Static))
            {
                // Get all public constant fields in the nested class
                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy))
                {
                    if (field.IsLiteral && !field.IsInitOnly)
                    {

                        if (field.Name != "GroupPermission")
                        {
                            permissions.Add(field.GetValue(null).ToString());
                        }
                    }
                }
            }
            return permissions;
        }

        public static List<PermissionViewModel> GeneratePermissionViewModel()
        {
            List<PermissionViewModel> lstPermissionViewModel = new List<PermissionViewModel>();
            var parentType = typeof(PermissionsAuthorize);

            // Get all nested types (classes)
            foreach (var type in parentType.GetNestedTypes(BindingFlags.Public | BindingFlags.Static))
            {
                PermissionViewModel permissionViewModel = new PermissionViewModel();
                List<RoleClaimsViewModel> listRoleClaimViewModel = new List<RoleClaimsViewModel>();
                // Get all public constant fields in the nested class
                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy))
                {
                    if (field.Name == "GroupPermission")
                    {
                        permissionViewModel.GroupPermission = field.GetValue(null).ToString();
                        continue;
                    }
                    RoleClaimsViewModel roleClaimsViewModel = new RoleClaimsViewModel();
                    if (field.IsLiteral && !field.IsInitOnly)
                    {
                        roleClaimsViewModel.Name = field.Name;
                        roleClaimsViewModel.Value = field.GetValue(null).ToString();
                    }
                    listRoleClaimViewModel.Add(roleClaimsViewModel);
                }
                permissionViewModel.RoleClaims = listRoleClaimViewModel;
                lstPermissionViewModel.Add(permissionViewModel);
            }
            return lstPermissionViewModel;
        }
    }

    // public static List<PermissionModel> GeneratePermissions()
    // {
    //     List<PermissionModel> permissions = new List<PermissionModel>();
    //     var parentType = typeof(PermissionsAuthorize);

    //     // Get all nested types (classes)
    //     foreach (var type in parentType.GetNestedTypes(BindingFlags.Public | BindingFlags.Static))
    //     {
    //         PermissionModel permissionModel = new PermissionModel();
    //         // Get all public constant fields in the nested class
    //         foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy))
    //         {
    //             if (field.IsLiteral && !field.IsInitOnly)
    //             {

    //                 if (field.Name == "GroupPermission")
    //                 {
    //                     permissionModel.GroupPermission = field.GetValue(null).ToString();
    //                 }
    //                 else if (field.Name == "View")
    //                 {
    //                     permissionModel.View = field.GetValue(null).ToString();
    //                 }
    //                 else if (field.Name == "Create")
    //                 {
    //                     permissionModel.Create = field.GetValue(null).ToString();
    //                 }
    //                 else if (field.Name == "Edit")
    //                 {
    //                     permissionModel.Edit = field.GetValue(null).ToString();
    //                 }
    //                 else if (field.Name == "Delete")
    //                 {
    //                     permissionModel.Delete = field.GetValue(null).ToString();
    //                 }

    //             }
    //         }
    //         permissions.Add(permissionModel);
    //     }
    //     return permissions;
    // }
}