namespace HumanResourcesApp.ViewModels
{
    public class RoleViewModel
    {
        #region Properties
        //[Required]
        //[Display(Name = "Id")]
        //[Column(TypeName = "INT")]
        public string? RoleId { get; set; }

        //[Required]
        //[Display(Name = "Role Name")]
        //[Column(TypeName = "VARCHAR(50)")]
        public string RoleName { get; set; }
        #endregion
    }
}
