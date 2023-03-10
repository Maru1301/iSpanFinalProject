using iSMusic.Models.DTOs;
using iSMusic.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace iSMusic.Models.ViewModels
{
    public class ProductVM
    {
        public int id { get; set; }

        [Display(Name = "演出者")]

        public string productName { get; set; }

        [Display(Name = "分類名稱")]
        public string categoryName { get; set; }

        [Display(Name = "售價")]
        public decimal productPrice { get; set; }

        [Display(Name = "庫存量")]
        public decimal stock { get; set; }

        [Display(Name = "status")]
        public bool status { get; set; }

        [Display(Name = "專輯")]
        public string album { get; set; }
    }


    public static partial class PorductDtoExts
    {

        public static ProductVM ToVM(this Product source)
        {
            return new ProductVM
            {
                id = source.id,
                productName = source.productName,
                categoryName = source.ProductCategory.categoryName,
                productPrice = source.productPrice,
                stock = source.stock,
                status = source.status,
                album = source.Album.albumName,

            };
        }
    }
}