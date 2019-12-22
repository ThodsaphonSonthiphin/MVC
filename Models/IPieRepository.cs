using System;
using System.Collections.Generic;
using System.Linq;
namespace LiuPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieID);
    }
}
