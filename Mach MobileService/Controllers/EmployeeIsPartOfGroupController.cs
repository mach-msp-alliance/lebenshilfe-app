﻿using Mach_MobileService.DataObjects;
using Mach_MobileService.Models;
using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;

namespace Mach_MobileService.Controllers
{
    public class EmployeeIsPartOfGroupController : TableController<EmployeeIsPartOfGroup>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<EmployeeIsPartOfGroup>(context, Request, Services);
        }

        // GET tables/TodoItem
        public IQueryable<EmployeeIsPartOfGroup> GetAllTodoItems()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<EmployeeIsPartOfGroup> GetTodoItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<EmployeeIsPartOfGroup> PatchTodoItem(string id, Delta<EmployeeIsPartOfGroup> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostTodoItem(EmployeeIsPartOfGroup item)
        {
            EmployeeIsPartOfGroup current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTodoItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}
