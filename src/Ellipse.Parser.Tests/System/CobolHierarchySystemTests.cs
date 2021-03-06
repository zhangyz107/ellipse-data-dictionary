﻿using Ellipse.DataDictionary.Models;
using Ellipse.DataDictionary.Parsers;
using Ellipse.DataDictionary.Parsers.Cobol;
using NUnit.Framework;

namespace Ellipse.DataDictionary.System
{
    [TestFixture]
    public class CobolHierarchySystemTests : ParserTestFixture<EmptyParser>
    {
        public CobolHierarchySystemTests() :base(CobolParser.CobolHierarchy)
        {
        }

        [Test]
        public void MSF000_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF000-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF001_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF001-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF002_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF002-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF003_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF003-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF004_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF004-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF005_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF005-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF006_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF006-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF007_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF007-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF008_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF008-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF010_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF010-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF011_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF011-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF012_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF012-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF013_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF013-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF014_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF014-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF015_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF015-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF016_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF016-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF017_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF017-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF018_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF018-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF019_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF019-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF01A_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF01A-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF01B_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF01B-RECORD.rpt");
            SaveAsXml(model);
        }

        /// <summary>
        /// MSF023 has errors in the structure where an extra space needs to be added to some lines to make them valid
        /// </summary>
        [Test]
        public void MSF023_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF023-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSF062_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSF062-RECORD.rpt");
            SaveAsXml(model);
        }

        [Test]
        public void MSW000_RECORD()
        {
            IModel model = ParseHierarchicalFile(@".\Resources\Cobol\MSW000-RECORD.rpt");
            SaveAsXml(model);
        }

    }
}