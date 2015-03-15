﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator
{
    abstract class TypeBase
    {
        public string Name { get; set; } = "vec";
        public string BaseType { get; set; } = "float";
        public abstract string ClassName { get; }

        public IEnumerable<string> CSharpFile
        {
            get
            {
                yield return "using System;";
                yield return "using System.Collections.Generic;";
                yield return "using System.Linq;";
                yield return "namespace GlmSharp";
                yield return "{";
                yield return "    [Serializable]";
                yield return "    public struct " + ClassName;
                yield return "    {";
                foreach (var line in Body)
                    yield return line.Indent(2);
                yield return "    }";
                yield return "}";
            }
        }

        protected abstract IEnumerable<string> Body { get; }
    }
}