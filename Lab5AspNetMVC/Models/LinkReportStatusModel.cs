using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab5AspNetMVC.Models
{
    public class LinkReportStatusModel
    {
        public List<Business_Logic_Layer.DTO.ReportDTOs.SelectionByStatusDTO> SelectionByStatusData { get; set; }
        public List<Business_Logic_Layer.DTO.TaskStatusDTO> taskStatusesList { get; set; }
        public int SelectedStatusId { get; set; }
    }
}