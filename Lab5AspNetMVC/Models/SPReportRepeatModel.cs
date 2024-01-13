using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab5AspNetMVC.Models
{
    public class SPReportRepeatModel
    {
        public List<Business_Logic_Layer.DTO.ReportDTOs.SelectionByRepeatabilityDTO> SelectionByRepeatabilityData { get; set; }
        public bool SelectedValueIsRepeat { get; set; }
    }
}