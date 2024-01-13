using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab5AspNetMVC.Models
{
    public class LinkReportKindModel
    {
        public List<Business_Logic_Layer.DTO.ReportDTOs.SelectionByKindDTO> SelectionByKindData { get; set; }
        public List<Business_Logic_Layer.DTO.TaskKindDTO> taskKindsList { get; set; }
        public int SelectedKindId { get; set; }
    }
}