using System.ComponentModel.DataAnnotations;

namespace ModelDataUsingViewData.Models
{
    public class CheckModel
    {
        public List<SingleCheckBoxModel> CheckBoxes { get; set; } // ye list of Check box hai 
                                                                  // isme hum multiple check box define karsakte hai
        public List<string> sports { get; set; } // submit ke baad selected checkboxes ko receive karne ke liye
                                                    // ye property banayi gayi hai
    }
    //public class CheckModel
    //{
    //    public bool AcceptTerms { get; set; } // "bool" => for Ture or False.
    //    [Required]
    //    public string Text { get; set; }
    //    public string UserName { get; set; }
    //    [Required]
    //    public int Age { get; set; }
    //    [Required]
    //    public long Cont_number { get; set; }
    //}
}
