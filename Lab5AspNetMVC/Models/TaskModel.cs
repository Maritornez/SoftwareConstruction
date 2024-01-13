using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Business_Logic_Layer.DTO;

namespace Lab5AspNetMVC.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        //[Required]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string/*?*/ Description { get; set; }

        public int? KindId { get; set; }

        [DisplayName("Вид")]
        public string/*?*/ KindName { get; set; }

        public int? StatusId { get; set; }

        [DisplayName("Cтатус")]
        public string StatusName { get; set; }

        [DisplayName("Дата начала")]
        public DateTime? BeginDate { get; set; }

        [DisplayName("Время начала")]
        public TimeSpan? BeginTime { get; set; }

        [DisplayName("Дата окончания")]
        public DateTime? EndDate { get; set; }

        [DisplayName("Время окончания")]
        public TimeSpan? EndTime { get; set; }

        [DisplayName("Повторяемость")]
        [Required]
        public bool IsRepeat { get; set; }

        [DisplayName("Дни")]
        public int? RepeatIntervalDays { get; set; }

        [DisplayName("Недели")]
        public int? RepeatIntervalWeeks { get; set; }

        [DisplayName("Месяцы")]
        public int? RepeatIntervalMonths { get; set; }

        [DisplayName("Годы")]
        public int? RepeatIntervalYears { get; set; }

        public List<TaskKindDTO> Kinds { get; set; }

        public List<TaskStatusDTO> Statuses { get; set; }


        public TaskModel()
        {
            
        }

        public TaskModel(List<TaskKindDTO> Kinds, List<TaskStatusDTO> Statuses)
        {
            this.Kinds = Kinds;
            this.Statuses = Statuses;
        }

        public TaskModel(Business_Logic_Layer.DTO.TaskDTO t, List<TaskKindDTO> Kinds, List<TaskStatusDTO> Statuses)
        {
            Id = t.Id;
            Name = t.Name;
            Description = t.Description;
            StatusId = t.StatusId;
            KindId = t.KindId;
            BeginDate = t.BeginDate;
            BeginTime = t.BeginTime;
            EndDate = t.EndDate;
            EndTime = t.EndTime;
            IsRepeat = t.IsRepeat;
            RepeatIntervalDays = t.RepeatIntervalDays;
            RepeatIntervalMonths = t.RepeatIntervalMonths;
            RepeatIntervalWeeks = t.RepeatIntervalWeeks;
            RepeatIntervalYears = t.RepeatIntervalYears;

            if (Kinds.Where(i => i.Id == t.KindId).FirstOrDefault() != null)
                KindName = Kinds.Where(i => i.Id == t.KindId).FirstOrDefault().Name;

            if (Statuses.Where(i => i.Id == t.StatusId).FirstOrDefault() != null)
                StatusName = Statuses.Where(i => i.Id == t.StatusId).FirstOrDefault().Name;

            this.Kinds = Kinds;
            this.Statuses = Statuses;
        }
    }
}