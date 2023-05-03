﻿using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class PropertiesRepos : BaseRepository<Properties>, IPropertiesRepos
    {
        public PropertiesRepos(Context context) : base(context)
        {
        }
    }
}
