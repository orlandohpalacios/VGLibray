namespace HelloMVC.Models
{
    public class RegisterViewModel
    {
        public string username { get; set; }
        public string password{ get; set; }
        public string email { get; set; }
        public string ErrorMSg { get; set; }
        public RegisterViewModel() 
        {
            this.ErrorMSg = "";
        }
    }
}
