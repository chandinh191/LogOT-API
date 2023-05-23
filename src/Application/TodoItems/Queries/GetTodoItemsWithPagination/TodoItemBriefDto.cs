using LogOT.Application.Common.Mappings;
using LogOT.Domain.Entities;
using LogOT.Domain.Entities;

namespace LogOT.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; init; }

    public int ListId { get; init; }

    public string? Title { get; init; }

    public bool Done { get; init; }
}
