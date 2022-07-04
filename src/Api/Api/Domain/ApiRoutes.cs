namespace Api.Domain;

public class ApiRoutes
{
    public const string Root = "api/";
    public const string Version = "v1/";
    public const string Base = Root + Version;

    public static class BudgetPath
    {
        private const string _controllerName = Base + "budget/";

        public const string GetBudget = _controllerName + "getbudget";
    }
}