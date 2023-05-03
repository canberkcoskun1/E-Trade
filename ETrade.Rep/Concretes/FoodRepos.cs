using ETrade.Core;
using ETrade.Dal;
using ETrade.DTO;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
	public class FoodRepos : BaseRepository<Foods>, IFoodRepos
	{
		public FoodRepos(Context context) : base(context)
		{

		}

        //public List<FoodsDTO> GetFoods()
        //{
        //    return Set().Select(x => new FoodsDTO
        //    {
        //        Id = x.Id,
        //        CategoryName = x.Categories.CategoryName,
                
                
        //    }).ToList();
        //}

        
    }
}
