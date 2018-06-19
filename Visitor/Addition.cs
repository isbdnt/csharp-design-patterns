using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Addition : IExpression
    {
        internal IExpression Left { get; set; }
        internal IExpression Right { get; set; }

        public Addition(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
