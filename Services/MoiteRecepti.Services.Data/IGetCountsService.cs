namespace MoiteRecepti.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MoiteRecepti.Services.Data.Models;
    using MoiteRecepti.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        // 1. Use the view model
        // 2. Create DTO -> view model
        // 3. Tuples

        CountsDto GetCounts();

        // 1 IndexViewModel GetCounts();
        // 2 CountsDto GetCounts();
        // 3 (int IngredientsCount, int RecipesCount, int CategoriesCount, int ImagesCount) GetCounts();
    }
}
