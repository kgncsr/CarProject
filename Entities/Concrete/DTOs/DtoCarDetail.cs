using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CDto
{
    public class DtoCarDetail : IDto
    {
        public int Id { get; set; }
        public string Descriptions { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
