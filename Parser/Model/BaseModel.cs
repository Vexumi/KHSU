﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Model
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
