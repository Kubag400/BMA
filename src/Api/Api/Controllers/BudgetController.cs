using Api.Domain;
using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class BudgetController : ControllerBase
{
    private IBudgetRepository _budgetRepository;
    public BudgetController(IBudgetRepository budgetRepository)
    {
        _budgetRepository = budgetRepository;
    }
    
    [HttpGet(ApiRoutes.BudgetPath.GetBudget)]
    public async Task<int> Index()
    {
        return await _budgetRepository.ELO();
    }
}