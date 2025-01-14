﻿using QuizMaster.Library.Common.Entities.Accounts;
using QuizMaster.Library.Common.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace QuizMaster.Library.Common.Entities.Questionnaire
{
    public class QuestionDetail: IEntity
    {
        [Key]
        public int QDetailId { get; set; }

        [Required]
        public string QDetailDesc { get; set; }

        [Required]
        public Question Question { get; set; }

        [Required]
        public bool ActiveData { get; set; } = true;
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [AllowNull]
        public DateTime DateUpdated { get; set; }
        [Required]
        public UserAccount CreatedByUser { get; set; }
        [AllowNull]
        public UserAccount UpdatedByUser { get; set; }
    }
}
