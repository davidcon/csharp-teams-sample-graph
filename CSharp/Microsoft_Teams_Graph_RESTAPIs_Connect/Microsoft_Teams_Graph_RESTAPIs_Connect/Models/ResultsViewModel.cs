﻿/* 
*  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. 
*  See LICENSE in the source repository root for complete license information. 
*/


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Microsoft_Teams_Graph_RESTAPIs_Connect.Models
{


    // View model to display a collection of one or more entities returned from the Microsoft Graph. 
    public class ResultsViewModel
    {
        // The list of entities to display.
        public IEnumerable<ResultsItem> Items { get; set; }
        public ResultsViewModel()
        {
            Items = Enumerable.Empty<ResultsItem>();
        }
    }

    public class FormOutput
    {
        public string Id { get; set; }
        public Team[] Teams { get; set; }
        //public SelectListItem[] Teams { get; set; }

        [Display(Name = "Favorite Flavor")]
        public int SelectedTeam { get; set; }

        public IEnumerable<SelectListItem> FlavorItems
        {
            get { return new SelectList(Teams, "id", "name"); }
        }

        public bool ShowTeamList { get; set; } = false;
    }
}