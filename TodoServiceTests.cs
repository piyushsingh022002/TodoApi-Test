using TodoApi.Models;
using TodoApi.Services;
using Xunit;

namespace TodoApi.Tests;

public class TodoServiceTests
{
    private readonly TodoService _service;

    public TodoServiceTests()
    {
        _service = new TodoService();
    }

    [Fact]
    public void Add_ShouldIncreaseCount()
    {
        var item = new TodoItem { Id = 1, Title = "Test", IsCompleted = false };
        _service.Add(item);

        var all = _service.GetAll();
        Assert.Single(all);
        Assert.Equal("Test", all[0].Title);
    }

    [Fact]
    public void GetById_ShouldReturnItem()
    {
        var item = new TodoItem { Id = 2, Title = "Task 2", IsCompleted = false };
        _service.Add(item);

        var result = _service.GetById(2);
        Assert.NotNull(result);
        Assert.Equal("Task 2", result.Title);
    }

    [Fact]
    public void Delete_ShouldRemoveItem()
    {
        var item = new TodoItem { Id = 3, Title = "Delete Me", IsCompleted = false };
        _service.Add(item);

        var deleted = _service.Delete(3);
        var all = _service.GetAll();

        Assert.True(deleted);
        Assert.Empty(all);
    }
}
