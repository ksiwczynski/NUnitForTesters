using NUnit.Framework;
using NUnitForTesters.Parallel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitForTesters.Test.Parallel
{
	[Parallelizable(ParallelScope.Children)]
	public class HtmlTextFormatterTests
	{
		[TestCase("zbyszek")]
		[TestCase("ala")]
		[TestCase("ma")]
		[TestCase("kota")]
		public void FormatAsBoldTest(string text)
		{
			var formatter = new HtmlTextFormatter();
			StringAssert.IsMatch($"<b>{text}</b>", formatter.FormatAsBold(text));
		}

		[TestCase("zbyszek")]
		[TestCase("ala")]
		[TestCase("ma")]
		[TestCase("kota")]
		public void FormatAsItalicTest(string text)
		{
			var formatter = new HtmlTextFormatter();
			StringAssert.IsMatch($"<i>{text}</i>", formatter.FormatAsItalic(text));
		}

		[TestCase("zbyszek")]
		[TestCase("ala")]
		[TestCase("ma")]
		[TestCase("kota")]
		public void FormatAsSmallTest(string text)
		{
			var formatter = new HtmlTextFormatter();
			StringAssert.IsMatch($"<small>{text}</small>", formatter.FormatAsSmall(text));
		}

		[TestCase("zbyszek")]
		[TestCase("ala")]
		[TestCase("ma")]
		[TestCase("kota")]
		public void FormatAsDeletedTest(string text)
		{
			var formatter = new HtmlTextFormatter();
			StringAssert.IsMatch($"<del>{text}</del>", formatter.FormatAsDeleted(text));
		}

		[TestCase("zbyszek")]
		[TestCase("ala")]
		[TestCase("ma")]
		[TestCase("kota")]
		public void FormatAsSubscriptTest(string text)
		{
			var formatter = new HtmlTextFormatter();
			StringAssert.IsMatch($"<sub>{text}</sub>", formatter.FormatAsSubscript(text));
		}

		[TestCase("zbyszek", "picca")]
		[TestCase("ala", "kota")]
		[TestCase("ma", "aka")]
		[TestCase("kota", "ma")]
		public void FormatAsCustomTagTest(string text, string customTag)
		{
			var formatter = new HtmlTextFormatter();
			StringAssert.IsMatch($"<{customTag}>{text}</{customTag}>", formatter.FormatAsCustomTag(text, customTag));
		}

		[TearDown]
		public void TearDown()
		{
			Thread.Sleep(1500);
		}
	}
}
