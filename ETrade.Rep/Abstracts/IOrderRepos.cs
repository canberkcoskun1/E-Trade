using ETrade.Core;
using ETrade.Ent;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Abstracts
{
    public interface IOrderRepos : IBaseRepository<Orders>
    {
        List<Orders> GetOrders(Guid Id);
    }
}
