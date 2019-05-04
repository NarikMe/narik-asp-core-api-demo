using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;

namespace NarikDemo.Modules.Demo._Department
{
    public partial class DepartmentController
    {
        public IQueryable<NarikDto> GetForSelector()
        {
            return DomainService.GetEntityList<Department, NarikDto>();
        }
    }
}
