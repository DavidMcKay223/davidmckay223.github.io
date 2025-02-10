using MyApp.Application.DTOs.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Interfaces.Food
{
    public interface IGeneratorPdf
    {
        public Task RecipeListDownloadPdfAsync(string fileName, List<RecipeDto> recipeIdList);
    }
}
