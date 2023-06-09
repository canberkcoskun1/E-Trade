﻿using ETrade.Core;
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
    public class CatRepos : BaseRepository<Categories>, ICatRepos
    {
        public CatRepos(Context context) : base(context)
        {

        }

        public List<CategoriesDTO> GetCategories()
        {
            return Set().Select(x => new CategoriesDTO
            {
                CategoryName = x.CategoryName,
                Id = x.CategoryId,
            }).ToList();
        }
    }
}
