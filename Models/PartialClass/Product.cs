using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelper_annotationLab.Models.PartialClass
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    public class ProductMetaData
    {
       

        [Required(ErrorMessage = "Product name is required.")]
        [Display(Name = "Product Name")]
		[wordCount(3, ErrorMessage = "Product name should not exceed 3 words")]
        public object ProductName { get; set; }

        [Required(ErrorMessage = "Unit price is required.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        public object UnitPrice { get; set; }

    }
}