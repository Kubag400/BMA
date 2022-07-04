using Api.Interfaces;

namespace Api.Repository;

public class BudgetRepository: IBudgetRepository
{
    public async Task<int> ELO()
    {
        return  5;
    }
}