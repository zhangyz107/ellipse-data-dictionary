﻿using System.Collections.Generic;
using Ellipse.DataDictionary.Models;
using Ellipse.DataDictionary.Readers;

namespace Ellipse.DataDictionary.Parsers
{
    public class HierarchyParser : IModelParser
    {
        private readonly IModelParser modelParser;
        private readonly IModelParser childrenParser;

        public HierarchyParser(IModelParser modelParser, params IModelParser[] childrenParser)
        {
            this.modelParser = modelParser;
            this.childrenParser = new CombinationParser(childrenParser);
        }

        public bool Matches(IReader reader)
        {
            if (modelParser.Matches(reader))
            {
                return true;
            }
            return false;
        }

        public IModel Parse(IReader reader)
        {
            IModel currentModel = modelParser.Parse(reader);
            IModel childModel = childrenParser.Parse(reader);
            
            List<IModel> children = new List<IModel>();
            while (childModel != null)
            {
                children.Add(childModel);
                childModel = childrenParser.Parse(reader);
            }

            return children.Count == 0 ? currentModel : new HierarchyModel(currentModel, children.ToArray());
        }
    }
}