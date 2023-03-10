using Microsoft.AspNetCore.Mvc;
using BussinesLayer.Concreate;
using DataAccessLayer.EntityFramework;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values); 
        }
    }
}
 