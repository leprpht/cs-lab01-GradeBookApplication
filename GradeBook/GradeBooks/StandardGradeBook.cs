﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Name = name;
            Type = GradeBookType.Standard;
            IsWeighted = isWeighted;
        }
    }
}
