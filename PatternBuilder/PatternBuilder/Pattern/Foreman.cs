using PatternBuilder.Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Pattern
{
    public class Foreman
    {
        private IBuilder _builder;

        public Foreman(IBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            this._builder.BuildBasement();
            this._builder.BuildStorey();
            this._builder.BuildRoof();
        }
    }
}
