﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int AssessmentID { get; set; }
        public string Text { get; set; }
    }
}