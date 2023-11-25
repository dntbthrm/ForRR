using System.Collections.Generic;
using ForRR.DataModel;

namespace ForRR.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem { Description = "Watch Magnificent Century" },
            new ToDoItem { Description = "Buy some jewellery" }
        };
    }
}