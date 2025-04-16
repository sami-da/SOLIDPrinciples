using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Exemple_01.After
{
    // Base interface for all discounts
    public interface IDiscount
    {
        bool CanApplyDiscount(decimal originalPrice);
        decimal ApplyDiscount(decimal originalPrice);
    }
}
