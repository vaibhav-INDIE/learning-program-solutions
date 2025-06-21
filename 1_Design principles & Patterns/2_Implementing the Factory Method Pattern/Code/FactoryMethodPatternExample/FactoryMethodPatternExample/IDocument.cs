using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample_
{
    public interface IDocument
    {
        void Create();
        void Initialize();
        void Show();
    }
}
