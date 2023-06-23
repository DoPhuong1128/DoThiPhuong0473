using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoThiPhuong0473.Models
{
    public class DTPStudent;
    

        [Key]
        public string StudentID {get; set;}
        public string StudentName {get; set;}
        public string Address {get; set;}
    
}
    

    //dotnet-aspnet-codegenerator controller -name DTPStudentController -m DTPStudent -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite


