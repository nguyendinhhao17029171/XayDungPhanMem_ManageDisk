﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Titles
{
    public class TitleToReserveDto
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }
    }
}
