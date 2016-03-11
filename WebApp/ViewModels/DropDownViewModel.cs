﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;
using Newtonsoft.Json;

namespace WebApp.ViewModels
{
    public class DropDownViewModel
    {
        public int Id { get; set; }

        [JsonIgnore]
        public IEnumerable<SelectListItem> Items { get; set; }

        [JsonIgnore]
        public string SelectedText
        {
            get { return Items?.FirstOrDefault(x => x.Value == Id.ToString())?.Text ?? string.Empty; }
        }
    }
}